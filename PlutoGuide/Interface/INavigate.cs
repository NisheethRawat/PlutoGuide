using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlutoGuide
{
    public interface INavigate
    {
        bool EvaluateNavigation(char command);
    }
}
