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
            this.SuspendLayout();
            // 
            // txtWordToDefine
            // 
            this.txtWordToDefine.Location = new System.Drawing.Point(12, 12);
            this.txtWordToDefine.Name = "txtWordToDefine";
            this.txtWordToDefine.Size = new System.Drawing.Size(409, 26);
            this.txtWordToDefine.TabIndex = 0;
            // 
            // btnDefineWord
            // 
            this.btnDefineWord.Location = new System.Drawing.Point(428, 12);
            this.btnDefineWord.Name = "btnDefineWord";
            this.btnDefineWord.Size = new System.Drawing.Size(75, 26);
            this.btnDefineWord.TabIndex = 1;
            this.btnDefineWord.Text = "Define";
            this.btnDefineWord.UseVisualStyleBackColor = true;
            this.btnDefineWord.Click += new System.EventHandler(this.btnDefineWord_Click);
            // 
            // tvResult
            // 
            this.tvResult.Location = new System.Drawing.Point(12, 45);
            this.tvResult.Name = "tvResult";
            this.tvResult.Size = new System.Drawing.Size(491, 422);
            this.tvResult.TabIndex = 2;
            // 
            // frmDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 479);
            this.Controls.Add(this.tvResult);
            this.Controls.Add(this.btnDefineWord);
            this.Controls.Add(this.txtWordToDefine);
            this.Name = "frmDefine";
            this.Text = "Define";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordToDefine;
        private System.Windows.Forms.Button btnDefineWord;
        private System.Windows.Forms.TreeView tvResult;
    }
}

