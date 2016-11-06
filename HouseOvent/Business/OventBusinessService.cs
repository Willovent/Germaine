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

        public async Task HandleLightStoreAsync(string command,string obj,string room)
        {
            switch (obj)
            {
                case "light": await HandleLights(command,room); break;
                case "volet": await HandleStores(command,room); break;
            }
        }

        public async Task PowerMusique() => await ApiService.AllumeEteinsLaMusique();
        
        public async Task HandlePlaylist(int playlistNumber)
        {
            switch (playlistNumber)
            {
                case 1: await ApiService.SelectionneLePreset1(); break;
                case 2: await ApiService.SelectionneLePreset2(); break;
                case 3: await ApiService.SelectionneLePreset3(); break;
                case 4: await ApiService.SelectionneLePreset4(); break;
                case 5: await ApiService.SelectionneLePreset5(); break;
                case 6: await ApiService.SelectionneLePreset6(); break;
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
