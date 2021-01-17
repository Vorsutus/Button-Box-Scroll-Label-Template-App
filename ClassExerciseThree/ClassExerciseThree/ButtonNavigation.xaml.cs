using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using InClass2;

namespace ClassExerciseThree
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonNavigation : ContentPage
    {
        public ButtonNavigation()
        {
            InitializeComponent();
        }

        private void Label_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LabelDemo());
        }

        private void BoxView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BoxViewDemo());
        }

        private void ScrollView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollViewDemo());
        }
    }
}