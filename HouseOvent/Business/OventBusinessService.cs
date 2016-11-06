using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOvent.Business
{
    public class OventBusinessService
    {
        private OventApiService ApiService = new OventApiService();

        public async Task HandleCommandAsync(string command,string obj,string room)
        {
            switch (obj)
            {
                case "light": await HandleLights(command,room); break;
                case "volet": await HandleStores(command,room); break;
            }
        }
        private async Task HandleLights(string command, string room)
        {
            switch (command)
            {
                case "open": await HandleLightOnAsync(room); break;
                case "close": await HandleLightOffAsync(room); break;
            }
        }

        private async Task HandleStores(string command, string room)
        {
            switch (command)
            {
                case "open": await HandleStoreUpAsync(room); break;
                case "close": await HandleStoreDownAsync(room); break;
            }
        }

        private async Task HandleLightOnAsync(string room)
        {
            switch (room)
            {
                case "salon": await ApiService.AllumerLaLumiereDuSalonAsync(); break;
                case "PC": await ApiService.AllumerLaLumiereDuPCAsync(); break;
                case "TV": await ApiService.AllumerLaLumiereTVAsync(); break;
            }
        }

        private async Task HandleLightOffAsync(string room)
        {
            switch (room)
            {
                case "salon": await ApiService.EteindreLaLumiereDuSalonAsync(); break;
                case "PC": await ApiService.EteindreLaLumiereDuPCAsync(); break;
                case "TV": await ApiService.EteindreLaLumiereTVAsync(); break;
            }
        }

        private async Task HandleStoreUpAsync(string room)
        {
            switch (room)
            {
                case "salon": await ApiService.OuvrirLesVoletsAsync(); break;
                case "PC": await ApiService.OuvrirVoletPCAsync(); break;
                case "TV": await ApiService.OuvrirVoletTVAsync(); break;
            }
        }

        private async Task HandleStoreDownAsync(string room)
        {
            switch (room)
            {
                case "salon": await ApiService.FermerLesVoletsAsync(); break;
                case "PC": await ApiService.FermerVoletPCAsync(); break;
                case "TV": await ApiService.FermerVoletsTVAsync(); break;
            }
        }
    }
}
