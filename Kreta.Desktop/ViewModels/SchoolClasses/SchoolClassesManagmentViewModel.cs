using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.SchoolClasses
{
    public partial class SchoolClassesManagmentViewModel : BaseViewModel
    {
        private ISchoolClassService? _schoolClassService;
        private ITypeOfEducationService? _typeOfEducationService;
        public string Title { get; set; } = "Osztályok kezelése";

        [ObservableProperty]
        private SchoolClass _selectedSchoolClass = new SchoolClass();

        [ObservableProperty]
        private ObservableCollection<SchoolClass> _schoolClasses = new ObservableCollection<SchoolClass>();

        [ObservableProperty]
        private ObservableCollection<TypeOfEducation> _typeOfEducations = new();

        public SchoolClassesManagmentViewModel()
        {
        }
        public SchoolClassesManagmentViewModel(
            ISchoolClassService schoolClassService,
            ITypeOfEducationService? typeOfEducationService)
        {
            _schoolClassService = schoolClassService;
            _typeOfEducationService = typeOfEducationService;
        }

        public override async Task InitializeAsync()
        {
            await UpdateView();
            await base.InitializeAsync();
        }

        [RelayCommand]
        private void New()
        {
            SelectedSchoolClass = new();
        }

        [RelayCommand]
        private async Task Delete(SchoolClass schoolClassToDelete)
        {
            if (_schoolClassService is not null)
            {
                ControllerResponse response = await _schoolClassService.DeleteAsync(schoolClassToDelete.Id);
                if (response.IsSuccess)
                    await UpdateView();
            }
        }


        [RelayCommand]
        private async Task Save(SchoolClass schoolClassToSave)
        {
            if (_schoolClassService != null)
            {
                ControllerResponse response = new ControllerResponse();
                if (schoolClassToSave.HasId)
                {
                    response=await _schoolClassService.UpdateAsync(schoolClassToSave);
                }
                else
                {
                    response = await _schoolClassService.InsertAsync(schoolClassToSave);
                }
                if (response.IsSuccess)
                {
                    await UpdateView();
                }
            }
        }
        private async Task UpdateView()
        {
            if (_schoolClassService!=null)
            {
                List<SchoolClass> schoolClasses = await _schoolClassService.SelectAllIncludedAsync();
                SchoolClasses =new ObservableCollection<SchoolClass>(schoolClasses);
            }

            if (_typeOfEducationService is not null)
            {
                List<TypeOfEducation> typeOfEducations = await _typeOfEducationService.SelectAllAsync();
                TypeOfEducations = new ObservableCollection<TypeOfEducation>(typeOfEducations);
            }
        }
    }
}
