using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using App3.DB;
using App3.iOS;
using Foundation;
using UIKit;
[assembly: Xamarin.Forms.Dependency(typeof(DBLite))]
namespace App3.iOS
{
    public class DBLite : IDBLite
    {
        public string DatabasePath(string DatabaseName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, DatabaseName);
        }
    }
}