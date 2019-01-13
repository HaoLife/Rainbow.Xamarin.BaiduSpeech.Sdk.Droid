using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']"
	[global::Android.Runtime.Register ("com/baidu/speech/core/BDSSDKLoader", DoNotGenerateAcw=true)]
	public partial class BDSSDKLoader : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.speech.core']/interface[@name='BDSSDKLoader.BDSCoreEventListener']"
		[Register ("com/baidu/speech/core/BDSSDKLoader$BDSCoreEventListener", "", "Com.Baidu.Speech.Core.BDSSDKLoader/IBDSCoreEventListenerInvoker")]
		public partial interface IBDSCoreEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/interface[@name='BDSSDKLoader.BDSCoreEventListener']/method[@name='receiveCoreEvent' and count(parameter)=2 and parameter[1][@type='com.baidu.speech.core.BDSMessage'] and parameter[2][@type='com.baidu.speech.core.BDSSDKLoader.BDSSDKInterface']]"
			[Register ("receiveCoreEvent", "(Lcom/baidu/speech/core/BDSMessage;Lcom/baidu/speech/core/BDSSDKLoader$BDSSDKInterface;)V", "GetReceiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_Handler:Com.Baidu.Speech.Core.BDSSDKLoader/IBDSCoreEventListenerInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
			void ReceiveCoreEvent (global::Com.Baidu.Speech.Core.BDSMessage p0, global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface p1);

		}

		[global::Android.Runtime.Register ("com/baidu/speech/core/BDSSDKLoader$BDSCoreEventListener", DoNotGenerateAcw=true)]
		internal class IBDSCoreEventListenerInvoker : global::Java.Lang.Object, IBDSCoreEventListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/core/BDSSDKLoader$BDSCoreEventListener", typeof (IBDSCoreEventListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IBDSCoreEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBDSCoreEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.speech.core.BDSSDKLoader.BDSCoreEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBDSCoreEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_receiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_;
#pragma warning disable 0169
			static Delegate GetReceiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_Handler ()
			{
				if (cb_receiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_ == null)
					cb_receiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReceiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_);
				return cb_receiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_;
			}

			static void n_ReceiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Speech.Core.BDSMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface p1 = (global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ReceiveCoreEvent (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_receiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_;
			public unsafe void ReceiveCoreEvent (global::Com.Baidu.Speech.Core.BDSMessage p0, global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface p1)
			{
				if (id_receiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_ == IntPtr.Zero)
					id_receiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_ = JNIEnv.GetMethodID (class_ref, "receiveCoreEvent", "(Lcom/baidu/speech/core/BDSMessage;Lcom/baidu/speech/core/BDSSDKLoader$BDSSDKInterface;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_receiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_, __args);
			}

		}

		// event args for com.baidu.speech.core.BDSSDKLoader.BDSCoreEventListener.receiveCoreEvent
		public partial class BDSCoreEventEventArgs : global::System.EventArgs {

			public BDSCoreEventEventArgs (global::Com.Baidu.Speech.Core.BDSMessage p0, global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Baidu.Speech.Core.BDSMessage p0;
			public global::Com.Baidu.Speech.Core.BDSMessage P0 {
				get { return p0; }
			}

			global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface p1;
			public global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/speech/core/BDSSDKLoader_BDSCoreEventListenerImplementor")]
		internal sealed partial class IBDSCoreEventListenerImplementor : global::Java.Lang.Object, IBDSCoreEventListener {

			object sender;

			public IBDSCoreEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/speech/core/BDSSDKLoader_BDSCoreEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BDSCoreEventEventArgs> Handler;
#pragma warning restore 0649

			public void ReceiveCoreEvent (global::Com.Baidu.Speech.Core.BDSMessage p0, global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BDSCoreEventEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IBDSCoreEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.speech.core']/interface[@name='BDSSDKLoader.BDSSDKInterface']"
		[Register ("com/baidu/speech/core/BDSSDKLoader$BDSSDKInterface", "", "Com.Baidu.Speech.Core.BDSSDKLoader/IBDSSDKInterfaceInvoker")]
		public partial interface IBDSSDKInterface : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/interface[@name='BDSSDKLoader.BDSSDKInterface']/method[@name='EchoMessage' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.core.BDSMessage']]"
			[Register ("EchoMessage", "(Lcom/baidu/speech/core/BDSMessage;)V", "GetEchoMessage_Lcom_baidu_speech_core_BDSMessage_Handler:Com.Baidu.Speech.Core.BDSSDKLoader/IBDSSDKInterfaceInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
			void EchoMessage (global::Com.Baidu.Speech.Core.BDSMessage p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/interface[@name='BDSSDKLoader.BDSSDKInterface']/method[@name='instanceInitialized' and count(parameter)=0]"
			[Register ("instanceInitialized", "()Z", "GetInstanceInitializedHandler:Com.Baidu.Speech.Core.BDSSDKLoader/IBDSSDKInterfaceInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
			bool InstanceInitialized ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/interface[@name='BDSSDKLoader.BDSSDKInterface']/method[@name='postMessage' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.core.BDSMessage']]"
			[Register ("postMessage", "(Lcom/baidu/speech/core/BDSMessage;)I", "GetPostMessage_Lcom_baidu_speech_core_BDSMessage_Handler:Com.Baidu.Speech.Core.BDSSDKLoader/IBDSSDKInterfaceInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
			int PostMessage (global::Com.Baidu.Speech.Core.BDSMessage p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/interface[@name='BDSSDKLoader.BDSSDKInterface']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "GetReleaseHandler:Com.Baidu.Speech.Core.BDSSDKLoader/IBDSSDKInterfaceInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
			void Release ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/interface[@name='BDSSDKLoader.BDSSDKInterface']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.core.BDSSDKLoader.BDSCoreEventListener']]"
			[Register ("setListener", "(Lcom/baidu/speech/core/BDSSDKLoader$BDSCoreEventListener;)V", "GetSetListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_Handler:Com.Baidu.Speech.Core.BDSSDKLoader/IBDSSDKInterfaceInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
			void SetListener (global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener p0);

		}

		[global::Android.Runtime.Register ("com/baidu/speech/core/BDSSDKLoader$BDSSDKInterface", DoNotGenerateAcw=true)]
		internal class IBDSSDKInterfaceInvoker : global::Java.Lang.Object, IBDSSDKInterface {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/core/BDSSDKLoader$BDSSDKInterface", typeof (IBDSSDKInterfaceInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IBDSSDKInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBDSSDKInterface> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.speech.core.BDSSDKLoader.BDSSDKInterface"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBDSSDKInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Speech.Core.BDSMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.EchoMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_EchoMessage_Lcom_baidu_speech_core_BDSMessage_;
			public unsafe void EchoMessage (global::Com.Baidu.Speech.Core.BDSMessage p0)
			{
				if (id_EchoMessage_Lcom_baidu_speech_core_BDSMessage_ == IntPtr.Zero)
					id_EchoMessage_Lcom_baidu_speech_core_BDSMessage_ = JNIEnv.GetMethodID (class_ref, "EchoMessage", "(Lcom/baidu/speech/core/BDSMessage;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_EchoMessage_Lcom_baidu_speech_core_BDSMessage_, __args);
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
				global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.InstanceInitialized ();
			}
#pragma warning restore 0169

			IntPtr id_instanceInitialized;
			public unsafe bool InstanceInitialized ()
			{
				if (id_instanceInitialized == IntPtr.Zero)
					id_instanceInitialized = JNIEnv.GetMethodID (class_ref, "instanceInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_instanceInitialized);
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
				global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Speech.Core.BDSMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PostMessage (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_postMessage_Lcom_baidu_speech_core_BDSMessage_;
			public unsafe int PostMessage (global::Com.Baidu.Speech.Core.BDSMessage p0)
			{
				if (id_postMessage_Lcom_baidu_speech_core_BDSMessage_ == IntPtr.Zero)
					id_postMessage_Lcom_baidu_speech_core_BDSMessage_ = JNIEnv.GetMethodID (class_ref, "postMessage", "(Lcom/baidu/speech/core/BDSMessage;)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_postMessage_Lcom_baidu_speech_core_BDSMessage_, __args);
				return __ret;
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
				global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			IntPtr id_release;
			public unsafe void Release ()
			{
				if (id_release == IntPtr.Zero)
					id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
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
				global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener p0 = (global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetListener (p0);
			}
#pragma warning restore 0169

			IntPtr id_setListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_;
			public unsafe void SetListener (global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener p0)
			{
				if (id_setListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_ == IntPtr.Zero)
					id_setListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/baidu/speech/core/BDSSDKLoader$BDSCoreEventListener;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_baidu_speech_core_BDSSDKLoader_BDSCoreEventListener_, __args);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSSDKLoader", typeof (BDSSDKLoader));
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

		protected BDSSDKLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/constructor[@name='BDSSDKLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDSSDKLoader ()
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

		public static unsafe int EngineVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='getEngineVersion' and count(parameter)=0]"
			[Register ("getEngineVersion", "()I", "GetGetEngineVersionHandler")]
			get {
				const string __id = "getEngineVersion.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='SetLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetLogLevel", "(I)V", "")]
		public static unsafe void SetLogLevel (int p0)
		{
			const string __id = "SetLogLevel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='getSDKObjectForSDKType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getSDKObjectForSDKType", "(Ljava/lang/String;Landroid/content/Context;)Lcom/baidu/speech/core/BDSSDKLoader$BDSSDKInterface;", "")]
		public static unsafe global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface GetSDKObjectForSDKType (string p0, global::Android.Content.Context p1)
		{
			const string __id = "getSDKObjectForSDKType.(Ljava/lang/String;Landroid/content/Context;)Lcom/baidu/speech/core/BDSSDKLoader$BDSSDKInterface;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='loadLibraries' and count(parameter)=0]"
		[Register ("loadLibraries", "()V", "")]
		public static unsafe void LoadLibraries ()
		{
			const string __id = "loadLibraries.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='makeDir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeDir", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool MakeDir (string p0)
		{
			const string __id = "makeDir.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='setJavaContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setJavaContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetJavaContext (global::Android.Content.Context p0)
		{
			const string __id = "setJavaContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='setWriteableLibraryDataPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setWriteableLibraryDataPath", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetWriteableLibraryDataPath (string p0)
		{
			const string __id = "setWriteableLibraryDataPath.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='setWriteableTempPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setWriteableTempPath", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetWriteableTempPath (string p0)
		{
			const string __id = "setWriteableTempPath.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSSDKLoader']/method[@name='setWriteableUserDataPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setWriteableUserDataPath", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetWriteableUserDataPath (string p0)
		{
			const string __id = "setWriteableUserDataPath.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
