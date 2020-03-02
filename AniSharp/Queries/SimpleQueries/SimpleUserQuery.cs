using AniSharp.Types.Users;
using CSGraphQL.GraphQL.Short;
using AniSharp.Queries.Base.Users;

namespace AniSharp.Queries.SimpleQueries
{
	public class SimpleUserQuery : UserQuery
	{
		[Request] public int Id_ { get; set; }
		[Request] public  string Name_ { get; set; }
		[Request] public string About { get; set; }
		[Request] public UserAvatar Avatar { get; set; }
		[Request] public string BannerImage { get; set; }
	}
}