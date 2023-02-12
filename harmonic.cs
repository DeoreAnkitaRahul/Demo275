namespace HelloWorld
{
    public class harmonicno
    {
        public static void Harmonic()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(" +1/" + i + " ");
            }
        }

    }
}
    
