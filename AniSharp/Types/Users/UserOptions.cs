using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users
{
	public class UserOptions : GraphQlType
	{
		[TypeField] public UserTitleLanguage TitleLanguage { get; set; }
		[TypeField] public bool DisplayAdultContent { get; set; }
		[TypeField] public bool AiringNotifications { get; set; }
		[TypeField] public string ProfileColor { get; set; }
		[TypeField] public NotificationOption[] NotificationOptions { get; set; }
	}
}