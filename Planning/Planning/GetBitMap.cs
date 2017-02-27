using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Planning
{
    public class GetBitMap
    {
        public static string Path =  Directory.GetCurrentDirectory();
    
        /// <summary>
        /// Set an image as priority for a task
        /// </summary>
        /// <param name="priorityindex"></param>
        /// <returns></returns>
        public static BitmapImage getPriority(string priorityindex)
        {
            try
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();

                bitmap.UriSource = new Uri(Path + @"\image\" + priorityindex + ".png");
                bitmap.EndInit();
                return bitmap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
