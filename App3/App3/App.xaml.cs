using App3.DB;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        //static LiteDBHelper db;
        //public static LiteDBHelper LiteDB
        //{
        //    get
        //    {
        //        if (db == null)
        //        {
        //            db = new LiteDBHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XamarinLiteDB.db"));
        //        }
        //        return db;
        //    }
        //}
    }
  
}
