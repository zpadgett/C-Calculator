namespace Project2
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.label1 = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.expButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.factButton = new System.Windows.Forms.Button();
            this.reciprocalButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.primeButton = new System.Windows.Forms.Button();
            this.sumOfSquareButton = new System.Windows.Forms.Button();
            this.rangeFileButton = new System.Windows.Forms.Button();
            this.stdevButton = new System.Windows.Forms.Button();
            this.maxFileButton = new System.Windows.Forms.Button();
            this.averageFileButton = new System.Windows.Forms.Button();
            this.multiplyTableButton = new System.Windows.Forms.Button();
            this.sumOfFileButton = new System.Windows.Forms.Button();
            this.arrayButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yCheckBox = new System.Windows.Forms.CheckBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(197, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 15;
            this.resultsListBox.Location = new System.Drawing.Point(157, 96);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(287, 109);
            this.resultsListBox.TabIndex = 1;
            // 
            // expButton
            // 
            this.expButton.Location = new System.Drawing.Point(157, 220);
            this.expButton.Name = "expButton";
            this.expButton.Size = new System.Drawing.Size(83, 38);
            this.expButton.TabIndex = 2;
            this.expButton.Text = "x&^y";
            this.expButton.UseVisualStyleBackColor = true;
            this.expButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(246, 220);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(107, 38);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "x&/y";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(361, 220);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 38);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "x&+y";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // factButton
            // 
            this.factButton.Location = new System.Drawing.Point(157, 264);
            this.factButton.Name = "factButton";
            this.factButton.Size = new System.Drawing.Size(83, 38);
            this.factButton.TabIndex = 5;
            this.factButton.Text = "x&!";
            this.factButton.UseVisualStyleBackColor = true;
            this.factButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // reciprocalButton
            // 
            this.reciprocalButton.Location = new System.Drawing.Point(246, 264);
            this.reciprocalButton.Name = "reciprocalButton";
            this.reciprocalButton.Size = new System.Drawing.Size(107, 38);
            this.reciprocalButton.TabIndex = 6;
            this.reciprocalButton.Text = "&1/x";
            this.reciprocalButton.UseVisualStyleBackColor = true;
            this.reciprocalButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(361, 264);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(90, 38);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "x&-y";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // primeButton
            // 
            this.primeButton.Location = new System.Drawing.Point(157, 308);
            this.primeButton.Name = "primeButton";
            this.primeButton.Size = new System.Drawing.Size(83, 38);
            this.primeButton.TabIndex = 8;
            this.primeButton.Text = "&Prime";
            this.primeButton.UseVisualStyleBackColor = true;
            this.primeButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // sumOfSquareButton
            // 
            this.sumOfSquareButton.Location = new System.Drawing.Point(157, 352);
            this.sumOfSquareButton.Name = "sumOfSquareButton";
            this.sumOfSquareButton.Size = new System.Drawing.Size(83, 38);
            this.sumOfSquareButton.TabIndex = 9;
            this.sumOfSquareButton.Text = "&Sum of Squares";
            this.sumOfSquareButton.UseVisualStyleBackColor = true;
            this.sumOfSquareButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // rangeFileButton
            // 
            this.rangeFileButton.Location = new System.Drawing.Point(157, 396);
            this.rangeFileButton.Name = "rangeFileButton";
            this.rangeFileButton.Size = new System.Drawing.Size(83, 38);
            this.rangeFileButton.TabIndex = 10;
            this.rangeFileButton.Text = "&Range of File Values";
            this.rangeFileButton.UseVisualStyleBackColor = true;
            this.rangeFileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // stdevButton
            // 
            this.stdevButton.Location = new System.Drawing.Point(246, 308);
            this.stdevButton.Name = "stdevButton";
            this.stdevButton.Size = new System.Drawing.Size(107, 38);
            this.stdevButton.TabIndex = 11;
            this.stdevButton.Text = "Sta&ndard Deviation of x:y";
            this.stdevButton.UseVisualStyleBackColor = true;
            this.stdevButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // maxFileButton
            // 
            this.maxFileButton.Location = new System.Drawing.Point(246, 352);
            this.maxFileButton.Name = "maxFileButton";
            this.maxFileButton.Size = new System.Drawing.Size(107, 38);
            this.maxFileButton.TabIndex = 12;
            this.maxFileButton.Text = "Ma&x of File Values";
            this.maxFileButton.UseVisualStyleBackColor = true;
            this.maxFileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // averageFileButton
            // 
            this.averageFileButton.Location = new System.Drawing.Point(246, 396);
            this.averageFileButton.Name = "averageFileButton";
            this.averageFileButton.Size = new System.Drawing.Size(107, 38);
            this.averageFileButton.TabIndex = 13;
            this.averageFileButton.Text = "&Average of File Values";
            this.averageFileButton.UseVisualStyleBackColor = true;
            this.averageFileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // multiplyTableButton
            // 
            this.multiplyTableButton.Location = new System.Drawing.Point(361, 308);
            this.multiplyTableButton.Name = "multiplyTableButton";
            this.multiplyTableButton.Size = new System.Drawing.Size(90, 38);
            this.multiplyTableButton.TabIndex = 14;
            this.multiplyTableButton.Text = "Multiplication &Table of x";
            this.multiplyTableButton.UseVisualStyleBackColor = true;
            this.multiplyTableButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // sumOfFileButton
            // 
            this.sumOfFileButton.Location = new System.Drawing.Point(361, 352);
            this.sumOfFileButton.Name = "sumOfFileButton";
            this.sumOfFileButton.Size = new System.Drawing.Size(90, 38);
            this.sumOfFileButton.TabIndex = 15;
            this.sumOfFileButton.Text = "Sum of &File Values";
            this.sumOfFileButton.UseVisualStyleBackColor = true;
            this.sumOfFileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // arrayButton
            // 
            this.arrayButton.Location = new System.Drawing.Point(361, 396);
            this.arrayButton.Name = "arrayButton";
            this.arrayButton.Size = new System.Drawing.Size(90, 38);
            this.arrayButton.TabIndex = 16;
            this.arrayButton.Text = "File Array &Value at (x.y)";
            this.arrayButton.UseVisualStyleBackColor = true;
            this.arrayButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sevenButton.ForeColor = System.Drawing.Color.White;
            this.sevenButton.Location = new System.Drawing.Point(468, 96);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(37, 30);
            this.sevenButton.TabIndex = 19;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fourButton.ForeColor = System.Drawing.Color.White;
            this.fourButton.Location = new System.Drawing.Point(468, 132);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(37, 30);
            this.fourButton.TabIndex = 20;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oneButton.ForeColor = System.Drawing.Color.White;
            this.oneButton.Location = new System.Drawing.Point(468, 168);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(37, 30);
            this.oneButton.TabIndex = 21;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.Color.Red;
            this.cButton.ForeColor = System.Drawing.Color.White;
            this.cButton.Location = new System.Drawing.Point(468, 204);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(37, 30);
            this.cButton.TabIndex = 22;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zeroButton.ForeColor = System.Drawing.Color.White;
            this.zeroButton.Location = new System.Drawing.Point(511, 204);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(37, 30);
            this.zeroButton.TabIndex = 23;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.twoButton.ForeColor = System.Drawing.Color.White;
            this.twoButton.Location = new System.Drawing.Point(511, 168);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(37, 30);
            this.twoButton.TabIndex = 24;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fiveButton.ForeColor = System.Drawing.Color.White;
            this.fiveButton.Location = new System.Drawing.Point(511, 132);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(37, 30);
            this.fiveButton.TabIndex = 25;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eightButton.ForeColor = System.Drawing.Color.White;
            this.eightButton.Location = new System.Drawing.Point(511, 96);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(37, 30);
            this.eightButton.TabIndex = 26;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nineButton.ForeColor = System.Drawing.Color.White;
            this.nineButton.Location = new System.Drawing.Point(554, 96);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(37, 30);
            this.nineButton.TabIndex = 27;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sixButton.ForeColor = System.Drawing.Color.White;
            this.sixButton.Location = new System.Drawing.Point(554, 132);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(37, 30);
            this.sixButton.TabIndex = 28;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.threeButton.ForeColor = System.Drawing.Color.White;
            this.threeButton.Location = new System.Drawing.Point(554, 168);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(37, 30);
            this.threeButton.TabIndex = 29;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // ceButton
            // 
            this.ceButton.BackColor = System.Drawing.Color.Red;
            this.ceButton.ForeColor = System.Drawing.Color.White;
            this.ceButton.Location = new System.Drawing.Point(554, 204);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(37, 30);
            this.ceButton.TabIndex = 30;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = false;
            this.ceButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "x:";
            // 
            // yCheckBox
            // 
            this.yCheckBox.AutoSize = true;
            this.yCheckBox.Location = new System.Drawing.Point(468, 275);
            this.yCheckBox.Name = "yCheckBox";
            this.yCheckBox.Size = new System.Drawing.Size(35, 19);
            this.yCheckBox.TabIndex = 32;
            this.yCheckBox.Text = "y:";
            this.yCheckBox.UseVisualStyleBackColor = true;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(506, 248);
            this.xTextBox.MaxLength = 9;
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(70, 23);
            this.xTextBox.TabIndex = 33;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(506, 277);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(70, 23);
            this.yTextBox.TabIndex = 34;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(468, 352);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 40);
            this.clearButton.TabIndex = 37;
            this.clearButton.Text = "C&lear Results";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(468, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 40);
            this.exitButton.TabIndex = 38;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button31_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(468, 306);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(108, 40);
            this.displayButton.TabIndex = 39;
            this.displayButton.Text = "&Display File";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(506, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.displayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(695, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.yCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ceButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.arrayButton);
            this.Controls.Add(this.sumOfFileButton);
            this.Controls.Add(this.multiplyTableButton);
            this.Controls.Add(this.averageFileButton);
            this.Controls.Add(this.maxFileButton);
            this.Controls.Add(this.stdevButton);
            this.Controls.Add(this.rangeFileButton);
            this.Controls.Add(this.sumOfSquareButton);
            this.Controls.Add(this.primeButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.reciprocalButton);
            this.Controls.Add(this.factButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.expButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Calculator App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button expButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button factButton;
        private System.Windows.Forms.Button reciprocalButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button primeButton;
        private System.Windows.Forms.Button sumOfSquareButton;
        private System.Windows.Forms.Button rangeFileButton;
        private System.Windows.Forms.Button stdevButton;
        private System.Windows.Forms.Button maxFileButton;
        private System.Windows.Forms.Button averageFileButton;
        private System.Windows.Forms.Button multiplyTableButton;
        private System.Windows.Forms.Button sumOfFileButton;
        private System.Windows.Forms.Button arrayButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox yCheckBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

