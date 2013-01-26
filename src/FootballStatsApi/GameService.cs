using System.Collections.Generic;
using System.Linq;
using ServiceStack.CacheAccess;
using ServiceStack.OrmLite;

namespace FootballStatsApi
{
    public class GameService : ServiceStack.ServiceInterface.Service
    {
        public List<Games> Get(Games request)
        {
            var games = GetGames();

            var t = request.HomeTeam;
            if (!string.IsNullOrWhiteSpace(t))
                return games.Where(x => x.HomeTeam == t || x.AwayTeam == t).ToList();

            return games;
        }

        private List<Games> GetGames()
        {
            var cache = TryResolve<ICacheClient>();
            var games = cache.Get<List<Games>>("games");
            if (games != null)
                return games;

            games = Db.Select<Games>().Where(g => g.Division == "E0").ToList();
            cache.Set("games", games);
            return games;
        }
    }
}