﻿
namespace FileExplorer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTypeBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pathDir = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.left = new System.Windows.Forms.ToolStripButton();
            this.right = new System.Windows.Forms.ToolStripButton();
            this.up = new System.Windows.Forms.ToolStripButton();
            this.refresh = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.diskInfoPanel = new System.Windows.Forms.Panel();
            this.diskInfo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeNode = new System.Windows.Forms.TreeView();
            this.listDir = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.diskInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 88);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 55);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "New File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Location = new System.Drawing.Point(815, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 49);
            this.button5.TabIndex = 0;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 55);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Computer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.Location = new System.Drawing.Point(726, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 49);
            this.button9.TabIndex = 5;
            this.button9.Text = "Select None";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Right;
            this.button8.Location = new System.Drawing.Point(832, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 49);
            this.button8.TabIndex = 4;
            this.button8.Text = "Select All";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.button7.Location = new System.Drawing.Point(285, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 49);
            this.button7.TabIndex = 3;
            this.button7.Text = "Properties";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Left;
            this.button6.Location = new System.Drawing.Point(191, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 49);
            this.button6.TabIndex = 2;
            this.button6.Text = "Paste";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(97, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 49);
            this.button4.TabIndex = 1;
            this.button4.Text = "Copy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "New Folder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button13);
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(929, 55);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Left;
            this.button13.Location = new System.Drawing.Point(285, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 49);
            this.button13.TabIndex = 3;
            this.button13.Text = "Large Icon";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Left;
            this.button12.Location = new System.Drawing.Point(191, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 49);
            this.button12.TabIndex = 2;
            this.button12.Text = "Title";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Left;
            this.button11.Location = new System.Drawing.Point(97, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 49);
            this.button11.TabIndex = 1;
            this.button11.Text = "Detail";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Left;
            this.button10.Location = new System.Drawing.Point(3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 49);
            this.button10.TabIndex = 0;
            this.button10.Text = "List";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitter1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.searchTypeBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(929, 55);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(306, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 49);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Searching type";
            // 
            // searchTypeBox
            // 
            this.searchTypeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTypeBox.FormattingEnabled = true;
            this.searchTypeBox.Items.AddRange(new object[] {
            "Date",
            "Name",
            "Content",
            "Type"});
            this.searchTypeBox.Location = new System.Drawing.Point(3, 3);
            this.searchTypeBox.Name = "searchTypeBox";
            this.searchTypeBox.Size = new System.Drawing.Size(303, 28);
            this.searchTypeBox.TabIndex = 0;
            this.searchTypeBox.SelectedIndexChanged += new System.EventHandler(this.searchTypeBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pathDir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 26);
            this.panel1.TabIndex = 1;
            // 
            // pathDir
            // 
            this.pathDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathDir.Location = new System.Drawing.Point(174, 0);
            this.pathDir.Name = "pathDir";
            this.pathDir.Size = new System.Drawing.Size(666, 27);
            this.pathDir.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 26);
            this.panel2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.left,
            this.right,
            this.up,
            this.refresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(174, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.SystemColors.Control;
            this.left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.left.Image = ((System.Drawing.Image)(resources.GetObject("left.Image")));
            this.left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(29, 23);
            this.left.Text = "toolStripButton1";
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.right.Image = ((System.Drawing.Image)(resources.GetObject("right.Image")));
            this.right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(29, 23);
            this.right.Text = "toolStripButton2";
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // up
            // 
            this.up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.up.Image = ((System.Drawing.Image)(resources.GetObject("up.Image")));
            this.up.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(29, 23);
            this.up.Text = "toolStripButton3";
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // refresh
            // 
            this.refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(29, 23);
            this.refresh.Text = "toolStripButton4";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(840, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 26);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy Path";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // diskInfoPanel
            // 
            this.diskInfoPanel.Controls.Add(this.diskInfo);
            this.diskInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.diskInfoPanel.Location = new System.Drawing.Point(0, 508);
            this.diskInfoPanel.Name = "diskInfoPanel";
            this.diskInfoPanel.Size = new System.Drawing.Size(937, 24);
            this.diskInfoPanel.TabIndex = 2;
            // 
            // diskInfo
            // 
            this.diskInfo.AutoSize = true;
            this.diskInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskInfo.Location = new System.Drawing.Point(0, 0);
            this.diskInfo.Name = "diskInfo";
            this.diskInfo.Size = new System.Drawing.Size(110, 20);
            this.diskInfo.TabIndex = 0;
            this.diskInfo.Text = "Folder(s) File(s)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 114);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeNode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listDir);
            this.splitContainer1.Size = new System.Drawing.Size(937, 394);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeNode
            // 
            this.treeNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeNode.Location = new System.Drawing.Point(0, 0);
            this.treeNode.Name = "treeNode";
            this.treeNode.Size = new System.Drawing.Size(310, 394);
            this.treeNode.TabIndex = 0;
            this.treeNode.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNode_AfterSelect);
            // 
            // listDir
            // 
            this.listDir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDir.HideSelection = false;
            this.listDir.LabelEdit = true;
            this.listDir.Location = new System.Drawing.Point(0, 0);
            this.listDir.Name = "listDir";
            this.listDir.Size = new System.Drawing.Size(622, 394);
            this.listDir.TabIndex = 3;
            this.listDir.UseCompatibleStateImageBehavior = false;
            this.listDir.View = System.Windows.Forms.View.Details;
            this.listDir.ItemActivate += new System.EventHandler(this.listDir_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 532);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.diskInfoPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.diskInfoPanel.ResumeLayout(false);
            this.diskInfoPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pathDir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel diskInfoPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeNode;
        private System.Windows.Forms.ListView listDir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton left;
        private System.Windows.Forms.ToolStripButton right;
        private System.Windows.Forms.ToolStripButton up;
        private System.Windows.Forms.ToolStripButton refresh;
        private System.Windows.Forms.Label diskInfo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchTypeBox;
        private System.Windows.Forms.Splitter splitter1;
    }
}
