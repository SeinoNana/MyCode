using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CannonShotsPlanes.Properties;

namespace CannonShotsPlanes {
 
    class Bullet : GameElement {
        private Image img = Resources._1;
        private int angle;
        public bool isAlive {
            get;
            set;
        }
        public Bullet(int x, int y, int l, int w, int s, int angle) : base(x, y, l, w, s) {
            isAlive = true;
            this.angle = angle;
        }
        public override void Draw(Graphics g) {
            Move();
            g.DrawImage(img, this.posX, this.posY, this.Length, this.Width);
        }

        public override void Move() {
            
            if (isAlive) {
                //计算炮管的角度
               
                double degree = (angle / 180.0) * 3.1415;
                this.posX += (int)(Math.Cos(degree) * this.Speed);
                this.posY -= (int)(Math.Sin(degree) * this.Speed);
                if (angle == 80) {
                    this.posX += 1;
                }
                Console.WriteLine("B posX = " + posX + "B posY =" + posY);
                //this.posX += 5;
                //this.posY -= 5;
            }

           
        }



   
    }
}
