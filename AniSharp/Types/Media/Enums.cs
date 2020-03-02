namespace AniSharp.Types.Media
{
	public enum MediaType
	{
		ANIME, 
		MANGA
	}

	public enum MediaFormat
	{
		TV,
		TV_SHORT,
		MOVIE,
		SPECIAL,
		OVA,
		ONA,
		MUSIC,
		MANGA,
		NOVEL,
		ONE_SHOT,
	}

	public enum MediaStatus
	{
		FINISHED,
		RELEASING,
		NOT_YET_RELEASED,
		CANCELLED,
	}

	public enum MediaSeason
	{
		WINTER,
		SPRING,
		SUMMER,
		FALL
	}

	public enum MediaSource
	{
		ORIGINAL,
		MANGA,
		LIGHT_NOVEL,
		VISUAL_NOVEL,
		VIDEO_GAME,
		OTHER,
		NOVEL,
		DOUJINSHI,
		ANIME,
	}

	public enum MediaRelation
	{
		ADAPTATION,
		PREQUEL,
		SEQUEL,
		PARENT,
		SIDE_STORY,
		CHARACTER,
		SUMMARY,
		ALTERNATIVE,
		SPIN_OFF,
		OTHER,
		SOURCE,
		COMPILATION,
		CONTAINS,
	}

	public enum MediaListStatus
	{
		CURRENT,
		PLANNING,
		COMPLETED,
		DROPPED,
		PAUSED,
		REPEATING,
	}

	public enum MediaSort
	{
		ID,
		ID_DESC,
		TITLE_ROMAJI,
		TITLE_ROMAJI_DESC,
		TITLE_ENGLISH,
		TITLE_ENGLISH_DESC,
		TITLE_NATIVE,
		TITLE_NATIVE_DESC,
		TYPE,
		TYPE_DESC,
		FORMAT,
		FORMAT_DESC,
		START_DATE,
		START_DATE_DESC,
		END_DATE,
		END_DATE_DESC,
		SCORE,
		SCORE_DESC,
		POPULARITY,
		POPULARITY_DESC,
		TRENDING,
		TRENDING_DESC,
		EPISODES,
		EPISODES_DESC,
		DURATION,
		DURATION_DESC,
		STATUS,
		STATUS_DESC,
		CHAPTERS,
		CHAPTERS_DESC,
		VOLUMES,
		VOLUMES_DESC,
		UPDATED_AT,
		UPDATED_AT_DESC,
		SEARCH_MATCH,
		FAVOURITES,
		FAVOURITES_DESC
	}

	public enum MediaRankType
	{
		RATED,
		POPULAR
	}

	public enum ReviewRating
	{
		NO_VOTE,
		UP_VOTE,
		DOWN_VOTE,
	}
	
	public enum RecommendationRating
	{
		NO_VOTE,
		UP_VOTE,
		DOWN_VOTE,
	}
}