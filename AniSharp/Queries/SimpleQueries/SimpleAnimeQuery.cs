using AniSharp.Queries.Base.Media.Single;
using AniSharp.Types.Media;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.SimpleQueries
{
	public class SimpleAnimeQuery : AnimeQuery
	{
		[Request] public int? Id_ { get; set; }
		[Request] public MediaTitle Title { get; set; }
		[Request] public MediaType Type_ { get; set; }
		[Request] public MediaFormat Format_ { get; set; }
		[Request] public MediaStatus Status_{ get; set; }
		[Request] public string Description { get; set; }
		[Request] public Date StartDate_ { get; set; }
		[Request] public Date EndDate_ { get; set; }
		[Request] public MediaSeason Season_ { get; set; }
		[Request] public int? SeasonYear_ { get; set; }
		[Request] public string CountryOfOrigin_ { get; set; }
		[Request] public bool IsLicensed { get; set; }
		[Request] public MediaSource Source_ { get; set; }
		[Request] public string Hashtag { get; set; }
		[Request] public MediaTrailer Trailer { get; set; }
		[Request] public int UpdatedAt { get; set; }
		[Request] public MediaCoverImage CoverImage { get; set; }
		[Request] public string BannerImage { get; set; }
		[Request] public string[] Genres { get; set; }
		[Request] public string[] Synonyms { get; set; }
		[Request] public int AverageScore_ { get; set; }
		[Request] public int MeanScore { get; set; }
		[Request] public int Popularity_ { get; set; }
		[Request] public bool IsLocked { get; set; }
		[Request] public int Trending { get; set; }
		[Request] public int Favourites { get; set; }
		[Request] public int? Episodes_ { get; set; }
		[Request] public int? Duration_ { get; set; }
	}
}