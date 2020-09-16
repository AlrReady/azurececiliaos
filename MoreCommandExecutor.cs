using System;
using System.Collections.Generic;
using System.Text;

namespace AzureCecilia_OS
{
    class MoreCommandExecutor
    {
        public void Run(string[] lines)
        {
            CommandExecutor c = new CommandExecutor();
            string[] ji_lines = new string[int.MaxValue]; // 奇行,指令
            string[] ou_lines = new string[int.MaxValue]; // 偶行,参数
            for (int i = 0;i <= lines.Length;i++)
            {
                if (i % 2 == 0)
                {
                    ou_lines[i] = lines[i];
                }
                else
                {
                    ji_lines[i] = lines[i];
                }
            }
            for (int j = 0;j <= ji_lines.Length;j++)
            {
                CommandExecutor.Run(ji_lines[j], ou_lines[j]);
            }
        }
        public void Instance()
        {
            Console.Write("Lines of MORE>>");
            string line = Console.ReadLine();
            string[] lines = new string[int.MaxValue];
            for (int i = 0;i <= Convert.ToInt32(line);i++)
            {
                string l = Console.ReadLine();
                lines[i] = l;
            }
            Run(lines);
        }
    }
}
