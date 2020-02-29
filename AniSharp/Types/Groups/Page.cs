using CSGraphQL.GraphQL;

namespace AniSharp.Types.Groups
{
	public class Page : Type
	{
		[Variable("Page")] public int Page_ { get; set; }
		[Variable] public int PerPage { get; set; }
		
		[Request] public PageInfo PageInfo { get; set; }
	}
}