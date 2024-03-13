using Accessibility;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;

namespace Kreta.Desktop.ViewModels.Administration
{
    public partial class AdministrationViewModel : BaseViewModel
    {
        private EducationLevelViewModel _educationLevelViewModel=new ();
        private TypeOfEducationViewModel _typeOfEducationViewModel = new();


        [ObservableProperty]
        private BaseViewModel _currentAdministrationChildView;

        public AdministrationViewModel()
        {
            _currentAdministrationChildView = _educationLevelViewModel;
        }

        public AdministrationViewModel(
            EducationLevelViewModel educationLevelViewModel,
            TypeOfEducationViewModel typeOfEducationViewModel
            )
        {
            _educationLevelViewModel= educationLevelViewModel;
            _typeOfEducationViewModel= typeOfEducationViewModel;
            CurrentAdministrationChildView= _educationLevelViewModel;            
        }

        [RelayCommand]
        private void ShowEducationLevel()
        {
            CurrentAdministrationChildView = _educationLevelViewModel;
        }

        [RelayCommand]
        private void ShowTypeOfEducaton()
        {
            _typeOfEducationViewModel.InitializeAsync();
            CurrentAdministrationChildView = _typeOfEducationViewModel;
        }
    }
}
