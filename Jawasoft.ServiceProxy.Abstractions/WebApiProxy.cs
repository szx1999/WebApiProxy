namespace Jawasoft.ServiceProxy.Abstractions
{
    public class WebApiProxy:IWebApiProxy
    {
        protected WebApiProxy(string baseUrl)
        {
            this.BaseUrl = baseUrl;
        }

        public string BaseUrl { get; set; }
    }
}
