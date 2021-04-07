using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access Youtube Api ...

                // Read data ...

                // Create a list of downloaded Videos
                throw new Exception("Ooops. Something fishy went wrong");
            }
            catch(Exception ex)
            {
                // Log error information to user
                throw new YouTubeException("Could not fetch videos from YouTube", ex);
            }

            return new List<Video>();
        }
    }
}