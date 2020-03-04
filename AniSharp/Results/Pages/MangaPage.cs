using AniSharp.Results.Single;
using AniSharp.Types.Media;

namespace AniSharp.Results.Pages
{
	public class MangaPage : MediaPage
	{
		public override MediaType MediaType => MediaType.MANGA;
		public Manga[] Media;
	}
}