using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Servicenode.Api.Controllers.ViewModels
{
    public class ServiceResultViewModel
    {
        public NodeInfoViewModel Node { get; set; }
        public List<NodeInfoViewModel> OtherNodes { get; set; }
    }
    
}