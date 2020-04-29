using System;
using System.Collections.Generic;
using System.Text;

namespace Programmation_Evenementielle_Quete_2
{
    class StandardOutputLogger : OutPutLoggerAbstract
    {
        public override void Write(String message, DateTime? dateTime = null)
        {
            if (dateTime == null)
            {
                dateTime = DateTime.Now;
            }
            String formattedMessage = String.Format("{0} - {1}", dateTime, message);
            Console.WriteLine(formattedMessage);
        }
    }
}
