using AniSharp.Types.Media;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.Base.Media.Multiple
{
	public class AnimePageQuery : MediaPageQuery
	{
		public override MediaType Type => MediaType.ANIME;
		[NestedVariable] public int? Episodes { get; set; }
		[NestedVariable] public int? Duration { get; set; }
		
		public AnimePageQuery(int page, int perPage) : base(page, perPage) {}
	}
}