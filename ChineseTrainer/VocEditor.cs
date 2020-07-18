using System;
using System.Windows.Forms;

namespace ChineseTrainer
{
    public partial class VocEditor: Form
    {
        public VocEditor()
        {
            InitializeComponent();
        }

        private void SaveVocabulary( object sender, EventArgs e )
        {
            dataSet11.WriteXml( "Vocabulary.xml" );
        }

        private void Form2_Load( object sender, EventArgs e )
        {
            try
            {
                dataSet11.ReadXml( "Vocabulary.xml" );
            } catch( Exception )
            {
            }
        }

        private void Exit( object sender, EventArgs e )
        {
            this.Dispose();
        }
    }
}