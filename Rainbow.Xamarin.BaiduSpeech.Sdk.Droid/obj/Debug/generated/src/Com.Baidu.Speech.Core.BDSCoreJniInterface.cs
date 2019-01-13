using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSCoreJniInterface']"
	[global::Android.Runtime.Register ("com/baidu/speech/core/BDSCoreJniInterface", DoNotGenerateAcw=true)]
	public partial class BDSCoreJniInterface : global::Java.Lang.Object, global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSCoreJniInterface", typeof (BDSCoreJniInterface));
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

		protected BDSCoreJniInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSCoreJniInterface']/constructor[@name='BDSCoreJniInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDSCoreJniInterface ()
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

		static Delegate cb_EchoMessage_Lcom_baidu_speech_core_BDSMessage_;
#pragma warning disable 0169
		static Delegate GetEchoMessage_Lcom_baidu_speech_core_BDSMessage_Handler ()
		{
			if (cb_EchoMessage_Lcom_baidu_speech_core_BDSMessage_ == null)
				cb_EchoMessage_Lcom_baidu_speech_core_BDSMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EchoMessage_Lcom_baidu_speech_core_BDSMessage_);
			return cb_EchoMessage_Lcom_baidu_speech_core_BDSMessage_;
		}

		static void n_EchoMessage_Lcom_baidu_speech_core_BDSMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Core.BDSCoreJniInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSCoreJniInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Core.BDSMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EchoMessage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSCoreJniInterface']/method[@name='EchoMessage' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.core.BDSMessage']]"
		[Register ("EchoMessage", "(Lcom/baidu/speech/core/BDSMessage;)V", "GetEchoMessage_Lcom_baidu_speech_core_BDSMessage_Handler")]
		public virtual unsafe void EchoMessage (global::Com.Baidu.Speech.Core.BDSMessage p0)
		{
			const string __id = "EchoMessage.(Lcom/baidu/speech/core/BDSMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSCoreJniInterface']/method[@name='getNewSDK' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNewSDK", "(Ljava/lang/String;)Lcom/baidu/speech/core/BDSCoreJniInterface;", "")]
		public static unsafe global::Com.Baidu.Speech.Core.BDSCoreJniInterface GetNewSDK (string p0)
		{
			const string __id = "getNewSDK.(Ljava/lang/String;)Lcom/baidu/speech/core/BDSCoreJniInterface;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSCoreJniInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_instanceInitialized;
#pragma warning disable 0169
		static Delegate GetInstanceInitializedHandler ()
		{
			if (cb_instanceInitialized == null)
				cb_instanceInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_InstanceInitialized);
			return cb_instanceInitialized;
		}

		static bool n_InstanceInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Speech.Core.BDSCoreJniInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSCoreJniInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InstanceInitialized ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSCoreJniInterface']/method[@name='instanceInitialized' and count(parameter)=0]"
		[Register ("instanceInitialized", "()Z", "GetInstanceInitializedHandler")]
		public virtual unsafe bool InstanceInitialized ()
		{
			const string __id = "instanceInitialized.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_postMessage_Lcom_baidu_speech_core_BDSMessage_;
#pragma warning disable 0169
		static Delegate GetPostMessage_Lcom_baidu_speech_core_BDSMessage_Handler ()
		{
			if (cb_postMessage_Lcom_baidu_speech_core_BDSMessage_ == null)
				cb_postMessage_Lcom_baidu_speech_core_BDSMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_PostMessage_Lcom_baidu_speech_core_BDSMessage_);
			return cb_postMessage_Lcom_baidu_speech_core_BDSMessage_;
		}

		static int n_PostMessage_Lcom_baidu_speech_core_BDSMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Core.BDSCoreJniInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSCoreJniInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Core.BDSMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PostMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSCoreJniInterface']/method[@name='postMessage' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.core.BDSMessage']]"
		[Register ("postMessage", "(Lcom/baidu/speech/core/BDSMessage;)I", "GetPostMessage_Lcom_baidu_speech_core_BDSMessage_Handler")]
		public virtual unsafe int PostMessage (global::Com.Baidu.Speech.Core.BDSMessage p0)
		{
			const string __id = "postMessage.(Lcom/baidu/speech/core/BDSMessage;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Speech.Core.BDSCoreJniInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSCoreJniInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSCoreJniInterface']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_Handler ()
		{
			if (cb_setListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_ == null)
				cb_setListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_);
			return cb_setListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_;
		}

		static void n_SetListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Core.BDSCoreJniInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSCoreJniInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener p0 = (global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSCoreJniInterface']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.core.BDSSDKLoader.BDSCoreEventListener']]"
		[Register ("setListener", "(Lcom/baidu/speech/core/BDSSDKLoader$BDSCoreEventListener;)V", "GetSetListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener p0)
		{
			const string __id = "setListener.(Lcom/baidu/speech/core/BDSSDKLoader$BDSCoreEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener"

		global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListenerImplementor __CreateIBDSCoreEventListenerImplementor ()
		{
			return new global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListenerImplementor (this);
		}
#endregion
	}
}
