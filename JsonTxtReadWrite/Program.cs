namespace JsonTxtReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtFilePath = @"C:\test\test1.txt";


            string[] lines = File.ReadAllLines(txtFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }

            //List<string> lines = new List<string>();

        }
    }
}