using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SoccerStatsTH
{

    public class RootObject
    {
        public Player[] Players { get; set; }
    }

    public class Player
    {
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "points_per_game")]
        public string pointsPerGame { get; set; }
        [JsonProperty(PropertyName = "second_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "team_name")]
        public string TeamName { get; set; }
    }

}
