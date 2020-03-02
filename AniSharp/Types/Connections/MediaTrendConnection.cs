using AniSharp.Types.Edges;
using AniSharp.Types.Groups;
using AniSharp.Types.Media;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Connections
{
	public class MediaTrendConnection : GraphQlType
	{
		[TypeField] public MediaTrendEdge[] Edges { get; set; }
		[TypeField] public MediaTrend[] Nodes { get; set; }
		[TypeField] public PageInfo PageInfo { get; set; }
	}
}