using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;

namespace Kreta.Desktop.ViewModels.Administration
{
    public partial class TypeOfEducationViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string _title = "Szakmák";
    }
}
