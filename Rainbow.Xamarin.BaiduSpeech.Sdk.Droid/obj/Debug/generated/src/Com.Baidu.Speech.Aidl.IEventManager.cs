using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManager.Stub']"
	[global::Android.Runtime.Register ("com/baidu/speech/aidl/EventManager$Stub", DoNotGenerateAcw=true)]
	public abstract partial class EventManagerStub : global::Android.OS.Binder, global::Com.Baidu.Speech.Aidl.IEventManager {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/aidl/EventManager$Stub", typeof (EventManagerStub));
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

		protected EventManagerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManager.Stub']/constructor[@name='EventManager.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventManagerStub ()
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Speech.Aidl.EventManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManager.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManager.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/baidu/speech/aidl/EventManager;", "")]
		public static unsafe global::Com.Baidu.Speech.Aidl.IEventManager AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/baidu/speech/aidl/EventManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Baidu.Speech.Aidl.EventManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManager.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_registerListener_Lcom_baidu_speech_aidl_EventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterListener_Lcom_baidu_speech_aidl_EventListener_Handler ()
		{
			if (cb_registerListener_Lcom_baidu_speech_aidl_EventListener_ == null)
				cb_registerListener_Lcom_baidu_speech_aidl_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterListener_Lcom_baidu_speech_aidl_EventListener_);
			return cb_registerListener_Lcom_baidu_speech_aidl_EventListener_;
		}

		static void n_RegisterListener_Lcom_baidu_speech_aidl_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Aidl.EventManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Aidl.IEventListener p0 = (global::Com.Baidu.Speech.Aidl.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='registerListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.aidl.EventListener']]"
		[Register ("registerListener", "(Lcom/baidu/speech/aidl/EventListener;)V", "GetRegisterListener_Lcom_baidu_speech_aidl_EventListener_Handler")]
		public abstract void RegisterListener (global::Com.Baidu.Speech.Aidl.IEventListener p0);

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
			global::Com.Baidu.Speech.Aidl.EventManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='send' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;[BII)V", "GetSend_Ljava_lang_String_Ljava_lang_String_arrayBIIHandler")]
		public abstract void Send (string p0, string p1, byte[] p2, int p3, int p4);

		static Delegate cb_unregisterListener_Lcom_baidu_speech_aidl_EventListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterListener_Lcom_baidu_speech_aidl_EventListener_Handler ()
		{
			if (cb_unregisterListener_Lcom_baidu_speech_aidl_EventListener_ == null)
				cb_unregisterListener_Lcom_baidu_speech_aidl_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterListener_Lcom_baidu_speech_aidl_EventListener_);
			return cb_unregisterListener_Lcom_baidu_speech_aidl_EventListener_;
		}

		static void n_UnregisterListener_Lcom_baidu_speech_aidl_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Aidl.EventManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Aidl.IEventListener p0 = (global::Com.Baidu.Speech.Aidl.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='unregisterListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.aidl.EventListener']]"
		[Register ("unregisterListener", "(Lcom/baidu/speech/aidl/EventListener;)V", "GetUnregisterListener_Lcom_baidu_speech_aidl_EventListener_Handler")]
		public abstract void UnregisterListener (global::Com.Baidu.Speech.Aidl.IEventListener p0);

	}

	[global::Android.Runtime.Register ("com/baidu/speech/aidl/EventManager$Stub", DoNotGenerateAcw=true)]
	internal partial class EventManagerStubInvoker : EventManagerStub {

		public EventManagerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/aidl/EventManager$Stub", typeof (EventManagerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='registerListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.aidl.EventListener']]"
		[Register ("registerListener", "(Lcom/baidu/speech/aidl/EventListener;)V", "GetRegisterListener_Lcom_baidu_speech_aidl_EventListener_Handler")]
		public override unsafe void RegisterListener (global::Com.Baidu.Speech.Aidl.IEventListener p0)
		{
			const string __id = "registerListener.(Lcom/baidu/speech/aidl/EventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='send' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;[BII)V", "GetSend_Ljava_lang_String_Ljava_lang_String_arrayBIIHandler")]
		public override unsafe void Send (string p0, string p1, byte[] p2, int p3, int p4)
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
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='unregisterListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.aidl.EventListener']]"
		[Register ("unregisterListener", "(Lcom/baidu/speech/aidl/EventListener;)V", "GetUnregisterListener_Lcom_baidu_speech_aidl_EventListener_Handler")]
		public override unsafe void UnregisterListener (global::Com.Baidu.Speech.Aidl.IEventListener p0)
		{
			const string __id = "unregisterListener.(Lcom/baidu/speech/aidl/EventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']"
	[Register ("com/baidu/speech/aidl/EventManager", "", "Com.Baidu.Speech.Aidl.IEventManagerInvoker")]
	public partial interface IEventManager : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='registerListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.aidl.EventListener']]"
		[Register ("registerListener", "(Lcom/baidu/speech/aidl/EventListener;)V", "GetRegisterListener_Lcom_baidu_speech_aidl_EventListener_Handler:Com.Baidu.Speech.Aidl.IEventManagerInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
		void RegisterListener (global::Com.Baidu.Speech.Aidl.IEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='send' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;[BII)V", "GetSend_Ljava_lang_String_Ljava_lang_String_arrayBIIHandler:Com.Baidu.Speech.Aidl.IEventManagerInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
		void Send (string p0, string p1, byte[] p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManager']/method[@name='unregisterListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.aidl.EventListener']]"
		[Register ("unregisterListener", "(Lcom/baidu/speech/aidl/EventListener;)V", "GetUnregisterListener_Lcom_baidu_speech_aidl_EventListener_Handler:Com.Baidu.Speech.Aidl.IEventManagerInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
		void UnregisterListener (global::Com.Baidu.Speech.Aidl.IEventListener p0);

	}

	[global::Android.Runtime.Register ("com/baidu/speech/aidl/EventManager", DoNotGenerateAcw=true)]
	internal class IEventManagerInvoker : global::Java.Lang.Object, IEventManager {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/aidl/EventManager", typeof (IEventManagerInvoker));

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

		public static IEventManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.speech.aidl.EventManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_registerListener_Lcom_baidu_speech_aidl_EventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterListener_Lcom_baidu_speech_aidl_EventListener_Handler ()
		{
			if (cb_registerListener_Lcom_baidu_speech_aidl_EventListener_ == null)
				cb_registerListener_Lcom_baidu_speech_aidl_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterListener_Lcom_baidu_speech_aidl_EventListener_);
			return cb_registerListener_Lcom_baidu_speech_aidl_EventListener_;
		}

		static void n_RegisterListener_Lcom_baidu_speech_aidl_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Aidl.IEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Aidl.IEventListener p0 = (global::Com.Baidu.Speech.Aidl.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerListener_Lcom_baidu_speech_aidl_EventListener_;
		public unsafe void RegisterListener (global::Com.Baidu.Speech.Aidl.IEventListener p0)
		{
			if (id_registerListener_Lcom_baidu_speech_aidl_EventListener_ == IntPtr.Zero)
				id_registerListener_Lcom_baidu_speech_aidl_EventListener_ = JNIEnv.GetMethodID (class_ref, "registerListener", "(Lcom/baidu/speech/aidl/EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerListener_Lcom_baidu_speech_aidl_EventListener_, __args);
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
			global::Com.Baidu.Speech.Aidl.IEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_lang_String_Ljava_lang_String_arrayBII;
		public unsafe void Send (string p0, string p1, byte[] p2, int p3, int p4)
		{
			if (id_send_Ljava_lang_String_Ljava_lang_String_arrayBII == IntPtr.Zero)
				id_send_Ljava_lang_String_Ljava_lang_String_arrayBII = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;Ljava/lang/String;[BII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_Ljava_lang_String_arrayBII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_unregisterListener_Lcom_baidu_speech_aidl_EventListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterListener_Lcom_baidu_speech_aidl_EventListener_Handler ()
		{
			if (cb_unregisterListener_Lcom_baidu_speech_aidl_EventListener_ == null)
				cb_unregisterListener_Lcom_baidu_speech_aidl_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterListener_Lcom_baidu_speech_aidl_EventListener_);
			return cb_unregisterListener_Lcom_baidu_speech_aidl_EventListener_;
		}

		static void n_UnregisterListener_Lcom_baidu_speech_aidl_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Aidl.IEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Aidl.IEventListener p0 = (global::Com.Baidu.Speech.Aidl.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterListener_Lcom_baidu_speech_aidl_EventListener_;
		public unsafe void UnregisterListener (global::Com.Baidu.Speech.Aidl.IEventListener p0)
		{
			if (id_unregisterListener_Lcom_baidu_speech_aidl_EventListener_ == IntPtr.Zero)
				id_unregisterListener_Lcom_baidu_speech_aidl_EventListener_ = JNIEnv.GetMethodID (class_ref, "unregisterListener", "(Lcom/baidu/speech/aidl/EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterListener_Lcom_baidu_speech_aidl_EventListener_, __args);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Speech.Aidl.IEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
