
namespace FinalProjectMDINicholasShortt
{
    partial class formMDIParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuWindowCarInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowAverageUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuWindow,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1403, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator1,
            this.menuFileClose,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(62, 34);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Actions related to file.";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeyDisplayString = "Ctrl+N";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(329, 40);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Open a new text file.";
            this.menuFileNew.Click += new System.EventHandler(this.ClickNewTextEditor);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeyDisplayString = "Ctrl+O";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(329, 40);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Open an existing text file.";
            this.menuFileOpen.Click += new System.EventHandler(this.ClickOpenFile);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(326, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(329, 40);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Save current text file.";
            this.menuFileSave.Click += new System.EventHandler(this.ClickSave);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(329, 40);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.ToolTipText = "Save current text file using a new name.";
            this.menuFileSaveAs.Click += new System.EventHandler(this.ClickSaveAs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(326, 6);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(329, 40);
            this.menuFileClose.Text = "&Close";
            this.menuFileClose.ToolTipText = "Close current active window.";
            this.menuFileClose.Click += new System.EventHandler(this.ClickClose);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeyDisplayString = "Alt+F4";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuFileExit.Size = new System.Drawing.Size(329, 40);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Close the program";
            this.menuFileExit.Click += new System.EventHandler(this.ClickExit);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(66, 34);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.ToolTipText = "Actions related to editing file.";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(252, 40);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Copy selected text to clipboard and remove it from file.";
            this.menuEditCut.Click += new System.EventHandler(this.ClickCut);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(252, 40);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Copy selected text to clipboard.";
            this.menuEditCopy.Click += new System.EventHandler(this.ClickCopy);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(252, 40);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Paste text from clipboard to cursor.";
            this.menuEditPaste.Click += new System.EventHandler(this.ClickPaste);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowCascade,
            this.menuWindowVertical,
            this.menuWindowHorizontal,
            this.toolStripSeparator2,
            this.menuWindowCarInventory,
            this.menuWindowAverageUnits,
            this.menuWindowCustomers,
            this.toolStripSeparator3});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(107, 34);
            this.menuWindow.Text = "&Window";
            this.menuWindow.ToolTipText = "Actions related to windows.";
            // 
            // menuWindowCascade
            // 
            this.menuWindowCascade.Name = "menuWindowCascade";
            this.menuWindowCascade.Size = new System.Drawing.Size(317, 40);
            this.menuWindowCascade.Text = "&Cascade";
            this.menuWindowCascade.ToolTipText = "Organize windows in cascade order.";
            this.menuWindowCascade.Click += new System.EventHandler(this.ClickCascadeOrder);
            // 
            // menuWindowVertical
            // 
            this.menuWindowVertical.Name = "menuWindowVertical";
            this.menuWindowVertical.Size = new System.Drawing.Size(317, 40);
            this.menuWindowVertical.Text = "Tile &Vertical";
            this.menuWindowVertical.ToolTipText = "Organize windows in vertical order.";
            this.menuWindowVertical.Click += new System.EventHandler(this.ClickVerticalOrder);
            // 
            // menuWindowHorizontal
            // 
            this.menuWindowHorizontal.Name = "menuWindowHorizontal";
            this.menuWindowHorizontal.Size = new System.Drawing.Size(317, 40);
            this.menuWindowHorizontal.Text = "Tile &Horizontal";
            this.menuWindowHorizontal.ToolTipText = "Organize windows in horizontal order.";
            this.menuWindowHorizontal.Click += new System.EventHandler(this.ClickHorizontalOrder);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(314, 6);
            // 
            // menuWindowCarInventory
            // 
            this.menuWindowCarInventory.Name = "menuWindowCarInventory";
            this.menuWindowCarInventory.Size = new System.Drawing.Size(317, 40);
            this.menuWindowCarInventory.Text = "Open Car &List";
            this.menuWindowCarInventory.ToolTipText = "Open a new Car Inventory window";
            this.menuWindowCarInventory.Click += new System.EventHandler(this.ClickNewCarList);
            // 
            // menuWindowAverageUnits
            // 
            this.menuWindowAverageUnits.Name = "menuWindowAverageUnits";
            this.menuWindowAverageUnits.Size = new System.Drawing.Size(317, 40);
            this.menuWindowAverageUnits.Text = "Open &Average Units";
            this.menuWindowAverageUnits.ToolTipText = "Open a new Average Units window";
            this.menuWindowAverageUnits.Click += new System.EventHandler(this.ClickNewAverageUnits);
            // 
            // menuWindowCustomers
            // 
            this.menuWindowCustomers.Name = "menuWindowCustomers";
            this.menuWindowCustomers.Size = new System.Drawing.Size(317, 40);
            this.menuWindowCustomers.Text = "Open C&ustomers";
            this.menuWindowCustomers.ToolTipText = "Open a new Customer entry window";
            this.menuWindowCustomers.Click += new System.EventHandler(this.ClickNewCustomerList);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(314, 6);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(74, 34);
            this.menuHelp.Text = "&Help";
            this.menuHelp.ToolTipText = "Action with helpful information.";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.ShortcutKeyDisplayString = "F1";
            this.menuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuHelpAbout.Size = new System.Drawing.Size(237, 40);
            this.menuHelpAbout.Text = "&About...";
            this.menuHelpAbout.ToolTipText = "Get information about the program.";
            this.menuHelpAbout.Click += new System.EventHandler(this.ClickAbout);
            // 
            // formMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 746);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "formMDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Document Editor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem menuWindowVertical;
        private System.Windows.Forms.ToolStripMenuItem menuWindowHorizontal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuWindowCarInventory;
        private System.Windows.Forms.ToolStripMenuItem menuWindowAverageUnits;
        private System.Windows.Forms.ToolStripMenuItem menuWindowCustomers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
    }
}

