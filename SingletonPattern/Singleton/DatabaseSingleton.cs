using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Singleton
{
    public class DatabaseSingleton
    {
        private DatabaseSingleton()
        { }

        private static DatabaseSingleton _instance;

        public static DatabaseSingleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new DatabaseSingleton();
            }
            return _instance;
        }

        public void QueryDatabase()
        {
            //query to db...
        }

    }
}
