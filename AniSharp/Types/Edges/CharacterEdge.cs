using AniSharp.Types.Characters;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Edges
{
	public class CharacterEdge : GraphQlType
	{
		[TypeField] public Character Node { get; set; }
		[TypeField] public int Id { get; set; }
		[TypeField] public CharacterRole CharacterRole { get; set; }
		[TypeField] public Staff.Staff[] VoiceActors { get; set; }
		[TypeField] public Media.Media[] Media { get; set; }
		[TypeField] public int FavouriteOrder { get; set; }
	}
}