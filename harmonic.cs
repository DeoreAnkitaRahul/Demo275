namespace HelloWorld
{
    public class harmonicno
    {
        public static void Harmonic()
        {

            double result = 0.0, num = 0;
            int n,j;
            n = Convert.ToInt32(Console.ReadLine());


            // INPUT DATA
            Console.Write("\n\n");
            Console.Write("enter the harmonic you want to find: ");
            

            // COMPUTATION
            for (j = 1; j <= n; j++)
            {
                num = num + (1 / j);
                result = num;
            }
            Console.WriteLine("the value of harmonic no. " + n + " is: " + result);

        }

    }
}
    
