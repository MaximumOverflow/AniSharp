using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users
{
	public class UserAvatar : GraphQlType
	{
		[TypeField] public string Large { get; set; }
		[TypeField] public string Medium { get; set; }
	}
}