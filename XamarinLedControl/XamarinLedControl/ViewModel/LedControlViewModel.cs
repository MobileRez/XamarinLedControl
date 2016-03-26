using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinLedControl.ViewModel
{
    public class LedControlViewModel
    {
        public ICommand ChangeLedCommand { get; set; }

        public LedControlViewModel()
        {
            ChangeLedCommand = new Command<string>(ChangeLed);
        }

        public void ChangeLed(string changeValue)
        {
            string accessToken = ""; //This is your Particle Cloud Access Token
            string deviceId = ""; //This is your Particle Device Id
            string partilceFunc = "ledcolor"; //This is the name of your Particle Function

            HttpClient client = new HttpClient
            {
                BaseAddress =
                new Uri("https://api.particle.io/")
            };

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("access_token", accessToken),
                new KeyValuePair<string, string>("args", changeValue )
            });

            var result = client.PostAsync("v1/devices/" + deviceId + "/" + partilceFunc, content).Result;
        }
    }
}
