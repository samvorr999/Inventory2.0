using Inventory.Core.Models;
using RestSharp;

namespace Inventory.Lib.Services;

public class RestService : IRepository
{

    private RestClient _client;

    public RestService(string apiBase)
    {
        var options = new RestClientOptions(apiBase)
        {
            ThrowOnAnyError = true,
            Timeout = new TimeSpan(0,0,60)


        };




        this._client = new RestClient(options);
        this._client.AddDefaultHeaders(new Dictionary<string, string>()
        {
            {KnownHeaders.ContentType, "application/json"},
            {KnownHeaders.Accept, "application/json"},
        });

        
    }



    public List<InventoryItem> Load()
    {
        var request = new RestRequest("/items", Method.Get);

        var result = this._client.Get<InventoryResponse>(request);

        System.Diagnostics.Debug.WriteLine(result);


        if (result.Success)
        { 
            return result.Items;
        }
        else
        {
            return new List<InventoryItem>();
        }
        /*
        return new List<InventoryItem>
        {
            new InventoryItem("INV123", "Baumann")
        }; 
        */
    }
}
