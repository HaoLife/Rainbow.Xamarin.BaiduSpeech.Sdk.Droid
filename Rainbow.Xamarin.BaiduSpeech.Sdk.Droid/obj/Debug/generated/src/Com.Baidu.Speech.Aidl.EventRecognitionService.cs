using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventRecognitionService']"
	[global::Android.Runtime.Register ("com/baidu/speech/aidl/EventRecognitionService", DoNotGenerateAcw=true)]
	public partial class EventRecognitionService : global::Android.App.Service {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventRecognitionService.EventListenerProxy']"
		[global::Android.Runtime.Register ("com/baidu/speech/aidl/EventRecognitionService$EventListenerProxy", DoNotGenerateAcw=true)]
		public partial class EventListenerProxy : global::Java.Lang.Object, global::Com.Baidu.Speech.IEventListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/aidl/EventRecognitionService$EventListenerProxy", typeof (EventListenerProxy));
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

			protected EventListenerProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventRecognitionService.EventListenerProxy']/constructor[@name='EventRecognitionService.EventListenerProxy' and count(parameter)=2 and parameter[1][@type='com.baidu.speech.aidl.EventRecognitionService'] and parameter[2][@type='com.baidu.speech.aidl.EventListener']]"
			[Register (".ctor", "(Lcom/baidu/speech/aidl/EventRecognitionService;Lcom/baidu/speech/aidl/EventListener;)V", "")]
			public unsafe EventListenerProxy (global::Com.Baidu.Speech.Aidl.EventRecognitionService __self, global::Com.Baidu.Speech.Aidl.IEventListener p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/baidu/speech/aidl/EventListener;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
			static Delegate GetOnEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIHandler ()
			{
				if (cb_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBII == null)
					cb_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_OnEvent_Ljava_lang_String_Ljava_lang_String_arrayBII);
				return cb_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBII;
			}

			static void n_OnEvent_Ljava_lang_String_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4)
			{
				global::Com.Baidu.Speech.Aidl.EventRecognitionService.EventListenerProxy __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventRecognitionService.EventListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnEvent (p0, p1, p2, p3, p4);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventRecognitionService.EventListenerProxy']/method[@name='onEvent' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("onEvent", "(Ljava/lang/String;Ljava/lang/String;[BII)V", "GetOnEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIHandler")]
			public virtual unsafe void OnEvent (string p0, string p1, byte[] p2, int p3, int p4)
			{
				const string __id = "onEvent.(Ljava/lang/String;Ljava/lang/String;[BII)V";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/aidl/EventRecognitionService", typeof (EventRecognitionService));
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

		protected EventRecognitionService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventRecognitionService']/constructor[@name='EventRecognitionService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventRecognitionService ()
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

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Aidl.EventRecognitionService __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventRecognitionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventRecognitionService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
