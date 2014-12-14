using System;

namespace TXWBB
{
	public enum TCWBErrorCode{
		Interface = 100,
		SDK = 101
	}

	public enum TCWBSDKErrorCode{
		RequestError = 201,
		AccessError = 202,
		bErrorCodeNoAuth = 203,
		ErrorCodeNoRefreshToken = 204,
		AuthorizeError = 205,
		SSOError = 206
	}

	public enum ELogLevel{
		Error = 0,
		Info = 1,
		Debug = 2
	}
}

