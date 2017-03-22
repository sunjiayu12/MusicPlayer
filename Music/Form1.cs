using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;
using System.Data.OleDb;
using System.Diagnostics;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] MusicFileNames;
        bool SingleLoop = true;
        bool AllLoop = true;
        bool Normal = true;
        bool RandomLoop = true;

        #region//播放
        private void btnPlay_Click(object sender, EventArgs e)
        {
            listView1.Focus();
            Normal = true;
            if (this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition == 0)
            {
                if (this.listView1.Items.Count > 0)
                {
                    timer1.Start();
                    if (this.listView1.SelectedItems.Count > 0)
                    {
                        int iPos = this.listView1.SelectedItems[0].Index;
                        string FileName = this.listView1.Items[iPos].SubItems[2].Text;
                        this.axWindowsMediaPlayer1.URL = FileName;
                    }
                }
                else
                {
                    MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        #endregion

        #region//停止
        private void btnStop_Click(object sender, EventArgs e)
        {
            listView1.Focus();
            timer1.Stop();
            if (this.listView1.Items.Count > 0)
            {
                if (this.listView1.SelectedItems.Count > 0)
                {
                    timer1.Enabled = false;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
            }
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region//暂停
        private void btnPause_Click(object sender, EventArgs e)
        {
            listView1.Focus();
            timer1.Stop();
            if (this.listView1.Items.Count > 0)
            {
                if (this.listView1.SelectedItems.Count > 0)
                {
                    timer1.Enabled = false;
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
            }
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region//上一首
        private void btnLast_Click(object sender, EventArgs e)
        {
            listView1.Focus();
            if (this.listView1.SelectedItems.Count > 0)
            {
                int iPos = this.listView1.SelectedItems[0].Index;
                if (iPos > 0)
                {
                    this.listView1.Items[iPos - 1].Selected = true;
                    this.listView1.Items[iPos].Selected = false;
                    string FileName = this.listView1.Items[iPos - 1].SubItems[2].Text;
                    this.axWindowsMediaPlayer1.URL = FileName;
                }
                else
                {
                    MessageBox.Show("这已经是第一首歌曲了！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region//下一首
        private void btnNext_Click(object sender, EventArgs e)
        {
            listView1.Focus();
            if (this.listView1.SelectedItems.Count > 0)
            {
                int iPos = this.listView1.SelectedItems[0].Index;
                if (iPos < this.listView1.Items.Count - 1)
                {
                    this.listView1.Items[iPos + 1].Selected = true;
                    this.listView1.Items[iPos].Selected = false;
                    string FileName = this.listView1.Items[iPos + 1].SubItems[2].Text;
                    this.axWindowsMediaPlayer1.URL = FileName;
                }
                else
                {
                    MessageBox.Show("这已经是最后一首歌曲了！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listView1.Focus();
        }
        #endregion

        #region//双击列表
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Start();
            Normal = true;
            if (this.listView1.Items.Count > 0)
            {
                if (this.listView1.SelectedItems.Count > 0)
                {
                    int iPos = this.listView1.SelectedItems[0].Index;
                    string FileName = this.listView1.Items[iPos].SubItems[2].Text;
                    this.axWindowsMediaPlayer1.URL = FileName;
                }
            }
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion 

        #region//播放方式（实现循环）
        private void timer1_Tick(object sender, EventArgs e)          //用 timer_tick 来实现循环
        {
            if(this.listView1.SelectedItems.Count > 0)
            {
                int iTotal = this.listView1.Items.Count;
                Random rnd = new Random();
                int record = this.listView1.SelectedItems[0].Index;
                int rand = rnd.Next(1, iTotal);
                if (AllLoop == true && Normal == false)
                {
                    if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                    {
                        if (record < this.listView1.Items.Count - 1)
                        {
                            this.listView1.Items[record + 1].Selected = true;
                            this.listView1.Items[record].Selected = false;
                            string FileName = this.listView1.Items[record + 1].SubItems[2].Text;
                            this.axWindowsMediaPlayer1.URL = FileName;
                        }
                        else if (record == this.listView1.Items.Count - 1)
                        {
                            this.listView1.Items[0].Selected = true;
                            this.listView1.Items[record].Selected = false;
                            string FileName = this.listView1.Items[0].SubItems[2].Text;
                            this.axWindowsMediaPlayer1.URL = FileName;
                        }
                    }
                }
                else if (SingleLoop == true && Normal == false)
                {
                    if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                    {
                        this.listView1.Items[record].Selected = true;
                        this.axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                }
                else if (Normal == true)
                {
                    if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                    {
                        if (record < this.listView1.Items.Count - 1)
                        {
                            this.listView1.Items[record + 1].Selected = true;
                            this.listView1.Items[record].Selected = false;
                            string FileName = this.listView1.Items[record + 1].SubItems[2].Text;
                            this.axWindowsMediaPlayer1.URL = FileName;
                        }
                        else if (record == this.listView1.Items.Count - 1)
                        {
                            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
                            this.listView1.Items[record].Selected = false;
                        }
                    }
                }
                else if (RandomLoop == true && Normal == false)
                {
                    if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                    {
                        if ((record + rand) < this.listView1.Items.Count - 1)
                        {
                            this.listView1.Items[record + rand].Selected = true;
                            this.listView1.Items[record].Selected = false;
                            string FileName = this.listView1.Items[record + rand].SubItems[2].Text;
                            this.axWindowsMediaPlayer1.URL = FileName;
                        }
                        else if ((record + rand) >= this.listView1.Items.Count - 1)
                        {
                            this.listView1.Items[rand].Selected = true;
                            this.listView1.Items[record].Selected = false;
                            string FileName = this.listView1.Items[rand].SubItems[2].Text;
                            this.axWindowsMediaPlayer1.URL = FileName;
                        }
                    }
                }
            }
        }
        #endregion

        #region//添加文件
        private void 添加文件ToolStripMenuItem_Click(object sender, EventArgs e)   //添加文件以及其中的信息
        {
            this.openFileDialog1.Multiselect=true;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MusicFileNames = this.openFileDialog1.FileNames;
                foreach (string MusicName in MusicFileNames)
                {
                    FileInfo MyFileInfo = new FileInfo(MusicName);
                    //曲名
                    string MyShortFileName = MusicName.Substring(MusicName.LastIndexOf("\\") + 1);
                    MyShortFileName = MyShortFileName.Substring(0, MyShortFileName.Length - 4);
 
                    //大小
                    float MyFileSize = (float)MyFileInfo.Length / (1024 * 1024);

                    //载入
                    string[] SubItem ={ MyShortFileName, MyFileSize.ToString().Substring(0, 4) + "M", MusicName };
                    ListViewItem Item = new ListViewItem(SubItem);
                    this.listView1.Items.Add(Item);
                    this.listView1.Items[0].Selected = true;
                    WMPLib.IWMPMedia media = this.axWindowsMediaPlayer1.newMedia(MusicName);
                    this.axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
                }
            }
        }
        #endregion

        #region//添加文件夹
        private void 添加文件夹ToolStripMenuItem_Click(object sender, EventArgs e)     //添加文件夹以及其中文件的信息
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(this.folderBrowserDialog1.SelectedPath);
                foreach (FileInfo f in dir.GetFiles("*.mp3"))
                {
                    //曲名
                    string MyShortFileName = f.Name;
                    MyShortFileName = MyShortFileName.Substring(0, MyShortFileName.Length - 4);
 
                    //大小
                    float MyFileSize = (float)f.Length / (1024 * 1024);

                    //载入
                    string fileName=MyShortFileName.ToLower();
                    string[] SubItem = { MyShortFileName, MyFileSize.ToString().Substring(0, 4) + "M", f.FullName };
                    ListViewItem Item = new ListViewItem(SubItem);
                    this.listView1.Items.Add(Item);
                    this.listView1.Items[0].Selected = true;
                    WMPLib.IWMPMedia media = this.axWindowsMediaPlayer1.newMedia(f.DirectoryName);
                    this.axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
                }
            }
        }
        #endregion

        #region//播放方式
        private void 顺序播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Normal = true;
            RandomLoop = false;
            SingleLoop = false;
            AllLoop = false;
            this.顺序播放ToolStripMenuItem.Checked = true;
            this.单曲播放ToolStripMenuItem.Checked = false;
            this.全部循环ToolStripMenuItem.Checked = false;
            this.随机播放ToolStripMenuItem.Checked = false;
        }
        private void 单曲播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleLoop = true;
            AllLoop = false;
            Normal = false;
            RandomLoop = false;
            this.顺序播放ToolStripMenuItem.Checked = false;
            this.单曲播放ToolStripMenuItem.Checked = true;
            this.全部循环ToolStripMenuItem.Checked = false;
            this.随机播放ToolStripMenuItem.Checked = false;
        }
        private void 全部循环ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllLoop = true;
            SingleLoop = false;
            Normal = false;
            RandomLoop = false;
            this.顺序播放ToolStripMenuItem.Checked = false;
            this.单曲播放ToolStripMenuItem.Checked = false;
            this.全部循环ToolStripMenuItem.Checked = true;
            this.随机播放ToolStripMenuItem.Checked = false;
        }
        private void 随机播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomLoop = true;
            SingleLoop = false;
            AllLoop = false;
            Normal = false;
            this.顺序播放ToolStripMenuItem.Checked = false;
            this.单曲播放ToolStripMenuItem.Checked = false;
            this.全部循环ToolStripMenuItem.Checked = false;
            this.随机播放ToolStripMenuItem.Checked = true;
        }
        #endregion

        #region//删除文件
        private void 删除选中的ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (this.listView1.Items.Count > 0)
            {
                if (this.listView1.SelectedItems.Count > 0)
                {
                    int i = this.listView1.SelectedItems[0].Index;
                    this.listView1.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("没有要删除的歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 全部删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            timer1.Stop();
            if (this.listView1.Items.Count > 0)
            {
                this.listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("没有要删除的歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region//关于
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者：sjy\n\t\t\t\t——2015/4/15", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("E:\\音乐");

            foreach (FileInfo f in dir.GetFiles("*.*"))
            {
                if (f.Name.ToLower().EndsWith(".mp3") || f.Name.ToLower().EndsWith(".wav") || f.Name.ToLower().EndsWith(".wma")||f.Name.ToLower().EndsWith(".asf"))
                {
                    //曲名
                    string MyShortFileName = f.Name;
                    MyShortFileName = MyShortFileName.Substring(0, MyShortFileName.Length - 4);

                    //大小
                    float MyFileSize = (float)f.Length / (1024 * 1024);

                    //载入
                    string fileName = MyShortFileName.ToLower();
                    string[] SubItem = { MyShortFileName, MyFileSize.ToString().Substring(0, 4) + "M", f.FullName };
                    ListViewItem Item = new ListViewItem(SubItem);
                    this.listView1.Items.Add(Item);
                    WMPLib.IWMPMedia media = this.axWindowsMediaPlayer1.newMedia(f.DirectoryName);
                    this.axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
                }
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            listView1.Focus();
        }
    }
}
