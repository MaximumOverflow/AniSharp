using CSGraphQL.GraphQL.Short;
using AniSharp.Mutations.Base.Media;

namespace AniSharp.Mutations.SimpleMutations
{
	public class SimpleSaveMediaListEntryMutation : SaveMediaListEntryMutation
	{
		public SimpleSaveMediaListEntryMutation(int mediaId) : base(mediaId) {}
		[Request] public int Id_ { get; }
	}
}