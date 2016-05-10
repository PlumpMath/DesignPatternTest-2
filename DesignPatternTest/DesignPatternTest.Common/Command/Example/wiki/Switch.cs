using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    /// <summary>Invoker</summary>
    public class Switch
    {
        private ICommand _closeCommand;

        private ICommand _openCommand;

        public Switch(ICommand closeCommand, ICommand openCommand)
        {
            this._closeCommand = closeCommand;
            this._openCommand = openCommand;
        }

        public void Close()
        {
            this._closeCommand.Execute();
        }

        public void Open()
        {
            this._openCommand.Execute();
        }
    }
}
