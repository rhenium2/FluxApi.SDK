using Newtonsoft.Json;

namespace FluxApi.SDK;

public static class FluxApiService
{
    public static async Task<TransactionHistory[]> GetTransactionHistories(string accountId)
    {
        using var client = new FluxApiClient();
        Response httpResponse;
        TransactionHistory[] response;
        try
        {
            httpResponse = await client.Get($"/explorer/transactions?address={accountId}");
            response = JsonConvert.DeserializeObject<TransactionHistory[]>(httpResponse.Data);
        }
        catch (Exception e)
        {
            throw e;
        }

        return response;
    }
    
    public static async Task<RawTransaction> GetRawTransaction(string transactionId)
    {
        using var client = new FluxApiClient();
        Response httpResponse;
        RawTransaction response;
        try
        {
            httpResponse = await client.Get($"/daemon/getrawtransaction?txid={transactionId}&verbose=1");
            response = JsonConvert.DeserializeObject<RawTransaction>(httpResponse.Data);
        }
        catch (Exception e)
        {
            throw e;
        }

        return response;
    }
    
    public static async Task<RawTransaction[]> GetAccountRawTransactions(string accountId)
    {
        var transactionHistories = await GetTransactionHistories(accountId);
        var result = new List<RawTransaction>();
        foreach (var transactionHistory in transactionHistories)
        {
            var t = await GetRawTransaction(transactionHistory.Txid);
            result.Add(t);
        }

        return result.ToArray();
    }
}