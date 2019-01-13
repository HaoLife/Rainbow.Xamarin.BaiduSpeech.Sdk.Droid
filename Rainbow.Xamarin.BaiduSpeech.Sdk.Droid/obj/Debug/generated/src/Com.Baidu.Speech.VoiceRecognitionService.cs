using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']"
	[global::Android.Runtime.Register ("com/baidu/speech/VoiceRecognitionService", DoNotGenerateAcw=true)]
	public sealed partial class VoiceRecognitionService : global::Android.Speech.RecognitionService {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/field[@name='EVENT_ENGINE_SWITCH']"
		[Register ("EVENT_ENGINE_SWITCH")]
		public const int EventEngineSwitch = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "VoiceRecognitionService";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/field[@name='VERSION_NAME']"
		[Register ("VERSION_NAME")]
		public const string VersionName = (string) "3.4.1.101";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService.MyListener']"
		[global::Android.Runtime.Register ("com/baidu/speech/VoiceRecognitionService$MyListener", DoNotGenerateAcw=true)]
		public partial class MyListener : global::Java.Lang.Object, global::Com.Baidu.Speech.IEventListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/VoiceRecognitionService$MyListener", typeof (MyListener));
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

			protected MyListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Baidu.Speech.VoiceRecognitionService.MyListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.VoiceRecognitionService.MyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnEvent (p0, p1, p2, p3, p4);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService.MyListener']/method[@name='onEvent' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
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

			static Delegate cb_setCallbackListener_Landroid_speech_RecognitionService_Callback_;
#pragma warning disable 0169
			static Delegate GetSetCallbackListener_Landroid_speech_RecognitionService_Callback_Handler ()
			{
				if (cb_setCallbackListener_Landroid_speech_RecognitionService_Callback_ == null)
					cb_setCallbackListener_Landroid_speech_RecognitionService_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallbackListener_Landroid_speech_RecognitionService_Callback_);
				return cb_setCallbackListener_Landroid_speech_RecognitionService_Callback_;
			}

			static void n_SetCallbackListener_Landroid_speech_RecognitionService_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Speech.VoiceRecognitionService.MyListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.VoiceRecognitionService.MyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Speech.RecognitionService.Callback p0 = global::Java.Lang.Object.GetObject<global::Android.Speech.RecognitionService.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetCallbackListener (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService.MyListener']/method[@name='setCallbackListener' and count(parameter)=1 and parameter[1][@type='android.speech.RecognitionService.Callback']]"
			[Register ("setCallbackListener", "(Landroid/speech/RecognitionService$Callback;)V", "GetSetCallbackListener_Landroid_speech_RecognitionService_Callback_Handler")]
			public virtual unsafe void SetCallbackListener (global::Android.Speech.RecognitionService.Callback p0)
			{
				const string __id = "setCallbackListener.(Landroid/speech/RecognitionService$Callback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/VoiceRecognitionService", typeof (VoiceRecognitionService));
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

		internal VoiceRecognitionService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/constructor[@name='VoiceRecognitionService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VoiceRecognitionService ()
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

		public static unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				const string __id = "getSdkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("fromJson", "(Lorg/json/JSONObject;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle FromJson (global::Org.Json.JSONObject p0)
		{
			const string __id = "fromJson.(Lorg/json/JSONObject;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='android.speech.RecognitionService.Callback']]"
		[Register ("onCancel", "(Landroid/speech/RecognitionService$Callback;)V", "")]
		protected override unsafe void OnCancel (global::Android.Speech.RecognitionService.Callback p0)
		{
			const string __id = "onCancel.(Landroid/speech/RecognitionService$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/method[@name='onStartListening' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.speech.RecognitionService.Callback']]"
		[Register ("onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V", "")]
		protected override unsafe void OnStartListening (global::Android.Content.Intent p0, global::Android.Speech.RecognitionService.Callback p1)
		{
			const string __id = "onStartListening.(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech']/class[@name='VoiceRecognitionService']/method[@name='onStopListening' and count(parameter)=1 and parameter[1][@type='android.speech.RecognitionService.Callback']]"
		[Register ("onStopListening", "(Landroid/speech/RecognitionService$Callback;)V", "")]
		protected override unsafe void OnStopListening (global::Android.Speech.RecognitionService.Callback p0)
		{
			const string __id = "onStopListening.(Landroid/speech/RecognitionService$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
