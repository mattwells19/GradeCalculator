namespace Grade_Average_Wells_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNum = new System.Windows.Forms.Button();
            this.btnLetter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iWantToAdMyOwnGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreLoopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uhhThatsItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtG1 = new System.Windows.Forms.TextBox();
            this.txtG4 = new System.Windows.Forms.TextBox();
            this.txtG3 = new System.Windows.Forms.TextBox();
            this.txtG2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pA = new System.Windows.Forms.PictureBox();
            this.pF = new System.Windows.Forms.PictureBox();
            this.pD = new System.Windows.Forms.PictureBox();
            this.pC = new System.Windows.Forms.PictureBox();
            this.pB = new System.Windows.Forms.PictureBox();
            this.btnDW = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNum
            // 
            this.btnNum.BackColor = System.Drawing.Color.White;
            this.btnNum.Location = new System.Drawing.Point(50, 56);
            this.btnNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(104, 55);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Get My Grade AVG";
            this.btnNum.UseVisualStyleBackColor = false;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.Location = new System.Drawing.Point(291, 144);
            this.btnLetter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.Size = new System.Drawing.Size(104, 55);
            this.btnLetter.TabIndex = 2;
            this.btnLetter.Text = "Get My AVG Letter";
            this.btnLetter.UseVisualStyleBackColor = true;
            this.btnLetter.Visible = false;
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.moreToolStripMenuItem,
            this.uhhThatsItToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iWantToAdMyOwnGradesToolStripMenuItem,
            this.moreLoopsToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // iWantToAdMyOwnGradesToolStripMenuItem
            // 
            this.iWantToAdMyOwnGradesToolStripMenuItem.Name = "iWantToAdMyOwnGradesToolStripMenuItem";
            this.iWantToAdMyOwnGradesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.iWantToAdMyOwnGradesToolStripMenuItem.Text = "I want to add my own grades!";
            this.iWantToAdMyOwnGradesToolStripMenuItem.Click += new System.EventHandler(this.iWantToAdMyOwnGradesToolStripMenuItem_Click);
            // 
            // moreLoopsToolStripMenuItem
            // 
            this.moreLoopsToolStripMenuItem.Name = "moreLoopsToolStripMenuItem";
            this.moreLoopsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.moreLoopsToolStripMenuItem.Text = "More Loops!";
            this.moreLoopsToolStripMenuItem.Click += new System.EventHandler(this.moreLoopsToolStripMenuItem_Click);
            // 
            // uhhThatsItToolStripMenuItem
            // 
            this.uhhThatsItToolStripMenuItem.Name = "uhhThatsItToolStripMenuItem";
            this.uhhThatsItToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.uhhThatsItToolStripMenuItem.Text = "Uhh that\'s it?";
            this.uhhThatsItToolStripMenuItem.Click += new System.EventHandler(this.uhhThatsItToolStripMenuItem_Click);
            // 
            // txtG1
            // 
            this.txtG1.Location = new System.Drawing.Point(53, 121);
            this.txtG1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtG1.Name = "txtG1";
            this.txtG1.Size = new System.Drawing.Size(76, 20);
            this.txtG1.TabIndex = 4;
            this.txtG1.Visible = false;
            // 
            // txtG4
            // 
            this.txtG4.Location = new System.Drawing.Point(53, 189);
            this.txtG4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtG4.Name = "txtG4";
            this.txtG4.Size = new System.Drawing.Size(76, 20);
            this.txtG4.TabIndex = 5;
            this.txtG4.Visible = false;
            // 
            // txtG3
            // 
            this.txtG3.Location = new System.Drawing.Point(53, 167);
            this.txtG3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtG3.Name = "txtG3";
            this.txtG3.Size = new System.Drawing.Size(76, 20);
            this.txtG3.TabIndex = 6;
            this.txtG3.Visible = false;
            // 
            // txtG2
            // 
            this.txtG2.Location = new System.Drawing.Point(53, 144);
            this.txtG2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtG2.Name = "txtG2";
            this.txtG2.Size = new System.Drawing.Size(76, 20);
            this.txtG2.TabIndex = 7;
            this.txtG2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Grade 1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Grade 2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grade 3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Grade 4";
            this.label4.Visible = false;
            // 
            // pA
            // 
            this.pA.Image = global::Grade_Average_Wells_02.Properties.Resources.A;
            this.pA.Location = new System.Drawing.Point(291, 56);
            this.pA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pA.Name = "pA";
            this.pA.Size = new System.Drawing.Size(104, 83);
            this.pA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pA.TabIndex = 12;
            this.pA.TabStop = false;
            this.pA.Visible = false;
            // 
            // pF
            // 
            this.pF.Image = global::Grade_Average_Wells_02.Properties.Resources.F;
            this.pF.Location = new System.Drawing.Point(291, 56);
            this.pF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pF.Name = "pF";
            this.pF.Size = new System.Drawing.Size(104, 83);
            this.pF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pF.TabIndex = 13;
            this.pF.TabStop = false;
            this.pF.Visible = false;
            // 
            // pD
            // 
            this.pD.Image = global::Grade_Average_Wells_02.Properties.Resources.D;
            this.pD.Location = new System.Drawing.Point(291, 56);
            this.pD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pD.Name = "pD";
            this.pD.Size = new System.Drawing.Size(104, 83);
            this.pD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pD.TabIndex = 14;
            this.pD.TabStop = false;
            this.pD.Visible = false;
            // 
            // pC
            // 
            this.pC.Image = global::Grade_Average_Wells_02.Properties.Resources.C;
            this.pC.Location = new System.Drawing.Point(291, 56);
            this.pC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pC.Name = "pC";
            this.pC.Size = new System.Drawing.Size(104, 83);
            this.pC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pC.TabIndex = 15;
            this.pC.TabStop = false;
            this.pC.Visible = false;
            // 
            // pB
            // 
            this.pB.Image = global::Grade_Average_Wells_02.Properties.Resources.B;
            this.pB.Location = new System.Drawing.Point(291, 56);
            this.pB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(104, 83);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB.TabIndex = 16;
            this.pB.TabStop = false;
            this.pB.Visible = false;
            // 
            // btnDW
            // 
            this.btnDW.Location = new System.Drawing.Point(477, 56);
            this.btnDW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDW.Name = "btnDW";
            this.btnDW.Size = new System.Drawing.Size(90, 41);
            this.btnDW.TabIndex = 17;
            this.btnDW.Text = "Do While";
            this.btnDW.UseVisualStyleBackColor = true;
            this.btnDW.Click += new System.EventHandler(this.btnDW_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(477, 102);
            this.btnW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(90, 41);
            this.btnW.TabIndex = 19;
            this.btnW.Text = "While";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(163, 156);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(97, 69);
            this.listBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Grade_Average_Wells_02.Properties.Resources.C_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(445, 333);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnDW);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.pC);
            this.Controls.Add(this.pD);
            this.Controls.Add(this.pF);
            this.Controls.Add(this.pA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtG2);
            this.Controls.Add(this.txtG3);
            this.Controls.Add(this.txtG4);
            this.Controls.Add(this.txtG1);
            this.Controls.Add(this.btnLetter);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Average";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnLetter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iWantToAdMyOwnGradesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtG1;
        private System.Windows.Forms.TextBox txtG4;
        private System.Windows.Forms.TextBox txtG3;
        private System.Windows.Forms.TextBox txtG2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.PictureBox pA;
        private System.Windows.Forms.PictureBox pF;
        private System.Windows.Forms.PictureBox pD;
        private System.Windows.Forms.PictureBox pC;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.ToolStripMenuItem moreLoopsToolStripMenuItem;
        private System.Windows.Forms.Button btnDW;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.ToolStripMenuItem uhhThatsItToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

