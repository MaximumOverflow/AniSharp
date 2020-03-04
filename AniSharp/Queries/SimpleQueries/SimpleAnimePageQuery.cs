using AniSharp.Queries.Base.Media.Multiple;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.SimpleQueries
{
	public class SimpleAnimePageQuery : AnimePageQuery
	{
		[Request] public SimpleAnimeQuery Media { get; set; }
		public SimpleAnimePageQuery(int page, int perPage) : base(page, perPage) {}
	}
}