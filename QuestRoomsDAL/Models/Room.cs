using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsDAL.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan PassingTime { get; set; }
        public int NumberPlayers { get; set; }
        public int YearPlayers { get; set; }
        public virtual Address Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual Company Company { get; set; }
        public int Rating { get; set; }
        public int LevelFear { get; set; }
        public int LevelDifficulty { get; set; }
        public string Logo { get; set; }
        public string Images { get; set; }

    }
}
