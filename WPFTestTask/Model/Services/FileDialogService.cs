using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestTask.Model.Services
{
    class FileDialogService : IFileDialogService
    {
        public string OpenExportDialog(string name, string ext)
        {
            var dlg = new SaveFileDialog();
            dlg.FileName = name;
            dlg.DefaultExt = $".{ext}";
            dlg.Filter = $"{ext.ToUpper()} documents (.{ext})|*.{ext}";

            if (dlg.ShowDialog() == true)
                return dlg.FileName;
            return null;
        }
    }
}
