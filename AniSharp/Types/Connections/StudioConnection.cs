using AniSharp.Types.Edges;
using AniSharp.Types.Groups;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Connections
{
	public class StudioConnection : GraphQlType
	{
		[TypeField] public StudioEdge[] Edges { get; set; }
		[TypeField] public Studio[] Nodes { get; set; }
		[TypeField] public PageInfo PageInfo { get; set; }
	}
}