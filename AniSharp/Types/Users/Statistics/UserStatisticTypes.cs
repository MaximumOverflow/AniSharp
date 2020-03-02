using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users.Statistics
{
	public class UserStatisticTypes : GraphQlType
	{
		[TypeField] public UserStatistics Anime { get; set; }
		[TypeField] public UserStatistics Manga { get; set; }
	}
}