namespace WAFMetastoreBuilder.UI
{
    partial class BaseWAFCtrl
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
			this.titlePanel = new System.Windows.Forms.Panel();
			this.lnkParentElement = new System.Windows.Forms.LinkLabel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.actionsPanel = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.splitlabel = new System.Windows.Forms.Label();
			this.titlePanel.SuspendLayout();
			this.actionsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.titlePanel.BackColor = System.Drawing.SystemColors.Control;
			this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.titlePanel.Controls.Add(this.lnkParentElement);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(581, 39);
			this.titlePanel.TabIndex = 0;
			// 
			// lnkParentElement
			// 
			this.lnkParentElement.AutoSize = true;
			this.lnkParentElement.Location = new System.Drawing.Point(126, 14);
			this.lnkParentElement.Name = "lnkParentElement";
			this.lnkParentElement.Size = new System.Drawing.Size(37, 13);
			this.lnkParentElement.TabIndex = 2;
			this.lnkParentElement.TabStop = true;
			this.lnkParentElement.Text = "parent";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(3, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(43, 20);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Title";
			// 
			// actionsPanel
			// 
			this.actionsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.actionsPanel.Controls.Add(this.btnCancel);
			this.actionsPanel.Controls.Add(this.btnSave);
			this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.actionsPanel.Location = new System.Drawing.Point(0, 350);
			this.actionsPanel.MinimumSize = new System.Drawing.Size(500, 57);
			this.actionsPanel.Name = "actionsPanel";
			this.actionsPanel.Size = new System.Drawing.Size(581, 57);
			this.actionsPanel.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Enabled = false;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(90, 15);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Enabled = false;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(9, 15);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// splitlabel
			// 
			this.splitlabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.splitlabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.splitlabel.Location = new System.Drawing.Point(0, 348);
			this.splitlabel.Name = "splitlabel";
			this.splitlabel.Size = new System.Drawing.Size(581, 2);
			this.splitlabel.TabIndex = 2;
			// 
			// BaseWAFCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this.splitlabel);
			this.Controls.Add(this.actionsPanel);
			this.Controls.Add(this.titlePanel);
			this.Name = "BaseWAFCtrl";
			this.Size = new System.Drawing.Size(581, 407);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.actionsPanel.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionsPanel;
				private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label splitlabel;
				private System.Windows.Forms.Button btnSave;
                public System.Windows.Forms.Label titleLabel;
                public System.Windows.Forms.Panel titlePanel;
                public System.Windows.Forms.LinkLabel lnkParentElement;
    }
}
