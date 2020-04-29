using System;

namespace Programmation_Evenementielle_Quete_2
{
    class Program
    {
        public event EventHandler<SendLogEventArgs> OnSendLog;

        static void Main(string[] args)
        {
            var program = new Program();
            var logger = new StandardOutputLogger();
            var fileStreamLogger = new FileStreamOutputLogger();

            logger.Subscribe(program);
            fileStreamLogger.Subscribe(program);

            var eventArgs = new SendLogEventArgs("LogEvent published", DateTime.Now);
            var eventArgs2 = new SendLogEventArgs("Log succeeded", DateTime.Now);

            if (program.OnSendLog != null)
            {
                program.OnSendLog(program, eventArgs);
                program.OnSendLog(program, eventArgs2);
            }
        }
    }
}
