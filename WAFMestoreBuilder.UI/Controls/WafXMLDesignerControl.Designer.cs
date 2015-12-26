namespace WAFMetastoreBuilder.UI
{
	partial class WafXMLDesignerControl
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WafXMLDesignerControl));
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Action name = a1");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Action name = a2");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Field name = f1");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("FormMenuAction name =");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("FormField name =");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("LinkedForm name =");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Form", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Table name =", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode7});
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Metastore", new System.Windows.Forms.TreeNode[] {
            treeNode8});
			this.treeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newFormMenuActionStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newFormFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newSearchFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newLinkedFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.metastoreXMLTreeView = new System.Windows.Forms.TreeView();
			this.newStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newSystemStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newIncludeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.treeContextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
			this.mainSplitContainer.Panel1.SuspendLayout();
			this.mainSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeContextMenuStrip
			// 
			this.treeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.treeContextMenuStrip.Name = "fetchXMLTreeContextMenuStrip";
			this.treeContextMenuStrip.Size = new System.Drawing.Size(153, 120);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newActionToolStripMenuItem,
            this.newFormMenuActionStripMenuItem,
            this.newFieldToolStripMenuItem,
            this.newFormFieldToolStripMenuItem,
            this.newSearchFieldToolStripMenuItem,
            this.newTableToolStripMenuItem,
            this.newSearchToolStripMenuItem,
            this.newFormToolStripMenuItem,
            this.newLinkedFormToolStripMenuItem,
            this.newIncludeToolStripMenuItem,
            this.newStringToolStripMenuItem,
            this.newSystemStringToolStripMenuItem});
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text = "Add";
			// 
			// newActionToolStripMenuItem
			// 
			this.newActionToolStripMenuItem.Name = "newActionToolStripMenuItem";
			this.newActionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newActionToolStripMenuItem.Text = "Action";
			this.newActionToolStripMenuItem.Visible = false;
			this.newActionToolStripMenuItem.Click += new System.EventHandler(this.actionToolStripMenuItem_Click);
			// 
			// newFormMenuActionStripMenuItem
			// 
			this.newFormMenuActionStripMenuItem.Name = "newFormMenuActionStripMenuItem";
			this.newFormMenuActionStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newFormMenuActionStripMenuItem.Text = "FormMenuAction";
			this.newFormMenuActionStripMenuItem.Visible = false;
			this.newFormMenuActionStripMenuItem.Click += new System.EventHandler(this.formMenuActionStripMenuItem_Click);
			// 
			// newFieldToolStripMenuItem
			// 
			this.newFieldToolStripMenuItem.Name = "newFieldToolStripMenuItem";
			this.newFieldToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newFieldToolStripMenuItem.Text = "Field";
			this.newFieldToolStripMenuItem.Visible = false;
			this.newFieldToolStripMenuItem.Click += new System.EventHandler(this.fieldToolStripMenuItem_Click);
			// 
			// newFormFieldToolStripMenuItem
			// 
			this.newFormFieldToolStripMenuItem.Name = "newFormFieldToolStripMenuItem";
			this.newFormFieldToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newFormFieldToolStripMenuItem.Text = "FormField";
			this.newFormFieldToolStripMenuItem.Visible = false;
			this.newFormFieldToolStripMenuItem.Click += new System.EventHandler(this.formFieldToolStripMenuItem_Click);
			// 
			// newSearchFieldToolStripMenuItem
			// 
			this.newSearchFieldToolStripMenuItem.Name = "newSearchFieldToolStripMenuItem";
			this.newSearchFieldToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newSearchFieldToolStripMenuItem.Text = "SearchField";
			this.newSearchFieldToolStripMenuItem.Visible = false;
			this.newSearchFieldToolStripMenuItem.Click += new System.EventHandler(this.newSearchFieldToolStripMenuItem_Click);
			// 
			// newTableToolStripMenuItem
			// 
			this.newTableToolStripMenuItem.Name = "newTableToolStripMenuItem";
			this.newTableToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newTableToolStripMenuItem.Text = "Table";
			this.newTableToolStripMenuItem.Visible = false;
			this.newTableToolStripMenuItem.Click += new System.EventHandler(this.newTableToolStripMenuItem_Click);
			// 
			// newSearchToolStripMenuItem
			// 
			this.newSearchToolStripMenuItem.Name = "newSearchToolStripMenuItem";
			this.newSearchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newSearchToolStripMenuItem.Text = "Search";
			this.newSearchToolStripMenuItem.Visible = false;
			this.newSearchToolStripMenuItem.Click += new System.EventHandler(this.newSearchToolStripMenuItem_Click);
			// 
			// newFormToolStripMenuItem
			// 
			this.newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
			this.newFormToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newFormToolStripMenuItem.Text = "Form";
			this.newFormToolStripMenuItem.Visible = false;
			this.newFormToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
			// 
			// newLinkedFormToolStripMenuItem
			// 
			this.newLinkedFormToolStripMenuItem.Name = "newLinkedFormToolStripMenuItem";
			this.newLinkedFormToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newLinkedFormToolStripMenuItem.Text = "LinkedForm";
			this.newLinkedFormToolStripMenuItem.Visible = false;
			this.newLinkedFormToolStripMenuItem.Click += new System.EventHandler(this.linkFormToolStripMenuItem_Click);
			// 
			// saveToXMLToolStripMenuItem
			// 
			this.saveToXMLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToXMLToolStripMenuItem.Image")));
			this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
			this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveToXMLToolStripMenuItem.Text = "Save To XML";
			this.saveToXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXMLToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// mainSplitContainer
			// 
			this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.mainSplitContainer.Name = "mainSplitContainer";
			// 
			// mainSplitContainer.Panel1
			// 
			this.mainSplitContainer.Panel1.Controls.Add(this.metastoreXMLTreeView);
			this.mainSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// mainSplitContainer.Panel2
			// 
			this.mainSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.mainSplitContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.mainSplitContainer.Size = new System.Drawing.Size(956, 518);
			this.mainSplitContainer.SplitterDistance = 301;
			this.mainSplitContainer.SplitterWidth = 5;
			this.mainSplitContainer.TabIndex = 4;
			// 
			// metastoreXMLTreeView
			// 
			this.metastoreXMLTreeView.ContextMenuStrip = this.treeContextMenuStrip;
			this.metastoreXMLTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metastoreXMLTreeView.Location = new System.Drawing.Point(0, 0);
			this.metastoreXMLTreeView.Name = "metastoreXMLTreeView";
			treeNode1.Name = "AttributesNode";
			treeNode1.Tag = "attribute";
			treeNode1.Text = "Action name = a1";
			treeNode2.Name = "ActionNode2";
			treeNode2.Text = "Action name = a2";
			treeNode3.Name = "FieldNode1";
			treeNode3.Text = "Field name = f1";
			treeNode4.Name = "FormMenuActionNode";
			treeNode4.Text = "FormMenuAction name =";
			treeNode5.Name = "FormFieldNode";
			treeNode5.Tag = "condition";
			treeNode5.Text = "FormField name =";
			treeNode6.Name = "LinkEntityNode";
			treeNode6.Tag = "linkedEntity";
			treeNode6.Text = "LinkedForm name =";
			treeNode7.Name = "FormNode";
			treeNode7.Tag = "filter";
			treeNode7.Text = "Form";
			treeNode8.Name = "TableNode";
			treeNode8.Tag = "entity";
			treeNode8.Text = "Table name =";
			treeNode9.Name = "RootNode";
			treeNode9.Text = "Metastore";
			this.metastoreXMLTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
			this.metastoreXMLTreeView.Size = new System.Drawing.Size(301, 518);
			this.metastoreXMLTreeView.TabIndex = 1;
			this.metastoreXMLTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.metastoreXMLTreeView_BeforeSelect);
			this.metastoreXMLTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.metastoreXMLTreeView_AfterSelect);
			// 
			// newStringToolStripMenuItem
			// 
			this.newStringToolStripMenuItem.Name = "newStringToolStripMenuItem";
			this.newStringToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newStringToolStripMenuItem.Text = "STRING";
			this.newStringToolStripMenuItem.Click += new System.EventHandler(this.newStringToolStripMenuItem_Click);
			// 
			// newSystemStringToolStripMenuItem
			// 
			this.newSystemStringToolStripMenuItem.Name = "newSystemStringToolStripMenuItem";
			this.newSystemStringToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newSystemStringToolStripMenuItem.Text = "SYSTEM STRING";
			this.newSystemStringToolStripMenuItem.Click += new System.EventHandler(this.newSystemStringToolStripMenuItem_Click);
			// 
			// newIncludeToolStripMenuItem
			// 
			this.newIncludeToolStripMenuItem.Name = "newIncludeToolStripMenuItem";
			this.newIncludeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.newIncludeToolStripMenuItem.Text = "INCLUDE";
			this.newIncludeToolStripMenuItem.Click += new System.EventHandler(this.newIncludeToolStripMenuItem_Click);
			// 
			// WafXMLDesignerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainSplitContainer);
			this.Name = "WafXMLDesignerControl";
			this.Size = new System.Drawing.Size(956, 518);
			this.Load += new System.EventHandler(this.WafXMLDesignerControl_Load);
			this.treeContextMenuStrip.ResumeLayout(false);
			this.mainSplitContainer.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
			this.mainSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip treeContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newActionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newFieldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newFormToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newLinkedFormToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.SplitContainer mainSplitContainer;
		private System.Windows.Forms.TreeView metastoreXMLTreeView;
		private System.Windows.Forms.ToolStripMenuItem newFormMenuActionStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newFormFieldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newTableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newSearchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newSearchFieldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newStringToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newSystemStringToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newIncludeToolStripMenuItem;
	}
}
