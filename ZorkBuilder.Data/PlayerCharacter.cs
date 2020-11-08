using System.Collections.Generic;

namespace ZorkBuilder.Data
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Score { get; set; }

        public List<Item> Inventory { get; set; }
    }
}
