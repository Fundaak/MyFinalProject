﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCC
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
