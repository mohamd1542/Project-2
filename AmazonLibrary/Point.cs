﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonLibrary
{
    internal class Point
    {
        private double _x;
        private double _y;
        public double x { get
            {
                return _x;
            }
            set 
            {
                _x = value;
            } 
        }
        public double y { get
            {
                return _y;
            }
            set 
            {
                _y = value;
            } 
        }
    }
}
