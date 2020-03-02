using CSGraphQL.GraphQL;
using CSGraphQL.GraphQL.Short;

namespace AniSharp.Mutations.Base.Media
{
	public abstract class MediaMutation : GraphQlMutation
	{
		[Variable] public int? MediaId { get; }
		[Variable("Ids")] public int[] MediaIds { get; }

		protected MediaMutation(int mediaId) => MediaId = mediaId;
		protected MediaMutation(int[] mediaIds) => MediaIds = mediaIds;
	}
}