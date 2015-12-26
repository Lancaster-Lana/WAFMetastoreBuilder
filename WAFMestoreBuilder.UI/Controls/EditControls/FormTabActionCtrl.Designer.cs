namespace WAFMetastoreBuilder.UI
{
	partial class FormTabActionCtrl
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
			this.cmbAction = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbRequired = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.txtAttributeName = new System.Windows.Forms.TextBox();
			this.cmbFieldType = new System.Windows.Forms.ComboBox();
			this.cmbFieldSource = new System.Windows.Forms.ComboBox();
			this.txtActionName = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cmbSecureConnection = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lbSecurity = new System.Windows.Forms.ListBox();
			this.btnEditSecurity = new System.Windows.Forms.Button();
			this.btnAddSecurity = new System.Windows.Forms.Button();
			this.btnDeleteSecurity = new System.Windows.Forms.Button();
			this.titlePanel.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Size = new System.Drawing.Size(141, 20);
			this.titleLabel.Text = "Form Tab Action";
			// 
			// titlePanel
			// 
			this.titlePanel.Size = new System.Drawing.Size(482, 38);
			// 
			// lnkParentElement
			// 
			this.lnkParentElement.Location = new System.Drawing.Point(164, 14);
			// 
			// cmbAction
			// 
			this.cmbAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbAction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbAction.FormattingEnabled = true;
			this.cmbAction.Location = new System.Drawing.Point(136, 47);
			this.cmbAction.Name = "cmbAction";
			this.cmbAction.Size = new System.Drawing.Size(307, 21);
			this.cmbAction.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 64;
			this.label3.Text = "Table Action";
			// 
			// cbRequired
			// 
			this.cbRequired.AutoSize = true;
			this.cbRequired.Location = new System.Drawing.Point(14, 132);
			this.cbRequired.Name = "cbRequired";
			this.cbRequired.Size = new System.Drawing.Size(69, 17);
			this.cbRequired.TabIndex = 60;
			this.cbRequired.Text = "Required";
			this.cbRequired.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(110, 70);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(218, 20);
			this.textBox1.TabIndex = 71;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(459, 76);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(182, 20);
			this.textBox2.TabIndex = 72;
			// 
			// txtAttributeName
			// 
			this.txtAttributeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtAttributeName.Location = new System.Drawing.Point(435, 45);
			this.txtAttributeName.Name = "txtAttributeName";
			this.txtAttributeName.Size = new System.Drawing.Size(218, 20);
			this.txtAttributeName.TabIndex = 57;
			// 
			// cmbFieldType
			// 
			this.cmbFieldType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbFieldType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbFieldType.FormattingEnabled = true;
			this.cmbFieldType.Location = new System.Drawing.Point(120, 178);
			this.cmbFieldType.Name = "cmbFieldType";
			this.cmbFieldType.Size = new System.Drawing.Size(218, 21);
			this.cmbFieldType.TabIndex = 59;
			// 
			// cmbFieldSource
			// 
			this.cmbFieldSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbFieldSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbFieldSource.FormattingEnabled = true;
			this.cmbFieldSource.Location = new System.Drawing.Point(435, 44);
			this.cmbFieldSource.Name = "cmbFieldSource";
			this.cmbFieldSource.Size = new System.Drawing.Size(221, 21);
			this.cmbFieldSource.TabIndex = 67;
			// 
			// txtActionName
			// 
			this.txtActionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtActionName.Location = new System.Drawing.Point(120, 205);
			this.txtActionName.Name = "txtActionName";
			this.txtActionName.Size = new System.Drawing.Size(218, 20);
			this.txtActionName.TabIndex = 57;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.cmbSecureConnection);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.lbSecurity);
			this.groupBox5.Controls.Add(this.btnEditSecurity);
			this.groupBox5.Controls.Add(this.btnAddSecurity);
			this.groupBox5.Controls.Add(this.btnDeleteSecurity);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox5.Location = new System.Drawing.Point(9, 82);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(440, 126);
			this.groupBox5.TabIndex = 67;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "SECURITY";
			this.groupBox5.Visible = false;
			// 
			// cmbSecureConnection
			// 
			this.cmbSecureConnection.FormattingEnabled = true;
			this.cmbSecureConnection.Location = new System.Drawing.Point(127, 91);
			this.cmbSecureConnection.Name = "cmbSecureConnection";
			this.cmbSecureConnection.Size = new System.Drawing.Size(307, 21);
			this.cmbSecureConnection.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Secure connection";
			// 
			// lbSecurity
			// 
			this.lbSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbSecurity.FormattingEnabled = true;
			this.lbSecurity.Location = new System.Drawing.Point(3, 16);
			this.lbSecurity.Name = "lbSecurity";
			this.lbSecurity.Size = new System.Drawing.Size(350, 69);
			this.lbSecurity.TabIndex = 0;
			this.lbSecurity.TabStop = false;
			// 
			// btnEditSecurity
			// 
			this.btnEditSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEditSecurity.Location = new System.Drawing.Point(359, 39);
			this.btnEditSecurity.Name = "btnEditSecurity";
			this.btnEditSecurity.Size = new System.Drawing.Size(75, 23);
			this.btnEditSecurity.TabIndex = 2;
			this.btnEditSecurity.TabStop = false;
			this.btnEditSecurity.Text = "Edit";
			this.btnEditSecurity.UseVisualStyleBackColor = true;
			// 
			// btnAddSecurity
			// 
			this.btnAddSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddSecurity.Location = new System.Drawing.Point(359, 12);
			this.btnAddSecurity.Name = "btnAddSecurity";
			this.btnAddSecurity.Size = new System.Drawing.Size(75, 23);
			this.btnAddSecurity.TabIndex = 1;
			this.btnAddSecurity.TabStop = false;
			this.btnAddSecurity.Text = "Add";
			this.btnAddSecurity.UseVisualStyleBackColor = true;
			// 
			// btnDeleteSecurity
			// 
			this.btnDeleteSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDeleteSecurity.Location = new System.Drawing.Point(359, 64);
			this.btnDeleteSecurity.Name = "btnDeleteSecurity";
			this.btnDeleteSecurity.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteSecurity.TabIndex = 3;
			this.btnDeleteSecurity.TabStop = false;
			this.btnDeleteSecurity.Text = "Delete";
			this.btnDeleteSecurity.UseVisualStyleBackColor = true;
			// 
			// FormTabActionCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.cmbAction);
			this.Controls.Add(this.label3);
			this.Name = "FormTabActionCtrl";
			this.Size = new System.Drawing.Size(482, 284);
			this.Title = "Form Tab Action";
			this.Controls.SetChildIndex(this.titlePanel, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.cmbAction, 0);
			this.Controls.SetChildIndex(this.groupBox5, 0);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

				private System.Windows.Forms.ComboBox cmbAction;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.CheckBox cbRequired;
				private System.Windows.Forms.TextBox textBox1;
				private System.Windows.Forms.TextBox textBox2;
				private System.Windows.Forms.TextBox txtAttributeName;
				private System.Windows.Forms.ComboBox cmbFieldType;
				private System.Windows.Forms.ComboBox cmbFieldSource;
				private System.Windows.Forms.TextBox txtActionName;
				private System.Windows.Forms.GroupBox groupBox5;
				private System.Windows.Forms.ComboBox cmbSecureConnection;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.ListBox lbSecurity;
				private System.Windows.Forms.Button btnEditSecurity;
				private System.Windows.Forms.Button btnAddSecurity;
				private System.Windows.Forms.Button btnDeleteSecurity;

		}
}
