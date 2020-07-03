using HamburguerConMvvm.Base;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace HamburguerConMvvm.ViewModels
{
    public class CustomDialogPinContent
    {
        private string _pin;
        private string _pinconfirmation;

        public CustomDialogPinContent(Action<CustomDialogPinContent> closeHandler)
        {
            CloseCommand = new RelayCommand(o => closeHandler(this));
        }

        public string Pin
        {
            get => _pin;
            set
            {
                _pin = value;
                RaisePropertyChanged(nameof(Pin));
            }
        }

        public string PinCOnfirmation
        {
            get => _pinconfirmation;
            set
            {
                _pinconfirmation = value;
                RaisePropertyChanged(nameof(PinCOnfirmation));
            }
        }

        public ICommand CloseCommand { get; }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        #endregion
    }
}
