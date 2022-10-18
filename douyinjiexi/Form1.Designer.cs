namespace douyinjiexi
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_shuchu_video = new System.Windows.Forms.TextBox();
            this.textBox_shuru1 = new System.Windows.Forms.TextBox();
            this.textBox_shuchu_music = new System.Windows.Forms.TextBox();
            this.textBox_shuchu_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_down_IDM = new System.Windows.Forms.Button();
            this.button_down_Thunder = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析后复制到剪贴板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析后使用IDM下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析后使用迅雷下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_ver = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.copy_to_jtb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(695, 15);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(144, 41);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "开始解析";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_shuchu_video
            // 
            this.textBox_shuchu_video.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_shuchu_video.Location = new System.Drawing.Point(87, 214);
            this.textBox_shuchu_video.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_shuchu_video.Multiline = true;
            this.textBox_shuchu_video.Name = "textBox_shuchu_video";
            this.textBox_shuchu_video.Size = new System.Drawing.Size(604, 141);
            this.textBox_shuchu_video.TabIndex = 1;
            this.textBox_shuchu_video.TextChanged += new System.EventHandler(this.textBox_shuchu_video_TextChanged);
            // 
            // textBox_shuru1
            // 
            this.textBox_shuru1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_shuru1.Location = new System.Drawing.Point(87, 15);
            this.textBox_shuru1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_shuru1.Multiline = true;
            this.textBox_shuru1.Name = "textBox_shuru1";
            this.textBox_shuru1.Size = new System.Drawing.Size(604, 41);
            this.textBox_shuru1.TabIndex = 2;
            this.textBox_shuru1.Leave += new System.EventHandler(this.textBox_shuru1_Leave);
            // 
            // textBox_shuchu_music
            // 
            this.textBox_shuchu_music.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_shuchu_music.Location = new System.Drawing.Point(86, 149);
            this.textBox_shuchu_music.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_shuchu_music.Multiline = true;
            this.textBox_shuchu_music.Name = "textBox_shuchu_music";
            this.textBox_shuchu_music.Size = new System.Drawing.Size(604, 61);
            this.textBox_shuchu_music.TabIndex = 3;
            this.textBox_shuchu_music.TextChanged += new System.EventHandler(this.textBox_shuchu_music_TextChanged);
            // 
            // textBox_shuchu_desc
            // 
            this.textBox_shuchu_desc.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_shuchu_desc.Location = new System.Drawing.Point(87, 115);
            this.textBox_shuchu_desc.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_shuchu_desc.Multiline = true;
            this.textBox_shuchu_desc.Name = "textBox_shuchu_desc";
            this.textBox_shuchu_desc.Size = new System.Drawing.Size(604, 28);
            this.textBox_shuchu_desc.TabIndex = 4;
            this.textBox_shuchu_desc.TextChanged += new System.EventHandler(this.textBox_shuchu_desc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "分享内容:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "标题:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "音乐URL:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(7, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "视频URL:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(145, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "并复制分享链接到此处即可，链接将自动提取";
            // 
            // button_down_IDM
            // 
            this.button_down_IDM.Enabled = false;
            this.button_down_IDM.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_down_IDM.Location = new System.Drawing.Point(695, 288);
            this.button_down_IDM.Margin = new System.Windows.Forms.Padding(2);
            this.button_down_IDM.Name = "button_down_IDM";
            this.button_down_IDM.Size = new System.Drawing.Size(144, 30);
            this.button_down_IDM.TabIndex = 12;
            this.button_down_IDM.Text = "IDM下载";
            this.button_down_IDM.UseVisualStyleBackColor = true;
            this.button_down_IDM.Click += new System.EventHandler(this.button_down_IDM_Click);
            // 
            // button_down_Thunder
            // 
            this.button_down_Thunder.Enabled = false;
            this.button_down_Thunder.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_down_Thunder.Location = new System.Drawing.Point(695, 251);
            this.button_down_Thunder.Margin = new System.Windows.Forms.Padding(2);
            this.button_down_Thunder.Name = "button_down_Thunder";
            this.button_down_Thunder.Size = new System.Drawing.Size(144, 30);
            this.button_down_Thunder.TabIndex = 13;
            this.button_down_Thunder.Text = "下载到桌面";
            this.button_down_Thunder.UseVisualStyleBackColor = true;
            this.button_down_Thunder.Click += new System.EventHandler(this.button_down_Thunder_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "抖音无水印解析助手";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nIcon_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主程序ToolStripMenuItem,
            this.解析ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 显示主程序ToolStripMenuItem
            // 
            this.显示主程序ToolStripMenuItem.Name = "显示主程序ToolStripMenuItem";
            this.显示主程序ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.显示主程序ToolStripMenuItem.Text = "显示主程序";
            this.显示主程序ToolStripMenuItem.Click += new System.EventHandler(this.显示主程序ToolStripMenuItem_Click);
            // 
            // 解析ToolStripMenuItem
            // 
            this.解析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.解析后复制到剪贴板ToolStripMenuItem,
            this.解析后使用IDM下载ToolStripMenuItem,
            this.解析后使用迅雷下载ToolStripMenuItem});
            this.解析ToolStripMenuItem.Name = "解析ToolStripMenuItem";
            this.解析ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.解析ToolStripMenuItem.Text = "一键解析剪贴板内容";
            this.解析ToolStripMenuItem.Click += new System.EventHandler(this.解析ToolStripMenuItem_Click);
            // 
            // 解析后复制到剪贴板ToolStripMenuItem
            // 
            this.解析后复制到剪贴板ToolStripMenuItem.Name = "解析后复制到剪贴板ToolStripMenuItem";
            this.解析后复制到剪贴板ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.解析后复制到剪贴板ToolStripMenuItem.Text = "解析后直链复制到剪贴板";
            this.解析后复制到剪贴板ToolStripMenuItem.Click += new System.EventHandler(this.解析后复制到剪贴板ToolStripMenuItem_Click);
            // 
            // 解析后使用IDM下载ToolStripMenuItem
            // 
            this.解析后使用IDM下载ToolStripMenuItem.Name = "解析后使用IDM下载ToolStripMenuItem";
            this.解析后使用IDM下载ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.解析后使用IDM下载ToolStripMenuItem.Text = "解析后使用IDM下载视频";
            this.解析后使用IDM下载ToolStripMenuItem.Click += new System.EventHandler(this.解析后使用IDM下载ToolStripMenuItem_Click);
            // 
            // 解析后使用迅雷下载ToolStripMenuItem
            // 
            this.解析后使用迅雷下载ToolStripMenuItem.Name = "解析后使用迅雷下载ToolStripMenuItem";
            this.解析后使用迅雷下载ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.解析后使用迅雷下载ToolStripMenuItem.Text = "解析后下载视频到桌面";
            this.解析后使用迅雷下载ToolStripMenuItem.Click += new System.EventHandler(this.解析后使用迅雷下载ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label_ver
            // 
            this.label_ver.AutoSize = true;
            this.label_ver.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ver.Location = new System.Drawing.Point(793, 548);
            this.label_ver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ver.Name = "label_ver";
            this.label_ver.Size = new System.Drawing.Size(0, 19);
            this.label_ver.TabIndex = 15;
            this.label_ver.Click += new System.EventHandler(this.label_ver_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(724, 548);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "版本号：";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button_copy
            // 
            this.button_copy.Enabled = false;
            this.button_copy.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_copy.Location = new System.Drawing.Point(695, 214);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(144, 30);
            this.button_copy.TabIndex = 17;
            this.button_copy.Text = "复制下载链接";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.button_update.Location = new System.Drawing.Point(623, 542);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(69, 30);
            this.button_update.TabIndex = 18;
            this.button_update.Text = "检查更新";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(90, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "打开抖音";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // copy_to_jtb
            // 
            this.copy_to_jtb.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.copy_to_jtb.Location = new System.Drawing.Point(695, 115);
            this.copy_to_jtb.Name = "copy_to_jtb";
            this.copy_to_jtb.Size = new System.Drawing.Size(144, 28);
            this.copy_to_jtb.TabIndex = 20;
            this.copy_to_jtb.Text = "复制标题";
            this.copy_to_jtb.UseVisualStyleBackColor = true;
            this.copy_to_jtb.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.button2.Location = new System.Drawing.Point(695, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "播放音乐";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.button3.Location = new System.Drawing.Point(695, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "播放视频";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.button4.Location = new System.Drawing.Point(697, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 48);
            this.button4.TabIndex = 23;
            this.button4.Text = "解析剪贴板分享链接并推送IDM下载";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.解析后使用IDM下载ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 586);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.copy_to_jtb);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_ver);
            this.Controls.Add(this.button_down_Thunder);
            this.Controls.Add(this.button_down_IDM);
            this.Controls.Add(this.textBox_shuru1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_shuchu_desc);
            this.Controls.Add(this.textBox_shuchu_music);
            this.Controls.Add(this.textBox_shuchu_video);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "抖音无水印解析助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_shuchu_video;
        private System.Windows.Forms.TextBox textBox_shuru1;
        private System.Windows.Forms.TextBox textBox_shuchu_music;
        private System.Windows.Forms.TextBox textBox_shuchu_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_down_IDM;
        private System.Windows.Forms.Button button_down_Thunder;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析后复制到剪贴板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析后使用IDM下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析后使用迅雷下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label label_ver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button copy_to_jtb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

