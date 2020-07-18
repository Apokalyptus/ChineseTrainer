using System;
using System.Data;
using System.Windows.Forms;

namespace ChineseTrainer
{
    public partial class PropEditor: Form
    {
        public PropEditor()
        {
            InitializeComponent();
        }

        private void PropEditor_Load( object sender, EventArgs e )
        {
            try
            {
                config2.ReadXml( "Configuration.xml" );
            } catch( Exception )
            {
                MessageBox.Show( "Configuration does not exist, please configure first (Menue: Config)!" );
                DataRow dr = config2.Tables["Config"].NewRow();
                dr["ChapterSelection"] = "ALL";
                dr["Chapter"] = "";
                dr["Sequence"] = "RANDOM";
                dr["ShowHideTime"] = "3000";
                dr["FadeTime"] = "100";

                config2.Tables["Config"].Rows.Add( dr );
            }

            if( config2.Tables["Config"].Rows[0]["ChapterSelection"].ToString() == "ALL" )
            {
                rbChoiceAll.Checked = true;
            } else
            {
                rbChoiceSelection.Checked = true;
                tbChapterList.Text = config2.Tables["Config"].Rows[0]["Chapter"].ToString();
            }

            if( config2.Tables["Config"].Rows[0]["Sequence"].ToString() == "RANDOM" )
            {
                rbRandom.Checked = true;
            } else
            {
                rbSequence.Checked = true;
            }

            tbShowHideTime.Text = config2.Tables["Config"].Rows[0]["ShowHideTime"].ToString();
            tbFadeTime.Text = config2.Tables["Config"].Rows[0]["FadeTime"].ToString();
        }

        private void ChapterSelected( object sender, EventArgs e )
        {
            tbChapterList.ReadOnly = false;
            config2.Tables["Config"].Rows[0]["ChapterSelection"] = "CHAPTER";
        }

        private void AllSelected( object sender, EventArgs e )
        {
            tbChapterList.ReadOnly = true;
            config2.Tables["Config"].Rows[0]["ChapterSelection"] = "ALL";
        }

        private void ChapterTextChanged( object sender, EventArgs e )
        {
            config2.Tables["Config"].Rows[0]["Chapter"] = tbChapterList.Text;
        }

        private void SaveConfiguration( object sender, EventArgs e )
        {
            config2.WriteXml( "Configuration.xml" );
            this.Dispose();
        }

        private void ChoseRandom( object sender, EventArgs e )
        {
            config2.Tables["Config"].Rows[0]["Sequence"] = "RANDOM";
        }

        private void ChoseSequence( object sender, EventArgs e )
        {
            config2.Tables["Config"].Rows[0]["Sequence"] = "SEQUENCE";
        }

        private void ChangedShowHideTime( object sender, EventArgs e )
        {
            config2.Tables["Config"].Rows[0]["ShowHideTime"] = tbShowHideTime.Text;
        }

        private void ChangedFadeInOutTime( object sender, EventArgs e )
        {
            config2.Tables["Config"].Rows[0]["FadeTime"] = tbFadeTime.Text;
        }
    }
}