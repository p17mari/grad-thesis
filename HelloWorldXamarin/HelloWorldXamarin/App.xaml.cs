using HelloWorldXamarin.Services;
using HelloWorldXamarin;
using HelloWorldXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;


//namespace HelloWorldXamarin { 
namespace  Teacher //HelloWorldXamarin
{
    public partial class App : Application
    {
       /* private static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "teachers.db3"));
                }
                return database;
            }
        }*/
        public App()
        {
           InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException(); // this method is not in default
        }
        
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
//}