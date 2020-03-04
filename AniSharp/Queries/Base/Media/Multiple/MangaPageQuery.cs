using AniSharp.Types.Media;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.Base.Media.Multiple
{
	public class MangaPageQuery : MediaPageQuery
	{
		public override MediaType Type => MediaType.MANGA;
		[NestedVariable] public int? Chapters { get; set; }
		[NestedVariable] public int? Volumes { get; set; }
		
		public MangaPageQuery(int page, int perPage) : base(page, perPage) {}
	}
}