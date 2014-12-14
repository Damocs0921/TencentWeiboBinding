//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.SceneKit;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.AddressBook;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace TXWBB {
	[Register("WeiboApi", true)]
	public unsafe partial class WeiboApi : NSObject {
		[CompilerGenerated]
		const string selCancelAuth = "cancelAuth";
		static readonly IntPtr selCancelAuthHandle = Selector.GetHandle ("cancelAuth");
		[CompilerGenerated]
		const string selCheckAuthValidAndDelegete_ = "checkAuthValid:andDelegete:";
		static readonly IntPtr selCheckAuthValidAndDelegete_Handle = Selector.GetHandle ("checkAuthValid:andDelegete:");
		[CompilerGenerated]
		const string selGetToken = "getToken";
		static readonly IntPtr selGetTokenHandle = Selector.GetHandle ("getToken");
		[CompilerGenerated]
		const string selHandleOpenURL_ = "handleOpenURL:";
		static readonly IntPtr selHandleOpenURL_Handle = Selector.GetHandle ("handleOpenURL:");
		[CompilerGenerated]
		const string selInitWithAppKeyAndSecretAndRedirectUriAndAuthModeFlagAndCachePolicy_ = "initWithAppKey:andSecret:andRedirectUri:andAuthModeFlag:andCachePolicy:";
		static readonly IntPtr selInitWithAppKeyAndSecretAndRedirectUriAndAuthModeFlagAndCachePolicy_Handle = Selector.GetHandle ("initWithAppKey:andSecret:andRedirectUri:andAuthModeFlag:andCachePolicy:");
		[CompilerGenerated]
		const string selLoginWithDelegateAndRootController_ = "loginWithDelegate:andRootController:";
		static readonly IntPtr selLoginWithDelegateAndRootController_Handle = Selector.GetHandle ("loginWithDelegate:andRootController:");
		[CompilerGenerated]
		const string selRequestWithParamsApiNameHttpMethodDelegate_ = "requestWithParams:apiName:httpMethod:delegate:";
		static readonly IntPtr selRequestWithParamsApiNameHttpMethodDelegate_Handle = Selector.GetHandle ("requestWithParams:apiName:httpMethod:delegate:");
		[CompilerGenerated]
		const string selSetLogLevel_ = "setLogLevel:";
		static readonly IntPtr selSetLogLevel_Handle = Selector.GetHandle ("setLogLevel:");
		[CompilerGenerated]
		const string selSetToken_ = "SetToken:";
		static readonly IntPtr selSetToken_Handle = Selector.GetHandle ("SetToken:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WeiboApi");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WeiboApi () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public WeiboApi (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboApi (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboApi (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAppKey:andSecret:andRedirectUri:andAuthModeFlag:andCachePolicy:")]
		[CompilerGenerated]
		public WeiboApi (string theAppkey, string theSecret, string theRedirecturi, int theAuthModeFlag, int theCachePolicy)
			: base (NSObjectFlag.Empty)
		{
			if (theAppkey == null)
				throw new ArgumentNullException ("theAppkey");
			if (theSecret == null)
				throw new ArgumentNullException ("theSecret");
			if (theRedirecturi == null)
				throw new ArgumentNullException ("theRedirecturi");
			var nstheAppkey = NSString.CreateNative (theAppkey);
			var nstheSecret = NSString.CreateNative (theSecret);
			var nstheRedirecturi = NSString.CreateNative (theRedirecturi);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int_int (this.Handle, selInitWithAppKeyAndSecretAndRedirectUriAndAuthModeFlagAndCachePolicy_Handle, nstheAppkey, nstheSecret, nstheRedirecturi, theAuthModeFlag, theCachePolicy), "initWithAppKey:andSecret:andRedirectUri:andAuthModeFlag:andCachePolicy:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_int (this.SuperHandle, selInitWithAppKeyAndSecretAndRedirectUriAndAuthModeFlagAndCachePolicy_Handle, nstheAppkey, nstheSecret, nstheRedirecturi, theAuthModeFlag, theCachePolicy), "initWithAppKey:andSecret:andRedirectUri:andAuthModeFlag:andCachePolicy:");
			}
			NSString.ReleaseNative (nstheAppkey);
			NSString.ReleaseNative (nstheSecret);
			NSString.ReleaseNative (nstheRedirecturi);
			
		}
		
		[Export ("cancelAuth")]
		[CompilerGenerated]
		public virtual void CancelAuth ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selCancelAuthHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelAuthHandle);
			}
		}
		
		[Export ("checkAuthValid:andDelegete:")]
		[CompilerGenerated]
		public virtual void CheckAuthValid (int theCheckAuthFlag, NSObject theDelegete)
		{
			if (theDelegete == null)
				throw new ArgumentNullException ("theDelegete");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, selCheckAuthValidAndDelegete_Handle, theCheckAuthFlag, theDelegete.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, selCheckAuthValidAndDelegete_Handle, theCheckAuthFlag, theDelegete.Handle);
			}
		}
		
		[Export ("getToken")]
		[CompilerGenerated]
		public virtual WeiboApiObject GetToken ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<WeiboApiObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selGetTokenHandle));
			} else {
				return  Runtime.GetNSObject<WeiboApiObject> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGetTokenHandle));
			}
		}
		
		[Export ("handleOpenURL:")]
		[CompilerGenerated]
		public virtual bool HandleOpenURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selHandleOpenURL_Handle, url.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selHandleOpenURL_Handle, url.Handle);
			}
		}
		
		[Export ("loginWithDelegate:andRootController:")]
		[CompilerGenerated]
		public virtual void LoginWithDelegate (NSObject theDelegate, global::MonoTouch.UIKit.UIViewController rootCtrl)
		{
			if (theDelegate == null)
				throw new ArgumentNullException ("theDelegate");
			if (rootCtrl == null)
				throw new ArgumentNullException ("rootCtrl");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selLoginWithDelegateAndRootController_Handle, theDelegate.Handle, rootCtrl.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selLoginWithDelegateAndRootController_Handle, theDelegate.Handle, rootCtrl.Handle);
			}
		}
		
		[Export ("requestWithParams:apiName:httpMethod:delegate:")]
		[CompilerGenerated]
		public virtual int RequestWithParams (NSMutableDictionary param, string apiName, string httpMethod, NSObject del)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (apiName == null)
				throw new ArgumentNullException ("apiName");
			if (httpMethod == null)
				throw new ArgumentNullException ("httpMethod");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsapiName = NSString.CreateNative (apiName);
			var nshttpMethod = NSString.CreateNative (httpMethod);
			
			int ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selRequestWithParamsApiNameHttpMethodDelegate_Handle, param.Handle, nsapiName, nshttpMethod, del.Handle);
			} else {
				ret = ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selRequestWithParamsApiNameHttpMethodDelegate_Handle, param.Handle, nsapiName, nshttpMethod, del.Handle);
			}
			NSString.ReleaseNative (nsapiName);
			NSString.ReleaseNative (nshttpMethod);
			
			return ret;
		}
		
		[Export ("setLogLevel:")]
		[CompilerGenerated]
		public virtual void SetLogLevel (int loglevel)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, selSetLogLevel_Handle, loglevel);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLogLevel_Handle, loglevel);
			}
		}
		
		[Export ("SetToken:")]
		[CompilerGenerated]
		public virtual void SetToken (WeiboApiObject weiboObj)
		{
			if (weiboObj == null)
				throw new ArgumentNullException ("weiboObj");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetToken_Handle, weiboObj.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetToken_Handle, weiboObj.Handle);
			}
		}
		
	} /* class WeiboApi */
}
