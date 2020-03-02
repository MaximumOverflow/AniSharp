using AniSharp.Types.Connections;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Characters
{
	public class Character : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public new CharacterName Name { get; set; }
		[TypeField] public CharacterImage Image { get; set; }
		[TypeField] public string Description { get; set; }
		[TypeField] public bool IsFavourite { get; set; }
		[TypeField] public string SiteUrl { get; set; }
		[TypeField] public MediaConnection[] Media { get; set; }
		[TypeField] public int Favourites { get; set; }
	}
}