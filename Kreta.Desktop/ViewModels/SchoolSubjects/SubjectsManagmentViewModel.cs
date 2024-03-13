using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.SchoolSubjects
{
    public partial class SubjectsManagmentViewModel : BaseViewModel
    {
        public string Title { get; set; } = "Tantárgyak kezelése";

        private ISubjectService? _subjectService { get; set; }

        [ObservableProperty]
        private Subject _selectedSubject= new Subject();

        [ObservableProperty]
        private ObservableCollection<Subject> _subjects= new ObservableCollection<Subject>();

        public SubjectsManagmentViewModel()
        {
        }

        public SubjectsManagmentViewModel(ISubjectService subjectService)
        {                 
            _subjectService = subjectService;
        }

        public override async Task InitializeAsync()
        {
            await UpdateView();
            await base.InitializeAsync();
        }

        private async Task UpdateView()
        {
            if (_subjectService!= null)
            {
                List<Subject> subjects= await _subjectService.SelectAllAsync();
                Subjects= new ObservableCollection<Subject>(subjects);
            }
        }
    }
}
