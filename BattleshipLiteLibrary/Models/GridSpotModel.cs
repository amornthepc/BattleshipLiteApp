using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; init; }
        public int SpotNumber { get; init; }
        public GridSpotStatus Status { get; set; }
    }
}
