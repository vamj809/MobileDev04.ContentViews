using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileDev04.ContentViews.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuElementView : StackLayout
    {
        public MenuElementView() {
            InitializeComponent();
        }
    }
}