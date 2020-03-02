using AniSharp.Types.Edges;
using AniSharp.Types.Groups;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Connections
{
	public class AiringScheduleConnection : GraphQlType
	{
		[TypeField] public AiringScheduleEdge[] Edges { get; set; }
		[TypeField] public AiringSchedule[] Nodes { get; set; }
		[TypeField] public PageInfo PageInfo { get; set; }
	}
}