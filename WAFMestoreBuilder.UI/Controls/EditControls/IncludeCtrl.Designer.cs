namespace WAFMetastoreBuilder.UI
{
	partial class IncludeCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOpenIncludePath = new System.Windows.Forms.Button();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Size = new System.Drawing.Size(68, 20);
			this.titleLabel.Text = "Include";
			// 
			// titlePanel
			// 
			this.titlePanel.Size = new System.Drawing.Size(584, 43);
			// 
			// lnkParentElement
			// 
			this.lnkParentElement.Location = new System.Drawing.Point(85, 14);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(90, 56);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(441, 20);
			this.txtName.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 47;
			this.label1.Text = "File name";
			// 
			// btnOpenIncludePath
			// 
			this.btnOpenIncludePath.Location = new System.Drawing.Point(537, 54);
			this.btnOpenIncludePath.Name = "btnOpenIncludePath";
			this.btnOpenIncludePath.Size = new System.Drawing.Size(36, 23);
			this.btnOpenIncludePath.TabIndex = 49;
			this.btnOpenIncludePath.Text = "...";
			this.btnOpenIncludePath.UseVisualStyleBackColor = true;
			this.btnOpenIncludePath.Click += new System.EventHandler(this.btnOpenIncludePath_Click);
			// 
			// IncludeCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnOpenIncludePath);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Name = "IncludeCtrl";
			this.Size = new System.Drawing.Size(584, 159);
			this.Title = "Include";
			this.Controls.SetChildIndex(this.titlePanel, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txtName, 0);
			this.Controls.SetChildIndex(this.btnOpenIncludePath, 0);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

				private System.Windows.Forms.TextBox txtName;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Button btnOpenIncludePath;

		}
}
