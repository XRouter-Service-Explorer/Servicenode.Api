using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Servicenode.Api.Controllers.ViewModels
{
    public class SpvConfigViewModel
    {
        public string SpvWallet { get; set; }
        public List<SpvCommandViewModel> Commands { get; set; }

        
    }
}