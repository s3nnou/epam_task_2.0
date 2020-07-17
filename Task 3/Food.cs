﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Food : Product
    {
        public Food(string name, string type, float price) : base(name, type, price)
        {

        }

        /// <summary>
        /// Used for a addition between same types of items.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>new same class item object</returns>
        public static Food operator +(Food a, Food b)
        {
            return new Food(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        }

        /// <summary>
        /// Converts this class object into a Chemical class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Chemical(Food a)
        {
            return new Chemical(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Converts this class object into a Furniture class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Furniture(Food a)
        {
            return new Furniture(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Converts this class object into a Technic class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Technic(Food a)
        {
            return new Technic(a.Name, a.Type, a.Price);
        }


        /// <summary>
        /// Returns item price in the coins type
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator int(Food a)
        {
            return (int) (a.Price * 100);
        }

        /// <summary>
        /// Returns item price in the money and coins type
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator float(Food a)
        {
            return a.Price;
        }
    }
}