using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Lib.Services
{
    public interface IRepository
    {
        List<InventoryItem> Load();




    }
}
