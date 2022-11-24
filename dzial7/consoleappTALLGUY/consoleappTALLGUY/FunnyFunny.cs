using System;
using System.Collections.Generic;
using System.Text;

namespace consoleappTALLGUY
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        protected string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "Czesc dzieciami mam " + funnyThingIHave; }
        }
        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
