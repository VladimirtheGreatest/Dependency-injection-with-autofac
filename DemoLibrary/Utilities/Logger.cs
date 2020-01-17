using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utilities
{
    public class Logger : ILogger
    {

        IDataAccess _dataAccess;

        public Logger(IDataAccess dataAccess )
        {
            _dataAccess = dataAccess;
        }
        public void Log(string message)
        {
            Console.WriteLine($"Logging in as { message }");
            _dataAccess.LoadData();
        }
    }
}
