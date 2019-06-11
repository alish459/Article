using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToolStripAuthor_Click(object sender, EventArgs e)
        {
            AuthorDefinition MyForm = new AuthorDefinition();
            MyForm.ShowDialog();
        }

        private void ToolStripCase_Click(object sender, EventArgs e)
        {
            CaseDefinition MyForm = new CaseDefinition();
            MyForm.Show();
        }

        private void toolStripCase_Click(object sender, EventArgs e)
        {

        }
    }
}
