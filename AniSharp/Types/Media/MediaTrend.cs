using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class MediaTrend : GraphQlType
	{
		[TypeField] public int MediaId { get; set; }
		[TypeField] public int Date { get; set; }
		[TypeField] public int Trending { get; set; }
		[TypeField] public int AverageScore { get; set; }
		[TypeField] public int Popularity { get; set; }
		[TypeField] public int InProgress { get; set; }
		[TypeField] public bool Releasing { get; set; }
		[TypeField] public int Episode { get; set; }
		[TypeField] public Media Media { get; set; }
	}
}