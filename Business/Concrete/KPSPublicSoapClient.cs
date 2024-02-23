
namespace Business.Concrete
{
    internal class KPSPublicSoapClient
    {
        public KPSPublicSoapClient(object kPSPublicSoap)
        {
        }

        public static object EndpointConfiguration { get; internal set; }

        internal object TCKimlikNoDogrulaAsync(TCKimlikNoDogrulaRequest tCKimlikNoDogrulaRequest)
        {
            throw new NotImplementedException();
        }
    }
}