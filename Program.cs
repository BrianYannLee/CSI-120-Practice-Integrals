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
            BreakingDownWordProblem();

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
            Console.WriteLine();

        }// end of Basic

        public static void BreakingDownWordProblem()
        {
            //Word Problem ------------------------------------------------
            Console.WriteLine("Samantha runs a small bakery. In one day, she bakes 5 batches of cookies, with each batch containing 24 cookies. She sells each cookie for $2. At the end of the day, she gives away 10 cookies to her neighbors and had to throw away 8 cookies that were accidentally burnt. How much money did Samantha make from selling the cookies after giving away and throwing away some of them?");
            //Delcaring and Initialize----------------------------------------
            byte batchTotal = 5; // number of batches  baked per day
            byte batchNum = 24; //number of cookies per batch
            decimal costPer = 2; //cost of a cookie in dollars
            byte give = 10; // number of cookies given away
            byte trash = 8; // number of cookies thrown away
            int cookieNum = 0; //number of cookies made per day
            decimal costTotal = 0; //number of dollars made from cookies
            decimal costBatch = 0; //cost per batch in dollars
            decimal costGive = 0; //cost per give in dollars
            decimal costTrash = 0; //cost per trash in dollars

            //Calculation----------------------------------------------------
            cookieNum = batchTotal * batchNum;
            costTotal = cookieNum * costPer;
            costBatch = costPer * batchNum;
            costGive = costPer * give;
            costTrash = costPer * trash;

            //Answer ----------------------------------------------------

            Console.WriteLine($"The cost of a single cookie is {costPer}");
            Console.WriteLine($"There is {batchNum} cookies in a batch");
            Console.WriteLine($"A Batch of cookies cost ${costBatch}");
            Console.WriteLine($"There is {cookieNum} cookies in {batchTotal} batches");
            Console.WriteLine($"{give} Cookies are given away. This cost Samantha ${costGive}");
            Console.WriteLine($"{trash} Cookies are thrown away. This cost Samantha ${costTrash}");
            Console.WriteLine($"Samantha made ${costTotal}");





        }//end of BreakingDownWordProblem


    }//end of class
}//end of namespace
