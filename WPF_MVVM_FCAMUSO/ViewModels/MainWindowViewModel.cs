using System.Collections.Generic;
using System.ComponentModel;

namespace WPF_MVVM_FCAMUSO.ViewModels
{
    public  class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly Models.IPersoneService _personeService = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel(Models.IPersoneService personeService)
        {
            _personeService = personeService;
        }


        public IList<Models.Persona> Persone => _personeService.Persone;

        private string _textSaluto;

        public string TextSaluto
        {
            get { return _textSaluto; }
            set
            {
                _textSaluto = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TextSaluto)));
            }
        }


        public Models.Persona PersonaSelezionata { get; set; }

       

        public void Saluta() {

            TextSaluto = $"Ciao {PersonaSelezionata.Nome} {PersonaSelezionata.Cognome}!";
        }

    }
}
