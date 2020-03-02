using CSGraphQL.GraphQL;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Mutations.SimpleMutations
{
	[MutationName("DeleteMediaListEntry")]
	public class SimpleDeleteMediaListEntryMutation : GraphQlMutation
	{
		public SimpleDeleteMediaListEntryMutation(int mediaId) => Id = mediaId;
		
		[Variable] public int Id { get; }
		[Request] public bool Deleted { get; }
	}
}