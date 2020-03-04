using AniSharp.Types.Users;
using CSGraphQL.GraphQL.Short;
using AniSharp.Queries.Base.Users;

namespace AniSharp.Queries.AdvancedQueries
{
	public class FullUserQuery : UserQuery
	{
		[Request] public int Id { get; set; }
		[Request] public new string Name { get; set; }
		[Request] public string About { get; set; }
		[Request] public UserAvatar Avatar { get; set; }
		[Request] public string BannerImage { get; set; }
		[Request] public UserOptions Options{ get; set; }
		[Request] public MediaListOptions MediaListOptions{ get; set; }
		// [Request] public Favourites Favourites{ get; set; }
		// [Request] public UserStatisticTypes Statistics{ get; set; } //TODO Fix array types in CSGraphQL
		[Request] public int UnreadNotificationCount{ get; set; }
		[Request] public string SiteUrl { get; set; }
		[Request] public int DonatorTier { get; set; }
		[Request] public string DonatorBadge { get; set; }
		[Request] public string ModeratorStatus { get; set; }
		[Request] public int UpdatedAt { get; set; }
	}
}