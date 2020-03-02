using CSGraphQL.GraphQL;

namespace AniSharp.Types.Characters
{
	public class CharacterImage : GraphQlType
	{
		[TypeField] public string Large { get; set; }
		[TypeField] public string Medium { get; set; }
	}
}