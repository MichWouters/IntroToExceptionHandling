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
                // Exceptions can be handled in a lower level, and can be 'bubbled up' to a higher catch block by using the throw keyword
                // throw -> Rethrow same exception. throw new ... -> throw a more specific exception
                // Be sure to include existing Exception into new exceptions, as to not lose important information
                throw new YouTubeException("Could not fetch videos from YouTube", ex);
            }

            return new List<Video>();
        }
    }
}