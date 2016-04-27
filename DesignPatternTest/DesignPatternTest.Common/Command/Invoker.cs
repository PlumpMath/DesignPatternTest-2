﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            this.command.Execute();
        }
    }


}
