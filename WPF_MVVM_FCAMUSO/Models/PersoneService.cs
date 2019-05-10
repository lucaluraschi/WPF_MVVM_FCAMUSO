using System.Collections.Generic;

namespace WPF_MVVM_FCAMUSO.Models
{
    public interface IPersoneService
    {
        IList<Persona> Persone { get; }
    }

     class PersoneService : IPersoneService
    {
        private  List<Persona> _persone = null;
        public PersoneService()
        {
            _persone = new List<Persona>
            {
                new Persona() { Nome = "Luca", Cognome = "Luraschi" },
                new Persona() { Nome = "Mario", Cognome = "Marchetti" },
                new Persona() { Nome = "Barbara", Cognome = "Cavalli" },
                new Persona() { Nome = "Beatrice", Cognome = "Bianchi" },
                new Persona() { Nome = "Roberto", Cognome = "Valtorta" },
                new Persona() { Nome = "Adriano", Cognome = "Pappalardo" },
                new Persona() { Nome = "Marco", Cognome = "Muliere" },
                new Persona() { Nome = "Daniele", Cognome = "Albertini" }
            };

        }



        public IList<Persona> Persone => _persone;
    }

}

