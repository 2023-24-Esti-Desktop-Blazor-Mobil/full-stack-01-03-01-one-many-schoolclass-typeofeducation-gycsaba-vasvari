using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.SchoolClasses
{
    public partial class SchoolClassesManagmentViewModel : BaseViewModel
    {
        private ISchoolClassService? _schoolClassService;
        public string Title { get; set; } = "Osztályok kezelése";
        
        [ObservableProperty]
        private SchoolClass _selectedSchoolClass = new SchoolClass();

        [ObservableProperty]
        private ObservableCollection<SchoolClass> _schoolClasses = new ObservableCollection<SchoolClass>();

        public SchoolClassesManagmentViewModel()
        {            
        }
        public SchoolClassesManagmentViewModel(ISchoolClassService schoolClassService)
        {
            _schoolClassService = schoolClassService;
        }

        public override async Task InitializeAsync()        
        {
            await UpdateView();
            await base.InitializeAsync();
        }

        private async Task UpdateView()
        {
            if (_schoolClassService!=null)
            {
                List<SchoolClass> schoolClasses = await _schoolClassService.SelectAllAsync();
                SchoolClasses =new ObservableCollection<SchoolClass>(schoolClasses);
            }
        }
    }
}
