using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.speech']/interface[@name='EventManager']"
	[Register ("com/baidu/speech/EventManager", "", "Com.Baidu.Speech.IEventManagerInvoker")]
	public partial interface IEventManager : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/interface[@name='EventManager']/method[@name='registerListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.EventListener']]"
		[Register ("registerListener", "(Lcom/baidu/speech/EventListener;)V", "GetRegisterListener_Lcom_baidu_speech_EventListener_Handler:Com.Baidu.Speech.IEventManagerInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
		void RegisterListener (global::Com.Baidu.Speech.IEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/interface[@name='EventManager']/method[@name='send' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;[BII)V", "GetSend_Ljava_lang_String_Ljava_lang_String_arrayBIIHandler:Com.Baidu.Speech.IEventManagerInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
		void Send (string p0, string p1, byte[] p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/interface[@name='EventManager']/method[@name='unregisterListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.EventListener']]"
		[Register ("unregisterListener", "(Lcom/baidu/speech/EventListener;)V", "GetUnregisterListener_Lcom_baidu_speech_EventListener_Handler:Com.Baidu.Speech.IEventManagerInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
		void UnregisterListener (global::Com.Baidu.Speech.IEventListener p0);

	}

	[global::Android.Runtime.Register ("com/baidu/speech/EventManager", DoNotGenerateAcw=true)]
	internal class IEventManagerInvoker : global::Java.Lang.Object, IEventManager {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/EventManager", typeof (IEventManagerInvoker));

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
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.speech.EventManager"));
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
			global::Com.Baidu.Speech.IEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.IEventListener p0 = (global::Com.Baidu.Speech.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerListener_Lcom_baidu_speech_EventListener_;
		public unsafe void RegisterListener (global::Com.Baidu.Speech.IEventListener p0)
		{
			if (id_registerListener_Lcom_baidu_speech_EventListener_ == IntPtr.Zero)
				id_registerListener_Lcom_baidu_speech_EventListener_ = JNIEnv.GetMethodID (class_ref, "registerListener", "(Lcom/baidu/speech/EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerListener_Lcom_baidu_speech_EventListener_, __args);
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
			global::Com.Baidu.Speech.IEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Baidu.Speech.IEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.IEventListener p0 = (global::Com.Baidu.Speech.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterListener_Lcom_baidu_speech_EventListener_;
		public unsafe void UnregisterListener (global::Com.Baidu.Speech.IEventListener p0)
		{
			if (id_unregisterListener_Lcom_baidu_speech_EventListener_ == IntPtr.Zero)
				id_unregisterListener_Lcom_baidu_speech_EventListener_ = JNIEnv.GetMethodID (class_ref, "unregisterListener", "(Lcom/baidu/speech/EventListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterListener_Lcom_baidu_speech_EventListener_, __args);
		}

	}

}
