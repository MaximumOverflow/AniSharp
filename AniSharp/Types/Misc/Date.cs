using CSGraphQL.GraphQL;

namespace AniSharp.Types.Misc
{
	public class Date : GraphQlType
	{
		[TypeField] public int Year { get; set; }
		[TypeField] public int Month { get; set; }
		[TypeField] public int Day { get; set; }
	}
}