using System;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pushes = int.Parse(Console.ReadLine());
            string sms = string.Empty;

            for (int i = 0; i < pushes; i++)
            {
                string nums = Console.ReadLine();

                int numLength = nums.Length;         //length
                                                     // char oneNum = nums[0];

                int firstNum = nums[0] - '0';        //digit
                int ofset = (firstNum - 2) * 3;      //offset

                if (firstNum == 0)                   //check for space
                {
                    sms += (char)(firstNum + 32);    //letter = (char)(firstNum + 32);
                    continue;                        //removes [
                }

                if (firstNum == 8 || firstNum == 9)
                {
                    ofset++; //ofset = (firstNum - 2) * 3 + 1; 
                }

                int letterIndex = ofset + numLength - 1;

                //int letter = (char)(letterIndex + 97);  //removed, we need letter not number
                //int letterCode = letterIndex + 97;

                sms += (char)(letterIndex + 97);         //add letter to message
            }

            Console.WriteLine(sms);                  //print message
        }
    }
}