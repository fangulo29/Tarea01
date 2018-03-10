using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Tarea01.Models;

namespace Tarea01.ViewModels
{
    public class ClientViewModel
    {
        public ObservableCollection<Client> vloListaClientes { get; set; }

        public ClientViewModel()
        {
            vloListaClientes = new ObservableCollection<Client>();

            vloListaClientes.Add(new Client()
            {
                Name = "Juan Viquez",
                Age = 21,
                Gender = 'M'
            });
        }
    }
}
