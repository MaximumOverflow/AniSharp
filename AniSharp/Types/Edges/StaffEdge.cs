using CSGraphQL.GraphQL;

namespace AniSharp.Types.Edges
{
	public class StaffEdge : GraphQlType
	{
		[TypeField] public Staff.Staff[] Node { get; set; }
		[TypeField] public int Id { get; set; }
		[TypeField] public string Role { get; set; }
		[TypeField] public int FavouriteOrder { get; set; }
	}
}