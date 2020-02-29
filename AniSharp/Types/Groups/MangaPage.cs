using CSGraphQL.GraphQL;

namespace AniSharp.Types.Groups
{
	public class MangaPage : Page
	{
		[Request] public Manga[] Media { get; set; }
	}
}