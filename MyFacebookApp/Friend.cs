using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using MyFacebookApp.View.Properties;


namespace MyFacebookApp.View
{
    public class Friend : User
    {
        public User FriendOf { get; private set; }
        public FacebookObjectCollection<Group> MutualGroups { get; private set; }
        public FacebookObjectCollection<Checkin> MutualCheckins { get; private set; }
        public FacebookObjectCollection<Post> PostsFriendTaggedUser { get; private set; }
        public FacebookObjectCollection<Photo> MutualPictures { get; private set; }
        public FacebookObjectCollection<Event> MutualEvents { get; private set; }

        public void SetFriendOfProperties(User i_FriendOf)
        {           
            FriendOf = i_FriendOf;
            SetMutualGroups();
            SetMutualCheckins();
            SetPostsFriendTaggedUser();
            SetMutualPictures();
            SetMutualEvents();
        }

        private void SetMutualEvents()
        {
            FacebookObjectCollection<Event> mutualEvents = new FacebookObjectCollection<Event>();

            foreach (Event currEvent in this.Events)
            {
                if (FriendOf.Events.Contains(currEvent))
                {
                    mutualEvents.Add(currEvent);
                }
            }

            MutualEvents = mutualEvents;
        }

        private void SetMutualGroups()
        {
            FacebookObjectCollection<Group> mutualGroups = new FacebookObjectCollection<Group>();

            foreach (Group group in this.Groups)
            {
                if (FriendOf.Groups.Contains(group))
                {
                    mutualGroups.Add(group);
                }
            }

            MutualGroups = mutualGroups;
        }

        private void SetMutualCheckins()
        {
            FacebookObjectCollection<Checkin> mutualCheckin = new FacebookObjectCollection<Checkin>();

            foreach (Checkin checkin in this.Checkins)
            {
                if (FriendOf.Checkins.Contains(checkin))
                {
                    mutualCheckin.Add(checkin);
                }
            }

            MutualCheckins = mutualCheckin;
        }

        private void SetPostsFriendTaggedUser()
        {
            FacebookObjectCollection<Post> postsFriendTaggedUser = new FacebookObjectCollection<Post>();

            foreach (Post post in this.Posts)
            {
                if (post.TaggedUsers.Contains(FriendOf))
                {
                    postsFriendTaggedUser.Add(post);
                }
            }

            PostsFriendTaggedUser = postsFriendTaggedUser;
        }

        private void SetMutualPictures()
        {
            FacebookObjectCollection<Photo> mutualPictuers = new FacebookObjectCollection<Photo>();

            foreach (Photo photo in FriendOf.PhotosTaggedIn)
            {
                if (this.PhotosTaggedIn.Contains(photo))
                {
                    mutualPictuers.Add(photo);                
                }
            }

            MutualPictures = mutualPictuers;
        }
    }
}

