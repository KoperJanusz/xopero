using System;
using System.Collections.Generic;
using System.Text;

namespace BudujemyDom
{
    class RoomWithDoor: Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription)
        : base(name, decoration)
        {
            DoorDescription = doorDescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
    }
}
