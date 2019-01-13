using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManagerFactory.Stub']"
	[global::Android.Runtime.Register ("com/baidu/speech/aidl/EventManagerFactory$Stub", DoNotGenerateAcw=true)]
	public abstract partial class EventManagerFactoryStub : global::Android.OS.Binder, global::Com.Baidu.Speech.Aidl.IEventManagerFactory {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/aidl/EventManagerFactory$Stub", typeof (EventManagerFactoryStub));
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

		protected EventManagerFactoryStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManagerFactory.Stub']/constructor[@name='EventManagerFactory.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventManagerFactoryStub ()
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
			global::Com.Baidu.Speech.Aidl.EventManagerFactoryStub __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventManagerFactoryStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManagerFactory.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManagerFactory.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/baidu/speech/aidl/EventManagerFactory;", "")]
		public static unsafe global::Com.Baidu.Speech.Aidl.IEventManagerFactory AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/baidu/speech/aidl/EventManagerFactory;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManagerFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Baidu.Speech.Aidl.EventManagerFactoryStub __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventManagerFactoryStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/class[@name='EventManagerFactory.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_create_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_lang_String_Handler ()
		{
			if (cb_create_Ljava_lang_String_ == null)
				cb_create_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Ljava_lang_String_);
			return cb_create_Ljava_lang_String_;
		}

		static IntPtr n_Create_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Aidl.EventManagerFactoryStub __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.EventManagerFactoryStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManagerFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lcom/baidu/speech/aidl/EventManager;", "GetCreate_Ljava_lang_String_Handler")]
		public abstract global::Com.Baidu.Speech.Aidl.IEventManager Create (string p0);

	}

	[global::Android.Runtime.Register ("com/baidu/speech/aidl/EventManagerFactory$Stub", DoNotGenerateAcw=true)]
	internal partial class EventManagerFactoryStubInvoker : EventManagerFactoryStub {

		public EventManagerFactoryStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/aidl/EventManagerFactory$Stub", typeof (EventManagerFactoryStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManagerFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lcom/baidu/speech/aidl/EventManager;", "GetCreate_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Baidu.Speech.Aidl.IEventManager Create (string p0)
		{
			const string __id = "create.(Ljava/lang/String;)Lcom/baidu/speech/aidl/EventManager;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManagerFactory']"
	[Register ("com/baidu/speech/aidl/EventManagerFactory", "", "Com.Baidu.Speech.Aidl.IEventManagerFactoryInvoker")]
	public partial interface IEventManagerFactory : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.aidl']/interface[@name='EventManagerFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lcom/baidu/speech/aidl/EventManager;", "GetCreate_Ljava_lang_String_Handler:Com.Baidu.Speech.Aidl.IEventManagerFactoryInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
		global::Com.Baidu.Speech.Aidl.IEventManager Create (string p0);

	}

	[global::Android.Runtime.Register ("com/baidu/speech/aidl/EventManagerFactory", DoNotGenerateAcw=true)]
	internal class IEventManagerFactoryInvoker : global::Java.Lang.Object, IEventManagerFactory {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/aidl/EventManagerFactory", typeof (IEventManagerFactoryInvoker));

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

		public static IEventManagerFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventManagerFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.speech.aidl.EventManagerFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventManagerFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_create_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_lang_String_Handler ()
		{
			if (cb_create_Ljava_lang_String_ == null)
				cb_create_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Ljava_lang_String_);
			return cb_create_Ljava_lang_String_;
		}

		static IntPtr n_Create_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Aidl.IEventManagerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManagerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_create_Ljava_lang_String_;
		public unsafe global::Com.Baidu.Speech.Aidl.IEventManager Create (string p0)
		{
			if (id_create_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/baidu/speech/aidl/EventManager;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Baidu.Speech.Aidl.IEventManager __ret = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Baidu.Speech.Aidl.IEventManagerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Aidl.IEventManagerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
