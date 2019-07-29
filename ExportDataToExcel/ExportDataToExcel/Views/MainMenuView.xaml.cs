using ExportDataToExcel.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExportDataToExcel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuView : ContentPage
    {
        public MainMenuView()
        {
            InitializeComponent();
            BindingContext = new MainMenuViewModel();
            RegisterMesssages();
        }


        private void RegisterMesssages()
        {
            MessagingCenter.Subscribe<MainMenuViewModel>(this, "DataExportedSuccessfully", (senderViewModel) =>
            {
                if (senderViewModel != null)
                {
                    DisplayAlert("Info", "Data exported Successfully. The location is :"+ senderViewModel.FilePath, "OK");
                }
            });

            MessagingCenter.Subscribe<MainMenuViewModel>(this, "DataExportedPermissionDenied", (senderViewModel) =>
            {
                DisplayAlert("Info", "You have denied the write permission", "OK");
            });

            MessagingCenter.Subscribe<MainMenuViewModel>(this, "NoDataToExport", (senderViewModel) =>
            {
                DisplayAlert("Warning !", "No data to export.", "OK");
            });
        }
    }
}