using Microsoft.Office.Interop.Word;
using SautinSoft.Document;
using System;
//using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article
{
    public partial class MainForm : Form
    {
        private readonly char[] separators = { ' ' };
        public MainForm()
        {
            InitializeComponent();
        }
        private void ToolStripAuthor_Click(object sender, EventArgs e)
        {

            string filePath = @"D:\BackUp\It’s_FATF’s_Way_or_the_Highway_for.docx";
            MethodForCounting(filePath);
            AuthorDefinition MyForm = new AuthorDefinition();
            MyForm.ShowDialog();
        }

        private static void MethodForCounting(string filePath)
        {
            DocumentCore dc = DocumentCore.Load(filePath);
            var x = dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.Pages];
            var y = dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.Words];
            //dc.CalculateStats();
        }
        private void ToolStripCase_Click(object sender, EventArgs e)
        {
            CaseDefinition MyForm = new CaseDefinition();
            MyForm.Show();
        }
        public IDictionary<string, int> Parse(string path)
        {
            var wordCount = new Dictionary<string, int>();

            using (var fileStream = File.Open(path, FileMode.Open, FileAccess.Read))
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word] = wordCount[word] + 1;
                        }
                        else
                        {
                            wordCount.Add(word, 1);
                        }
                    }
                }
            }

            return wordCount;
        }
    }
}
