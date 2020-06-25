using System;
using System.Collections.Generic;
using System.Text;
using TpsXamarin.Entities;

namespace TpsXamarin.Services
{
    public interface ITwitterService
    {
        Boolean Authenticate(User user);
        List<Tweet> GetTweets();
    }
}
