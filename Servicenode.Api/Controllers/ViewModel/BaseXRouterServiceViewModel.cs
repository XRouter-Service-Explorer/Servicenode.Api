using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Servicenode.Api.Controllers.ViewModels
{
    public class BaseXRouterServiceViewModel
    {
        public double Fee { get; set; }
        public int RequestLimit { get; set; }
        public int FetchLimit { get; set; }
        public string PaymentAddress { get; set; }
        public bool Disabled { get; set; }
    }
}