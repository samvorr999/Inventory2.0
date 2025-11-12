using CommunityToolkit.Mvvm.ComponentModel;
using Inventory.Core.Models;
using Inventory.Lib.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.ViewModels;

public class DashboardViewModels : ObservableObject
{


    [ObservableProperty]
    private ObservableCollection<InventoryItem> _items = new();

    private IRepository _repository;

    public DashboardViewModels(IRepository service)
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
