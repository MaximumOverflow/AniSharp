using AniSharp.Types.Edges;
using AniSharp.Types.Groups;
using AniSharp.Types.Users;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Connections
{
	public class ReviewConnection : GraphQlType
	{
		[TypeField] public ReviewEdge[] Edges { get; set; }
		[TypeField] public Review[] Nodes { get; set; }
		[TypeField] public PageInfo PageInfo { get; set; }
	}
}