using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaTitle : GraphQlType
	{
		[TypeField] public string Native { get; set; }
		[TypeField] public string Romaji { get; set; }
		[TypeField] public string English { get; set; }
	}
}