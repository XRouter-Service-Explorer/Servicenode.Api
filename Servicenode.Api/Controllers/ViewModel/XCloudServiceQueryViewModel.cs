using System.Collections.Generic;
using Blocknet.Lib.RPC.RequestResponse;
using Newtonsoft.Json;

namespace Servicenode.Api.Controllers.ViewModels
{
    public class XCloudServiceQueryViewModel : QueryViewModel
    {
        public string NodePubKey{ get; set; }
        
    }

}
