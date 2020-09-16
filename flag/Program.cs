using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace flag_1
{
    class Flag
    {
            private string stars1;
            private string stars2;
            private string red;
            private string white;
       public string Stars1{            
            get { return stars1; }
            set { stars1 = value; }
        }
            public string Stars2 { 
            get { return stars2; }
            set { stars2 = value; }
        }
            public string Red { 
            get { return red; }
            set { red = value; }
        }
            public string White { 
            get { return white; }
            set { white = value; }
        }
    }
            }
        class Program
        {
          static void Main(string[] args)
            {
                string stars1 = " * * * * * * * * * * *";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;

                string stars2 = "* * * * * * * * * * * ";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;

                string red = "* * * * * * * * * * * ";
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;

                string white = "* * * * * * * * * * * ";
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(red);
                Console.ReadKey();

            }
        }



            //Console.WriteLine(stars1 + red + red);
            //Console.WriteLine(stars2 + white + white);
            //Console.WriteLine(stars1 + red + red);
            //Console.WriteLine(stars2 + white + white);
            //Console.WriteLine(stars1 + red + red);
            //Console.WriteLine(stars2 + white + white);
            //Console.WriteLine(stars1 + red + red);
            //Console.WriteLine(stars2 + white + white);
            //Console.WriteLine(red + red + red);
            //Console.WriteLine(white + white + white);
            //Console.WriteLine(red + red + red);
            //Console.WriteLine(white + white + white);
            //Console.WriteLine(red + red + red);
            //Console.WriteLine(white + white + white);
            //Console.WriteLine(red + red + red);


