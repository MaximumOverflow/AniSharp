using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media.Statistics
{
	public class StatusDistribution : GraphQlType
	{
		[TypeField] public MediaListStatus Status { get; set; }
		[TypeField] public int Amount { get; set; }
	}
}