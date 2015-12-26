namespace WAFMetastoreBuilder.UI
{
	partial class WafXMLDesignerForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WafXMLDesignerForm));
			this.commonSplitContainer = new System.Windows.Forms.SplitContainer();
			this.metastoreXMLControl = new WAFMetastoreBuilder.UI.WafXMLDesignerControl();
			this.runToolStrip = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.addToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.saveToXMLToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.commonSplitContainer)).BeginInit();
			this.commonSplitContainer.Panel1.SuspendLayout();
			this.commonSplitContainer.Panel2.SuspendLayout();
			this.commonSplitContainer.SuspendLayout();
			this.runToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// commonSplitContainer
			// 
			this.commonSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.commonSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.commonSplitContainer.Name = "commonSplitContainer";
			this.commonSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// commonSplitContainer.Panel1
			// 
			this.commonSplitContainer.Panel1.Controls.Add(this.metastoreXMLControl);
			this.commonSplitContainer.Panel1.Controls.Add(this.runToolStrip);
			// 
			// commonSplitContainer.Panel2
			// 
			this.commonSplitContainer.Panel2.Controls.Add(this.resultRichTextBox);
			this.commonSplitContainer.Size = new System.Drawing.Size(998, 571);
			this.commonSplitContainer.SplitterDistance = 542;
			this.commonSplitContainer.TabIndex = 0;
			// 
			// metastoreXMLControl
			// 
			this.metastoreXMLControl.CurrentMetastore = null;
			this.metastoreXMLControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metastoreXMLControl.Location = new System.Drawing.Point(0, 25);
			this.metastoreXMLControl.Name = "metastoreXMLControl";
			this.metastoreXMLControl.Size = new System.Drawing.Size(998, 517);
			this.metastoreXMLControl.TabIndex = 1;
			// 
			// runToolStrip
			// 
			this.runToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.addToolStripButton,
            this.saveToXMLToolStripButton});
			this.runToolStrip.Location = new System.Drawing.Point(0, 0);
			this.runToolStrip.Name = "runToolStrip";
			this.runToolStrip.Size = new System.Drawing.Size(998, 25);
			this.runToolStrip.TabIndex = 0;
			this.runToolStrip.Text = "Run";
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.newToolStripButton.Size = new System.Drawing.Size(54, 22);
			this.newToolStripButton.Text = "New ";
			this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(65, 22);
			this.openToolStripButton.Text = "Open";
			this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// addToolStripButton
			// 
			this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
			this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addToolStripButton.Name = "addToolStripButton";
			this.addToolStripButton.Size = new System.Drawing.Size(58, 22);
			this.addToolStripButton.Text = "Add";
			this.addToolStripButton.Visible = false;
			// 
			// saveToXMLToolStripButton
			// 
			this.saveToXMLToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToXMLToolStripButton.Image")));
			this.saveToXMLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToXMLToolStripButton.Name = "saveToXMLToolStripButton";
			this.saveToXMLToolStripButton.Size = new System.Drawing.Size(151, 22);
			this.saveToXMLToolStripButton.Text = "Save To Metastore XML";
			this.saveToXMLToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// resultRichTextBox
			// 
			this.resultRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resultRichTextBox.Location = new System.Drawing.Point(0, 0);
			this.resultRichTextBox.Name = "resultRichTextBox";
			this.resultRichTextBox.Size = new System.Drawing.Size(998, 25);
			this.resultRichTextBox.TabIndex = 1;
			this.resultRichTextBox.Text = "";
			// 
			// WafXMLDesignerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 571);
			this.Controls.Add(this.commonSplitContainer);
			this.Name = "WafXMLDesignerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Metastore XML designer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.commonSplitContainer.Panel1.ResumeLayout(false);
			this.commonSplitContainer.Panel1.PerformLayout();
			this.commonSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.commonSplitContainer)).EndInit();
			this.commonSplitContainer.ResumeLayout(false);
			this.runToolStrip.ResumeLayout(false);
			this.runToolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer commonSplitContainer;
		private System.Windows.Forms.ToolStrip runToolStrip;
		private System.Windows.Forms.ToolStripDropDownButton addToolStripButton;
		private System.Windows.Forms.RichTextBox resultRichTextBox;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripDropDownButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToXMLToolStripButton;
		private WafXMLDesignerControl metastoreXMLControl;
	}
}

