namespace Music
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顺序播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单曲播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部循环ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随机播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表中删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.CausesValidation = false;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 28);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(270, 139);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.CausesValidation = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.ForeColor = System.Drawing.Color.Red;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 173);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(351, 487);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌名";
            this.columnHeader1.Width = 330;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(288, 28);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(288, 86);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(288, 57);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(288, 115);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = "上一首";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(288, 144);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一首";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加文件ToolStripMenuItem,
            this.添加文件夹ToolStripMenuItem,
            this.播放方式ToolStripMenuItem,
            this.列表中删除ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加文件ToolStripMenuItem
            // 
            this.添加文件ToolStripMenuItem.Name = "添加文件ToolStripMenuItem";
            this.添加文件ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加文件ToolStripMenuItem.Text = "添加文件";
            this.添加文件ToolStripMenuItem.Click += new System.EventHandler(this.添加文件ToolStripMenuItem_Click);
            // 
            // 添加文件夹ToolStripMenuItem
            // 
            this.添加文件夹ToolStripMenuItem.Name = "添加文件夹ToolStripMenuItem";
            this.添加文件夹ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.添加文件夹ToolStripMenuItem.Text = "添加文件夹";
            this.添加文件夹ToolStripMenuItem.Click += new System.EventHandler(this.添加文件夹ToolStripMenuItem_Click);
            // 
            // 播放方式ToolStripMenuItem
            // 
            this.播放方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顺序播放ToolStripMenuItem,
            this.单曲播放ToolStripMenuItem,
            this.全部循环ToolStripMenuItem,
            this.随机播放ToolStripMenuItem});
            this.播放方式ToolStripMenuItem.Name = "播放方式ToolStripMenuItem";
            this.播放方式ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.播放方式ToolStripMenuItem.Text = "播放方式";
            // 
            // 顺序播放ToolStripMenuItem
            // 
            this.顺序播放ToolStripMenuItem.Name = "顺序播放ToolStripMenuItem";
            this.顺序播放ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.顺序播放ToolStripMenuItem.Text = "顺序播放";
            this.顺序播放ToolStripMenuItem.Click += new System.EventHandler(this.顺序播放ToolStripMenuItem_Click);
            // 
            // 单曲播放ToolStripMenuItem
            // 
            this.单曲播放ToolStripMenuItem.Name = "单曲播放ToolStripMenuItem";
            this.单曲播放ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.单曲播放ToolStripMenuItem.Text = "单曲播放";
            this.单曲播放ToolStripMenuItem.Click += new System.EventHandler(this.单曲播放ToolStripMenuItem_Click);
            // 
            // 全部循环ToolStripMenuItem
            // 
            this.全部循环ToolStripMenuItem.Name = "全部循环ToolStripMenuItem";
            this.全部循环ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部循环ToolStripMenuItem.Text = "全部循环";
            this.全部循环ToolStripMenuItem.Click += new System.EventHandler(this.全部循环ToolStripMenuItem_Click);
            // 
            // 随机播放ToolStripMenuItem
            // 
            this.随机播放ToolStripMenuItem.Name = "随机播放ToolStripMenuItem";
            this.随机播放ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.随机播放ToolStripMenuItem.Text = "随机播放";
            this.随机播放ToolStripMenuItem.Click += new System.EventHandler(this.随机播放ToolStripMenuItem_Click);
            // 
            // 列表中删除ToolStripMenuItem
            // 
            this.列表中删除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中的ToolStripMenuItem,
            this.全部删除ToolStripMenuItem});
            this.列表中删除ToolStripMenuItem.Name = "列表中删除ToolStripMenuItem";
            this.列表中删除ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.列表中删除ToolStripMenuItem.Text = "列表中删除";
            // 
            // 删除选中的ToolStripMenuItem
            // 
            this.删除选中的ToolStripMenuItem.Name = "删除选中的ToolStripMenuItem";
            this.删除选中的ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除选中的ToolStripMenuItem.Text = "删除选中的";
            this.删除选中的ToolStripMenuItem.Click += new System.EventHandler(this.删除选中的ToolStripMenuItem_Click);
            // 
            // 全部删除ToolStripMenuItem
            // 
            this.全部删除ToolStripMenuItem.Name = "全部删除ToolStripMenuItem";
            this.全部删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.全部删除ToolStripMenuItem.Text = "全部删除";
            this.全部删除ToolStripMenuItem.Click += new System.EventHandler(this.全部删除ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|wav file (*.wav)|*.wav|wma files (*.wma)|*.wma|ASF files(" +
    "*.asf)|*.asf";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 672);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顺序播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单曲播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部循环ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 随机播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表中删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选中的ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部删除ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;





    }
}

