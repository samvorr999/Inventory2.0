using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Inventory.Core.Models;
using Inventory.Lib.Services;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.ViewModels;

public partial class DashboardViewModel : ObservableObject
{


    [ObservableProperty]
    private ObservableCollection<InventoryItem> _items = new();

    private IRepository _repository;

    public DashboardViewModel(IRepository service)
    {
        this._repository = service;
    }



    [RelayCommand] 
    void Load()
    {
        this.Items.Clear();

        List<InventoryItem> items = _repository.Load();
    

         foreach(InventoryItem item in items)
         {

         }
    }
}
