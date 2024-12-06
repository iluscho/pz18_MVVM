using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace pz18
{
    public class ClientViewModel : BaseViewModel
    {
        private ObservableCollection<Clients> _clients;
        private readonly bituchet2Entities _context;

        public ClientViewModel()
        {
            _context = new bituchet2Entities();
            LoadClientsCommand = new RelayCommand(LoadClients);
        }

        public ObservableCollection<Clients> Clients
        {
            get => _clients;
            set
            {
                _clients = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadClientsCommand { get; set; }

        private void LoadClients()
        {
            //Clients = new ObservableCollection<Clients>(_context.Clients.ToList());
            // Выводим информацию для отладки
            MessageBox.Show("Loading clients...");

            var clientsList = _context.Clients.ToList();

            // Проверка наличия данных
            if (clientsList.Count == 0)
            {
                MessageBox.Show("No clients found in the database.");
            }

            Clients = new ObservableCollection<Clients>(clientsList);
        }
    }
}
