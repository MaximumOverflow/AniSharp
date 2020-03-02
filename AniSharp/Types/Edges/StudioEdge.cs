using CSGraphQL.GraphQL;

namespace AniSharp.Types.Edges
{
	public class StudioEdge : GraphQlType
	{
		[TypeField] public Studio Node { get; set; }
		[TypeField] public int Id { get; set; }
		[TypeField] public bool IsMain { get; set; }
		[TypeField] public int FavouriteOrder { get; set; }
	}
}