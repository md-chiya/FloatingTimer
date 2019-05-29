namespace Timer
{
    partial class TimerWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity100 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity70 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity50 = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cnacelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Timer = new System.Windows.Forms.Button();
            this.timer_increment = new System.Windows.Forms.Timer(this.components);
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.opacityToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cnacelToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(165, 126);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.setToolStripMenuItem.Text = "時間をセット";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.SetToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.moveToolStripMenuItem.Text = "移動させる";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.MoveToolStripMenuItem_Click);
            // 
            // opacityToolStripMenuItem
            // 
            this.opacityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacity100,
            this.opacity70,
            this.opacity50,
            this.opacity20});
            this.opacityToolStripMenuItem.Name = "opacityToolStripMenuItem";
            this.opacityToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.opacityToolStripMenuItem.Text = "不透明度";
            // 
            // opacity100
            // 
            this.opacity100.Name = "opacity100";
            this.opacity100.Size = new System.Drawing.Size(102, 22);
            this.opacity100.Text = "100%";
            this.opacity100.Click += new System.EventHandler(this.changeOpacity);
            // 
            // opacity70
            // 
            this.opacity70.Name = "opacity70";
            this.opacity70.Size = new System.Drawing.Size(102, 22);
            this.opacity70.Text = "70%";
            this.opacity70.Click += new System.EventHandler(this.changeOpacity);
            // 
            // opacity50
            // 
            this.opacity50.Name = "opacity50";
            this.opacity50.Size = new System.Drawing.Size(102, 22);
            this.opacity50.Text = "50%";
            this.opacity50.Click += new System.EventHandler(this.changeOpacity);
            // 
            // opacity20
            // 
            this.opacity20.Name = "opacity20";
            this.opacity20.Size = new System.Drawing.Size(102, 22);
            this.opacity20.Text = "20%";
            this.opacity20.Click += new System.EventHandler(this.changeOpacity);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // cnacelToolStripMenuItem
            // 
            this.cnacelToolStripMenuItem.Name = "cnacelToolStripMenuItem";
            this.cnacelToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cnacelToolStripMenuItem.Text = "このメニューを閉じる";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "終了";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // btn_Timer
            // 
            this.btn_Timer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Timer.ContextMenuStrip = this.cms;
            this.btn_Timer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Timer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Timer.FlatAppearance.BorderSize = 5;
            this.btn_Timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timer.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Timer.ForeColor = System.Drawing.Color.White;
            this.btn_Timer.Location = new System.Drawing.Point(0, 0);
            this.btn_Timer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Timer.Name = "btn_Timer";
            this.btn_Timer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Timer.Size = new System.Drawing.Size(334, 111);
            this.btn_Timer.TabIndex = 2;
            this.btn_Timer.Text = "00:00:00";
            this.btn_Timer.UseVisualStyleBackColor = false;
            this.btn_Timer.Click += new System.EventHandler(this.onClikck_btn);
            this.btn_Timer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // timer_increment
            // 
            this.timer_increment.Interval = 1000;
            this.timer_increment.Tick += new System.EventHandler(this.Timer_increment_Tick);
            // 
            // TimerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.btn_Timer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "TimerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.TopMost = true;
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.Button btn_Timer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cnacelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opacity100;
        private System.Windows.Forms.ToolStripMenuItem opacity70;
        private System.Windows.Forms.ToolStripMenuItem opacity50;
        private System.Windows.Forms.ToolStripMenuItem opacity20;
        private System.Windows.Forms.Timer timer_increment;
    }
}

