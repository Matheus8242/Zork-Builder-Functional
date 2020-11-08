using System;
using System.Collections.Generic;
using System.Text;

namespace ZorkBuilder.Data
{
    public class GameWorld
    {
        public List<PlayerCharacter> Player { get; set; }
        public List<Item> Items { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
