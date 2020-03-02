using AniSharp.Types.Media;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.Base
{
	public abstract class MangaQuery : MediaQuery
	{
		public override MediaType Type => MediaType.Manga;
		[Variable] public int? Chapters { get; set; }
		[Variable] public int? Volumes { get; set; }
	}
}