using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users
{
	public class MediaListOptions : GraphQlType
	{
		[TypeField] public ScoreFormat ScoreFormat { get; set; }
		[TypeField] public string RowOrder { get; set; }
		[TypeField] public bool UseLegacyLists { get; set; }
		[TypeField] public MediaListTypeOptions AnimeList { get; set; }
		[TypeField] public MediaListTypeOptions MangaList { get; set; }
	}
}