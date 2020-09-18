using System;
using System.Collections.Generic;
using System.Text;

namespace AzureCecilia_OS.ACPI
{

    class KeyboardManaged
    {
        public bool AltKeyPressed()
        {
            return Cosmos.System.KeyboardManager.AltPressed;
        }
        public bool CtrlKeyPressed()
        {
            return Cosmos.System.KeyboardManager.ControlPressed;
        }
        public bool NUMLOCKKeyIsLoocked()
        {
            return Cosmos.System.KeyboardManager.NumLock;
        }
        public bool ShiftKeyPressed()
        {
            return Cosmos.System.KeyboardManager.ShiftPressed;
        }
        public string GetKeyPressed()
        {
            Cosmos.System.KeyEvent k = Cosmos.System.KeyboardManager.ReadKey();
            Cosmos.System.ConsoleKeyEx ex = k.Key;
            switch (ex.ToString())
            {
                case "A":
                    {
                        return "A";
                    }
                case "B":
                    {
                        return "B";
                    }
                case "C":
                    {
                        return "C";
                    }
            }
            return "0";
        }
    }
}
