using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotes.UWP
{
    class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            string path = global::Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            return System.IO.Path.Combine(path, filename);
            // Local: /urs/var/appNotes/data.bd
        }
    }
}
