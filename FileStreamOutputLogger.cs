using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Programmation_Evenementielle_Quete_2
{
    class FileStreamOutputLogger : OutPutLoggerAbstract
    {
        public override void Write(String message, DateTime? dateTime = null)
        {
            if (dateTime == null)
            {
                dateTime = DateTime.Now;
            }
            String formattedMessage = String.Format("{0} - {1}", dateTime, message);
            List<string> formattedMessageList = new List<string> { formattedMessage };
            string path = @"./Log.txt";
            File.AppendAllLines(path, formattedMessageList);
        }
    }
}