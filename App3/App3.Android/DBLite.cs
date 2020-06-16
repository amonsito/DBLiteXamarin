using App3.DB;
using App3.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(DBLite))]
namespace App3.Droid
{
    public class DBLite : IDBLite
    {
        public string DatabasePath(string DatabaseName)
        {
            return
                Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), DatabaseName);

            //if (!File.Exists(path))
            //{
            //    File.Create(path).Dispose();
            //}

            //return path;
        }
    }
}