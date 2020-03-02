using CSGraphQL.GraphQL;

namespace AniSharp.Types.Staff
{
	public class StaffName : GraphQlType
	{
		[TypeField] public string First { get; set; }
		[TypeField] public string Last { get; set; }
		[TypeField] public string Full { get; set; }
		[TypeField] public string Native { get; set; }
		[TypeField] public string[] Alternative { get; set; }
	}
}