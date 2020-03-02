using AniSharp.Types.Media;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.Base
{
	public abstract class AnimeQuery : MediaQuery
	{
		public override MediaType Type => MediaType.Anime;
		[Variable] public int? Episodes { get; set; }
		[Variable] public int? Duration { get; set; }
	}
}