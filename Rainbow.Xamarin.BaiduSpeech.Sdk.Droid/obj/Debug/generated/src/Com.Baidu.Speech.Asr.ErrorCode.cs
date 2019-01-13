using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Asr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/baidu/speech/asr/ErrorCode", DoNotGenerateAcw=true)]
	public partial class ErrorCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/field[@name='RECOGNIZER_OK']"
		[Register ("RECOGNIZER_OK")]
		public const int RecognizerOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/field[@name='RECORDING_EXCEPTION']"
		[Register ("RECORDING_EXCEPTION")]
		public const int RecordingException = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/field[@name='RECORDING_FILE_OPEN_FAIL']"
		[Register ("RECORDING_FILE_OPEN_FAIL")]
		public const int RecordingFileOpenFail = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/field[@name='RECORDING_INTERRUPT']"
		[Register ("RECORDING_INTERRUPT")]
		public const int RecordingInterrupt = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/field[@name='RECORDING_NO_PERMISSION']"
		[Register ("RECORDING_NO_PERMISSION")]
		public const int RecordingNoPermission = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/field[@name='RECORDING_OPEN_FAIL']"
		[Register ("RECORDING_OPEN_FAIL")]
		public const int RecordingOpenFail = (int) 1004;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/asr/ErrorCode", typeof (ErrorCode));
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

		protected ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/constructor[@name='ErrorCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCode ()
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

		static Delegate cb_getDesc_I;
#pragma warning disable 0169
		static Delegate GetGetDesc_IHandler ()
		{
			if (cb_getDesc_I == null)
				cb_getDesc_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDesc_I);
			return cb_getDesc_I;
		}

		static IntPtr n_GetDesc_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Speech.Asr.ErrorCode __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.ErrorCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetDesc (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/method[@name='getDesc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDesc", "(I)Ljava/lang/String;", "GetGetDesc_IHandler")]
		public virtual unsafe string GetDesc (int p0)
		{
			const string __id = "getDesc.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMessage_I;
#pragma warning disable 0169
		static Delegate GetGetMessage_IHandler ()
		{
			if (cb_getMessage_I == null)
				cb_getMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMessage_I);
			return cb_getMessage_I;
		}

		static IntPtr n_GetMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Speech.Asr.ErrorCode __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.ErrorCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetMessage (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='ErrorCode']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMessage", "(I)Ljava/lang/String;", "GetGetMessage_IHandler")]
		public virtual unsafe string GetMessage (int p0)
		{
			const string __id = "getMessage.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
