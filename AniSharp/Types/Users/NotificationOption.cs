using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users
{
	public class NotificationOption : GraphQlType
	{
		[TypeField] public NotificationType Type { get; set; }
		[TypeField] public bool Enabled { get; set; }
	}
}