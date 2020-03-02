using AniSharp.Types.Media;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Results
{
	public class Media : GraphQlType
	{
		[Field] public int? Id { get; set; }
		[Field] public int? IdMal { get; set; }
		[Field] public MediaTitle Title { get; set; }
		[Field] public MediaType Type { get; set; }
		[Field] public MediaFormat Format { get; set; }
		[Field] public MediaStatus Status{ get; set; }
		[Field] public string Description { get; set; }
		[Field] public Date StartDate { get; set; }
		[Field] public Date EndDate { get; set; }
		[Field] public MediaSeason Season { get; set; }
		[Field] public int? SeasonYear { get; set; }
		[Field] public string CountryOfOrigin { get; set; }
		[Field] public bool IsLicensed { get; set; }
		[Field] public MediaSource Source { get; set; }
		[Field] public string Hashtag { get; set; }
		[Field] public MediaTrailer Trailer { get; set; }
		[Field] public int UpdatedAt { get; set; }
		[Field] public MediaCoverImage CoverImage { get; set; }
		[Field] public string BannerImage { get; set; }
		[Field] public string[] Genres { get; set; }
		[Field] public string[] Synonyms { get; set; }
		[Field] public int AverageScore { get; set; }
		[Field] public int MeanScore { get; set; }
		[Field] public int Popularity { get; set; }
		[Field] public bool IsLocked { get; set; }
		[Field] public int Trending { get; set; }
		[Field] public int Favourites { get; set; }
	}
}