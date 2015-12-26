namespace WAFMetastoreBuilder.UI
{
	partial class SystemStringCtrl
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
			this.txtValue = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Size = new System.Drawing.Size(121, 20);
			this.titleLabel.Text = "System String";
			// 
			// titlePanel
			// 
			this.titlePanel.Size = new System.Drawing.Size(675, 38);
			// 
			// lnkParentElement
			// 
			this.lnkParentElement.Location = new System.Drawing.Point(127, 14);
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(135, 71);
			this.txtValue.Multiline = true;
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(523, 88);
			this.txtValue.TabIndex = 39;
			this.txtValue.Text = " ";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(135, 44);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(523, 20);
			this.txtName.TabIndex = 37;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 48;
			this.label2.Text = "Value";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 47;
			this.label1.Text = "Name";
			// 
			// SystemStringCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SystemStringCtrl";
			this.Size = new System.Drawing.Size(675, 235);
			this.Title = "System String";
			this.Controls.SetChildIndex(this.titlePanel, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.txtName, 0);
			this.Controls.SetChildIndex(this.txtValue, 0);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

				private System.Windows.Forms.TextBox txtValue;
				private System.Windows.Forms.TextBox txtName;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label1;

		}
}
