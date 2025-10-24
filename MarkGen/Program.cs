using System;
using System.IO;
using System.Threading;

namespace markgen {
    class main {
        static void Main() {
            Console.WriteLine("Welcome to Markdown Generator!");
            Thread.Sleep(2000);
            Console.WriteLine("You just have to fill the details to generate a Markdown file");
            Thread.Sleep(1000);
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine(); // Stores name
            Console.WriteLine("Enter a short text about youself");
            string about = Console.ReadLine(); // Stores about
            Console.WriteLine("Enter your Email");
            string email = Console.ReadLine(); // Stores email
            Console.WriteLine("Enter your website's link");
            string website = Console.ReadLine(); // Stores link
            Console.WriteLine("Enter your blog link");
            string blog = Console.ReadLine();
            Thread.Sleep(2000);
            Console.Clear();
            string combine = "# Hi! 👋, I am " + name + "\n" + "**💎**" + " " + about + "\n" + "**📪 Contact email is:**" + " " + email + "\n" + "**🌐 My Website is:**" + " " + website + "\n" + "**📝 My Blog is:**" + " " + blog; // Makes the files
            File.WriteAllText("gen.md", combine); // Exports
            Console.WriteLine("Exported!");
         }
    }
}
