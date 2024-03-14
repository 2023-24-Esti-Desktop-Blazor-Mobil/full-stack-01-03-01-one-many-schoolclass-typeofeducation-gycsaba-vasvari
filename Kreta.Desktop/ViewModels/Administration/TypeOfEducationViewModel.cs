using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.Administration
{
    public partial class TypeOfEducationViewModel : BaseViewModel
    {
        private readonly ITypeOfEducationService? _typeOfEducationService;

        [ObservableProperty]
        private string _title = "Szakmák";

        [ObservableProperty]
        private ObservableCollection<TypeOfEducation> _typeOfEducations = new ObservableCollection<TypeOfEducation>();
        [ObservableProperty]
        private TypeOfEducation _selectedTypeOfEducation=new();

        public TypeOfEducationViewModel()
        {                 
        }
        public TypeOfEducationViewModel(ITypeOfEducationService? typeOfEducationService)
        {
            _typeOfEducationService = typeOfEducationService;
        }

        public async override Task InitializeAsync()
        {
            await UpdateView();
            await base.InitializeAsync();
        }

        [RelayCommand]
        private void DoNewTypeOfEducation()
        {
            SelectedTypeOfEducation = new TypeOfEducation();
        }

        [RelayCommand]
        private async Task DoDelete(TypeOfEducation typeOfEducation)
        {
            if (_typeOfEducationService is not null && typeOfEducation.HasId)
            {
                ControllerResponse response = await _typeOfEducationService.DeleteAsync(typeOfEducation.Id);
                if (response.IsSuccess)
                    await UpdateView();
            }
        }

        [RelayCommand]
        private async Task DoSave(TypeOfEducation toSave)
        {
            if (_typeOfEducationService is not null)
            {
                ControllerResponse response;
                if (toSave.HasId)
                    response = await _typeOfEducationService.UpdateAsync(toSave);
                else
                    response = await _typeOfEducationService.InsertAsync(toSave);
                if (response.IsSuccess)
                    await UpdateView();
            }
        }
        private async Task UpdateView()
        {
            if (_typeOfEducationService is not null)
            {
                List<TypeOfEducation> typeOfEducations = await _typeOfEducationService.SelectAllAsync();
                TypeOfEducations = new ObservableCollection<TypeOfEducation>(typeOfEducations);
            }
        }
    }
}
