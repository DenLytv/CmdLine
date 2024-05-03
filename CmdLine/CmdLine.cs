using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmd
{
    internal class CmdLine
    {
        public void Md(string name)
        {
            if (Directory.Exists(name))
                throw new Exception($"md : An element with the specified name {Directory.GetCurrentDirectory()}\\{name} already exists.");
            Directory.CreateDirectory(name);
        }
        public void Rd(string name)
        {
            if (!Directory.Exists(name))
                throw new Exception($"rd : Cannot find path {Directory.GetCurrentDirectory()}\\{name} because it does not exist.");
            Directory.Delete(name);
        }
        public void Cd(string name)
        {
            if (!Directory.Exists(name))
                throw new Exception($"cd : Cannot find path {Directory.GetCurrentDirectory()}\\{name} because it does not exist.");
            Directory.SetCurrentDirectory(name);
        }
        public void Create(string name)
        {
            if (File.Exists(name))
                throw new Exception($"create : An element with the specified name {Directory.GetCurrentDirectory()}\\{name} already exists.");
            Console.WriteLine("Input file data: ");
            File.WriteAllText(name, Console.ReadLine());
        }
        public void Type(string name)
        {
            if (!File.Exists(name))
                throw new Exception($"type : Cannot find path {Directory.GetCurrentDirectory()}\\{name} because it does not exist.");
            using (StreamReader sr = new StreamReader(name))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        public void Copy(string name1, string name2)
        {
            if (!File.Exists(name2))
            {
                File.Copy(name1, name2);
            }
            else
                throw new Exception($"copy : Copy with path {Directory.GetCurrentDirectory()}\\{name2} already exist");
        }
        public void Del(string name)
        {
            if (!File.Exists(name))
                throw new Exception($"del : Cannot find path {Directory.GetCurrentDirectory()}\\{name} because it does not exist.");
            File.Delete(name);
        }
        public void Append(string name)
        {
            if (!File.Exists(name))
                throw new Exception($"append : Cannot find path {Directory.GetCurrentDirectory()}\\{name} because it does not exist.");
            Console.Write("Input data: ");
            File.AppendAllText(name, Console.ReadLine());
        }
        public void Dir(string pattern)
        {
            string pathDir = Directory.GetCurrentDirectory();
            DirectoryInfo di = new DirectoryInfo(pathDir);
            int counter1 = 0, counter2 = 0;
            long size = 0;
            foreach (DirectoryInfo d in di.EnumerateDirectories(pattern))
            {
                Console.WriteLine($"{d.Name,-40} {"<DIR>",-15} {d.CreationTime,-20}");
                ++counter1;
            }
            foreach (FileInfo f in di.EnumerateFiles(pattern))
            {
                Console.WriteLine($"{f.Name,-40} {f.Length,-15} {f.CreationTime,-20}");
                ++counter2;
                size += f.Length;
            }
            if (counter1 == 0 && counter2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"dir : Cannot find elements with pattern '{pattern}' because it does not exist.");
                Console.ResetColor();
                return;
            }
            Console.WriteLine($"\t\t{counter2} files   {size} bytes");
            Console.WriteLine($"\t\t{counter1} directories");
        }
    }
}
