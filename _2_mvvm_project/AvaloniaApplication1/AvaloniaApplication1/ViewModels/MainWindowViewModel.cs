using AvaloniaApplication1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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
        }
    }
}
