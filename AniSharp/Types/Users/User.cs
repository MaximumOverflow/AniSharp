using AniSharp.Types.Users.Statistics;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users
{
	public class User : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public new string Name { get; set; }
		[TypeField] public string About { get; set; }
		[TypeField] public UserAvatar Avatar { get; set; }
		[TypeField] public string BannerImage { get; set; }
		[TypeField] public bool IsFollowing { get; set; }
		[TypeField] public bool IsFollower { get; set; }
		[TypeField] public bool IsBlocked{ get; set; }
		[TypeField] public UserOptions Options{ get; set; }
		[TypeField] public MediaListOptions MediaListOptions{ get; set; }
		[TypeField] public Favourites Favourites{ get; set; }
		[TypeField] public UserStatisticTypes Statistics{ get; set; }
		[TypeField] public int UnreadNotificationCount{ get; set; }
		[TypeField] public string SiteUrl { get; set; }
		[TypeField] public int DonatorTier { get; set; }
		[TypeField] public string DonatorBadge { get; set; }
		[TypeField] public string ModeratorBadge { get; set; }
		[TypeField] public int UpdatedAt { get; set; }
	}
}