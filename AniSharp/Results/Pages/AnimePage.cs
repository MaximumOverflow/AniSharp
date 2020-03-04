using AniSharp.Results.Single;
using AniSharp.Types.Media;

namespace AniSharp.Results.Pages
{
	public class AnimePage : MediaPage
	{
		public override MediaType MediaType => MediaType.ANIME;
		public Anime[] Media;
	}
}