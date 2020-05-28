using System;
using Business;

namespace ConsoleApp1
{

    
    class Program
    {
        public static string ConvertDigits(string Number)
        {
            Digits dgt = new Digits();
            string word = "";
            try
            {
                
                bool isDone = false;
                double dblAmt = (Convert.ToDouble(Number));

                if (dblAmt > 0)
                {                 

                    int numDigits = Number.Length;
                    int pos = 0;
                    string place = "";
                    switch (numDigits)
                    {
                        case 1:  
                            word = dgt.Ones(Convert.ToInt32(Number));
                            isDone = true;
                            break;
                        case 2: 
                            word = dgt.Tens(Convert.ToInt32(Number));
                            isDone = true;
                            break;
                        case 3:
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4:  
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    { 
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertDigits(Number.Substring(0, pos)) + place + ConvertDigits(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = ConvertDigits(Number.Substring(0, pos)) + ConvertDigits(Number.Substring(pos));
                        }

                       
                    }
                  
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { }
            return word.Trim();
        }

        static void Main(string[] args)
        {
            string isNegative = "";
            try
            {
             
                Console.WriteLine("Enter a Number to convert to currency");
                string number = Console.ReadLine();
                number = Convert.ToDouble(number).ToString();

                if (number.Contains("-"))
                {
                    isNegative = "Minus ";
                    number = number.Substring(1, number.Length - 1);
                }
                if (number == "0")
                {
                    Console.WriteLine("The number in currency fomat is \nZero Only");
                }
                else
                {
                    Console.WriteLine("The number in currency fomat is \n{0}", isNegative + ConvertDigits(number));
                }
                

                Console.ReadKey();
             
               

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
