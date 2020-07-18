using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ChineseTrainer
{
    public partial class ChineseTrainer: Form
    {
        private bool up;            // indicates the direction of fade
        private bool isRunning;    // indicates whether its in start or stop mode
        private Rectangle rect;
        private long evenOddCounter = 0;
        private int vocCount = 0;
        private int vocPointer = 0;
        private int[] vocOrderList;
        private static readonly Random rng = new Random();
        private static readonly Random rtm = new Random();

        public ChineseTrainer()
        {
            InitializeComponent();
        }

        private void ChineseTrainer_Load( object sender, EventArgs e )
        {
            // Size welcome window
            tbWelcome.Size = new Size( 267, 220 );

            bool initialerror = false;
            // get Configuration
            try
            {
                config1.ReadXml( "Configuration.xml" );
            } catch( Exception )
            {
                MessageBox.Show( "Configuration does not exist, I use default!" );
                DataRow dr = config1.Tables["Config"].NewRow();
                dr["ChapterSelection"] = "ALL";
                dr["Chapter"] = "";
                dr["Sequence"] = "RANDOM";
                dr["ShowHideTime"] = "3000";
                dr["FadeTime"] = "100";

                config1.Tables["Config"].Rows.Add( dr );
                config1.WriteXml( "Configuration.xml" );
            }
            // get Vocabulary
            try
            {
                dataSet1.ReadXml( "Vocabulary.xml" );
            } catch( Exception )
            {
                MessageBox.Show( "Vocabulary does not exist, please enter first (Menue: Database)!" );
                initialerror = true;
            }

            toolStripComboBox1.ComboBox.SelectedItem = "off";
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Hey, cooool";
       
            rect = Screen.GetWorkingArea( this );
            int diff = Screen.PrimaryScreen.Bounds.Height - rect.Height;
            this.Location = new Point( Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height - this.Size.Height - diff );

            this.Opacity = 0;
            up = true;

            if( !initialerror )
            {
                isRunning = true;
                timer1.Enabled = true;
                timer2.Enabled = false;
                mDatabase.Enabled = false;
                mConfig.Enabled = false;
                tbChinese.Text = "";
                tbPinyin.Text = "";
                tbGerman.Text = "";
                tbWelcome.Text = "\r\nWelcome\r\nto\r\nChineseTrainer";
                PrepareVocList();
            } else
            {
                isRunning = false;
                mStartStop.Text = "Start";
                mDatabase.Enabled = true;
                mConfig.Enabled = true;
            }

            Debug.Write( "Load\n" );
        }

        private void PrepareVocList()
        {
            // if chapter has chosen
            if( config1.Tables["Config"].Rows[0]["ChapterSelection"].ToString() == "CHAPTER" )
            {
                // get chapters
                String chapters = config1.Tables["Config"].Rows[0]["Chapter"].ToString();
                chapters.Trim();

                ArrayList chaptlist = new ArrayList();

                foreach( String s in chaptlist )
                {
                    if( System.Text.RegularExpressions.Regex.IsMatch( s, "^\\d+$" ) )
                        chaptlist.Add( s );
                }

                // create dynamically a statement OR statement OR ...
                String res = "";
                for( int i = 0; i < chaptlist.Count; i++ )
                {
                    res += "(Chapter = " + chaptlist[i].ToString() + ")";
                    if( i < chaptlist.Count - 1 )
                        res += " OR ";
                }
                Debug.Write( res + "\r\n" );

                DataRow[] resultrow = dataSet1.Vokabeln.Select(res);
                // Make a list with the entries in the table that are wanted.

                DataSet ds = dataSet1.Clone();
                DataTable tb = ds.Tables["Vokabeln"];

                foreach( DataRow dr in resultrow )
                {
                    tb.ImportRow( dr );
                }
                // and set this list instead the whole list
                dataSet1 = (global::ChineseTrainer.Properties.DataSources.Vocabulary)ds;
            }

            // create a list of numbers in that the entrys should appear ...
            vocCount = dataSet1.Tables["Vokabeln"].Rows.Count;
            if( vocCount > 0 )
            {
                vocOrderList = new int[vocCount];

                for( int i = 0; i < vocCount; i++ )
                {
                    vocOrderList[i] = i;
                }
            }

            // if wanted, randomize them.
            if( config1.Tables["Config"].Rows[0]["Sequence"].ToString() == "RANDOM" )
            {
                for( int i = vocCount - 1; i > 0; i-- )
                {
                    int swapindex = rng.Next(i + 1);
                    if( swapindex != i )
                    {
                        int tmp = vocOrderList[swapindex];
                        vocOrderList[swapindex] = vocOrderList[i];
                        vocOrderList[i] = tmp;
                    }
                }
            }
        }

        private void FadeInOutTimer( object sender, EventArgs e )
        {
            if( (this.Opacity > 0.0f) && (up == false) )
            {
                this.Opacity -= 0.1f;
                Debug.Write( "down: timer2.enabled: " + timer2.Enabled + "\n" );
            } else
            if( (this.Opacity < 1.0f) && (up == true) )
            {
                this.Opacity += 0.1f;
                Debug.Write( "up: timer2.enabled: " + timer2.Enabled + "\n" );

                Debug.Write( "L: " + tbChinese.Text.Length );
            } else
            {
                timer1.Enabled = false;
                timer2.Enabled = true;

                if( up == true )
                    up = false;
                else
                    up = true;
            }
        }

        private void PauseTimer( object sender, EventArgs e )
        {
            timer1.Enabled = true;
            timer2.Enabled = false;

            if( (evenOddCounter % 2) != 0 )
            {
                Debug.Write( "Good time to change the VOC\n" );
                laPosition.Text = (vocPointer + 1).ToString() + " / " + vocCount.ToString();
                tbChinese.Text = dataSet1.Tables["Vokabeln"].Rows[vocOrderList[vocPointer]]["Chinesisch"].ToString();
                tbPinyin.Text = dataSet1.Tables["Vokabeln"].Rows[vocOrderList[vocPointer]]["Pinyin"].ToString();
                tbGerman.Text = dataSet1.Tables["Vokabeln"].Rows[vocOrderList[vocPointer]]["German"].ToString();

                // Change Font if Size bigger then TextBox

                Font f = tbChinese.Font;
                if( tbChinese.Text.Length <= 3 )
                {
                    tbChinese.Font = new Font( f.FontFamily, 60.0f );
                } else
                {
                    tbChinese.Font = new Font( f.FontFamily, 40.0f );
                }
                f = tbGerman.Font;
                if( tbGerman.Text.Length <= 17 )
                {
                    tbGerman.Font = new Font( f.FontFamily, 20.0f );
                } else
                {
                    tbGerman.Font = new Font( f.FontFamily, 15.0f );
                }
                f = tbPinyin.Font;
                if( tbPinyin.Text.Length <= 17 )
                {
                    tbPinyin.Font = new Font( f.FontFamily, 20.0f );
                } else
                {
                    tbPinyin.Font = new Font( f.FontFamily, 15.0f );
                }
                vocPointer++;
                if( vocPointer == vocCount )
                    vocPointer = 0;
                tbWelcome.Visible = false;

                // Randomize Trainingmode

                if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "Random G/P" )
                {
                    if( (rtm.Next() % 2) == 0 )
                    {
                        tbChinese.Visible = true;
                        tbGerman.Visible = false;
                        tbPinyin.Visible = true;
                    } else
                    {
                        tbChinese.Visible = true;
                        tbGerman.Visible = true;
                        tbPinyin.Visible = false;
                    }
                }
            }
            evenOddCounter++;
        }

        private void Exit( object sender, EventArgs e )
        {
            notifyIcon1.Dispose();
            this.Dispose();
        }

        private void StartStop( object sender, EventArgs e )
        {
            if( isRunning == true ) //dann ausschalten
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                mStartStop.Text = "Start";
                isRunning = false;
                this.Visible = false;
                mDatabase.Enabled = true;
                mConfig.Enabled = true;
                this.TopMost = false;
            } else // einschalten
            {
                try
                {
                    // reload Vocabulary, maby it changed
                    dataSet1.Clear();
                    dataSet1.ReadXml( "Vocabulary.xml" );
                } catch( Exception )
                {
                    MessageBox.Show( "Vocabulary does not exist, please enter first (Menue: Database)!" );
                    return;
                }
                this.Opacity = 0;
                up = true;
                evenOddCounter = 0;
                vocPointer = 0;
                PrepareVocList();
                mDatabase.Enabled = false;
                mConfig.Enabled = false;
                timer1.Enabled = true;
                timer2.Enabled = false;
                timer1.Start();
                timer2.Start();
                mStartStop.Text = "Stop";
                isRunning = true;
                this.Visible = true;
                this.TopMost = true;
            }
        }

        private void ShowVocabularyEditorDialog( object sender, EventArgs e )
        {
            Form f = new VocEditor();
            f.ShowDialog( this );
        }

        private void ShowAboutDialog( object sender, EventArgs e )
        {
            MessageBox.Show( "ChineseTrainer\r\nby\r\nJoern Notbom 2008" );
        }

        private void ShowConfigurationDialog( object sender, EventArgs e )
        {
            Form f = new PropEditor();
            f.ShowDialog( this );
        }

        private void ChangeTrainigMode( object sender, EventArgs e )
        {
            if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "off" )
            {
                tbChinese.Visible = true;
                tbGerman.Visible = true;
                tbPinyin.Visible = true;
            } else if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "HanZi" )
            {
                tbChinese.Visible = false;
                tbGerman.Visible = true;
                tbPinyin.Visible = true;
            } else if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "PinYin" )
            {
                tbChinese.Visible = true;
                tbGerman.Visible = true;
                tbPinyin.Visible = false;
            } else if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "German" )
            {
                tbChinese.Visible = true;
                tbGerman.Visible = false;
                tbPinyin.Visible = true;
            } else if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "Random G/P" )
            {
                tbChinese.Visible = true;
                tbGerman.Visible = true;
                tbPinyin.Visible = true;
            }
        }

        private void ChineseTrainer_KeyDown( object sender, KeyEventArgs e )
        {
            tbChinese.Visible = true;
            tbGerman.Visible = true;
            tbPinyin.Visible = true;
        }

        private void ChineseTrainer_KeyUp( object sender, KeyEventArgs e )
        {
            if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "off" )
            {
                tbChinese.Visible = true;
                tbGerman.Visible = true;
                tbPinyin.Visible = true;
            } else if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "HanZi" )
            {
                tbChinese.Visible = false;
                tbGerman.Visible = true;
                tbPinyin.Visible = true;
            } else if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "PinYin" )
            {
                tbChinese.Visible = true;
                tbGerman.Visible = true;
                tbPinyin.Visible = false;
            } else if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "German" )
            {
                tbChinese.Visible = true;
                tbGerman.Visible = false;
                tbPinyin.Visible = true;
            } else if( toolStripComboBox1.ComboBox.SelectedItem.ToString() == "Random G/P" )
            {
                tbChinese.Visible = true;
                tbGerman.Visible = true;
                tbPinyin.Visible = true;
            }
        }
    }
}