using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Net;


namespace TestRestAPI.PostRequest
{
    [TestClass]
    public class TestPostWithJsonData
    {
        private string myToken = "Bearer BQAy03ds0vNU22qlu51xwMai3Y50qrd6f7xhRF5ges1D2GqFLui8Z1DBCKz3ACkFB-TyBzN7atmRSmaa6xDauv5i8rCQPCBU80xvqr8ryxSwpJ--oZYdOjEGeQCq-jlSDaLXeRgKc9AT45dnu-an-CmwrBT-cIQ4amyNYVDFz36P4XIuu2qxZ3K3Qz4cwKABYqfuQgXbJFG47CHQIbX-W-2cK-okdvRXw9iundyKQadeSAgBBtebDdQnajP68HErPcu0pam2hMnEybJlRjr_gYJyGIcE1ol08uLSPNQ7";
        private string postUrl = "https://api.spotify.com/v1/users/s27dmlg557v3itkvxtlfahdey/playlists";
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
