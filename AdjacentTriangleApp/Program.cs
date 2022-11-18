// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Triangle triangle = new Triangle();
using (StreamReader reader = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "triangle.txt")))
{
    while (!reader.EndOfStream)
    {
        triangle.AppendRow(reader.ReadLine());
    }
}
Console.WriteLine(triangle.GetMaxSum());
class Triangle
{
    private int[] Row = new int[0];

    public void AppendRow(string numbers)
    {
        int[] oldRow = Row;

        // http://stackoverflow.com/a/1297250
        Row = Array.ConvertAll(numbers.Trim().Split(' '), int.Parse);

        for (int j = 0; j < Row.Length; j++)
        {
            Row[j] += Math.Max
            (
                (j > 0) ? oldRow[j - 1] : 0,
                (j < oldRow.Length) ? oldRow[j] : 0
            );
        }
    }

    public int GetMaxSum()
    {
        return Row.Max();
    }
}

////Create triangle numbers string
//int i, j, k, l, n;
//n = 100;
//var rdn = new Random();
//string result = string.Empty;
//for (i = 1; i <= n; i++)
//{
//    for (j = 1; j <= n - i; j++)
//    {
//        result += " ";
//    }
//    for (k = 1; k <= i; k++)
//    {
//        result += " " + rdn.Next(9);
//    }
//    result += "\n";
//}

//Console.WriteLine(result);
//Console.ReadKey();