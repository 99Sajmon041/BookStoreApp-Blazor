using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace BookStoreApp.Blazor.Server.UI.Services.Base
{
    public class BaseHttpService
    {
        //private readonly IClient client;
        protected readonly IClient client;
        private readonly ILocalStorageService localStorage;
        public BaseHttpService(IClient client, ILocalStorageService localStorage)
        {
            this.client = client;
            this.localStorage = localStorage;
        }

        protected Response<T> ConvertApiExceptions<T>(ApiException apiException)
        {
            if(apiException.StatusCode == 400)
            {
                return new Response<T>() { Message = "Validations errors have occured.", ValidationErrors = apiException.Response, Success = false };
            }
            if (apiException.StatusCode == 404)
            {
                return new Response<T>() { Message = "The requested item  could not be found.", Success = false };
            }
            if(apiException.StatusCode >= 200 && apiException.StatusCode <= 299)
            {
                return new Response<T>() { Message = "Operation reported success.", Success = true };
            }

            return new Response<T>() { Message = "Something went wrong, please try again.", Success = false };
        }

        protected async Task GetBearerToken()
        {
            var token = await localStorage.GetItemAsync<string>("accessToken");
            if(token is not null)
            {
                client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}
