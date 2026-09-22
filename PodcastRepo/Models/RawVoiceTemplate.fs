namespace PodcastRepo.Models

type RawVoiceEpisode =
    { Author: string
      Title: string
      PublishedDate: string
      AudioUrl: string
      AudioType: string
      AudioLength: string
      Guid: string
      Description: string }

type RawVoiceChannel =
    { Title: string
      Rating: string
      Location: string
      Frequency: string
      Author: string
      ImageUrl: string
      PodcastUrl: string
      Copyright: string
      ShortDescription: string
      Language: string
      PublishedDate: string
      FeedUrl: string
      Episode: RawVoiceEpisode array }

type RawVoiceTemplate =
    { Channel: RawVoiceChannel }