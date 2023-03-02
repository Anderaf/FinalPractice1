using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPractice1
{
    public class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void Run()
        {
            if (_command != null)
            {
                _command.Run();
            }           
        }

        public void Cancel()
        {
            _command.Cancel();
        }
    }
}
