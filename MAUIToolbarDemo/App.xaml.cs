namespace MAUIToolbarDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //shell
            MainPage = new AppShell();
            
            //no shell
            //MainPage = new NavigationPage(new MainPage());
        }
    }
}
