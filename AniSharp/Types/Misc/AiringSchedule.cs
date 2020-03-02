using CSGraphQL.GraphQL;

namespace AniSharp.Types.Misc
{
	public class AiringSchedule
	{
		[TypeField] public int Id { get; set; }
		[TypeField] public int AiringAt { get; set; }
		[TypeField] public int TimeUntilAiring { get; set; }
		[TypeField] public int Episode { get; set; }
		[TypeField] public int MediaId { get; set; }
		[TypeField] public Media.Media Media { get; set; }
	}
}