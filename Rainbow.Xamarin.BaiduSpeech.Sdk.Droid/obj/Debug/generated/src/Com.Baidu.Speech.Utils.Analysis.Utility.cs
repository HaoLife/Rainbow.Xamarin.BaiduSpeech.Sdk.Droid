using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Utils.Analysis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']"
	[global::Android.Runtime.Register ("com/baidu/speech/utils/analysis/Utility", DoNotGenerateAcw=true)]
	public partial class Utility : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/analysis/Utility", typeof (Utility));
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

		protected Utility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/constructor[@name='Utility' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utility ()
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

		public static unsafe string OS {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getOS' and count(parameter)=0]"
			[Register ("getOS", "()Ljava/lang/String;", "GetGetOSHandler")]
			get {
				const string __id = "getOS.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string SdkName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getSdkName' and count(parameter)=0]"
			[Register ("getSdkName", "()Ljava/lang/String;", "GetGetSdkNameHandler")]
			get {
				const string __id = "getSdkName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getSdkVersion' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='checkPermission' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkPermission", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool CheckPermission (global::Android.Content.Context p0, string p1)
		{
			const string __id = "checkPermission.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='encryptBASE64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encryptBASE64", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncryptBASE64 (byte[] p0)
		{
			const string __id = "encryptBASE64.([B)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='encryptBASE64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encryptBASE64", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncryptBASE64 (string p0)
		{
			const string __id = "encryptBASE64.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='encryptGZIP' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encryptGZIP", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] EncryptGZIP (string p0)
		{
			const string __id = "encryptGZIP.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getAppName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppName (global::Android.Content.Context p0)
		{
			const string __id = "getAppName.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getLastDownloadStatPeriod' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLastDownloadStatPeriod", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetLastDownloadStatPeriod (global::Android.Content.Context p0)
		{
			const string __id = "getLastDownloadStatPeriod.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getLastUploadStatTime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLastUploadStatTime", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetLastUploadStatTime (global::Android.Content.Context p0)
		{
			const string __id = "getLastUploadStatTime.(Landroid/content/Context;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getLicenseDataFromFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("getLicenseDataFromFile", "(Ljava/lang/String;[B)I", "")]
		public static unsafe int GetLicenseDataFromFile (string p0, byte[] p1)
		{
			const string __id = "getLicenseDataFromFile.(Ljava/lang/String;[B)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getNetType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetType", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetNetType (global::Android.Content.Context p0)
		{
			const string __id = "getNetType.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getNetworkInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkInfo", "(Landroid/content/Context;)Landroid/net/NetworkInfo;", "")]
		public static unsafe global::Android.Net.NetworkInfo GetNetworkInfo (global::Android.Content.Context p0)
		{
			const string __id = "getNetworkInfo.(Landroid/content/Context;)Landroid/net/NetworkInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.NetworkInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getPackageName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPackageName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetPackageName (global::Android.Content.Context p0)
		{
			const string __id = "getPackageName.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getPlatform' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPlatform", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetPlatform (global::Android.Content.Context p0)
		{
			const string __id = "getPlatform.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getScreen' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreen", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetScreen (global::Android.Content.Context p0)
		{
			const string __id = "getScreen.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='getSignatureMD5' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSignatureMD5", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetSignatureMD5 (global::Android.Content.Context p0)
		{
			const string __id = "getSignatureMD5.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='isNetworkConnected' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkConnected", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkConnected (global::Android.Content.Context p0)
		{
			const string __id = "isNetworkConnected.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='setLastDownloadStatPeriod' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setLastDownloadStatPeriod", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetLastDownloadStatPeriod (global::Android.Content.Context p0, int p1)
		{
			const string __id = "setLastDownloadStatPeriod.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Utility']/method[@name='setLastUploadStatTime' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setLastUploadStatTime", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetLastUploadStatTime (global::Android.Content.Context p0, long p1)
		{
			const string __id = "setLastUploadStatTime.(Landroid/content/Context;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
