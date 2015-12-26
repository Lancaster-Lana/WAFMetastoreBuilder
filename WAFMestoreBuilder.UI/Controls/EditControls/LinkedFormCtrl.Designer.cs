namespace WAFMetastoreBuilder.UI
{
    partial class LinkedFormCtrl
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
			this.cmbFormName = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbTableName = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbFKColumn = new System.Windows.Forms.ComboBox();
			this.lnkParentTable = new System.Windows.Forms.LinkLabel();
			this.lnkParentForm = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Size = new System.Drawing.Size(108, 20);
			this.titleLabel.Text = "Linked Form";
			// 
			// titlePanel
			// 
			this.titlePanel.Size = new System.Drawing.Size(788, 38);
			// 
			// lnkParentElement
			// 
			this.lnkParentElement.Location = new System.Drawing.Point(122, 14);
			// 
			// cmbFormName
			// 
			this.cmbFormName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbFormName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbFormName.FormattingEnabled = true;
			this.cmbFormName.Items.AddRange(new object[] {
            "eq ",
            "ne",
            "null",
            "not-null",
            "in",
            "between",
            "not-between",
            "like",
            "not-like",
            "yesterday",
            "today",
            "tomorrow",
            "next-seven-days",
            "last-seven-days",
            "next-week",
            "last-week",
            "last-month",
            "this-month",
            "next-month",
            "on",
            "on-or-before",
            "on-or-after",
            "last-year",
            "this-year",
            "next-year",
            "eq-userid",
            "ne-userid",
            "eq-businessid",
            "ne-businessid",
            "last-x-hours",
            "next-x-hours",
            "last-x-days",
            "next-x-days",
            "last-x-weeks",
            "next-x-weeks",
            "last-x-monthes",
            "next-x-monthes",
            "last-x-years",
            "next-x-years"});
			this.cmbFormName.Location = new System.Drawing.Point(90, 79);
			this.cmbFormName.Name = "cmbFormName";
			this.cmbFormName.Size = new System.Drawing.Size(238, 21);
			this.cmbFormName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "FORM";
			// 
			// cmbTableName
			// 
			this.cmbTableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbTableName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbTableName.FormattingEnabled = true;
			this.cmbTableName.Items.AddRange(new object[] {
            "eq ",
            "ne",
            "null",
            "not-null",
            "in",
            "between",
            "not-between",
            "like",
            "not-like",
            "yesterday",
            "today",
            "tomorrow",
            "next-seven-days",
            "last-seven-days",
            "next-week",
            "last-week",
            "last-month",
            "this-month",
            "next-month",
            "on",
            "on-or-before",
            "on-or-after",
            "last-year",
            "this-year",
            "next-year",
            "eq-userid",
            "ne-userid",
            "eq-businessid",
            "ne-businessid",
            "last-x-hours",
            "next-x-hours",
            "last-x-days",
            "next-x-days",
            "last-x-weeks",
            "next-x-weeks",
            "last-x-monthes",
            "next-x-monthes",
            "last-x-years",
            "next-x-years"});
			this.cmbTableName.Location = new System.Drawing.Point(90, 52);
			this.cmbTableName.Name = "cmbTableName";
			this.cmbTableName.Size = new System.Drawing.Size(238, 21);
			this.cmbTableName.TabIndex = 0;
			this.cmbTableName.SelectedValueChanged += new System.EventHandler(this.cmbTableName_SelectedValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "TABLE";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(359, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 13);
			this.label6.TabIndex = 50;
			this.label6.Text = "FOREIGN KEY COLUMN";
			// 
			// cmbFKColumn
			// 
			this.cmbFKColumn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbFKColumn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbFKColumn.FormattingEnabled = true;
			this.cmbFKColumn.Items.AddRange(new object[] {
            "eq ",
            "ne",
            "null",
            "not-null",
            "in",
            "between",
            "not-between",
            "like",
            "not-like",
            "yesterday",
            "today",
            "tomorrow",
            "next-seven-days",
            "last-seven-days",
            "next-week",
            "last-week",
            "last-month",
            "this-month",
            "next-month",
            "on",
            "on-or-before",
            "on-or-after",
            "last-year",
            "this-year",
            "next-year",
            "eq-userid",
            "ne-userid",
            "eq-businessid",
            "ne-businessid",
            "last-x-hours",
            "next-x-hours",
            "last-x-days",
            "next-x-days",
            "last-x-weeks",
            "next-x-weeks",
            "last-x-monthes",
            "next-x-monthes",
            "last-x-years",
            "next-x-years"});
			this.cmbFKColumn.Location = new System.Drawing.Point(493, 52);
			this.cmbFKColumn.Name = "cmbFKColumn";
			this.cmbFKColumn.Size = new System.Drawing.Size(254, 21);
			this.cmbFKColumn.TabIndex = 1;
			// 
			// lnkParentTable
			// 
			this.lnkParentTable.AutoSize = true;
			this.lnkParentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnkParentTable.Location = new System.Drawing.Point(334, 55);
			this.lnkParentTable.Name = "lnkParentTable";
			this.lnkParentTable.Size = new System.Drawing.Size(15, 13);
			this.lnkParentTable.TabIndex = 51;
			this.lnkParentTable.TabStop = true;
			this.lnkParentTable.Text = "V";
			this.lnkParentTable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkParentTable_LinkClicked);
			// 
			// lnkParentForm
			// 
			this.lnkParentForm.AutoSize = true;
			this.lnkParentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnkParentForm.Location = new System.Drawing.Point(334, 87);
			this.lnkParentForm.Name = "lnkParentForm";
			this.lnkParentForm.Size = new System.Drawing.Size(15, 13);
			this.lnkParentForm.TabIndex = 52;
			this.lnkParentForm.TabStop = true;
			this.lnkParentForm.Text = "V";
			this.lnkParentForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkParentForm_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(334, 87);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(14, 13);
			this.linkLabel2.TabIndex = 52;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "V";
			// 
			// LinkedFormCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lnkParentForm);
			this.Controls.Add(this.lnkParentTable);
			this.Controls.Add(this.cmbFKColumn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbTableName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbFormName);
			this.Controls.Add(this.label2);
			this.Name = "LinkedFormCtrl";
			this.Size = new System.Drawing.Size(788, 196);
			this.Title = "Linked Form";
			this.Controls.SetChildIndex(this.titlePanel, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.cmbFormName, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.cmbTableName, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.cmbFKColumn, 0);
			this.Controls.SetChildIndex(this.lnkParentTable, 0);
			this.Controls.SetChildIndex(this.lnkParentForm, 0);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFormName;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.ComboBox cmbTableName;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.Label label6;
				private System.Windows.Forms.ComboBox cmbFKColumn;
				private System.Windows.Forms.LinkLabel lnkParentTable;
				private System.Windows.Forms.LinkLabel lnkParentForm;
				private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
