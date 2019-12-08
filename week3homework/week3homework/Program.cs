using System;
using System.Linq;
using System.Text;

namespace week3homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a method that to remove the nth index character from a nonempty string.
            //RemoveLetter();
            //2.Write a method that to remove the characters which have odd index values of a given string.
            //RemoveOddIndex();
            //3.Write a method that takes input from the user and displays that input back in upper and lower cases.
            //UpperLower();
            //4.Write a method that reverses a string if it's length is a multiple of 4
            //Reversed();
            //5.Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
            // IfUppercase();
            // 6.Write a method that to remove a newline. (nu sunt sigur ca am inteles cerinta)
            // DeleteNewLine();
            // 7.Write a method to display formatted text(width= 50) as output.
            // For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line.
            // In this case we will have 3 lines of text.
            // Split50Ch();
            //8. Write a method that formats a number with a percentage
            Percentage();

            //   1. Write a method that to remove the nth index character from a nonempty string.
            static void RemoveLetter()
            {
                Console.WriteLine("Scrieti un cuvant");
                String cuvant = Console.ReadLine();
                StringBuilder sb = new StringBuilder(cuvant);
                Console.WriteLine("A cata litera doriti sa o stergem");
                int indexlitera = int.Parse(Console.ReadLine());
                sb.Remove(indexlitera - 1, 1);
                cuvant = sb.ToString();
                Console.WriteLine($"Noul cuvant este {cuvant}");
            }
            //2.Write a method that to remove the characters which have odd index values of a given string.
            static void RemoveOddIndex()
            {
                Console.WriteLine("Scrieti un cuvant");
                String cuvant = Console.ReadLine();
                StringBuilder sb = new StringBuilder(cuvant);
                String noulcuvant = "";
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] % 2 == 0)
                    {
                       noulcuvant += sb[i];
                    }
                }
                Console.WriteLine($"Noul cuvant este {noulcuvant}");
            }
            //3.Write a method that takes input from the user and displays that input back in upper and lower cases.
           static void UpperLower()
            {
                Console.WriteLine("Scrieti un cuvant");
                String cuvant = Console.ReadLine();
                StringBuilder sb = new StringBuilder(cuvant);
                String noulcuvantupper = cuvant.ToUpper();
                String noulcuvantlower = cuvant.ToLower();
                Console.WriteLine($"Noul cuvant UPPER este {noulcuvantupper}");
                Console.WriteLine($"Noul cuvant lower este {noulcuvantlower}");
            }

            //4.Write a method that reverses a string if it's length is a multiple of 4
            static void Reversed()
            {
                Console.WriteLine("Scrieti un cuvant");
                String cuvant = Console.ReadLine();
                StringBuilder sb = new StringBuilder(cuvant);
                String noulcuvant = "";
                if (sb.Length < 5)
                {
                    for (int i = 0; i < sb.Length; i++)
                    {
                        noulcuvant += sb[sb.Length - i - 1];
                    }
                    Console.WriteLine($"Noul cuvant este {noulcuvant}");
                }
                else
                {
                    Console.WriteLine($"Cuvantul este {cuvant}");
                }
            }
            //5.Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
            static void IfUppercase()
            {
                Console.WriteLine("Scrieti un cuvant");
                String cuvant = Console.ReadLine();
                StringBuilder sb = new StringBuilder(cuvant);
                int literamare=0;
                for (int i = 0; i < 4; i++)
                {
                    if (char.IsUpper(sb[i]))
                    {
                        literamare += 1;
                    }
                }
                if (literamare > 1)
                {
                    String noulcuvantupper = cuvant.ToUpper();
                    Console.WriteLine($"Noul cuvant este {noulcuvantupper}");
                }
                else 
                {
                    Console.WriteLine($"Cuvantul este {cuvant}");
                }
            }

            // 6.Write a method that to remove a newline. (nu sunt sigur ca am inteles cerinta)
            static void DeleteNewLine()
            {
               
                String fraza = " First line\n Second Line\n Third Line\n Forth Line";
                Console.WriteLine(fraza);
               // cuvant = cuvant.Replace(Environment.NewLine, " ");
                fraza = fraza.Replace("\n", String.Empty);
                Console.WriteLine("-------------------");
                Console.WriteLine(fraza);

            }

            // 7.Write a method to display formatted text(width= 50) as output.
            // For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line.
            // In this case we will have 3 lines of text.
            static void Split50Ch()
            {

                String fraza = "This is a very loooooooooooooooooooooooooooooooooooooooong string. This is a very loooooooooooooooooooooooooooooooooooooooong string.";
                Console.WriteLine(fraza);
                StringBuilder sb = new StringBuilder(fraza);
                Console.WriteLine(sb.Length);
                for (int i = 1; i < sb.Length; i++)
                {
              
                    if (i % 50 == 0)
                    sb.Insert(i , "\n");

                }
                Console.WriteLine("-------------------");
                Console.WriteLine(sb.ToString());

            }

            //8. Write a method that formats a number with a percentage
            static void Percentage()
            {
                String number = "0.8";
                Console.WriteLine(String.Format("Valoare procentuala: {0:P2}.", number));
            }



        }
    }
}
