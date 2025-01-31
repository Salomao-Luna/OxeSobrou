using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OxeSobrou.Views.Pages;

namespace OxeSobrou.ViewModels
{
    public partial class SummaryViewModel : ObservableObject
    {
        [ObservableProperty]
        private View pageContent;

        private ContentPage _yearPage = new YearSummaryPage();
         
        private ContentPage _monthPage = new MonthSummaryPage();

        public SummaryViewModel()
        {
            pageContent = _yearPage.Content;
        }

        [RelayCommand]
        private void FirstButtonClicked()
        {
            pageContent = _yearPage.Content;
        }

        [RelayCommand]
        private void SecondButtonClicked()
        {
            pageContent = _monthPage.Content;
        }

     

    }
}
