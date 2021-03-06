﻿using System.Windows.Forms;

namespace DBWACS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로젝트PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dB열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DBOPEN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CSVOPEN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_DBSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DBCLOSE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.테이블추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테이블삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSV를DB로변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btGo = new System.Windows.Forms.Button();
            this.tbPATH = new System.Windows.Forms.TextBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmnuAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuDelRow = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status3 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.menuStrip1.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2});
            toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripSplitButton1.Margin = new System.Windows.Forms.Padding(1100, 2, 0, 0);
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(71, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.dBToolStripMenuItem,
            this.보기VToolStripMenuItem,
            this.프로젝트PToolStripMenuItem,
            this.도구TToolStripMenuItem,
            this.창WToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.dBToolStripMenuItem.Text = "편집(E)";
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            this.보기VToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.보기VToolStripMenuItem.Text = "보기(V)";
            // 
            // 프로젝트PToolStripMenuItem
            // 
            this.프로젝트PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dB열기OToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnu_DBSave,
            this.mnu_DBCLOSE,
            this.toolStripSeparator3,
            this.테이블추가ToolStripMenuItem,
            this.테이블삭제ToolStripMenuItem,
            this.cSV를DB로변환ToolStripMenuItem});
            this.프로젝트PToolStripMenuItem.Name = "프로젝트PToolStripMenuItem";
            this.프로젝트PToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.프로젝트PToolStripMenuItem.Text = "데이터(D)";
            // 
            // dB열기OToolStripMenuItem
            // 
            this.dB열기OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_DBOPEN,
            this.mnu_CSVOPEN});
            this.dB열기OToolStripMenuItem.Name = "dB열기OToolStripMenuItem";
            this.dB열기OToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.dB열기OToolStripMenuItem.Text = "열기(O)";
            // 
            // mnu_DBOPEN
            // 
            this.mnu_DBOPEN.Name = "mnu_DBOPEN";
            this.mnu_DBOPEN.Size = new System.Drawing.Size(120, 26);
            this.mnu_DBOPEN.Text = "DB";
            this.mnu_DBOPEN.Click += new System.EventHandler(this.mnu_DBOPEN_Click);
            // 
            // mnu_CSVOPEN
            // 
            this.mnu_CSVOPEN.Name = "mnu_CSVOPEN";
            this.mnu_CSVOPEN.Size = new System.Drawing.Size(120, 26);
            this.mnu_CSVOPEN.Text = "CSV";
            this.mnu_CSVOPEN.Click += new System.EventHandler(this.mnu_CSVOPEN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // mnu_DBSave
            // 
            this.mnu_DBSave.Name = "mnu_DBSave";
            this.mnu_DBSave.Size = new System.Drawing.Size(210, 26);
            this.mnu_DBSave.Text = "DB 저장(S)";
            this.mnu_DBSave.Click += new System.EventHandler(this.mnu_DBSave_Click);
            // 
            // mnu_DBCLOSE
            // 
            this.mnu_DBCLOSE.Name = "mnu_DBCLOSE";
            this.mnu_DBCLOSE.Size = new System.Drawing.Size(210, 26);
            this.mnu_DBCLOSE.Text = "DB 닫기(C)";
            this.mnu_DBCLOSE.Click += new System.EventHandler(this.mnu_DBCLOSE_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // 테이블추가ToolStripMenuItem
            // 
            this.테이블추가ToolStripMenuItem.Name = "테이블추가ToolStripMenuItem";
            this.테이블추가ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.테이블추가ToolStripMenuItem.Text = "테이블 추가";
            this.테이블추가ToolStripMenuItem.Click += new System.EventHandler(this.테이블추가ToolStripMenuItem_Click);
            // 
            // 테이블삭제ToolStripMenuItem
            // 
            this.테이블삭제ToolStripMenuItem.Name = "테이블삭제ToolStripMenuItem";
            this.테이블삭제ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.테이블삭제ToolStripMenuItem.Text = "테이블 삭제";
            this.테이블삭제ToolStripMenuItem.Click += new System.EventHandler(this.테이블삭제ToolStripMenuItem_Click);
            // 
            // cSV를DB로변환ToolStripMenuItem
            // 
            this.cSV를DB로변환ToolStripMenuItem.Name = "cSV를DB로변환ToolStripMenuItem";
            this.cSV를DB로변환ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.cSV를DB로변환ToolStripMenuItem.Text = "CSV를 DB로 변환";
            // 
            // 도구TToolStripMenuItem
            // 
            this.도구TToolStripMenuItem.Name = "도구TToolStripMenuItem";
            this.도구TToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.도구TToolStripMenuItem.Text = "도구(T)";
            // 
            // 창WToolStripMenuItem
            // 
            this.창WToolStripMenuItem.Name = "창WToolStripMenuItem";
            this.창WToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.창WToolStripMenuItem.Text = "창(W)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // tab_main
            // 
            this.tab_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_main.Controls.Add(this.tabPage1);
            this.tab_main.Controls.Add(this.Tab2);
            this.tab_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab_main.Location = new System.Drawing.Point(52, 52);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(1150, 595);
            this.tab_main.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(150)))));
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1142, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataGrid";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.splitContainer1.Panel1.Controls.Add(this.tbInput);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 556);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.tbInput.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbInput.Location = new System.Drawing.Point(17, 64);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(1092, 126);
            this.tbInput.TabIndex = 6;
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.3428F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.Controls.Add(this.btGo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPATH, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbTable, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 50);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btGo
            // 
            this.btGo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btGo.ForeColor = System.Drawing.Color.White;
            this.btGo.Location = new System.Drawing.Point(950, 3);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(177, 44);
            this.btGo.TabIndex = 4;
            this.btGo.Text = "go";
            this.btGo.UseVisualStyleBackColor = false;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // tbPATH
            // 
            this.tbPATH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPATH.BackColor = System.Drawing.Color.White;
            this.tbPATH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPATH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbPATH.Location = new System.Drawing.Point(3, 3);
            this.tbPATH.Name = "tbPATH";
            this.tbPATH.ReadOnly = true;
            this.tbPATH.Size = new System.Drawing.Size(581, 30);
            this.tbPATH.TabIndex = 1;
            // 
            // cbTable
            // 
            this.cbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTable.BackColor = System.Drawing.Color.White;
            this.cbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(590, 3);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(354, 33);
            this.cbTable.TabIndex = 3;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Location = new System.Drawing.Point(17, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(1092, 317);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuAddRow,
            this.tsmnuDelRow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 52);
            // 
            // tsmnuAddRow
            // 
            this.tsmnuAddRow.Name = "tsmnuAddRow";
            this.tsmnuAddRow.Size = new System.Drawing.Size(123, 24);
            this.tsmnuAddRow.Text = "행추가";
            this.tsmnuAddRow.Click += new System.EventHandler(this.tsmnuAddRow_Click);
            // 
            // tsmnuDelRow
            // 
            this.tsmnuDelRow.Name = "tsmnuDelRow";
            this.tsmnuDelRow.Size = new System.Drawing.Size(123, 24);
            this.tsmnuDelRow.Text = "행삭제";
            this.tsmnuDelRow.Click += new System.EventHandler(this.tsmnuDelRow_Click);
            // 
            // Tab2
            // 
            this.Tab2.BackColor = System.Drawing.Color.Transparent;
            this.Tab2.Location = new System.Drawing.Point(4, 29);
            this.Tab2.Name = "Tab2";
            this.Tab2.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2.Size = new System.Drawing.Size(1142, 562);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "Tab2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status1,
            this.status2,
            this.status3,
            toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1250, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status1
            // 
            this.status1.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.status1.BackColor = System.Drawing.SystemColors.Control;
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(0, 20);
            // 
            // status2
            // 
            this.status2.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.status2.BackColor = System.Drawing.SystemColors.Control;
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(0, 20);
            // 
            // status3
            // 
            this.status3.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.status3.BackColor = System.Drawing.SystemColors.Control;
            this.status3.Name = "status3";
            this.status3.Size = new System.Drawing.Size(0, 20);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(250)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1250, 701);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tab_main);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DBWACS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로젝트PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Tab2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.TextBox tbPATH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dB열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_DBOPEN;
        private System.Windows.Forms.ToolStripMenuItem mnu_CSVOPEN;
        private System.Windows.Forms.ToolStripMenuItem mnu_DBSave;
        private System.Windows.Forms.ToolStripMenuItem mnu_DBCLOSE;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status1;
        private System.Windows.Forms.ToolStripStatusLabel status2;
        private System.Windows.Forms.ToolStripStatusLabel status3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmnuAddRow;
        private ToolStripMenuItem tsmnuDelRow;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem 테이블추가ToolStripMenuItem;
        private ToolStripMenuItem cSV를DB로변환ToolStripMenuItem;
        private ToolStripMenuItem 테이블삭제ToolStripMenuItem;
    }
}

