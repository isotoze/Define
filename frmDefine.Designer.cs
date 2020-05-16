namespace Define
{
    partial class frmDefine
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
            this.txtWordToDefine = new System.Windows.Forms.TextBox();
            this.btnDefineWord = new System.Windows.Forms.Button();
            this.tvResult = new System.Windows.Forms.TreeView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtWordToDefine
            // 
            this.txtWordToDefine.Location = new System.Drawing.Point(8, 8);
            this.txtWordToDefine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWordToDefine.Name = "txtWordToDefine";
            this.txtWordToDefine.Size = new System.Drawing.Size(328, 20);
            this.txtWordToDefine.TabIndex = 0;
            // 
            // btnDefineWord
            // 
            this.btnDefineWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefineWord.Location = new System.Drawing.Point(259, 33);
            this.btnDefineWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDefineWord.Name = "btnDefineWord";
            this.btnDefineWord.Size = new System.Drawing.Size(77, 23);
            this.btnDefineWord.TabIndex = 1;
            this.btnDefineWord.Text = "Define";
            this.btnDefineWord.UseVisualStyleBackColor = true;
            this.btnDefineWord.Click += new System.EventHandler(this.btnDefineWord_Click);
            // 
            // tvResult
            // 
            this.tvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvResult.Location = new System.Drawing.Point(8, 63);
            this.tvResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvResult.Name = "tvResult";
            this.tvResult.Size = new System.Drawing.Size(329, 242);
            this.tvResult.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // frmDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 311);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tvResult);
            this.Controls.Add(this.btnDefineWord);
            this.Controls.Add(this.txtWordToDefine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDefine";
            this.Text = "Define";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordToDefine;
        private System.Windows.Forms.Button btnDefineWord;
        private System.Windows.Forms.TreeView tvResult;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

