using AniSharp.Types.Users;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Edges
{
	public class ReviewEdge
	{
		[TypeField] public Review Node { get; set; }
	}
}