using MobileDev04.ContentViews.Models;
using System.Collections.ObjectModel;

namespace MobileDev04.ContentViews.ViewModels
{
    public class MainMenuViewModel : BaseViewModel
    {
        public MenuOption SelectedMenuOption { get; set; }
        public ObservableCollection<MenuOption> DiscoveryMenuOptions { get; }
        public MainMenuViewModel() {
            DiscoveryMenuOptions = new ObservableCollection<MenuOption>() {
                new MenuOption("BarIcon", "Bars & Hotels", "42 Places"),
                new MenuOption("DinerIcon", "Fine Dining", "15 Places"),
                new MenuOption("CafeIcon", "Cafes", "28 Places"),
                new MenuOption("NearbyIcon", "Nearby", "34 Places"),
                new MenuOption("FastFoodIcon", "Fast Foods", "29 Places"),
                new MenuOption("PizzaIcon", "Featured Foods", "21 Places")
            };
        }
    }
}
