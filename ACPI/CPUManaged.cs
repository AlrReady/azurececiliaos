using System;
using System.Collections.Generic;
using System.Text;

namespace AzureCecilia_OS
{
    class CPUManagedEx
    {
        public bool isCPUInpurruptsIsEnabled()
        {
            return Cosmos.Core.CPU.mInterruptsEnabled;
        }
        public long getCPUCycleSpeed()
        {
            return Cosmos.Core.CPU.GetCPUCycleSpeed();
        }
        public string getCPUVendorString()
        {
            return Cosmos.Core.CPU.GetCPUVendorName();
        }
    }
}
