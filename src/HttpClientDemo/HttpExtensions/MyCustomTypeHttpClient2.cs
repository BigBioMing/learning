namespace HttpClientDemo.HttpExtensions
{
    public class MyCustomTypeHttpClient2 : IMyCustomTypeHttpClient2
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<MyCustomTypeHttpClient2> _logger;
        public MyCustomTypeHttpClient2(HttpClient httpClient, ILogger<MyCustomTypeHttpClient2> logger)
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
