namespace PodcastRepo.Models

type GooglePlayEpisode =
    { Author: string
      Title: string
      PublishedDate: string
      AudioUrl: string
      AudioType: string
      AudioLength: string
      Guid: string
      Description: string }

type GooglePlayChannel =
    { Title: string
      Author: string
      ImageUrl: string
      PodcastUrl: string
      Copyright: string
      ShortDescription: string
      IconUrl: string
      Language: string
      PublishedDate: string
      FeedUrl: string
      Episode: GooglePlayEpisode array }

type GooglePlayTemplate =
    { Channel: GooglePlayChannel }