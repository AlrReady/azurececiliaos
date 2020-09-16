using Cosmos.Core;
using Cosmos.System.Network.IPv4;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureCecilia_OS
{
    class DEBUG_CommandExecutorInstance
    {
        public bool DEBUG_NET_SetConfig(Address addr,Address submask,Address gateway)
        {
            Cosmos.System.Network.IPv4.Config c = new Config(addr, submask, gateway);
            return true;
        }
        public string DEBUG_NET_GETOEMSTRING()
        {
            
            return "1";
        }
    }
    class CommandExecutorInstance
    {
        /// <summary>
        /// 频率:32~32767Hz
        /// </summary>
        /// <param name="freq">频率</param>
        public void Beep(UInt32 freq)
        {
            if (freq < 32 || freq > 32767)
            {
                Console.WriteLine("CEI.Beep(freq) call failed.");
            }
            Cosmos.System.PCSpeaker.Beep(freq);
        }
        public void Print(string args)
        {
            Console.WriteLine(Convert.ToString(args));
        }
        public void Clear()
        {
            Console.Clear();
        }
        public void About()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("About AzureCecilia Operation System");
            Console.WriteLine("Version:{0}", AboutConfigs.ACOS_VERSION);
            Console.WriteLine("Kernel Version:{0}", AboutConfigs.ACOS_KERNEL);
            Console.WriteLine("Build:{0}", AboutConfigs.ACOS_BUILD);
            Console.WriteLine("Version Tag:{0}", AboutConfigs.ACOS_VERSION_TAG);
            Console.WriteLine("ACSh Version:{0};Build: {1}", AboutConfigs.ACSH_VERSION, AboutConfigs.ACSH_BUILD);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Copyright (c) 2017-2020 Biscuitcube Studio");
            Console.WriteLine("Copyright (c) Person Yuan Daiqi");
            Console.WriteLine("All rights reserved.");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("This operation system used GPL v2 and Anti-996 license.License of files:");
            Console.WriteLine("------------------------LIST-OF-PROGRAMS---------------------------------");
            Console.WriteLine("isolinux(syslinux) - GPLv2 - https://github.com/geneC/syslinux");
            Console.WriteLine("CosmosOS           - BSD-3 - https://github.com/CosmosOS/Cosmos");
            Console.WriteLine("AzureCeciliaOS     - Multi-License - https://github.com/StarMoon123/azurececiliaos");
            Console.WriteLine("-------------------------------------------------------------------------");
        }
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
    }
    class CommandExecutor
    {
        public static void Run(string command, string args)
        {
            CommandExecutorInstance c = new CommandExecutorInstance();
            CPUManagedEx cpu = new CPUManagedEx();
            switch (command)
            {
                case "print":
                    {
                        c.Print(args);
                        break;
                    }
                case "clear":
                    {
                        c.Clear();
                        break;
                    }
                case "about":
                    {
                        c.About();
                        break;
                    }
                case "reboot":
                    {
                        // 请勿使用ACPI
                        Cosmos.System.Power.Reboot();
                        break;
                    }
                case "powerdown":
                    {
                        Cosmos.System.Power.Shutdown();
                        break;
                    }
                case "debug":
                    {
                        break;
                    }
                case "beep":
                    {
                        c.Beep(Convert.ToUInt32(args));
                        break;
                    }
                case "cpu::vendorname":
                    {
                        Console.WriteLine(cpu.getCPUVendorString());break;

                    }
                case "cpu::cyclespeed":
                    {
                        Console.WriteLine(cpu.getCPUCycleSpeed().ToString());break;
                    }
            }
        }
    }
}
