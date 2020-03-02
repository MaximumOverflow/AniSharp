using AniSharp.Types.Characters;
using AniSharp.Types.Media;
using AniSharp.Types.Misc;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Edges
{
	public class MediaEdge : GraphQlType
	{
		[TypeField] public Media.Media Node { get; set; }
		[TypeField] public int Id { get; set; }
		[TypeField] public MediaRelation RelationType { get; set; }
		[TypeField] public bool IsMainStudio { get; set; }
		[TypeField] public Character[] Characters { get; set; }
		[TypeField] public CharacterRole CharacterRole { get; set; }
		[TypeField] public string StaffRole { get; set; }
		[TypeField] public Staff.Staff[] VoiceActors { get; set; }
		[TypeField] public int FavouriteOrder { get; set; }
	}
}