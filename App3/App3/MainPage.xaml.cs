using App3.DB;
using App3.Model;
using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace App3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly DBLiteExample _db = new DBLiteExample();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            var newPerson = new PersonModel
            {
                Id=Guid.NewGuid().ToString(),
                Nombre = Name.Text,
                Edad= int.Parse(Edad.Text)
            };

            var lis=new ListModel
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = Name.Text,
            };

            _db.PersonModel.Insert(newPerson);
            _db.ListModel.Insert(lis);

            var a = _db.PersonModel.FindAll().ToList();
            var b = _db.ListModel.FindAll().ToList();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}

