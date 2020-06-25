using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TpsXamarin.Entities;

namespace TpsXamarin.Services
{
    public class TwitterService : ITwitterService
    {
        public Boolean Authenticate(User user)
        {
            Boolean result = GetTweets().Select(x => x.User).Any(x => user.Pseudo == x.Pseudo && user.Password == x.Password);
            return result;
        }

        public List<Tweet> GetTweets()
        {
            
                List<Tweet> tweets = new List<Tweet>();
                User user = new User() { Name = "Vince", Pseudo = "lechdo", Password = "password" };
                tweets.Add(new Tweet()
                {
                    DateCreation = DateTime.Now,
                    Id = 0,
                    User = user,
                    Text = "Ahoy loot dance the hempen jig mizzen line crimp warp list Letter of Marque lookout. Pressgang case shot man-of-war transom shrouds aye draft fathom Buccaneer take a caulk. Hempen halter deadlights crimp tack Admiral of the Black jib maroon ye Nelsons folly cable."
                });
                tweets.Add(new Tweet()
                {
                    DateCreation = DateTime.Now,
                    Id = 1,
                    User = user,
                    Text = "Zombie ipsum reversus ab viral inferno, nam rick grimes malum cerebro. De carne lumbering animata corpora quaeritis."
                });
                tweets.Add(new Tweet()
                {
                    DateCreation = DateTime.Now,
                    Id = 2,
                    User = user,
                    Text = "Barbary Coast black spot maroon lanyard blow the man down hands sutler chase gally lass. Chain Shot topsail Arr coxswain heave to piracy case shot spirits ballast port. Reef plunder belay Jack Tar Spanish Main crow's nest nipperkin black jack topmast fluke."
                });
                tweets.Add(new Tweet()
                {
                    DateCreation = DateTime.Now,
                    Id = 3,
                    User = user,
                    Text = " Hodor hodor. Hodor? Hodor hodor. Hodor hodor. Hodor, hodor. Hodor. Hodor hodor! Hodor! Hodor hodor. HODOR? Hodor... Hodor hodor. Hodor, hodor. Hodor. Hodor."
                });
                tweets.Add(new Tweet()
                {
                    DateCreation = DateTime.Now,
                    Id = 4,
                    User = user,
                    Text = "Pieces of Eight trysail Gold Road Chain Shot grapple landlubber or just lubber coffer Arr walk the plank Davy Jones' Locker. Skysail topgallant yo-ho-ho yard Barbary Coast Pirate Round belay boom bilge rat six pounders. Reef league hogshead Spanish Main cog scourge of the seven seas carouser grapple lookout quarter."
                });

                return tweets;
       
            
        }

    }
}
