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
            //Percentage();
            //9.  Write a method that reverses a string.
            //Reverse();
            // 11.Write a method that transforms to lowercase first n characters in a string.
            //lowercase();
            //12.Write a method to capitalize first and last letters of each word of a given string.
            //Capitalize();
            //13.Write a method to compute sum of digits of a given string(if any).
            //SumOfDigits();
            //14.You will get a text from where you will need to clean the text because it
            // contains a lot of strange characters that don’t belong there ( ^ <, > &+ @%$)
            // Cleaner();
            // 15. Write a method to add 'ing' at the end of a given string (length should be at least 3).
            //If the given string already ends with 'ing' then add 'ly' instead. 
            //If the string length of the given string is less than 3, leave it unchanged.
            // Ing();
            // 16. You have some text that contains your email address. And you want to hide that. 
            //You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain. 
            //Assume your email address will always be in format [username]@[domain]. 
            //You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. 
            //You will get as input the email address you need to obfuscate
            //Obfuscate();
            //17. Write a method to get a string made of the first 2 and the last 2 chars from a given a string.
            //If the string length is less than 2, return instead of the empty string.
            //FirstLastChar();
            //18. Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.
            // ReplaceWithFirstChar();
            //19. Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
            //  Input: 'abc', 'xyz'
            // Output: 'xyc abz'
            //SwapChar();
            //20. Write a method that takes a list of words and returns the length of the longest one.
            //LongestString();
            // 21. Write a method to find the first appearance of the substring 'not' and 'poor' from a given string,
            //if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'.Return the resulting string.
            //  Input: 'The lyrics is not that poor!'
            //  Output: 'The lyrics is poor!'
            //  Input: 'The lyrics is good!'
            //  Output: 'The lyrics is poor!'
            // Notpoor();
            // 22. Write a method to get the last part of a string before a specified character.
            // Input: https://www.siit.com/net-exercises
            //        -
            // Output:  https://www.siit.com/net
            // GetLastPartChar();
            // 23. Write a method to check whether a string starts with specified characters
            // input: awesome string
            //   a
            // output: Yes, starts with a
            // StartWithSpecChar();
            // 24.Write a method to count occurrences of a substring in a string
            // input: alabala portocala
            // ala
            // output : 3
            NoOfSubstring();



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
                int literamare = 0;
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
                        sb.Insert(i, "\n");

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


            //9.  Write a method that reverses a string.
            static void Reverse()
            {
                Console.WriteLine("Scrieti un cuvant");
                String cuv = Console.ReadLine();
                char[] cuvant = cuv.ToCharArray();
                Array.Reverse(cuvant);
                Console.WriteLine(cuvant);
            }

            //10.Write a method that strips a set of characters from a string.

            // 11.Write a method that transforms to lowercase first n characters in a string.
            static void lowercase()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti un cuvant");
                    String cuv = Console.ReadLine();
                    char[] cuvant = cuv.ToCharArray();
                    Console.WriteLine("Scrieti un numar");
                    int nr = int.Parse(Console.ReadLine());
                    for (int i = 0; i < nr; i++)
                    {
                        cuvant[i] = char.ToLower(cuvant[i]);
                    }
                    Console.WriteLine(cuvant);
                }

            }

            //12.Write a method to capitalize first and last letters of each word of a given string.
            static void Capitalize()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti un cuvant");
                    String cuv = Console.ReadLine();
                    char[] cuvant = cuv.ToCharArray();
                    cuvant[0] = char.ToUpper(cuvant[0]);
                    cuvant[cuv.Length - 1] = char.ToUpper(cuvant[cuv.Length - 1]);
                    Console.WriteLine(cuvant);
                }
            }

            //13.Write a method to compute sum of digits of a given string(if any).
            static void SumOfDigits()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti un cuvant");
                    String cuv = Console.ReadLine();
                    char[] cuvant = cuv.ToCharArray();
                    int Suma = 0;
                    for (int i = 0; i < cuv.Length; i++)
                    {
                        Suma = int.Parse(cuvant[i].ToString()) + Suma;
                    }
                    Console.WriteLine(Suma);
                }
            }

            //14.You will get a text from where you will need to clean the text because it
            // contains a lot of strange characters that don’t belong there ( ^ <, > &+ @%$)
            static void Cleaner()
            {
                String cuv = "Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later.";
                char[] ToTrim = { '^', '<', ',', '>', '&', '+', '@', '%', '$' };
                string cuvnou = cuv.TrimStart(ToTrim);
                Console.WriteLine(cuv);
                Console.WriteLine(cuvnou);
            }

            // 15. Write a method to add 'ing' at the end of a given string (length should be at least 3).
            //If the given string already ends with 'ing' then add 'ly' instead. 
            //If the string length of the given string is less than 3, leave it unchanged.
            static void Ing()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti un cuvant");
                    String cuv = Console.ReadLine();
                    if (cuv.Length >= 3)
                    {
                        if (cuv.Substring(cuv.Length - 3, 3) == "ing")
                        {
                            cuv = cuv + "ly";
                            Console.WriteLine(cuv);
                        }
                        else
                        {
                            cuv = cuv + "ing";
                        }
                    }
                    Console.WriteLine(cuv);
                }
               
            }

            // 16. You have some text that contains your email address. And you want to hide that. 
            //You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain. 
            //Assume your email address will always be in format [username]@[domain]. 
            //You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. 
            //You will get as input the email address you need to obfuscate
            static void Obfuscate()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti un cuvant");
                    String cuv = Console.ReadLine();
                    char[] car = cuv.ToCharArray();
                    int nr = car.Length;
                    for (
                        int i = 0; i < nr; i++)
                    {
                        if (car[i].ToString() != "@")
                        {
                            car[i] = char.Parse("*");
                        }
                        else 
                        {
                            break;   
                        }
                    }
                    Console.WriteLine(car);
                }
            }

            //17. Write a method to get a string made of the first 2 and the last 2 chars from a given a string.
            //If the string length is less than 2, return instead of the empty string.

            static void FirstLastChar()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti un cuvant");
                    String cuv = Console.ReadLine();
                    char[] car = cuv.ToCharArray();
                    int nr = car.Length;
                    String cuvnou = "";
                    if (nr >= 2)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            cuvnou = cuvnou + car[i];
                        }
                        for (int i = nr-2; i < nr; i++)
                        {
                            cuvnou = cuvnou + car[i];
                        }
                        Console.WriteLine(cuvnou);
                    }
                    else
                    {
                        Console.WriteLine("Empty String");
                    }
                }
            }

            //18. Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.
            static void ReplaceWithFirstChar()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti un cuvant");
                    String cuv = Console.ReadLine();
                    char[] car = cuv.ToCharArray();
                    int nr = car.Length;
                    for (
                        int i = 1; i < nr; i++)
                    {
                        
                       if (car[i] == car[0])
                        {
                            car[i] = char.Parse("$");
                        }
                    }
                    Console.WriteLine(car);
                }
            }

            //19. Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
            //  Input: 'abc', 'xyz'
            // Output: 'xyc abz'
            static void SwapChar()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti primul cuvant");
                    String cuv1 = Console.ReadLine();
                    char[] car1 = cuv1.ToCharArray();
                    Console.WriteLine("Scrieti al doilea cuvant");
                    String cuv2 = Console.ReadLine();
                    char[] car2 = cuv2.ToCharArray();
                    int nr1 = car1.Length;
                    int nr2 = car2.Length;
                    String cuvnou1 = "";
                    String cuvnou2 = "";
                    for (int i = 0; i < 2; i++)
                    {
                        cuvnou1 = cuvnou1 + car2[i];
                    }
                    for (int i = 2; i < nr1; i++)
                    {
                        cuvnou1 = cuvnou1 + car1[i];
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        cuvnou2 = cuvnou2 + car1[i];
                    }
                    for (int i = 2; i < nr2; i++)
                    {
                        cuvnou2 = cuvnou2 + car2[i];
                    }
                    Console.WriteLine(cuvnou1 + cuvnou2);
                }
            }

            //20. Write a method that takes a list of words and returns the length of the longest one.
            static void LongestString()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti un cuvantul 1");
                    String cuv1 = Console.ReadLine();
                    int nr1 = cuv1.Length;
                    Console.WriteLine("Scrieti un cuvantul 2");
                    String cuv2 = Console.ReadLine();
                    int nr2 = cuv2.Length;
                    Console.WriteLine("Scrieti un cuvantul 3");
                    String cuv3 = Console.ReadLine();
                    int nr3 = cuv3.Length;
                    Console.WriteLine("Scrieti un cuvantul 4");
                    String cuv4 = Console.ReadLine();
                    int nr4 = cuv4.Length;
                    Console.WriteLine("Scrieti un cuvantul 5");
                    String cuv5 = Console.ReadLine();
                    int nr5 = cuv5.Length;
                    int max = Math.Max(nr1, Math.Max(nr2, Math.Max(nr3, Math.Max(nr4, nr5))));
                    Console.WriteLine($"Cel mai lung cuvant introdus are {max} litere");
                }
            }


            // 21. Write a method to find the first appearance of the substring 'not' and 'poor' from a given string,
            //if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'.Return the resulting string.
            //  Input: 'The lyrics is not that poor!'
            //  Output: 'The lyrics is poor!'
            //  Input: 'The lyrics is good!'
            //  Output: 'The lyrics is poor!'

            static void Notpoor()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti primul cuvant");
                    String cuv1 = Console.ReadLine();
                    char[] car1 = cuv1.ToCharArray();
                    String cuvnou = "";
                    if (cuv1.Contains("not") && cuv1.IndexOf("not") < cuv1.IndexOf("poor"))
                    {
                        cuvnou = cuv1.Substring(0, cuv1.IndexOf("not")) + "poor!";

                    }
                    else
                    {
                        cuvnou = cuv1.Substring(0, cuv1.IndexOf("good!")) + "poor";
                    }
                    Console.WriteLine(cuvnou);
                }
            }

            // 22. Write a method to get the last part of a string before a specified character.
            // Input: https://www.siit.com/net-exercises
            //        -
            // Output:  https://www.siit.com/net

            static void GetLastPartChar()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti primul cuvant");
                    String cuv1 = Console.ReadLine();
                    Console.WriteLine("Scrieti caracterul special");
                    String carspec = Console.ReadLine();
                    String cuvnou = "";
                    if (cuv1.Contains(carspec))
                    {
                        cuvnou = cuv1.Substring(0, cuv1.IndexOf(carspec));
                        Console.WriteLine(cuvnou);
                    }
                    
                }
            }

            // 23. Write a method to check whether a string starts with specified characters
            // input: awesome string
            //   a
            // output: Yes, starts with a
            static void StartWithSpecChar()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti primul cuvant");
                    String cuv1 = Console.ReadLine();
                    Console.WriteLine("Scrieti caracterul");
                    String carspec = Console.ReadLine();
                    String cuvnou = "";
                    if (cuv1.Contains(carspec) && cuv1.IndexOf(carspec) == 0)
                    {
                        cuvnou = cuv1.Substring(0, cuv1.IndexOf(carspec));
                        Console.WriteLine($"Yes, starts with {carspec}");
                    }
                    else
                    {
                        Console.WriteLine($"Nope, it not starts with {carspec}");
                    }

                }
            }

            // 24.Write a method to count occurrences of a substring in a string
            // input: alabala portocala
            // ala
            // output : 3
            static void NoOfSubstring()
            {
                while (true)
                {
                    Console.WriteLine("Scrieti primul cuvant");
                    String cuv1 = Console.ReadLine();
                    Console.WriteLine("Scrieti substringul");
                    String substr = Console.ReadLine();
                    int no = 0;
                    for (int i = 0; i < (cuv1.Length - substr.Length); i++)
                    {
                        String substr2 = cuv1.Substring(i, substr.Length);
                        if ((substr2).Contains(substr))
                        {
                            no = no + 1;
                        }
                    }
                    Console.WriteLine(no);
                }
            }
        }
    }
}
