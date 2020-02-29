using CSGraphQL.GraphQL;

namespace AniSharp.Types.Groups
{
	public class AnimePage : Page
	{
		[Request] public Anime[] Media { get; set; }
	}
}