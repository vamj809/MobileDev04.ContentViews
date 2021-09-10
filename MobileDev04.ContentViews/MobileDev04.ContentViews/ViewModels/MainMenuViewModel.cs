using MobileDev04.ContentViews.Models;
using System.Collections.ObjectModel;

namespace MobileDev04.ContentViews.ViewModels
{
    public class MainMenuViewModel : BaseViewModel
    {
        public MenuOption SelectedMenuOption { get; set; }
        public ObservableCollection<MenuOption> DiscoveryMenuOptions { get; }
        public MenuOption BarsMenuOption { get; }
        public MenuOption DinersMenuOption { get; }
        public MenuOption CafesMenuOption { get; }
        public MenuOption NearbyMenuOption { get; }
        public MenuOption FastFoodsMenuOption { get; }
        public MenuOption FeaturedFoodsMenuOption { get; }
        public MainMenuViewModel() {
            DiscoveryMenuOptions = new ObservableCollection<MenuOption>() {
                new MenuOption("BarIcon", "Bars & Hotels", "42 Places"),
                new MenuOption("DinerIcon", "Fine Dining", "15 Places"),
                new MenuOption("CafeIcon", "Cafes", "28 Places"),
                new MenuOption("NearbyIcon", "Nearby", "34 Places"),
                new MenuOption("FastFoodIcon", "Fast Foods", "29 Places"),
                new MenuOption("PizzaIcon", "Featured Foods", "21 Places")
            };
            BarsMenuOption = new MenuOption("BarIcon", "Bars & Hotels", "42 Places");
            DinersMenuOption = new MenuOption("DinerIcon", "Fine Dining", "15 Places");
            CafesMenuOption = new MenuOption("CafeIcon", "Cafes", "28 Places");
            NearbyMenuOption = new MenuOption("NearbyIcon", "Nearby", "34 Places");
            FastFoodsMenuOption = new MenuOption("FastFoodIcon", "Fast Foods", "29 Places");
            FeaturedFoodsMenuOption = new MenuOption("PizzaIcon", "Featured Foods", "21 Places");
        }
    }
}
