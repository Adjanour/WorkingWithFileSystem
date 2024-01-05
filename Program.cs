using static System.Console;
using System.IO;
namespace WorkingWithFileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            File.WriteAllText("C:\\Users\\kirk\\Desktop\\Hello.txt", "Hello World and Welcome");
            if (File.Exists("C:\\Users\\kirk\\Desktop\\Hello.txt"))
            {
                Console.WriteLine("Success");
            }
            string Content = File.ReadAllText("C:\\Users\\Kirk\\Desktop\\schedule.txt");
            StreamWriter w = File.AppendText("C:\\Users\\kirk\\Desktop\\Hello.txt");
            w.WriteLine(Content);
            WriteLine(Content);

            string newFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NewFolder");

            WriteLine($"Working with: {newFolder}");

            WriteLine($"Does it exist? {Path.Exists(newFolder)}");
            WriteLine("Creating it ...");
            Directory.CreateDirectory(newFolder);
            WriteLine($"Does it exist? {Path.Exists(newFolder)}");
            Write("Confirm the directory exists, and then press ENTER: ");
            ReadLine();

            WriteLine("Deleting it ....");
            Directory.Delete(newFolder,true);
            WriteLine($"Does it exist? {Path.Exists(newFolder)}");

            byte[] binary = new byte[128];
            byte[] binary2 = new byte[128];

            binary = File.ReadAllBytes("C:\\Users\\Kirk\\Desktop\\Albert\\_5be9230c-9cad-425e-a3b8-a3f03408e306.jpg");
            WriteLine(binary.ToList());

            binary2 =(File.ReadAllBytes("C:\\Users\\Kirk\\Desktop\\Albert\\favicon-32x32.png"));
            
            string encoded = Convert.ToBase64String(binary);
            WriteLine(encoded);
           Stream file =  File.Create("C:\\Users\\Kirk\\Desktop\\Albert\\Bunny.png");
            file.Write(binary);
            file.Write(binary2);
        }
    }
}