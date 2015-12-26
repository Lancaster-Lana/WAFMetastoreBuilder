namespace WAFMetastoreBuilder.UI
{
	partial class FormMenuActionCtrl
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
			this.addButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.lbAvailableActions = new System.Windows.Forms.ListBox();
			this.lbVisibleActions = new System.Windows.Forms.ListBox();
			this.availableActionsListBox = new System.Windows.Forms.ListBox();
			this.visibleActionsListBox = new System.Windows.Forms.ListBox();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Size = new System.Drawing.Size(164, 20);
			this.titleLabel.Text = "Form Menu Actions";
			// 
			// titlePanel
			// 
			this.titlePanel.Size = new System.Drawing.Size(664, 39);
			// 
			// lnkParentElement
			// 
			this.lnkParentElement.Location = new System.Drawing.Point(211, 14);
			// 
			// addButton
			// 
			this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.addButton.Location = new System.Drawing.Point(289, 118);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(51, 23);
			this.addButton.TabIndex = 0;
			this.addButton.Text = ">";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.removeButton.Location = new System.Drawing.Point(289, 147);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(51, 23);
			this.removeButton.TabIndex = 1;
			this.removeButton.Text = "<";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// lbAvailableActions
			// 
			this.lbAvailableActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbAvailableActions.FormattingEnabled = true;
			this.lbAvailableActions.Location = new System.Drawing.Point(0, 38);
			this.lbAvailableActions.Name = "lbAvailableActions";
			this.lbAvailableActions.Size = new System.Drawing.Size(283, 225);
			this.lbAvailableActions.TabIndex = 2;
			// 
			// lbVisibleActions
			// 
			this.lbVisibleActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbVisibleActions.FormattingEnabled = true;
			this.lbVisibleActions.Location = new System.Drawing.Point(346, 38);
			this.lbVisibleActions.Name = "lbVisibleActions";
			this.lbVisibleActions.Size = new System.Drawing.Size(318, 225);
			this.lbVisibleActions.TabIndex = 3;
			// 
			// availableActionsListBox
			// 
			this.availableActionsListBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.availableActionsListBox.FormattingEnabled = true;
			this.availableActionsListBox.Location = new System.Drawing.Point(0, 38);
			this.availableActionsListBox.Name = "availableActionsListBox";
			this.availableActionsListBox.Size = new System.Drawing.Size(165, 200);
			this.availableActionsListBox.TabIndex = 2;
			// 
			// visibleActionsListBox
			// 
			this.visibleActionsListBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.visibleActionsListBox.FormattingEnabled = true;
			this.visibleActionsListBox.Location = new System.Drawing.Point(228, 38);
			this.visibleActionsListBox.Name = "visibleActionsListBox";
			this.visibleActionsListBox.Size = new System.Drawing.Size(184, 200);
			this.visibleActionsListBox.TabIndex = 3;
			// 
			// FormMenuActionCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbAvailableActions);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.lbVisibleActions);
			this.Controls.Add(this.addButton);
			this.Name = "FormMenuActionCtrl";
			this.Size = new System.Drawing.Size(664, 322);
			this.Title = "Form Menu Actions";
			this.Controls.SetChildIndex(this.titlePanel, 0);
			this.Controls.SetChildIndex(this.addButton, 0);
			this.Controls.SetChildIndex(this.lbVisibleActions, 0);
			this.Controls.SetChildIndex(this.removeButton, 0);
			this.Controls.SetChildIndex(this.lbAvailableActions, 0);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox lbAvailableActions;
        private System.Windows.Forms.ListBox lbVisibleActions;
				private System.Windows.Forms.ListBox availableAttributesListBox;
				private System.Windows.Forms.ListBox availableActionsListBox;
				private System.Windows.Forms.ListBox visibleActionsListBox;
    }
}
