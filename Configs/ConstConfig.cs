using System;
using System.Collections.Generic;
using System.Text;

namespace AzureCecilia_OS
{
    class AboutConfigs
    {
        public const string ACOS_VERSION = "20.09.01.23516(20sep09b0123516)";
        public const string ACOS_KERNEL = "20.09.01.23516";
        public const string ACOS_BUILD = "Version 20.1 Build 23516";
        public const string ACOS_AUTHOR = "Biscuitcube Studio";
        public const string ACSH_VERSION = "1.1.1";
        public const string ACSH_BUILD = "00600";
        public const string ACSH_KERNEL = "1.1.0";
        // HF=热更新,RL=发布版,BT=BETA,AL=ALPHA,DV=DEV,PB=PUBLISHED,同时可存在多个标签
        public const string ACOS_VERSION_TAG = "AL-DV-PB";
    }
    public class BootConfigs
    {
        public const string BOOT_SUCCESSFULY_MSG = "---------------------------\nAzureCecilia OS boot successfuly.\n---------------------------";
    }
}
