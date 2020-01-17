using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificarMVVM
{
    class MainWindowVM : INotifyPropertyChanged
    {
        Tema_6Entities contexto;
        public ObservableCollection<CLIENTES> clientesCollection { get; set; }
        public CLIENTES cliente { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowVM()
        {
            contexto = new Tema_6Entities();
            contexto.CLIENTES.Load();
            clientesCollection = contexto.CLIENTES.Local;
        }

        public bool PuedeEjecutar()
        {
            return cliente != null;
        }

        public void Ejecutar()
        {
            contexto.SaveChanges();
        }
    }
}
