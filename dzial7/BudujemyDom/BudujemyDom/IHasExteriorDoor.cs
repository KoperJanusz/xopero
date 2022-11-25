using System;
using System.Collections.Generic;
using System.Text;

namespace BudujemyDom
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
