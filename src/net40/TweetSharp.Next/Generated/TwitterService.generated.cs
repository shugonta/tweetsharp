using System;
using System.Collections.Generic;
using Hammock;
using Hammock.Web;

namespace TweetSharp
{
#region Interface
	public partial interface ITwitterService
	{
#if !SILVERLIGHT
		#region Sequential Methods
		TwitterUser VerifyCredentials();	

		TwitterRateLimitStatus GetRateLimitStatus();	

		TwitterError EndSession();	

		TwitterUser UpdateDeliveryDevice(TwitterDeliveryDevice device);	

		TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor);	

		TwitterUser UpdateProfileColors(string backgroundColor);	

		TwitterUser UpdateProfileColors(string backgroundColor, string textColor);	

		TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor);	

		TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor);	

		TwitterUser UpdateProfileImage(string path);	

		TwitterUser UpdateProfileBackgroundImage(string path);	

		TwitterUser UpdateProfile(string name, string description, string email, string url, string location);	

		TwitterUser BlockUser(int userId);	

		TwitterUser BlockUser(string userScreenName);	

		TwitterUser UnblockUser(int userId);	

		TwitterUser UnblockUser(string userScreenName);	

		TwitterUser VerifyBlocking(int userId);	

		TwitterUser VerifyBlocking(string userScreenName);	

		IEnumerable<TwitterUser> ListBlockedUsers();	

		IEnumerable<TwitterUser> ListBlockedUsers(int page);	

		IEnumerable<int> ListBlockedUserIds();	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived();	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId, int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId, int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSent();	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId, int page, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId, int count);	

		IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId, int page, int count);	

		TwitterDirectMessage DeleteDirectMessage(long id);	

		TwitterDirectMessage DeleteDirectMessage(int id);	

		TwitterDirectMessage SendDirectMessage(int userId, string text);	

		TwitterDirectMessage SendDirectMessage(string screenName, string text);	

		IEnumerable<TwitterStatus> ListFavoriteTweets();	

		IEnumerable<TwitterStatus> ListFavoriteTweets(int page);	

		IEnumerable<TwitterStatus> ListFavoriteTweets(int page, int count);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId, int page);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId, int page, int count);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName, int page);	

		IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName, int page, int count);	

		TwitterStatus FavoriteTweet(long id);	

		TwitterStatus UnfavoriteTweet(long id);	

		TwitterCursorList<int> ListFriendIdsOf(string screenName, long cursor);	

		TwitterCursorList<int> ListFriendIdsOf(int userId, long cursor);	

		TwitterCursorList<int> ListFollowerIdsOf(int userId, long cursor);	

		TwitterCursorList<int> ListFollowerIdsOf(string screenName, long cursor);	

		TwitterUser FollowUser(int userId);	

		TwitterUser FollowUser(string screenName);	

		TwitterUser UnfollowUser(string screenName);	

		TwitterUser UnfollowUser(int userId);	

		TwitterCursorList<int> GetIncomingFriendRequests();	

		TwitterCursorList<int> GetIncomingFriendRequests(long cursor);	

		TwitterCursorList<int> GetOutgoingFriendRequests();	

		TwitterCursorList<int> GetOutgoingFriendRequests(long cursor);	

		TwitterFriendship GetFriendshipInfo(string sourceScreenName, string targetScreenName);	

		TwitterFriendship GetFriendshipInfo(int sourceId, int targetId);	

		TwitterList CreateList(string listOwner, string name);	

		TwitterList CreateList(string listOwner, string name, string description);	

		TwitterList CreateList(string listOwner, string name, string description, string mode);	

		TwitterCursorList<TwitterList> ListListsFor(string screenName, long cursor);	

		TwitterList GetList(string ownerScreenName, string slug);	

		TwitterList DeleteList(long listId);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string ownerScreenName, string slug);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string ownerScreenName, string slug, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnList(string ownerScreenName, string slug, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int page, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int perPage);	

		IEnumerable<TwitterStatus> ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int page, int perPage);	

		TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor);	

		TwitterCursorList<TwitterUser> ListListMembers(string ownerScreenName, string slug, long cursor);	

		TwitterUser AddListMember(string ownerScreenName, string slug, string screenName);	

		TwitterUser RemoveListMember(string ownerScreenName, string slug, string screenName);	

		TwitterUser VerifyListMembership(string ownerScreenName, string slug, string screenName);	

		IEnumerable<TwitterList> ListListSubscriptionsFor(string screenName);	

		TwitterCursorList<TwitterUser> ListListSubscribers(string ownerScreenName, string slug, long cursor);	

		TwitterUser FollowList(string ownerScreenName, string slug);	

		TwitterUser UnfollowList(string ownerScreenName, string slug);	

		TwitterUser VerifyListSubscription(string ownerScreenName, string slug, string screenName);	

		TwitterUser FollowUserNotifications(string screenName);	

		TwitterUser FollowUserNotifications(int userId);	

		TwitterUser UnfollowUserNotifications(int userId);	

		TwitterUser UnfollowUserNotifications(string userScreenName);	

		IEnumerable<TwitterSavedSearch> ListSavedSearches();	

		TwitterSavedSearch GetSavedSearch(long id);	

		TwitterSavedSearch CreateSavedSearch(string query);	

		TwitterSavedSearch DeleteSavedSearch(long id);	

		TwitterSearchResult Search(string q);	

		TwitterSearchResult Search(string q, TwitterSearchResultType resultType);	

		TwitterSearchResult Search(string q, int rpp);	

		TwitterSearchResult Search(string q, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult Search(string q, int page, int rpp);	

		TwitterSearchResult Search(string q, int page, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchSince(long since_id, string q);	

		TwitterSearchResult SearchSince(long since_id, string q, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchSince(long since_id, string q, int rpp);	

		TwitterSearchResult SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchSince(long since_id, string q, int page, int rpp);	

		TwitterSearchResult SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchBefore(long max_id, string q);	

		TwitterSearchResult SearchBefore(long max_id, string q, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchBefore(long max_id, string q, int rpp);	

		TwitterSearchResult SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType);	

		TwitterSearchResult SearchBefore(long max_id, string q, int page, int rpp);	

		TwitterSearchResult SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType);	

		IEnumerable<TwitterStatus> ListTweetsOnPublicTimeline();	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline();	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimeline();	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimeline(int count);	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimeline(int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineSince(long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineBefore(long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline();	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page);	

		IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMe();	

		IEnumerable<TwitterStatus> ListTweetsMentioningMe(int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMe(int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMe();	

		IEnumerable<TwitterStatus> ListRetweetsByMe(int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMe(int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMe(long sinceId);	

		IEnumerable<TwitterStatus> ListRetweetsByMeSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMeSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId);	

		IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMe();	

		IEnumerable<TwitterStatus> ListRetweetsToMe(int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMe(int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId);	

		IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId);	

		IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets();	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(long sinceId);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long sinceId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long sinceId, int page, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long maxId);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsBefore(long maxId, int count);	

		IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsBefore(long maxId, int page, int count);	

		TwitterTrends ListCurrentTrends();	

		TwitterTrends ListCurrentTrends(string exclude);	

		TwitterTrends ListDailyTrends();	

		TwitterTrends ListDailyTrends(DateTime date);	

		TwitterTrends ListDailyTrends(string exclude);	

		TwitterTrends ListDailyTrends(DateTime date, string exclude);	

		TwitterTrends ListWeeklyTrends();	

		TwitterTrends ListWeeklyTrends(DateTime date);	

		TwitterTrends ListWeeklyTrends(string exclude);	

		TwitterTrends ListWeeklyTrends(DateTime date, string exclude);	

		IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations();	

		IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations(double lat);	

		IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations(double lat, double @long);	

		TwitterLocalTrends ListLocalTrendsFor(long woeId);	

		TwitterStatus GetTweet(long id);	

		TwitterStatus SendTweet(string status);	

		TwitterStatus SendTweet(string status, double lat, double @long);	

		TwitterStatus SendTweet(string status, long inReplyToStatusId);	

		TwitterStatus SendTweet(string status, long inReplyToStatusId, double lat, double @long);	

		TwitterStatus DeleteTweet(long id);	

		TwitterStatus Retweet(long id);	

		IEnumerable<TwitterStatus> Retweets(long id);	

		IEnumerable<TwitterStatus> Retweets(long id, int count);	

		IEnumerable<TwitterUser> ListUsersWhoRetweeted(long id);	

		IEnumerable<TwitterUser> ListUsersWhoRetweeted(long id, int count);	

		IEnumerable<int> ListUserIdsWhoRetweeted(long id);	

		IEnumerable<int> ListUserIdsWhoRetweeted(long id, int count);	

		TwitterCursorList<TwitterUser> ListFriends();	

		TwitterCursorList<TwitterUser> ListFriends(long cursor);	

		TwitterCursorList<TwitterUser> ListFriendsOf(int userId);	

		TwitterCursorList<TwitterUser> ListFriendsOf(int userId, long cursor);	

		TwitterCursorList<TwitterUser> ListFriendsOf(string screenName);	

		TwitterCursorList<TwitterUser> ListFriendsOf(string screenName, long cursor);	

		TwitterCursorList<TwitterUser> ListFollowers();	

		TwitterCursorList<TwitterUser> ListFollowers(long cursor);	

		TwitterCursorList<TwitterUser> ListFollowersOf(int userId);	

		TwitterCursorList<TwitterUser> ListFollowersOf(int userId, long cursor);	

		TwitterCursorList<TwitterUser> ListFollowersOf(string screenName);	

		TwitterCursorList<TwitterUser> ListFollowersOf(string screenName, long cursor);	

		TwitterUser GetUserProfile();	

		TwitterUser GetUserProfileFor(string screenName);	

		TwitterUser GetUserProfileFor(int id);	

		IEnumerable<TwitterUser> SearchForUser(string q);	

		IEnumerable<TwitterUser> SearchForUser(string q, int perPage);	

		IEnumerable<TwitterUser> SearchForUser(string q, int page, int perPage);	

		IEnumerable<TwitterUser> ListUserProfilesFor(IEnumerable<string> screenName);	

		IEnumerable<TwitterUser> ListUserProfilesFor(IEnumerable<int> userId);	

		IEnumerable<TwitterUser> ListUserProfilesFor(IEnumerable<string> screenName, IEnumerable<int> userId);	

		byte[] GetProfileImageFor(string screenName);	

		byte[] GetProfileImageFor(string screenName, TwitterProfileImageSize size);	

		IEnumerable<TwitterUserSuggestions> ListSuggestedUserCategories();	

		TwitterUserSuggestions ListSuggestedUsers(string categorySlug);	

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with IAsyncResult)
		IAsyncResult VerifyCredentials(Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetRateLimitStatus(Action<TwitterRateLimitStatus, TwitterResponse> action);		

		IAsyncResult EndSession(Action<TwitterError, TwitterResponse> action);		

		IAsyncResult UpdateDeliveryDevice(TwitterDeliveryDevice device, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileImage(string path, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfileBackgroundImage(string path, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UpdateProfile(string name, string description, string email, string url, string location, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult BlockUser(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult BlockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnblockUser(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnblockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyBlocking(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyBlocking(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult ListBlockedUsers(Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListBlockedUsers(int page, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListBlockedUserIds(Action<IEnumerable<int>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceived(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceived(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceived(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesReceivedBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSent(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSent(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSent(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult ListDirectMessagesSentBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);		

		IAsyncResult DeleteDirectMessage(long id, Action<TwitterDirectMessage, TwitterResponse> action);		

		IAsyncResult DeleteDirectMessage(int id, Action<TwitterDirectMessage, TwitterResponse> action);		

		IAsyncResult SendDirectMessage(int userId, string text, Action<TwitterDirectMessage, TwitterResponse> action);		

		IAsyncResult SendDirectMessage(string screenName, string text, Action<TwitterDirectMessage, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweets(int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(int userId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(string userScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(string userScreenName, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListFavoriteTweetsFor(string userScreenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult FavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult UnfavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult ListFriendIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult ListFriendIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult ListFollowerIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult ListFollowerIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult FollowUser(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult FollowUser(string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowUser(string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowUser(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetIncomingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult GetIncomingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult GetOutgoingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult GetOutgoingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);		

		IAsyncResult GetFriendshipInfo(string sourceScreenName, string targetScreenName, Action<TwitterFriendship, TwitterResponse> action);		

		IAsyncResult GetFriendshipInfo(int sourceId, int targetId, Action<TwitterFriendship, TwitterResponse> action);		

		IAsyncResult CreateList(string listOwner, string name, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult CreateList(string listOwner, string name, string description, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult CreateList(string listOwner, string name, string description, string mode, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult ListListsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult GetList(string ownerScreenName, string slug, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult DeleteList(long listId, Action<TwitterList, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string ownerScreenName, string slug, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string ownerScreenName, string slug, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnList(string ownerScreenName, string slug, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListMembers(string ownerScreenName, string slug, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult AddListMember(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult RemoveListMember(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListMembership(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult ListListSubscriptionsFor(string screenName, Action<IEnumerable<TwitterList>, TwitterResponse> action);		

		IAsyncResult ListListSubscribers(string ownerScreenName, string slug, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult FollowList(string ownerScreenName, string slug, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowList(string ownerScreenName, string slug, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult VerifyListSubscription(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult FollowUserNotifications(string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult FollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult UnfollowUserNotifications(string userScreenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse> action);		

		IAsyncResult GetSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action);		

		IAsyncResult CreateSavedSearch(string query, Action<TwitterSavedSearch, TwitterResponse> action);		

		IAsyncResult DeleteSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action);		

		IAsyncResult Search(string q, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult Search(string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);		

		IAsyncResult ListTweetsOnPublicTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnFriendsTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListTweetsMentioningMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMe(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsByMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsToMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweets(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweets(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsSince(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListRetweetsOfMyTweetsBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListCurrentTrends(Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListCurrentTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListDailyTrends(Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListDailyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListDailyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListDailyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListWeeklyTrends(Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListWeeklyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListWeeklyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListWeeklyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action);		

		IAsyncResult ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);		

		IAsyncResult ListAvailableTrendsLocations(double lat, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);		

		IAsyncResult ListAvailableTrendsLocations(double lat, double @long, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);		

		IAsyncResult ListLocalTrendsFor(long woeId, Action<TwitterLocalTrends, TwitterResponse> action);		

		IAsyncResult GetTweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult SendTweet(string status, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult SendTweet(string status, double lat, double @long, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult SendTweet(string status, long inReplyToStatusId, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult SendTweet(string status, long inReplyToStatusId, double lat, double @long, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult DeleteTweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult Retweet(long id, Action<TwitterStatus, TwitterResponse> action);		

		IAsyncResult Retweets(long id, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult Retweets(long id, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);		

		IAsyncResult ListUsersWhoRetweeted(long id, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListUsersWhoRetweeted(long id, int count, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListUserIdsWhoRetweeted(long id, Action<IEnumerable<int>, TwitterResponse> action);		

		IAsyncResult ListUserIdsWhoRetweeted(long id, int count, Action<IEnumerable<int>, TwitterResponse> action);		

		IAsyncResult ListFriends(Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFriends(long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFriendsOf(int userId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFriendsOf(int userId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFriendsOf(string screenName, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFriendsOf(string screenName, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFollowers(Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFollowers(long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFollowersOf(int userId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFollowersOf(int userId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFollowersOf(string screenName, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListFollowersOf(string screenName, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);		

		IAsyncResult GetUserProfile(Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetUserProfileFor(string screenName, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult GetUserProfileFor(int id, Action<TwitterUser, TwitterResponse> action);		

		IAsyncResult SearchForUser(string q, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult SearchForUser(string q, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult SearchForUser(string q, int page, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListUserProfilesFor(IEnumerable<string> screenName, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListUserProfilesFor(IEnumerable<int> userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult ListUserProfilesFor(IEnumerable<string> screenName, IEnumerable<int> userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action);		

		IAsyncResult GetProfileImageFor(string screenName, Action<byte[], TwitterResponse> action);		

		IAsyncResult GetProfileImageFor(string screenName, TwitterProfileImageSize size, Action<byte[], TwitterResponse> action);		

		IAsyncResult ListSuggestedUserCategories(Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse> action);		

		IAsyncResult ListSuggestedUsers(string categorySlug, Action<TwitterUserSuggestions, TwitterResponse> action);		

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with Begin/End pattern)
		IAsyncResult BeginVerifyCredentials();

		TwitterUser EndVerifyCredentials(IAsyncResult result);		

		TwitterUser EndVerifyCredentials(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetRateLimitStatus();

		TwitterRateLimitStatus EndGetRateLimitStatus(IAsyncResult result);		

		TwitterRateLimitStatus EndGetRateLimitStatus(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginEndSession();

		TwitterError EndEndSession(IAsyncResult result);		

		TwitterError EndEndSession(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateDeliveryDevice();

		TwitterUser EndUpdateDeliveryDevice(IAsyncResult result);		

		TwitterUser EndUpdateDeliveryDevice(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateProfileColors();

		TwitterUser EndUpdateProfileColors(IAsyncResult result);		

		TwitterUser EndUpdateProfileColors(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateProfileImage();

		TwitterUser EndUpdateProfileImage(IAsyncResult result);		

		TwitterUser EndUpdateProfileImage(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateProfileBackgroundImage();

		TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result);		

		TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUpdateProfile();

		TwitterUser EndUpdateProfile(IAsyncResult result);		

		TwitterUser EndUpdateProfile(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginBlockUser();

		TwitterUser EndBlockUser(IAsyncResult result);		

		TwitterUser EndBlockUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnblockUser();

		TwitterUser EndUnblockUser(IAsyncResult result);		

		TwitterUser EndUnblockUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginVerifyBlocking();

		TwitterUser EndVerifyBlocking(IAsyncResult result);		

		TwitterUser EndVerifyBlocking(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListBlockedUsers();

		IEnumerable<TwitterUser> EndListBlockedUsers(IAsyncResult result);		

		IEnumerable<TwitterUser> EndListBlockedUsers(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListBlockedUserIds();

		IEnumerable<int> EndListBlockedUserIds(IAsyncResult result);		

		IEnumerable<int> EndListBlockedUserIds(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesReceived();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesReceivedSince();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedSince(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesReceivedBefore();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedBefore(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesSent();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesSentSince();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentSince(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDirectMessagesSentBefore();

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentBefore(IAsyncResult result);		

		IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginDeleteDirectMessage();

		TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result);		

		TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSendDirectMessage();

		TwitterDirectMessage EndSendDirectMessage(IAsyncResult result);		

		TwitterDirectMessage EndSendDirectMessage(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFavoriteTweets();

		IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFavoriteTweetsFor();

		IEnumerable<TwitterStatus> EndListFavoriteTweetsFor(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListFavoriteTweetsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginFavoriteTweet();

		TwitterStatus EndFavoriteTweet(IAsyncResult result);		

		TwitterStatus EndFavoriteTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnfavoriteTweet();

		TwitterStatus EndUnfavoriteTweet(IAsyncResult result);		

		TwitterStatus EndUnfavoriteTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFriendIdsOf();

		TwitterCursorList<int> EndListFriendIdsOf(IAsyncResult result);		

		TwitterCursorList<int> EndListFriendIdsOf(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFollowerIdsOf();

		TwitterCursorList<int> EndListFollowerIdsOf(IAsyncResult result);		

		TwitterCursorList<int> EndListFollowerIdsOf(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginFollowUser();

		TwitterUser EndFollowUser(IAsyncResult result);		

		TwitterUser EndFollowUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnfollowUser();

		TwitterUser EndUnfollowUser(IAsyncResult result);		

		TwitterUser EndUnfollowUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetIncomingFriendRequests();

		TwitterCursorList<int> EndGetIncomingFriendRequests(IAsyncResult result);		

		TwitterCursorList<int> EndGetIncomingFriendRequests(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetOutgoingFriendRequests();

		TwitterCursorList<int> EndGetOutgoingFriendRequests(IAsyncResult result);		

		TwitterCursorList<int> EndGetOutgoingFriendRequests(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetFriendshipInfo();

		TwitterFriendship EndGetFriendshipInfo(IAsyncResult result);		

		TwitterFriendship EndGetFriendshipInfo(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginCreateList();

		TwitterList EndCreateList(IAsyncResult result);		

		TwitterList EndCreateList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListsFor();

		TwitterCursorList<TwitterList> EndListListsFor(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListListsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetList();

		TwitterList EndGetList(IAsyncResult result);		

		TwitterList EndGetList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginDeleteList();

		TwitterList EndDeleteList(IAsyncResult result);		

		TwitterList EndDeleteList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnList();

		IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnListSince();

		IEnumerable<TwitterStatus> EndListTweetsOnListSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnListSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnListBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnListBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnListBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListMembershipsFor();

		TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result);		

		TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListMembers();

		TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginAddListMember();

		TwitterUser EndAddListMember(IAsyncResult result);		

		TwitterUser EndAddListMember(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginRemoveListMember();

		TwitterUser EndRemoveListMember(IAsyncResult result);		

		TwitterUser EndRemoveListMember(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginVerifyListMembership();

		TwitterUser EndVerifyListMembership(IAsyncResult result);		

		TwitterUser EndVerifyListMembership(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListSubscriptionsFor();

		IEnumerable<TwitterList> EndListListSubscriptionsFor(IAsyncResult result);		

		IEnumerable<TwitterList> EndListListSubscriptionsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListListSubscribers();

		TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginFollowList();

		TwitterUser EndFollowList(IAsyncResult result);		

		TwitterUser EndFollowList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnfollowList();

		TwitterUser EndUnfollowList(IAsyncResult result);		

		TwitterUser EndUnfollowList(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginVerifyListSubscription();

		TwitterUser EndVerifyListSubscription(IAsyncResult result);		

		TwitterUser EndVerifyListSubscription(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginFollowUserNotifications();

		TwitterUser EndFollowUserNotifications(IAsyncResult result);		

		TwitterUser EndFollowUserNotifications(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginUnfollowUserNotifications();

		TwitterUser EndUnfollowUserNotifications(IAsyncResult result);		

		TwitterUser EndUnfollowUserNotifications(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListSavedSearches();

		IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result);		

		IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetSavedSearch();

		TwitterSavedSearch EndGetSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndGetSavedSearch(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginCreateSavedSearch();

		TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginDeleteSavedSearch();

		TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result);		

		TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSearch();

		TwitterSearchResult EndSearch(IAsyncResult result);		

		TwitterSearchResult EndSearch(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSearchSince();

		TwitterSearchResult EndSearchSince(IAsyncResult result);		

		TwitterSearchResult EndSearchSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSearchBefore();

		TwitterSearchResult EndSearchBefore(IAsyncResult result);		

		TwitterSearchResult EndSearchBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnPublicTimeline();

		IEnumerable<TwitterStatus> EndListTweetsOnPublicTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnPublicTimeline(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnHomeTimeline();

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnHomeTimelineSince();

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnHomeTimelineBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnFriendsTimeline();

		IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimeline(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnFriendsTimelineSince();

		IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimelineSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimelineSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnFriendsTimelineBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimelineBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimelineBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnUserTimeline();

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnUserTimelineSince();

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnUserTimelineBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnSpecifiedUserTimeline();

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimeline(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimeline(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince();

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore();

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsMentioningMe();

		IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsMentioningMeSince();

		IEnumerable<TwitterStatus> EndListTweetsMentioningMeSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsMentioningMeSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListTweetsMentioningMeBefore();

		IEnumerable<TwitterStatus> EndListTweetsMentioningMeBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListTweetsMentioningMeBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsByMe();

		IEnumerable<TwitterStatus> EndListRetweetsByMe(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsByMe(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsByMeSince();

		IEnumerable<TwitterStatus> EndListRetweetsByMeSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsByMeSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsByMeBefore();

		IEnumerable<TwitterStatus> EndListRetweetsByMeBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsByMeBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsToMe();

		IEnumerable<TwitterStatus> EndListRetweetsToMe(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsToMe(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsToMeSince();

		IEnumerable<TwitterStatus> EndListRetweetsToMeSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsToMeSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsToMeBefore();

		IEnumerable<TwitterStatus> EndListRetweetsToMeBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsToMeBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsOfMyTweets();

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsOfMyTweetsSince();

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsSince(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsSince(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListRetweetsOfMyTweetsBefore();

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsBefore(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsBefore(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListCurrentTrends();

		TwitterTrends EndListCurrentTrends(IAsyncResult result);		

		TwitterTrends EndListCurrentTrends(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListDailyTrends();

		TwitterTrends EndListDailyTrends(IAsyncResult result);		

		TwitterTrends EndListDailyTrends(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListWeeklyTrends();

		TwitterTrends EndListWeeklyTrends(IAsyncResult result);		

		TwitterTrends EndListWeeklyTrends(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListAvailableTrendsLocations();

		IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result);		

		IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListLocalTrendsFor();

		TwitterLocalTrends EndListLocalTrendsFor(IAsyncResult result);		

		TwitterLocalTrends EndListLocalTrendsFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetTweet();

		TwitterStatus EndGetTweet(IAsyncResult result);		

		TwitterStatus EndGetTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSendTweet();

		TwitterStatus EndSendTweet(IAsyncResult result);		

		TwitterStatus EndSendTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginDeleteTweet();

		TwitterStatus EndDeleteTweet(IAsyncResult result);		

		TwitterStatus EndDeleteTweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginRetweet();

		TwitterStatus EndRetweet(IAsyncResult result);		

		TwitterStatus EndRetweet(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginRetweets();

		IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result);		

		IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListUsersWhoRetweeted();

		IEnumerable<TwitterUser> EndListUsersWhoRetweeted(IAsyncResult result);		

		IEnumerable<TwitterUser> EndListUsersWhoRetweeted(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListUserIdsWhoRetweeted();

		IEnumerable<int> EndListUserIdsWhoRetweeted(IAsyncResult result);		

		IEnumerable<int> EndListUserIdsWhoRetweeted(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFriends();

		TwitterCursorList<TwitterUser> EndListFriends(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListFriends(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFriendsOf();

		TwitterCursorList<TwitterUser> EndListFriendsOf(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListFriendsOf(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFollowers();

		TwitterCursorList<TwitterUser> EndListFollowers(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListFollowers(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListFollowersOf();

		TwitterCursorList<TwitterUser> EndListFollowersOf(IAsyncResult result);		

		TwitterCursorList<TwitterUser> EndListFollowersOf(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetUserProfile();

		TwitterUser EndGetUserProfile(IAsyncResult result);		

		TwitterUser EndGetUserProfile(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetUserProfileFor();

		TwitterUser EndGetUserProfileFor(IAsyncResult result);		

		TwitterUser EndGetUserProfileFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginSearchForUser();

		IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result);		

		IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListUserProfilesFor();

		IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result);		

		IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginGetProfileImageFor();

		byte[] EndGetProfileImageFor(IAsyncResult result);		

		byte[] EndGetProfileImageFor(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListSuggestedUserCategories();

		IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result);		

		IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result, TimeSpan timeout);

		IAsyncResult BeginListSuggestedUsers();

		TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result);		

		TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result, TimeSpan timeout);

		#endregion
#endif
	
#if WINDOWS_PHONE
		#region Asynchronous Methods (without IAsyncResult)
		void VerifyCredentials(Action<TwitterUser, TwitterResponse> action);

		void GetRateLimitStatus(Action<TwitterRateLimitStatus, TwitterResponse> action);

		void EndSession(Action<TwitterError, TwitterResponse> action);

		void UpdateDeliveryDevice(TwitterDeliveryDevice device, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, string textColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileImage(string path, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfileBackgroundImage(string path, Action<TwitterUser, TwitterResponse> action);

		void UpdateProfile(string name, string description, string email, string url, string location, Action<TwitterUser, TwitterResponse> action);

		void BlockUser(int userId, Action<TwitterUser, TwitterResponse> action);

		void BlockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void UnblockUser(int userId, Action<TwitterUser, TwitterResponse> action);

		void UnblockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyBlocking(int userId, Action<TwitterUser, TwitterResponse> action);

		void VerifyBlocking(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void ListBlockedUsers(Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListBlockedUsers(int page, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListBlockedUserIds(Action<IEnumerable<int>, TwitterResponse> action);

		void ListDirectMessagesReceived(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceived(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceived(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesReceivedBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSent(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSent(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSent(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void ListDirectMessagesSentBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action);

		void DeleteDirectMessage(long id, Action<TwitterDirectMessage, TwitterResponse> action);

		void DeleteDirectMessage(int id, Action<TwitterDirectMessage, TwitterResponse> action);

		void SendDirectMessage(int userId, string text, Action<TwitterDirectMessage, TwitterResponse> action);

		void SendDirectMessage(string screenName, string text, Action<TwitterDirectMessage, TwitterResponse> action);

		void ListFavoriteTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweets(int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(int userId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(string userScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(string userScreenName, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListFavoriteTweetsFor(string userScreenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void FavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void UnfavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void ListFriendIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void ListFriendIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void ListFollowerIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void ListFollowerIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void FollowUser(int userId, Action<TwitterUser, TwitterResponse> action);

		void FollowUser(string screenName, Action<TwitterUser, TwitterResponse> action);

		void UnfollowUser(string screenName, Action<TwitterUser, TwitterResponse> action);

		void UnfollowUser(int userId, Action<TwitterUser, TwitterResponse> action);

		void GetIncomingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action);

		void GetIncomingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void GetOutgoingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action);

		void GetOutgoingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action);

		void GetFriendshipInfo(string sourceScreenName, string targetScreenName, Action<TwitterFriendship, TwitterResponse> action);

		void GetFriendshipInfo(int sourceId, int targetId, Action<TwitterFriendship, TwitterResponse> action);

		void CreateList(string listOwner, string name, Action<TwitterList, TwitterResponse> action);

		void CreateList(string listOwner, string name, string description, Action<TwitterList, TwitterResponse> action);

		void CreateList(string listOwner, string name, string description, string mode, Action<TwitterList, TwitterResponse> action);

		void ListListsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void GetList(string ownerScreenName, string slug, Action<TwitterList, TwitterResponse> action);

		void DeleteList(long listId, Action<TwitterList, TwitterResponse> action);

		void ListTweetsOnList(string ownerScreenName, string slug, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string ownerScreenName, string slug, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnList(string ownerScreenName, string slug, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action);

		void ListListMembers(string ownerScreenName, string slug, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void AddListMember(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action);

		void RemoveListMember(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action);

		void VerifyListMembership(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action);

		void ListListSubscriptionsFor(string screenName, Action<IEnumerable<TwitterList>, TwitterResponse> action);

		void ListListSubscribers(string ownerScreenName, string slug, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void FollowList(string ownerScreenName, string slug, Action<TwitterUser, TwitterResponse> action);

		void UnfollowList(string ownerScreenName, string slug, Action<TwitterUser, TwitterResponse> action);

		void VerifyListSubscription(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action);

		void FollowUserNotifications(string screenName, Action<TwitterUser, TwitterResponse> action);

		void FollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action);

		void UnfollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action);

		void UnfollowUserNotifications(string userScreenName, Action<TwitterUser, TwitterResponse> action);

		void ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse> action);

		void GetSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action);

		void CreateSavedSearch(string query, Action<TwitterSavedSearch, TwitterResponse> action);

		void DeleteSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action);

		void Search(string q, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void Search(string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action);

		void SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action);

		void ListTweetsOnPublicTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnFriendsTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnUserTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListTweetsMentioningMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMe(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsByMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsToMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweets(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweets(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsSince(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListRetweetsOfMyTweetsBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListCurrentTrends(Action<TwitterTrends, TwitterResponse> action);

		void ListCurrentTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListDailyTrends(Action<TwitterTrends, TwitterResponse> action);

		void ListDailyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action);

		void ListDailyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListDailyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListWeeklyTrends(Action<TwitterTrends, TwitterResponse> action);

		void ListWeeklyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action);

		void ListWeeklyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListWeeklyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action);

		void ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);

		void ListAvailableTrendsLocations(double lat, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);

		void ListAvailableTrendsLocations(double lat, double @long, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action);

		void ListLocalTrendsFor(long woeId, Action<TwitterLocalTrends, TwitterResponse> action);

		void GetTweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void SendTweet(string status, Action<TwitterStatus, TwitterResponse> action);

		void SendTweet(string status, double lat, double @long, Action<TwitterStatus, TwitterResponse> action);

		void SendTweet(string status, long inReplyToStatusId, Action<TwitterStatus, TwitterResponse> action);

		void SendTweet(string status, long inReplyToStatusId, double lat, double @long, Action<TwitterStatus, TwitterResponse> action);

		void DeleteTweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void Retweet(long id, Action<TwitterStatus, TwitterResponse> action);

		void Retweets(long id, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void Retweets(long id, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action);

		void ListUsersWhoRetweeted(long id, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListUsersWhoRetweeted(long id, int count, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListUserIdsWhoRetweeted(long id, Action<IEnumerable<int>, TwitterResponse> action);

		void ListUserIdsWhoRetweeted(long id, int count, Action<IEnumerable<int>, TwitterResponse> action);

		void ListFriends(Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFriends(long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFriendsOf(int userId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFriendsOf(int userId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFriendsOf(string screenName, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFriendsOf(string screenName, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFollowers(Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFollowers(long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFollowersOf(int userId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFollowersOf(int userId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFollowersOf(string screenName, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void ListFollowersOf(string screenName, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action);

		void GetUserProfile(Action<TwitterUser, TwitterResponse> action);

		void GetUserProfileFor(string screenName, Action<TwitterUser, TwitterResponse> action);

		void GetUserProfileFor(int id, Action<TwitterUser, TwitterResponse> action);

		void SearchForUser(string q, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void SearchForUser(string q, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void SearchForUser(string q, int page, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListUserProfilesFor(IEnumerable<string> screenName, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListUserProfilesFor(IEnumerable<int> userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void ListUserProfilesFor(IEnumerable<string> screenName, IEnumerable<int> userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action);

		void GetProfileImageFor(string screenName, Action<byte[], TwitterResponse> action);

		void GetProfileImageFor(string screenName, TwitterProfileImageSize size, Action<byte[], TwitterResponse> action);

		void ListSuggestedUserCategories(Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse> action);

		void ListSuggestedUsers(string categorySlug, Action<TwitterUserSuggestions, TwitterResponse> action);

		#endregion
#endif		
	}
#endregion
}

namespace TweetSharp
{
#region Implementation
	public partial class TwitterService
	{	
#if !SILVERLIGHT
		#region Sequential Methods
		public virtual TwitterUser VerifyCredentials()
		{
			return WithHammock<TwitterUser>("account/verify_credentials", FormatAsString);
		}

		public virtual TwitterRateLimitStatus GetRateLimitStatus()
		{
			return WithHammock<TwitterRateLimitStatus>("account/rate_limit_status", FormatAsString);
		}

		public virtual TwitterError EndSession()
		{
			return WithHammock<TwitterError>(WebMethod.Post, "account/end_session", FormatAsString);
		}

		public virtual TwitterUser UpdateDeliveryDevice(TwitterDeliveryDevice device)
		{
			return WithHammock<TwitterUser>("account/update_delivery_device", FormatAsString, "?device=", device);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor, "&sidebar_border_color=", sidebarBorderColor);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor, string textColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor);
		}

		public virtual TwitterUser UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor);
		}

		public virtual TwitterUser UpdateProfileImage(string path)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_image", FormatAsString, "?path=", path);
		}

		public virtual TwitterUser UpdateProfileBackgroundImage(string path)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_background_image", FormatAsString, "?path=", path);
		}

		public virtual TwitterUser UpdateProfile(string name, string description, string email, string url, string location)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "account/update_profile", FormatAsString, "?name=", name, "&description=", description, "&email=", email, "&url=", url, "&location=", location);
		}

		public virtual TwitterUser BlockUser(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "blocks/create", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser BlockUser(string userScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "blocks/create", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual TwitterUser UnblockUser(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Delete, "blocks/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser UnblockUser(string userScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Delete, "blocks/destroy", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual TwitterUser VerifyBlocking(int userId)
		{
			return WithHammock<TwitterUser>("blocks/exists", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser VerifyBlocking(string userScreenName)
		{
			return WithHammock<TwitterUser>("blocks/exists", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IEnumerable<TwitterUser> ListBlockedUsers()
		{
			return WithHammock<IEnumerable<TwitterUser>>("blocks/blocking", FormatAsString);
		}

		public virtual IEnumerable<TwitterUser> ListBlockedUsers(int page)
		{
			return WithHammock<IEnumerable<TwitterUser>>("blocks/blocking", FormatAsString, "?page=", page);
		}

		public virtual IEnumerable<int> ListBlockedUserIds()
		{
			return WithHammock<IEnumerable<int>>("blocks/blocking/ids", FormatAsString);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived()
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceived(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesReceivedBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSent()
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSent(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterDirectMessage> ListDirectMessagesSentBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterDirectMessage>>("direct_messages/sent", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual TwitterDirectMessage DeleteDirectMessage(long id)
		{
			return WithHammock<TwitterDirectMessage>(WebMethod.Delete, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterDirectMessage DeleteDirectMessage(int id)
		{
			return WithHammock<TwitterDirectMessage>(WebMethod.Delete, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterDirectMessage SendDirectMessage(int userId, string text)
		{
			return WithHammock<TwitterDirectMessage>(WebMethod.Post, "direct_messages/new", FormatAsString, "?user_id=", userId, "&text=", text);
		}

		public virtual TwitterDirectMessage SendDirectMessage(string screenName, string text)
		{
			return WithHammock<TwitterDirectMessage>(WebMethod.Post, "direct_messages/new", FormatAsString, "?screen_name=", screenName, "&text=", text);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweets()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweets(int page)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites", FormatAsString, "?page=", page);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweets(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_id=", userId);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId, int page)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(int userId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName, int page)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page);
		}

		public virtual IEnumerable<TwitterStatus> ListFavoriteTweetsFor(string userScreenName, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page, "&count=", count);
		}

		public virtual TwitterStatus FavoriteTweet(long id)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "favorites/create/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterStatus UnfavoriteTweet(long id)
		{
			return WithHammock<TwitterStatus>(WebMethod.Delete, "favorites/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterCursorList<int> ListFriendIdsOf(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("friends/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<int> ListFriendIdsOf(int userId, long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("friends/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<int> ListFollowerIdsOf(int userId, long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("followers/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<int> ListFollowerIdsOf(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("followers/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterUser FollowUser(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "friendships/create", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser FollowUser(string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "friendships/create", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterUser UnfollowUser(string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Delete, "friendships/destroy", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterUser UnfollowUser(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Delete, "friendships/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterCursorList<int> GetIncomingFriendRequests()
		{
			return WithHammock<TwitterCursorList<int>>("friendships/incoming", FormatAsString);
		}

		public virtual TwitterCursorList<int> GetIncomingFriendRequests(long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

		public virtual TwitterCursorList<int> GetOutgoingFriendRequests()
		{
			return WithHammock<TwitterCursorList<int>>("friendships/outgoing", FormatAsString);
		}

		public virtual TwitterCursorList<int> GetOutgoingFriendRequests(long cursor)
		{
			return WithHammock<TwitterCursorList<int>>("friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

		public virtual TwitterFriendship GetFriendshipInfo(string sourceScreenName, string targetScreenName)
		{
			return WithHammock<TwitterFriendship>("friendships/show", FormatAsString, "?source_screen_name=", sourceScreenName, "&target_screen_name=", targetScreenName);
		}

		public virtual TwitterFriendship GetFriendshipInfo(int sourceId, int targetId)
		{
			return WithHammock<TwitterFriendship>("friendships/show", FormatAsString, "?source_id=", sourceId, "&target_id=", targetId);
		}

		public virtual TwitterList CreateList(string listOwner, string name)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name);
		}

		public virtual TwitterList CreateList(string listOwner, string name, string description)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name, "&description=", description);
		}

		public virtual TwitterList CreateList(string listOwner, string name, string description, string mode)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual TwitterCursorList<TwitterList> ListListsFor(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterList GetList(string ownerScreenName, string slug)
		{
			return WithHammock<TwitterList>("lists/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual TwitterList DeleteList(long listId)
		{
			return WithHammock<TwitterList>(WebMethod.Post, "lists/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string ownerScreenName, string slug)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string ownerScreenName, string slug, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnList(string ownerScreenName, string slug, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual TwitterCursorList<TwitterList> ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterList>>("lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListListMembers(string ownerScreenName, string slug, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/members", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&cursor=", cursor);
		}

		public virtual TwitterUser AddListMember(string ownerScreenName, string slug, string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual TwitterUser RemoveListMember(string ownerScreenName, string slug, string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual TwitterUser VerifyListMembership(string ownerScreenName, string slug, string screenName)
		{
			return WithHammock<TwitterUser>("lists/members/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IEnumerable<TwitterList> ListListSubscriptionsFor(string screenName)
		{
			return WithHammock<IEnumerable<TwitterList>>("lists/all", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterUser> ListListSubscribers(string ownerScreenName, string slug, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("lists/subscribers", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&cursor=", cursor);
		}

		public virtual TwitterUser FollowList(string ownerScreenName, string slug)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual TwitterUser UnfollowList(string ownerScreenName, string slug)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/destroy", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual TwitterUser VerifyListSubscription(string ownerScreenName, string slug, string screenName)
		{
			return WithHammock<TwitterUser>("lists/subscribers/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual TwitterUser FollowUserNotifications(string screenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "users/notifications/follow", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterUser FollowUserNotifications(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "users/notifications/follow", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser UnfollowUserNotifications(int userId)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "users/notifications/leave", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterUser UnfollowUserNotifications(string userScreenName)
		{
			return WithHammock<TwitterUser>(WebMethod.Post, "users/notifications/leave", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IEnumerable<TwitterSavedSearch> ListSavedSearches()
		{
			return WithHammock<IEnumerable<TwitterSavedSearch>>("saved_searches", FormatAsString);
		}

		public virtual TwitterSavedSearch GetSavedSearch(long id)
		{
			return WithHammock<TwitterSavedSearch>("saved_searches/show", FormatAsString, "?id=", id);
		}

		public virtual TwitterSavedSearch CreateSavedSearch(string query)
		{
			return WithHammock<TwitterSavedSearch>(WebMethod.Post, "saved_searches/create", FormatAsString, "?query=", query);
		}

		public virtual TwitterSavedSearch DeleteSavedSearch(long id)
		{
			return WithHammock<TwitterSavedSearch>(WebMethod.Delete, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterSearchResult Search(string q)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q);
		}

		public virtual TwitterSearchResult Search(string q, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult Search(string q, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult Search(string q, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult Search(string q, int page, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult Search(string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, int page, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, int page, int rpp)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual TwitterSearchResult SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return WithHammock<TwitterSearchResult>("search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnPublicTimeline()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/public_timeline", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnHomeTimelineBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimeline()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimeline(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimeline(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnFriendsTimelineBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/friends_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimeline(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnUserTimelineBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMe()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMe(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMe(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListTweetsMentioningMeBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/mentions", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMe()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMe(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMe(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMe(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsByMeBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMe()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMe(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMe(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsToMeBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets()
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweets(long sinceId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long sinceId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long sinceId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsSince(long maxId)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsBefore(long maxId, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IEnumerable<TwitterStatus> ListRetweetsOfMyTweetsBefore(long maxId, int page, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual TwitterTrends ListCurrentTrends()
		{
			return WithHammock<TwitterTrends>("trends/current", FormatAsString);
		}

		public virtual TwitterTrends ListCurrentTrends(string exclude)
		{
			return WithHammock<TwitterTrends>("trends/current", FormatAsString, "?exclude=", exclude);
		}

		public virtual TwitterTrends ListDailyTrends()
		{
			return WithHammock<TwitterTrends>("trends/daily", FormatAsString);
		}

		public virtual TwitterTrends ListDailyTrends(DateTime date)
		{
			return WithHammock<TwitterTrends>("trends/daily", FormatAsString, "?date=", date);
		}

		public virtual TwitterTrends ListDailyTrends(string exclude)
		{
			return WithHammock<TwitterTrends>("trends/daily", FormatAsString, "?exclude=", exclude);
		}

		public virtual TwitterTrends ListDailyTrends(DateTime date, string exclude)
		{
			return WithHammock<TwitterTrends>("trends/daily", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual TwitterTrends ListWeeklyTrends()
		{
			return WithHammock<TwitterTrends>("trends/weekly", FormatAsString);
		}

		public virtual TwitterTrends ListWeeklyTrends(DateTime date)
		{
			return WithHammock<TwitterTrends>("trends/weekly", FormatAsString, "?date=", date);
		}

		public virtual TwitterTrends ListWeeklyTrends(string exclude)
		{
			return WithHammock<TwitterTrends>("trends/weekly", FormatAsString, "?exclude=", exclude);
		}

		public virtual TwitterTrends ListWeeklyTrends(DateTime date, string exclude)
		{
			return WithHammock<TwitterTrends>("trends/weekly", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations()
		{
			return WithHammock<IEnumerable<WhereOnEarthLocation>>("trends/available", FormatAsString);
		}

		public virtual IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations(double lat)
		{
			return WithHammock<IEnumerable<WhereOnEarthLocation>>("trends/available", FormatAsString, "?lat=", lat);
		}

		public virtual IEnumerable<WhereOnEarthLocation> ListAvailableTrendsLocations(double lat, double @long)
		{
			return WithHammock<IEnumerable<WhereOnEarthLocation>>("trends/available", FormatAsString, "?lat=", lat, "&long=", @long);
		}

		public virtual TwitterLocalTrends ListLocalTrendsFor(long woeId)
		{
			return WithHammock<TwitterLocalTrends>("trends/{woe_id}", FormatAsString, "?woe_id=", woeId);
		}

		public virtual TwitterStatus GetTweet(long id)
		{
			return WithHammock<TwitterStatus>("statuses/show/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterStatus SendTweet(string status)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status);
		}

		public virtual TwitterStatus SendTweet(string status, double lat, double @long)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&lat=", lat, "&long=", @long);
		}

		public virtual TwitterStatus SendTweet(string status, long inReplyToStatusId)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId);
		}

		public virtual TwitterStatus SendTweet(string status, long inReplyToStatusId, double lat, double @long)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId, "&lat=", lat, "&long=", @long);
		}

		public virtual TwitterStatus DeleteTweet(long id)
		{
			return WithHammock<TwitterStatus>(WebMethod.Delete, "statuses/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual TwitterStatus Retweet(long id)
		{
			return WithHammock<TwitterStatus>(WebMethod.Post, "statuses/retweet/{id}", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<TwitterStatus> Retweets(long id)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets/{id}", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<TwitterStatus> Retweets(long id, int count)
		{
			return WithHammock<IEnumerable<TwitterStatus>>("statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IEnumerable<TwitterUser> ListUsersWhoRetweeted(long id)
		{
			return WithHammock<IEnumerable<TwitterUser>>("statuses/{id}/retweeted_by", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<TwitterUser> ListUsersWhoRetweeted(long id, int count)
		{
			return WithHammock<IEnumerable<TwitterUser>>("statuses/{id}/retweeted_by", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IEnumerable<int> ListUserIdsWhoRetweeted(long id)
		{
			return WithHammock<IEnumerable<int>>("statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<int> ListUserIdsWhoRetweeted(long id, int count)
		{
			return WithHammock<IEnumerable<int>>("statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual TwitterCursorList<TwitterUser> ListFriends()
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/friends", FormatAsString);
		}

		public virtual TwitterCursorList<TwitterUser> ListFriends(long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/friends", FormatAsString, "?cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListFriendsOf(int userId)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/friends", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterCursorList<TwitterUser> ListFriendsOf(int userId, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/friends", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListFriendsOf(string screenName)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/friends", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterUser> ListFriendsOf(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/friends", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListFollowers()
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/followers", FormatAsString);
		}

		public virtual TwitterCursorList<TwitterUser> ListFollowers(long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/followers", FormatAsString, "?cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListFollowersOf(int userId)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/followers", FormatAsString, "?user_id=", userId);
		}

		public virtual TwitterCursorList<TwitterUser> ListFollowersOf(int userId, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/followers", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual TwitterCursorList<TwitterUser> ListFollowersOf(string screenName)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/followers", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterCursorList<TwitterUser> ListFollowersOf(string screenName, long cursor)
		{
			return WithHammock<TwitterCursorList<TwitterUser>>("statuses/followers", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual TwitterUser GetUserProfile()
		{
			return WithHammock<TwitterUser>("account/verify_credentials", FormatAsString);
		}

		public virtual TwitterUser GetUserProfileFor(string screenName)
		{
			return WithHammock<TwitterUser>("users/show", FormatAsString, "?screen_name=", screenName);
		}

		public virtual TwitterUser GetUserProfileFor(int id)
		{
			return WithHammock<TwitterUser>("users/show", FormatAsString, "?id=", id);
		}

		public virtual IEnumerable<TwitterUser> SearchForUser(string q)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/search", FormatAsString, "?q=", q);
		}

		public virtual IEnumerable<TwitterUser> SearchForUser(string q, int perPage)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/search", FormatAsString, "?q=", q, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterUser> SearchForUser(string q, int page, int perPage)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/search", FormatAsString, "?q=", q, "&page=", page, "&per_page=", perPage);
		}

		public virtual IEnumerable<TwitterUser> ListUserProfilesFor(IEnumerable<string> screenName)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/lookup", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IEnumerable<TwitterUser> ListUserProfilesFor(IEnumerable<int> userId)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/lookup", FormatAsString, "?user_id=", userId);
		}

		public virtual IEnumerable<TwitterUser> ListUserProfilesFor(IEnumerable<string> screenName, IEnumerable<int> userId)
		{
			return WithHammock<IEnumerable<TwitterUser>>("users/lookup", FormatAsString, "?screen_name=", screenName, "&user_id=", userId);
		}

		public virtual byte[] GetProfileImageFor(string screenName)
		{
			return WithHammock<byte[]>("users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName);
		}

		public virtual byte[] GetProfileImageFor(string screenName, TwitterProfileImageSize size)
		{
			return WithHammock<byte[]>("users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName, "&size=", size);
		}

		public virtual IEnumerable<TwitterUserSuggestions> ListSuggestedUserCategories()
		{
			return WithHammock<IEnumerable<TwitterUserSuggestions>>("users/suggestions", FormatAsString);
		}

		public virtual TwitterUserSuggestions ListSuggestedUsers(string categorySlug)
		{
			return WithHammock<TwitterUserSuggestions>("/users/suggestions/{category_slug}", FormatAsString, "?category_slug=", categorySlug);
		}

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with IAsyncResult)
		public virtual IAsyncResult VerifyCredentials(Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "account/verify_credentials", FormatAsString);
		}

		public virtual IAsyncResult GetRateLimitStatus(Action<TwitterRateLimitStatus, TwitterResponse> action)
		{
			return WithHammock(action, "account/rate_limit_status", FormatAsString);
		}

		public virtual IAsyncResult EndSession(Action<TwitterError, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/end_session", FormatAsString);
		}

		public virtual IAsyncResult UpdateDeliveryDevice(TwitterDeliveryDevice device, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "account/update_delivery_device", FormatAsString, "?device=", device);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor, "&sidebar_border_color=", sidebarBorderColor);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor);
		}

		public virtual IAsyncResult UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor);
		}

		public virtual IAsyncResult UpdateProfileImage(string path, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_image", FormatAsString, "?path=", path);
		}

		public virtual IAsyncResult UpdateProfileBackgroundImage(string path, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile_background_image", FormatAsString, "?path=", path);
		}

		public virtual IAsyncResult UpdateProfile(string name, string description, string email, string url, string location, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "account/update_profile", FormatAsString, "?name=", name, "&description=", description, "&email=", email, "&url=", url, "&location=", location);
		}

		public virtual IAsyncResult BlockUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "blocks/create", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BlockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "blocks/create", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult UnblockUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "blocks/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult UnblockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "blocks/destroy", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult VerifyBlocking(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/exists", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult VerifyBlocking(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/exists", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult ListBlockedUsers(Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/blocking", FormatAsString);
		}

		public virtual IAsyncResult ListBlockedUsers(int page, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/blocking", FormatAsString, "?page=", page);
		}

		public virtual IAsyncResult ListBlockedUserIds(Action<IEnumerable<int>, TwitterResponse> action)
		{
			return WithHammock(action, "blocks/blocking/ids", FormatAsString);
		}

		public virtual IAsyncResult ListDirectMessagesReceived(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString);
		}

		public virtual IAsyncResult ListDirectMessagesReceived(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceived(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesReceivedBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSent(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString);
		}

		public virtual IAsyncResult ListDirectMessagesSent(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSent(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSentSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListDirectMessagesSentSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSentSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSentBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListDirectMessagesSentBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListDirectMessagesSentBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			return WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult DeleteDirectMessage(long id, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult DeleteDirectMessage(int id, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult SendDirectMessage(int userId, string text, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "direct_messages/new", FormatAsString, "?user_id=", userId, "&text=", text);
		}

		public virtual IAsyncResult SendDirectMessage(string screenName, string text, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "direct_messages/new", FormatAsString, "?screen_name=", screenName, "&text=", text);
		}

		public virtual IAsyncResult ListFavoriteTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites", FormatAsString);
		}

		public virtual IAsyncResult ListFavoriteTweets(int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites", FormatAsString, "?page=", page);
		}

		public virtual IAsyncResult ListFavoriteTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(int userId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(string userScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(string userScreenName, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page);
		}

		public virtual IAsyncResult ListFavoriteTweetsFor(string userScreenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult FavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "favorites/create/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult UnfavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "favorites/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult ListFriendIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friends/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFriendIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friends/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFollowerIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "followers/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFollowerIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "followers/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult FollowUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "friendships/create", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult FollowUser(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "friendships/create", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult UnfollowUser(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "friendships/destroy", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult UnfollowUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "friendships/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult GetIncomingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/incoming", FormatAsString);
		}

		public virtual IAsyncResult GetIncomingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult GetOutgoingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/outgoing", FormatAsString);
		}

		public virtual IAsyncResult GetOutgoingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult GetFriendshipInfo(string sourceScreenName, string targetScreenName, Action<TwitterFriendship, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/show", FormatAsString, "?source_screen_name=", sourceScreenName, "&target_screen_name=", targetScreenName);
		}

		public virtual IAsyncResult GetFriendshipInfo(int sourceId, int targetId, Action<TwitterFriendship, TwitterResponse> action)
		{
			return WithHammock(action, "friendships/show", FormatAsString, "?source_id=", sourceId, "&target_id=", targetId);
		}

		public virtual IAsyncResult CreateList(string listOwner, string name, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name);
		}

		public virtual IAsyncResult CreateList(string listOwner, string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name, "&description=", description);
		}

		public virtual IAsyncResult CreateList(string listOwner, string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult ListListsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult GetList(string ownerScreenName, string slug, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(action, "lists/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IAsyncResult DeleteList(long listId, Action<TwitterList, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult ListTweetsOnList(string ownerScreenName, string slug, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IAsyncResult ListTweetsOnList(string ownerScreenName, string slug, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnList(string ownerScreenName, string slug, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListListMembers(string ownerScreenName, string slug, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&cursor=", cursor);
		}

		public virtual IAsyncResult AddListMember(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IAsyncResult RemoveListMember(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IAsyncResult VerifyListMembership(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/members/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IAsyncResult ListListSubscriptionsFor(string screenName, Action<IEnumerable<TwitterList>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/all", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListListSubscribers(string ownerScreenName, string slug, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&cursor=", cursor);
		}

		public virtual IAsyncResult FollowList(string ownerScreenName, string slug, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IAsyncResult UnfollowList(string ownerScreenName, string slug, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "lists/subscribers/destroy", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IAsyncResult VerifyListSubscription(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "lists/subscribers/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IAsyncResult FollowUserNotifications(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "users/notifications/follow", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult FollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "users/notifications/follow", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult UnfollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "users/notifications/leave", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult UnfollowUserNotifications(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "users/notifications/leave", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse> action)
		{
			return WithHammock(action, "saved_searches", FormatAsString);
		}

		public virtual IAsyncResult GetSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			return WithHammock(action, "saved_searches/show", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult CreateSavedSearch(string query, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "saved_searches/create", FormatAsString, "?query=", query);
		}

		public virtual IAsyncResult DeleteSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult Search(string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q);
		}

		public virtual IAsyncResult Search(string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult Search(string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult Search(string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult Search(string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult Search(string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			return WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult ListTweetsOnPublicTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/public_timeline", FormatAsString);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnFriendsTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnUserTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page);
		}

		public virtual IAsyncResult ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString);
		}

		public virtual IAsyncResult ListTweetsMentioningMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListTweetsMentioningMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListTweetsMentioningMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListTweetsMentioningMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString);
		}

		public virtual IAsyncResult ListRetweetsByMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMe(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListRetweetsByMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListRetweetsByMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsByMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString);
		}

		public virtual IAsyncResult ListRetweetsToMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListRetweetsToMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListRetweetsToMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsToMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweets(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweets(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsSince(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult ListRetweetsOfMyTweetsBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult ListCurrentTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/current", FormatAsString);
		}

		public virtual IAsyncResult ListCurrentTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/current", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult ListDailyTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/daily", FormatAsString);
		}

		public virtual IAsyncResult ListDailyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/daily", FormatAsString, "?date=", date);
		}

		public virtual IAsyncResult ListDailyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/daily", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult ListDailyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/daily", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IAsyncResult ListWeeklyTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/weekly", FormatAsString);
		}

		public virtual IAsyncResult ListWeeklyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/weekly", FormatAsString, "?date=", date);
		}

		public virtual IAsyncResult ListWeeklyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/weekly", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult ListWeeklyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/weekly", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IAsyncResult ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			return WithHammock(action, "trends/available", FormatAsString);
		}

		public virtual IAsyncResult ListAvailableTrendsLocations(double lat, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			return WithHammock(action, "trends/available", FormatAsString, "?lat=", lat);
		}

		public virtual IAsyncResult ListAvailableTrendsLocations(double lat, double @long, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			return WithHammock(action, "trends/available", FormatAsString, "?lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult ListLocalTrendsFor(long woeId, Action<TwitterLocalTrends, TwitterResponse> action)
		{
			return WithHammock(action, "trends/{woe_id}", FormatAsString, "?woe_id=", woeId);
		}

		public virtual IAsyncResult GetTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/show/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult SendTweet(string status, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status);
		}

		public virtual IAsyncResult SendTweet(string status, double lat, double @long, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult SendTweet(string status, long inReplyToStatusId, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId);
		}

		public virtual IAsyncResult SendTweet(string status, long inReplyToStatusId, double lat, double @long, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId, "&lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult DeleteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Delete, action, "statuses/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult Retweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			return WithHammock(WebMethod.Post, action, "statuses/retweet/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult Retweets(long id, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult Retweets(long id, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult ListUsersWhoRetweeted(long id, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult ListUsersWhoRetweeted(long id, int count, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult ListUserIdsWhoRetweeted(long id, Action<IEnumerable<int>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult ListUserIdsWhoRetweeted(long id, int count, Action<IEnumerable<int>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult ListFriends(Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends", FormatAsString);
		}

		public virtual IAsyncResult ListFriends(long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult ListFriendsOf(int userId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListFriendsOf(int userId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFriendsOf(string screenName, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListFriendsOf(string screenName, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/friends", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFollowers(Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/followers", FormatAsString);
		}

		public virtual IAsyncResult ListFollowers(long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/followers", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult ListFollowersOf(int userId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/followers", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListFollowersOf(int userId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/followers", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult ListFollowersOf(string screenName, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/followers", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListFollowersOf(string screenName, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "statuses/followers", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult GetUserProfile(Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "account/verify_credentials", FormatAsString);
		}

		public virtual IAsyncResult GetUserProfileFor(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "users/show", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult GetUserProfileFor(int id, Action<TwitterUser, TwitterResponse> action)
		{
			return WithHammock(action, "users/show", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult SearchForUser(string q, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/search", FormatAsString, "?q=", q);
		}

		public virtual IAsyncResult SearchForUser(string q, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/search", FormatAsString, "?q=", q, "&per_page=", perPage);
		}

		public virtual IAsyncResult SearchForUser(string q, int page, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/search", FormatAsString, "?q=", q, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult ListUserProfilesFor(IEnumerable<string> screenName, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/lookup", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult ListUserProfilesFor(IEnumerable<int> userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/lookup", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult ListUserProfilesFor(IEnumerable<string> screenName, IEnumerable<int> userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			return WithHammock(action, "users/lookup", FormatAsString, "?screen_name=", screenName, "&user_id=", userId);
		}

		public virtual IAsyncResult GetProfileImageFor(string screenName, Action<byte[], TwitterResponse> action)
		{
			return WithHammock(action, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult GetProfileImageFor(string screenName, TwitterProfileImageSize size, Action<byte[], TwitterResponse> action)
		{
			return WithHammock(action, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName, "&size=", size);
		}

		public virtual IAsyncResult ListSuggestedUserCategories(Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse> action)
		{
			return WithHammock(action, "users/suggestions", FormatAsString);
		}

		public virtual IAsyncResult ListSuggestedUsers(string categorySlug, Action<TwitterUserSuggestions, TwitterResponse> action)
		{
			return WithHammock(action, "/users/suggestions/{category_slug}", FormatAsString, "?category_slug=", categorySlug);
		}

		#endregion
#endif

#if !WINDOWS_PHONE
		#region Asynchronous Methods (with Begin/End pattern)
		public virtual IAsyncResult BeginVerifyCredentials()
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "account/verify_credentials", FormatAsString);
		}

		public virtual IAsyncResult BeginGetRateLimitStatus()
		{
			return BeginWithHammock<TwitterRateLimitStatus>(WebMethod.Get, "account/rate_limit_status", FormatAsString);
		}

		public virtual IAsyncResult BeginEndSession()
		{
			return BeginWithHammock<TwitterError>(WebMethod.Post, "account/end_session", FormatAsString);
		}

		public virtual IAsyncResult BeginUpdateDeliveryDevice(TwitterDeliveryDevice device)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "account/update_delivery_device", FormatAsString, "?device=", device);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor, "&sidebar_border_color=", sidebarBorderColor);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor, string textColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor, string textColor, string linkColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor);
		}

		public virtual IAsyncResult BeginUpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor);
		}

		public virtual IAsyncResult BeginUpdateProfileImage(string path)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_image", FormatAsString, "?path=", path);
		}

		public virtual IAsyncResult BeginUpdateProfileBackgroundImage(string path)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile_background_image", FormatAsString, "?path=", path);
		}

		public virtual IAsyncResult BeginUpdateProfile(string name, string description, string email, string url, string location)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "account/update_profile", FormatAsString, "?name=", name, "&description=", description, "&email=", email, "&url=", url, "&location=", location);
		}

		public virtual IAsyncResult BeginBlockUser(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "blocks/create", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginBlockUser(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "blocks/create", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginUnblockUser(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Delete, "blocks/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginUnblockUser(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Delete, "blocks/destroy", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginVerifyBlocking(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "blocks/exists", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginVerifyBlocking(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "blocks/exists", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginListBlockedUsers()
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "blocks/blocking", FormatAsString);
		}

		public virtual IAsyncResult BeginListBlockedUsers(int page)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "blocks/blocking", FormatAsString, "?page=", page);
		}

		public virtual IAsyncResult BeginListBlockedUserIds()
		{
			return BeginWithHammock<IEnumerable<int>>(WebMethod.Get, "blocks/blocking/ids", FormatAsString);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceived()
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceived(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceived(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesReceivedBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSent()
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString);
		}

		public virtual IAsyncResult BeginListDirectMessagesSent(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSent(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListDirectMessagesSentBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterDirectMessage>>(WebMethod.Get, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginDeleteDirectMessage(long id)
		{
			return BeginWithHammock<TwitterDirectMessage>(WebMethod.Delete, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginDeleteDirectMessage(int id)
		{
			return BeginWithHammock<TwitterDirectMessage>(WebMethod.Delete, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginSendDirectMessage(int userId, string text)
		{
			return BeginWithHammock<TwitterDirectMessage>(WebMethod.Post, "direct_messages/new", FormatAsString, "?user_id=", userId, "&text=", text);
		}

		public virtual IAsyncResult BeginSendDirectMessage(string screenName, string text)
		{
			return BeginWithHammock<TwitterDirectMessage>(WebMethod.Post, "direct_messages/new", FormatAsString, "?screen_name=", screenName, "&text=", text);
		}

		public virtual IAsyncResult BeginListFavoriteTweets()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites", FormatAsString);
		}

		public virtual IAsyncResult BeginListFavoriteTweets(int page)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites", FormatAsString, "?page=", page);
		}

		public virtual IAsyncResult BeginListFavoriteTweets(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(int userId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(int userId, int page)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(int userId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(string userScreenName)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(string userScreenName, int page)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page);
		}

		public virtual IAsyncResult BeginListFavoriteTweetsFor(string userScreenName, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginFavoriteTweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "favorites/create/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginUnfavoriteTweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Delete, "favorites/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginListFriendIdsOf(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friends/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFriendIdsOf(int userId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friends/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFollowerIdsOf(int userId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "followers/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFollowerIdsOf(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "followers/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginFollowUser(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "friendships/create", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginFollowUser(string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "friendships/create", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginUnfollowUser(string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Delete, "friendships/destroy", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginUnfollowUser(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Delete, "friendships/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginGetIncomingFriendRequests()
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friendships/incoming", FormatAsString);
		}

		public virtual IAsyncResult BeginGetIncomingFriendRequests(long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult BeginGetOutgoingFriendRequests()
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friendships/outgoing", FormatAsString);
		}

		public virtual IAsyncResult BeginGetOutgoingFriendRequests(long cursor)
		{
			return BeginWithHammock<TwitterCursorList<int>>(WebMethod.Get, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult BeginGetFriendshipInfo(string sourceScreenName, string targetScreenName)
		{
			return BeginWithHammock<TwitterFriendship>(WebMethod.Get, "friendships/show", FormatAsString, "?source_screen_name=", sourceScreenName, "&target_screen_name=", targetScreenName);
		}

		public virtual IAsyncResult BeginGetFriendshipInfo(int sourceId, int targetId)
		{
			return BeginWithHammock<TwitterFriendship>(WebMethod.Get, "friendships/show", FormatAsString, "?source_id=", sourceId, "&target_id=", targetId);
		}

		public virtual IAsyncResult BeginCreateList(string listOwner, string name)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name);
		}

		public virtual IAsyncResult BeginCreateList(string listOwner, string name, string description)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name, "&description=", description);
		}

		public virtual IAsyncResult BeginCreateList(string listOwner, string name, string description, string mode)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual IAsyncResult BeginListListsFor(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginGetList(string ownerScreenName, string slug)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Get, "lists/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IAsyncResult BeginDeleteList(long listId)
		{
			return BeginWithHammock<TwitterList>(WebMethod.Post, "lists/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string ownerScreenName, string slug)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string ownerScreenName, string slug, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnList(string ownerScreenName, string slug, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string ownerScreenName, string slug, long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string ownerScreenName, string slug, long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterList>>(WebMethod.Get, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListListMembers(string ownerScreenName, string slug, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/members", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginAddListMember(string ownerScreenName, string slug, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/create", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginRemoveListMember(string ownerScreenName, string slug, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/members/destroy", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginVerifyListMembership(string ownerScreenName, string slug, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/members/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListListSubscriptionsFor(string screenName)
		{
			return BeginWithHammock<IEnumerable<TwitterList>>(WebMethod.Get, "lists/all", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListListSubscribers(string ownerScreenName, string slug, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "lists/subscribers", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginFollowList(string ownerScreenName, string slug)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IAsyncResult BeginUnfollowList(string ownerScreenName, string slug)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "lists/subscribers/destroy", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual IAsyncResult BeginVerifyListSubscription(string ownerScreenName, string slug, string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "lists/subscribers/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual IAsyncResult BeginFollowUserNotifications(string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "users/notifications/follow", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginFollowUserNotifications(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "users/notifications/follow", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginUnfollowUserNotifications(int userId)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "users/notifications/leave", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginUnfollowUserNotifications(string userScreenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Post, "users/notifications/leave", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual IAsyncResult BeginListSavedSearches()
		{
			return BeginWithHammock<IEnumerable<TwitterSavedSearch>>(WebMethod.Get, "saved_searches", FormatAsString);
		}

		public virtual IAsyncResult BeginGetSavedSearch(long id)
		{
			return BeginWithHammock<TwitterSavedSearch>(WebMethod.Get, "saved_searches/show", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginCreateSavedSearch(string query)
		{
			return BeginWithHammock<TwitterSavedSearch>(WebMethod.Post, "saved_searches/create", FormatAsString, "?query=", query);
		}

		public virtual IAsyncResult BeginDeleteSavedSearch(long id)
		{
			return BeginWithHammock<TwitterSavedSearch>(WebMethod.Delete, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginSearch(string q)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q);
		}

		public virtual IAsyncResult BeginSearch(string q, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearch(string q, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearch(string q, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearch(string q, int page, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearch(string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, int page, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, int page, int rpp)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual IAsyncResult BeginSearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType)
		{
			return BeginWithHammock<TwitterSearchResult>(WebMethod.Get, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual IAsyncResult BeginListTweetsOnPublicTimeline()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/public_timeline", FormatAsString);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimeline(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnHomeTimelineBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimeline()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimeline(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimeline(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimelineSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimelineSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimelineSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimelineBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimelineBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnFriendsTimelineBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimeline(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnUserTimelineBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(int userId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page);
		}

		public virtual IAsyncResult BeginListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMe()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMe(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMe(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListTweetsMentioningMeBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMe()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString);
		}

		public virtual IAsyncResult BeginListRetweetsByMe(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMe(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMe(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListRetweetsByMeSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMeSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMeBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListRetweetsByMeBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsByMeBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMe()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString);
		}

		public virtual IAsyncResult BeginListRetweetsToMe(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMe(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMeSince(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListRetweetsToMeSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMeSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMeBefore(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListRetweetsToMeBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsToMeBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweets()
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweets(int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweets(int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweets(long sinceId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsSince(long sinceId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsSince(long sinceId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsSince(long maxId)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsBefore(long maxId, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual IAsyncResult BeginListRetweetsOfMyTweetsBefore(long maxId, int page, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual IAsyncResult BeginListCurrentTrends()
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/current", FormatAsString);
		}

		public virtual IAsyncResult BeginListCurrentTrends(string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/current", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult BeginListDailyTrends()
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/daily", FormatAsString);
		}

		public virtual IAsyncResult BeginListDailyTrends(DateTime date)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/daily", FormatAsString, "?date=", date);
		}

		public virtual IAsyncResult BeginListDailyTrends(string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/daily", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult BeginListDailyTrends(DateTime date, string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/daily", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IAsyncResult BeginListWeeklyTrends()
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/weekly", FormatAsString);
		}

		public virtual IAsyncResult BeginListWeeklyTrends(DateTime date)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/weekly", FormatAsString, "?date=", date);
		}

		public virtual IAsyncResult BeginListWeeklyTrends(string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/weekly", FormatAsString, "?exclude=", exclude);
		}

		public virtual IAsyncResult BeginListWeeklyTrends(DateTime date, string exclude)
		{
			return BeginWithHammock<TwitterTrends>(WebMethod.Get, "trends/weekly", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual IAsyncResult BeginListAvailableTrendsLocations()
		{
			return BeginWithHammock<IEnumerable<WhereOnEarthLocation>>(WebMethod.Get, "trends/available", FormatAsString);
		}

		public virtual IAsyncResult BeginListAvailableTrendsLocations(double lat)
		{
			return BeginWithHammock<IEnumerable<WhereOnEarthLocation>>(WebMethod.Get, "trends/available", FormatAsString, "?lat=", lat);
		}

		public virtual IAsyncResult BeginListAvailableTrendsLocations(double lat, double @long)
		{
			return BeginWithHammock<IEnumerable<WhereOnEarthLocation>>(WebMethod.Get, "trends/available", FormatAsString, "?lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult BeginListLocalTrendsFor(long woeId)
		{
			return BeginWithHammock<TwitterLocalTrends>(WebMethod.Get, "trends/{woe_id}", FormatAsString, "?woe_id=", woeId);
		}

		public virtual IAsyncResult BeginGetTweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Get, "statuses/show/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginSendTweet(string status)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status);
		}

		public virtual IAsyncResult BeginSendTweet(string status, double lat, double @long)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult BeginSendTweet(string status, long inReplyToStatusId)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId);
		}

		public virtual IAsyncResult BeginSendTweet(string status, long inReplyToStatusId, double lat, double @long)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId, "&lat=", lat, "&long=", @long);
		}

		public virtual IAsyncResult BeginDeleteTweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Delete, "statuses/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginRetweet(long id)
		{
			return BeginWithHammock<TwitterStatus>(WebMethod.Post, "statuses/retweet/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginRetweets(long id)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets/{id}", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginRetweets(long id, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterStatus>>(WebMethod.Get, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult BeginListUsersWhoRetweeted(long id)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginListUsersWhoRetweeted(long id, int count)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult BeginListUserIdsWhoRetweeted(long id)
		{
			return BeginWithHammock<IEnumerable<int>>(WebMethod.Get, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginListUserIdsWhoRetweeted(long id, int count)
		{
			return BeginWithHammock<IEnumerable<int>>(WebMethod.Get, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual IAsyncResult BeginListFriends()
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/friends", FormatAsString);
		}

		public virtual IAsyncResult BeginListFriends(long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/friends", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFriendsOf(int userId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/friends", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListFriendsOf(int userId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/friends", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFriendsOf(string screenName)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/friends", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListFriendsOf(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/friends", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFollowers()
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/followers", FormatAsString);
		}

		public virtual IAsyncResult BeginListFollowers(long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/followers", FormatAsString, "?cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFollowersOf(int userId)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/followers", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListFollowersOf(int userId, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/followers", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginListFollowersOf(string screenName)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/followers", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListFollowersOf(string screenName, long cursor)
		{
			return BeginWithHammock<TwitterCursorList<TwitterUser>>(WebMethod.Get, "statuses/followers", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual IAsyncResult BeginGetUserProfile()
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "account/verify_credentials", FormatAsString);
		}

		public virtual IAsyncResult BeginGetUserProfileFor(string screenName)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "users/show", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginGetUserProfileFor(int id)
		{
			return BeginWithHammock<TwitterUser>(WebMethod.Get, "users/show", FormatAsString, "?id=", id);
		}

		public virtual IAsyncResult BeginSearchForUser(string q)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/search", FormatAsString, "?q=", q);
		}

		public virtual IAsyncResult BeginSearchForUser(string q, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/search", FormatAsString, "?q=", q, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginSearchForUser(string q, int page, int perPage)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/search", FormatAsString, "?q=", q, "&page=", page, "&per_page=", perPage);
		}

		public virtual IAsyncResult BeginListUserProfilesFor(IEnumerable<string> screenName)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/lookup", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginListUserProfilesFor(IEnumerable<int> userId)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/lookup", FormatAsString, "?user_id=", userId);
		}

		public virtual IAsyncResult BeginListUserProfilesFor(IEnumerable<string> screenName, IEnumerable<int> userId)
		{
			return BeginWithHammock<IEnumerable<TwitterUser>>(WebMethod.Get, "users/lookup", FormatAsString, "?screen_name=", screenName, "&user_id=", userId);
		}

		public virtual IAsyncResult BeginGetProfileImageFor(string screenName)
		{
			return BeginWithHammock<byte[]>(WebMethod.Get, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName);
		}

		public virtual IAsyncResult BeginGetProfileImageFor(string screenName, TwitterProfileImageSize size)
		{
			return BeginWithHammock<byte[]>(WebMethod.Get, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName, "&size=", size);
		}

		public virtual IAsyncResult BeginListSuggestedUserCategories()
		{
			return BeginWithHammock<IEnumerable<TwitterUserSuggestions>>(WebMethod.Get, "users/suggestions", FormatAsString);
		}

		public virtual IAsyncResult BeginListSuggestedUsers(string categorySlug)
		{
			return BeginWithHammock<TwitterUserSuggestions>(WebMethod.Get, "/users/suggestions/{category_slug}", FormatAsString, "?category_slug=", categorySlug);
		}

		public virtual TwitterUser EndVerifyCredentials(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndVerifyCredentials(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterRateLimitStatus EndGetRateLimitStatus(IAsyncResult result) 
		{
			return EndWithHammock<TwitterRateLimitStatus>(result);
		}

		public virtual TwitterRateLimitStatus EndGetRateLimitStatus(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterRateLimitStatus>(result, timeout);
		}

		public virtual TwitterError EndEndSession(IAsyncResult result) 
		{
			return EndWithHammock<TwitterError>(result);
		}

		public virtual TwitterError EndEndSession(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterError>(result, timeout);
		}

		public virtual TwitterUser EndUpdateDeliveryDevice(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateDeliveryDevice(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUpdateProfileColors(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateProfileColors(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUpdateProfileImage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateProfileImage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateProfileBackgroundImage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUpdateProfile(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUpdateProfile(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndBlockUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndBlockUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUnblockUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUnblockUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndVerifyBlocking(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndVerifyBlocking(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterUser> EndListBlockedUsers(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		public virtual IEnumerable<TwitterUser> EndListBlockedUsers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

		public virtual IEnumerable<int> EndListBlockedUserIds(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<int>>(result);
		}

		public virtual IEnumerable<int> EndListBlockedUserIds(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<int>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceived(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesReceivedBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSent(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result);
		}

		public virtual IEnumerable<TwitterDirectMessage> EndListDirectMessagesSentBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterDirectMessage>>(result, timeout);
		}

		public virtual TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterDirectMessage>(result);
		}

		public virtual TwitterDirectMessage EndDeleteDirectMessage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterDirectMessage>(result, timeout);
		}

		public virtual TwitterDirectMessage EndSendDirectMessage(IAsyncResult result) 
		{
			return EndWithHammock<TwitterDirectMessage>(result);
		}

		public virtual TwitterDirectMessage EndSendDirectMessage(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterDirectMessage>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweetsFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListFavoriteTweetsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual TwitterStatus EndFavoriteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndFavoriteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterStatus EndUnfavoriteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndUnfavoriteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterCursorList<int> EndListFriendIdsOf(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result);
		}

		public virtual TwitterCursorList<int> EndListFriendIdsOf(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result, timeout);
		}

		public virtual TwitterCursorList<int> EndListFollowerIdsOf(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result);
		}

		public virtual TwitterCursorList<int> EndListFollowerIdsOf(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result, timeout);
		}

		public virtual TwitterUser EndFollowUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndFollowUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUnfollowUser(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUnfollowUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterCursorList<int> EndGetIncomingFriendRequests(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result);
		}

		public virtual TwitterCursorList<int> EndGetIncomingFriendRequests(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result, timeout);
		}

		public virtual TwitterCursorList<int> EndGetOutgoingFriendRequests(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result);
		}

		public virtual TwitterCursorList<int> EndGetOutgoingFriendRequests(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<int>>(result, timeout);
		}

		public virtual TwitterFriendship EndGetFriendshipInfo(IAsyncResult result) 
		{
			return EndWithHammock<TwitterFriendship>(result);
		}

		public virtual TwitterFriendship EndGetFriendshipInfo(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterFriendship>(result, timeout);
		}

		public virtual TwitterList EndCreateList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		public virtual TwitterList EndCreateList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterList> EndListListsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		public virtual TwitterCursorList<TwitterList> EndListListsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

		public virtual TwitterList EndGetList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		public virtual TwitterList EndGetList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

		public virtual TwitterList EndDeleteList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterList>(result);
		}

		public virtual TwitterList EndDeleteList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterList>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnListSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnListSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnListBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnListBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result);
		}

		public virtual TwitterCursorList<TwitterList> EndListListMembershipsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterList>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		public virtual TwitterCursorList<TwitterUser> EndListListMembers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

		public virtual TwitterUser EndAddListMember(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndAddListMember(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndRemoveListMember(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndRemoveListMember(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndVerifyListMembership(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndVerifyListMembership(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterList> EndListListSubscriptionsFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterList>>(result);
		}

		public virtual IEnumerable<TwitterList> EndListListSubscriptionsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterList>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		public virtual TwitterCursorList<TwitterUser> EndListListSubscribers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

		public virtual TwitterUser EndFollowList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndFollowList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUnfollowList(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUnfollowList(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndVerifyListSubscription(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndVerifyListSubscription(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndFollowUserNotifications(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndFollowUserNotifications(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndUnfollowUserNotifications(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndUnfollowUserNotifications(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterSavedSearch>>(result);
		}

		public virtual IEnumerable<TwitterSavedSearch> EndListSavedSearches(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterSavedSearch>>(result, timeout);
		}

		public virtual TwitterSavedSearch EndGetSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		public virtual TwitterSavedSearch EndGetSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

		public virtual TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		public virtual TwitterSavedSearch EndCreateSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

		public virtual TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSavedSearch>(result);
		}

		public virtual TwitterSavedSearch EndDeleteSavedSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSavedSearch>(result, timeout);
		}

		public virtual TwitterSearchResult EndSearch(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSearchResult>(result);
		}

		public virtual TwitterSearchResult EndSearch(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSearchResult>(result, timeout);
		}

		public virtual TwitterSearchResult EndSearchSince(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSearchResult>(result);
		}

		public virtual TwitterSearchResult EndSearchSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSearchResult>(result, timeout);
		}

		public virtual TwitterSearchResult EndSearchBefore(IAsyncResult result) 
		{
			return EndWithHammock<TwitterSearchResult>(result);
		}

		public virtual TwitterSearchResult EndSearchBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterSearchResult>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnPublicTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnPublicTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnHomeTimelineBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimelineSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimelineSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimelineBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnFriendsTimelineBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnUserTimelineBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimeline(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimeline(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsOnSpecifiedUserTimelineBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMe(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMeSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMeSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMeBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListTweetsMentioningMeBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMe(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMe(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMeSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMeSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMeBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsByMeBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMe(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMe(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMeSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMeSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMeBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsToMeBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsSince(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsSince(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsBefore(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndListRetweetsOfMyTweetsBefore(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual TwitterTrends EndListCurrentTrends(IAsyncResult result) 
		{
			return EndWithHammock<TwitterTrends>(result);
		}

		public virtual TwitterTrends EndListCurrentTrends(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterTrends>(result, timeout);
		}

		public virtual TwitterTrends EndListDailyTrends(IAsyncResult result) 
		{
			return EndWithHammock<TwitterTrends>(result);
		}

		public virtual TwitterTrends EndListDailyTrends(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterTrends>(result, timeout);
		}

		public virtual TwitterTrends EndListWeeklyTrends(IAsyncResult result) 
		{
			return EndWithHammock<TwitterTrends>(result);
		}

		public virtual TwitterTrends EndListWeeklyTrends(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterTrends>(result, timeout);
		}

		public virtual IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<WhereOnEarthLocation>>(result);
		}

		public virtual IEnumerable<WhereOnEarthLocation> EndListAvailableTrendsLocations(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<WhereOnEarthLocation>>(result, timeout);
		}

		public virtual TwitterLocalTrends EndListLocalTrendsFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterLocalTrends>(result);
		}

		public virtual TwitterLocalTrends EndListLocalTrendsFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterLocalTrends>(result, timeout);
		}

		public virtual TwitterStatus EndGetTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndGetTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterStatus EndSendTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndSendTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterStatus EndDeleteTweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndDeleteTweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual TwitterStatus EndRetweet(IAsyncResult result) 
		{
			return EndWithHammock<TwitterStatus>(result);
		}

		public virtual TwitterStatus EndRetweet(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterStatus>(result, timeout);
		}

		public virtual IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result);
		}

		public virtual IEnumerable<TwitterStatus> EndRetweets(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterStatus>>(result, timeout);
		}

		public virtual IEnumerable<TwitterUser> EndListUsersWhoRetweeted(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		public virtual IEnumerable<TwitterUser> EndListUsersWhoRetweeted(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

		public virtual IEnumerable<int> EndListUserIdsWhoRetweeted(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<int>>(result);
		}

		public virtual IEnumerable<int> EndListUserIdsWhoRetweeted(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<int>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterUser> EndListFriends(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		public virtual TwitterCursorList<TwitterUser> EndListFriends(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterUser> EndListFriendsOf(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		public virtual TwitterCursorList<TwitterUser> EndListFriendsOf(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterUser> EndListFollowers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		public virtual TwitterCursorList<TwitterUser> EndListFollowers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

		public virtual TwitterCursorList<TwitterUser> EndListFollowersOf(IAsyncResult result) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result);
		}

		public virtual TwitterCursorList<TwitterUser> EndListFollowersOf(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterCursorList<TwitterUser>>(result, timeout);
		}

		public virtual TwitterUser EndGetUserProfile(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndGetUserProfile(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual TwitterUser EndGetUserProfileFor(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUser>(result);
		}

		public virtual TwitterUser EndGetUserProfileFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUser>(result, timeout);
		}

		public virtual IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		public virtual IEnumerable<TwitterUser> EndSearchForUser(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

		public virtual IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result);
		}

		public virtual IEnumerable<TwitterUser> EndListUserProfilesFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUser>>(result, timeout);
		}

		public virtual byte[] EndGetProfileImageFor(IAsyncResult result) 
		{
			return EndWithHammock<byte[]>(result);
		}

		public virtual byte[] EndGetProfileImageFor(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<byte[]>(result, timeout);
		}

		public virtual IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result) 
		{
			return EndWithHammock<IEnumerable<TwitterUserSuggestions>>(result);
		}

		public virtual IEnumerable<TwitterUserSuggestions> EndListSuggestedUserCategories(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<IEnumerable<TwitterUserSuggestions>>(result, timeout);
		}

		public virtual TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result) 
		{
			return EndWithHammock<TwitterUserSuggestions>(result);
		}

		public virtual TwitterUserSuggestions EndListSuggestedUsers(IAsyncResult result, TimeSpan timeout) 
		{
			return EndWithHammock<TwitterUserSuggestions>(result, timeout);
		}

		#endregion
#endif

#if WINDOWS_PHONE
		#region Asynchronous Methods (without IAsyncResult)
		public virtual void VerifyCredentials(Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "account/verify_credentials", FormatAsString);
		}

		public virtual void GetRateLimitStatus(Action<TwitterRateLimitStatus, TwitterResponse> action)
		{
			WithHammock(action, "account/rate_limit_status", FormatAsString);
		}

		public virtual void EndSession(Action<TwitterError, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/end_session", FormatAsString);
		}

		public virtual void UpdateDeliveryDevice(TwitterDeliveryDevice device, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "account/update_delivery_device", FormatAsString, "?device=", device);
		}

		public virtual void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, string sidebarBorderColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor, "&sidebar_border_color=", sidebarBorderColor);
		}

		public virtual void UpdateProfileColors(string backgroundColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor);
		}

		public virtual void UpdateProfileColors(string backgroundColor, string textColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor);
		}

		public virtual void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor);
		}

		public virtual void UpdateProfileColors(string backgroundColor, string textColor, string linkColor, string sidebarFillColor, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_colors", FormatAsString, "?background_color=", backgroundColor, "&text_color=", textColor, "&link_color=", linkColor, "&sidebar_fill_color=", sidebarFillColor);
		}

		public virtual void UpdateProfileImage(string path, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_image", FormatAsString, "?path=", path);
		}

		public virtual void UpdateProfileBackgroundImage(string path, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile_background_image", FormatAsString, "?path=", path);
		}

		public virtual void UpdateProfile(string name, string description, string email, string url, string location, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "account/update_profile", FormatAsString, "?name=", name, "&description=", description, "&email=", email, "&url=", url, "&location=", location);
		}

		public virtual void BlockUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "blocks/create", FormatAsString, "?user_id=", userId);
		}

		public virtual void BlockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "blocks/create", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void UnblockUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "blocks/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual void UnblockUser(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "blocks/destroy", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void VerifyBlocking(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "blocks/exists", FormatAsString, "?user_id=", userId);
		}

		public virtual void VerifyBlocking(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "blocks/exists", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void ListBlockedUsers(Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "blocks/blocking", FormatAsString);
		}

		public virtual void ListBlockedUsers(int page, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "blocks/blocking", FormatAsString, "?page=", page);
		}

		public virtual void ListBlockedUserIds(Action<IEnumerable<int>, TwitterResponse> action)
		{
			WithHammock(action, "blocks/blocking/ids", FormatAsString);
		}

		public virtual void ListDirectMessagesReceived(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString);
		}

		public virtual void ListDirectMessagesReceived(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?count=", count);
		}

		public virtual void ListDirectMessagesReceived(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesReceivedSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListDirectMessagesReceivedSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListDirectMessagesReceivedSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesReceivedBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListDirectMessagesReceivedBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListDirectMessagesReceivedBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesSent(Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString);
		}

		public virtual void ListDirectMessagesSent(int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?count=", count);
		}

		public virtual void ListDirectMessagesSent(int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesSentSince(long sinceId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListDirectMessagesSentSince(long sinceId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListDirectMessagesSentSince(long sinceId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListDirectMessagesSentBefore(long maxId, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListDirectMessagesSentBefore(long maxId, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListDirectMessagesSentBefore(long maxId, int page, int count, Action<IEnumerable<TwitterDirectMessage>, TwitterResponse> action)
		{
			WithHammock(action, "direct_messages/sent", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void DeleteDirectMessage(long id, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void DeleteDirectMessage(int id, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "direct_messages/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void SendDirectMessage(int userId, string text, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "direct_messages/new", FormatAsString, "?user_id=", userId, "&text=", text);
		}

		public virtual void SendDirectMessage(string screenName, string text, Action<TwitterDirectMessage, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "direct_messages/new", FormatAsString, "?screen_name=", screenName, "&text=", text);
		}

		public virtual void ListFavoriteTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites", FormatAsString);
		}

		public virtual void ListFavoriteTweets(int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites", FormatAsString, "?page=", page);
		}

		public virtual void ListFavoriteTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListFavoriteTweetsFor(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListFavoriteTweetsFor(int userId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page);
		}

		public virtual void ListFavoriteTweetsFor(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual void ListFavoriteTweetsFor(string userScreenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void ListFavoriteTweetsFor(string userScreenName, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page);
		}

		public virtual void ListFavoriteTweetsFor(string userScreenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "favorites/{user_screen_name}", FormatAsString, "?user_screen_name=", userScreenName, "&page=", page, "&count=", count);
		}

		public virtual void FavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "favorites/create/{id}", FormatAsString, "?id=", id);
		}

		public virtual void UnfavoriteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "favorites/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void ListFriendIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friends/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void ListFriendIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friends/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual void ListFollowerIdsOf(int userId, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "followers/ids", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual void ListFollowerIdsOf(string screenName, long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "followers/ids", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void FollowUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "friendships/create", FormatAsString, "?user_id=", userId);
		}

		public virtual void FollowUser(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "friendships/create", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void UnfollowUser(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "friendships/destroy", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void UnfollowUser(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "friendships/destroy", FormatAsString, "?user_id=", userId);
		}

		public virtual void GetIncomingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friendships/incoming", FormatAsString);
		}

		public virtual void GetIncomingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friendships/incoming", FormatAsString, "?cursor=", cursor);
		}

		public virtual void GetOutgoingFriendRequests(Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friendships/outgoing", FormatAsString);
		}

		public virtual void GetOutgoingFriendRequests(long cursor, Action<TwitterCursorList<int>, TwitterResponse> action)
		{
			WithHammock(action, "friendships/outgoing", FormatAsString, "?cursor=", cursor);
		}

		public virtual void GetFriendshipInfo(string sourceScreenName, string targetScreenName, Action<TwitterFriendship, TwitterResponse> action)
		{
			WithHammock(action, "friendships/show", FormatAsString, "?source_screen_name=", sourceScreenName, "&target_screen_name=", targetScreenName);
		}

		public virtual void GetFriendshipInfo(int sourceId, int targetId, Action<TwitterFriendship, TwitterResponse> action)
		{
			WithHammock(action, "friendships/show", FormatAsString, "?source_id=", sourceId, "&target_id=", targetId);
		}

		public virtual void CreateList(string listOwner, string name, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name);
		}

		public virtual void CreateList(string listOwner, string name, string description, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name, "&description=", description);
		}

		public virtual void CreateList(string listOwner, string name, string description, string mode, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/create", FormatAsString, "?list_owner=", listOwner, "&name=", name, "&description=", description, "&mode=", mode);
		}

		public virtual void ListListsFor(string screenName, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void GetList(string ownerScreenName, string slug, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(action, "lists/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual void DeleteList(long listId, Action<TwitterList, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/destroy", FormatAsString, "?list_id=", listId);
		}

		public virtual void ListTweetsOnList(string ownerScreenName, string slug, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual void ListTweetsOnList(string ownerScreenName, string slug, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnList(string ownerScreenName, string slug, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId);
		}

		public virtual void ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListSince(string ownerScreenName, string slug, long sinceId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&since_id=", sinceId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId);
		}

		public virtual void ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId, "&per_page=", perPage);
		}

		public virtual void ListTweetsOnListBefore(string ownerScreenName, string slug, long maxId, int page, int perPage, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "lists/statuses", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&max_id=", maxId, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListListMembershipsFor(string screenName, bool filterToOwnedLists, long cursor, Action<TwitterCursorList<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/memberships", FormatAsString, "?screen_name=", screenName, "&filter_to_owned_lists=", filterToOwnedLists, "&cursor=", cursor);
		}

		public virtual void ListListMembers(string ownerScreenName, string slug, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/members", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&cursor=", cursor);
		}

		public virtual void AddListMember(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/create", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual void RemoveListMember(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/members/destroy", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual void VerifyListMembership(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/members/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual void ListListSubscriptionsFor(string screenName, Action<IEnumerable<TwitterList>, TwitterResponse> action)
		{
			WithHammock(action, "lists/all", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListListSubscribers(string ownerScreenName, string slug, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&cursor=", cursor);
		}

		public virtual void FollowList(string ownerScreenName, string slug, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/subscribers/create", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual void UnfollowList(string ownerScreenName, string slug, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "lists/subscribers/destroy", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug);
		}

		public virtual void VerifyListSubscription(string ownerScreenName, string slug, string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "lists/subscribers/show", FormatAsString, "?owner_screen_name=", ownerScreenName, "&slug=", slug, "&screen_name=", screenName);
		}

		public virtual void FollowUserNotifications(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "users/notifications/follow", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void FollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "users/notifications/follow", FormatAsString, "?user_id=", userId);
		}

		public virtual void UnfollowUserNotifications(int userId, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "users/notifications/leave", FormatAsString, "?user_id=", userId);
		}

		public virtual void UnfollowUserNotifications(string userScreenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "users/notifications/leave", FormatAsString, "?user_screen_name=", userScreenName);
		}

		public virtual void ListSavedSearches(Action<IEnumerable<TwitterSavedSearch>, TwitterResponse> action)
		{
			WithHammock(action, "saved_searches", FormatAsString);
		}

		public virtual void GetSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			WithHammock(action, "saved_searches/show", FormatAsString, "?id=", id);
		}

		public virtual void CreateSavedSearch(string query, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "saved_searches/create", FormatAsString, "?query=", query);
		}

		public virtual void DeleteSavedSearch(long id, Action<TwitterSavedSearch, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "saved_searches/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void Search(string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q);
		}

		public virtual void Search(string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&result_type=", resultType);
		}

		public virtual void Search(string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&rpp=", rpp);
		}

		public virtual void Search(string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void Search(string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual void Search(string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void SearchSince(long since_id, string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q);
		}

		public virtual void SearchSince(long since_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual void SearchSince(long since_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual void SearchSince(long since_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void SearchSince(long since_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual void SearchSince(long since_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?since_id=", since_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void SearchBefore(long max_id, string q, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q);
		}

		public virtual void SearchBefore(long max_id, string q, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&result_type=", resultType);
		}

		public virtual void SearchBefore(long max_id, string q, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp);
		}

		public virtual void SearchBefore(long max_id, string q, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void SearchBefore(long max_id, string q, int page, int rpp, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp);
		}

		public virtual void SearchBefore(long max_id, string q, int page, int rpp, TwitterSearchResultType resultType, Action<TwitterSearchResult, TwitterResponse> action)
		{
			WithHammock(action, "search", FormatAsString, "?max_id=", max_id, "&q=", q, "&page=", page, "&rpp=", rpp, "&result_type=", resultType);
		}

		public virtual void ListTweetsOnPublicTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/public_timeline", FormatAsString);
		}

		public virtual void ListTweetsOnHomeTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString);
		}

		public virtual void ListTweetsOnHomeTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?count=", count);
		}

		public virtual void ListTweetsOnHomeTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsOnHomeTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/home_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnFriendsTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString);
		}

		public virtual void ListTweetsOnFriendsTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString, "?count=", count);
		}

		public virtual void ListTweetsOnFriendsTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnFriendsTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListTweetsOnFriendsTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnFriendsTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnFriendsTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListTweetsOnFriendsTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsOnFriendsTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimeline(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString);
		}

		public virtual void ListTweetsOnUserTimeline(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?count=", count);
		}

		public virtual void ListTweetsOnUserTimeline(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimelineSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsOnUserTimelineBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(int userId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(int userId, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(int userId, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?user_id=", userId, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimeline(string screenName, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineSince(string screenName, long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page);
		}

		public virtual void ListTweetsOnSpecifiedUserTimelineBefore(string screenName, long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/user_timeline", FormatAsString, "?screen_name=", screenName, "&max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsMentioningMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString);
		}

		public virtual void ListTweetsMentioningMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?count=", count);
		}

		public virtual void ListTweetsMentioningMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListTweetsMentioningMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListTweetsMentioningMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListTweetsMentioningMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListTweetsMentioningMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListTweetsMentioningMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListTweetsMentioningMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/mentions", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsByMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString);
		}

		public virtual void ListRetweetsByMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?count=", count);
		}

		public virtual void ListRetweetsByMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListRetweetsByMe(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListRetweetsByMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListRetweetsByMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsByMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListRetweetsByMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListRetweetsByMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_by_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsToMe(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString);
		}

		public virtual void ListRetweetsToMe(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?count=", count);
		}

		public virtual void ListRetweetsToMe(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListRetweetsToMeSince(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListRetweetsToMeSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListRetweetsToMeSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsToMeBefore(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListRetweetsToMeBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListRetweetsToMeBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweeted_to_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweets(Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString);
		}

		public virtual void ListRetweetsOfMyTweets(int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?count=", count);
		}

		public virtual void ListRetweetsOfMyTweets(int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?page=", page, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweets(long sinceId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId);
		}

		public virtual void ListRetweetsOfMyTweetsSince(long sinceId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweetsSince(long sinceId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?since_id=", sinceId, "&page=", page, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweetsSince(long maxId, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId);
		}

		public virtual void ListRetweetsOfMyTweetsBefore(long maxId, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&count=", count);
		}

		public virtual void ListRetweetsOfMyTweetsBefore(long maxId, int page, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets_of_me", FormatAsString, "?max_id=", maxId, "&page=", page, "&count=", count);
		}

		public virtual void ListCurrentTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/current", FormatAsString);
		}

		public virtual void ListCurrentTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/current", FormatAsString, "?exclude=", exclude);
		}

		public virtual void ListDailyTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/daily", FormatAsString);
		}

		public virtual void ListDailyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/daily", FormatAsString, "?date=", date);
		}

		public virtual void ListDailyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/daily", FormatAsString, "?exclude=", exclude);
		}

		public virtual void ListDailyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/daily", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual void ListWeeklyTrends(Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/weekly", FormatAsString);
		}

		public virtual void ListWeeklyTrends(DateTime date, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/weekly", FormatAsString, "?date=", date);
		}

		public virtual void ListWeeklyTrends(string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/weekly", FormatAsString, "?exclude=", exclude);
		}

		public virtual void ListWeeklyTrends(DateTime date, string exclude, Action<TwitterTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/weekly", FormatAsString, "?date=", date, "&exclude=", exclude);
		}

		public virtual void ListAvailableTrendsLocations(Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			WithHammock(action, "trends/available", FormatAsString);
		}

		public virtual void ListAvailableTrendsLocations(double lat, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			WithHammock(action, "trends/available", FormatAsString, "?lat=", lat);
		}

		public virtual void ListAvailableTrendsLocations(double lat, double @long, Action<IEnumerable<WhereOnEarthLocation>, TwitterResponse> action)
		{
			WithHammock(action, "trends/available", FormatAsString, "?lat=", lat, "&long=", @long);
		}

		public virtual void ListLocalTrendsFor(long woeId, Action<TwitterLocalTrends, TwitterResponse> action)
		{
			WithHammock(action, "trends/{woe_id}", FormatAsString, "?woe_id=", woeId);
		}

		public virtual void GetTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(action, "statuses/show/{id}", FormatAsString, "?id=", id);
		}

		public virtual void SendTweet(string status, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status);
		}

		public virtual void SendTweet(string status, double lat, double @long, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&lat=", lat, "&long=", @long);
		}

		public virtual void SendTweet(string status, long inReplyToStatusId, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId);
		}

		public virtual void SendTweet(string status, long inReplyToStatusId, double lat, double @long, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/update", FormatAsString, "?status=", status, "&in_reply_to_status_id=", inReplyToStatusId, "&lat=", lat, "&long=", @long);
		}

		public virtual void DeleteTweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Delete, action, "statuses/destroy/{id}", FormatAsString, "?id=", id);
		}

		public virtual void Retweet(long id, Action<TwitterStatus, TwitterResponse> action)
		{
			WithHammock(WebMethod.Post, action, "statuses/retweet/{id}", FormatAsString, "?id=", id);
		}

		public virtual void Retweets(long id, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets/{id}", FormatAsString, "?id=", id);
		}

		public virtual void Retweets(long id, int count, Action<IEnumerable<TwitterStatus>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/retweets/{id}", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual void ListUsersWhoRetweeted(long id, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id);
		}

		public virtual void ListUsersWhoRetweeted(long id, int count, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/{id}/retweeted_by", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual void ListUserIdsWhoRetweeted(long id, Action<IEnumerable<int>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id);
		}

		public virtual void ListUserIdsWhoRetweeted(long id, int count, Action<IEnumerable<int>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/{id}/retweeted_by/ids", FormatAsString, "?id=", id, "&count=", count);
		}

		public virtual void ListFriends(Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends", FormatAsString);
		}

		public virtual void ListFriends(long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends", FormatAsString, "?cursor=", cursor);
		}

		public virtual void ListFriendsOf(int userId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListFriendsOf(int userId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual void ListFriendsOf(string screenName, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListFriendsOf(string screenName, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/friends", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void ListFollowers(Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/followers", FormatAsString);
		}

		public virtual void ListFollowers(long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/followers", FormatAsString, "?cursor=", cursor);
		}

		public virtual void ListFollowersOf(int userId, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/followers", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListFollowersOf(int userId, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/followers", FormatAsString, "?user_id=", userId, "&cursor=", cursor);
		}

		public virtual void ListFollowersOf(string screenName, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/followers", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListFollowersOf(string screenName, long cursor, Action<TwitterCursorList<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "statuses/followers", FormatAsString, "?screen_name=", screenName, "&cursor=", cursor);
		}

		public virtual void GetUserProfile(Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "account/verify_credentials", FormatAsString);
		}

		public virtual void GetUserProfileFor(string screenName, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "users/show", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void GetUserProfileFor(int id, Action<TwitterUser, TwitterResponse> action)
		{
			WithHammock(action, "users/show", FormatAsString, "?id=", id);
		}

		public virtual void SearchForUser(string q, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/search", FormatAsString, "?q=", q);
		}

		public virtual void SearchForUser(string q, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/search", FormatAsString, "?q=", q, "&per_page=", perPage);
		}

		public virtual void SearchForUser(string q, int page, int perPage, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/search", FormatAsString, "?q=", q, "&page=", page, "&per_page=", perPage);
		}

		public virtual void ListUserProfilesFor(IEnumerable<string> screenName, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/lookup", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void ListUserProfilesFor(IEnumerable<int> userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/lookup", FormatAsString, "?user_id=", userId);
		}

		public virtual void ListUserProfilesFor(IEnumerable<string> screenName, IEnumerable<int> userId, Action<IEnumerable<TwitterUser>, TwitterResponse> action)
		{
			WithHammock(action, "users/lookup", FormatAsString, "?screen_name=", screenName, "&user_id=", userId);
		}

		public virtual void GetProfileImageFor(string screenName, Action<byte[], TwitterResponse> action)
		{
			WithHammock(action, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName);
		}

		public virtual void GetProfileImageFor(string screenName, TwitterProfileImageSize size, Action<byte[], TwitterResponse> action)
		{
			WithHammock(action, "users/profile_image/{screen_name}", FormatAsString, "?screen_name=", screenName, "&size=", size);
		}

		public virtual void ListSuggestedUserCategories(Action<IEnumerable<TwitterUserSuggestions>, TwitterResponse> action)
		{
			WithHammock(action, "users/suggestions", FormatAsString);
		}

		public virtual void ListSuggestedUsers(string categorySlug, Action<TwitterUserSuggestions, TwitterResponse> action)
		{
			WithHammock(action, "/users/suggestions/{category_slug}", FormatAsString, "?category_slug=", categorySlug);
		}

		#endregion
#endif	
	}

	#endregion
}
