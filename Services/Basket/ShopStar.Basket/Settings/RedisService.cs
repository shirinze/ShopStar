using StackExchange.Redis;

namespace ShopStar.Basket.Settings
{
    public class RedisService
    {
        private readonly string _host;
        private readonly int _port;

        //redise baglanmak icin kopru gorevi gorecek
        private ConnectionMultiplexer _connectionMultiplexer;

        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");
        public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(0);//burda redisisn 16 tane db getirdigi icin burda 0 db getirmesini istedim
    }
}
