using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Models
{
    public class InventoryResponse
    {
        public bool Success { get; set; }

        public List<InventoryItem> Items { get; set; } = new ();

    }
}
