using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HouseOvent.Business
{
    public class OventApiService
    {
        private HttpClient Client;
        public OventApiService()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            this.Client = new HttpClient();
            this.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "YWRtaW46N0RUdXk2VEs=");
            this.Client.BaseAddress = new Uri("http://192.168.1.24:8083");
        }

        private string ToApiRoute(string device,string commande) => $"ZAutomation/api/v1/devices/{device}/command/{commande}";

        private async Task GetAsync(string device, string commande = "on") => await this.Client.GetAsync(ToApiRoute(device, commande));

        public async Task AllumerLaLumiereDuSalonAsync() => await GetAsync("LightScene_12");

        public async Task EteindreLaLumiereDuSalonAsync() => await GetAsync("LightScene_17");

        public async Task AllumerLaLumiereDuPCAsync() => await GetAsync("ZWayVDev_zway_11-0-37");

        public async Task EteindreLaLumiereDuPCAsync() => await GetAsync("ZWayVDev_zway_11-0-37","off");

        public async Task AllumerLaLumiereTVAsync() => await GetAsync("ZWayVDev_zway_2-0-37");

        public async Task EteindreLaLumiereTVAsync() => await GetAsync("ZWayVDev_zway_2-0-37","off");

        public async Task OuvrirLesVoletsAsync() => await GetAsync("LightScene_14");

        public async Task FermerLesVoletsAsync() => await GetAsync("LightScene_19");

        public async Task OuvrirVoletPCAsync() => await GetAsync("ZWayVDev_zway_9-0-37");

        public async Task FermerVoletPCAsync() => await GetAsync("ZWayVDev_zway_9-0-37","off");

        public async Task OuvrirVoletTVAsync() => await GetAsync("ZWayVDev_zway_8-0-37");

        public async Task FermerVoletsTVAsync() => await GetAsync("ZWayVDev_zway_8-0-37", "off");

        public async Task FermeToutAsync() => await GetAsync("LightScene_15");

        public async Task AllumeEteinsLaMusique() => await GetAsync("BoseSoundTouchCommand_31");

        public async Task PlayPauseLaMusique() => await GetAsync("BoseSoundTouchCommand_32");

        public async Task SelectionneLePreset1() => await GetAsync("BoseSoundTouchCommand_34");

        public async Task SelectionneLePreset2() => await GetAsync("BoseSoundTouchCommand_35");

        public async Task SelectionneLePreset3() => await GetAsync("BoseSoundTouchCommand_36");

        public async Task SelectionneLePreset4() => await GetAsync("BoseSoundTouchCommand_37");

        public async Task SelectionneLePreset5() => await GetAsync("BoseSoundTouchCommand_38");

        public async Task SelectionneLePreset6() => await GetAsync("BoseSoundTouchCommand_39");

    }
}
