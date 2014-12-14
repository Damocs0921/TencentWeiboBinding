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
	[Protocol (Name = "WeiboRequestDelegate", WrapperType = typeof (WeiboRequestDelegateWrapper))]
	public interface IWeiboRequestDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class WeiboRequestDelegate_Extensions {
		[CompilerGenerated]
		public static void DidReceiveRawData (this IWeiboRequestDelegate This, NSData data, int reqno)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("didReceiveRawData:reqNo:"), data.Handle, reqno);
		}
		
		[CompilerGenerated]
		public static void DidFailWithError (this IWeiboRequestDelegate This, NSError error, int reqno)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("didFailWithError:reqNo:"), error.Handle, reqno);
		}
		
		[CompilerGenerated]
		public static void DidNeedRelogin (this IWeiboRequestDelegate This, NSError error, int reqno)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("didNeedRelogin:reqNo:"), error.Handle, reqno);
		}
		
	}
	
	internal sealed class WeiboRequestDelegateWrapper : BaseWrapper, IWeiboRequestDelegate {
		public WeiboRequestDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public WeiboRequestDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace TXWBB {
	[Protocol]
	[Register("WeiboRequestDelegate", true)]
	[Model]
	public unsafe partial class WeiboRequestDelegate : NSObject, IWeiboRequestDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WeiboRequestDelegate () : base (NSObjectFlag.Empty)
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
		public WeiboRequestDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboRequestDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboRequestDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("didFailWithError:reqNo:")]
		[CompilerGenerated]
		public virtual void DidFailWithError (NSError error, int reqno)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didNeedRelogin:reqNo:")]
		[CompilerGenerated]
		public virtual void DidNeedRelogin (NSError error, int reqno)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didReceiveRawData:reqNo:")]
		[CompilerGenerated]
		public virtual void DidReceiveRawData (NSData data, int reqno)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class WeiboRequestDelegate */
}
