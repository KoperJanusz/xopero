using System;

namespace consoleappTALLGUY
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("Nazywam sie " + Name + " I mam " + Height + " centymetrow wzrostu");
        }
        public string FunnyThingIHave
        {
            get { return "duze buty"; }
        }
        public void Honk()
        {
            Console.WriteLine("tut tuut!");
        }
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("duze buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadKey();

        
        }
       

    }
}
