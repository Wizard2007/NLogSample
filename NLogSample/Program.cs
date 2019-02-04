using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NLogSample
{    
    // https://github.com/nlog/NLog/wiki/File-target   - clear logs 
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("test trace");
            logger.Debug("test debug");
        }
    }
}
