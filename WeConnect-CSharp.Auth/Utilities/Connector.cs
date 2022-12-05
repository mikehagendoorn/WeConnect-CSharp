using System;
namespace WeConnect_CSharp.Auth.Utilities
{
	public class Connector
	{
		private static readonly string VOLKSWAGEN_HOST = "https://identity.vwgroup.io/oidc/v1/";
		private static readonly string CLIENT_ID = "3c756d46-f1ba-4d78-9f9a-cff0d5292d51@apps_vw-dilab_com";
        private static readonly string SCOPE = "openid profile nickname birthdate phone";

        public Connector()
		{
		}

		public void Connect()
		{

		}

		public void Login()
		{
			string authorizeUrl = VOLKSWAGEN_HOST + "authorize";

		}

		private void Authorize()
		{

		}
	}
}

