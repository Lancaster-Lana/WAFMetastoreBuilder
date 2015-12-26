namespace WAFMetastoreBuilder.UI
{
    partial class TableActionCtrl
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
			this.label4 = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbSubmitEditForm = new System.Windows.Forms.CheckBox();
			this.cmbSecureConnection = new System.Windows.Forms.ComboBox();
			this.txtLabel = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cbRequired = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.txtAttributeName = new System.Windows.Forms.TextBox();
			this.txtNextActionName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbFieldType = new System.Windows.Forms.ComboBox();
			this.cmbFieldSource = new System.Windows.Forms.ComboBox();
			this.txtActionName = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lbSecurity = new System.Windows.Forms.ListBox();
			this.btnEditSecurity = new System.Windows.Forms.Button();
			this.btnAddSecurity = new System.Windows.Forms.Button();
			this.btnDeleteSecurity = new System.Windows.Forms.Button();
			this.txtExecActionName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbTableName = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbFormName = new System.Windows.Forms.ComboBox();
			this.titlePanel.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Size = new System.Drawing.Size(60, 20);
			this.titleLabel.Text = "Action";
			// 
			// titlePanel
			// 
			this.titlePanel.Size = new System.Drawing.Size(803, 38);
			// 
			// lnkParentElement
			// 
			this.lnkParentElement.Location = new System.Drawing.Point(102, 14);
			// 
			// cmbAction
			// 
			this.cmbAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbAction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbAction.FormattingEnabled = true;
			this.cmbAction.Items.AddRange(new object[] {
            "Query",
            "Search",
            "New",
            "Open ",
            "Redisplay",
            "Save",
            "SaveNew",
            "Delete",
            "Dispaly",
            "Redisplay",
            "Report",
            "Redirect",
            "GetFile"});
			this.cmbAction.Location = new System.Drawing.Point(107, 96);
			this.cmbAction.Name = "cmbAction";
			this.cmbAction.Size = new System.Drawing.Size(257, 21);
			this.cmbAction.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(6, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 13);
			this.label4.TabIndex = 65;
			this.label4.Text = "Secure connection";
			// 
			// txtUrl
			// 
			this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtUrl.Location = new System.Drawing.Point(496, 70);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(293, 20);
			this.txtUrl.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(385, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 13);
			this.label6.TabIndex = 66;
			this.label6.Text = "Url";
			// 
			// cbSubmitEditForm
			// 
			this.cbSubmitEditForm.AutoSize = true;
			this.cbSubmitEditForm.Location = new System.Drawing.Point(18, 199);
			this.cbSubmitEditForm.Name = "cbSubmitEditForm";
			this.cbSubmitEditForm.Size = new System.Drawing.Size(102, 17);
			this.cbSubmitEditForm.TabIndex = 8;
			this.cbSubmitEditForm.Text = "Submit EditForm";
			this.cbSubmitEditForm.UseVisualStyleBackColor = true;
			// 
			// cmbSecureConnection
			// 
			this.cmbSecureConnection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSecureConnection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSecureConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbSecureConnection.FormattingEnabled = true;
			this.cmbSecureConnection.Location = new System.Drawing.Point(141, 93);
			this.cmbSecureConnection.Name = "cmbSecureConnection";
			this.cmbSecureConnection.Size = new System.Drawing.Size(293, 21);
			this.cmbSecureConnection.TabIndex = 0;
			// 
			// txtLabel
			// 
			this.txtLabel.Location = new System.Drawing.Point(107, 70);
			this.txtLabel.Name = "txtLabel";
			this.txtLabel.Size = new System.Drawing.Size(257, 20);
			this.txtLabel.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 64;
			this.label3.Text = "Action";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 63;
			this.label2.Text = "Label";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 62;
			this.label1.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(107, 44);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(257, 20);
			this.txtName.TabIndex = 0;
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(385, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 69;
			this.label5.Text = "Title";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(455, 203);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 70;
			this.label7.Text = "Description";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(496, 44);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(293, 20);
			this.txtTitle.TabIndex = 1;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(458, 242);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(331, 114);
			this.txtDescription.TabIndex = 7;
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
			// txtNextActionName
			// 
			this.txtNextActionName.Location = new System.Drawing.Point(496, 97);
			this.txtNextActionName.Name = "txtNextActionName";
			this.txtNextActionName.Size = new System.Drawing.Size(293, 20);
			this.txtNextActionName.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(385, 97);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 13);
			this.label8.TabIndex = 73;
			this.label8.Text = "Next Action Name";
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
			this.groupBox5.Controls.Add(this.lbSecurity);
			this.groupBox5.Controls.Add(this.btnEditSecurity);
			this.groupBox5.Controls.Add(this.btnAddSecurity);
			this.groupBox5.Controls.Add(this.btnDeleteSecurity);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.cmbSecureConnection);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox5.Location = new System.Drawing.Point(9, 230);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(443, 126);
			this.groupBox5.TabIndex = 8;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "SECURITY";
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
			this.btnEditSecurity.Click += new System.EventHandler(this.btnEditSecurity_Click);
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
			this.btnAddSecurity.Click += new System.EventHandler(this.btnAddSecurity_Click);
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
			this.btnDeleteSecurity.Click += new System.EventHandler(this.btnDeleteSecurity_Click);
			// 
			// txtExecActionName
			// 
			this.txtExecActionName.Location = new System.Drawing.Point(496, 123);
			this.txtExecActionName.Name = "txtExecActionName";
			this.txtExecActionName.Size = new System.Drawing.Size(293, 20);
			this.txtExecActionName.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(385, 122);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(95, 13);
			this.label9.TabIndex = 76;
			this.label9.Text = "Exec Action Name";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(385, 159);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 13);
			this.label10.TabIndex = 80;
			this.label10.Text = "FORM Name";
			// 
			// cmbTableName
			// 
			this.cmbTableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbTableName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbTableName.FormattingEnabled = true;
			this.cmbTableName.Location = new System.Drawing.Point(105, 155);
			this.cmbTableName.Name = "cmbTableName";
			this.cmbTableName.Size = new System.Drawing.Size(257, 21);
			this.cmbTableName.TabIndex = 77;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(11, 159);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 13);
			this.label11.TabIndex = 79;
			this.label11.Text = "TABLE Name";
			// 
			// cmbFormName
			// 
			this.cmbFormName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbFormName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbFormName.FormattingEnabled = true;
			this.cmbFormName.Location = new System.Drawing.Point(496, 151);
			this.cmbFormName.Name = "cmbFormName";
			this.cmbFormName.Size = new System.Drawing.Size(293, 21);
			this.cmbFormName.TabIndex = 81;
			// 
			// TableActionCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cmbFormName);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cmbTableName);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtExecActionName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.txtNextActionName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmbAction);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbSubmitEditForm);
			this.Controls.Add(this.txtLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TableActionCtrl";
			this.Size = new System.Drawing.Size(803, 436);
			this.Title = "Action";
			this.Controls.SetChildIndex(this.titlePanel, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.txtLabel, 0);
			this.Controls.SetChildIndex(this.cbSubmitEditForm, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.txtUrl, 0);
			this.Controls.SetChildIndex(this.cmbAction, 0);
			this.Controls.SetChildIndex(this.txtName, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.txtTitle, 0);
			this.Controls.SetChildIndex(this.txtDescription, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.txtNextActionName, 0);
			this.Controls.SetChildIndex(this.groupBox5, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.txtExecActionName, 0);
			this.Controls.SetChildIndex(this.label11, 0);
			this.Controls.SetChildIndex(this.cmbTableName, 0);
			this.Controls.SetChildIndex(this.label10, 0);
			this.Controls.SetChildIndex(this.cmbFormName, 0);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

				private System.Windows.Forms.ComboBox cmbAction;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.TextBox txtUrl;
				private System.Windows.Forms.Label label6;
				private System.Windows.Forms.CheckBox cbSubmitEditForm;
				private System.Windows.Forms.ComboBox cmbSecureConnection;
				private System.Windows.Forms.TextBox txtLabel;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.TextBox txtName;
				private System.Windows.Forms.CheckBox cbRequired;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.Label label7;
				private System.Windows.Forms.TextBox txtTitle;
				private System.Windows.Forms.TextBox txtDescription;
				private System.Windows.Forms.TextBox textBox1;
				private System.Windows.Forms.TextBox textBox2;
				private System.Windows.Forms.TextBox txtAttributeName;
				private System.Windows.Forms.TextBox txtNextActionName;
				private System.Windows.Forms.Label label8;
				private System.Windows.Forms.ComboBox cmbFieldType;
				private System.Windows.Forms.ComboBox cmbFieldSource;
				private System.Windows.Forms.TextBox txtActionName;
				private System.Windows.Forms.GroupBox groupBox5;
				private System.Windows.Forms.ListBox lbSecurity;
				private System.Windows.Forms.Button btnEditSecurity;
				private System.Windows.Forms.Button btnAddSecurity;
				private System.Windows.Forms.Button btnDeleteSecurity;
				private System.Windows.Forms.TextBox txtExecActionName;
				private System.Windows.Forms.Label label9;
				private System.Windows.Forms.Label label10;
				private System.Windows.Forms.ComboBox cmbTableName;
				private System.Windows.Forms.Label label11;
				private System.Windows.Forms.ComboBox cmbFormName;

		}
}
