namespace HttpClientDemo.HttpExtensions
{
    public class RequestIdDelegatingHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("x-requestId", Guid.NewGuid().ToString("N"));
            return base.SendAsync(request, cancellationToken);
        }
    }
}
