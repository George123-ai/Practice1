namespace JsonTxtReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtFilePath = @"C:\test\test1.txt";
            List<Person> people = new List<Person>();
            List<string> lines = new List<string>();
            

            lines = File.ReadAllLines(txtFilePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] items = lines[i].Split(',');
                Person person = new Person(items[0], items[1]);
                people.Add(person);

            }

            List<string> list1 = new List<string>(); 

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
                list1.Add(people[i].ToString());

            }

            //FileStream fs = File.Create("test2");

            string jsonFilePath = @"C:\test\testJson1.json";
            string[] jsonLines = File.ReadAllLines(jsonFilePath);
            for (int i = 0; i < jsonLines.Length; i++)
            {
                Console.WriteLine(jsonLines[i]);
            }
            //
            //string[] lines = File.ReadAllLines(txtFilePath);
            ////for (int i = 0; i < lines.Length; i++)
            ////{
            ////    Console.WriteLine(lines[i]);
            ////}
            
            //List<string> lines1 = new List<string>();
            //lines1 = File.ReadAllLines(txtFilePath).ToList();

            //for (int i = 0; i < lines1.Count; i++)
            //{
            //    Console.WriteLine(lines1[i]);
            //}

            //lines1.Add("Name:Bruce,Surname:Wayne");
            //Person person = new Person();
            
            //File.WriteAllLines(txtFilePath, lines1);

        }
    }
}