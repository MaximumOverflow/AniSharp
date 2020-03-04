using AniSharp.Queries.Base.Media.Multiple;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.SimpleQueries
{
	public class SimpleMangaPageQuery : MangaPageQuery
	{
		[Request] public SimpleMangaQuery Media { get; set; }
		public SimpleMangaPageQuery(int page, int perPage) : base(page, perPage) {}
	}
}