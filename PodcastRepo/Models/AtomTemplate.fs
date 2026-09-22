namespace PodcastRepo.Models

type AtomEpisode =
    { Author: string
      Title: string
      PublishedDate: string
      AudioUrl: string
      AudioType: string
      AudioLength: string
      Guid: string
      Description: string }

type AtomChannel =
    { Title: string
      Author: string
      ImageUrl: string
      PodcastUrl: string
      Copyright: string
      ShortDescription: string
      Language: string
      PublishedDate: string
      FeedUrl: string
      Episode: AtomEpisode array }

type AtomTemplate =
    { Channel: AtomChannel }