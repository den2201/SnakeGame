﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Domain
{
   public class Figure
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach( var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point p)
        {
            foreach(var i in pList)
            {
                if(p.IsHit(i))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
