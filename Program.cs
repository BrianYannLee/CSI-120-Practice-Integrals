//Programmer: Brian Lee
//Date: 04/15/2024

//Title: Pratice Integrals

namespace CSI_120_Practice_Integrals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basics();
        }//end of main
        public static void Basics()
        {
            //Declariation and Initiliazation----------------------------------------
            float num1 = 0;
            float num2 = 0;
            float num3= 0;
            float q1 = 0;
            float q2 = 0;
            float q3 = 0;
            float q4 = 0;
            float q5 = 0;
            float q6 = 0;
            float q7 = 0;
            float q8 = 0;
            float q9 = 0;
            float q10 = 0;

            //User Input---------------------------------------------------------------
            Console.WriteLine("Please Enter Number 1: ");
            num1 =  float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number 2: ");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number 3: ");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            //Q Calculation------------------------------------------------------
            q1 = num1 + num2;
            q2 = num3 - num1 + num2;
            q3 = (num3 * num2) - num3;
            q4 = (num1 / num3) - num1;
            q5 = (num3 + num3 - num2) * 5;
            q6 = q1 * q3;
            q7 = q2 / q4;
            q8 = q5 + q1 + 2;
            q9 = (q3 - q6 + 1) * q4;
            q10 = ((q3 * q2) + (q4 + 2 - q6)) / q8;



            //Display Answer-----------------------------------------------------------

            Console.WriteLine($"Q1 = Num1 + Num2 = {q1}");
            Console.WriteLine($"Q2 = Num3-Num1+Num2 = {q2}");
            Console.WriteLine($"Q3 = (Num3*Num2)-Num3 = {q3}");
            Console.WriteLine($"Q4 = (Num1/Num3)-Num1 = {q4}");
            Console.WriteLine($"Q5 = (Num3+Num3-Num2)*5 = {q5}");
            Console.WriteLine($"Q1*Q3 = {q6}");
            Console.WriteLine($"Q2/Q4 = {q7}");
            Console.WriteLine($"Q5+Q1+2 = {q8}");
            Console.WriteLine($"(Q3-Q5+1)*Q4 = {q9}");
            Console.WriteLine($"((Q3*Q2)+(Q4+2-Q6))/Q8 = {q10}");


        }// end of Basic


    }//end of class
}//end of namespace
