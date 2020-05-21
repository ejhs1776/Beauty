

namespace beauty
{
    using beauty.Views;
    using Xamarin.Forms;

    public partial class App : Application
    {
        #region constructors

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new LoginPage());
        }

        #endregion


    }
        
    }

