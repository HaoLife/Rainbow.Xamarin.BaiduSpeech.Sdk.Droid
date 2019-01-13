using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSpeechSDKContext']"
	[global::Android.Runtime.Register ("com/baidu/speech/core/BDSSpeechSDKContext", DoNotGenerateAcw=true)]
	public partial class BDSSpeechSDKContext : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSpeechSDKContext']/field[@name='ctx']"
		[Register ("ctx")]
		public static global::Android.Content.Context Ctx {
			get {
				const string __id = "ctx.Landroid/content/Context;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ctx.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSSpeechSDKContext", typeof (BDSSpeechSDKContext));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected BDSSpeechSDKContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSpeechSDKContext']/constructor[@name='BDSSpeechSDKContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDSSpeechSDKContext ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
