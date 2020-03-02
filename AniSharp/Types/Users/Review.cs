using AniSharp.Types.Media;
using CSGraphQL.GraphQL;

namespace AniSharp.Types.Users
{
	public class Review : GraphQlType
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public int UserId { get; set; }
		[TypeField] public int MediaId { get; set; }
		[TypeField] public MediaType MediaType { get; set; }
		[TypeField] public string Summery { get; set; }
		[TypeField] public string Body { get; set; }
		[TypeField] public int Rating { get; set; }
		[TypeField] public int RatingAmount { get; set; }
		[TypeField] public ReviewRating UserRating { get; set; }
		[TypeField] public int Score { get; set; }
		[TypeField] public bool Private { get; set; }
		[TypeField] public string SiteUrl { get; set; }
		[TypeField] public int CreatedAt { get; set; }
		[TypeField] public int UpdatedAt { get; set; }
		[TypeField] public User User { get; set; }
		[TypeField] public Media.Media Media { get; set; }
	}
}