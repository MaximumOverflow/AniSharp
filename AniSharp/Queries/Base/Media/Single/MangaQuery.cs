using AniSharp.Types.Media;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.Base.Media.Single
{
	public abstract class MangaQuery : MediaQuery
	{
		public override MediaType Type => MediaType.MANGA;
		[Variable] public int? Chapters { get; set; }
		[Variable] public int? Volumes { get; set; }
	}
}