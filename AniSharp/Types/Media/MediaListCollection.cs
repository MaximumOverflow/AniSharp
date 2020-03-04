using AniSharp.Types.Users;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaListCollection : GraphQlType
	{
		[TypeField] public MediaListGroup[] Lists { get; set; }
		[TypeField] public User User{ get; set; }
		[TypeField] public bool HasNextChunk{ get; set; }
	}
}