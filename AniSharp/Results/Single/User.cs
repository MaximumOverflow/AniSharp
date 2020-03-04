using AniSharp.Types.Users;
using CSGraphQL.GraphQL;

namespace AniSharp.Results.Single
{
	public class User : GraphQlType
	{
		[TypeField] public int Id_ { get; set; }
		[TypeField] public string Name_ { get; set; }
		[TypeField] public string About { get; set; }
		[TypeField] public UserAvatar Avatar { get; set; }
		[TypeField] public string BannerImage { get; set; }
	}
}