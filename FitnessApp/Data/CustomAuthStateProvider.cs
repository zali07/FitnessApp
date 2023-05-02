using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Mail;
using System.Security.Claims;

namespace FitnessApp.Data
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;
        public CustomAuthStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService  = sessionStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //var emailAddress = await _sessionStorageService.GetItemAsync<string>("emailAddress");
            ClaimsIdentity identity;

            //if (emailAddress != null)
            //{
            //    identity = new ClaimsIdentity(new[]
            //    {
            //        new Claim(ClaimTypes.Name, emailAddress)
            //    }, "apiauth_type");
            //}
            //else
            //{
            //    identity = new ClaimsIdentity();
            //}

            identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "admin")
                }, "apiauth_type");
            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAuthenticated(string emailAddress)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, emailAddress)
            }, "apiauth_type");
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            //_sessionStorageService.RemoveItemAsync("emailAddress");
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

    }
}
