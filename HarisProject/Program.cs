using HarisProject;

//static void Main(string[] args)
//{
    string str;
    int n;

    Number p = new Number();

    Console.WriteLine("Enter Your Number:");
    n = int.Parse(Console.ReadLine());
    str = p.convert(n);
    Console.WriteLine(str);
    Console.ReadKey();
//}