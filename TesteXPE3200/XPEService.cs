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
        private readonly string endereco;
        private readonly string login;
        private readonly string senha;
        private readonly string imagem;

        public XPEService(string endereco, string login, string senha, string imagem)
        {
            this.endereco = endereco;
            this.login = login;
            this.senha = senha;
            this.imagem = imagem;
        }

        public void Enviar(bool sincrono, bool emLote, int usuariosEnvio, int numerosPacotes)
        {
            if (sincrono)
            {
                if (emLote)
                {
                    AddUsers(usuariosEnvio, numerosPacotes);
                }
                else
                {
                    AddUsersOneAtTime(usuariosEnvio);
                }
            }
            else
            {
                if (emLote)
                {
                    Task.Run(async () => await AddUsersAsync(usuariosEnvio, numerosPacotes));
                }
                else
                {
                    Task.Run(async () => await AddUsersOneAtTimeAsync(usuariosEnvio));
                }
            }
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

        private void AddUsersOneAtTime(int numberOfUsers)
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

        private async Task AddUsersAsync(int numberOfUsers, int numerosPacotes)
        {
            try
            {
                for (int index = 0; index < numerosPacotes; index++)
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private async Task AddUsersOneAtTimeAsync(int numberOfUsers)
        {
            using (SemaphoreSlim concurrencySemaphore = new SemaphoreSlim(1))
            {
                var users = CreateUsers(numberOfUsers);

                var tasks = new List<Task>();

                foreach (var item in users.Data.Items)
                {
                    concurrencySemaphore.Wait();
                    var task = Task.Run(async () =>
                    {
                        try
                        {
                            return await AddUserAsync(users.Target, users.Action, item);
                        }
                        finally
                        {
                            concurrencySemaphore.Release();
                        }
                    });
                    tasks.Add(task);
                }

                await Task.WhenAll(tasks.ToArray());
            }
        }

        private async Task<bool> AddUserAsync(string target, string action, UserItem userItem)
        {
            try
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

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void AddUsers(int numberOfUsers, int numerosPacotes)
        {
            try
            {
                for (int index = 0; index < numerosPacotes; index++)
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
                items.Add(new UserItem($"Pessoa {userId}", userId.ToString(), imagem));
            }
            
            return new User("user", "add", items);
        }
    }
}
