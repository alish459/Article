using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article
{
    class AuthorDefinition : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private PersianUI.TextBoxes.TextBox txtAuthorName;
        private System.Windows.Forms.GroupBox groupBox3;
        private PersianUI.OtherControls.Checkbox chkTranslate;
        private PersianUI.OtherControls.Checkbox chkNews;
        private PersianUI.OtherControls.Checkbox chkArticle;
        private Label label3;
        private PersianUI.TextBoxes.TextBox textBox2;
        private Label label2;
        private PersianUI.TextBoxes.TextBox textBox1;
        private Label label7;
        private Label label6;
        private PersianUI.TextBoxes.TextBox textBox5;
        private Label label5;
        private PersianUI.TextBoxes.TextBox textBox4;
        private Label label4;
        private PersianUI.TextBoxes.TextBox textBox3;
        private PersianUI.TextBoxes.NumericTextBox numericTextBox1;
        private Label label8;
        private PersianUI.TextBoxes.NumericTextBoxWithSeperator numericTextBoxWithSeperator3;
        private Label label11;
        private PersianUI.TextBoxes.NumericTextBoxWithSeperator numericTextBoxWithSeperator2;
        private Label label10;
        private PersianUI.TextBoxes.NumericTextBoxWithSeperator numericTextBoxWithSeperator1;
        private Label label9;
        private PersianUI.OtherControls.DataGridView dataGridView1;
        private PersianUI.TextBoxes.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        public AuthorDefinition()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTranslate = new PersianUI.OtherControls.Checkbox();
            this.chkNews = new PersianUI.OtherControls.Checkbox();
            this.chkArticle = new PersianUI.OtherControls.Checkbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorName = new PersianUI.TextBoxes.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new PersianUI.TextBoxes.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new PersianUI.TextBoxes.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new PersianUI.TextBoxes.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new PersianUI.TextBoxes.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new PersianUI.TextBoxes.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericTextBox1 = new PersianUI.TextBoxes.NumericTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericTextBoxWithSeperator1 = new PersianUI.TextBoxes.NumericTextBoxWithSeperator();
            this.numericTextBoxWithSeperator2 = new PersianUI.TextBoxes.NumericTextBoxWithSeperator();
            this.label10 = new System.Windows.Forms.Label();
            this.numericTextBoxWithSeperator3 = new PersianUI.TextBoxes.NumericTextBoxWithSeperator();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new PersianUI.TextBoxes.TextBox();
            this.dataGridView1 = new PersianUI.OtherControls.DataGridView();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(884, 200);
            this.pnlTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericTextBoxWithSeperator3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericTextBoxWithSeperator2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericTextBoxWithSeperator1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericTextBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAuthorName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعريف نويسنده";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chkTranslate);
            this.groupBox3.Controls.Add(this.chkNews);
            this.groupBox3.Controls.Add(this.chkArticle);
            this.groupBox3.Location = new System.Drawing.Point(274, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "گروه هاي فعال";
            // 
            // chkTranslate
            // 
            this.chkTranslate.AutoSize = true;
            this.chkTranslate.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkTranslate.Font = new System.Drawing.Font("IRANSans", 10F);
            this.chkTranslate.Location = new System.Drawing.Point(28, 26);
            this.chkTranslate.Name = "chkTranslate";
            this.chkTranslate.NextControl = null;
            this.chkTranslate.Size = new System.Drawing.Size(62, 28);
            this.chkTranslate.TabIndex = 2;
            this.chkTranslate.Text = "ترجمه";
            this.chkTranslate.UseVisualStyleBackColor = true;
            // 
            // chkNews
            // 
            this.chkNews.AutoSize = true;
            this.chkNews.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkNews.Font = new System.Drawing.Font("IRANSans", 10F);
            this.chkNews.Location = new System.Drawing.Point(90, 26);
            this.chkNews.Name = "chkNews";
            this.chkNews.NextControl = null;
            this.chkNews.Size = new System.Drawing.Size(53, 28);
            this.chkNews.TabIndex = 1;
            this.chkNews.Text = "اخبار";
            this.chkNews.UseVisualStyleBackColor = true;
            // 
            // chkArticle
            // 
            this.chkArticle.AutoSize = true;
            this.chkArticle.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkArticle.Font = new System.Drawing.Font("IRANSans", 10F);
            this.chkArticle.Location = new System.Drawing.Point(143, 26);
            this.chkArticle.Name = "chkArticle";
            this.chkArticle.NextControl = null;
            this.chkArticle.Size = new System.Drawing.Size(66, 28);
            this.chkArticle.TabIndex = 0;
            this.chkArticle.Text = "مقالات";
            this.chkArticle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام و نام خانوادگي :";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthorName.BackColor = System.Drawing.Color.White;
            this.txtAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthorName.Font = new System.Drawing.Font("IRANSans", 10F);
            this.txtAuthorName.ForeColor = System.Drawing.Color.Black;
            this.txtAuthorName.Location = new System.Drawing.Point(499, 24);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(10);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.NextControl = null;
            this.txtAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAuthorName.Size = new System.Drawing.Size(258, 30);
            this.txtAuthorName.TabIndex = 0;
            this.txtAuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 416);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(884, 45);
            this.pnlFooter.TabIndex = 1;
            this.pnlFooter.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 216);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 216);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ليست نويسنده ها";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "شماره كارت :";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("IRANSans", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(499, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.NextControl = null;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(258, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "شماره تلفن :";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("IRANSans", 10F);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(13, 24);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10);
            this.textBox2.Name = "textBox2";
            this.textBox2.NextControl = null;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(166, 30);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "نام بانك :";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("IRANSans", 10F);
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(274, 62);
            this.textBox3.Margin = new System.Windows.Forms.Padding(10);
            this.textBox3.Name = "textBox3";
            this.textBox3.NextControl = null;
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(136, 30);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "شماره حساب :";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("IRANSans", 10F);
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(13, 62);
            this.textBox4.Margin = new System.Windows.Forms.Padding(10);
            this.textBox4.Name = "textBox4";
            this.textBox4.NextControl = null;
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(166, 30);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(765, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "ايميل :";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("IRANSans", 10F);
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(499, 100);
            this.textBox5.Margin = new System.Windows.Forms.Padding(10);
            this.textBox5.Name = "textBox5";
            this.textBox5.NextControl = null;
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox5.Size = new System.Drawing.Size(258, 30);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "تعداد پرونده :";
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTextBox1.BackColor = System.Drawing.Color.White;
            this.numericTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericTextBox1.Enabled = false;
            this.numericTextBox1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.numericTextBox1.ForeColor = System.Drawing.Color.Black;
            this.numericTextBox1.Location = new System.Drawing.Point(274, 100);
            this.numericTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.NextControl = null;
            this.numericTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericTextBox1.Size = new System.Drawing.Size(136, 29);
            this.numericTextBox1.TabIndex = 15;
            this.numericTextBox1.Text = "0";
            this.numericTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(3, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(878, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "توضيحات تكميلي :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(765, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "هزينه مقاله :";
            // 
            // numericTextBoxWithSeperator1
            // 
            this.numericTextBoxWithSeperator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTextBoxWithSeperator1.BackColor = System.Drawing.Color.White;
            this.numericTextBoxWithSeperator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericTextBoxWithSeperator1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.numericTextBoxWithSeperator1.ForeColor = System.Drawing.Color.Black;
            this.numericTextBoxWithSeperator1.Location = new System.Drawing.Point(611, 138);
            this.numericTextBoxWithSeperator1.Margin = new System.Windows.Forms.Padding(10);
            this.numericTextBoxWithSeperator1.Name = "numericTextBoxWithSeperator1";
            this.numericTextBoxWithSeperator1.NextControl = null;
            this.numericTextBoxWithSeperator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericTextBoxWithSeperator1.Size = new System.Drawing.Size(146, 29);
            this.numericTextBoxWithSeperator1.TabIndex = 18;
            this.numericTextBoxWithSeperator1.Text = "0";
            this.numericTextBoxWithSeperator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericTextBoxWithSeperator2
            // 
            this.numericTextBoxWithSeperator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTextBoxWithSeperator2.BackColor = System.Drawing.Color.White;
            this.numericTextBoxWithSeperator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericTextBoxWithSeperator2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.numericTextBoxWithSeperator2.ForeColor = System.Drawing.Color.Black;
            this.numericTextBoxWithSeperator2.Location = new System.Drawing.Point(388, 138);
            this.numericTextBoxWithSeperator2.Margin = new System.Windows.Forms.Padding(10);
            this.numericTextBoxWithSeperator2.Name = "numericTextBoxWithSeperator2";
            this.numericTextBoxWithSeperator2.NextControl = null;
            this.numericTextBoxWithSeperator2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericTextBoxWithSeperator2.Size = new System.Drawing.Size(136, 29);
            this.numericTextBoxWithSeperator2.TabIndex = 20;
            this.numericTextBoxWithSeperator2.Text = "0";
            this.numericTextBoxWithSeperator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "هزينه اخبار :";
            // 
            // numericTextBoxWithSeperator3
            // 
            this.numericTextBoxWithSeperator3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTextBoxWithSeperator3.BackColor = System.Drawing.Color.White;
            this.numericTextBoxWithSeperator3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericTextBoxWithSeperator3.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.numericTextBoxWithSeperator3.ForeColor = System.Drawing.Color.Black;
            this.numericTextBoxWithSeperator3.Location = new System.Drawing.Point(117, 138);
            this.numericTextBoxWithSeperator3.Margin = new System.Windows.Forms.Padding(10);
            this.numericTextBoxWithSeperator3.Name = "numericTextBoxWithSeperator3";
            this.numericTextBoxWithSeperator3.NextControl = null;
            this.numericTextBoxWithSeperator3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericTextBoxWithSeperator3.Size = new System.Drawing.Size(176, 29);
            this.numericTextBoxWithSeperator3.TabIndex = 22;
            this.numericTextBoxWithSeperator3.Text = "0";
            this.numericTextBoxWithSeperator3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "هزينه ترجمه :";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Font = new System.Drawing.Font("IRANSans", 10F);
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(3, 26);
            this.textBox6.Margin = new System.Windows.Forms.Padding(10);
            this.textBox6.Name = "textBox6";
            this.textBox6.NextControl = null;
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox6.Size = new System.Drawing.Size(878, 30);
            this.textBox6.TabIndex = 1;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("IRANSans", 12F);
            this.dataGridView1.Location = new System.Drawing.Point(3, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(878, 157);
            this.dataGridView1.TabIndex = 2;
            // 
            // AuthorDefinition
            // 
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "AuthorDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
