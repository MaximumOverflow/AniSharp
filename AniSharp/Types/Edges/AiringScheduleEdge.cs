using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Edges
{
	public class AiringScheduleEdge : GraphQlType
	{
		[TypeField] public AiringSchedule Node { get; set; }
		[TypeField] public int Id { get; set; }
	}
}