using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPasteFingerCNet.src.FingerprintDevice;

namespace AutoPasteFingerCNet
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Device device = new Device();
            while (!Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                } else
                {
                    device = new Device();
                }
            }
        }
    }
}
