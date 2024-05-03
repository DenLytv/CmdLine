using cmd;

try
{
    CmdLine cmdLine = new CmdLine();
    string str;
    string[] str1;
    Console.WriteLine("Microsoft Windows [Version 10.0.19045.3930]\n(c) Microsoft Corporation. All rights reserved.\n");
    while (true)
    {
        Console.Write($"{Directory.GetCurrentDirectory()}>");
        str = Console.ReadLine();
        if (str != null)
        {
            str1 = str.Split(' ');
            switch (str1[0])
            {
                case "md":
                    cmdLine.Md(str1[1]);
                    break;
                case "rd":
                    cmdLine.Rd(str1[1]);
                    break;
                case "cd":
                    cmdLine.Cd(str1[1]);
                    break;
                case "create":
                    cmdLine.Create(str1[1]);
                    break;
                case "type":
                    cmdLine.Type(str1[1]);
                    break;
                case "copy":
                    cmdLine.Copy(str1[1], str1[2]);
                    break;
                case "del":
                    cmdLine.Del(str1[1]);
                    break;
                case "append":
                    cmdLine.Append(str1[1]);
                    break;
                case "dir":
                    cmdLine.Dir(str1[1]);
                    break;
                case "exit":
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\"{str1[0]}\" is not internal or externalcommand, executable program, or batch file.");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ResetColor();
}
