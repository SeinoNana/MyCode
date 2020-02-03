using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CannonShotsPlanes.Properties;

namespace CannonShotsPlanes {
    class Cannon : GameElement{
        public int angle;
        public Image img {
            get;
            set;
        }
        public Image bottomImg {
            get;
            set;
        }
        Pen p = new Pen(Color.Black);
        Point top, bottom;
        public Cannon(int x, int y, int s, int w, int h) : base(x, y, s, w, h) {
            top.X = 425;
            bottom.X = 425;
            bottom.Y = 420;
            top.Y = 380;
            bottomImg = Resources.坦克;
            angle = 90;
        }

        //在窗体上绘制大炮
        public override void Draw(Graphics g) {
            // this.Move();
            //画炮管
            switchImg(g, angle);
            //g.DrawImage(gunImg, this.posX, this.posY, this.Length, this.Width);
            //画炮底
            g.DrawImage(bottomImg, this.posX-50, this.posY+30, 100, 100);
           

            //画炮管
           // top.X = this.posX + this.Length / 2;
           // top.Y = this.posY - 45;
           // bottom.X = top.X;
           // bottom.Y = this.posY;
           //// g.DrawLine(p,top, bottom);
           // g.DrawLine(p, top, bottom);
        }
        public override void Move() {
            throw new NotImplementedException();
            
        }

        public void switchImg(Graphics g, int angle) {
            switch (angle) {
                case 90:
                    img = Resources._90;
                    g.DrawImage(img, this.posX, this.posY, 23, 80);
                    break;
                case 100:
                    img = Resources._100;
                    g.DrawImage(img, this.posX - 3, this.posY, 26, 80);
                    break;

                case 110:
                    img = Resources._110;
                    g.DrawImage(img, this.posX - 15, this.posY + 2, 38, 78);
                    break;
                case 120:
                    img = Resources._120;
                    g.DrawImage(img, this.posX - 27, this.posY + 6, 50, 74);
                    break;
                case 130:
                    img = Resources._130;
                    g.DrawImage(img, this.posX - 37, this.posY + 14, 60, 69);
                    break;
                case 140:
                    img = Resources._140;
                    g.DrawImage(img, this.posX - 45, this.posY + 23, 68, 60);
                    break;
                case 150:
                    img = Resources._150;
                    g.DrawImage(img, this.posX - 51, this.posY + 33, 74, 50);
                    break;
                case 160:
                    img = Resources._160;
                    g.DrawImage(img, this.posX - 54, this.posY + 43, 77, 38);
                    break;
                case 170:
                    img = Resources._170;
                    g.DrawImage(img, this.posX - 58, this.posY + 54, 81, 27);
                    break;
                case 180:
                    img = Resources._180;
                    g.DrawImage(img, this.posX - 60, this.posY + 58, 79, 22);
                    break;
                case 190:
                    img = Resources._190;
                    g.DrawImage(img, this.posX - 60, this.posY + 56, 81, 27);
                    break;
                case 200:
                    img = Resources._200;
                    g.DrawImage(img, this.posX - 54, this.posY + 57, 77, 38);
                    break;
                case 210:
                    img = Resources._210;
                    g.DrawImage(img, this.posX - 51, this.posY + 55, 74, 50);
                    break;
                case 220:
                    img = Resources._220;
                    g.DrawImage(img, this.posX - 45, this.posY + 55, 68, 60);
                    break;
                case 230:
                    img = Resources._230;
                    g.DrawImage(img, this.posX - 37, this.posY + 55, 60, 69);
                    break;
                case 240:
                    img = Resources._240;
                    g.DrawImage(img, this.posX - 27, this.posY + 56, 50, 74);
                    break;
                case 250:
                    img = Resources._250;
                    g.DrawImage(img, this.posX - 15, this.posY + 57, 38, 78);
                    break;
                case 260:
                    img = Resources._260;
                    g.DrawImage(img, this.posX - 3, this.posY + 58, 26, 80);
                    break;
                case 270:
                    img = Resources._270;
                    g.DrawImage(img, this.posX, this.posY + 59, 23, 80);
                    break;
                case 280:
                    img = Resources._280;
                    g.DrawImage(img, this.posX, this.posY + 58, 26, 80);
                    break;
                case 290:
                    img = Resources._290;
                    g.DrawImage(img, this.posX, this.posY + 58, 38, 78);
                    break;
                case 300:
                    img = Resources._300;
                    g.DrawImage(img, this.posX, this.posY + 58, 50, 74);
                    break;
                case 310:
                    img = Resources._310;
                    g.DrawImage(img, this.posX, this.posY + 58, 60, 69);
                    break;
                case 320:
                    img = Resources._320;
                    g.DrawImage(img, this.posX, this.posY + 58, 68, 60);

                    break;
                case 330:
                    img = Resources._330;
                    g.DrawImage(img, this.posX, this.posY + 58, 74, 50);
                    break;
                case 340:
                    img = Resources._340;
                    g.DrawImage(img, this.posX, this.posY + 58, 77, 38);
                    break;
                case 350:
                    img = Resources._350;
                    g.DrawImage(img, this.posX, this.posY + 58, 81, 27);
                    break;
                case 80:
                    img = Resources._80;
                    g.DrawImage(img, this.posX, this.posY, 26, 80);
                    break;
                case 70:
                    img = Resources._70;
                    g.DrawImage(img, this.posX, this.posY + 3, 38, 78);
                    break;
                case 60:
                    img = Resources._60;
                    g.DrawImage(img, this.posX, this.posY + 8, 50, 74);

                    break;
                case 50:
                    img = Resources._50;
                    g.DrawImage(img, this.posX, this.posY + 15, 60, 69);
                    break;
                case 40:
                    img = Resources._40;
                    g.DrawImage(img, this.posX, this.posY + 24, 68, 60);
                    break;
                case 30:
                    img = Resources._30;
                    g.DrawImage(img, this.posX, this.posY + 34, 74, 50);
                    break;
                case 20:
                    img = Resources._20;
                    g.DrawImage(img, this.posX, this.posY + 45, 77, 38);
                    break;
                case 10:
                    img = Resources._10;
                    g.DrawImage(img, this.posX, this.posY + 55, 81, 27);
                    break;
                case 0:
                    img = Resources._0;
                    g.DrawImage(img, this.posX, this.posY + 58, 79, 22);
                    break;
            }

            //switch (angle) {
            //    case 350:
            //        c.gunImg = Resources._350;
            //        c.Length = 81;
            //        c.Width = 27;
            //        break;
            //    case 340:
            //        c.gunImg = Resources._340;
            //        c.Length = 77;
            //        c.Width = 38;
            //        break;
            //    case 330:
            //        c.gunImg = Resources._330;
            //        c.Length = 74;
            //        c.Width = 50;
            //        break;
            //    case 320:
            //        c.gunImg = Resources._320;
            //        c.Length = 68;
            //        c.Width = 60;
            //        break;
            //    case 310:
            //        c.gunImg = Resources._310;
            //        c.Length = 60;
            //        c.Width = 69;
            //        break;
            //    case 300:
            //        c.gunImg = Resources._300;
            //        c.Length = 50;
            //        c.Width = 74;
            //        break;
            //    case 290:
            //        c.gunImg = Resources._290;
            //        c.Length = 38;
            //        c.Width = 78;
            //        break;
            //    case 280:
            //        c.gunImg = Resources._280;
            //        c.Length = 26;
            //        c.Width = 80;
            //        break;
            //    case 270:
            //        c.gunImg = Resources._270;
            //        c.Length = 22;
            //        c.Width = 80;
            //        break;
            //    case 260:
            //        c.gunImg = Resources._260;
            //        c.Length = 27;
            //        c.Width = 81;
            //        break;
            //    case 250:
            //        c.gunImg = Resources._250;
            //        c.Length = 38;
            //        c.Width = 77;
            //        break;
            //    case 240:
            //        c.gunImg = Resources._240;
            //        c.Length = 50;
            //        c.Width = 74;
            //        break;
            //    case 230:
            //        c.gunImg = Resources._230;
            //        c.Length = 60;
            //        c.Width = 68;
            //        break;
            //    case 220:
            //        c.gunImg = Resources._220;
            //        c.Length = 69;
            //        c.Width = 60;
            //        break;
            //    case 210:
            //        c.gunImg = Resources._210;
            //        c.Length = 74;
            //        c.Width = 50;
            //        break;
            //    case 200:
            //        c.gunImg = Resources._200;
            //        c.Length = 78;
            //        c.Width = 38;
            //        break;
            //    case 190:
            //        c.gunImg = Resources._190;
            //        c.Length = 80;
            //        c.Width = 26;
            //        break;
            //    case 180:
            //        c.gunImg = Resources._180;
            //        c.Length = 79;
            //        c.Width = 22;
            //        break;
            //    case 170:
            //        c.gunImg = Resources._170;
            //        c.Length = 81;
            //        c.Width = 27;
            //        break;
            //    case 160:
            //        c.gunImg = Resources._160;
            //        c.Length = 77;
            //        c.Width = 38;
            //        break;
            //    case 150:
            //        c.gunImg = Resources._150;
            //        c.Length = 74;
            //        c.Width = 50;
            //        break;
            //    case 140:
            //        c.gunImg = Resources._140;
            //        c.Length = 68;
            //        c.Width = 60;
            //        break;
            //    case 130:
            //        c.gunImg = Resources._130;
            //        c.Length = 60;
            //        c.Width = 68;
            //        break;
            //    case 120:
            //        c.gunImg = Resources._120;
            //        c.Length = 50;
            //        c.Width = 74;
            //        break;
            //    case 110:
            //        c.gunImg = Resources._110;
            //        c.Length = 38;
            //        c.Width = 78;
            //        break;
            //    case 100:
            //        c.gunImg = Resources._100;
            //        c.Length = 26;
            //        c.Width = 80;
            //        break;
            //    case 90:
            //        c.gunImg = Resources._90;

            //        c.Length = 23;
            //        c.Width = 80;
            //        break;
            //    case 80:
            //        c.gunImg = Resources._80;
            //        c.po
            //        c.Length = 26;
            //        c.Width = 80;
            //        break;
            //    case 70:
            //        c.gunImg = Resources._70;
            //        c.Length = 38;
            //        c.Width = 78;
            //        break;
            //    case 60:
            //        c.gunImg = Resources._60;
            //        c.Length = 50;
            //        c.Width = 74;
            //        break;
            //    case 50:
            //        c.gunImg = Resources._50;
            //        c.Length = 60;
            //        c.Width = 69;
            //        break;
            //    case 40:
            //        c.gunImg = Resources._40;
            //        c.Length = 68;
            //        c.Width = 60;
            //        break;
            //    case 30:
            //        c.gunImg = Resources._30;
            //        c.Length = 74;
            //        c.Width = 50;
            //        break;
            //    case 20:
            //        c.gunImg = Resources._20;
            //        c.Length = 77;
            //        c.Width = 38;
            //        break;
            //    case 10:
            //        c.gunImg = Resources._10;
            //        c.Length = 81;
            //        c.Width = 27;
            //        break;
            //    case 0:
            //        c.gunImg = Resources._0;
            //        c.Length = 79;
            //        c.Width = 22;
            //        c.posY =
            //        break;
        }
        }
}
