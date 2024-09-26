using Microsoft.Extensions.Caching.Distributed;
using RedisCache.Entities;
using RedisCache.Interfaces;
using System.Text.Json;

namespace RedisCache.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redisCache;

        public BasketRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

        public async Task<ShoppingCart> GetBasket(string userName)
        {
            var getBasket = await _redisCache.GetStringAsync(userName);

            if (string.IsNullOrEmpty(getBasket))
                return null;

            return JsonSerializer.Deserialize<ShoppingCart>(getBasket);
        }

        public async Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            await _redisCache.SetStringAsync(basket.UserName, JsonSerializer.Serialize(basket));

            return await GetBasket(basket.UserName);
        }

        public async Task DeleteBasket(string userName)
        {
            await _redisCache.RemoveAsync(userName);
        }
    }
}
