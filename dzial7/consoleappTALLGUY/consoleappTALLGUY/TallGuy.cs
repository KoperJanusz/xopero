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
        static void Main(string[] args)
        {
            TallGuy tallguy = new TallGuy() { Height = 74, Name = "Adam" };
            tallguy.TalkAboutYourself();
            Console.WriteLine(tallguy.FunnyThingIHave);
            tallguy.Honk();
        
        }
        public string FunnyThingIHave
        {
            get { return "duze buty"; }
        }
        public void Honk()
        {
            Console.WriteLine("tut tuut!");
        }

    }
}
