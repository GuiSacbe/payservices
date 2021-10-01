using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using payservices.response;
using payservices.Util;
using System.Linq;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using payservices.Request;

namespace payservices.ViewModels
{
    public class PayServicePageViewModel : BaseViewModel
    {
        private ArcusClient<List<ProviderResponse>> arcusClient;
        private List<Saldo> saldo;
        private ProviderResponse selectProvider = new ProviderResponse();
        private ObservableCollection<ProviderResponse> items = new ObservableCollection<ProviderResponse>();
        private ServiceProviderPaymentRequest serviceProviderPaymentRequest = new ServiceProviderPaymentRequest();
        private Saldo currentSaldo = new Saldo();

        public ObservableCollection<ProviderResponse> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }

        public ProviderResponse SelectProvider
        {
            get => selectProvider;
            set { selectProvider = value; OnPropertyChanged(); }
        }

        public ServiceProviderPaymentRequest ServiceProviderRequest
        {
            get => serviceProviderPaymentRequest;
            set
            {
                serviceProviderPaymentRequest = value;
                OnPropertyChanged();
            }
        }

        public List<Saldo> Saldos
        {
            get => saldo;
            set
            {
                saldo = value;
                OnPropertyChanged();
            }
        }

        public Saldo CurrentSaldo
        {
            get => currentSaldo;
            set
            {
                currentSaldo = value;
                OnPropertyChanged();
            }
        }

        public Command payCommand { get; }

        public PayServicePageViewModel()
        {
            LoadProviders();
            payCommand = new Command(async () =>
            {
                var client = new ArcusClient<ServiceProviderPaymentResponse>();
                serviceProviderPaymentRequest.accountId = 6073;
                serviceProviderPaymentRequest.providerId = selectProvider.providerId;
                serviceProviderPaymentRequest.paymentCurrency = "MXN";
                var result = await client.PostAsync(serviceProviderPaymentRequest, EndPoint.serviceProviderPayent);
            });

            saldo = new List<Saldo>();
            saldo.Add(new Saldo("$20.00", 20));
            saldo.Add(new Saldo("$30.00", 30));
            saldo.Add(new Saldo("$50.00", 50));
            saldo.Add(new Saldo("$100.00", 100));
            saldo.Add(new Saldo("$200.00", 200));
        }

        public async Task LoadProviders()
        {
            try
            {
                arcusClient = new ArcusClient<List<ProviderResponse>>();
                var list = await arcusClient.GetAsync(EndPoint.provider);
                foreach(var row in list)
                {
                    items.Add(row);
                }
            }
            catch(Exception e)
            {
                string message = e.Message;
            }
            
        }
    }
}
