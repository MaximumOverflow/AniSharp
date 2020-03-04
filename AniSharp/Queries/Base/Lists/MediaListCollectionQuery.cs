using AniSharp.Types.Media;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.Base.Lists
{
	public class MediaListCollectionQuery : GraphQlQuery
	{
		[Variable] public int? UserId { get; set; }
		[Variable] public MediaType Type { get; set; }
		[Variable] public string UserName { get; set; }
		[Variable] public MediaListStatus? Status { get; set; }
		[Variable] public string Notes { get; set; }
		[Variable] public Date StartedAt { get; set; }
		[Variable] public Date CompletedAt { get; set; }
		[Variable] public MediaListSort? Sort { get; set; }
	}
}