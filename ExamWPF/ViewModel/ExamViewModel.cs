using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ExamWPF.Commands;
using ExamCommon.Models;
using Newtonsoft.Json;

namespace ExamWPF.ViewModel
{
    public class ExamViewModel:ViewModelBase
    {
        private ObservableCollection<Client> _clients;
        private Client _currentClient;
        private ICommand _deleteClient;
        private ICommand _addClient;
        private ICommand _updateClient;


        private ObservableCollection<Appointment> _appointmants;
        private Appointment _currentAppointment;
        private ICommand _deleteAppointment;
        private ICommand _addAppointment;
        private ICommand _updateAppointment;

        private HttpClient httpClient = new HttpClient();
        public ExamViewModel()
        {
            var json = httpClient.GetStringAsync("https://localhost:44335/api/").Result;
            var list = JsonConvert.DeserializeObject<List<Client>>(json);
            Clients = new ObservableCollection<Client>(list);
            AddClient = new MyCommand(_ => AddClientMethod());
        }
        public ObservableCollection<Client> Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }
        public Client CurrentItem
        {
            get { return _currentClient; }
            set { _currentClient = value; }
        }
        public ICommand DeleteItem
        {
            get
            {
                _deleteClient ??= new MyCommand(_ => DeleteClientMethod());
                return _deleteClient;
            }
        }
        public ICommand AddClient
        {
            get
            {
                return _addClient;
            }
            set { _addClient = value; }
        }
        public ICommand UpdateItem
        {
            get
            {
                _updateClient ??= new MyCommand(_ => UpdateClientMethod());
                return _updateClient;
            }
        }
        private void DeleteClientMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentItem),
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:5001/api/", UriKind.Relative)
            };
            httpClient.SendAsync(request).Wait();
        }
        private void AddClientMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentItem),
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:5001/api/", UriKind.Relative)
            };
            httpClient.SendAsync(request).Wait();
        }
        private void UpdateClientMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentItem),
                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:5001/api/", UriKind.Relative)
            };
            httpClient.SendAsync(request).Wait();
        }
    }
}
