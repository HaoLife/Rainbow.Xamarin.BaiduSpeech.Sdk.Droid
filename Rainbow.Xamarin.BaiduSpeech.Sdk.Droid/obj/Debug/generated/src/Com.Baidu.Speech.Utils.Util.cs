using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/baidu/speech/utils/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/Util", typeof (Util));
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

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Util ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Util']/method[@name='getDevId' and count(parameter)=1 and parameter[1][@type='android.telephony.TelephonyManager']]"
		[Register ("getDevId", "(Landroid/telephony/TelephonyManager;)Ljava/lang/String;", "")]
		public static unsafe string GetDevId (global::Android.Telephony.TelephonyManager p0)
		{
			const string __id = "getDevId.(Landroid/telephony/TelephonyManager;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Util']/method[@name='pfm' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("pfm", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string Pfm (global::Android.Content.Context p0)
		{
			const string __id = "pfm.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Util']/method[@name='toMd5' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("toMd5", "([BZ)Ljava/lang/String;", "")]
		public static unsafe string ToMd5 (byte[] p0, bool p1)
		{
			const string __id = "toMd5.([BZ)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
