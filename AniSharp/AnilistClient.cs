using System.Threading.Tasks;
using AniSharp.Queries;
using AniSharp.Queries.Groups;
using AniSharp.Types;
using AniSharp.Types.Groups;
using CSGraphQL.Client;

using Anime = AniSharp.Results.Anime;
using Manga = AniSharp.Results.Manga;
using AnimePage = AniSharp.Results.Groups.AnimePage;
using MangaPage = AniSharp.Results.Groups.MangaPage;

namespace AniSharp
{
    public class AnilistClient
    {
        private static readonly GraphQlClient graphql = new GraphQlClient("https://graphql.anilist.co");

        public Anime GetAnime(int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaFormat? format = null, MediaStatus? status = null,
            int? episodes = null, int? duration = null, bool? isAdult = null, int? averageScore = null,
            int? popularity = null, MediaSource? source = null, string countryOfOrigin = null, string search = null,
            MediaSort? sort = null)
        {
            return GetAnimeAsync(id, endDate, startDate,
                season, seasonYear, format, status,
                episodes, duration, isAdult, averageScore,
                popularity, source, countryOfOrigin, search,
                sort).Result;
        }
        
        public async Task<Anime> GetAnimeAsync(int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaFormat? format = null, MediaStatus? status = null,
            int? episodes = null, int? duration = null, bool? isAdult = null, int? averageScore = null,
            int? popularity = null, MediaSource? source = null, string countryOfOrigin = null, string search = null,
            MediaSort? sort = null)
        {
            var query = new AnimeQuery
            {
                Id = id,
                EndDate = endDate,
                StartDate = startDate,
                Season = season,
                SeasonYear = seasonYear,
                Format = format,
                Status = status,
                Episodes = episodes,
                Duration = duration,
                IsAdult = isAdult,
                AverageScore = averageScore,
                Popularity = popularity,
                Source = source,
                CountryOfOrigin = countryOfOrigin,
                Search = search,
                Sort = sort,
            };

            var result = await graphql.PostAsync(query);
            return new Anime(result);
        }

        public AnimePage SearchAnime(int page, int perPage, int? id = null, int? endDate = null,
            int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaFormat? format = null, MediaStatus? status = null,
            int? episodes = null, int? duration = null, bool? isAdult = null, int? averageScore = null,
            int? popularity = null, MediaSource? source = null, string countryOfOrigin = null, string search = null,
            MediaSort? sort = null)
        {
            return SearchAnimeAsync(page, perPage, id, endDate, startDate,
                season, seasonYear, format, status,
                episodes, duration, isAdult, averageScore,
                popularity, source, countryOfOrigin, search,
                sort).Result;
        }

        public async Task<AnimePage> SearchAnimeAsync(int page, int perPage, int? id = null, int? endDate = null,
            int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaFormat? format = null, MediaStatus? status = null,
            int? episodes = null, int? duration = null, bool? isAdult = null, int? averageScore = null,
            int? popularity = null, MediaSource? source = null, string countryOfOrigin = null, string search = null,
            MediaSort? sort = null)
        {
            var query = new AnimePageQuery()
            {
                Page = page,
                PerPage = perPage,
                
                Id = id,
                EndDate = endDate,
                StartDate = startDate,
                Season = season,
                SeasonYear = seasonYear,
                Format = format,
                Status = status,
                Episodes = episodes,
                Duration = duration,
                IsAdult = isAdult,
                AverageScore = averageScore,
                Popularity = popularity,
                Source = source,
                CountryOfOrigin = countryOfOrigin,
                Search = search,
                Sort = sort,
            };

            var result = await graphql.PostAsync(query);
            return new AnimePage(result);
        }
        
        public Manga GetManga(int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaStatus? status = null,
            int? volumes = null, int? chapters = null, bool? isAdult = null, int? averageScore = null,
            int? popularity = null, MediaSource? source = null, string countryOfOrigin = null, string search = null,
            MediaSort? sort = null)
        {
            return GetMangaAsync(id, endDate, startDate,
                season, seasonYear, status,
                volumes, chapters, isAdult, averageScore,
                popularity, source, countryOfOrigin, search,
                sort).Result;
        }
        
        public async Task<Manga> GetMangaAsync(int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaStatus? status = null,
            int? volumes = null, int? chapters = null, bool? isAdult = null, int? averageScore = null,
            int? popularity = null, MediaSource? source = null, string countryOfOrigin = null, string search = null,
            MediaSort? sort = null)
        {
            var query = new MangaQuery()
            {
                Id = id,
                EndDate = endDate,
                StartDate = startDate,
                Season = season,
                SeasonYear = seasonYear,
                Status = status,
                Volumes = volumes,
                Chapters = chapters,
                IsAdult = isAdult,
                AverageScore = averageScore,
                Popularity = popularity,
                Source = source,
                CountryOfOrigin = countryOfOrigin,
                Search = search,
                Sort = sort,
            };

            var result = await graphql.PostAsync(query);
            return new Manga(result);
        }

        public MangaPage SearchManga(int page, int perPage, int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaStatus? status = null,
            int? volumes = null, int? chapters = null, bool? isAdult = null, int? averageScore = null,
            int? popularity = null, MediaSource? source = null, string countryOfOrigin = null, string search = null,
            MediaSort? sort = null)
        {
            return SearchMangaAsync(page, perPage, id, endDate, startDate,
                season, seasonYear, status,
                volumes, chapters, isAdult, averageScore,
                popularity, source, countryOfOrigin, search,
                sort).Result;
        }
        
        public async Task<MangaPage> SearchMangaAsync(int page, int perPage, int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaStatus? status = null,
            int? volumes = null, int? chapters = null, bool? isAdult = null, int? averageScore = null,
            int? popularity = null, MediaSource? source = null, string countryOfOrigin = null, string search = null,
            MediaSort? sort = null)
        {
            var query = new MangaPageQuery()
            {
                Page = page,
                PerPage = perPage,
                
                Id = id,
                EndDate = endDate,
                StartDate = startDate,
                Season = season,
                SeasonYear = seasonYear,
                Status = status,
                Volumes = volumes,
                Chapters = chapters,
                IsAdult = isAdult,
                AverageScore = averageScore,
                Popularity = popularity,
                Source = source,
                CountryOfOrigin = countryOfOrigin,
                Search = search,
                Sort = sort,
            };

            var result = await graphql.PostAsync(query);
            return new MangaPage(result);
        }
    }
}