using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannonShotsPlanes {
    abstract class GameElement {
        //将每个游戏元素看作一个矩形，定义相关属性

        //X坐标
        public int posX {
            get;
            set;
        }

        //Y坐标
        public int posY {
            get;
            set;
        }

        //矩形长
        public int Length {
            get;
            set;
        }

        //矩形宽
        public int Width {
            get;
            set;
        }

        //元素速度
        public int Speed {
            get;
            set;
        }
        public GameElement(int x, int y, int l, int w, int s) {
            this.posX = x;
            this.posY = y;
            this.Length = l;
            this.Width = w;
            this.Speed = s;
        }
        public abstract void Draw(Graphics g);
        public abstract void Move();
        public Rectangle GetRectangle() {
            Rectangle r = new Rectangle(this.posX, this.posY, this.Length, this.Width);
            return r;
        }
    }
}
