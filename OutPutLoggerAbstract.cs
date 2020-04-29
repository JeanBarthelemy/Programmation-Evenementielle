using System;
using System.Collections.Generic;
using System.Text;

namespace Programmation_Evenementielle_Quete_2
{
    class OutPutLoggerAbstract
    {
        public void Subscribe(Program program)
        {
            program.OnSendLog += HandleLogSend;
        }

        public void HandleLogSend(object sender, SendLogEventArgs args)
        {
            // When OnLogSent is called, it writes a log on the stream
            Write(args.Message, args.DateTime);
        }

        public virtual void Write(String message, DateTime? dateTime = null)
        {
        }
    }
}
