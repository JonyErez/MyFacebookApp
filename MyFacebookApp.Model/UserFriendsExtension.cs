using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.View
{
    public class UserFriendsExtension
    {
        public User User { get; set; }
        
        public FacebookObjectCollection<User> Friends()
        {
            return User.Friends;
        }

        public FacebookObjectCollection<Event> GetMutualEvents(User i_Friend)
        {
            FacebookObjectCollection<Event> mutualEvents = new FacebookObjectCollection<Event>();

            foreach (Event currEvent in User.Events)
            {
                if (i_Friend.Events.Contains(currEvent))
                {
                    mutualEvents.Add(currEvent);
                }
            }

            return mutualEvents;
        }

        public FacebookObjectCollection<Group> GetMutualGroups(User i_Friend)
        {
            FacebookObjectCollection<Group> mutualGroups = new FacebookObjectCollection<Group>();

            foreach (Group group in User.Groups)
            {
                if (i_Friend.Groups.Contains(group))
                {
                    mutualGroups.Add(group);
                }
            }

            return mutualGroups;
        }

        public FacebookObjectCollection<Checkin> GetMutualCheckins(User i_Friend)
        {
            FacebookObjectCollection<Checkin> mutualCheckin = new FacebookObjectCollection<Checkin>();

            foreach (Checkin checkin in User.Checkins)
            {
                if (i_Friend.Checkins.Contains(checkin))
                {
                    mutualCheckin.Add(checkin);
                }
            }

            return mutualCheckin;
        }

        public FacebookObjectCollection<Post> GetPostsFriendTaggedUser(User i_Friend)
        {
            FacebookObjectCollection<Post> postsFriendTaggedUser = new FacebookObjectCollection<Post>();

            foreach (Post post in User.Posts)
            {
                if (post.TaggedUsers.Contains(i_Friend))
                {
                    postsFriendTaggedUser.Add(post);
                }
            }

            return postsFriendTaggedUser;
        }

        public FacebookObjectCollection<Photo> GetMutualPictures(User i_Friend)
        {
            FacebookObjectCollection<Photo> mutualPictuers = new FacebookObjectCollection<Photo>();

            foreach (Photo photo in User.PhotosTaggedIn)
            {
                if (i_Friend.PhotosTaggedIn.Contains(photo))
                {
                    mutualPictuers.Add(photo);
                }
            }

            return mutualPictuers;
        }
    }
}
