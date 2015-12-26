namespace WAFMetastoreBuilder.UI
{
    partial class MetastoreCtrl
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
			this.txtAppName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbSearchSystemString = new System.Windows.Forms.ComboBox();
			this.btnEditSystemString = new System.Windows.Forms.Button();
			this.btnAddSystemString = new System.Windows.Forms.Button();
			this.btnDeleteSystemString = new System.Windows.Forms.Button();
			this.lbSystemStrings = new System.Windows.Forms.ListBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cmbSearchInclude = new System.Windows.Forms.ComboBox();
			this.lbIncludes = new System.Windows.Forms.ListBox();
			this.btnEditInclude = new System.Windows.Forms.Button();
			this.btnAddInclude = new System.Windows.Forms.Button();
			this.btnDeleteInclude = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbSearchString = new System.Windows.Forms.ComboBox();
			this.btnEditString = new System.Windows.Forms.Button();
			this.btnAddString = new System.Windows.Forms.Button();
			this.btnDeleteString = new System.Windows.Forms.Button();
			this.lbStrings = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSearchTable = new System.Windows.Forms.ComboBox();
			this.btnEditTable = new System.Windows.Forms.Button();
			this.btnAddTable = new System.Windows.Forms.Button();
			this.btnDeleteTable = new System.Windows.Forms.Button();
			this.lbTables = new System.Windows.Forms.ListBox();
			this.titlePanel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Size = new System.Drawing.Size(90, 20);
			this.titleLabel.Text = "Metastore";
			// 
			// titlePanel
			// 
			this.titlePanel.Size = new System.Drawing.Size(736, 37);
			// 
			// lnkParentElement
			// 
			this.lnkParentElement.Location = new System.Drawing.Point(249, 14);
			this.lnkParentElement.Size = new System.Drawing.Size(120, 13);
			this.lnkParentElement.Text = "This is a ROOT element";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(155, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Application Name";
			// 
			// txtAppName
			// 
			this.txtAppName.Location = new System.Drawing.Point(254, 43);
			this.txtAppName.Name = "txtAppName";
			this.txtAppName.Size = new System.Drawing.Size(370, 20);
			this.txtAppName.TabIndex = 16;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbSearchSystemString);
			this.groupBox2.Controls.Add(this.btnEditSystemString);
			this.groupBox2.Controls.Add(this.btnAddSystemString);
			this.groupBox2.Controls.Add(this.btnDeleteSystemString);
			this.groupBox2.Controls.Add(this.lbSystemStrings);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(9, 407);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(724, 102);
			this.groupBox2.TabIndex = 26;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "SYSTEM STRINGS";
			// 
			// cmbSearchSystemString
			// 
			this.cmbSearchSystemString.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSearchSystemString.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSearchSystemString.BackColor = System.Drawing.SystemColors.MenuBar;
			this.cmbSearchSystemString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbSearchSystemString.FormattingEnabled = true;
			this.cmbSearchSystemString.Location = new System.Drawing.Point(6, 19);
			this.cmbSearchSystemString.Name = "cmbSearchSystemString";
			this.cmbSearchSystemString.Size = new System.Drawing.Size(230, 21);
			this.cmbSearchSystemString.TabIndex = 5;
			this.cmbSearchSystemString.TabStop = false;
			// 
			// btnEditSystemString
			// 
			this.btnEditSystemString.Location = new System.Drawing.Point(627, 42);
			this.btnEditSystemString.Name = "btnEditSystemString";
			this.btnEditSystemString.Size = new System.Drawing.Size(75, 23);
			this.btnEditSystemString.TabIndex = 2;
			this.btnEditSystemString.Text = "Edit";
			this.btnEditSystemString.UseVisualStyleBackColor = true;
			this.btnEditSystemString.Click += new System.EventHandler(this.btnEditSystemString_Click);
			// 
			// btnAddSystemString
			// 
			this.btnAddSystemString.Location = new System.Drawing.Point(627, 13);
			this.btnAddSystemString.Name = "btnAddSystemString";
			this.btnAddSystemString.Size = new System.Drawing.Size(75, 23);
			this.btnAddSystemString.TabIndex = 1;
			this.btnAddSystemString.Text = "Add";
			this.btnAddSystemString.UseVisualStyleBackColor = true;
			this.btnAddSystemString.Click += new System.EventHandler(this.btnAddSystemString_Click);
			// 
			// btnDeleteSystemString
			// 
			this.btnDeleteSystemString.Location = new System.Drawing.Point(627, 71);
			this.btnDeleteSystemString.Name = "btnDeleteSystemString";
			this.btnDeleteSystemString.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteSystemString.TabIndex = 3;
			this.btnDeleteSystemString.Text = "Delete";
			this.btnDeleteSystemString.UseVisualStyleBackColor = true;
			this.btnDeleteSystemString.Click += new System.EventHandler(this.btnDeleteSystemString_Click);
			// 
			// lbSystemStrings
			// 
			this.lbSystemStrings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbSystemStrings.FormattingEnabled = true;
			this.lbSystemStrings.Location = new System.Drawing.Point(245, 10);
			this.lbSystemStrings.Name = "lbSystemStrings";
			this.lbSystemStrings.Size = new System.Drawing.Size(373, 82);
			this.lbSystemStrings.TabIndex = 0;
			this.lbSystemStrings.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cmbSearchInclude);
			this.groupBox4.Controls.Add(this.lbIncludes);
			this.groupBox4.Controls.Add(this.btnEditInclude);
			this.groupBox4.Controls.Add(this.btnAddInclude);
			this.groupBox4.Controls.Add(this.btnDeleteInclude);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox4.Location = new System.Drawing.Point(9, 72);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(724, 108);
			this.groupBox4.TabIndex = 25;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "INCLUDES";
			// 
			// cmbSearchInclude
			// 
			this.cmbSearchInclude.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSearchInclude.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSearchInclude.BackColor = System.Drawing.SystemColors.MenuBar;
			this.cmbSearchInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbSearchInclude.FormattingEnabled = true;
			this.cmbSearchInclude.Location = new System.Drawing.Point(6, 19);
			this.cmbSearchInclude.Name = "cmbSearchInclude";
			this.cmbSearchInclude.Size = new System.Drawing.Size(230, 21);
			this.cmbSearchInclude.TabIndex = 4;
			this.cmbSearchInclude.TabStop = false;
			// 
			// lbIncludes
			// 
			this.lbIncludes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbIncludes.FormattingEnabled = true;
			this.lbIncludes.Location = new System.Drawing.Point(245, 16);
			this.lbIncludes.Name = "lbIncludes";
			this.lbIncludes.Size = new System.Drawing.Size(373, 82);
			this.lbIncludes.TabIndex = 0;
			this.lbIncludes.TabStop = false;
			// 
			// btnEditInclude
			// 
			this.btnEditInclude.Location = new System.Drawing.Point(627, 45);
			this.btnEditInclude.Name = "btnEditInclude";
			this.btnEditInclude.Size = new System.Drawing.Size(75, 23);
			this.btnEditInclude.TabIndex = 2;
			this.btnEditInclude.Text = "Edit";
			this.btnEditInclude.UseVisualStyleBackColor = true;
			this.btnEditInclude.Click += new System.EventHandler(this.btnEditInclude_Click);
			// 
			// btnAddInclude
			// 
			this.btnAddInclude.Location = new System.Drawing.Point(627, 16);
			this.btnAddInclude.Name = "btnAddInclude";
			this.btnAddInclude.Size = new System.Drawing.Size(75, 23);
			this.btnAddInclude.TabIndex = 1;
			this.btnAddInclude.Text = "Add";
			this.btnAddInclude.UseVisualStyleBackColor = true;
			this.btnAddInclude.Click += new System.EventHandler(this.btnAddInclude_Click);
			// 
			// btnDeleteInclude
			// 
			this.btnDeleteInclude.Location = new System.Drawing.Point(627, 74);
			this.btnDeleteInclude.Name = "btnDeleteInclude";
			this.btnDeleteInclude.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteInclude.TabIndex = 3;
			this.btnDeleteInclude.Text = "Delete";
			this.btnDeleteInclude.UseVisualStyleBackColor = true;
			this.btnDeleteInclude.Click += new System.EventHandler(this.btnDeleteInclude_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbSearchString);
			this.groupBox3.Controls.Add(this.btnEditString);
			this.groupBox3.Controls.Add(this.btnAddString);
			this.groupBox3.Controls.Add(this.btnDeleteString);
			this.groupBox3.Controls.Add(this.lbStrings);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.Location = new System.Drawing.Point(9, 295);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(724, 111);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "STRINGS";
			// 
			// cmbSearchString
			// 
			this.cmbSearchString.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSearchString.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSearchString.BackColor = System.Drawing.SystemColors.MenuBar;
			this.cmbSearchString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbSearchString.FormattingEnabled = true;
			this.cmbSearchString.Location = new System.Drawing.Point(6, 19);
			this.cmbSearchString.Name = "cmbSearchString";
			this.cmbSearchString.Size = new System.Drawing.Size(230, 21);
			this.cmbSearchString.TabIndex = 5;
			this.cmbSearchString.TabStop = false;
			// 
			// btnEditString
			// 
			this.btnEditString.Location = new System.Drawing.Point(627, 45);
			this.btnEditString.Name = "btnEditString";
			this.btnEditString.Size = new System.Drawing.Size(75, 23);
			this.btnEditString.TabIndex = 2;
			this.btnEditString.Text = "Edit";
			this.btnEditString.UseVisualStyleBackColor = true;
			this.btnEditString.Click += new System.EventHandler(this.btnEditString_Click);
			// 
			// btnAddString
			// 
			this.btnAddString.Location = new System.Drawing.Point(627, 16);
			this.btnAddString.Name = "btnAddString";
			this.btnAddString.Size = new System.Drawing.Size(75, 23);
			this.btnAddString.TabIndex = 1;
			this.btnAddString.Text = "Add";
			this.btnAddString.UseVisualStyleBackColor = true;
			this.btnAddString.Click += new System.EventHandler(this.btnAddString_Click);
			// 
			// btnDeleteString
			// 
			this.btnDeleteString.Location = new System.Drawing.Point(627, 74);
			this.btnDeleteString.Name = "btnDeleteString";
			this.btnDeleteString.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteString.TabIndex = 3;
			this.btnDeleteString.Text = "Delete";
			this.btnDeleteString.UseVisualStyleBackColor = true;
			this.btnDeleteString.Click += new System.EventHandler(this.btnDeleteString_Click);
			// 
			// lbStrings
			// 
			this.lbStrings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbStrings.FormattingEnabled = true;
			this.lbStrings.Location = new System.Drawing.Point(245, 16);
			this.lbStrings.Name = "lbStrings";
			this.lbStrings.Size = new System.Drawing.Size(373, 82);
			this.lbStrings.TabIndex = 0;
			this.lbStrings.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbSearchTable);
			this.groupBox1.Controls.Add(this.btnEditTable);
			this.groupBox1.Controls.Add(this.btnAddTable);
			this.groupBox1.Controls.Add(this.btnDeleteTable);
			this.groupBox1.Controls.Add(this.lbTables);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(9, 184);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(724, 105);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TABLES";
			// 
			// cmbSearchTable
			// 
			this.cmbSearchTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSearchTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSearchTable.BackColor = System.Drawing.SystemColors.MenuBar;
			this.cmbSearchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbSearchTable.FormattingEnabled = true;
			this.cmbSearchTable.Location = new System.Drawing.Point(6, 19);
			this.cmbSearchTable.Name = "cmbSearchTable";
			this.cmbSearchTable.Size = new System.Drawing.Size(230, 21);
			this.cmbSearchTable.TabIndex = 5;
			this.cmbSearchTable.TabStop = false;
			// 
			// btnEditTable
			// 
			this.btnEditTable.Location = new System.Drawing.Point(627, 45);
			this.btnEditTable.Name = "btnEditTable";
			this.btnEditTable.Size = new System.Drawing.Size(75, 23);
			this.btnEditTable.TabIndex = 2;
			this.btnEditTable.Text = "Edit";
			this.btnEditTable.UseVisualStyleBackColor = true;
			this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
			// 
			// btnAddTable
			// 
			this.btnAddTable.Location = new System.Drawing.Point(627, 16);
			this.btnAddTable.Name = "btnAddTable";
			this.btnAddTable.Size = new System.Drawing.Size(75, 23);
			this.btnAddTable.TabIndex = 1;
			this.btnAddTable.Text = "Add";
			this.btnAddTable.UseVisualStyleBackColor = true;
			this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
			// 
			// btnDeleteTable
			// 
			this.btnDeleteTable.Location = new System.Drawing.Point(627, 74);
			this.btnDeleteTable.Name = "btnDeleteTable";
			this.btnDeleteTable.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteTable.TabIndex = 3;
			this.btnDeleteTable.Text = "Delete";
			this.btnDeleteTable.UseVisualStyleBackColor = true;
			this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
			// 
			// lbTables
			// 
			this.lbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbTables.FormattingEnabled = true;
			this.lbTables.Location = new System.Drawing.Point(245, 14);
			this.lbTables.Name = "lbTables";
			this.lbTables.Size = new System.Drawing.Size(373, 82);
			this.lbTables.TabIndex = 0;
			this.lbTables.TabStop = false;
			// 
			// MetastoreCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtAppName);
			this.Controls.Add(this.label1);
			this.Name = "MetastoreCtrl";
			this.ParentElementLink = "This is a ROOT element";
			this.Size = new System.Drawing.Size(736, 573);
			this.Title = "Metastore";
			this.Controls.SetChildIndex(this.titlePanel, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txtAppName, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox3, 0);
			this.Controls.SetChildIndex(this.groupBox4, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.TextBox txtAppName;
				private System.Windows.Forms.GroupBox groupBox2;
				private System.Windows.Forms.Button btnEditSystemString;
				private System.Windows.Forms.Button btnAddSystemString;
				private System.Windows.Forms.Button btnDeleteSystemString;
				private System.Windows.Forms.ListBox lbSystemStrings;
				private System.Windows.Forms.GroupBox groupBox4;
				private System.Windows.Forms.ListBox lbIncludes;
				private System.Windows.Forms.Button btnEditInclude;
				private System.Windows.Forms.Button btnAddInclude;
				private System.Windows.Forms.Button btnDeleteInclude;
				private System.Windows.Forms.GroupBox groupBox3;
				private System.Windows.Forms.Button btnEditString;
				private System.Windows.Forms.Button btnAddString;
				private System.Windows.Forms.Button btnDeleteString;
				private System.Windows.Forms.ListBox lbStrings;
				private System.Windows.Forms.GroupBox groupBox1;
				private System.Windows.Forms.Button btnEditTable;
				private System.Windows.Forms.Button btnAddTable;
				private System.Windows.Forms.Button btnDeleteTable;
				private System.Windows.Forms.ListBox lbTables;
				private System.Windows.Forms.ComboBox cmbSearchSystemString;
				private System.Windows.Forms.ComboBox cmbSearchInclude;
				private System.Windows.Forms.ComboBox cmbSearchString;
				private System.Windows.Forms.ComboBox cmbSearchTable;
		}
}
