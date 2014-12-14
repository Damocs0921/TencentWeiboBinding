using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TXWBB
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//

	[BaseType (typeof (NSObject))]
	public partial interface WeiboApiObject {

		[Export ("appKey", ArgumentSemantic.Copy)]
		string AppKey { get; set; }

		[Export ("appSecret", ArgumentSemantic.Copy)]
		string AppSecret { get; set; }

		[Export ("redirectUri", ArgumentSemantic.Copy)]
		string RedirectUri { get; set; }

		[Export ("userName", ArgumentSemantic.Copy)]
		string UserName { get; set; }

		[Export ("userNick", ArgumentSemantic.Copy)]
		string UserNick { get; set; }

		[Export ("openid", ArgumentSemantic.Copy)]
		string Openid { get; set; }

		[Export ("accessToken", ArgumentSemantic.Copy)]
		string AccessToken { get; set; }

		[Export ("refreshToken", ArgumentSemantic.Copy)]
		string RefreshToken { get; set; }

		[Export ("expires")]
		double Expires { get; set; }

		[Export ("realAuthMode")]
		int RealAuthMode { get; set; }

		[Export ("authMode")]
		int AuthMode { get; set; }

		[Export ("systemSSOUsable")]
		int SystemSSOUsable { get; set; }

		[Export ("AppSSOUsable")]
		int AppSSOUsable { get; set; }

		[Export ("authDelegate", ArgumentSemantic.Assign)]
		NSObject AuthDelegate { get; set; }

		[Export ("authDelegate2", ArgumentSemantic.Assign)]
		NSObject AuthDelegate2 { get; set; }

		[Export ("reqDelegate", ArgumentSemantic.Assign)]
		NSObject ReqDelegate { get; set; }

		[Export ("rootViewCtrl", ArgumentSemantic.Retain)]
		UIViewController RootViewCtrl { get; set; }
	}


	[BaseType (typeof (NSObject))]
	public partial interface WeiboApi {

		[Export ("initWithAppKey:andSecret:andRedirectUri:andAuthModeFlag:andCachePolicy:")]
		IntPtr Constructor (string theAppkey, string theSecret, string theRedirecturi, int theAuthModeFlag, int theCachePolicy);

		[Export ("loginWithDelegate:andRootController:")]
		void LoginWithDelegate (NSObject theDelegate, UIViewController rootCtrl);

		[Export ("requestWithParams:apiName:httpMethod:delegate:")]
		int RequestWithParams (NSMutableDictionary param, string apiName, string httpMethod, NSObject del);

		[Export ("SetToken:")]
		void SetToken(WeiboApiObject weiboObj);

		[Export ("getToken")]
		WeiboApiObject GetToken();

		[Export ("cancelAuth")]
		void CancelAuth ();

		[Export ("checkAuthValid:andDelegete:")]
		void CheckAuthValid (int theCheckAuthFlag, NSObject theDelegete);

		[Export ("setLogLevel:")]
		void SetLogLevel(int loglevel);

		[Export ("handleOpenURL:")]
		bool HandleOpenURL (NSUrl url);
	}


	[Model][Protocol]
	[BaseType(typeof(NSObject))]
	public partial interface WeiboAuthDelegate {

		[Export ("DidAuthFinished:")]
		void  DidAuthFinished(WeiboApiObject wbobj);

		[Export ("DidAuthCanceled:")]
		void  DidAuthCanceled(WeiboApiObject wbobj);

		[Export ("DidAuthFailWithError:")]
		void  DidAuthFailWithError(NSError error);

		[Export ("didCheckAuthValid:suggest:")]
		void DidCheckAuthValid(bool bResult, string strSuggestion);
	}


	[Model][Protocol]
	[BaseType(typeof(NSObject))]
	public partial interface WeiboRequestDelegate {

		[Export ("didReceiveRawData:reqNo:")]
		void DidReceiveRawData (NSData data, int reqno);

		[Export ("didFailWithError:reqNo:")]
		void DidFailWithError (NSError error, int reqno);

		[Export ("didNeedRelogin:reqNo:")]
		void DidNeedRelogin (NSError error, int reqno);
	}

}

