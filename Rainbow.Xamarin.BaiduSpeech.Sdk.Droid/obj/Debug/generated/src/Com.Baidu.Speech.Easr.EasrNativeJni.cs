using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Easr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.easr']/class[@name='easrNativeJni']"
	[global::Android.Runtime.Register ("com/baidu/speech/easr/easrNativeJni", DoNotGenerateAcw=true)]
	public partial class EasrNativeJni : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/easr/easrNativeJni", typeof (EasrNativeJni));
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

		protected EasrNativeJni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.easr']/class[@name='easrNativeJni']/method[@name='AECExit' and count(parameter)=0]"
		[Register ("AECExit", "()I", "")]
		public static unsafe int AECExit ()
		{
			const string __id = "AECExit.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.easr']/class[@name='easrNativeJni']/method[@name='AECInit' and count(parameter)=0]"
		[Register ("AECInit", "()I", "")]
		public static unsafe int AECInit ()
		{
			const string __id = "AECInit.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.easr']/class[@name='easrNativeJni']/method[@name='AECProcess' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='short[]'] and parameter[3][@type='short[]'] and parameter[4][@type='int']]"
		[Register ("AECProcess", "([S[S[SI)I", "")]
		public static unsafe int AECProcess (short[] p0, short[] p1, short[] p2, int p3)
		{
			const string __id = "AECProcess.([S[S[SI)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.easr']/class[@name='easrNativeJni']/method[@name='AECReset' and count(parameter)=0]"
		[Register ("AECReset", "()I", "")]
		public static unsafe int AECReset ()
		{
			const string __id = "AECReset.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.easr']/class[@name='easrNativeJni']/method[@name='SetLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetLogLevel", "(I)I", "")]
		public static unsafe int SetLogLevel (int p0)
		{
			const string __id = "SetLogLevel.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
