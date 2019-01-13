using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory']"
	[global::Android.Runtime.Register ("com/baidu/speech/EventManagerFactory", DoNotGenerateAcw=true)]
	public partial class EventManagerFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory.EventManagerRemote2Local']"
		[global::Android.Runtime.Register ("com/baidu/speech/EventManagerFactory$EventManagerRemote2Local", DoNotGenerateAcw=true)]
		public partial class EventManagerRemote2Local : global::Java.Lang.Object, global::Com.Baidu.Speech.IEventManager {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/EventManagerFactory$EventManagerRemote2Local", typeof (EventManagerRemote2Local));
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

			protected EventManagerRemote2Local (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_registerListener_Lcom_baidu_speech_EventListener_;
#pragma warning disable 0169
			static Delegate GetRegisterListener_Lcom_baidu_speech_EventListener_Handler ()
			{
				if (cb_registerListener_Lcom_baidu_speech_EventListener_ == null)
					cb_registerListener_Lcom_baidu_speech_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterListener_Lcom_baidu_speech_EventListener_);
				return cb_registerListener_Lcom_baidu_speech_EventListener_;
			}

			static void n_RegisterListener_Lcom_baidu_speech_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Speech.EventManagerFactory.EventManagerRemote2Local __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.EventManagerFactory.EventManagerRemote2Local> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Speech.IEventListener p0 = (global::Com.Baidu.Speech.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RegisterListener (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory.EventManagerRemote2Local']/method[@name='registerListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.EventListener']]"
			[Register ("registerListener", "(Lcom/baidu/speech/EventListener;)V", "GetRegisterListener_Lcom_baidu_speech_EventListener_Handler")]
			public virtual unsafe void RegisterListener (global::Com.Baidu.Speech.IEventListener p0)
			{
				const string __id = "registerListener.(Lcom/baidu/speech/EventListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_send_Ljava_lang_String_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
			static Delegate GetSend_Ljava_lang_String_Ljava_lang_String_arrayBIIHandler ()
			{
				if (cb_send_Ljava_lang_String_Ljava_lang_String_arrayBII == null)
					cb_send_Ljava_lang_String_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_Send_Ljava_lang_String_Ljava_lang_String_arrayBII);
				return cb_send_Ljava_lang_String_Ljava_lang_String_arrayBII;
			}

			static void n_Send_Ljava_lang_String_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4)
			{
				global::Com.Baidu.Speech.EventManagerFactory.EventManagerRemote2Local __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.EventManagerFactory.EventManagerRemote2Local> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Send (p0, p1, p2, p3, p4);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory.EventManagerRemote2Local']/method[@name='send' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("send", "(Ljava/lang/String;Ljava/lang/String;[BII)V", "GetSend_Ljava_lang_String_Ljava_lang_String_arrayBIIHandler")]
			public virtual unsafe void Send (string p0, string p1, byte[] p2, int p3, int p4)
			{
				const string __id = "send.(Ljava/lang/String;Ljava/lang/String;[BII)V";
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

			static Delegate cb_setRemoteEM_Lcom_baidu_speech_aidl_EventManager_;
#pragma warning disable 0169
			static Delegate GetSetRemoteEM_Lcom_baidu_speech_aidl_EventManager_Handler ()
			{
				if (cb_setRemoteEM_Lcom_baidu_speech_aidl_EventManager_ == null)
					cb_setRemoteEM_Lcom_baidu_speech_aidl_EventManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRemoteEM_Lcom_baidu_speech_aidl_EventManager_);
				return cb_setRemoteEM_Lcom_baidu_speech_aidl_EventManager_;
			}

			static void n_SetRemoteEM_Lcom_baidu_speech_aidl_EventManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Speech.EventManagerFactory.EventManagerRemote2Local __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.EventManagerFactory.EventManagerRemote2Local> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Speech.Aidl.IEventManager p0 = (global::Com.Baidu.Speech.Aidl.IEventManager)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManager> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetRemoteEM (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory.EventManagerRemote2Local']/method[@name='setRemoteEM' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.aidl.EventManager']]"
			[Register ("setRemoteEM", "(Lcom/baidu/speech/aidl/EventManager;)V", "GetSetRemoteEM_Lcom_baidu_speech_aidl_EventManager_Handler")]
			public virtual unsafe void SetRemoteEM (global::Com.Baidu.Speech.Aidl.IEventManager p0)
			{
				const string __id = "setRemoteEM.(Lcom/baidu/speech/aidl/EventManager;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_unregisterListener_Lcom_baidu_speech_EventListener_;
#pragma warning disable 0169
			static Delegate GetUnregisterListener_Lcom_baidu_speech_EventListener_Handler ()
			{
				if (cb_unregisterListener_Lcom_baidu_speech_EventListener_ == null)
					cb_unregisterListener_Lcom_baidu_speech_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterListener_Lcom_baidu_speech_EventListener_);
				return cb_unregisterListener_Lcom_baidu_speech_EventListener_;
			}

			static void n_UnregisterListener_Lcom_baidu_speech_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Speech.EventManagerFactory.EventManagerRemote2Local __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.EventManagerFactory.EventManagerRemote2Local> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Speech.IEventListener p0 = (global::Com.Baidu.Speech.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.UnregisterListener (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory.EventManagerRemote2Local']/method[@name='unregisterListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.EventListener']]"
			[Register ("unregisterListener", "(Lcom/baidu/speech/EventListener;)V", "GetUnregisterListener_Lcom_baidu_speech_EventListener_Handler")]
			public virtual unsafe void UnregisterListener (global::Com.Baidu.Speech.IEventListener p0)
			{
				const string __id = "unregisterListener.(Lcom/baidu/speech/EventListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/EventManagerFactory", typeof (EventManagerFactory));
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

		protected EventManagerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory']/constructor[@name='EventManagerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventManagerFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Landroid/content/Context;Ljava/lang/String;)Lcom/baidu/speech/EventManager;", "")]
		public static unsafe global::Com.Baidu.Speech.IEventManager Create (global::Android.Content.Context p0, string p1)
		{
			const string __id = "create.(Landroid/content/Context;Ljava/lang/String;)Lcom/baidu/speech/EventManager;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='EventManagerFactory']/method[@name='create' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("create", "(Landroid/content/Context;Ljava/lang/String;Z)Lcom/baidu/speech/EventManager;", "")]
		public static unsafe global::Com.Baidu.Speech.IEventManager Create (global::Android.Content.Context p0, string p1, bool p2)
		{
			const string __id = "create.(Landroid/content/Context;Ljava/lang/String;Z)Lcom/baidu/speech/EventManager;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
