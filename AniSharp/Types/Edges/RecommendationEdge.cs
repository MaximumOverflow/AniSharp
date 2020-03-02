using AniSharp.Types.Media;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Edges
{
	public class RecommendationEdge : GraphQlType
	{
		[TypeField] public Recommendation Node { get; set; }
	}
}