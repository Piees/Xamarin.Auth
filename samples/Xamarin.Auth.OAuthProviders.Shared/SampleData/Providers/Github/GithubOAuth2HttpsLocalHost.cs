﻿using System;

namespace Xamarin.Auth.ProviderSamples
{
	public partial class GithubOAuth2HttpsLocalHost : Helpers.OAuth2
	{
		partial void SetPublicNonSensitiveData();
		partial void SetPrivateSensitiveData();

		public GithubOAuth2HttpsLocalHost()
		{
			SetPublicNonSensitiveData();
			SetPrivateSensitiveData();

			return;
		}

		partial void SetPublicNonSensitiveData()
		{
			HowToMarkDown = 
@"
https://github.com/settings/applications
https://developer.github.com/v3/oauth/#scopes
https://github.com/settings/developers
";
			Description = "Github OAuth2 https://localhost";
			OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "";
			OAuth2_Scope = ""; // "", "user",
			OAuth_UriAuthorization = new Uri("https://github.com/login/oauth/authorize");
            OAuth_UriAccessToken_UriRequestToken = new Uri("https://github.com/login/oauth/access_token");
			OAuth_UriCallbackAKARedirect = new Uri("https://localhost");
			AllowCancel = true;

			return;
		}
	}
}

