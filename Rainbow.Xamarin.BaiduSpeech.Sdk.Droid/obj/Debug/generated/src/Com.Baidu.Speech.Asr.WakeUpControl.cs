using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Asr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl']"
	[global::Android.Runtime.Register ("com/baidu/speech/asr/WakeUpControl", DoNotGenerateAcw=true)]
	public partial class WakeUpControl : global::Java.Lang.Object, global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSCoreEventListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']"
		[global::Android.Runtime.Register ("com/baidu/speech/asr/WakeUpControl$DebugLogLevel", DoNotGenerateAcw=true)]
		public sealed partial class DebugLogLevel : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/field[@name='EVRDebugLogLevelDebug']"
			[Register ("EVRDebugLogLevelDebug")]
			public static global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel EVRDebugLogLevelDebug {
				get {
					const string __id = "EVRDebugLogLevelDebug.Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/field[@name='EVRDebugLogLevelError']"
			[Register ("EVRDebugLogLevelError")]
			public static global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel EVRDebugLogLevelError {
				get {
					const string __id = "EVRDebugLogLevelError.Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/field[@name='EVRDebugLogLevelFatal']"
			[Register ("EVRDebugLogLevelFatal")]
			public static global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel EVRDebugLogLevelFatal {
				get {
					const string __id = "EVRDebugLogLevelFatal.Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/field[@name='EVRDebugLogLevelInformation']"
			[Register ("EVRDebugLogLevelInformation")]
			public static global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel EVRDebugLogLevelInformation {
				get {
					const string __id = "EVRDebugLogLevelInformation.Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/field[@name='EVRDebugLogLevelOff']"
			[Register ("EVRDebugLogLevelOff")]
			public static global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel EVRDebugLogLevelOff {
				get {
					const string __id = "EVRDebugLogLevelOff.Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/field[@name='EVRDebugLogLevelTrace']"
			[Register ("EVRDebugLogLevelTrace")]
			public static global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel EVRDebugLogLevelTrace {
				get {
					const string __id = "EVRDebugLogLevelTrace.Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/field[@name='EVRDebugLogLevelWarning']"
			[Register ("EVRDebugLogLevelWarning")]
			public static global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel EVRDebugLogLevelWarning {
				get {
					const string __id = "EVRDebugLogLevelWarning.Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/asr/WakeUpControl$DebugLogLevel", typeof (DebugLogLevel));
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

			internal DebugLogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Ljava/lang/Enum;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl.DebugLogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;", "")]
			public static unsafe global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/speech/asr/WakeUpControl$DebugLogLevel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Speech.Asr.WakeUpControl.DebugLogLevel));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/asr/WakeUpControl", typeof (WakeUpControl));
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

		protected WakeUpControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl']/constructor[@name='WakeUpControl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WakeUpControl (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_postEvent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPostEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_postEvent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_postEvent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostEvent_Ljava_lang_String_Ljava_lang_String_);
			return cb_postEvent_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PostEvent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Speech.Asr.WakeUpControl __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostEvent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl']/method[@name='postEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("postEvent", "(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/speech/core/BDSErrorDescription;", "GetPostEvent_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Speech.Core.BDSErrorDescription PostEvent (string p0, string p1)
		{
			const string __id = "postEvent.(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/speech/core/BDSErrorDescription;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSErrorDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Baidu.Speech.Asr.WakeUpControl __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Core.BDSMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface p1 = (global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReceiveCoreEvent (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl']/method[@name='receiveCoreEvent' and count(parameter)=2 and parameter[1][@type='com.baidu.speech.core.BDSMessage'] and parameter[2][@type='com.baidu.speech.core.BDSSDKLoader.BDSSDKInterface']]"
		[Register ("receiveCoreEvent", "(Lcom/baidu/speech/core/BDSMessage;Lcom/baidu/speech/core/BDSSDKLoader$BDSSDKInterface;)V", "GetReceiveCoreEvent_Lcom_baidu_speech_core_BDSMessage_Lcom_baidu_speech_core_BDSSDKLoader_BDSSDKInterface_Handler")]
		public virtual unsafe void ReceiveCoreEvent (global::Com.Baidu.Speech.Core.BDSMessage p0, global::Com.Baidu.Speech.Core.BDSSDKLoader.IBDSSDKInterface p1)
		{
			const string __id = "receiveCoreEvent.(Lcom/baidu/speech/core/BDSMessage;Lcom/baidu/speech/core/BDSSDKLoader$BDSSDKInterface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_baidu_speech_EventListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_baidu_speech_EventListener_Handler ()
		{
			if (cb_setListener_Lcom_baidu_speech_EventListener_ == null)
				cb_setListener_Lcom_baidu_speech_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_baidu_speech_EventListener_);
			return cb_setListener_Lcom_baidu_speech_EventListener_;
		}

		static void n_SetListener_Lcom_baidu_speech_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Speech.Asr.WakeUpControl __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.WakeUpControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Speech.IEventListener p0 = (global::Com.Baidu.Speech.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='WakeUpControl']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.baidu.speech.EventListener']]"
		[Register ("setListener", "(Lcom/baidu/speech/EventListener;)V", "GetSetListener_Lcom_baidu_speech_EventListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Baidu.Speech.IEventListener p0)
		{
			const string __id = "setListener.(Lcom/baidu/speech/EventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Speech.IEventListener"

		global::Com.Baidu.Speech.IEventListenerImplementor __CreateIEventListenerImplementor ()
		{
			return new global::Com.Baidu.Speech.IEventListenerImplementor (this);
		}
#endregion
	}
}
