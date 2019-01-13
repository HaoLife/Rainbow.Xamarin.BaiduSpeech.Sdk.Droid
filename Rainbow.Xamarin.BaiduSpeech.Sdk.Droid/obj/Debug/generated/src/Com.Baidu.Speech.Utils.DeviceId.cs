using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='DeviceId']"
	[global::Android.Runtime.Register ("com/baidu/speech/utils/DeviceId", DoNotGenerateAcw=true)]
	public sealed partial class DeviceId : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/DeviceId", typeof (DeviceId));
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

		internal DeviceId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='DeviceId']/method[@name='getCUID' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCUID", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCUID (global::Android.Content.Context p0)
		{
			const string __id = "getCUID.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='DeviceId']/method[@name='getDevID' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDevID", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDevID (global::Android.Content.Context p0)
		{
			const string __id = "getDevID.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='DeviceId']/method[@name='getDroidId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDroidId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDroidId (global::Android.Content.Context p0)
		{
			const string __id = "getDroidId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='DeviceId']/method[@name='getIntlMobEqId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIntlMobEqId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetIntlMobEqId (global::Android.Content.Context p0)
		{
			const string __id = "getIntlMobEqId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
