using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15OrangeTree
{
    public class OrangeTree
    {
        private int age;
        private int height;


        public OrangeTree(int age, int height)
        {
            this.age = age;
            this.height = height;
        }


        public int Age
        {
            get;
            private set;

        }
        public int Height
        {
            get
            {
                return height;
            }
            private set
            {
                height = value;
            }
        }
        public bool TreeAlive
        {
            get;
            set;
        }
        public int NumOranges
        {
            get;
            private set;
        }
        public int OrangesEaten
        {
            get;
            private set;
        }

        public void OneYearPasses()
        {
            Age++;

            if (Age < 80)
            {
                Height += 2;
            }

            OrangesEaten = 0;
            

            if (Age > 1 && Age <= 80)
            {
                NumOranges += 5;
            }


            if (Age > 80)
            {
                TreeAlive = false;
                NumOranges = 0;
            }

        }


        public void EatOrange(int v)
        {
            OrangesEaten += v;

            if (Age < 1)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
