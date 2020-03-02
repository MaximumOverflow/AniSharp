using AniSharp.Types.Edges;
using AniSharp.Types.Groups;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Connections
{
	public class StaffConnection : GraphQlType
	{
		[TypeField] public StaffEdge[] Edges { get; set; }
		[TypeField] public Staff.Staff[] Nodes { get; set; }
		[TypeField] public PageInfo PageInfo { get; set; }
	}
}