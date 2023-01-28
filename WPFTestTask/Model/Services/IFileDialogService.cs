using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestTask.Model.Services
{
    interface IFileDialogService
    {
        string OpenExportDialog(string name, string ext);
    }
}
