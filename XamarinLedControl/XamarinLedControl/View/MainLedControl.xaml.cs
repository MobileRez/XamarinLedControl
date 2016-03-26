using Xamarin.Forms;
using XamarinLedControl.ViewModel;

namespace XamarinLedControl.View
{
    public partial class MainLedControl : ContentPage
    {
        public MainLedControl()
        {
            InitializeComponent();
            BindingContext = new LedControlViewModel();
        }
    }
}
