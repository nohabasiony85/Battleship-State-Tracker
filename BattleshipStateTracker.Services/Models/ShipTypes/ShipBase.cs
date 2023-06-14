using System.Collections.Generic;
using System.Linq;
using BattleshipStateTracker.Services.Models.Enums;

namespace BattleshipStateTracker.Services.Models.ShipTypes
{
    public abstract class ShipBase
    {
        /// <summary>
        /// Gets or Sets Cells
        /// </summary>
        public List<GridCell> Cells { get; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        public int Length { get; set; }

        protected ShipBase()
        {
            Cells = new List<GridCell>();
        }

        /// <summary>
        /// Gets IsSunk
        /// </summary>
        public bool IsSunk
        {
            get
            {
                return Cells.All(c => c.Status == Occupation.Hit);
            }
        }
    }
}
