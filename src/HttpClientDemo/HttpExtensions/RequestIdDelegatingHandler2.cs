namespace HttpClientDemo.HttpExtensions
{
    public class RequestIdDelegatingHandler2 : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("x-requestId2", Guid.NewGuid().ToString("N"));
            return base.SendAsync(request, cancellationToken);
        }
    }
}
