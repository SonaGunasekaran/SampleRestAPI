/*
 * Project:validating the API services and performing the operations like post,put,get,delete
 * Author:Sona G
 * Date:18/08/2021
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Net;


namespace TestRestAPI.PostRequest
{
    [TestClass]
    public class TestPostWithJsonData
    {
        private string myToken = "Bearer BQDfmen6kZdRF1yhFrwha38VPxWdPJkdp1qyO93qrIwea-YWAgenzJKn4ilMfqacYcDu1nyMWjewk_i-4ge6em-dWmjjUddKQDBlfHXflpLCeNWrIyAQZicP3L0IisqMLai0PKLulJFW9nRziylpqq5b0MvdXEzSr4jFdQm81SvXuFrn6lKUR_Vv1WrdNw8foNdDQwhj0-C5N9UcXZ-9Yujw4VJ6L6UAwluh8r-hM84XgMJtDMkFZPWpU0UxBm11UNubNiYKRPhiES9tow0hrrMreoJZXWoh2rXh3erA";
        private string postUrl = "https://api.spotify.com/v1/playlists/playlists";
        private static IRestResponse restResponse { get; set; }
        [TestMethod]
        public void TestCreatePlaylist()
        {
            string JsonData = "{" +
                                  "\"name\": \"My Playlist 4\"," +
                                  "\"description\": \"New playlist description\"," +
                                  "\"public\":\" false\"" +
                              "}";

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(postUrl);

            restRequest.AddHeader("Authorization", "token" + myToken);
            restRequest.AddJsonBody(JsonData);
            restResponse = restClient.Post(restRequest);
            Assert.AreEqual(201, (int)restResponse.StatusCode);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("Status Code:" + restResponse.StatusCode);
                Console.WriteLine("Response: " + restResponse.Content);
            }

           
        }
    }
}
