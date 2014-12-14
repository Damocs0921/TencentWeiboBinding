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
	[Register("WeiboApiObject", true)]
	public unsafe partial class WeiboApiObject : NSObject {
		[CompilerGenerated]
		const string selAccessToken = "accessToken";
		static readonly IntPtr selAccessTokenHandle = Selector.GetHandle ("accessToken");
		[CompilerGenerated]
		const string selAppKey = "appKey";
		static readonly IntPtr selAppKeyHandle = Selector.GetHandle ("appKey");
		[CompilerGenerated]
		const string selAppSecret = "appSecret";
		static readonly IntPtr selAppSecretHandle = Selector.GetHandle ("appSecret");
		[CompilerGenerated]
		const string selAppSSOUsable = "AppSSOUsable";
		static readonly IntPtr selAppSSOUsableHandle = Selector.GetHandle ("AppSSOUsable");
		[CompilerGenerated]
		const string selAuthDelegate = "authDelegate";
		static readonly IntPtr selAuthDelegateHandle = Selector.GetHandle ("authDelegate");
		[CompilerGenerated]
		const string selAuthDelegate2 = "authDelegate2";
		static readonly IntPtr selAuthDelegate2Handle = Selector.GetHandle ("authDelegate2");
		[CompilerGenerated]
		const string selAuthMode = "authMode";
		static readonly IntPtr selAuthModeHandle = Selector.GetHandle ("authMode");
		[CompilerGenerated]
		const string selExpires = "expires";
		static readonly IntPtr selExpiresHandle = Selector.GetHandle ("expires");
		[CompilerGenerated]
		const string selOpenid = "openid";
		static readonly IntPtr selOpenidHandle = Selector.GetHandle ("openid");
		[CompilerGenerated]
		const string selRealAuthMode = "realAuthMode";
		static readonly IntPtr selRealAuthModeHandle = Selector.GetHandle ("realAuthMode");
		[CompilerGenerated]
		const string selRedirectUri = "redirectUri";
		static readonly IntPtr selRedirectUriHandle = Selector.GetHandle ("redirectUri");
		[CompilerGenerated]
		const string selRefreshToken = "refreshToken";
		static readonly IntPtr selRefreshTokenHandle = Selector.GetHandle ("refreshToken");
		[CompilerGenerated]
		const string selReqDelegate = "reqDelegate";
		static readonly IntPtr selReqDelegateHandle = Selector.GetHandle ("reqDelegate");
		[CompilerGenerated]
		const string selRootViewCtrl = "rootViewCtrl";
		static readonly IntPtr selRootViewCtrlHandle = Selector.GetHandle ("rootViewCtrl");
		[CompilerGenerated]
		const string selSetAccessToken_ = "setAccessToken:";
		static readonly IntPtr selSetAccessToken_Handle = Selector.GetHandle ("setAccessToken:");
		[CompilerGenerated]
		const string selSetAppKey_ = "setAppKey:";
		static readonly IntPtr selSetAppKey_Handle = Selector.GetHandle ("setAppKey:");
		[CompilerGenerated]
		const string selSetAppSecret_ = "setAppSecret:";
		static readonly IntPtr selSetAppSecret_Handle = Selector.GetHandle ("setAppSecret:");
		[CompilerGenerated]
		const string selSetAppSSOUsable_ = "setAppSSOUsable:";
		static readonly IntPtr selSetAppSSOUsable_Handle = Selector.GetHandle ("setAppSSOUsable:");
		[CompilerGenerated]
		const string selSetAuthDelegate_ = "setAuthDelegate:";
		static readonly IntPtr selSetAuthDelegate_Handle = Selector.GetHandle ("setAuthDelegate:");
		[CompilerGenerated]
		const string selSetAuthDelegate2_ = "setAuthDelegate2:";
		static readonly IntPtr selSetAuthDelegate2_Handle = Selector.GetHandle ("setAuthDelegate2:");
		[CompilerGenerated]
		const string selSetAuthMode_ = "setAuthMode:";
		static readonly IntPtr selSetAuthMode_Handle = Selector.GetHandle ("setAuthMode:");
		[CompilerGenerated]
		const string selSetExpires_ = "setExpires:";
		static readonly IntPtr selSetExpires_Handle = Selector.GetHandle ("setExpires:");
		[CompilerGenerated]
		const string selSetOpenid_ = "setOpenid:";
		static readonly IntPtr selSetOpenid_Handle = Selector.GetHandle ("setOpenid:");
		[CompilerGenerated]
		const string selSetRealAuthMode_ = "setRealAuthMode:";
		static readonly IntPtr selSetRealAuthMode_Handle = Selector.GetHandle ("setRealAuthMode:");
		[CompilerGenerated]
		const string selSetRedirectUri_ = "setRedirectUri:";
		static readonly IntPtr selSetRedirectUri_Handle = Selector.GetHandle ("setRedirectUri:");
		[CompilerGenerated]
		const string selSetRefreshToken_ = "setRefreshToken:";
		static readonly IntPtr selSetRefreshToken_Handle = Selector.GetHandle ("setRefreshToken:");
		[CompilerGenerated]
		const string selSetReqDelegate_ = "setReqDelegate:";
		static readonly IntPtr selSetReqDelegate_Handle = Selector.GetHandle ("setReqDelegate:");
		[CompilerGenerated]
		const string selSetRootViewCtrl_ = "setRootViewCtrl:";
		static readonly IntPtr selSetRootViewCtrl_Handle = Selector.GetHandle ("setRootViewCtrl:");
		[CompilerGenerated]
		const string selSetSystemSSOUsable_ = "setSystemSSOUsable:";
		static readonly IntPtr selSetSystemSSOUsable_Handle = Selector.GetHandle ("setSystemSSOUsable:");
		[CompilerGenerated]
		const string selSetUserName_ = "setUserName:";
		static readonly IntPtr selSetUserName_Handle = Selector.GetHandle ("setUserName:");
		[CompilerGenerated]
		const string selSetUserNick_ = "setUserNick:";
		static readonly IntPtr selSetUserNick_Handle = Selector.GetHandle ("setUserNick:");
		[CompilerGenerated]
		const string selSystemSSOUsable = "systemSSOUsable";
		static readonly IntPtr selSystemSSOUsableHandle = Selector.GetHandle ("systemSSOUsable");
		[CompilerGenerated]
		const string selUserName = "userName";
		static readonly IntPtr selUserNameHandle = Selector.GetHandle ("userName");
		[CompilerGenerated]
		const string selUserNick = "userNick";
		static readonly IntPtr selUserNickHandle = Selector.GetHandle ("userNick");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WeiboApiObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WeiboApiObject () : base (NSObjectFlag.Empty)
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
		public WeiboApiObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboApiObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboApiObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string AccessToken {
			[Export ("accessToken", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessTokenHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAccessTokenHandle));
				}
			}
			
			[Export ("setAccessToken:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessToken_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAccessToken_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string AppKey {
			[Export ("appKey", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selAppKeyHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAppKeyHandle));
				}
			}
			
			[Export ("setAppKey:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAppKey_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAppKey_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string AppSecret {
			[Export ("appSecret", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selAppSecretHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAppSecretHandle));
				}
			}
			
			[Export ("setAppSecret:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAppSecret_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAppSecret_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int AppSSOUsable {
			[Export ("AppSSOUsable")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.int_objc_msgSend (this.Handle, selAppSSOUsableHandle);
				} else {
					return ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, selAppSSOUsableHandle);
				}
			}
			
			[Export ("setAppSSOUsable:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, selSetAppSSOUsable_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetAppSSOUsable_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_AuthDelegate_var;
		[CompilerGenerated]
		public virtual NSObject AuthDelegate {
			[Export ("authDelegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selAuthDelegateHandle));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAuthDelegateHandle));
				}
				MarkDirty ();
				__mt_AuthDelegate_var = ret;
				return ret;
			}
			
			[Export ("setAuthDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAuthDelegate_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAuthDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_AuthDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AuthDelegate2_var;
		[CompilerGenerated]
		public virtual NSObject AuthDelegate2 {
			[Export ("authDelegate2", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selAuthDelegate2Handle));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAuthDelegate2Handle));
				}
				MarkDirty ();
				__mt_AuthDelegate2_var = ret;
				return ret;
			}
			
			[Export ("setAuthDelegate2:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAuthDelegate2_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAuthDelegate2_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_AuthDelegate2_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual int AuthMode {
			[Export ("authMode")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.int_objc_msgSend (this.Handle, selAuthModeHandle);
				} else {
					return ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, selAuthModeHandle);
				}
			}
			
			[Export ("setAuthMode:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, selSetAuthMode_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetAuthMode_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Expires {
			[Export ("expires")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, selExpiresHandle);
				} else {
					return ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selExpiresHandle);
				}
			}
			
			[Export ("setExpires:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, selSetExpires_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetExpires_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Openid {
			[Export ("openid", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selOpenidHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOpenidHandle));
				}
			}
			
			[Export ("setOpenid:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOpenid_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOpenid_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int RealAuthMode {
			[Export ("realAuthMode")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.int_objc_msgSend (this.Handle, selRealAuthModeHandle);
				} else {
					return ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, selRealAuthModeHandle);
				}
			}
			
			[Export ("setRealAuthMode:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, selSetRealAuthMode_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetRealAuthMode_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string RedirectUri {
			[Export ("redirectUri", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selRedirectUriHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRedirectUriHandle));
				}
			}
			
			[Export ("setRedirectUri:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRedirectUri_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRedirectUri_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string RefreshToken {
			[Export ("refreshToken", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selRefreshTokenHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRefreshTokenHandle));
				}
			}
			
			[Export ("setRefreshToken:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRefreshToken_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRefreshToken_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_ReqDelegate_var;
		[CompilerGenerated]
		public virtual NSObject ReqDelegate {
			[Export ("reqDelegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selReqDelegateHandle));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selReqDelegateHandle));
				}
				MarkDirty ();
				__mt_ReqDelegate_var = ret;
				return ret;
			}
			
			[Export ("setReqDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetReqDelegate_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetReqDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ReqDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RootViewCtrl_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController RootViewCtrl {
			[Export ("rootViewCtrl", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selRootViewCtrlHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRootViewCtrlHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RootViewCtrl_var = ret;
				return ret;
			}
			
			[Export ("setRootViewCtrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRootViewCtrl_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRootViewCtrl_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RootViewCtrl_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual int SystemSSOUsable {
			[Export ("systemSSOUsable")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.int_objc_msgSend (this.Handle, selSystemSSOUsableHandle);
				} else {
					return ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSystemSSOUsableHandle);
				}
			}
			
			[Export ("setSystemSSOUsable:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, selSetSystemSSOUsable_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetSystemSSOUsable_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string UserName {
			[Export ("userName", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selUserNameHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserNameHandle));
				}
			}
			
			[Export ("setUserName:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserName_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UserNick {
			[Export ("userNick", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selUserNickHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserNickHandle));
				}
			}
			
			[Export ("setUserNick:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserNick_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserNick_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AuthDelegate_var = null;
				__mt_AuthDelegate2_var = null;
				__mt_ReqDelegate_var = null;
				__mt_RootViewCtrl_var = null;
			}
		}
	} /* class WeiboApiObject */
}
