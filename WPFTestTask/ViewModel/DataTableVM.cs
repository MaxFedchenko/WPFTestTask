using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Xpf.Grid;
using Microsoft.Win32;

using WPFTestTask.Model;
using WPFTestTask.Model.Services;

namespace WPFTestTask.ViewModel
{
    class DataTableVM : ViewModelBase
    {
        private readonly IFileDialogService fileDialogService;
        private readonly IPeopleService peopleService;

        public ObservableCollection<Person> People
        {
            get => GetValue<ObservableCollection<Person>>();
            private set => SetValue(value);
        }

        public DelegateCommand<TableView> ExportToCsvCmd { get; init; }
        public DelegateCommand<TableView> ExportToTxtCmd { get; init; }

        public DataTableVM(IPeopleService peopleService, IFileDialogService fileDialogService) 
        {
            this.peopleService = peopleService;
            this.fileDialogService = fileDialogService;

            ExportToCsvCmd = new DelegateCommand<TableView>(ExportToCsv);
            ExportToTxtCmd = new DelegateCommand<TableView>(ExportToTxt);

            People = peopleService.GetPeople();
        }

        private void ExportToCsv(TableView gridView)
        {
            string fileName = fileDialogService.OpenExportDialog("people", "csv");
            if (fileName != null)
                gridView.ExportToCsv(fileName);
        }
        private void ExportToTxt(TableView gridView)
        {
            string fileName = fileDialogService.OpenExportDialog("people", "txt");
            if (fileName != null)
                gridView.ExportToText(fileName);
        }
    }
}
