using AniSharp.Types;
using CSGraphQL.GraphQL;

namespace AniSharp.Queries
{
	public class MediaQuery : Query<Media>
	{
		[Variable] public int? Id { get; set; }
		[Variable] public int? IdMal { get; set; }
		[Variable] public int? EndDate { get; set; }
		[Variable] public int? StartDate { get; set; }
		[Variable] public MediaSeason? Season { get; set; }
		[Variable] public int? SeasonYear { get; set; }
		[Variable] public MediaType? Type { get; set; }
		[Variable] public MediaFormat? Format { get; set; }
		[Variable] public MediaStatus? Status { get; set; }
		[Variable] public int? Episodes { get; set; }
		[Variable] public int? Duration { get; set; }
		[Variable] public int? Chapters { get; set; }
		[Variable] public int? Volumes { get; set; }
		[Variable] public bool? IsAdult { get; set; }
		[Variable] public string Genre { get; set; }
		[Variable] public string Tag { get; set; }
		[Variable] public int? MinimumTagRank { get; set; }
		[Variable] public string TagCategory { get; set; }
		[Variable] public bool? OnList { get; set; }
		[Variable] public string LicensedBy { get; set; }
		[Variable] public int? AverageScore { get; set; }
		[Variable] public int? Popularity { get; set; }
		[Variable] public MediaSource? Source { get; set; }
		[Variable] public string CountryOfOrigin { get; set; }
		[Variable] public string Search { get; set; }
		[Variable] public MediaSort? Sort { get; set; }
	}
}