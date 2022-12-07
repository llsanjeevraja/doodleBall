﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameEngine
{
    public class Vector2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2D()
        {
            this.X = Zero().X;
            this.Y = Zero().Y;
        }
        public Vector2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        static Vector2D Zero()
        {
            return new Vector2D(0, 0);
        }
        public double Magnitude()
        {
            return(Math.Sqrt(this.X* this.X + this.Y * this.Y));
        }
        

    }

}
