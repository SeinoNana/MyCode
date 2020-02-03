namespace CannonShotsPlanes {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCreatePlane = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnTurnRight = new System.Windows.Forms.Button();
            this.btnTurnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(213, 39);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 21);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblScore.Location = new System.Drawing.Point(542, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(68, 21);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "label2";
            // 
            // btnCreatePlane
            // 
            this.btnCreatePlane.BackColor = System.Drawing.Color.Silver;
            this.btnCreatePlane.BackgroundImage = global::CannonShotsPlanes.Properties.Resources.战斗机;
            this.btnCreatePlane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreatePlane.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreatePlane.Location = new System.Drawing.Point(1051, 525);
            this.btnCreatePlane.Name = "btnCreatePlane";
            this.btnCreatePlane.Size = new System.Drawing.Size(60, 60);
            this.btnCreatePlane.TabIndex = 10;
            this.btnCreatePlane.UseVisualStyleBackColor = false;
            this.btnCreatePlane.Click += new System.EventHandler(this.btnCreatePlane_Click_1);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Silver;
            this.btnFire.BackgroundImage = global::CannonShotsPlanes.Properties.Resources.fantankedaodan;
            this.btnFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFire.Location = new System.Drawing.Point(137, 499);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(50, 50);
            this.btnFire.TabIndex = 9;
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnTurnRight
            // 
            this.btnTurnRight.BackColor = System.Drawing.Color.Silver;
            this.btnTurnRight.BackgroundImage = global::CannonShotsPlanes.Properties.Resources.炮管右倾;
            this.btnTurnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnRight.Location = new System.Drawing.Point(193, 431);
            this.btnTurnRight.Name = "btnTurnRight";
            this.btnTurnRight.Size = new System.Drawing.Size(60, 60);
            this.btnTurnRight.TabIndex = 8;
            this.btnTurnRight.UseVisualStyleBackColor = false;
            this.btnTurnRight.Click += new System.EventHandler(this.btnTurnRight_Click);
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.BackColor = System.Drawing.Color.Silver;
            this.btnTurnLeft.BackgroundImage = global::CannonShotsPlanes.Properties.Resources.炮管左倾;
            this.btnTurnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnLeft.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTurnLeft.Location = new System.Drawing.Point(71, 434);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(60, 60);
            this.btnTurnLeft.TabIndex = 7;
            this.btnTurnLeft.UseVisualStyleBackColor = false;
            this.btnTurnLeft.Click += new System.EventHandler(this.btnTurnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Silver;
            this.btnDown.BackgroundImage = global::CannonShotsPlanes.Properties.Resources.向下;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(137, 555);
            this.btnDown.Name = "btnDown";
            this.btnDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDown.Size = new System.Drawing.Size(50, 62);
            this.btnDown.TabIndex = 6;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Silver;
            this.btnUp.BackgroundImage = global::CannonShotsPlanes.Properties.Resources.向上;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(137, 433);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(50, 60);
            this.btnUp.TabIndex = 5;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Silver;
            this.btnRight.BackgroundImage = global::CannonShotsPlanes.Properties.Resources.向右;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(193, 499);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 50);
            this.btnRight.TabIndex = 4;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Silver;
            this.btnLeft.BackgroundImage = global::CannonShotsPlanes.Properties.Resources.向左;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(71, 499);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(60, 50);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(961, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "A：炮口左转";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(961, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "D：炮口右转";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(961, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "C：产生一架飞机";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(961, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Space：开火";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(961, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "方向键：大炮移动";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(784, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 61);
            this.label8.TabIndex = 16;
            this.label8.Text = "规则：游戏过程可随时按C键添加飞机，若飞机全部被射下，则游戏结束";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "当前飞机数量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(421, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "当前得分：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(973, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "结束";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreatePlane);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnTurnRight);
            this.Controls.Add(this.btnTurnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCount);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnTurnLeft;
        private System.Windows.Forms.Button btnTurnRight;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnCreatePlane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

