using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_7
{
    class ExternalCommand : CommandBase
    {
        private readonly Action<object> execute; 
        private readonly Func<object, bool> canExecute;

        public override void Execute(object parameter) => execute(parameter);

        public ExternalCommand(Action<object> execute)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(Execute));
        }
    }
}
