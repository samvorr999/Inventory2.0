using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inventory.Core.Models
{
    public partial class InventoryItem : ObservableObject
    {
     
        long _id = 0;


        [JsonPropertyName("title")]
        string Title = string.Empty;

        

        [JsonPropertyName("inventory_number")]
        public string InventoryNoumber { get; set; }

        public InventoryItem(string inventoryNumber, string title)
        {
         
            this.InventoryNumber = inventoryNumber;
            this.Title = title;
            
        }
    }
}
