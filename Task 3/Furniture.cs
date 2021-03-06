﻿namespace Task_3
{
    public class Furniture : Product
    {
        public Furniture(string name, string type, float price) : base(name, type, price)
        {

        }

        /// <summary>
        /// Used for a addition between same types of items.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>new same class item object</returns>
        public static Furniture operator +(Furniture a, Furniture b)
        {
            return new Furniture(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        }

        /// <summary>
        /// Converts this class object into a Chemical class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Chemical(Furniture a)
        {
            return new Chemical(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Converts this class object into a Food class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Food(Furniture a)
        {
            return new Food(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Converts this class object into a Technic class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Technic(Furniture a)
        {
            return new Technic(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Returns item price in the coins type
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator int(Furniture a)
        {
            return (int)(a.Price * 100);
        }

        /// <summary>
        /// Returns item price in the money and coins type
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator float(Furniture a)
        {
            return a.Price;
        }

        /// <summary>
        /// Used for comparing two objects
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If two items are equal - true, else - false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Furniture)
            {
                Furniture furniture = obj as Furniture;

                if (this.Name == furniture.Name && this.Price == furniture.Price && this.Type == furniture.Type)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns HashCode of the object
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            return (Type.GetHashCode() ^ Price.GetHashCode() ^ Name.GetHashCode());
        }
    }
}
