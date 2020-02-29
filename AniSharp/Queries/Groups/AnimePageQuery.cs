using AniSharp.Types;
using AniSharp.Types.Groups;
using CSGraphQL.GraphQL;

namespace AniSharp.Queries.Groups
{
	[QueryName("Page")]
	public class AnimePageQuery : Query<AnimePage>
	{
		[Variable] public int Page { get; set; }
		[Variable] public int PerPage { get; set; }
		
		[Variable] public int? Id { get; set; }
		[Variable] public int? EndDate { get; set; }
		[Variable] public int? StartDate { get; set; }
		[Variable] public MediaSeason? Season { get; set; }
		[Variable] public int? SeasonYear { get; set; }
		[Variable] public MediaType? Type => MediaType.ANIME;
		[Variable] public MediaFormat? Format { get; set; }
		[Variable] public MediaStatus? Status { get; set; }
		[Variable] public int? Episodes { get; set; }
		[Variable] public int? Duration { get; set; }
		[Variable] public bool? IsAdult { get; set; }
		[Variable] public int? AverageScore { get; set; }
		[Variable] public int? Popularity { get; set; }
		[Variable] public MediaSource? Source { get; set; }
		[Variable] public string CountryOfOrigin { get; set; }
		[Variable] public string Search { get; set; }
		[Variable] public MediaSort? Sort { get; set; }
		

		[Request] public AnimePage AnimePage { get; set; }
	}
}