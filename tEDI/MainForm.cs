using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using System.Security;
using System.Security.Permissions;

namespace tEDI
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        bool FileIsSaved = true;
        bool FindWindowAppeared = false;
        string FileName = "Untitled";
        string GetDirectory;
        string AppData;
        XDocument BuildXML;
        public MainForm()
        {
            InitializeComponent();
            this.Text = FileName + " - tEDI";
            this.scintilla1.ConfigurationManager.Language = "";
            scintilla1.ConfigurationManager.Configure();
            MyInitializeComponent();
        }

        private void MyInitializeComponent()
        {
            for (int i = 0; i < 33; i++)
                scintilla1.Styles[i].Font = new Font("Consolas", 12);
            for (int i = 34; i < 255; i++)
                scintilla1.Styles[i].Font = new Font("Consolas", 12);
            treeView1.Font = new Font("Consolas", 12);
            scintilla1.Styles.LineNumber.ForeColor = Color.Red;
            commandsToolStripMenuItem.Checked = !splitContainer1.Panel2Collapsed;
            messagesToolStripMenuItem.Checked = !splitContainerMessageBox.Panel2Collapsed;
        }

        public MainForm(string file)
        {
            InitializeComponent();
            openFile(file);
        }

        private void openFile(string file)
        {
            if (File.Exists(file))
            {
                this.FileName = file;
                this.Text = Path.GetFileName(FileName) + " - tEDI";
                scintilla1.Text = File.ReadAllText(FileName);
                scintilla1.UndoRedo.EmptyUndoBuffer();
                FileIsSaved = true;
                setSyntax();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewFile();
        }

        private void openNewFile()
        {
            if (!savingDialogIsCanceled())
            {
                FileIsSaved = false;
                FileName = "Untitled";
                this.Text = "Untitled - tEDI";
                scintilla1.Text = string.Empty;
                scintilla1.UndoRedo.EmptyUndoBuffer();
                this.scintilla1.ConfigurationManager.Language = "";
                scintilla1.ConfigurationManager.Configure();
                MyInitializeComponent();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = /*"Text Files(*.txt)|*.txt|*/"All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openFile(ofd.FileName);
            }
        }

        private void setSyntax(string ext = null)
        {
            string lang = "";
            if (!Path.HasExtension(this.FileName))
            {
                this.scintilla1.ConfigurationManager.Language = "";
                scintilla1.ConfigurationManager.Configure();
                MyInitializeComponent();
                return;
            }
            else if (ext == null)
                ext = Path.GetExtension(this.FileName).Remove(0, 1);
            ext = ext.ToLower();
            //Ada
            if (ext == "adb" || ext == "ads" || ext == "ada") lang = "ada";
            //Assembly
            else if (ext == "asm" || ext == "assembly") lang = "asm";
            //Caml
            else if (ext == "ml" || ext == "mli" || ext == "caml") lang = "caml";
            //Bash
            else if (ext == "bash") lang = "bash";
            //Batch File
            else if (ext == "bat" || ext == "cmd" || ext == "btm" || ext == "batch file") lang = "batch";
            //C/C++
            else if (ext == "c" || ext == "h" || ext == "cpp" || ext == "cxx" || ext == "c++" || ext == "cc" || ext == "hpp" || ext == "hxx" || ext == "h++" || ext == "c/c++") lang = "cpp";
            //C#
            else if (ext == "cs" || ext == "java" || ext == "jsp" || ext == "c#") lang = "cs";
            //CMake
            else if (ext == "cmakelists.txt" || ext == "cmake" || ext == "ctest") lang = "cmake";
            //css
            else if (ext == "css") lang = "css";
            //D
            else if (ext == "d" || ext == "di") lang = "d";
            //Diff
            else if (ext == "diff" || ext == "patch" || ext == "rej") lang = "diff";
            //Erlang
            else if (ext == "erl" || ext == "erlang") lang = "erlang";
            //F77
            else if (ext == "f" || ext == "for" || ext == "ftn" || ext == "f77" || ext == "Fortran 77") lang = "f77";
            //Forth
            else if (ext == "fs" || ext == "fth" || ext == "forth") lang = "forth";
            //Fortran
            else if (ext == "f90" || ext == "f95" || ext == "f03" || ext == "fortran") lang = "fortran";
            //Freebasic
            else if (ext == "bas" || ext == "bi" || ext == "freebasic") lang = "freebasic";
            //Haskell
            else if (ext == "hs" || ext == "lhs" || ext == "haskel") lang = "haskel";
            //Html
            else if (ext == "htm" || ext == "html" || ext == "shtml" || ext == "hta" || ext == "htd" || ext == "htt" || ext == "cfm") lang = "html";
            //Javascript
            else if (ext == "js" || ext == "javascript") lang = "js";
            //LaTeX
            else if (ext == "tex" || ext == "sty" || ext == "idx" || ext == "itx" || ext == "latex") lang = "latex";
            //Lisp
            else if (ext == "lisp") lang = "lisp";
            //Lua
            else if (ext == "lua") lang = "lua";
            //Make
            else if (ext == "mak" || ext == "mk" || ext == "gnumakefile" || ext == "makefile" || ext == "make") lang = "make";
            //Matlab/Octave
            else if (ext == "m" || ext == "matlab/octave") lang = "matlab";
            //NSIS
            else if (ext == "nsi" || ext == "nsh" || ext == "nsis") lang = "nsis";
            //Pascal
            else if (ext == "pas" || ext == "pp" || ext == "inc" || ext == "dpr" || ext == "dpk" || ext == "pascal") lang = "pascal";
            //Perl
            else if (ext == "pl" || ext == "perl" || ext == "pm" || ext == "agi" || ext == "pod") lang = "perl";
            //PHPScript
            else if (ext == "php" || ext == "php3" || ext == "php4" || ext == "php5" || ext == "phtml") lang = "phpscript";
            //Python
            else if (ext == "py" || ext == "pyc" || ext == "pyw" || ext == "pyo" || ext == "pyd" || ext == "pyx" || ext == "pxd" || ext == "pxi" || ext == "sconstruct" || ext == "sconscript" || ext == "python") lang = "python";
            //Ruby
            else if (ext == "rb" || ext == "rhtml" || ext == "ruby") lang = "ruby";
            //SQL(T-SQL)
            else if (ext == "sql" || ext == "sql(t-sql)") lang = "mssql";
            //Tcl
            else if (ext == "tcl" || ext == "tk" || ext == "wish") lang = "mssql";
            //VB Script
            else if (ext == "vbs" || ext == "vbscript") lang = "vbscript";
            //Visual Basic
            else if (ext == "vb" || ext == "visual basic") lang = "vb";
            //Verilog
            else if (ext == "v" || ext == "verilog") lang = "verilog";
            //VHDL
            else if (ext == "vhd" || ext == "vhdl") lang = "vhdl";
            //XML
            else if (ext == "xml" || ext == "sgxml" || ext == "xsl" || ext == "xslt" || ext == "xsd" || ext == "xhtml") lang = "xml";
            //YAML
            else if (ext == "yaml" || ext == "yml") lang = "yaml";
            this.scintilla1.ConfigurationManager.Language = "";
            scintilla1.ConfigurationManager.Configure();
            this.scintilla1.ConfigurationManager.Language = lang;
            scintilla1.ConfigurationManager.Configure();
            MyInitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.UndoRedo.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.UndoRedo.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.Clipboard.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.Clipboard.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.Clipboard.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.Selection.Text = string.Empty;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.NativeInterface.SelectAll();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ZoomOut();
        }

        private void normalSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ZoomFactor = 0;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == "Untitled")
            {
                saveAsToolStripMenuItem_Click(saveToolStripMenuItem, EventArgs.Empty);
            }
            else if (!FileIsSaved)
            {
                try
                {
                    File.WriteAllText(FileName, scintilla1.Text);
                    FileIsSaved = true;
                }
                catch (Exception except)
                {
                    MessageBox.Show(FileName + " file can not be saved! \n" + except.Message, "Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                setSyntax();
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "txt";
            sfd.Filter = /*"Text Files(*.txt)|*.txt|*/"All Files(*.*)|*.*";
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileName = sfd.FileName;
                this.Text = Path.GetFileName(FileName) + " - tEDI";
                try
                {
                    File.WriteAllText(FileName, scintilla1.Text);
                    FileIsSaved = true;
                }
                catch(Exception except)
                {
                    MessageBox.Show(FileName + " file can not be saved! \n" + except.Message, "Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                setSyntax();
            }

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(FileName))
            {
                try
                {
                    scintilla1.Text = File.ReadAllText(FileName);
                    FileIsSaved = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An unexcepted error occured!\n" + ex.Message, "Error");
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = savingDialogIsCanceled();
        }

        private bool savingDialogIsCanceled()
        {
            if (FileName == "Untitled" && scintilla1.Text == "" || FileIsSaved) return false;
            DialogResult dr = MessageBox.Show("Do you want to save changes to " + FileName + "?", "tEDI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) return true;
            else if (dr == DialogResult.Yes) saveToolStripMenuItem_Click(saveToolStripMenuItem, EventArgs.Empty);
            return false;
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                for (int i = 0; i < 255; i++)
                    scintilla1.Styles[i].Font = fd.Font;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.Commands.Execute(ScintillaNET.BindableCommand.Print);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.Commands.Execute(ScintillaNET.BindableCommand.PrintPreview);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scintilla1.Selection.Text != "")
            {
                scintilla1.FindReplace.Window.Text = scintilla1.Selection.Text;
            }
            FindWindowAppeared = true;
            scintilla1.FindReplace.ShowFind();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scintilla1.Selection.Text != "")
            {
                ScintillaNET.Range range = scintilla1.Selection.Range;
                scintilla1.Selection.Range.GotoStart();
                scintilla1.Selection.Start = range.Start;
                scintilla1.Selection.End = range.End;
                scintilla1.Selection.Range = scintilla1.FindReplace.FindNext(scintilla1.Selection.Text);
            }
            else if (FindWindowAppeared && scintilla1.Selection.Text != "") scintilla1.FindReplace.Window.FindNext();
            else
            {
                scintilla1.FindReplace.ShowFind();
                FindWindowAppeared = true;
            }
        }

        private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scintilla1.Selection.Text != "")
            {
                ScintillaNET.Range range = scintilla1.Selection.Range;
                scintilla1.Selection.Range.GotoStart();
                scintilla1.Selection.Start = range.Start;
                scintilla1.Selection.End = range.End;
                scintilla1.Selection.Range = scintilla1.FindReplace.FindPrevious(scintilla1.Selection.Text);
            }
            else if (FindWindowAppeared && scintilla1.Selection.Text != "") scintilla1.FindReplace.Window.FindPrevious();
            else
            {
                scintilla1.FindReplace.ShowFind();
                FindWindowAppeared = true;
            }
        }

        private void findAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scintilla1.Selection.Text != "")
                scintilla1.FindReplace.HighlightAll(scintilla1.FindReplace.FindAll(scintilla1.Selection.Text));
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.FindReplace.ClearAllHighlights();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.FindReplace.ShowReplace();
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            this.FileIsSaved = false;
            scintilla1.NativeInterface.SetSavePoint();
            getStatusBarLabels();
        }

        private void scintilla1_SelectionChanged(object sender, EventArgs e)
        {
            getStatusBarLabels();
        }

        private void commandsWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandsToolStripMenuItem.Checked = splitContainer1.Panel2Collapsed;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        private void messagesWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messagesToolStripMenuItem.Checked = splitContainerMessageBox.Panel2Collapsed;
            splitContainerMessageBox.Panel2Collapsed = !splitContainerMessageBox.Panel2Collapsed;
        }

        private void scintilla1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Delete)
                scintilla1.NativeInterface.LineDelete();
            else if (e.Shift && e.KeyCode == Keys.Enter)
                scintilla1.NativeInterface.LineDown();
        }

        private void actionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.NativeInterface.SetSavePoint();
        }

        private void scintilla1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.UnicodeText) || e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
        }

        private void scintilla1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                openFile(files[0]);
                if (files.Length > 1)
                {
                    for (int i = 1; i < files.Length; i++)
                        Process.Start(Application.ExecutablePath, "\"" + files[i] + "\"");
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.UnicodeText))
                scintilla1.InsertText(e.Data.GetData(DataFormats.UnicodeText).ToString());
        }

        private void changeSyntaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = sender as ToolStripMenuItem;
            setSyntax(it.Text);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string[] text = File.ReadAllLines(file);
                string currentnode = "";
                bool childnode = false;
                foreach (string str in text)
                {
                    if (str.Contains("hide_drop_down") || Regex.IsMatch(str, @"^[,.0-9]+$")) continue;
                    else if (str.Contains("start_drop_down")) childnode = true;
                    else if (str.Contains("end_drop_down")) childnode = false;
                    else if (Regex.IsMatch(str, @"\w"))
                    {
                        if (childnode)
                        {
                            if (!treeView1.Nodes[currentnode].Nodes.ContainsKey(str))
                                treeView1.Nodes[currentnode].Nodes.Add(str, str);
                        }
                        else if (!treeView1.Nodes.ContainsKey(str))
                        {
                            treeView1.Nodes.Add(str, str);
                            currentnode = str;
                        }
                    }
                }
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode.Nodes.Count != 0) return;
            if (treeView1.SelectedNode.Text == "Comment")
                this.scintilla1.InsertText("#\n");
            else this.scintilla1.InsertText(treeView1.SelectedNode.Text + "\n");
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(treeView1.SelectedNode.Text);
            treeView1.SelectedNode.Remove();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(treeView1.SelectedNode.Text);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string command = Clipboard.GetText();
            if (Regex.IsMatch(command, @"\w+"))
                treeView1.Nodes.Add(command, command);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void clearAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommandsNew form = new CommandsNew();
            if (form.ShowDialog() == DialogResult.OK)
                if (Regex.IsMatch(form.command, @"\w+"))
                    treeView1.Nodes.Add(form.command, form.command);
        }

        private void lineNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineNumbersToolStripMenuItem.Checked = !lineNumbersToolStripMenuItem.Checked;
            if (lineNumbersToolStripMenuItem.Checked)
                scintilla1.Margins.Margin0.Width = 35;
            else scintilla1.Margins.Margin0.Width = 0;
        }

        private void getStatusBarLabels()
        {
            if (statusStrip1.Visible)
            {
                toolStripStatusLabeCount.Text = (Regex.Matches(scintilla1.Text, @"[\S]+")).Count.ToString();
                toolStripStatusLabelColumnNumber.Text = (scintilla1.NativeInterface.GetColumn(scintilla1.Caret.Position)+1).ToString();
                toolStripStatusLabelLineNumber.Text = (scintilla1.Caret.LineNumber+1).ToString();
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBarToolStripMenuItem.Checked = !statusBarToolStripMenuItem.Checked;
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked;
            if (statusStrip1.Visible)
                getStatusBarLabels();
        }

        private void saveCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = scintilla1.Text;
            saveToolStripMenuItem_Click(sender, e);
            openNewFile();
            scintilla1.Text = text;
        }

        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
            string Ext = (Path.GetExtension(this.FileName).Remove(0, 1)).ToLower();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(FileName));
            try
            {
                bool hideconsole = true;
                XElement contentXML = BuildXML.FirstNode.Document.Element("Build");
                XElement bcommand = contentXML.Element(((ToolStripMenuItem)sender).Text.Replace("&", string.Empty));
                if (bcommand.HasAttributes && bcommand.FirstAttribute.Value == "no") hideconsole = false;
                string command = bcommand.Element(Ext).Value.ToString();
                command = command.Replace("%f", string.Format("\"{0}\"",FileName)).Replace("%d", string.Format("\"{0}\"",Path.GetFileNameWithoutExtension(FileName)));
                cmdRun(command, hideconsole);
            }
            catch (Exception except)
            {
                MessageBox.Show("Build command can not be found! \n" + except.Message, "Build Options", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmdRun(string command, bool hideconsole=true)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = @"/c " + command;
            if (hideconsole)
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                this.messagesRichTextBox.Text = process.StandardError.ReadToEnd()+process.StandardOutput.ReadToEnd();
            }
            else
            {
                process.Start();
            }
            process.WaitForExit();
            process.Close();

        }

        private void loadBuild()
        {
            GetDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\tEDI";
            if (File.Exists(AppData + @"\Build.xml"))
                try
                {
                    BuildXML = XDocument.Load(string.Format("{0}\\Build.xml", AppData));
                }
                catch(Exception e)
                {
                    MessageBox.Show("Build.xml file can not be loaded! \n"+e.Message, "Build Options", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else MessageBox.Show("Build.xml file does not exist!", "Build Options", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadBuild();
        }

        private void buildOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = GetDirectory + @"\tEDI.exe";
            process.StartInfo.Arguments = string.Format("\"{0}\\Build.xml\"", AppData);
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            /*PermissionSet permissionSet = new PermissionSet(PermissionState.None);
            FileIOPermission writePermission = new FileIOPermission(FileIOPermissionAccess.AllAccess, GetDirectory);
            permissionSet.AddPermission(writePermission);
            if (!(permissionSet.IsSubsetOf(AppDomain.CurrentDomain.PermissionSet)) && System.Environment.OSVersion.Version.Major >= 6)
            {
                process.StartInfo.Verb = "runas";
            }*/
            process.Start();
            //process.WaitForExit();
            //process.Close();

            //Process.Start(GetDirectory + @"\tEDI.exe", string.Format("\"{0}\\Build.xml\"",GetDirectory));
            //Process.Start(Application.StartupPath + Path.DirectorySeparatorChar + Path.GetFileName(Application.ExecutablePath), GetDirectory + @"\Build.xml");
            //OpenFile(GetDirectory + @"\Build.xml");
        }

        private void reloadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadBuild();
        }

        private void editToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = scintilla1.UndoRedo.CanUndo;
            redoToolStripMenuItem.Enabled = scintilla1.UndoRedo.CanRedo;
            cutToolStripMenuItem.Enabled = scintilla1.Clipboard.CanCut;
            copyToolStripMenuItem.Enabled = scintilla1.Clipboard.CanCopy;
            pasteToolStripMenuItem.Enabled = scintilla1.Clipboard.CanPaste;
        }

        private void messagesRichTextBox_DoubleClick(object sender, EventArgs e)
        {
            string msg = messagesRichTextBox.Lines[messagesRichTextBox.GetLineFromCharIndex(messagesRichTextBox.SelectionStart)];
            Match m = Regex.Match(msg, @"\((?<line>\d+),(?<col>\d+)\)");
            if (m.Success)
            {
                int line = int.Parse(m.Groups["line"].Value) - 1;
                scintilla1.Focus();
                scintilla1.Selection.Start = scintilla1.Lines.FromVisibleLineNumber(line).StartPosition;
                scintilla1.Selection.End = scintilla1.Lines.FromVisibleLineNumber(line).EndPosition;
                scintilla1.Selection.BackColor = Color.DarkRed;
            }
        }

    }
}
