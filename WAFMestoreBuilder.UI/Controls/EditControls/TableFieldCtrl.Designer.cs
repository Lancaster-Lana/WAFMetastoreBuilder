namespace WAFMetastoreBuilder.UI
{
    partial class TableFieldCtrl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.cmbFieldType = new System.Windows.Forms.ComboBox();
            this.txtAttributeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRequired = new System.Windows.Forms.CheckBox();
            this.txtFieldSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDBColumnName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbExcludeOnSearchWhere = new System.Windows.Forms.CheckBox();
            this.ckbExcludeOnSearchForm = new System.Windows.Forms.CheckBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFKOrderClause = new System.Windows.Forms.TextBox();
            this.txtFKAdditionalWhereClause = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtReqularExpression = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReqularExpressionErrorText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmbValidValuesType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValidValues = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbSecurity = new System.Windows.Forms.ListBox();
            this.btnEditSecurity = new System.Windows.Forms.Button();
            this.btnAddSecurity = new System.Windows.Forms.Button();
            this.btnDeleteSecurity = new System.Windows.Forms.Button();
            this.cmbFieldTarget = new System.Windows.Forms.ComboBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Size = new System.Drawing.Size(48, 20);
            this.titleLabel.Text = "Field";
            // 
            // titlePanel
            // 
            this.titlePanel.Size = new System.Drawing.Size(837, 38);
            // 
            // lnkParentElement
            // 
            this.lnkParentElement.Location = new System.Drawing.Point(122, 14);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Field Type";
            // 
            // cbReadOnly
            // 
            this.cbReadOnly.AutoSize = true;
            this.cbReadOnly.Checked = true;
            this.cbReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReadOnly.Location = new System.Drawing.Point(272, 192);
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.Size = new System.Drawing.Size(73, 17);
            this.cbReadOnly.TabIndex = 9;
            this.cbReadOnly.Text = "ReadOnly";
            this.cbReadOnly.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(516, 44);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(296, 20);
            this.txtLabel.TabIndex = 1;
            // 
            // cmbFieldType
            // 
            this.cmbFieldType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFieldType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFieldType.FormattingEnabled = true;
            this.cmbFieldType.Location = new System.Drawing.Point(127, 120);
            this.cmbFieldType.Name = "cmbFieldType";
            this.cmbFieldType.Size = new System.Drawing.Size(296, 21);
            this.cmbFieldType.TabIndex = 5;
            // 
            // txtAttributeName
            // 
            this.txtAttributeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAttributeName.Location = new System.Drawing.Point(127, 94);
            this.txtAttributeName.Name = "txtAttributeName";
            this.txtAttributeName.Size = new System.Drawing.Size(296, 20);
            this.txtAttributeName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Attribute Name";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(516, 193);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(296, 108);
            this.txtComment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Comment";
            // 
            // cbRequired
            // 
            this.cbRequired.AutoSize = true;
            this.cbRequired.Checked = true;
            this.cbRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRequired.Location = new System.Drawing.Point(127, 193);
            this.cbRequired.Name = "cbRequired";
            this.cbRequired.Size = new System.Drawing.Size(69, 17);
            this.cbRequired.TabIndex = 8;
            this.cbRequired.Text = "Required";
            this.cbRequired.UseVisualStyleBackColor = true;
            // 
            // txtFieldSource
            // 
            this.txtFieldSource.Location = new System.Drawing.Point(516, 120);
            this.txtFieldSource.Name = "txtFieldSource";
            this.txtFieldSource.Size = new System.Drawing.Size(296, 20);
            this.txtFieldSource.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "FieldSource";
            // 
            // txtDBColumnName
            // 
            this.txtDBColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDBColumnName.Location = new System.Drawing.Point(151, 22);
            this.txtDBColumnName.Multiline = true;
            this.txtDBColumnName.Name = "txtDBColumnName";
            this.txtDBColumnName.Size = new System.Drawing.Size(652, 71);
            this.txtDBColumnName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "DB column";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbExcludeOnSearchWhere);
            this.groupBox1.Controls.Add(this.ckbExcludeOnSearchForm);
            this.groupBox1.Controls.Add(this.cmbSearchType);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 53);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // ckbExcludeOnSearchWhere
            // 
            this.ckbExcludeOnSearchWhere.AutoSize = true;
            this.ckbExcludeOnSearchWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbExcludeOnSearchWhere.Location = new System.Drawing.Point(650, 23);
            this.ckbExcludeOnSearchWhere.Name = "ckbExcludeOnSearchWhere";
            this.ckbExcludeOnSearchWhere.Size = new System.Drawing.Size(153, 17);
            this.ckbExcludeOnSearchWhere.TabIndex = 2;
            this.ckbExcludeOnSearchWhere.Text = "Exclude On Search Where";
            this.ckbExcludeOnSearchWhere.UseVisualStyleBackColor = true;
            // 
            // ckbExcludeOnSearchForm
            // 
            this.ckbExcludeOnSearchForm.AutoSize = true;
            this.ckbExcludeOnSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckbExcludeOnSearchForm.Location = new System.Drawing.Point(474, 24);
            this.ckbExcludeOnSearchForm.Name = "ckbExcludeOnSearchForm";
            this.ckbExcludeOnSearchForm.Size = new System.Drawing.Size(144, 17);
            this.ckbExcludeOnSearchForm.TabIndex = 1;
            this.ckbExcludeOnSearchForm.Text = "Exclude On Search Form";
            this.ckbExcludeOnSearchForm.UseVisualStyleBackColor = true;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(151, 19);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(296, 21);
            this.cmbSearchType.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(17, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Search Type";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFKOrderClause);
            this.groupBox2.Controls.Add(this.txtFKAdditionalWhereClause);
            this.groupBox2.Controls.Add(this.txtDBColumnName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 224);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DB relation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "FK_OrderClause";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "FK_AdditionalWhereClause";
            // 
            // txtFKOrderClause
            // 
            this.txtFKOrderClause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFKOrderClause.Location = new System.Drawing.Point(151, 164);
            this.txtFKOrderClause.Multiline = true;
            this.txtFKOrderClause.Name = "txtFKOrderClause";
            this.txtFKOrderClause.Size = new System.Drawing.Size(652, 54);
            this.txtFKOrderClause.TabIndex = 2;
            // 
            // txtFKAdditionalWhereClause
            // 
            this.txtFKAdditionalWhereClause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFKAdditionalWhereClause.Location = new System.Drawing.Point(151, 99);
            this.txtFKAdditionalWhereClause.Multiline = true;
            this.txtFKAdditionalWhereClause.Name = "txtFKAdditionalWhereClause";
            this.txtFKAdditionalWhereClause.Size = new System.Drawing.Size(652, 59);
            this.txtFKAdditionalWhereClause.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 36;
            // 
            // txtReqularExpression
            // 
            this.txtReqularExpression.Location = new System.Drawing.Point(127, 147);
            this.txtReqularExpression.Multiline = true;
            this.txtReqularExpression.Name = "txtReqularExpression";
            this.txtReqularExpression.Size = new System.Drawing.Size(296, 35);
            this.txtReqularExpression.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Regular Expression";
            // 
            // txtReqularExpressionErrorText
            // 
            this.txtReqularExpressionErrorText.Location = new System.Drawing.Point(516, 147);
            this.txtReqularExpressionErrorText.Multiline = true;
            this.txtReqularExpressionErrorText.Name = "txtReqularExpressionErrorText";
            this.txtReqularExpressionErrorText.Size = new System.Drawing.Size(296, 35);
            this.txtReqularExpressionErrorText.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "ErrorText";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 20);
            this.textBox4.TabIndex = 35;
            // 
            // cmbValidValuesType
            // 
            this.cmbValidValuesType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbValidValuesType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbValidValuesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbValidValuesType.FormattingEnabled = true;
            this.cmbValidValuesType.Location = new System.Drawing.Point(127, 67);
            this.cmbValidValuesType.Name = "cmbValidValuesType";
            this.cmbValidValuesType.Size = new System.Drawing.Size(296, 21);
            this.cmbValidValuesType.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(18, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Valid values Type";
            // 
            // txtValidValues
            // 
            this.txtValidValues.Location = new System.Drawing.Point(516, 70);
            this.txtValidValues.Multiline = true;
            this.txtValidValues.Name = "txtValidValues";
            this.txtValidValues.Size = new System.Drawing.Size(296, 20);
            this.txtValidValues.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(438, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Valid Values";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbSecurity);
            this.groupBox5.Controls.Add(this.btnEditSecurity);
            this.groupBox5.Controls.Add(this.btnAddSecurity);
            this.groupBox5.Controls.Add(this.btnDeleteSecurity);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(9, 216);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(429, 97);
            this.groupBox5.TabIndex = 67;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SECURITY";
            // 
            // lbSecurity
            // 
            this.lbSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSecurity.FormattingEnabled = true;
            this.lbSecurity.Location = new System.Drawing.Point(3, 16);
            this.lbSecurity.Name = "lbSecurity";
            this.lbSecurity.Size = new System.Drawing.Size(333, 69);
            this.lbSecurity.TabIndex = 0;
            this.lbSecurity.TabStop = false;
            // 
            // btnEditSecurity
            // 
            this.btnEditSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSecurity.Location = new System.Drawing.Point(342, 39);
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
            this.btnAddSecurity.Location = new System.Drawing.Point(342, 12);
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
            this.btnDeleteSecurity.Location = new System.Drawing.Point(342, 64);
            this.btnDeleteSecurity.Name = "btnDeleteSecurity";
            this.btnDeleteSecurity.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSecurity.TabIndex = 3;
            this.btnDeleteSecurity.TabStop = false;
            this.btnDeleteSecurity.Text = "Delete";
            this.btnDeleteSecurity.UseVisualStyleBackColor = true;
            this.btnDeleteSecurity.Click += new System.EventHandler(this.btnDeleteSecurity_Click);
            // 
            // cmbFieldTarget
            // 
            this.cmbFieldTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFieldTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFieldTarget.FormattingEnabled = true;
            this.cmbFieldTarget.Location = new System.Drawing.Point(516, 94);
            this.cmbFieldTarget.Name = "cmbFieldTarget";
            this.cmbFieldTarget.Size = new System.Drawing.Size(296, 21);
            this.cmbFieldTarget.TabIndex = 68;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(438, 99);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(63, 13);
            this.lblTarget.TabIndex = 69;
            this.lblTarget.Text = "Field Target";
            // 
            // TableFieldCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFieldTarget);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtValidValues);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbValidValuesType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtReqularExpressionErrorText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtReqularExpression);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFieldSource);
            this.Controls.Add(this.txtAttributeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbRequired);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFieldType);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbReadOnly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TableFieldCtrl";
            this.Size = new System.Drawing.Size(837, 661);
            this.Title = "Field";
            this.Controls.SetChildIndex(this.titlePanel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbReadOnly, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtLabel, 0);
            this.Controls.SetChildIndex(this.cmbFieldType, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtComment, 0);
            this.Controls.SetChildIndex(this.cbRequired, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtAttributeName, 0);
            this.Controls.SetChildIndex(this.txtFieldSource, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtReqularExpression, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtReqularExpressionErrorText, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cmbValidValuesType, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtValidValues, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.lblTarget, 0);
            this.Controls.SetChildIndex(this.cmbFieldTarget, 0);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.CheckBox cbReadOnly;
				private System.Windows.Forms.TextBox txtName;
				private System.Windows.Forms.TextBox txtLabel;
				private System.Windows.Forms.ComboBox cmbFieldType;
				private System.Windows.Forms.TextBox txtAttributeName;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.TextBox txtComment;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.CheckBox cbRequired;
				private System.Windows.Forms.TextBox txtFieldSource;
				private System.Windows.Forms.Label label6;
				private System.Windows.Forms.TextBox txtDBColumnName;
				private System.Windows.Forms.Label label7;
				private System.Windows.Forms.GroupBox groupBox1;
				private System.Windows.Forms.ComboBox cmbSearchType;
				private System.Windows.Forms.Label label11;
				private System.Windows.Forms.ComboBox comboBox1;
				private System.Windows.Forms.CheckBox ckbExcludeOnSearchForm;
				private System.Windows.Forms.CheckBox ckbExcludeOnSearchWhere;
				private System.Windows.Forms.GroupBox groupBox2;
				private System.Windows.Forms.Label label8;
				private System.Windows.Forms.TextBox txtFKAdditionalWhereClause;
				private System.Windows.Forms.TextBox textBox1;
				private System.Windows.Forms.TextBox txtFKOrderClause;
				private System.Windows.Forms.Label label9;
				private System.Windows.Forms.TextBox textBox2;
				private System.Windows.Forms.TextBox txtReqularExpression;
				private System.Windows.Forms.Label label10;
				private System.Windows.Forms.TextBox txtReqularExpressionErrorText;
				private System.Windows.Forms.Label label12;
				private System.Windows.Forms.TextBox textBox3;
				private System.Windows.Forms.TextBox textBox4;
				private System.Windows.Forms.ComboBox cmbValidValuesType;
				private System.Windows.Forms.Label label13;
				private System.Windows.Forms.TextBox txtValidValues;
				private System.Windows.Forms.Label label14;
				private System.Windows.Forms.GroupBox groupBox5;
				private System.Windows.Forms.ListBox lbSecurity;
				private System.Windows.Forms.Button btnEditSecurity;
				private System.Windows.Forms.Button btnAddSecurity;
				private System.Windows.Forms.Button btnDeleteSecurity;
                private System.Windows.Forms.ComboBox cmbFieldTarget;
                private System.Windows.Forms.Label lblTarget;

		}
}
