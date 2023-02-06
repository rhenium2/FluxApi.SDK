using Newtonsoft.Json;

namespace FluxApi.SDK;

public class TransactionHistory
{
    [JsonProperty("txid")]
    public string Txid { get; set; }
}