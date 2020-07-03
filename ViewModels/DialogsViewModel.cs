using HamburguerConMvvm.Base;
using HamburguerConMvvm.Views;
using MahApps.Metro.Controls.Dialogs;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HamburguerConMvvm.ViewModels
{
    public class DialogsViewModel : PropertyChangedViewModel
    {
        private string _InputResult;
        public string InputResult
        {
            get => _InputResult;
            set
            {
                _InputResult = value;
                RaisePropertyChanged(nameof(InputResult));
            }
        }

        private string _CustomResult;
        public string CustomResult
        {
            get => _CustomResult;
            set
            {
                _CustomResult = value;
                RaisePropertyChanged(nameof(CustomResult));
            }
        }

        public AsyncCommand ShowMessageDialogCmd { get; }
        public AsyncCommand ShowInputDialogCmd { get; }
        public AsyncCommand ShowCustomDialogCmd { get; }

        public DialogsViewModel()
        {
            ShowMessageDialogCmd = new AsyncCommand(ShowMessageDialogAsync);

            ShowInputDialogCmd = new AsyncCommand(ShowInputDialogAsync);

            ShowCustomDialogCmd = new AsyncCommand(ShowCustomDialogAsync);
        }

        public async Task ShowMessageDialogAsync()
        {
            await DialogCoordinator.Instance.ShowMessageAsync(this, "Message dialog", "Hello! This is a message Dialog!", MessageDialogStyle.Affirmative);
        }

        public async Task ShowInputDialogAsync()
        {
            InputResult = "Waiting 2seg to show the dialog...";

            await Task.Delay(2000);

            InputResult = "Showing the dialog...";

            string result = await DialogCoordinator.Instance.ShowInputAsync(this, "Hello!", "What is your name?");

            if (result == null) //user pressed cancel
            {
                InputResult = "Dialog canceled!!";
                return;
            }

            InputResult = result;
        }

        public async Task ShowCustomDialogAsync()
        {
            CustomResult = "Waiting 2seg to show the custom dialog...";

            await Task.Delay(2000);

            CustomResult = "Showing the dialog...";

            await RunCustomFromVm();

            await Task.Delay(1000);
            
            CustomResult = "This message should not have appeared...";

            await Task.Delay(1000);

            CustomResult = "Long process finished";
        }
        private async Task RunCustomFromVm()
        {
            var customDialog = new CustomDialog() { Title = "Custom Dialog" };

            var dataContext = new CustomDialogPinContent(instance =>
            {
                DialogCoordinator.Instance.HideMetroDialogAsync(this, customDialog);
                Debug.WriteLine(instance.Pin);
            });
            customDialog.Content = new CustomDialogPin { DataContext = dataContext };

            await DialogCoordinator.Instance.ShowMetroDialogAsync(this, customDialog);
        }
    }
}
