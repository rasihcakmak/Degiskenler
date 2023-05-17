using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger;
            deger=2;

           Console.WriteLine(deger);
           string degisken= null;
           string Degisken= null;
           byte b = 5;
           sbyte c = 5; // 1byte 
           short d=5; // 2 byte
           object o1="x";
           object o2 = 'y';
           object o3 = 4;
           object o4 =4.5;
            string str20 = "20";
            int int20= 20 ;
            string yenideg = str20 + int20.ToString();
            Console.WriteLine(yenideg);



        }
    }
}