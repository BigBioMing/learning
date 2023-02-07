namespace HttpClientDemo.HttpExtensions
{
    public class MyCustomTypeHttpClient : IMyCustomTypeHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<MyCustomTypeHttpClient> _logger;
        public MyCustomTypeHttpClient(HttpClient httpClient, ILogger<MyCustomTypeHttpClient> logger)
        {
            this._httpClient = httpClient;
            this._logger = logger;
        }

        public async Task<string> GetAsync()
        {
            var response = await _httpClient.GetAsync("/GetUser");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
