using AniSharp.Types.Users;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Media
{
	public class Recommendation : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public int Rating { get; set; }
		[TypeField] public RecommendationRating UserRating { get; set; }
		[TypeField] public Media Media { get; set; }
		[TypeField] public Media MediaRecommendation { get; set; }
		[TypeField] public User User { get; set; }
	}
}