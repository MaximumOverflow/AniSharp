namespace AniSharp.Types.Media
{
	public enum MediaType
	{
		Anime, 
		Manga
	}

	public enum MediaFormat
	{
		Tv,
		TvShort,
		Movie,
		Special,
		Ova,
		Ona,
		Music,
		Manga,
		Novel,
		OneShot,
	}

	public enum MediaStatus
	{
		Finished,
		Releasing,
		NotYetReleased,
		Cancelled,
	}

	public enum MediaSeason
	{
		Winter,
		Spring,
		Summer,
		Fall
	}

	public enum MediaSource
	{
		Original,
		Manga,
		LightNovel,
		VisualNovel,
		VideoGame,
		Other,
		Novel,
		Doujinshi,
		Anime,
	}

	public enum MediaRelation
	{
		Adaptation,
		Prequel,
		Sequel,
		Parent,
		SideStory,
		Character,
		Summary,
		Alternative,
		SpinOff,
		Other,
		Source,
		Compilation,
		Contains,
	}

	public enum MediaListStatus
	{
		Current,
		Planning,
		Completed,
		Dropped,
		Paused,
		Repeating,
	}

	public enum MediaSort
	{
		Id,
		IdDesc,
		TitleRomaji,
		TitleRomajiDesc,
		TitleEnglish,
		TitleEnglishDesc,
		TitleNative,
		TitleNativeDesc,
		Type,
		TypeDesc,
		Format,
		FormatDesc,
		StartDate,
		StartDateDesc,
		EndDate,
		EndDateDesc,
		Score,
		ScoreDesc,
		Popularity,
		PopularityDesc,
		Trending,
		TrendingDesc,
		Episodes,
		EpisodesDesc,
		Duration,
		DurationDesc,
		Status,
		StatusDesc,
		Chapters,
		ChaptersDesc,
		Volumes,
		VolumesDesc,
		UpdatedAt,
		UpdatedAtDesc,
		SearchMatch,
		Favourites,
		FavouritesDesc
	}

	public enum MediaRankType
	{
		Rated,
		Popular
	}

	public enum ReviewRating
	{
		NoVote,
		UpVote,
		DownVote,
	}
	
	public enum RecommendationRating
	{
		NoVote,
		UpVote,
		DownVote,
	}
}