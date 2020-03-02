using AniSharp.Queries.SimpleQueries;
using AniSharp.Client.Account;
using System.Threading.Tasks;
using AniSharp.Queries.Base;
using AniSharp.Types.Media;
using AniSharp.Results;
using CSGraphQL;
using System;
using System.Collections.Generic;
using AniSharp.Mutations.SimpleMutations;
using AniSharp.Queries.AdvancedQueries;
using AniSharp.Queries.Base.Media;
using AniSharp.Queries.Base.Users;
using AniSharp.Types.Misc;
using AniSharp.Types.Users;
using CSGraphQL.Extensions;
using Media = AniSharp.Results.Media;

namespace AniSharp.Client
{
    public class AnilistClient
    {
        private static readonly GraphQlClient graphql = new GraphQlClient("https://graphql.anilist.co");

        private KeyValuePair<string, string>[] Headers => 
            _loginCredentials.HasValue ? new[] {_loginCredentials.Value.AccessHeader} : null;
        
        #region Queries

        public T GetMedia<T>(MediaQuery query)
            where T : Media => GetMediaAsync<T>(query).Result;
        public async Task<T> GetMediaAsync<T>(MediaQuery query)
            where T : Media => await graphql.PostAsync<T>(query, Headers);

        public T GetAnime<T>(AnimeQuery query)
            where T : Anime => GetAnimeAsync<T>(query).Result;
        public async Task<T> GetAnimeAsync<T>(AnimeQuery query)
            where T : Anime => await GetMediaAsync<T>(query);

        public T GetManga<T>(MangaQuery query)
                    where T : Manga => GetMangaAsync<T>(query).Result;
        public async Task<T> GetMangaAsync<T>(MangaQuery query)
            where T : Manga => await GetMediaAsync<T>(query);

        public Anime GetAnime(int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaFormat? format = null,
            MediaStatus? status = null, int? episodes = null, int? duration = null, bool? isAdult = null, string genre = null, string tag = null,
            int? minimumTagRank = null, string tagCategory = null, bool? onList = null, string licensedBy = null,
            int? averageScore = null, int? popularity = null, MediaSource? source = null,
            string countryOfOrigin = null, string search = null, MediaSort? sort = null)
        {
            return GetAnimeAsync(id, endDate, startDate, season, seasonYear, format, status, episodes, duration,
                isAdult, genre, tag, minimumTagRank, tagCategory, onList, licensedBy, averageScore, popularity, source,
                countryOfOrigin, search, sort).Result;
        }
        
        public async Task<Anime> GetAnimeAsync(int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaFormat? format = null,
            MediaStatus? status = null, int? episodes = null, int? duration = null, bool? isAdult = null, string genre = null, string tag = null,
            int? minimumTagRank = null, string tagCategory = null, bool? onList = null, string licensedBy = null,
            int? averageScore = null, int? popularity = null, MediaSource? source = null,
            string countryOfOrigin = null, string search = null, MediaSort? sort = null)
        {
            return await GetAnimeAsync<Anime>(new SimpleAnimeQuery
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
                Genre = genre,
                Tag = tag,
                MinimumTagRank = minimumTagRank,
                TagCategory = tagCategory,
                OnList = onList,
                LicensedBy = licensedBy,
                AverageScore = averageScore,
                Popularity = popularity,
                Source = source,
                CountryOfOrigin = countryOfOrigin,
                Search = search,
                Sort = sort,
            });
        }
        
        public Manga GetManga(int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaFormat? format = null,
            MediaStatus? status = null, int? chapters = null, int? volumes = null, bool? isAdult = null, string genre = null, string tag = null,
            int? minimumTagRank = null, string tagCategory = null, bool? onList = null, string licensedBy = null,
            int? averageScore = null, int? popularity = null, MediaSource? source = null,
            string countryOfOrigin = null, string search = null, MediaSort? sort = null)
        {
            return GetMangaAsync(id, endDate, startDate, season, seasonYear, format, status, chapters, volumes,
                isAdult, genre, tag, minimumTagRank, tagCategory, onList, licensedBy, averageScore, popularity, source,
                countryOfOrigin, search, sort).Result;
        }
        
        public async Task<Manga> GetMangaAsync(int? id = null, int? endDate = null, int? startDate = null,
            MediaSeason? season = null, int? seasonYear = null, MediaFormat? format = null,
            MediaStatus? status = null, int? chapters = null, int? volumes = null, bool? isAdult = null, string genre = null, string tag = null,
            int? minimumTagRank = null, string tagCategory = null, bool? onList = null, string licensedBy = null,
            int? averageScore = null, int? popularity = null, MediaSource? source = null,
            string countryOfOrigin = null, string search = null, MediaSort? sort = null)
        {
            return await GetMangaAsync<Manga>(new SimpleMangaQuery
            {
                Id = id,
                EndDate = endDate,
                StartDate = startDate,
                Season = season,
                SeasonYear = seasonYear,
                Format = format,
                Status = status,
                Chapters = chapters,
                Volumes = volumes,
                IsAdult = isAdult,
                Genre = genre,
                Tag = tag,
                MinimumTagRank = minimumTagRank,
                TagCategory = tagCategory,
                OnList = onList,
                LicensedBy = licensedBy,
                AverageScore = averageScore,
                Popularity = popularity,
                Source = source,
                CountryOfOrigin = countryOfOrigin,
                Search = search,
                Sort = sort,
            });
        }

        public T GetUser<T>(UserQuery query) where T : User => GetUserAsync<T>(query).Result;
        public async Task<T> GetUserAsync<T>(UserQuery query) where T : User => await graphql.PostAsync<T>(query, Headers);
        public User GetUser(int? id = null, string name = null, string search = null, UserSort? sort = null) 
            => GetUserAsync(id, name, search, sort).Result;
        public async Task<User> GetUserAsync(int? id = null, string name = null, string search = null, UserSort? sort = null)
        {
            return await GetUserAsync<User>(new SimpleUserQuery
            {
                Id = id,
                Name = name,
                Search = search,
                Sort = sort,
            });
        }

        #endregion

        #region AccountManagement

        public User User => _user ?? throw new InvalidOperationException("You must login first");
        private AccessToken? _loginCredentials;
        private User _user;

        public void Login(AccessToken token)
        {
            _loginCredentials = token;
            _user = GetUser<User>(new ViewerQuery());
        }
        public void Login(AccessTokenProvider provider) => Login(provider.GetAccessToken());
        public void Login(int clientId, string token) => Login(new AccessToken(clientId, token));
        public void Login<T>(int clientId) where T : AccessTokenProvider 
            => Login(Activator.CreateInstance(typeof(T), clientId) as AccessTokenProvider);

        public void DeleteMediaListEntry(int mediaId)
        {
            var result = graphql.Post<MediaList>(new SimpleSaveMediaListEntryMutation(mediaId), Headers);
            graphql.PostToJson(new SimpleDeleteMediaListEntryMutation(result.Id), Headers);
        }

        public void EditMediaListEntry(int mediaId, MediaListStatus? status = null, float? score = null,
            int? scoreRaw = null, int? progress = null, int? progressVolumes = null, int? repeat = null,
            int? priority = null, bool? @private = null, string notes = null, bool? hiddenFromStatusLists = null,
            string[] customLists = null, float[] advancedScores = null, Date startedAt = null, Date completedAt = null)
        {
            graphql.PostToJson(new SimpleSaveMediaListEntryMutation(mediaId)
            {
                AdvancedScores = advancedScores,
                CompletedAt = completedAt,
                CustomLists = customLists,
                HiddenFromStatusLists = hiddenFromStatusLists,
                Notes = notes,
                Priority = priority,
                Private = @private,
                Progress = progress,
                ProgressVolumes = progressVolumes,
                Repeat = repeat
            }, Headers);
        }
        
        #endregion
    }
}