using System;
using System.Collections.Generic;
using System.IO;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.proxy
{
    class ProxyClass:IDemoProxy
    {
        private IDemoProxy _real;
        private string _logFile;

        public ProxyClass(string logfile)
        {
            _real = new RealProxy();
            _logFile = logfile;
        }


        public void InsertString(string str)
        {
            _real.InsertString(str);
            LogMessage(str);
        }

        

        public List<string> GetAll()
        {
            return _real.GetAll();
        }
        private void LogMessage(string str)
        {
            using (StreamWriter sw = File.AppendText(_logFile))
            {
                sw.WriteLine($"({DateTime.Now.ToString()}) {str}");
                sw.Flush();
            }
        }
    }
}
