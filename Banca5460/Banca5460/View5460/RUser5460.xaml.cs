using Banca5460.ViewModel5460;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Banca5460.View5460
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RUser5460 : ContentPage
    {
        public RUser5460()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel5460();
        }
    }
}