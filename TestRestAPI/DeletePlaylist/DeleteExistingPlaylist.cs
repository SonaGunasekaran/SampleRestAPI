using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Net;

namespace TestRestAPI.DeletePlaylist
{
    [TestClass]
    public class DeleteExistingPlaylist
    {
        private string myToken = "Bearer BQAy03ds0vNU22qlu51xwMai3Y50qrd6f7xhRF5ges1D2GqFLui8Z1DBCKz3ACkFB-TyBzN7atmRSmaa6xDauv5i8rCQPCBU80xvqr8ryxSwpJ--oZYdOjEGeQCq-jlSDaLXeRgKc9AT45dnu-an-CmwrBT-cIQ4amyNYVDFz36P4XIuu2qxZ3K3Qz4cwKABYqfuQgXbJFG47CHQIbX-W-2cK-okdvRXw9iundyKQadeSAgBBtebDdQnajP68HErPcu0pam2hMnEybJlRjr_gYJyGIcE1ol08uLSPNQ7";
        private string deleteUrl = "https://api.spotify.com/v1/playlists/39kaAAGLwt492cEWtFsLJi/tracks";
        private static IRestResponse restResponse { get; set; }
        [TestMethod]
        public void TestDeleteUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(deleteUrl);
            restRequest.AddHeader("Authorization", "token" + myToken);
            restResponse = restClient.Get(restRequest);
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("Status Code " + restResponse.StatusCode);
                Console.WriteLine("Response Content " + restResponse.Content);
            }

        }

    }
}

