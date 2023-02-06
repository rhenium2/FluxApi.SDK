using Newtonsoft.Json;

namespace FluxApi.SDK;

 public class RawTransaction
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("overwintered")]
        public bool Overwintered { get; set; }

        [JsonProperty("versiongroupid")]
        public string Versiongroupid { get; set; }

        [JsonProperty("locktime")]
        public int Locktime { get; set; }

        [JsonProperty("expiryheight")]
        public int Expiryheight { get; set; }

        [JsonProperty("vin")]
        public List<Vin> Vin { get; set; }

        [JsonProperty("vout")]
        public List<Vout> Vout { get; set; }

        [JsonProperty("vJoinSplit")]
        public List<object> VJoinSplit { get; set; }

        [JsonProperty("valueBalance")]
        public int ValueBalance { get; set; }

        [JsonProperty("valueBalanceZat")]
        public int ValueBalanceZat { get; set; }

        [JsonProperty("vShieldedSpend")]
        public List<object> VShieldedSpend { get; set; }

        [JsonProperty("vShieldedOutput")]
        public List<object> VShieldedOutput { get; set; }

        [JsonProperty("blockhash")]
        public string Blockhash { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("blocktime")]
        public int Blocktime { get; set; }
    }

    public class ScriptPubKey
    {
        [JsonProperty("asm")]
        public string Asm { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("reqSigs")]
        public int ReqSigs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("addresses")]
        public List<string> Addresses { get; set; }
    }

    public class ScriptSig
    {
        [JsonProperty("asm")]
        public string Asm { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }
    }

    public class Vin
    {
        [JsonProperty("txid")]
        public string Txid { get; set; }

        [JsonProperty("vout")]
        public int Vout { get; set; }

        [JsonProperty("scriptSig")]
        public ScriptSig ScriptSig { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("valueSat")]
        public object ValueSat { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("sequence")]
        public object Sequence { get; set; }
    }

    public class Vout
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("valueZat")]
        public object ValueZat { get; set; }

        [JsonProperty("valueSat")]
        public object ValueSat { get; set; }

        [JsonProperty("n")]
        public int N { get; set; }

        [JsonProperty("scriptPubKey")]
        public ScriptPubKey ScriptPubKey { get; set; }

        [JsonProperty("spentTxId")]
        public string SpentTxId { get; set; }

        [JsonProperty("spentIndex")]
        public int SpentIndex { get; set; }

        [JsonProperty("spentHeight")]
        public int SpentHeight { get; set; }
    }

