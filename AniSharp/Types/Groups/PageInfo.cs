using CSGraphQL.GraphQL;

namespace AniSharp.Types.Groups
{
	public class PageInfo : GraphQlType
	{
		[TypeField] public int Total { get; set; }
		[TypeField] public int Page { get; set; }
		[TypeField] public int PerPage { get; set; }
		[TypeField] public int LastPage { get; set; }
		[TypeField] public bool HasNextPage { get; set; }
	}
}