using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media.Statistics
{
	public class MediaStats : GraphQlType
	{
		[TypeField] public ScoreDistribution ScoreDistribution { get; set; }
		[TypeField] public StatusDistribution StatusDistribution { get; set; }
	}
}