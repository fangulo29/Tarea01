using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea01.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea01.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClientsView : ContentPage
	{
        public ObservableCollection<Client> vloListaClientes { get; set; }

        public ClientsView ()
		{
			InitializeComponent ();
            vloListaClientes = new ObservableCollection<Client>();

            vloListaClientes.Add(new Client(){ Name = "Juan", Age = 21, Gender = 'M' });
            vloListaClientes.Add(new Client(){ Name = "Pedro", Age = 32, Gender = 'M' });
            vloListaClientes.Add(new Client() { Name = "Samuel", Age = 27, Gender = 'F' });
            vloListaClientes.Add(new Client() { Name = "Fernando", Age = 22, Gender = 'F' });
            vloListaClientes.Add(new Client() { Name = "Sofia", Age = 26, Gender = 'F' });
            vloListaClientes.Add(new Client() { Name = "Rodolfo", Age = 32, Gender = 'F' });

            vloListaClientes.Add(new Client(){ Name = "Jimena", Age = 20, Gender = 'F' });
            vloListaClientes.Add(new Client() { Name = "Ema", Age = 16, Gender = 'F' });
            vloListaClientes.Add(new Client() { Name = "Paola", Age = 18, Gender = 'F' });
            
            
            
            vloListaClientes.Add(new Client() { Name = "Daniel", Age = 19, Gender = 'F' });
            vloListaClientes.Add(new Client() { Name = "Johan", Age = 12, Gender = 'F' });
            

            ListView vloFilterByAge = new ListView();
            vloFilterByAge.ItemsSource = vloListaClientes.Where(cliente => cliente.Age >= 21);

            vloFilterByAge.ItemTemplate = new DataTemplate(typeof(TextCell));
            vloFilterByAge.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");

            //----------------------------------------------------------------------------
            ListView vloFilterByName = new ListView();
            vloFilterByName.ItemsSource = vloListaClientes.Where(cliente => cliente.Name.StartsWith("S"));

            vloFilterByName.ItemTemplate = new DataTemplate(typeof(TextCell));
            vloFilterByName.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");

            //----------------------------------------------------------------------------
            ListView vloFilterByGender = new ListView();
            vloFilterByGender.ItemsSource = vloListaClientes.Where(cliente => cliente.Gender == 'F');

            vloFilterByGender.ItemTemplate = new DataTemplate(typeof(TextCell));
            vloFilterByGender.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");

            Content = new StackLayout
            {
                Children = {
                    vloFilterByAge,
                    vloFilterByName,
                    vloFilterByGender
                }
            };
        }
	}
}