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
	[Protocol (Name = "WeiboAuthDelegate", WrapperType = typeof (WeiboAuthDelegateWrapper))]
	public interface IWeiboAuthDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class WeiboAuthDelegate_Extensions {
		[CompilerGenerated]
		public static void DidAuthFinished (this IWeiboAuthDelegate This, WeiboApiObject wbobj)
		{
			if (wbobj == null)
				throw new ArgumentNullException ("wbobj");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("DidAuthFinished:"), wbobj.Handle);
		}
		
		[CompilerGenerated]
		public static void DidAuthCanceled (this IWeiboAuthDelegate This, WeiboApiObject wbobj)
		{
			if (wbobj == null)
				throw new ArgumentNullException ("wbobj");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("DidAuthCanceled:"), wbobj.Handle);
		}
		
		[CompilerGenerated]
		public static void DidAuthFailWithError (this IWeiboAuthDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("DidAuthFailWithError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidCheckAuthValid (this IWeiboAuthDelegate This, bool bResult, string strSuggestion)
		{
			if (strSuggestion == null)
				throw new ArgumentNullException ("strSuggestion");
			var nsstrSuggestion = NSString.CreateNative (strSuggestion);
			
			ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("didCheckAuthValid:suggest:"), bResult, nsstrSuggestion);
			NSString.ReleaseNative (nsstrSuggestion);
			
		}
		
	}
	
	internal sealed class WeiboAuthDelegateWrapper : BaseWrapper, IWeiboAuthDelegate {
		public WeiboAuthDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public WeiboAuthDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace TXWBB {
	[Protocol]
	[Register("WeiboAuthDelegate", true)]
	[Model]
	public unsafe partial class WeiboAuthDelegate : NSObject, IWeiboAuthDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WeiboAuthDelegate () : base (NSObjectFlag.Empty)
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
		public WeiboAuthDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboAuthDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboAuthDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("DidAuthCanceled:")]
		[CompilerGenerated]
		public virtual void DidAuthCanceled (WeiboApiObject wbobj)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("DidAuthFailWithError:")]
		[CompilerGenerated]
		public virtual void DidAuthFailWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("DidAuthFinished:")]
		[CompilerGenerated]
		public virtual void DidAuthFinished (WeiboApiObject wbobj)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didCheckAuthValid:suggest:")]
		[CompilerGenerated]
		public virtual void DidCheckAuthValid (bool bResult, string strSuggestion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class WeiboAuthDelegate */
}
