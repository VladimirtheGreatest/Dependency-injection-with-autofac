using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        //class level private variables
        ILogger _logger;
        IDataAccess _dataAccess;

        //constructor   this is called constructor injection
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            //Logger logger = new Logger();
            //DataAccess dataAccess = new DataAccess();

            string User = "Vladimir";

            _logger.Log(User);
            Console.WriteLine("Processing the data");
            _dataAccess.SaveData($"{User}");
        }
    }
}
