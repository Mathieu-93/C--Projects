using System;
namespace homework1
{
    class Vector2D
    {
        public Vector2D(int x=0,int y=0)
        {
             this.x = x;
             this.y = y;
        }
        private readonly int x,y;
        public int X{
            get{return x;}
        }
        public int Y{
            get{return y;}
        }
        
        public double Length{
            get{return Math.Sqrt(X*X+Y*Y);}
        }

        public static Vector2D operator +( Vector2D v1, Vector2D v2 )=>new Vector2D(v1.x+v2.x,v1.y+v2.y);
        public override string ToString() => $"[{x},{y}]";
        
    }
}