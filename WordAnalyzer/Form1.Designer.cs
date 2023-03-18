namespace WordAnalyzer
{
    partial class WordAnalyzer
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
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.NumberOfWordsLbl = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LongestWordLbl = new System.Windows.Forms.Label();
            this.ShortestWordLbl = new System.Windows.Forms.Label();
            this.AvgWordLenght = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MostCommonWordsLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LeastCommonWordsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "Browse File";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // NumberOfWordsLbl
            // 
            this.NumberOfWordsLbl.AutoSize = true;
            this.NumberOfWordsLbl.Location = new System.Drawing.Point(288, 16);
            this.NumberOfWordsLbl.Name = "NumberOfWordsLbl";
            this.NumberOfWordsLbl.Size = new System.Drawing.Size(13, 15);
            this.NumberOfWordsLbl.TabIndex = 1;
            this.NumberOfWordsLbl.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(190, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(92, 15);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Count of words:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Longest word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shortest word:";
            // 
            // LongestWordLbl
            // 
            this.LongestWordLbl.AutoSize = true;
            this.LongestWordLbl.Location = new System.Drawing.Point(288, 46);
            this.LongestWordLbl.Name = "LongestWordLbl";
            this.LongestWordLbl.Size = new System.Drawing.Size(34, 15);
            this.LongestWordLbl.TabIndex = 5;
            this.LongestWordLbl.Text = "none";
            // 
            // ShortestWordLbl
            // 
            this.ShortestWordLbl.AutoSize = true;
            this.ShortestWordLbl.Location = new System.Drawing.Point(288, 75);
            this.ShortestWordLbl.Name = "ShortestWordLbl";
            this.ShortestWordLbl.Size = new System.Drawing.Size(34, 15);
            this.ShortestWordLbl.TabIndex = 6;
            this.ShortestWordLbl.Text = "none";
            // 
            // AvgWordLenght
            // 
            this.AvgWordLenght.AutoSize = true;
            this.AvgWordLenght.Location = new System.Drawing.Point(288, 99);
            this.AvgWordLenght.Name = "AvgWordLenght";
            this.AvgWordLenght.Size = new System.Drawing.Size(13, 15);
            this.AvgWordLenght.TabIndex = 8;
            this.AvgWordLenght.Text = "0";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(162, 99);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(120, 15);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Average word length:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 41);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(77, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Most common words:";
            // 
            // MostCommonWordsLbl
            // 
            this.MostCommonWordsLbl.AutoSize = true;
            this.MostCommonWordsLbl.Location = new System.Drawing.Point(544, 16);
            this.MostCommonWordsLbl.Name = "MostCommonWordsLbl";
            this.MostCommonWordsLbl.Size = new System.Drawing.Size(13, 15);
            this.MostCommonWordsLbl.TabIndex = 11;
            this.MostCommonWordsLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Least common words:";
            // 
            // LeastCommonWordsLbl
            // 
            this.LeastCommonWordsLbl.AutoSize = true;
            this.LeastCommonWordsLbl.Location = new System.Drawing.Point(544, 99);
            this.LeastCommonWordsLbl.Name = "LeastCommonWordsLbl";
            this.LeastCommonWordsLbl.Size = new System.Drawing.Size(13, 15);
            this.LeastCommonWordsLbl.TabIndex = 13;
            this.LeastCommonWordsLbl.Text = "0";
            // 
            // WordAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeastCommonWordsLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MostCommonWordsLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AvgWordLenght);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.ShortestWordLbl);
            this.Controls.Add(this.LongestWordLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.NumberOfWordsLbl);
            this.Controls.Add(this.OpenFileBtn);
            this.Name = "WordAnalyzer";
            this.Text = "Word Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OpenFileBtn;
        private Label NumberOfWordsLbl;
        private Label lbl1;
        private Label label1;
        private Label label2;
        private Label LongestWordLbl;
        private Label ShortestWordLbl;
        private Label AvgWordLenght;
        private Label lbl4;
        private Button Cancel;
        private Label label3;
        private Label MostCommonWordsLbl;
        private Label label4;
        private Label LeastCommonWordsLbl;
    }
}