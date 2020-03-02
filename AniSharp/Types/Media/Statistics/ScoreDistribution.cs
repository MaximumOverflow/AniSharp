using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media.Statistics
{
	public class ScoreDistribution : GraphQlType
	{
		[TypeField] public int Score { get; set; }
		[TypeField] public int Amount { get; set; }
	}
}