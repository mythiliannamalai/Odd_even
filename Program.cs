namespace Odd_even
{
    class Program
    {
        public void Calculation()
        {
         int GET_NUM;
            Console.WriteLine("Enter the value : ");
            GET_NUM =int.Parse(Console.ReadLine());
            if(GET_NUM %2 == 0)
            {
                Console.WriteLine("{0} is Even number....", GET_NUM);
            }
          else
            {
                Console.WriteLine("{0} is Odd number....",GET_NUM);
            }       
        }
    }
    class Result
    {
        public static void Main(string[]args)
        {
            Program pro=new Program();
            pro.Calculation();
        }
    }
}