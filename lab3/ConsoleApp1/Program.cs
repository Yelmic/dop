using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != " " && name != "")
                    name = value;
                else
                    Console.WriteLine("The mistake");
            }
        }
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The mistake");
                }
                else
                    number = value;
            }
        }
        private int numway;

        public int Numway
        {
            get
            {
                return numway;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The mistake");
                }
                else
                    numway = value;
            }
        }
        private string mark;
        public string Mark
        {
            get
            {
                return mark;
            }
            set
            {
                if (mark != " " && mark != "")
                    mark = value;
                else
                    Console.WriteLine("The mistake");
            }
        }
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The mistake");
                }
                else
                    year = value;
            }
        }
        private int run;
        public int Run
        {
            get
            {
                return run;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The mistake");
                }
                else
                    run = value;
            }
        }
        public int Age(int year)
        {
            return 2020 - year;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length\n");
            int n = int.Parse(Console.ReadLine());
            Bus[] bus = new Bus[n];
            int k;
            Console.WriteLine("Enter the data\n");
            for (int i = 0; i < n; i++)
            {
                bus[i] = new Bus();
                Console.WriteLine("Enter the name:");
                bus[i].Name = Console.ReadLine();
                Console.WriteLine("Enter the number of bus:");
                bus[i].Number=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of way:");
                bus[i].Numway = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the mark:");
                bus[i].Mark = Console.ReadLine();
                Console.WriteLine("Enter the year:");
                bus[i].Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the run:");
                bus[i].Run = int.Parse(Console.ReadLine());
                k = bus[i].Age(bus[i].Year);
            }
            int num;
            Console.WriteLine("введите номер заданного маршрута");
            num= int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                if(num== bus[i].Numway)
                {
                    Console.WriteLine("Name "+ bus[i].Name);
                    Console.WriteLine("Number " + bus[i].Number);
                    Console.WriteLine("Numway " + bus[i].Numway);
                    Console.WriteLine("Mark " + bus[i].Mark);
                    Console.WriteLine("Year " + bus[i].Year);
                    Console.WriteLine("Run " + bus[i].Run);
                    Console.WriteLine("Age " + bus[i].Age(bus[i].Year));
                }
            }
            int time;
            Console.WriteLine("введите заданный срок");
            time= int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (time < bus[i].Age(bus[i].Year))
                {
                    Console.WriteLine("Name " + bus[i].Name);
                    Console.WriteLine("Number " + bus[i].Number);
                    Console.WriteLine("Numway " + bus[i].Numway);
                    Console.WriteLine("Mark " + bus[i].Mark);
                    Console.WriteLine("Year " + bus[i].Year);
                    Console.WriteLine("Run " + bus[i].Run);
                    Console.WriteLine("Age " + bus[i].Age(bus[i].Year));
                }
            }
        }
    }
}
