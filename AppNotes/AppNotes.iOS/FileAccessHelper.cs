using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace AppNotes.iOS
{
    class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = System.IO.Path.Combine(docFolder, "..", "Library"); //criando pasta para o DataBase
            if (!System.IO.Directory.Exists(libFolder))
            {
                System.IO.Directory.CreateDirectory(libFolder);
            }

            return System.IO.Path.Combine(libFolder, filename);
            // Local: /urs/var/appNotes/data.bd
        }
    }
}