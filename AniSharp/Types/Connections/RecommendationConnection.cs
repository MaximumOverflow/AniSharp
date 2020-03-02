using AniSharp.Types.Edges;
using AniSharp.Types.Groups;
using AniSharp.Types.Media;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Connections
{
	public class RecommendationConnection : GraphQlType
	{
		[TypeField] public RecommendationEdge[] Edges { get; set; }
		[TypeField] public Recommendation[] Nodes { get; set; }
		[TypeField] public PageInfo PageInfo { get; set; }
	}
}