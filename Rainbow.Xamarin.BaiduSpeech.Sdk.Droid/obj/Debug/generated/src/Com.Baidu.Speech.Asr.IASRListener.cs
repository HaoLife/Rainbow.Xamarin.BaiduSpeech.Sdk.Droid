using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Asr {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.speech.asr']/interface[@name='ASRListener']"
	[Register ("com/baidu/speech/asr/ASRListener", "", "Com.Baidu.Speech.Asr.IASRListenerInvoker")]
	public partial interface IASRListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/interface[@name='ASRListener']/method[@name='onEvent' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register ("onEvent", "(Ljava/lang/String;Ljava/lang/String;[BIIZ)V", "GetOnEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZHandler:Com.Baidu.Speech.Asr.IASRListenerInvoker, Rainbow.Xamarin.BaiduSpeech.Sdk.Droid")]
		void OnEvent (string p0, string p1, byte[] p2, int p3, int p4, bool p5);

	}

	[global::Android.Runtime.Register ("com/baidu/speech/asr/ASRListener", DoNotGenerateAcw=true)]
	internal class IASRListenerInvoker : global::Java.Lang.Object, IASRListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/asr/ASRListener", typeof (IASRListenerInvoker));

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

		public static IASRListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IASRListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.speech.asr.ASRListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IASRListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ;
#pragma warning disable 0169
		static Delegate GetOnEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZHandler ()
		{
			if (cb_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ == null)
				cb_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ);
			return cb_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ;
		}

		static void n_OnEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, bool p5)
		{
			global::Com.Baidu.Speech.Asr.IASRListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.IASRListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnEvent (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ;
		public unsafe void OnEvent (string p0, string p1, byte[] p2, int p3, int p4, bool p5)
		{
			if (id_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ == IntPtr.Zero)
				id_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Ljava/lang/String;Ljava/lang/String;[BIIZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_Ljava_lang_String_Ljava_lang_String_arrayBIIZ, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	// event args for com.baidu.speech.asr.ASRListener.onEvent
	public partial class ASREventArgs : global::System.EventArgs {

		public ASREventArgs (string p0, string p1, byte[] p2, int p3, int p4, bool p5)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		byte[] p2;
		public byte[] P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}

		int p4;
		public int P4 {
			get { return p4; }
		}

		bool p5;
		public bool P5 {
			get { return p5; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/speech/asr/ASRListenerImplementor")]
	internal sealed partial class IASRListenerImplementor : global::Java.Lang.Object, IASRListener {

		object sender;

		public IASRListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/speech/asr/ASRListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ASREventArgs> Handler;
#pragma warning restore 0649

		public void OnEvent (string p0, string p1, byte[] p2, int p3, int p4, bool p5)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ASREventArgs (p0, p1, p2, p3, p4, p5));
		}

		internal static bool __IsEmpty (IASRListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
