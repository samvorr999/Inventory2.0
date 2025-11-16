using Inventory.Core.ViewModels;

namespace Inventory.Gui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage(DashboardViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
        }

       
    }

}
