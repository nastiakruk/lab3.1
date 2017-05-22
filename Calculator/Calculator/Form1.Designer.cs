namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExpression = new System.Windows.Forms.TextBox();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btC = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.btDevid = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btSubst = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // tbExpression
            // 
            this.tbExpression.Location = new System.Drawing.Point(103, 17);
            this.tbExpression.Name = "tbExpression";
            this.tbExpression.Size = new System.Drawing.Size(208, 20);
            this.tbExpression.TabIndex = 2;
            this.tbExpression.TabStop = false;
            this.tbExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbExpression.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbExpression_KeyUp);
            // 
            // tbRes
            // 
            this.tbRes.Location = new System.Drawing.Point(103, 47);
            this.tbRes.Name = "tbRes";
            this.tbRes.ReadOnly = true;
            this.tbRes.Size = new System.Drawing.Size(208, 20);
            this.tbRes.TabIndex = 3;
            this.tbRes.TabStop = false;
            this.tbRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btC);
            this.groupBox1.Controls.Add(this.btBack);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btC
            // 
            this.btC.ForeColor = System.Drawing.Color.Red;
            this.btC.Location = new System.Drawing.Point(244, 19);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(49, 37);
            this.btC.TabIndex = 2;
            this.btC.TabStop = false;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btBack
            // 
            this.btBack.ForeColor = System.Drawing.Color.Red;
            this.btBack.Location = new System.Drawing.Point(128, 19);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(110, 37);
            this.btBack.TabIndex = 1;
            this.btBack.TabStop = false;
            this.btBack.Text = "Backspace";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 40);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 40);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btShacle);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(18, 164);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(43, 40);
            this.bt1.TabIndex = 0;
            this.bt1.TabStop = false;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(18, 210);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(43, 40);
            this.bt4.TabIndex = 0;
            this.bt4.TabStop = false;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(18, 256);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(43, 40);
            this.bt7.TabIndex = 0;
            this.bt7.TabStop = false;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(18, 302);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 40);
            this.button8.TabIndex = 0;
            this.button8.TabStop = false;
            this.button8.Text = "-/+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonP_m_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(67, 164);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(43, 40);
            this.bt2.TabIndex = 0;
            this.bt2.TabStop = false;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(116, 164);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(43, 40);
            this.bt3.TabIndex = 0;
            this.bt3.TabStop = false;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(67, 210);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(43, 40);
            this.bt5.TabIndex = 0;
            this.bt5.TabStop = false;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(67, 256);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(43, 40);
            this.bt8.TabIndex = 0;
            this.bt8.TabStop = false;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.button8_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(67, 302);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(43, 40);
            this.bt0.TabIndex = 0;
            this.bt0.TabStop = false;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.button0_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(116, 210);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(43, 40);
            this.bt6.TabIndex = 0;
            this.bt6.TabStop = false;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            //this.bt6.Click += new System.EventHandler(this.button6_Click);
            this.bt6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt6_MouseClick);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(116, 256);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(43, 40);
            this.bt9.TabIndex = 0;
            this.bt9.TabStop = false;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btMod
            // 
            this.btMod.ForeColor = System.Drawing.Color.Red;
            this.btMod.Location = new System.Drawing.Point(116, 302);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(43, 40);
            this.btMod.TabIndex = 0;
            this.btMod.TabStop = false;
            this.btMod.Text = "mod";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.clickMod);
            // 
            // btDevid
            // 
            this.btDevid.ForeColor = System.Drawing.Color.Red;
            this.btDevid.Location = new System.Drawing.Point(165, 164);
            this.btDevid.Name = "btDevid";
            this.btDevid.Size = new System.Drawing.Size(43, 40);
            this.btDevid.TabIndex = 0;
            this.btDevid.TabStop = false;
            this.btDevid.Text = "/";
            this.btDevid.UseVisualStyleBackColor = true;
            this.btDevid.Click += new System.EventHandler(this.btDev);
            // 
            // btMult
            // 
            this.btMult.ForeColor = System.Drawing.Color.Red;
            this.btMult.Location = new System.Drawing.Point(165, 210);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(43, 40);
            this.btMult.TabIndex = 0;
            this.btMult.TabStop = false;
            this.btMult.Text = "*";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.clMult);
            // 
            // btSubst
            // 
            this.btSubst.ForeColor = System.Drawing.Color.Red;
            this.btSubst.Location = new System.Drawing.Point(165, 256);
            this.btSubst.Name = "btSubst";
            this.btSubst.Size = new System.Drawing.Size(43, 40);
            this.btSubst.TabIndex = 0;
            this.btSubst.TabStop = false;
            this.btSubst.Text = "-";
            this.btSubst.UseVisualStyleBackColor = true;
            this.btSubst.Click += new System.EventHandler(this.btSub);
            // 
            // Sum
            // 
            this.Sum.ForeColor = System.Drawing.Color.Red;
            this.Sum.Location = new System.Drawing.Point(165, 302);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(43, 40);
            this.Sum.TabIndex = 0;
            this.Sum.TabStop = false;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.btSum);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(262, 164);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(43, 40);
            this.button21.TabIndex = 0;
            this.button21.TabStop = false;
            this.button21.Text = "MR";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.buttonMRead_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(262, 210);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(43, 40);
            this.button22.TabIndex = 0;
            this.button22.TabStop = false;
            this.button22.Text = "M+";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(262, 256);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(43, 40);
            this.button23.TabIndex = 0;
            this.button23.TabStop = false;
            this.button23.Text = "MC";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.buttonMClean_Click);
            // 
            // button24
            // 
            this.button24.ForeColor = System.Drawing.Color.Red;
            this.button24.Location = new System.Drawing.Point(242, 302);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(63, 40);
            this.button24.TabIndex = 0;
            this.button24.Text = "=";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.bcResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.tbExpression);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.btSubst);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.btDevid);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbExpression;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btDevid;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btSubst;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

