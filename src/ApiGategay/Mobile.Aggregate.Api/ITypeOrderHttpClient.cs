namespace Mobile.Aggregate.Api
{
    public interface ITypeOrderHttpClient
    {
        Task<string> GetOrder(string orderCode);
    }
}
