using Inventory.Core.ViewModels;

namespace Inventory.Gui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage(DashboardViewModels vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
        }

       
    }

}
