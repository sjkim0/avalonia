using AvaloniaApplication1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AvaloniaApplication1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        /*
         * @ brief : readonly로 선언하여 model을 한번만 인스턴스화 하도록한다.
         */
        private readonly MyModel _model;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private ObservableCollection<string> items;

        [RelayCommand]
        private void buttonClicked()
        {
            _model.Name = "ModelName";

            Name = _model.BussinessLogicReturn();
        }

        public MainWindowViewModel()
        {
            _model = new MyModel();

            Name = "ViewModelName";
            Items = new ObservableCollection<string>{"item 0", "item 1"};
        }
    }
}
