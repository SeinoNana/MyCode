using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CannonShotsPlanes.Properties;
using CannonShotsPlanes;

namespace CannonShotsPlanes {
    class Plane : GameElement {
        public bool canRemove {
            get;
            set;
        }
        public Image img {
            get;
            set;
        }
        public bool isAlive {
            get;
            set;
        }
        int initPosX;
        public Plane(int x, int y, int s, int w, int h) : base(x, y, s, w, h) {
            initPosX = x;
            isAlive = true;
            img = Resources._100_直升飞机;
            canRemove = false;
        }
        //绘制飞机到窗体上
        public override void Draw(Graphics g) {
            this.Move();
            g.DrawImage(img, this.posX, this.posY, this.Length, this.Width);
        }
        //飞机移动方法
        public override void Move() {

            if (isAlive) {
                this.posX += this.Speed;
            }
            else  {
                this.img = Resources.爆炸;
                this.posY += 5;
            }
            
            if(this.posX > 1250) {
                this.posX = initPosX; 
            }
            //坠落出范围，可以清除
            if(this.posY > 671) {
                this.canRemove = true;
            }
            Console.WriteLine("P posX = " + posX + "P posY =" + posY);
            ////当飞机超出范围，应当移除
            //if (this.posX > 800 || this.posY > 600) {
            //    SingleObject.GetSingle().DeleteGameObject(this);
            //}

        }

        //坠机
        public void planeCrashDown() {
            while (this.posY <= 671) {
                this.posY += 10;
                Thread.Sleep(50);
            }
            this.isAlive = false;
        }



    }
}
