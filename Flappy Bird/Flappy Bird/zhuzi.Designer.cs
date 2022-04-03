namespace Flappy_Bird
{
    partial class zhuzi
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.up = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.PictureBox();
            this.TriggerMid = new System.Windows.Forms.PictureBox();
            this.movetimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerMid)).BeginInit();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Lime;
            this.up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.up.Location = new System.Drawing.Point(0, 0);
            this.up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(66, 312);
            this.up.TabIndex = 0;
            this.up.TabStop = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.Lime;
            this.down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.down.Location = new System.Drawing.Point(0, 500);
            this.down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(66, 312);
            this.down.TabIndex = 0;
            this.down.TabStop = false;
            // 
            // TriggerMid
            // 
            this.TriggerMid.Location = new System.Drawing.Point(20, 312);
            this.TriggerMid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriggerMid.Name = "TriggerMid";
            this.TriggerMid.Size = new System.Drawing.Size(27, 188);
            this.TriggerMid.TabIndex = 1;
            this.TriggerMid.TabStop = false;
            // 
            // movetimer
            // 
            this.movetimer.Enabled = true;
            this.movetimer.Interval = 16;
            this.movetimer.Tick += new System.EventHandler(this.Movetimer_Tick);
            // 
            // zhuzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TriggerMid);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "zhuzi";
            this.Size = new System.Drawing.Size(67, 812);
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerMid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox up;
        private System.Windows.Forms.PictureBox down;
        private System.Windows.Forms.Timer movetimer;
        public System.Windows.Forms.PictureBox TriggerMid;
    }
}
