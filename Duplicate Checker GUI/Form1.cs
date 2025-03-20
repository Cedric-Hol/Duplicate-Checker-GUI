using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicate_Checker_GUI
{
    public partial class frmMain: Form
    {
        public string firstFile, secondFile;
        public frmMain()
        {
            InitializeComponent();
            pnlMain.BackColor = Color.FromArgb(32, 29, 72);
        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select a Text File";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string editedFilePath = filePath.Substring(filePath.LastIndexOf('\\') + 1);
                    txtFirstChoice.Text = editedFilePath;
                }
            }
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string editedFilePath = filePath.Substring(filePath.LastIndexOf('\\') + 1);
                    txtSecondChoice.Text = editedFilePath;
                }
            }
        }
    }
}
