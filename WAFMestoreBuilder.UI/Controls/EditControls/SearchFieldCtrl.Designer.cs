namespace WAFMetastoreBuilder.UI
{
    partial class SearchFieldCtrl
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
            this.label1 = new System.Windows.Forms.Label();
            this.ckbExcludeOnSearchForm = new System.Windows.Forms.CheckBox();
            this.cmbFieldName = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbSecureConnection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSecurity = new System.Windows.Forms.ListBox();
            this.btnEditSecurity = new System.Windows.Forms.Button();
            this.btnAddSecurity = new System.Windows.Forms.Button();
            this.btnDeleteSecurity = new System.Windows.Forms.Button();
            this.ckbExcludeOnSearchResults = new System.Windows.Forms.CheckBox();
            this.ckbHideOnEditForm = new System.Windows.Forms.CheckBox();
            this.ckbHideOnSearchForm = new System.Windows.Forms.CheckBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Size = new System.Drawing.Size(110, 20);
            this.titleLabel.Text = "Search Field";
            // 
            // titlePanel
            // 
            this.titlePanel.Size = new System.Drawing.Size(766, 37);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // ckbExcludeOnSearchForm
            // 
            this.ckbExcludeOnSearchForm.AutoSize = true;
            this.ckbExcludeOnSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbExcludeOnSearchForm.Location = new System.Drawing.Point(12, 106);
            this.ckbExcludeOnSearchForm.Name = "ckbExcludeOnSearchForm";
            this.ckbExcludeOnSearchForm.Size = new System.Drawing.Size(144, 17);
            this.ckbExcludeOnSearchForm.TabIndex = 1;
            this.ckbExcludeOnSearchForm.Text = "Exclude On Search Form";
            this.ckbExcludeOnSearchForm.UseVisualStyleBackColor = true;
            // 
            // cmbFieldName
            // 
            this.cmbFieldName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFieldName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFieldName.FormattingEnabled = true;
            this.cmbFieldName.Location = new System.Drawing.Point(131, 43);
            this.cmbFieldName.Name = "cmbFieldName";
            this.cmbFieldName.Size = new System.Drawing.Size(231, 21);
            this.cmbFieldName.TabIndex = 16;
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
            this.groupBox5.Location = new System.Drawing.Point(9, 170);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(440, 126);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SECURITY";
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
            // ckbExcludeOnSearchResults
            // 
            this.ckbExcludeOnSearchResults.AutoSize = true;
            this.ckbExcludeOnSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbExcludeOnSearchResults.Location = new System.Drawing.Point(12, 129);
            this.ckbExcludeOnSearchResults.Name = "ckbExcludeOnSearchResults";
            this.ckbExcludeOnSearchResults.Size = new System.Drawing.Size(156, 17);
            this.ckbExcludeOnSearchResults.TabIndex = 67;
            this.ckbExcludeOnSearchResults.Text = "Exclude On Search Results";
            this.ckbExcludeOnSearchResults.UseVisualStyleBackColor = true;
            // 
            // ckbHideOnEditForm
            // 
            this.ckbHideOnEditForm.AutoSize = true;
            this.ckbHideOnEditForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbHideOnEditForm.Location = new System.Drawing.Point(188, 129);
            this.ckbHideOnEditForm.Name = "ckbHideOnEditForm";
            this.ckbHideOnEditForm.Size = new System.Drawing.Size(140, 17);
            this.ckbHideOnEditForm.TabIndex = 69;
            this.ckbHideOnEditForm.Text = "Hide On Search Results";
            this.ckbHideOnEditForm.UseVisualStyleBackColor = true;
            // 
            // ckbHideOnSearchForm
            // 
            this.ckbHideOnSearchForm.AutoSize = true;
            this.ckbHideOnSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbHideOnSearchForm.Location = new System.Drawing.Point(188, 106);
            this.ckbHideOnSearchForm.Name = "ckbHideOnSearchForm";
            this.ckbHideOnSearchForm.Size = new System.Drawing.Size(128, 17);
            this.ckbHideOnSearchForm.TabIndex = 68;
            this.ckbHideOnSearchForm.Text = "Hide On Search Form";
            this.ckbHideOnSearchForm.UseVisualStyleBackColor = true;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(131, 67);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(231, 21);
            this.cmbSearchType.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Search Type";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(449, 44);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(276, 20);
            this.txtLabel.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Label";
            // 
            // SearchFieldCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSearchType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbHideOnEditForm);
            this.Controls.Add(this.ckbHideOnSearchForm);
            this.Controls.Add(this.ckbExcludeOnSearchResults);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.cmbFieldName);
            this.Controls.Add(this.ckbExcludeOnSearchForm);
            this.Controls.Add(this.label1);
            this.Name = "SearchFieldCtrl";
            this.Size = new System.Drawing.Size(766, 359);
            this.Title = "Search Field";
            this.Controls.SetChildIndex(this.titlePanel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ckbExcludeOnSearchForm, 0);
            this.Controls.SetChildIndex(this.cmbFieldName, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.ckbExcludeOnSearchResults, 0);
            this.Controls.SetChildIndex(this.ckbHideOnSearchForm, 0);
            this.Controls.SetChildIndex(this.ckbHideOnEditForm, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbSearchType, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtLabel, 0);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.CheckBox ckbExcludeOnSearchForm;
				private System.Windows.Forms.ComboBox cmbFieldName;
				private System.Windows.Forms.GroupBox groupBox5;
				private System.Windows.Forms.ComboBox cmbSecureConnection;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.ListBox lbSecurity;
				private System.Windows.Forms.Button btnEditSecurity;
				private System.Windows.Forms.Button btnAddSecurity;
				private System.Windows.Forms.Button btnDeleteSecurity;
                private System.Windows.Forms.CheckBox ckbExcludeOnSearchResults;
                private System.Windows.Forms.CheckBox ckbHideOnEditForm;
                private System.Windows.Forms.CheckBox ckbHideOnSearchForm;
                private System.Windows.Forms.ComboBox cmbSearchType;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.TextBox txtLabel;
                private System.Windows.Forms.Label label3;

		}
}
