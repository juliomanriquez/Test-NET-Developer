using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {      
            GenerateColorChips();
            Console.ReadLine();
        }



        static void GenerateColorChips()
        {
            Random randomColor = new Random();
            const string startColor = "red";
            const string EndColor = "blue";

            //while (true)
            //{
                Console.Clear();

                Tuple<Color, Color>[] colorChip = new Tuple<Color, Color>[4];
                Tuple<Color, Color>[] colorChipCode = new Tuple<Color, Color>[4];

                Console.WriteLine("Access Code");

                Console.WriteLine("Your chips are :\n");

                for (int i = 0; i < colorChip.Length; i++)
                {
                    Color color1 = (Color)randomColor.Next(Enum.GetValues(typeof(Color)).Length);
                    Color color2 = (Color)randomColor.Next(Enum.GetValues(typeof(Color)).Length);

                    colorChip[i] = Tuple.Create(color1, color2);
                    Console.WriteLine(i + "-" + colorChip[i].ToString());
                }

                Console.WriteLine("\n To generate new chips press 0");
                Console.WriteLine("\n Please enter de correct position");
                int position = int.Parse(Console.ReadLine());

                int numCode = 0;
                if (position > 0 &&  colorChip[position].Item1.ToString() == startColor)
                {
                    colorChipCode[numCode] = colorChip[position];
                }
                else
                {
                    Console.WriteLine(Constants.ErrorMessage);
                }

            //    if (Console.ReadKey(true).KeyChar == '0')
            //    {
            //        break; 
            //    }

            //}

        }
    }
}
