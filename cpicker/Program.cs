using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cpicker
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Color inputColor = new Color();

            try
            {
                inputColor = ColorTranslator.FromHtml(args[0]);
            }
            catch
            {
                // http://i.imgur.com/T8c7dYY.jpg
            }

            System.Windows.Forms.ColorDialog colorDialog1 = new System.Windows.Forms.ColorDialog();
            
            colorDialog1.CustomColors = new int[] { ColorTranslator.ToOle(inputColor) };
            colorDialog1.Color = inputColor;
            colorDialog1.ShowDialog();
            Console.WriteLine("#" + string.Format("0x{0:X8}", colorDialog1.Color.ToArgb()).Substring(4, 6));
        }
    }
}
