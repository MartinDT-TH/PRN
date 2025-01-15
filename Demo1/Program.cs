// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//var a = Console.ReadLine();
//Console.WriteLine(a);
//Console.WriteLine($"The price us {2344.233:C}.");



/// <summary>
/// // Bài 1: Tính trung bình cộng các số chia hết cho 3 < 1000
/// </summary>

class Program
{
    static double Average(int limit)
    {
        int sum = 0,
            count = 0;
        for (int i = 0; i < limit; i++)
        {
            if (i % 3 == 0)
            {
                sum += i;
                count++;
            }
        }
        Console.WriteLine("sum:" + sum);
        Console.WriteLine("count:" + count);
        return count > 0 ? (double)sum/count : 0; 
    }

    static void pt_bac_2(int a, int b, int c)
    {
        double delta =  b * b - 4 * a * c;
        bool isExist = delta > 0;
        double sDelta = Math.Sqrt(delta);
        Console.WriteLine($"Delta: {delta}");
        int y = 2 * a;
        if (isExist) {
            double x1 = (-b + sDelta) / y;
            double x2 = (-b - sDelta) / y;
            Console.WriteLine("x1: {0}", x1);
            Console.WriteLine("x2: {0}", x2);
        }
        else
        {
            if(delta < 0) {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else
            {
                double x = -b / y;
                Console.WriteLine("Phương trình có nghiệm kép x = {0}", x);
            }
        }

    }

    static void permutation(int a, int b)
    {
        Console.WriteLine("Before swap: a: {0}, b: {1}", a, b);
        a = a*b;
        b = a / b;
        a = a / b;
        
        Console.WriteLine("After swap: a: {0}, b: {1}", a, b);
    }

    static void compare(int a, int b, int c)
    {
        int max = a;
        if (max<b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        if ( (a == b ? "true" : "false" )== "true")
        {
            Console.WriteLine("a == b");
        }
        Console.WriteLine( max);
    }

    static void Main(string[] args)
    {
        var a = 5;
        var b = 6;
        var c = 3;    
        // tính trung bình cộng các số chia hết cho 3 < 1000
        //Console.WriteLine("Trung bình cộng các số chia hết cho 3 < 1000 là: {0}", Average(1000));

        //pt_bac_2(6, 5, 0);
        //permutation(3, 5);
        //compare(a, b, c);
    }
}