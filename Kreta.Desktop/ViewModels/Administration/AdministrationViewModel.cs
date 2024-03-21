using Accessibility;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.Administration
{
    public partial class AdministrationViewModel : BaseViewModel
    {
        private EducationLevelViewModel? _educationLevelViewModel;
        private TypeOfEducationViewModel? _typeOfEducationViewModel;

        [ObservableProperty]
        private BaseViewModel _currentAdministrationChildView;

        public AdministrationViewModel()
        {
            if (_educationLevelViewModel is not null)
                CurrentAdministrationChildView = _educationLevelViewModel;
            else
                CurrentAdministrationChildView = new TypeOfEducationViewModel();
        }

        public AdministrationViewModel(
            EducationLevelViewModel? educationLevelViewModel,
            TypeOfEducationViewModel? typeOfEducationViewModel
            )
        {
            _educationLevelViewModel= educationLevelViewModel;
            _typeOfEducationViewModel= typeOfEducationViewModel;
            if (_educationLevelViewModel is not null)
                CurrentAdministrationChildView = _educationLevelViewModel;
            else
                CurrentAdministrationChildView = new TypeOfEducationViewModel();
        }

        [RelayCommand]
        private void ShowEducationLevel()
        {
            if (_educationLevelViewModel is not null)
                CurrentAdministrationChildView = _educationLevelViewModel;
        }

        [RelayCommand]
        private async Task ShowTypeOfEducaton()
        {
            if (_typeOfEducationViewModel is not null)
            {
                await _typeOfEducationViewModel.InitializeAsync();
                CurrentAdministrationChildView = _typeOfEducationViewModel;
            }
        }
    }
}
