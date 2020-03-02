using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaRank : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public int Rank { get; set; }
		[TypeField] public MediaRankType Type { get; set; }
		[TypeField] public MediaFormat Format { get; set; }
		[TypeField] public int Year { get; set; }
		[TypeField] public MediaSeason Season { get; set; }
		[TypeField] public bool AllTime { get; set; }
		[TypeField] public string Context { get; set; }
	}
}