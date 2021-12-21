using System;
using System.Windows.Forms;
using System.Drawing;


namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MB = new System.Windows.Forms.MaskedTextBox();
            this.MinI = new System.Windows.Forms.MaskedTextBox();
            this.MinU = new System.Windows.Forms.MaskedTextBox();
            this.MaxI = new System.Windows.Forms.MaskedTextBox();
            this.MaxB = new System.Windows.Forms.MaskedTextBox();
            this.MaxU = new System.Windows.Forms.MaskedTextBox();
            this.SecondNum = new System.Windows.Forms.MaskedTextBox();
            this.SymbOper = new System.Windows.Forms.MaskedTextBox();
            this.FirstNum = new System.Windows.Forms.MaskedTextBox();
            this.AnsL = new System.Windows.Forms.Label();
            this.MinB = new System.Windows.Forms.LinkLabel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DMT = new System.Windows.Forms.MaskedTextBox();
            this.D_M = new System.Windows.Forms.MaskedTextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "integer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.MB);
            this.panel1.Controls.Add(this.MinI);
            this.panel1.Controls.Add(this.MinU);
            this.panel1.Controls.Add(this.MaxI);
            this.panel1.Controls.Add(this.MaxB);
            this.panel1.Controls.Add(this.MaxU);
            this.panel1.Controls.Add(this.SecondNum);
            this.panel1.Controls.Add(this.SymbOper);
            this.panel1.Controls.Add(this.FirstNum);
            this.panel1.Controls.Add(this.AnsL);
            this.panel1.Controls.Add(this.MinB);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 434);
            this.panel1.TabIndex = 1;
            // 
            // MB
            // 
            this.MB.Location = new System.Drawing.Point(138, 72);
            this.MB.MinimumSize = new System.Drawing.Size(38, 23);
            this.MB.Name = "MB";
            this.MB.Size = new System.Drawing.Size(78, 23);
            this.MB.TabIndex = 32;
            // 
            // MinI
            // 
            this.MinI.Location = new System.Drawing.Point(265, 73);
            this.MinI.MinimumSize = new System.Drawing.Size(38, 23);
            this.MinI.Name = "MinI";
            this.MinI.Size = new System.Drawing.Size(76, 23);
            this.MinI.TabIndex = 31;
            // 
            // MinU
            // 
            this.MinU.Location = new System.Drawing.Point(12, 74);
            this.MinU.MinimumSize = new System.Drawing.Size(38, 23);
            this.MinU.Name = "MinU";
            this.MinU.Size = new System.Drawing.Size(78, 23);
            this.MinU.TabIndex = 29;
            // 
            // MaxI
            // 
            this.MaxI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxI.Location = new System.Drawing.Point(265, 151);
            this.MaxI.Margin = new System.Windows.Forms.Padding(0);
            this.MaxI.MinimumSize = new System.Drawing.Size(38, 23);
            this.MaxI.Name = "MaxI";
            this.MaxI.Size = new System.Drawing.Size(76, 23);
            this.MaxI.TabIndex = 28;
            this.MaxI.ValidatingType = typeof(int);
            // 
            // MaxB
            // 
            this.MaxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxB.Location = new System.Drawing.Point(138, 151);
            this.MaxB.MinimumSize = new System.Drawing.Size(38, 23);
            this.MaxB.Name = "MaxB";
            this.MaxB.Size = new System.Drawing.Size(78, 23);
            this.MaxB.TabIndex = 27;
            // 
            // MaxU
            // 
            this.MaxU.Location = new System.Drawing.Point(12, 152);
            this.MaxU.MinimumSize = new System.Drawing.Size(38, 23);
            this.MaxU.Name = "MaxU";
            this.MaxU.Size = new System.Drawing.Size(78, 23);
            this.MaxU.TabIndex = 26;
            // 
            // SecondNum
            // 
            this.SecondNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SecondNum.Location = new System.Drawing.Point(203, 216);
            this.SecondNum.Mask = "CCCCC";
            this.SecondNum.MinimumSize = new System.Drawing.Size(100, 23);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(100, 23);
            this.SecondNum.TabIndex = 25;
            this.SecondNum.ValidatingType = typeof(int);
            // 
            // SymbOper
            // 
            this.SymbOper.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SymbOper.Location = new System.Drawing.Point(141, 216);
            this.SymbOper.Mask = "C";
            this.SymbOper.MinimumSize = new System.Drawing.Size(24, 23);
            this.SymbOper.Name = "SymbOper";
            this.SymbOper.Size = new System.Drawing.Size(35, 23);
            this.SymbOper.TabIndex = 24;
            this.SymbOper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstNum
            // 
            this.FirstNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FirstNum.Location = new System.Drawing.Point(12, 217);
            this.FirstNum.Mask = "CCCCCCCCCCCCC";
            this.FirstNum.MinimumSize = new System.Drawing.Size(100, 23);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(100, 23);
            this.FirstNum.TabIndex = 23;
            this.FirstNum.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.FirstNum.ValidatingType = typeof(int);
            // 
            // AnsL
            // 
            this.AnsL.AutoSize = true;
            this.AnsL.Location = new System.Drawing.Point(138, 289);
            this.AnsL.MinimumSize = new System.Drawing.Size(38, 15);
            this.AnsL.Name = "AnsL";
            this.AnsL.Size = new System.Drawing.Size(38, 15);
            this.AnsL.TabIndex = 22;
            // 
            // MinB
            // 
            this.MinB.AutoSize = true;
            this.MinB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinB.LinkColor = System.Drawing.Color.Black;
            this.MinB.Location = new System.Drawing.Point(112, 256);
            this.MinB.MinimumSize = new System.Drawing.Size(60, 15);
            this.MinB.Name = "MinB";
            this.MinB.Size = new System.Drawing.Size(90, 15);
            this.MinB.TabIndex = 21;
            this.MinB.TabStop = true;
            this.MinB.Text = "Опять работа...";
            this.MinB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox9.Location = new System.Drawing.Point(12, 185);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(36, 16);
            this.textBox9.TabIndex = 16;
            this.textBox9.Text = "Calc";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox8.Location = new System.Drawing.Point(265, 129);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 16);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "int";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox7.Location = new System.Drawing.Point(138, 129);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(78, 16);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "byte";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox6.Location = new System.Drawing.Point(265, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(47, 16);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "int";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.Location = new System.Drawing.Point(12, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 16);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "uint";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Max";
            this.textBox4.Size = new System.Drawing.Size(36, 16);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(12, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Min";
            this.textBox3.Size = new System.Drawing.Size(26, 16);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(12, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 16);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "uint";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(138, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 16);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "byte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, -73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DMT);
            this.panel2.Controls.Add(this.D_M);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(402, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 434);
            this.panel2.TabIndex = 2;
            // 
            // DMT
            // 
            this.DMT.Location = new System.Drawing.Point(15, 73);
            this.DMT.Name = "DMT";
            this.DMT.Size = new System.Drawing.Size(200, 23);
            this.DMT.TabIndex = 11;
            // 
            // D_M
            // 
            this.D_M.Location = new System.Drawing.Point(15, 151);
            this.D_M.Name = "D_M";
            this.D_M.Size = new System.Drawing.Size(200, 23);
            this.D_M.TabIndex = 10;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox12.Location = new System.Drawing.Point(15, 106);
            this.textBox12.Name = "textBox12";
            this.textBox12.PlaceholderText = "Max";
            this.textBox12.Size = new System.Drawing.Size(26, 16);
            this.textBox12.TabIndex = 9;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Control;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox11.Location = new System.Drawing.Point(15, 48);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(78, 16);
            this.textBox11.TabIndex = 7;
            this.textBox11.Text = "double";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox10.Location = new System.Drawing.Point(15, 26);
            this.textBox10.Name = "textBox10";
            this.textBox10.PlaceholderText = "Min";
            this.textBox10.Size = new System.Drawing.Size(26, 16);
            this.textBox10.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "real";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox9;
        private LinkLabel MinB;
        private Label AnsL;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private MaskedTextBox MinU;
        private MaskedTextBox MaxI;
        private MaskedTextBox MaxB;
        private MaskedTextBox MaxU;
        private MaskedTextBox SecondNum;
        private MaskedTextBox SymbOper;
        private MaskedTextBox FirstNum;
        private MaskedTextBox MinI;
        private MaskedTextBox MB;
        private MaskedTextBox DMT;
        private MaskedTextBox D_M;
    }
}

