using System.IO;
using ExportDataToExcel.Droid;
using ExportDataToExcel.Interfaces;
using Java.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExportFilesToLocation))]
namespace ExportDataToExcel.Droid
{
    public class ExportFilesToLocation : IExportFilesToLocation
    {
        public string GetFolderLocation()
        {
            string root;
            root = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            if (Android.OS.Environment.IsExternalStorageEmulated)
            {
                root = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads);
            }

            bool folderExists = Directory.Exists(root);
            if (!folderExists)
                Directory.CreateDirectory(root);

            return root + "/";
        }
    }
}