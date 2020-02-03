using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CannonShotsPlanes.Properties;

namespace CannonShotsPlanes {
    public partial class Form1 : Form {
        int angle = 90;//炮管初始角度为90度
        public bool isEnd = false;
        public Graphics graphics;
        static List<Plane> planes = new List<Plane>();//存放飞机的链表
        List<Bullet> bullets = new List<Bullet>();//存放子弹的链表
        private int planeCount = 3;//初始飞机数为1
        private int score = 0;
        //初始时有一架飞机
        Plane plane = new Plane(-50, 50, 50, 50, 5);
        Plane plane2 = new Plane(-50, 80, 50, 50, 5);
        PictureBox pb = new PictureBox();
        Cannon c = new Cannon(400, 400, 30, 80, 50);
        public Form1() {
            //pb.BackgroundImage = Resources.100;
            //pb.BackgroundImageLayout = ImageLayout.Stretch;
            //this.Controls.Add(pb);
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //获得Form1的画板
            graphics = this.CreateGraphics();
            //planes.Add(plane);
           // planes.Add(plane2);
            
            //画出大炮和炮管
            
            //初始时有一架飞机
            //  Thread newPlane = new Thread(createOnePlane);
            //newPlane.Start();
            // Thread drawThread = new Thread(Draw);
            //   drawThread.Start();
            //Thread t_thread_run = new Thread(a);
            //t_thread_run.Start();
            Thread t = new Thread(createOnePlane);
            t.Start();

          
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            for(int i = 0; i < planes.Count; i++) {
                planes[i].Draw(e.Graphics);
            }
            //选择炮台图片
            //switchImg();
            for (int i = 0; i < bullets.Count; ++i) {
                bullets[i].Draw(e.Graphics);
            }

            c.Draw(e.Graphics);

            
            //  plane.Draw(e.Graphics);
            //label1.Text = "" + planes.Count();
            //drawOneCannon();
            //drawAllPlanes();
            
            lblCount.Text = planeCount.ToString();
            lblScore.Text = score.ToString();
            //MessageBox.Show("w");

        }

        //public void switchImg() {
        //    switch (angle) {
        //        case 350:
        //            c.gunImg = Resources._350;
        //            c.Length = 81;
        //            c.Width = 27;
        //            break;
        //        case 340:
        //            c.gunImg = Resources._340;
        //            c.Length = 77;
        //            c.Width = 38;
        //            break;
        //        case 330:
        //            c.gunImg = Resources._330;
        //            c.Length = 74;
        //            c.Width = 50;
        //            break;
        //        case 320:
        //            c.gunImg = Resources._320;
        //            c.Length = 68;
        //            c.Width = 60;
        //            break;
        //        case 310:
        //            c.gunImg = Resources._310;
        //            c.Length = 60;
        //            c.Width = 69;
        //            break;
        //        case 300:
        //            c.gunImg = Resources._300;
        //            c.Length = 50;
        //            c.Width = 74;
        //            break;
        //        case 290:
        //            c.gunImg = Resources._290;
        //            c.Length = 38;
        //            c.Width = 78;
        //            break;
        //        case 280:
        //            c.gunImg = Resources._280;
        //            c.Length = 26;
        //            c.Width = 80;
        //            break;
        //        case 270:
        //            c.gunImg = Resources._270;
        //            c.Length = 22;
        //            c.Width = 80;
        //            break;
        //        case 260:
        //            c.gunImg = Resources._260;
        //            c.Length = 27;
        //            c.Width = 81;
        //            break;
        //        case 250:
        //            c.gunImg = Resources._250;
        //            c.Length = 38;
        //            c.Width = 77;
        //            break;
        //        case 240:
        //            c.gunImg = Resources._240;
        //            c.Length = 50;
        //            c.Width = 74;
        //            break;
        //        case 230:
        //            c.gunImg = Resources._230;
        //            c.Length = 60;
        //            c.Width = 68;
        //            break;
        //        case 220:
        //            c.gunImg = Resources._220;
        //            c.Length = 69;
        //            c.Width = 60;
        //            break;
        //        case 210:
        //            c.gunImg = Resources._210;
        //            c.Length = 74;
        //            c.Width = 50;
        //            break;
        //        case 200:
        //            c.gunImg = Resources._200;
        //            c.Length = 78;
        //            c.Width = 38;
        //            break;
        //        case 190:
        //            c.gunImg = Resources._190;
        //            c.Length = 80;
        //            c.Width = 26;
        //            break;
        //        case 180:
        //            c.gunImg = Resources._180;
        //            c.Length = 79;
        //            c.Width = 22;
        //            break;
        //        case 170:
        //            c.gunImg = Resources._170;
        //            c.Length = 81;
        //            c.Width = 27;
        //            break;
        //        case 160:
        //            c.gunImg = Resources._160;
        //            c.Length = 77;
        //            c.Width = 38;
        //            break;
        //        case 150:
        //            c.gunImg = Resources._150;
        //            c.Length = 74;
        //            c.Width = 50;
        //            break;
        //        case 140:
        //            c.gunImg = Resources._140;
        //            c.Length = 68;
        //            c.Width = 60;
        //            break;
        //        case 130:
        //            c.gunImg = Resources._130;
        //            c.Length = 60;
        //            c.Width = 68;
        //            break;
        //        case 120:
        //            c.gunImg = Resources._120;
        //            c.Length = 50;
        //            c.Width = 74;
        //            break;
        //        case 110:
        //            c.gunImg = Resources._110;
        //            c.Length = 38;
        //            c.Width = 78;
        //            break;
        //        case 100:
        //            c.gunImg = Resources._100;
        //            c.Length = 26;
        //            c.Width = 80;
        //            break;
        //        case 90:
        //            c.gunImg = Resources._90;
                    
        //            c.Length = 23;
        //            c.Width = 80;
        //            break;
        //        case 80:
        //            c.gunImg = Resources._80;
        //            c.po
        //            c.Length = 26;
        //            c.Width = 80;
        //            break;
        //        case 70:
        //            c.gunImg = Resources._70;
        //            c.Length = 38;
        //            c.Width = 78;
        //            break;
        //        case 60:
        //            c.gunImg = Resources._60;
        //            c.Length = 50;
        //            c.Width = 74;
        //            break;
        //        case 50:
        //            c.gunImg = Resources._50;
        //            c.Length = 60;
        //            c.Width = 69;
        //            break;
        //        case 40:
        //            c.gunImg = Resources._40;
        //            c.Length = 68;
        //            c.Width = 60;
        //            break;
        //        case 30:
        //            c.gunImg = Resources._30;
        //            c.Length = 74;
        //            c.Width = 50;
        //            break;
        //        case 20:
        //            c.gunImg = Resources._20;
        //            c.Length = 77;
        //            c.Width = 38;
        //            break;
        //        case 10:
        //            c.gunImg = Resources._10;
        //            c.Length = 81;
        //            c.Width = 27;
        //            break;
        //        case 0:
        //            c.gunImg = Resources._0;
        //            c.Length = 79;
        //            c.Width = 22;
                     
        //            break;
        //    }
        //}
        
        private void timer1_Tick(object sender, EventArgs e) {
            collisionDetection();
           
        }

        private void btnCreatePlane_Click(object sender, EventArgs e) {
            Random rd = new Random();
            int posY = rd.Next(200) + 20;
            //int length = rd.Next(80) + 20;
            int length = 50;
            int width = length;
            int posX = -length;
            //int speed = rd.Next(20) + 5;
            int speed = 1;
            Plane newPlane = new Plane(posX, posY, length, width, speed);
            planes.Add(newPlane);
            lblCount.Text = planeCount.ToString();
            planeCount++;
           
            //Random rd = new Random();
            //int posY = rd.Next(200)+ 20;
            //int length = rd.Next(80) + 20;
            //int width = length;
            //int posX = -length;
            //int speed = rd.Next(5) ;
            //Thread newPlane = new Thread(createOnePlane);
            //newPlane.Start();
            //Plane newPlane = new Plane(posX, posY, length, width, speed);
            //planes.Add(newPlane);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.A:
                    c.angle += 10;
                    angle += 10;
                    if (c.angle == 360) {
                        c.angle = 0;
                        angle = 0;
                    }
                    btnTurnLeft.BackColor = Color.Gray;
                    break;
                case Keys.D:
                    c.angle -= 10;
                    angle -= 10;
                    if (c.angle == -10) {
                        c.angle = 350;
                        angle = 350;
                    }
                    btnTurnRight.BackColor = Color.Gray;
                    break;
                case Keys.Left:
                    c.posX -= 10;
                    btnLeft.BackColor = Color.Gray;
                    break;
                case Keys.Right:
                    c.posX += 10;
                    btnRight.BackColor = Color.Gray;
                    break;
                case Keys.Up:
                    c.posY -= 10;
                    btnUp.BackColor = Color.Gray;
                    break;
                case Keys.Down:
                    c.posY += 10;
                    btnDown.BackColor = Color.Gray;
                    break;
                case Keys.C:
                    btnCreatePlane_Click(sender, e);
                    btnCreatePlane.BackColor = Color.Gray;
                    break;
                case Keys.Space:
                    //Bullet newBullet = new Bullet(382, 355, 20, 20, 5, angle);
                    //bullets.Add(newBullet);
                    Thread newBulletThread = new Thread(createOneBullet);
                    newBulletThread.Start();
                    btnFire.BackColor = Color.Gray;
                    break;
                default:
                    break;

            }

        }

        private void Form1_Load(object sender, EventArgs e) {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            // c.Draw(this.CreateGraphics());
            // Thread drawThread = new Thread(Draw);
            //   drawThread.Start();
        }

        
        //画出所有炮弹
        public void drawAllBullets() {
            for(int i = 0; i < bullets.Count; ++i) {
                bullets[i].Draw(this.CreateGraphics());
            }
        }
        //生成一架飞机
        public void createOnePlane() {
            Random rd = new Random();

           // for (int i = 0; i < 3; i++) {
                
                int posY = rd.Next(200) + 50;
                //int length = rd.Next(80) + 20;
                int length = 50;
                int width = length;
                int posX = -length;
                //int speed = rd.Next(20) + 5;
                int speed = 1;
                Plane newPlane = new Plane(posX, posY, length, width, speed);
                planes.Add(newPlane);
                lblCount.Text = planeCount.ToString();
            //}
            while (!isEnd) {
                this.Invalidate();
               // if (Singl.planes.Count < 3) {
                //    for (int i = 0; i < 5; i++) {
                //        SingleObject.GetSingle().AddGameObject(new Plane(0, r.Next(0, 500), r.Next(3, 10), 50, 50));
                //        Thread.Sleep(100);
                //    }
                //}
                Thread.Sleep(25);
                
            }
           
            //飞机的移动
            //while (newPlane.isAlive == true) {
            //    //newplane.draw(this.creategraphics());
            //    newPlane.Draw(this.CreateGraphics());
            //   // Thread.Sleep(200);
            //}
        }

        //生成一颗炮弹
        public void createOneBullet() {
            //计算炮管的角度
            int initX = c.posX + c.Length / 2;
            int initY = c.posY + c.Width / 2;
            Bullet newBullet = new Bullet(initX-30, initY+20, 20, 20, 5, angle);
            bullets.Add(newBullet);

  

            //炮弹的移动
            //while(newBullet.isAlive == true) {
            //    newBullet.Move();
            //    lock (this){
            //        //炮弹的碰撞检测
            //        if (collisionDetection(newBullet.GetRectangle())) {
            //            bullets.Remove(newBullet);
            //            //Invoke(new MethodInvoker(delegate { MessageBox.Show("恭喜你,游戏结束!"); }));
            //            //当前线程结束
            //            Thread.CurrentThread.Abort();
            //            //cnt++;
            //            //label2.Text = "" + cnt;
            //           // MessageBox.Show("游戏结束");
            //        }
            //    }
            //    Thread.Sleep(200);
            //}

            //bullets.Remove(newBullet);


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            btnRight.BackColor = Color.Silver;
            btnLeft.BackColor = Color.Silver;
            btnDown.BackColor = Color.Silver;
            btnUp.BackColor = Color.Silver;
            btnTurnLeft.BackColor = Color.Silver;
            btnTurnRight.BackColor = Color.Silver;
            btnFire.BackColor = Color.Silver;
            btnCreatePlane.BackColor = Color.Silver;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
           // if(e.KeyChar == Keys.Space) {

           // }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Invalidate();
        }

        //炮弹出界
        private bool bulletOutofBounds(Bullet bullet) {
            if (bullet.posX < 0 || bullet.posX > 1250 || bullet.posY < 0 || bullet.posY > 671) {
                return true;
            }
            else {
                return false;
            } 
        }

        //碰撞检测
        public void collisionDetection() {
            for (int i = 0; i < planes.Count; i++)
                for (int j = 0; j < bullets.Count; j++) {
                    if (planes[i].isAlive == true && planes[i].GetRectangle().IntersectsWith(bullets[j].GetRectangle())) {
                        score++;
                        planeCount--;
                        
                        //if(planes.Count != 1)
                        planes[i].isAlive = false;
                        if (planes[i].canRemove) { 
                            planes.Remove(planes[i]);
                        }
                        bullets.Remove(bullets[j]);
                        //   this.label2.Text = "" + ++cnt;
                    }
                    else {
                        if (bulletOutofBounds(bullets[j]))
                            bullets.Remove(bullets[j]);
                    }
                }
        }

        private void btnCreatePlane_Click_1(object sender, EventArgs e) {
            btnCreatePlane_Click(sender, e);
            //btnCreatePlane.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e) {
            isEnd = true;
            MessageBox.Show("游戏结束！");
        }

        private void btnTurnLeft_Click(object sender, EventArgs e) {
            c.angle += 10;
            angle += 10;
            if (c.angle == 360) {
                c.angle = 0;
                angle = 0;
            }
            //btnTurnLeft.BackColor = Color.Gray;
        }

        private void btnUp_Click(object sender, EventArgs e) {
            c.posY -= 10;
            //btnUp.BackColor = Color.Gray;
        }

        private void btnTurnRight_Click(object sender, EventArgs e) {
            c.angle -= 10;
            angle -= 10;
            if (c.angle == -10) {
                c.angle = 350;
                angle = 350;
            }
           // btnTurnRight.BackColor = Color.Gray;
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            c.posX -= 10;
            //btnLeft.BackColor = Color.Gray;
        }

        private void btnFire_Click(object sender, EventArgs e) {
            //Bullet newBullet = new Bullet(382, 355, 20, 20, 5, angle);
            //bullets.Add(newBullet);
            Thread newBulletThread = new Thread(createOneBullet);
            newBulletThread.Start();
        }

        private void btnRight_Click(object sender, EventArgs e) {
            c.posX += 10;
           // btnLeft.BackColor = Color.Gray;
        }

        private void btnDown_Click(object sender, EventArgs e) {
            c.posY += 10;
           // btnUp.BackColor = Color.Gray;
        }
    }
}
