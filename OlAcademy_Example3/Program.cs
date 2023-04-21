
/*დავალება 3: ორი სხვადასხვა მეთოდის შქმნა */
class Program
{
    static int MethodS(int length, int width)
    {
        return length * width;
    }

    static int MethodV(int length, int width, int height)
    {
        return length * width * height;
    }

    static void Main(string[] args)
    {

        int s = MethodS(3, 4);
        int v = MethodV(3, 4, 5);

        Console.Write("-----------------------------------------------------\n");
        Console.Write("-----------------------------------------------------\n");
        Console.WriteLine($"Method 1: length * width * height =  {s}");
        Console.WriteLine($"Method 2: length * width = {v}");
    }
}