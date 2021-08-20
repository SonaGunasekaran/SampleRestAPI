/*
 * Project:validating the API services and performing the operations like post,put,get,delete
 * Author:Sona G
 * Date:18/08/2021
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;


namespace TestRestAPI.GetRequest
{
    [TestClass]
    public class TestGetEndPoint
    {
        private string mytoken = "Bearer BQDfmen6kZdRF1yhFrwha38VPxWdPJkdp1qyO93qrIwea-YWAgenzJKn4ilMfqacYcDu1nyMWjewk_i-4ge6em-dWmjjUddKQDBlfHXflpLCeNWrIyAQZicP3L0IisqMLai0PKLulJFW9nRziylpqq5b0MvdXEzSr4jFdQm81SvXuFrn6lKUR_Vv1WrdNw8foNdDQwhj0-C5N9UcXZ-9Yujw4VJ6L6UAwluh8r-hM84XgMJtDMkFZPWpU0UxBm11UNubNiYKRPhiES9tow0hrrMreoJZXWoh2rXh3erA";
        int userId;
        IRestResponse restResponse { get; set; }

        [TestMethod]
        public void TestGetCurrentPlaylist()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest("https://api.spotify.com/v1/users/s27dmlg557v3itkvxtlfahdey/playlists");
            restRequest.AddHeader("Authorization", "token" + mytoken);
            IRestResponse restResponse = restClient.Get(restRequest);
            IRestResponse<List<TestUserId>> restResponse1 = restClient.Get<List<TestUserId>>(restRequest);
            var res = restResponse1.Data;
            foreach (var r in res)
            {
                userId = r.id;
            }
            Console.WriteLine(userId);

        }
    }
}
