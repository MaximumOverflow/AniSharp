using CSGraphQL.GraphQL;
using AniSharp.Types.Users;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Queries.Base.Users
{
	[QueryName("User")]
	public class UserQuery : GraphQlQuery
	{
		[Variable] public int? Id { get; set; }
		[Variable] public string Name { get; set; }
		[Variable] public string Search { get; set; }
		[Variable] public UserSort? Sort { get; set; }
	}
}