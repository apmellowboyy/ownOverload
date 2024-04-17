using System;

namespace ownOverload
{
    public class milkVendor
    {
        public int size { get; set; }

        public static milkVendor operator ++(milkVendor obj)
        {
            obj.size++;
            return obj;

        }
        public static milkVendor operator --(milkVendor obj)
        {
            obj.size--;
            return obj;
        }
        public static bool operator >(milkVendor obj1, milkVendor obj2)
        {
            bool larger = false;
            if (obj1.size>obj2.size)
                larger=true;
            return larger;
        }

        public static bool operator <(milkVendor obj1, milkVendor obj2)
        {
            bool smaller = false;
            if (obj1.size < obj2.size)
                smaller = true;
            return smaller;
        }


        public static milkVendor operator +(milkVendor obj1, milkVendor obj2)
        {
            milkVendor calcBruh = new milkVendor();
            calcBruh.size = obj1.size + obj2.size;
            return calcBruh;
        }
        public static milkVendor operator -(milkVendor obj1, milkVendor obj2)
        {
            milkVendor calcBruh = new milkVendor();
            calcBruh.size = obj1.size - obj2.size;
            return calcBruh;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            milkVendor[] size = new milkVendor[17];
            Console.Write("SIZE OF MILK IN PINTS");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < size.Length; i++)
            {
                size[i] = new milkVendor();
                size[i].size = r.Next(1, 24);
                Console.Write(" " + size[i].size);
            }
            for (int i = 0; i < size.Length; i++)
            {
                if (size[i].size % 2 == 0)
                {
                    size[i]++;
                }
                else
                {
                    size[i]--;
                }
                Console.Write(" " + size[i].size);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************************************");

            milkVendor numToAdd = new milkVendor();
            numToAdd.size = r.Next(1, 30);
            Console.Write($"YESTERDAY's DELIVERIES ->>>>>>>> {numToAdd.size}");
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                size[i]+= numToAdd;
            }

            Console.WriteLine();

            milkVendor numToSub = new milkVendor();
            numToSub.size = r.Next(1, 50);


            milkVendor numToCompare = new milkVendor();
            numToCompare.size = r.Next(1, 40);
            Console.WriteLine($"TODAY's DELIVERIES ->>>>>>>> {numToCompare.size}");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine();

            for (int i = 0; i < 1; i++)
            {
                if (size[i] > numToCompare)
                {
                    Console.WriteLine("LIGHTER LOAD PEOPLE NO NEED TO RUSH.... TAKE YOUR TIME!");
                    Console.WriteLine();
                    Console.WriteLine("AWESOME I'M GOING TO USE THE BATHROOM FIRST!");
                }
                else if (size[i] < numToCompare)
                {
                    Console.WriteLine("HEAVY LOAD PEOPLE LET's GOOO..... LOAD THE TRUCK!");
                    Console.WriteLine();
                    Console.WriteLine("YOU GOT IT BOSS!");
                }
                else if (size[i] == numToCompare)
                {
                    Console.WriteLine("SAME LOAD AS BEFORE....WE'LL BE OUT BY 12!");
                    Console.WriteLine();
                    Console.WriteLine("MY DAY ISN'T WASTED!");
                }
                size[i]+= numToCompare;
                size[i]-= numToCompare;
            }

        }
    }
}
