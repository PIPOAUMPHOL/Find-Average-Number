
namespace AvgApp {
    class Program{
        static void Main() {
        
        int sum = 0;
        int avg = 0;

        for (int count = 1; count <=5; count++) {
            int number;
            Console.Write("Input Number = ");
            int.TryParse(Console.ReadLine(), out number);
            sum = sum + number;
            avg = avg + 1;
        }


        Console.WriteLine((double)sum/avg);

        
        }
    }
}
