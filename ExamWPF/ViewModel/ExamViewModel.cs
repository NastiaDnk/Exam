using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Net.Http;
using System.Windows.Input;
using ExamWPF.Commands;
using ExamCommon.Models;
using Newtonsoft.Json;

namespace ExamWPF.ViewModel
{
    public class ExamViewModel : ViewModelBase
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
            var json = httpClient.GetStringAsync("https://localhost:5001/api/Client").Result;
            var list = JsonConvert.DeserializeObject<List<Client>>(json);
            Clients = new ObservableCollection<Client>(list);

            var json2 = httpClient.GetStringAsync("https://localhost:5001/api/Appointment").Result;
            var list2 = JsonConvert.DeserializeObject<List<Appointment>>(json2);
            Appointments = new ObservableCollection<Appointment>(list2);

            AddClient = new MyCommand(_ => AddClientMethod());
            DeleteClient = new MyCommand(_ => DeleteClientMethod());
            UpdateClient = new MyCommand(_ => UpdateClientMethod());
            AddAppointment = new MyCommand(_ => AddAppointmentMethod());
            DeleteAppointment = new MyCommand(_ => DeleteAppointmentMethod());
            UpdateAppointment = new MyCommand(_ => UpdateAppointmentMethod());
        }
        public ObservableCollection<Client> Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }
        public ObservableCollection<Appointment> Appointments
        {
            get { return _appointmants; }
            set { _appointmants = value; }
        }
        public Client CurrentClient
        {
            get { return _currentClient; }
            set { _currentClient = value; }
        }
        public Appointment CurrentAppointment
        {
            get { return _currentAppointment; }
            set { _currentAppointment = value; }
        }
        public ICommand DeleteClient
        {
            get { return _deleteClient; }
            set { _deleteClient = value; }
        }
        public ICommand AddClient
        {
            get { return _addClient; }
            set { _addClient = value; }
        }
        public ICommand UpdateClient
        {
            get { return _updateClient; }
            set { _updateClient = value; }
        }
        public ICommand DeleteAppointment
        {
            get { return _deleteAppointment; }
            set { _deleteAppointment = value; }
        }
        public ICommand AddAppointment
        {
            get { return _addAppointment; }
            set { _addAppointment = value; }
        }
        public ICommand UpdateAppointment
        {
            get { return _updateAppointment; }
            set { _updateAppointment = value; }
        }
        private void DeleteClientMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentClient),
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:5001/api/Client")
            };
            httpClient.SendAsync(request).Wait();
        }
        private void AddClientMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentClient),
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:5001/api/Client")
            };
            httpClient.SendAsync(request).Wait();
        }
        private void UpdateClientMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentClient),
                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:5001/api/Client")
            };
            httpClient.SendAsync(request).Wait();
        }

        private void DeleteAppointmentMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentAppointment),
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:5001/api/Appointment")
            };
            httpClient.SendAsync(request).Wait();
        }
        private void AddAppointmentMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentAppointment),
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:5001/api/Appointment")
            };
            httpClient.SendAsync(request).Wait();
        }
        private void UpdateAppointmentMethod()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = JsonContent.Create(CurrentAppointment),
                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:5001/api/Appointment")
            };
            httpClient.SendAsync(request).Wait();
        }
    }
}
