namespace AniSharp.Types.Users
{
	public enum UserTitleLanguage
	{
		Romaji,
		English,
		Native,
		RomajiStylised,
		EnglishStylised,
		NativeStylised,
	}

	public enum NotificationType
	{
		ActivityMessage,
		ActivityReply,
		Following,
		ActivityMention,
		ThreadCommentMention,
		ThreadSubscribed,
		ThreadCommentReply,
		Airing,
		ActivityLike,
		ActivityReplyLike,
		ThreadLike,
		ThreadCommentLike,
		ActivityReplySubscribed,
		RelatedMediaAddition,
	}

	public enum ScoreFormat
	{
		Point100,
		Point10Decimal,
		Point10,
		Point5,
		Point3,
	}
}