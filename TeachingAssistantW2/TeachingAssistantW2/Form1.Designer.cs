namespace TeachingAssistantW2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbUsage = new System.Windows.Forms.TextBox();
            this.btnUsage = new System.Windows.Forms.Button();
            this.lstOptions = new System.Windows.Forms.ListBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtVal8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVal7 = new System.Windows.Forms.TextBox();
            this.txtVal6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtVal5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVal4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.txtVal3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(595, 652);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbUsage);
            this.tabPage1.Controls.Add(this.btnUsage);
            this.tabPage1.Controls.Add(this.lstOptions);
            this.tabPage1.Controls.Add(this.cmbType);
            this.tabPage1.Controls.Add(this.tbCategory);
            this.tabPage1.Controls.Add(this.tbSize);
            this.tabPage1.Controls.Add(this.tbRange);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Types";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbUsage
            // 
            this.tbUsage.Location = new System.Drawing.Point(22, 265);
            this.tbUsage.Multiline = true;
            this.tbUsage.Name = "tbUsage";
            this.tbUsage.Size = new System.Drawing.Size(477, 151);
            this.tbUsage.TabIndex = 10;
            // 
            // btnUsage
            // 
            this.btnUsage.Location = new System.Drawing.Point(22, 227);
            this.btnUsage.Name = "btnUsage";
            this.btnUsage.Size = new System.Drawing.Size(233, 23);
            this.btnUsage.TabIndex = 9;
            this.btnUsage.Text = "Usage Example";
            this.btnUsage.UseVisualStyleBackColor = true;
            this.btnUsage.Click += new System.EventHandler(this.btnUsage_Click);
            // 
            // lstOptions
            // 
            this.lstOptions.FormattingEnabled = true;
            this.lstOptions.Items.AddRange(new object[] {
            "int                                 -System.int",
            "float                              -System.float",
            "double                          -System.double",
            "uint32                            -System.uint32",
            "uint64                            -System.uint64",
            "char                               -System.char",
            "short                               -System.short",
            "long                                -System.long",
            "unsigned long                -System.ulong",
            "byte                                -System.byte",
            "Sbyte                              -System.Sbyte",
            "decimal                           -System.decimal",
            "boolean                           -System.Boolean"});
            this.lstOptions.Location = new System.Drawing.Point(297, 9);
            this.lstOptions.Name = "lstOptions";
            this.lstOptions.Size = new System.Drawing.Size(238, 212);
            this.lstOptions.TabIndex = 8;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "int",
            "float",
            "double",
            "uint32",
            "uint64",
            "char",
            "short",
            "long",
            "unsigned long",
            "byte",
            "Sbyte",
            "decimal",
            "boolean"});
            this.cmbType.Location = new System.Drawing.Point(103, 18);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 7;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(103, 45);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(121, 20);
            this.tbCategory.TabIndex = 6;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(103, 73);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(121, 20);
            this.tbSize.TabIndex = 5;
            // 
            // tbRange
            // 
            this.tbRange.Location = new System.Drawing.Point(103, 104);
            this.tbRange.Multiline = true;
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(121, 73);
            this.tbRange.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtVal8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtVal7);
            this.tabPage2.Controls.Add(this.txtVal6);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.richTextBox3);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Value Vs Reference";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtVal8
            // 
            this.txtVal8.Location = new System.Drawing.Point(376, 365);
            this.txtVal8.Name = "txtVal8";
            this.txtVal8.Size = new System.Drawing.Size(100, 20);
            this.txtVal8.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "personTwo.Name=";
            // 
            // txtVal7
            // 
            this.txtVal7.Location = new System.Drawing.Point(376, 170);
            this.txtVal7.Name = "txtVal7";
            this.txtVal7.Size = new System.Drawing.Size(100, 20);
            this.txtVal7.TabIndex = 9;
            // 
            // txtVal6
            // 
            this.txtVal6.Location = new System.Drawing.Point(85, 170);
            this.txtVal6.Name = "txtVal6";
            this.txtVal6.Size = new System.Drawing.Size(100, 20);
            this.txtVal6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "valTwo=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "valTwo=";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Run Code";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Run Code";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(39, 210);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(429, 96);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "Person personOne=new Person(\"Bill Clinton\");\nPerson personTwo=personOne;\npersonOn" +
    "e.Name=\"George Bush\";\n\nWhat is the value of personTwo.Name?\n";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(317, 15);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(217, 96);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "String nameOne=\"Alpha\";\nString nameTwo=nameOne;\nnameOne=\"Beta\";\n\nWhat is the valu" +
    "e of nameTwo?";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(230, 94);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "int valOne=10;\nint valTwo=valOne;\nvalOne=50;\n\nWhat is the value of valTwo?";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtVal5);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtVal4);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.richTextBox7);
            this.tabPage3.Controls.Add(this.txtVal3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.richTextBox6);
            this.tabPage3.Controls.Add(this.txtVal2);
            this.tabPage3.Controls.Add(this.txtVal1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.richTextBox5);
            this.tabPage3.Controls.Add(this.richTextBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(587, 626);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Equality";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtVal5
            // 
            this.txtVal5.Location = new System.Drawing.Point(370, 593);
            this.txtVal5.Name = "txtVal5";
            this.txtVal5.Size = new System.Drawing.Size(146, 20);
            this.txtVal5.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(263, 593);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "personTwo";
            // 
            // txtVal4
            // 
            this.txtVal4.Location = new System.Drawing.Point(416, 562);
            this.txtVal4.Name = "txtVal4";
            this.txtVal4.Size = new System.Drawing.Size(100, 20);
            this.txtVal4.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "personOne==personTwo?";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(416, 513);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Run Code";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(30, 410);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(461, 97);
            this.richTextBox7.TabIndex = 13;
            this.richTextBox7.Text = "Person personOne=new Person(\"Bill Clinton\");\nPerson personTwo=personOne;\npersonOn" +
    "e.name=\"George Bush\";\n\nWhat is the name of personTwo?";
            // 
            // txtVal3
            // 
            this.txtVal3.Location = new System.Drawing.Point(391, 352);
            this.txtVal3.Name = "txtVal3";
            this.txtVal3.Size = new System.Drawing.Size(100, 20);
            this.txtVal3.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "personOne==personTwo?";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(416, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Run Code";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(30, 189);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(461, 97);
            this.richTextBox6.TabIndex = 8;
            this.richTextBox6.Text = "Person personOne=new Person(\"Bill Clinton\");\nPerson personTwo=new Person(\"Bill Cl" +
    "inton\");\n \n\nis personOne==personTwo?";
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(424, 135);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 20);
            this.txtVal2.TabIndex = 7;
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(107, 135);
            this.txtVal1.Multiline = true;
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(82, 26);
            this.txtVal1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "nameOne==nameTwo?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "valOne==valTwo?";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(416, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Run Code";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Run Code";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(332, 6);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(159, 80);
            this.richTextBox5.TabIndex = 1;
            this.richTextBox5.Text = "String nameOne=\"Alpha\";\nString nameTwo=\"Alpha\";\n\nis nameOne==nameTwo?";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(30, 6);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(159, 80);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "int valOne=10;\nint valTwo=10;\n\nis valOne==valTwo?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 677);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbUsage;
        private System.Windows.Forms.Button btnUsage;
        private System.Windows.Forms.ListBox lstOptions;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtVal6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVal8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVal7;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.TextBox txtVal3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtVal5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVal4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RichTextBox richTextBox7;
    }
}

