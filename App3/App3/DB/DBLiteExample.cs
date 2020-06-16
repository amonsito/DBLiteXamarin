using App3.Model;
using LiteDB;
using Xamarin.Forms;

namespace App3.DB
{
    public class DBLiteExample
    {
        private LiteDatabase _dataBase;
        public DBLiteExample() {

            var DatabaseName = Properties.Resources.DatabaseName;
            _dataBase = new LiteDatabase(DependencyService.Get<IDBLite>().DatabasePath(DatabaseName));

            ListModel = _dataBase.GetCollection<ListModel>();
            PersonModel = _dataBase.GetCollection<PersonModel>();

        }
        public LiteCollection<ListModel> ListModel;
        public LiteCollection<PersonModel> PersonModel;
    }
}
