using MyLibrary.DAL;

namespace ShoesAndHats.DAL
{
    public class Data
    {
        string connectionString = "server=WULKAN\\SA; initial catalog=ShoesAndHats; user id=SA; password=1234; TrustServerCertificate=Yes";


        private static Data _data;
        private DataLayer DataLayer;

        private Data()
        {
            DataLayer = new DataLayer(connectionString);
        }

        public static DataLayer Get
        {
            get
            {
                if (_data == null)
                {
                    _data = new Data();
                }
                return _data.DataLayer;               
            }
        }
    }
}
