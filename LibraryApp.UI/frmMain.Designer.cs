namespace LibraryApp.UI
{
	partial class frmMain
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
			components = new System.ComponentModel.Container();
			documentManagerMain = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
			tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
			dockManagerMain = new DevExpress.XtraBars.Docking.DockManager(components);
			dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
			dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			navBarGroupNavigator = new DevExpress.XtraNavBar.NavBarGroup();
			navBarItemBooks = new DevExpress.XtraNavBar.NavBarItem();
			navBarItemAuthors = new DevExpress.XtraNavBar.NavBarItem();
			navBarItemCategory = new DevExpress.XtraNavBar.NavBarItem();
			navBarItemStudents = new DevExpress.XtraNavBar.NavBarItem();
			navBarItemBookTransactions = new DevExpress.XtraNavBar.NavBarItem();
			navBarItemStatistics = new DevExpress.XtraNavBar.NavBarItem();
			((System.ComponentModel.ISupportInitialize)documentManagerMain).BeginInit();
			((System.ComponentModel.ISupportInitialize)tabbedView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dockManagerMain).BeginInit();
			dockPanel1.SuspendLayout();
			dockPanel1_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)navBarControl1).BeginInit();
			SuspendLayout();
			// 
			// documentManagerMain
			// 
			documentManagerMain.MdiParent = this;
			documentManagerMain.View = tabbedView1;
			documentManagerMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView1 });
			// 
			// dockManagerMain
			// 
			dockManagerMain.Form = this;
			dockManagerMain.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] { dockPanel1 });
			dockManagerMain.TopZIndexControls.AddRange(new string[] { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl" });
			// 
			// dockPanel1
			// 
			dockPanel1.Controls.Add(dockPanel1_Container);
			dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			dockPanel1.ID = new System.Guid("5eec3591-6827-41ed-9637-dabdb21fa465");
			dockPanel1.Location = new System.Drawing.Point(0, 0);
			dockPanel1.Name = "dockPanel1";
			dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
			dockPanel1.Size = new System.Drawing.Size(200, 680);
			dockPanel1.Text = "dockPanel1";
			// 
			// dockPanel1_Container
			// 
			dockPanel1_Container.Controls.Add(navBarControl1);
			dockPanel1_Container.Location = new System.Drawing.Point(4, 32);
			dockPanel1_Container.Name = "dockPanel1_Container";
			dockPanel1_Container.Size = new System.Drawing.Size(190, 644);
			dockPanel1_Container.TabIndex = 0;
			// 
			// navBarControl1
			// 
			navBarControl1.ActiveGroup = navBarGroupNavigator;
			navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] { navBarGroupNavigator });
			navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] { navBarItemBooks, navBarItemAuthors, navBarItemCategory, navBarItemStudents, navBarItemBookTransactions, navBarItemStatistics });
			navBarControl1.Location = new System.Drawing.Point(0, 0);
			navBarControl1.Name = "navBarControl1";
			navBarControl1.OptionsNavPane.ExpandedWidth = 190;
			navBarControl1.Size = new System.Drawing.Size(190, 644);
			navBarControl1.TabIndex = 0;
			navBarControl1.Text = "navBarControl1";
			// 
			// navBarGroupNavigator
			// 
			navBarGroupNavigator.Caption = "Navigator";
			navBarGroupNavigator.Expanded = true;
			navBarGroupNavigator.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(navBarItemBooks), new DevExpress.XtraNavBar.NavBarItemLink(navBarItemAuthors), new DevExpress.XtraNavBar.NavBarItemLink(navBarItemCategory), new DevExpress.XtraNavBar.NavBarItemLink(navBarItemStudents), new DevExpress.XtraNavBar.NavBarItemLink(navBarItemBookTransactions), new DevExpress.XtraNavBar.NavBarItemLink(navBarItemStatistics) });
			navBarGroupNavigator.Name = "navBarGroupNavigator";
			// 
			// navBarItemBooks
			// 
			navBarItemBooks.Caption = "Books";
			navBarItemBooks.Name = "navBarItemBooks";
			navBarItemBooks.LinkClicked += navBarItemBooks_LinkClicked;
			// 
			// navBarItemAuthors
			// 
			navBarItemAuthors.Caption = "Authors";
			navBarItemAuthors.Name = "navBarItemAuthors";
			navBarItemAuthors.LinkClicked += navBarItemAuthors_LinkClicked;
			// 
			// navBarItemCategory
			// 
			navBarItemCategory.Caption = "Category";
			navBarItemCategory.Name = "navBarItemCategory";
			navBarItemCategory.LinkClicked += navBarItemCategory_LinkClicked;
			// 
			// navBarItemStudents
			// 
			navBarItemStudents.Caption = "Students";
			navBarItemStudents.Name = "navBarItemStudents";
			navBarItemStudents.LinkClicked += navBarItemStudents_LinkClicked;
			// 
			// navBarItemBookTransactions
			// 
			navBarItemBookTransactions.Caption = "Book Transactions";
			navBarItemBookTransactions.Name = "navBarItemBookTransactions";
			navBarItemBookTransactions.LinkClicked += navBarItemBookTransactions_LinkClicked;
			// 
			// navBarItemStatistics
			// 
			navBarItemStatistics.Caption = "Statistics";
			navBarItemStatistics.Name = "navBarItemStatistics";
			navBarItemStatistics.LinkClicked += navBarItemStatistics_LinkClicked;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1321, 680);
			Controls.Add(dockPanel1);
			IsMdiContainer = true;
			Name = "frmMain";
			Text = "frmMain";
			((System.ComponentModel.ISupportInitialize)documentManagerMain).EndInit();
			((System.ComponentModel.ISupportInitialize)tabbedView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dockManagerMain).EndInit();
			dockPanel1.ResumeLayout(false);
			dockPanel1_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)navBarControl1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraBars.Docking2010.DocumentManager documentManagerMain;
		private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
		private DevExpress.XtraNavBar.NavBarControl navBarControl1;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroupNavigator;
		private DevExpress.XtraNavBar.NavBarItem navBarItemBooks;
		private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
		private DevExpress.XtraBars.Docking.DockManager dockManagerMain;
		private DevExpress.XtraNavBar.NavBarItem navBarItemAuthors;
		private DevExpress.XtraNavBar.NavBarItem navBarItemCategory;
		private DevExpress.XtraNavBar.NavBarItem navBarItemStudents;
		private DevExpress.XtraNavBar.NavBarItem navBarItemBookTransactions;
		private DevExpress.XtraNavBar.NavBarItem navBarItemStatistics;
	}
}