public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade");
        int x = int.Parse(Console.ReadLine());

        if (x > 100){
            Console.WriteLine("Letter Grade: A++");
            Console.WriteLine("Unbelivable");
        } else if (x == 100){
            Console.WriteLine("Letter Grade: A+");
            Console.WriteLine("Wow! 100…That's impressive!");
        } else if (x >= 90 && x < 100){
            Console.WriteLine("Letter Grade: A");
            Console.WriteLine("Very nice!");
        } else if (x >= 80 && x < 90){
            Console.WriteLine("Letter Grade: B");
            Console.WriteLine("Keep it up!");
        } else if (x >= 70 && x < 80){
            Console.WriteLine("Letter Grade: C");
           Console.WriteLine("You got this, keep working!");
        } else if (x >= 60 && x < 70){
            Console.WriteLine("Letter Grade: D");
            Console.WriteLine("Keep trying!");
        } else {
            Console.WriteLine("Letter Grade: E");
            Console.WriteLine("Don't give up!");            
        }
    }
}