using System.Collections.Generic;
using System.Linq;
using AniSharp.Types;

namespace AniSharp.Results.Groups
{
	public class MangaPage : IResult
	{
		public readonly PageInfo PageInfo;
		public readonly Manga[] Manga;

		public MangaPage(Types.Groups.MangaPage page) : this(page.PageInfo, page.Media){}
		
		public MangaPage(PageInfo info, IEnumerable<Types.Manga> manga)
		{
			PageInfo = info;
			Manga = manga.Select(a => new Manga(a)).ToArray();
		}
	}
}