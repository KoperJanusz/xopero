using System;
using System.Collections.Generic;
using System.Text;

namespace consoleappTALLGUY
{
    interface IScaryClown: IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
