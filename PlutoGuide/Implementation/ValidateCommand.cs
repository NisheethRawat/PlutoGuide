using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlutoGuide
{
    public class ValidateCommand : IValidateCommand
    {
        public void ValidateInputCommand(string command)
        {
            if (!command.ToUpper().All(e => "FBLR".Contains(e)))
                throw new Exception("Invalid Command Sequence");
        }
    }
}
