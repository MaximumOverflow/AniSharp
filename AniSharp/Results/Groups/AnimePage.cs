using System.Collections.Generic;
using System.Linq;
using AniSharp.Types;

namespace AniSharp.Results.Groups
{
	public class AnimePage : IResult
	{
		public readonly PageInfo PageInfo;
		public readonly Anime[] Anime;

		public AnimePage(Types.Groups.AnimePage page) : this(page.PageInfo, page.Media){}
		
		public AnimePage(PageInfo info, IEnumerable<Types.Anime> anime)
		{
			PageInfo = info;
			Anime = anime.Select(a => new Anime(a)).ToArray();
		}
	}
}