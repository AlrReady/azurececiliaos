using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Sys = Cosmos.System;

namespace AzureCecilia_OS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine(BootConfigs.BOOT_SUCCESSFULY_MSG);
        }

        protected override void Run()
        {
            CommandExecutor ce = new CommandExecutor();
            Console.WriteLine("ACSh Ready.Type any key to start ACSh");
            Console.ReadKey();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ACSh Version: {0}",AboutConfigs.ACSH_VERSION);
                Console.Write(">>>");
                string command = Console.ReadLine();
                int isfirstmore = 0;
                if (command == "moredo" || isfirstmore != 0)
                {
                    MoreCommandExecutor m = new MoreCommandExecutor();
                    isfirstmore = 1;
                    m.Instance();
                }
                else
                {
                    string args = Console.ReadLine();
                    CommandExecutor.Run(command, args);
                    Console.ReadKey();
                }
            }
        }
    }
}
