using System;
using System.Collections.Generic;
using System.Text;

namespace Programmation_Evenementielle_Quete_2
{
    class SendLogEventArgs : EventArgs
    {
        public String Message;
        public DateTime DateTime;

        public SendLogEventArgs(String message, DateTime dateTime)
        {
            Message = message;
            DateTime = dateTime;
        }
    }
}
