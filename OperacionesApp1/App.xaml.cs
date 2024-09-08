using OperacionesApp1.Tabbed;

namespace OperacionesApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage1();
        }
    }
}   
