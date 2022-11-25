using System;
using System.Collections.Generic;
using System.Text;

namespace BudujemyDom
{
    class Outside: Location
    {
        private bool hot;
        public Outside(string name, bool hot)
       : base(name)
        {
            this.hot = hot;
        }
        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += " Tutaj jest bardzo goraco.";
            return NewDescription;
            }
        }
    }
}
