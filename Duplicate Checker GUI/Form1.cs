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
                    firstFile = filePath;
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
                    secondFile = filePath;
                    string editedFilePath = filePath.Substring(filePath.LastIndexOf('\\') + 1);
                    txtSecondChoice.Text = editedFilePath;
                }
            }
        }

        private void lblDownload_Click(object sender, EventArgs e)
        {
            //Checks if the textboxes are empty if so then pushes a messagebox otherwise it goes to the Filereader
            if (!string.IsNullOrEmpty(txtFirstChoice.Text) && !string.IsNullOrEmpty(txtSecondChoice.Text) && !string.IsNullOrEmpty(txtNameFile.Text))
            {
                fileReader(firstFile, secondFile, txtNameFile.Text);
            }
            else
            {
                MessageBox.Show("Please select a file.");
            }
        }

        private async Task fileReader(string first, string second, string name)
        {
            List<string> firstItems = new List<string>();
            List<string> secondItems = new List<string>();
            List<string> finalList = new List<string>();
            const Int32 BufferSize = 512;

            using(var firstFilestream = File.OpenRead(first))
            {
                using (var streamReader = new StreamReader(firstFilestream, Encoding.UTF8, true, BufferSize))
                {
                    String line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        firstItems.Add(line);
                    }
                }
            }

            using (var secondFilestream = File.OpenRead(second))
            {
                using (var streamReader = new StreamReader(secondFilestream, Encoding.UTF8, true, BufferSize))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        secondItems.Add(line);
                    }
                }
            }

            foreach (string firstName in firstItems)
            {
                foreach (string secondName in secondItems)
                {
                    if (firstName == secondName)
                    {
                        lbBudgetConsole.Items.Add($"{firstName} - {secondName}");
                        finalList.Add($"{firstName} - {secondName}");
                        await Task.Delay(1);
                        lbBudgetConsole.TopIndex = lbBudgetConsole.Items.Count - 1;
                    }
                }
            }

            string saveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter writer = new StreamWriter($"{saveFilePath}\\{name}.txt");
            foreach(string firstItem in finalList)
            {
                writer.WriteLine(firstItem);
            }
            writer.Close();
        }
    }
}
