/*
 * Created by SharpDevelop.
 * User: Mane
 * Date: 14.04.2014
 * Time: 15:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tEDI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newwithTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSyntaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erlangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fortran77ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fortranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freebasicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haskellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javascriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laTeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lispToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.matlabOctaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nSISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pascalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLTSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tclToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vBScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualBasicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verilogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vHDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.lineNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLineNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelComma = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelColumnNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabeCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMessageBox = new System.Windows.Forms.SplitContainer();
            this.messagesRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scintilla1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMessageBox)).BeginInit();
            this.splitContainerMessageBox.Panel1.SuspendLayout();
            this.splitContainerMessageBox.Panel2.SuspendLayout();
            this.splitContainerMessageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // scintilla1
            // 
            this.scintilla1.AllowDrop = true;
            this.scintilla1.ConfigurationManager.LoadOrder = ScintillaNET.Configuration.ConfigurationLoadOrder.UserBuiltInCustom;
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scintilla1.Indentation.TabWidth = 4;
            this.scintilla1.Lexing.Lexer = ScintillaNET.Lexer.Null;
            this.scintilla1.Lexing.LexerName = "automatic";
            this.scintilla1.Lexing.LineCommentPrefix = "";
            this.scintilla1.Lexing.StreamCommentPrefix = "";
            this.scintilla1.Lexing.StreamCommentSufix = "";
            this.scintilla1.Location = new System.Drawing.Point(0, 0);
            this.scintilla1.Margin = new System.Windows.Forms.Padding(4);
            this.scintilla1.Margins.FoldMarginColor = System.Drawing.Color.White;
            this.scintilla1.Margins.Margin0.Width = 35;
            this.scintilla1.Margins.Margin1.Width = 1;
            this.scintilla1.Margins.Margin2.Width = 10;
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(671, 557);
            this.scintilla1.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.scintilla1.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.Styles.LineNumber.ForeColor = System.Drawing.Color.Red;
            this.scintilla1.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla1.TabIndex = 6;
            this.scintilla1.SelectionChanged += new System.EventHandler(this.scintilla1_SelectionChanged);
            this.scintilla1.TextChanged += new System.EventHandler(this.scintilla1_TextChanged);
            this.scintilla1.DragDrop += new System.Windows.Forms.DragEventHandler(this.scintilla1_DragDrop);
            this.scintilla1.DragEnter += new System.Windows.Forms.DragEventHandler(this.scintilla1_DragEnter);
            this.scintilla1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scintilla1_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(671, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newwithTemplateToolStripMenuItem,
            this.toolStripSeparator5,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveCopyToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.toolStripSeparator6,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator7,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newwithTemplateToolStripMenuItem
            // 
            this.newwithTemplateToolStripMenuItem.Name = "newwithTemplateToolStripMenuItem";
            this.newwithTemplateToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.newwithTemplateToolStripMenuItem.Text = "New(with &Template)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(210, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveCopyToolStripMenuItem
            // 
            this.saveCopyToolStripMenuItem.Name = "saveCopyToolStripMenuItem";
            this.saveCopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.saveCopyToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.saveCopyToolStripMenuItem.Text = "Save &Copy";
            this.saveCopyToolStripMenuItem.Click += new System.EventHandler(this.saveCopyToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.reloadToolStripMenuItem.Text = "&Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(210, 6);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.printToolStripMenuItem.Text = "&Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.DropDownOpened += new System.EventHandler(this.editToolStripMenuItem_DropDownOpened);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.findPreviousToolStripMenuItem,
            this.findAllToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.findNextToolStripMenuItem.Text = "Find &Next";
            this.findNextToolStripMenuItem.Click += new System.EventHandler(this.findNextToolStripMenuItem_Click);
            // 
            // findPreviousToolStripMenuItem
            // 
            this.findPreviousToolStripMenuItem.Name = "findPreviousToolStripMenuItem";
            this.findPreviousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.findPreviousToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.findPreviousToolStripMenuItem.Text = "Find &Previous";
            this.findPreviousToolStripMenuItem.Click += new System.EventHandler(this.findPreviousToolStripMenuItem_Click);
            // 
            // findAllToolStripMenuItem
            // 
            this.findAllToolStripMenuItem.Name = "findAllToolStripMenuItem";
            this.findAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F3)));
            this.findAllToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.findAllToolStripMenuItem.Text = "Find &All";
            this.findAllToolStripMenuItem.Click += new System.EventHandler(this.findAllToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F3)));
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.clearAllToolStripMenuItem.Text = "&Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.replaceToolStripMenuItem.Text = "&Replace...";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem,
            this.changeSyntaxToolStripMenuItem,
            this.toolStripSeparator8,
            this.lineNumbersToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.toolStripSeparator9,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.normalSizeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.changeFontToolStripMenuItem.Text = "&Change Font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // changeSyntaxToolStripMenuItem
            // 
            this.changeSyntaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaToolStripMenuItem,
            this.assemblyToolStripMenuItem,
            this.camlToolStripMenuItem,
            this.bashToolStripMenuItem,
            this.batchFileToolStripMenuItem,
            this.cCToolStripMenuItem,
            this.cToolStripMenuItem,
            this.cMakeToolStripMenuItem,
            this.cSSToolStripMenuItem,
            this.dToolStripMenuItem,
            this.diffToolStripMenuItem,
            this.erlangToolStripMenuItem,
            this.fortran77ToolStripMenuItem,
            this.forthToolStripMenuItem,
            this.fortranToolStripMenuItem,
            this.freebasicToolStripMenuItem,
            this.haskellToolStripMenuItem,
            this.htmlToolStripMenuItem,
            this.javaToolStripMenuItem,
            this.javascriptToolStripMenuItem,
            this.laTeXToolStripMenuItem,
            this.lispToolStripMenuItem,
            this.luaToolStripMenuItem,
            this.makeToolStripMenuItem1,
            this.matlabOctaveToolStripMenuItem,
            this.nSISToolStripMenuItem,
            this.pascalToolStripMenuItem,
            this.perlToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.pythonToolStripMenuItem,
            this.rubyToolStripMenuItem,
            this.sQLTSQLToolStripMenuItem,
            this.tclToolStripMenuItem,
            this.vBScriptToolStripMenuItem,
            this.visualBasicToolStripMenuItem,
            this.verilogToolStripMenuItem,
            this.vHDLToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.yAMLToolStripMenuItem});
            this.changeSyntaxToolStripMenuItem.Name = "changeSyntaxToolStripMenuItem";
            this.changeSyntaxToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.changeSyntaxToolStripMenuItem.Text = "Change &Syntax";
            // 
            // adaToolStripMenuItem
            // 
            this.adaToolStripMenuItem.Name = "adaToolStripMenuItem";
            this.adaToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.adaToolStripMenuItem.Text = "Ada";
            this.adaToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // assemblyToolStripMenuItem
            // 
            this.assemblyToolStripMenuItem.Name = "assemblyToolStripMenuItem";
            this.assemblyToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.assemblyToolStripMenuItem.Text = "Assembly";
            this.assemblyToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // camlToolStripMenuItem
            // 
            this.camlToolStripMenuItem.Name = "camlToolStripMenuItem";
            this.camlToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.camlToolStripMenuItem.Text = "Caml";
            this.camlToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // bashToolStripMenuItem
            // 
            this.bashToolStripMenuItem.Name = "bashToolStripMenuItem";
            this.bashToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.bashToolStripMenuItem.Text = "Bash";
            this.bashToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // batchFileToolStripMenuItem
            // 
            this.batchFileToolStripMenuItem.Name = "batchFileToolStripMenuItem";
            this.batchFileToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.batchFileToolStripMenuItem.Text = "Batch File";
            this.batchFileToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // cCToolStripMenuItem
            // 
            this.cCToolStripMenuItem.Name = "cCToolStripMenuItem";
            this.cCToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.cCToolStripMenuItem.Text = "C/C++";
            this.cCToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.cToolStripMenuItem.Text = "C#";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // cMakeToolStripMenuItem
            // 
            this.cMakeToolStripMenuItem.Name = "cMakeToolStripMenuItem";
            this.cMakeToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.cMakeToolStripMenuItem.Text = "CMake";
            this.cMakeToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // cSSToolStripMenuItem
            // 
            this.cSSToolStripMenuItem.Name = "cSSToolStripMenuItem";
            this.cSSToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.cSSToolStripMenuItem.Text = "CSS";
            this.cSSToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.dToolStripMenuItem.Text = "D";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // diffToolStripMenuItem
            // 
            this.diffToolStripMenuItem.Name = "diffToolStripMenuItem";
            this.diffToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.diffToolStripMenuItem.Text = "Diff";
            this.diffToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // erlangToolStripMenuItem
            // 
            this.erlangToolStripMenuItem.Name = "erlangToolStripMenuItem";
            this.erlangToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.erlangToolStripMenuItem.Text = "Erlang";
            this.erlangToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // fortran77ToolStripMenuItem
            // 
            this.fortran77ToolStripMenuItem.Name = "fortran77ToolStripMenuItem";
            this.fortran77ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.fortran77ToolStripMenuItem.Text = "Fortran 77";
            this.fortran77ToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // forthToolStripMenuItem
            // 
            this.forthToolStripMenuItem.Name = "forthToolStripMenuItem";
            this.forthToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.forthToolStripMenuItem.Text = "Forth";
            this.forthToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // fortranToolStripMenuItem
            // 
            this.fortranToolStripMenuItem.Name = "fortranToolStripMenuItem";
            this.fortranToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.fortranToolStripMenuItem.Text = "Fortran";
            this.fortranToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // freebasicToolStripMenuItem
            // 
            this.freebasicToolStripMenuItem.Name = "freebasicToolStripMenuItem";
            this.freebasicToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.freebasicToolStripMenuItem.Text = "Freebasic";
            this.freebasicToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // haskellToolStripMenuItem
            // 
            this.haskellToolStripMenuItem.Name = "haskellToolStripMenuItem";
            this.haskellToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.haskellToolStripMenuItem.Text = "Haskell";
            this.haskellToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // htmlToolStripMenuItem
            // 
            this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
            this.htmlToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.htmlToolStripMenuItem.Text = "Html";
            this.htmlToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // javaToolStripMenuItem
            // 
            this.javaToolStripMenuItem.Name = "javaToolStripMenuItem";
            this.javaToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.javaToolStripMenuItem.Text = "Java";
            this.javaToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // javascriptToolStripMenuItem
            // 
            this.javascriptToolStripMenuItem.Name = "javascriptToolStripMenuItem";
            this.javascriptToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.javascriptToolStripMenuItem.Text = "Javascript";
            this.javascriptToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // laTeXToolStripMenuItem
            // 
            this.laTeXToolStripMenuItem.Name = "laTeXToolStripMenuItem";
            this.laTeXToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.laTeXToolStripMenuItem.Text = "LaTeX";
            this.laTeXToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // lispToolStripMenuItem
            // 
            this.lispToolStripMenuItem.Name = "lispToolStripMenuItem";
            this.lispToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.lispToolStripMenuItem.Text = "Lisp";
            this.lispToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // luaToolStripMenuItem
            // 
            this.luaToolStripMenuItem.Name = "luaToolStripMenuItem";
            this.luaToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.luaToolStripMenuItem.Text = "Lua";
            this.luaToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // makeToolStripMenuItem1
            // 
            this.makeToolStripMenuItem1.Name = "makeToolStripMenuItem1";
            this.makeToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.makeToolStripMenuItem1.Text = "Make";
            this.makeToolStripMenuItem1.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // matlabOctaveToolStripMenuItem
            // 
            this.matlabOctaveToolStripMenuItem.Name = "matlabOctaveToolStripMenuItem";
            this.matlabOctaveToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.matlabOctaveToolStripMenuItem.Text = "Matlab/Octave";
            this.matlabOctaveToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // nSISToolStripMenuItem
            // 
            this.nSISToolStripMenuItem.Name = "nSISToolStripMenuItem";
            this.nSISToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.nSISToolStripMenuItem.Text = "NSIS";
            this.nSISToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // pascalToolStripMenuItem
            // 
            this.pascalToolStripMenuItem.Name = "pascalToolStripMenuItem";
            this.pascalToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.pascalToolStripMenuItem.Text = "Pascal";
            this.pascalToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // perlToolStripMenuItem
            // 
            this.perlToolStripMenuItem.Name = "perlToolStripMenuItem";
            this.perlToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.perlToolStripMenuItem.Text = "Perl";
            this.perlToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.pHPToolStripMenuItem.Text = "PHP";
            this.pHPToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // pythonToolStripMenuItem
            // 
            this.pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            this.pythonToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.pythonToolStripMenuItem.Text = "Python";
            this.pythonToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // rubyToolStripMenuItem
            // 
            this.rubyToolStripMenuItem.Name = "rubyToolStripMenuItem";
            this.rubyToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.rubyToolStripMenuItem.Text = "Ruby";
            this.rubyToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // sQLTSQLToolStripMenuItem
            // 
            this.sQLTSQLToolStripMenuItem.Name = "sQLTSQLToolStripMenuItem";
            this.sQLTSQLToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.sQLTSQLToolStripMenuItem.Text = "SQL(T-SQL)";
            this.sQLTSQLToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // tclToolStripMenuItem
            // 
            this.tclToolStripMenuItem.Name = "tclToolStripMenuItem";
            this.tclToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.tclToolStripMenuItem.Text = "Tcl";
            this.tclToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // vBScriptToolStripMenuItem
            // 
            this.vBScriptToolStripMenuItem.Name = "vBScriptToolStripMenuItem";
            this.vBScriptToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.vBScriptToolStripMenuItem.Text = "VB Script";
            this.vBScriptToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // visualBasicToolStripMenuItem
            // 
            this.visualBasicToolStripMenuItem.Name = "visualBasicToolStripMenuItem";
            this.visualBasicToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.visualBasicToolStripMenuItem.Text = "Visual Basic";
            this.visualBasicToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // verilogToolStripMenuItem
            // 
            this.verilogToolStripMenuItem.Name = "verilogToolStripMenuItem";
            this.verilogToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.verilogToolStripMenuItem.Text = "Verilog";
            this.verilogToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // vHDLToolStripMenuItem
            // 
            this.vHDLToolStripMenuItem.Name = "vHDLToolStripMenuItem";
            this.vHDLToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.vHDLToolStripMenuItem.Text = "VHDL";
            this.vHDLToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // yAMLToolStripMenuItem
            // 
            this.yAMLToolStripMenuItem.Name = "yAMLToolStripMenuItem";
            this.yAMLToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.yAMLToolStripMenuItem.Text = "YAML";
            this.yAMLToolStripMenuItem.Click += new System.EventHandler(this.changeSyntaxToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(209, 6);
            // 
            // lineNumbersToolStripMenuItem
            // 
            this.lineNumbersToolStripMenuItem.Checked = true;
            this.lineNumbersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumbersToolStripMenuItem.Name = "lineNumbersToolStripMenuItem";
            this.lineNumbersToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.lineNumbersToolStripMenuItem.Text = "&Line Numbers";
            this.lineNumbersToolStripMenuItem.Click += new System.EventHandler(this.lineNumbersToolStripMenuItem_Click);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Checked = true;
            this.commandsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.commandsToolStripMenuItem.Text = "Co&mmands Window";
            this.commandsToolStripMenuItem.Click += new System.EventHandler(this.commandsWindowToolStripMenuItem_Click);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Checked = true;
            this.messagesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.messagesToolStripMenuItem.Text = "&Messages Window";
            this.messagesToolStripMenuItem.Click += new System.EventHandler(this.messagesWindowToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.statusBarToolStripMenuItem.Text = "Status &Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(209, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl++";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zoomInToolStripMenuItem.Text = "Zoom &In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl--";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom &Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // normalSizeToolStripMenuItem
            // 
            this.normalSizeToolStripMenuItem.Name = "normalSizeToolStripMenuItem";
            this.normalSizeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+0";
            this.normalSizeToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.normalSizeToolStripMenuItem.Text = "&Normal Size";
            this.normalSizeToolStripMenuItem.Click += new System.EventHandler(this.normalSizeToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem,
            this.buildToolStripMenuItem1,
            this.runToolStripMenuItem,
            this.toolStripSeparator4,
            this.makeToolStripMenuItem,
            this.cleanToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.toolStripSeparator3,
            this.reloadSettingsToolStripMenuItem,
            this.buildOptionsToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.buildToolStripMenuItem.Text = "&Build";
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.compileToolStripMenuItem.Text = "&Compile";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem1
            // 
            this.buildToolStripMenuItem1.Name = "buildToolStripMenuItem1";
            this.buildToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.buildToolStripMenuItem1.Size = new System.Drawing.Size(203, 24);
            this.buildToolStripMenuItem1.Text = "&Build";
            this.buildToolStripMenuItem1.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.runToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.runToolStripMenuItem.Text = "&Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.makeToolStripMenuItem.Text = "&Make";
            this.makeToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.cleanToolStripMenuItem.Text = "C&lean";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.executeToolStripMenuItem.Text = "&Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // reloadSettingsToolStripMenuItem
            // 
            this.reloadSettingsToolStripMenuItem.Name = "reloadSettingsToolStripMenuItem";
            this.reloadSettingsToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.reloadSettingsToolStripMenuItem.Text = "Reload &Settings";
            this.reloadSettingsToolStripMenuItem.Click += new System.EventHandler(this.reloadSettingsToolStripMenuItem_Click);
            // 
            // buildOptionsToolStripMenuItem
            // 
            this.buildOptionsToolStripMenuItem.Name = "buildOptionsToolStripMenuItem";
            this.buildOptionsToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.buildOptionsToolStripMenuItem.Text = "Build &Options";
            this.buildOptionsToolStripMenuItem.Click += new System.EventHandler(this.buildOptionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.scintilla1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(671, 557);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(96, 100);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.clearAllToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 148);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.newToolStripMenuItem1.Text = "&New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.cutToolStripMenuItem1.Text = "Cu&t ";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.copyToolStripMenuItem1.Text = "&Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.pasteToolStripMenuItem1.Text = "&Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.deleteToolStripMenuItem1.Text = "&Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // clearAllToolStripMenuItem1
            // 
            this.clearAllToolStripMenuItem1.Name = "clearAllToolStripMenuItem1";
            this.clearAllToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.clearAllToolStripMenuItem1.Text = "Clea&r All";
            this.clearAllToolStripMenuItem1.Click += new System.EventHandler(this.clearAllToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLine,
            this.toolStripStatusLabelLineNumber,
            this.toolStripStatusLabelComma,
            this.toolStripStatusLabelColumn,
            this.toolStripStatusLabelColumnNumber,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelWordCount,
            this.toolStripStatusLabeCount});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(602, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabelLine
            // 
            this.toolStripStatusLabelLine.Name = "toolStripStatusLabelLine";
            this.toolStripStatusLabelLine.Size = new System.Drawing.Size(24, 20);
            this.toolStripStatusLabelLine.Text = "Ln";
            // 
            // toolStripStatusLabelLineNumber
            // 
            this.toolStripStatusLabelLineNumber.Name = "toolStripStatusLabelLineNumber";
            this.toolStripStatusLabelLineNumber.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelLineNumber.Text = "0";
            // 
            // toolStripStatusLabelComma
            // 
            this.toolStripStatusLabelComma.Name = "toolStripStatusLabelComma";
            this.toolStripStatusLabelComma.Size = new System.Drawing.Size(12, 20);
            this.toolStripStatusLabelComma.Text = ",";
            // 
            // toolStripStatusLabelColumn
            // 
            this.toolStripStatusLabelColumn.Name = "toolStripStatusLabelColumn";
            this.toolStripStatusLabelColumn.Size = new System.Drawing.Size(31, 20);
            this.toolStripStatusLabelColumn.Text = "Col";
            // 
            // toolStripStatusLabelColumnNumber
            // 
            this.toolStripStatusLabelColumnNumber.Name = "toolStripStatusLabelColumnNumber";
            this.toolStripStatusLabelColumnNumber.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelColumnNumber.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 20);
            this.toolStripStatusLabel1.Text = ",";
            // 
            // toolStripStatusLabelWordCount
            // 
            this.toolStripStatusLabelWordCount.Name = "toolStripStatusLabelWordCount";
            this.toolStripStatusLabelWordCount.Size = new System.Drawing.Size(89, 20);
            this.toolStripStatusLabelWordCount.Text = "Word Count";
            this.toolStripStatusLabelWordCount.ToolTipText = "Showes word  count";
            // 
            // toolStripStatusLabeCount
            // 
            this.toolStripStatusLabeCount.Name = "toolStripStatusLabeCount";
            this.toolStripStatusLabeCount.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabeCount.Text = "0";
            // 
            // splitContainerMessageBox
            // 
            this.splitContainerMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMessageBox.Location = new System.Drawing.Point(0, 28);
            this.splitContainerMessageBox.Name = "splitContainerMessageBox";
            this.splitContainerMessageBox.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMessageBox.Panel1
            // 
            this.splitContainerMessageBox.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainerMessageBox.Panel2
            // 
            this.splitContainerMessageBox.Panel2.Controls.Add(this.messagesRichTextBox);
            this.splitContainerMessageBox.Panel2Collapsed = true;
            this.splitContainerMessageBox.Size = new System.Drawing.Size(671, 557);
            this.splitContainerMessageBox.SplitterDistance = 387;
            this.splitContainerMessageBox.TabIndex = 9;
            // 
            // messagesRichTextBox
            // 
            this.messagesRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.messagesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.messagesRichTextBox.Name = "messagesRichTextBox";
            this.messagesRichTextBox.ReadOnly = true;
            this.messagesRichTextBox.Size = new System.Drawing.Size(150, 46);
            this.messagesRichTextBox.TabIndex = 0;
            this.messagesRichTextBox.Text = "";
            this.messagesRichTextBox.DoubleClick += new System.EventHandler(this.messagesRichTextBox_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 585);
            this.Controls.Add(this.splitContainerMessageBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "tEDI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scintilla1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainerMessageBox.Panel1.ResumeLayout(false);
            this.splitContainerMessageBox.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMessageBox)).EndInit();
            this.splitContainerMessageBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newwithTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPreviousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSyntaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem adaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erlangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fortran77ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fortranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freebasicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haskellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javascriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laTeXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lispToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matlabOctaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nSISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pascalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLTSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tclToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vBScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualBasicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verilogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vHDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAMLToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lineNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem buildOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWordCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabeCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLine;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLineNumber;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelComma;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelColumnNumber;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem javaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSettingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMessageBox;
        private System.Windows.Forms.RichTextBox messagesRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
	}
}
