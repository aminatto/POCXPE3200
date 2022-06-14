using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators.Digest;
using RestSharp.Serializers.Utf8Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteXPE3200
{
    public class XPEService
    {
        private string image = @"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";

        private string endereco;
        private string login;
        private string senha;

        public XPEService(string endereco, string login, string senha)
        {
            this.endereco = endereco;
            this.login = login;
            this.senha = senha;
        }

        public void AddUsersOneAtTime(int numberOfUsers)
        {
            try
            {
                var users = CreateUsers(numberOfUsers);

                foreach (var items in users.Data.Items)
                {
                    AddUser(users.Target, users.Action, items);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task AddUsersOneAtTimeAsync(int numberOfUsers)
        {
            try
            {
                Semaphore semaphoreObject = new Semaphore(initialCount: 1, maximumCount: 1);

                var users = CreateUsers(numberOfUsers);

                var executions = new List<Task>();

                foreach (var items in users.Data.Items)
                {
                    executions.Add(Task.Run(() =>
                    {
                        semaphoreObject.WaitOne();
                        AddUser(users.Target, users.Action, items);
                        semaphoreObject.Release();
                    }));
                }

                await Task.WhenAll(executions);

                //foreach (var items in users.Data.Items)
                //{
                //    await AddUserAsync(users.Target, users.Action, items);

                //    await Task.Delay(2000);
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private async Task AddUserAsync(string target, string action, UserItem userItem)
        {
            var sendUser = new User(target, action, new List<UserItem> { userItem });

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(sendUser), Encoding.UTF8);

            var requestUri = new Uri($"{endereco}/api/user/add");

            var credCache = new CredentialCache
            {
                {
                    new Uri($"{endereco}"),
                    "Digest",
                    new NetworkCredential(login, senha)
                }
            };

            using var clientHander = new HttpClientHandler
            {
                Credentials = credCache,
                PreAuthenticate = true
            };

            using var httpClient = new HttpClient(clientHander);
            var responseTask = await httpClient.PostAsync(requestUri, httpContent);
            responseTask.EnsureSuccessStatusCode();
        }

        private void AddUser(string target, string action, UserItem userItem)
        {
            var sendUser = new User(target, action, new List<UserItem> { userItem });

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(sendUser), Encoding.UTF8);

            var requestUri = new Uri($"{endereco}/api/user/add");

            var credCache = new CredentialCache
            {
                {
                    new Uri($"{endereco}"),
                    "Digest",
                    new NetworkCredential(login, senha)
                }
            };

            using var clientHander = new HttpClientHandler
            {
                Credentials = credCache,
                PreAuthenticate = true
            };

            using var httpClient = new HttpClient(clientHander);

            var webRequest = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Content = httpContent,
            };

            var responseTask = httpClient.Send(webRequest);
            responseTask.EnsureSuccessStatusCode();
        }

        public void AddUsers(int numberOfUsers)
        {
            try
            {
                var users = CreateUsers(numberOfUsers);

                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(users), Encoding.UTF8);

                var requestUri = new Uri($"{endereco}/api/user/add");

                var credCache = new CredentialCache
                {
                    {
                        new Uri($"{endereco}"),
                        "Digest",
                        new NetworkCredential(login, senha)
                    }
                };

                using var clientHander = new HttpClientHandler
                {
                    Credentials = credCache,
                    PreAuthenticate = true
                };

                using var httpClient = new HttpClient(clientHander);

                var webRequest = new HttpRequestMessage(HttpMethod.Post, requestUri)
                {
                    Content = httpContent,
                };

                var responseTask = httpClient.Send(webRequest);
                responseTask.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public async Task AddUsersAsync(int numberOfUsers)
        {
            try
            {
                var users = CreateUsers(numberOfUsers);

                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(users), Encoding.UTF8);

                var requestUri = new Uri($"{endereco}/api/user/add");

                var credCache = new CredentialCache
                {
                    {
                        new Uri($"{endereco}"),
                        "Digest",
                        new NetworkCredential(login, senha)
                    }
                };

                using var clientHander = new HttpClientHandler
                {
                    Credentials = credCache,
                    PreAuthenticate = true
                };

                using var httpClient = new HttpClient(clientHander);
                var responseTask = await httpClient.PostAsync(requestUri, httpContent);
                responseTask.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private User CreateUsers(int numberOfUsers)
        {
            var items = new List<UserItem>();

            for (int index = 0; index < numberOfUsers; index++)
            {
                var userId = index + 1;
                items.Add(new UserItem($"Pessoa {userId}", userId.ToString(), image));
            }

            User user = new User("user", "add", items);

            return user;
        }
    }
}
