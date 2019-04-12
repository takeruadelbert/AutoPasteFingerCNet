using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This is Takeru's Helper
 * Built and Developed by Takeru T.K. 
 * Email : takeruadelbert@gmail.com
 */
namespace AutoPasteFingerCNet.src.Helper
{
    class TKHelper
    {
        public string GetCurrentDatetime()
        {
            return DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID")) + " " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
