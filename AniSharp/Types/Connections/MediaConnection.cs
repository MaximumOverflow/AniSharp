using AniSharp.Types.Edges;
using AniSharp.Types.Groups;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Connections
{
	public class MediaConnection : GraphQlType
	{
		[TypeField] public MediaEdge[] Edges { get; set; }
		[TypeField] public Media.Media[] Nodes { get; set; }
		[TypeField] public PageInfo PageInfo { get; set; }
	}
}