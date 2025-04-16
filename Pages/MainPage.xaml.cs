using BuyAndSellTrading.Models;
using BuyAndSellTrading.PageModels;

namespace BuyAndSellTrading.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}