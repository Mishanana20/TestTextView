using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestTextView.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Вкладка Браузера Микрокотроллера для передачи файла";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://192.168.0.10"));
        }

        public ICommand OpenWebCommand { get; }
    }
}