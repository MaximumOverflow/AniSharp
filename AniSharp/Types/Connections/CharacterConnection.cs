using AniSharp.Types.Characters;
using AniSharp.Types.Edges;
using AniSharp.Types.Groups;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Connections
{
	public class CharacterConnection : GraphQlType
	{
		[TypeField] public CharacterEdge[] Edges { get; set; }
		[TypeField] public Character[] Nodes { get; set; }
		[TypeField] public PageInfo PageInfo { get; set; }
	}
}