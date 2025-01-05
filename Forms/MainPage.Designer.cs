using System;
using System.Windows.Forms;

namespace historian {
    partial class MainPage {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            mainStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            dataStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            addPersonMenu = new ToolStripMenuItem();
            toolStripMenuItem21 = new ToolStripMenuItem();
            toolStripMenuItem22 = new ToolStripMenuItem();
            toolStripMenuItem23 = new ToolStripMenuItem();
            toolStripSeparator11 = new ToolStripSeparator();
            toolStripMenuItem24 = new ToolStripMenuItem();
            toolStripMenuItem18 = new ToolStripMenuItem();
            toolStripMenuItem19 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripMenuItem13 = new ToolStripMenuItem();
            toolStripMenuItem14 = new ToolStripMenuItem();
            toolStripMenuItem15 = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            toolStripMenuItem16 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem26 = new ToolStripMenuItem();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            mainStrip.SuspendLayout();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainStrip
            // 
            mainStrip.ImageScalingSize = new Size(20, 20);
            mainStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem, dataStripMenuItem });
            mainStrip.Location = new Point(0, 0);
            mainStrip.Name = "mainStrip";
            mainStrip.Size = new Size(1282, 28);
            mainStrip.TabIndex = 0;
            mainStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(181, 26);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 26);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(181, 26);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(181, 26);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(181, 26);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(179, 26);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(179, 26);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(179, 26);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(179, 26);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(179, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(176, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(179, 26);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(161, 26);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(161, 26);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(150, 26);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(150, 26);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(150, 26);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(150, 26);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // dataStripMenuItem
            // 
            dataStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            dataStripMenuItem.Name = "dataStripMenuItem";
            dataStripMenuItem.Size = new Size(55, 24);
            dataStripMenuItem.Text = "&Data";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 26);
            toolStripMenuItem1.Text = "aaaaaaaaaaa";
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ActiveBorder;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { addPersonMenu });
            menuStrip2.Location = new Point(0, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1282, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip1";
            // 
            // addPersonMenu
            // 
            addPersonMenu.Name = "addPersonMenu";
            addPersonMenu.ShortcutKeys = Keys.Control | Keys.Q;
            addPersonMenu.Size = new Size(51, 24);
            addPersonMenu.Text = "Add";
            // 
            // toolStripMenuItem21
            // 
            toolStripMenuItem21.Name = "toolStripMenuItem21";
            toolStripMenuItem21.Size = new Size(150, 26);
            toolStripMenuItem21.Text = "&Contents";
            // 
            // toolStripMenuItem22
            // 
            toolStripMenuItem22.Name = "toolStripMenuItem22";
            toolStripMenuItem22.Size = new Size(150, 26);
            toolStripMenuItem22.Text = "&Index";
            // 
            // toolStripMenuItem23
            // 
            toolStripMenuItem23.Name = "toolStripMenuItem23";
            toolStripMenuItem23.Size = new Size(150, 26);
            toolStripMenuItem23.Text = "&Search";
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(147, 6);
            // 
            // toolStripMenuItem24
            // 
            toolStripMenuItem24.Name = "toolStripMenuItem24";
            toolStripMenuItem24.Size = new Size(150, 26);
            toolStripMenuItem24.Text = "&About...";
            // 
            // toolStripMenuItem18
            // 
            toolStripMenuItem18.Name = "toolStripMenuItem18";
            toolStripMenuItem18.Size = new Size(161, 26);
            toolStripMenuItem18.Text = "&Customize";
            // 
            // toolStripMenuItem19
            // 
            toolStripMenuItem19.Name = "toolStripMenuItem19";
            toolStripMenuItem19.Size = new Size(161, 26);
            toolStripMenuItem19.Text = "&Options";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.ShortcutKeys = Keys.Control | Keys.Z;
            toolStripMenuItem11.Size = new Size(179, 26);
            toolStripMenuItem11.Text = "&Undo";
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.ShortcutKeys = Keys.Control | Keys.Y;
            toolStripMenuItem12.Size = new Size(179, 26);
            toolStripMenuItem12.Text = "&Redo";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(176, 6);
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.Image = (Image)resources.GetObject("toolStripMenuItem13.Image");
            toolStripMenuItem13.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.ShortcutKeys = Keys.Control | Keys.X;
            toolStripMenuItem13.Size = new Size(179, 26);
            toolStripMenuItem13.Text = "Cu&t";
            // 
            // toolStripMenuItem14
            // 
            toolStripMenuItem14.Image = (Image)resources.GetObject("toolStripMenuItem14.Image");
            toolStripMenuItem14.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem14.Name = "toolStripMenuItem14";
            toolStripMenuItem14.ShortcutKeys = Keys.Control | Keys.C;
            toolStripMenuItem14.Size = new Size(179, 26);
            toolStripMenuItem14.Text = "&Copy";
            // 
            // toolStripMenuItem15
            // 
            toolStripMenuItem15.Image = (Image)resources.GetObject("toolStripMenuItem15.Image");
            toolStripMenuItem15.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem15.Name = "toolStripMenuItem15";
            toolStripMenuItem15.ShortcutKeys = Keys.Control | Keys.V;
            toolStripMenuItem15.Size = new Size(179, 26);
            toolStripMenuItem15.Text = "&Paste";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(176, 6);
            // 
            // toolStripMenuItem16
            // 
            toolStripMenuItem16.Name = "toolStripMenuItem16";
            toolStripMenuItem16.Size = new Size(179, 26);
            toolStripMenuItem16.Text = "Select &All";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.ShortcutKeys = Keys.Control | Keys.N;
            toolStripMenuItem3.Size = new Size(181, 26);
            toolStripMenuItem3.Text = "&New";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Image = (Image)resources.GetObject("toolStripMenuItem4.Image");
            toolStripMenuItem4.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.ShortcutKeys = Keys.Control | Keys.O;
            toolStripMenuItem4.Size = new Size(181, 26);
            toolStripMenuItem4.Text = "&Open";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(178, 6);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Image = (Image)resources.GetObject("toolStripMenuItem5.Image");
            toolStripMenuItem5.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItem5.Size = new Size(181, 26);
            toolStripMenuItem5.Text = "&Save";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(181, 26);
            toolStripMenuItem6.Text = "Save &As";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(178, 6);
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Image = (Image)resources.GetObject("toolStripMenuItem7.Image");
            toolStripMenuItem7.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.ShortcutKeys = Keys.Control | Keys.P;
            toolStripMenuItem7.Size = new Size(181, 26);
            toolStripMenuItem7.Text = "&Print";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Image = (Image)resources.GetObject("toolStripMenuItem8.Image");
            toolStripMenuItem8.ImageTransparentColor = Color.Magenta;
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(181, 26);
            toolStripMenuItem8.Text = "Print Pre&view";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(178, 6);
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(181, 26);
            toolStripMenuItem9.Text = "E&xit";
            // 
            // toolStripMenuItem26
            // 
            toolStripMenuItem26.Name = "toolStripMenuItem26";
            toolStripMenuItem26.Size = new Size(180, 26);
            toolStripMenuItem26.Text = "aaaaaaaaaaa";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 614);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(446, 268);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(8, 8);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 673);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Controls.Add(mainStrip);
            MainMenuStrip = mainStrip;
            Name = "MainPage";
            Text = "Historian";
            mainStrip.ResumeLayout(false);
            mainStrip.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem dataStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem addPersonMenu;
        private ToolStripMenuItem toolStripMenuItem21;
        private ToolStripMenuItem toolStripMenuItem22;
        private ToolStripMenuItem toolStripMenuItem23;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem toolStripMenuItem24;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem26;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
