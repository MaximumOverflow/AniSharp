using CSGraphQL.GraphQL;
using AniSharp.Types.Media;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.Base.Media.Multiple
{
	[QueryName("Page")]
	public abstract class MediaPageQuery : GraphQlQuery
	{
		[Variable] public int Page { get; set; }
		[Variable] public int PerPage { get; set; }

		public abstract MediaType Type { get; }
		[NestedVariable] public int? EndDate { get; set; }
		[NestedVariable] public int? StartDate { get; set; }
		[NestedVariable] public MediaSeason? Season { get; set; }
		[NestedVariable] public int? SeasonYear { get; set; }
		[NestedVariable] public MediaFormat? Format { get; set; }
		[NestedVariable] public MediaStatus? Status { get; set; }
		[NestedVariable] public bool? IsAdult { get; set; }
		[NestedVariable] public string Genre { get; set; }
		[NestedVariable] public string Tag { get; set; }
		[NestedVariable] public int? MinimumTagRank { get; set; }
		[NestedVariable] public string TagCategory { get; set; }
		[NestedVariable] public bool? OnList { get; set; }
		[NestedVariable] public string LicensedBy { get; set; }
		[NestedVariable] public int? AverageScore { get; set; }
		[NestedVariable] public int? Popularity { get; set; }
		[NestedVariable] public MediaSource? Source { get; set; }
		[NestedVariable] public string CountryOfOrigin { get; set; }
		[NestedVariable] public string Search { get; set; }
		[NestedVariable] public MediaSort? Sort { get; set; }

		protected MediaPageQuery(int page, int perPage)
		{
			Page = page;
			PerPage = perPage;
		}
	}
}