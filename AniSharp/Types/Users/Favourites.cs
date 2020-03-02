using AniSharp.Types.Connections;
using CSGraphQL.GraphQL;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Types.Users
{
	//Fix recursion
	public class Favourites : GraphQlType
	{
		[TypeField] public MediaConnection Anime { get; set; }
		[TypeField] public MediaConnection Manga { get; set; }
		[TypeField] public CharacterConnection Characters { get; set; }
		[TypeField] public StaffConnection Staff { get; set; }
		[TypeField] public StudioConnection Studios { get; set; }
	}
}