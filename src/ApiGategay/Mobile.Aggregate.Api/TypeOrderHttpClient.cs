namespace Mobile.Aggregate.Api
{
    public class TypeOrderHttpClient : ITypeOrderHttpClient
    {
        private readonly HttpClient _httpClient;
        public TypeOrderHttpClient(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<string> GetOrder(string orderCode)
        {
            var response = await _httpClient.GetAsync($"/api/order?orderCode={orderCode}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
