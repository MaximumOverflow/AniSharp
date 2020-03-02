using AniSharp.Types.Media;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Edges
{
	public class MediaTrendEdge : GraphQlType
	{
		[TypeField] public MediaTrend Node { get; set; }
	}
}