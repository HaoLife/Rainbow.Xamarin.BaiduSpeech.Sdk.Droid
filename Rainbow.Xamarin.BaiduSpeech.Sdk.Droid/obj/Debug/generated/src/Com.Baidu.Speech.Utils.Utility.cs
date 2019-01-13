using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']"
	[global::Android.Runtime.Register ("com/baidu/speech/utils/Utility", DoNotGenerateAcw=true)]
	public sealed partial class Utility : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/Utility", typeof (Utility));
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

		internal Utility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe int MaxCpuFreq {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='getMaxCpuFreq' and count(parameter)=0]"
			[Register ("getMaxCpuFreq", "()I", "GetGetMaxCpuFreqHandler")]
			get {
				const string __id = "getMaxCpuFreq.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='checkPermission' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='fun' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("fun", "(Ljava/lang/Exception;)Ljava/lang/String;", "")]
		public static unsafe string Fun (global::Java.Lang.Exception p0)
		{
			const string __id = "fun.(Ljava/lang/Exception;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='getFileName' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("getFileName", "(Ljava/lang/Exception;)Ljava/lang/String;", "")]
		public static unsafe string GetFileName (global::Java.Lang.Exception p0)
		{
			const string __id = "getFileName.(Ljava/lang/Exception;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='getLineNumber' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("getLineNumber", "(Ljava/lang/Exception;)Ljava/lang/String;", "")]
		public static unsafe string GetLineNumber (global::Java.Lang.Exception p0)
		{
			const string __id = "getLineNumber.(Ljava/lang/Exception;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='getNetworkInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='getVoiceDataSizeInShort' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getVoiceDataSizeInShort", "(III)I", "")]
		public static unsafe int GetVoiceDataSizeInShort (int p0, int p1, int p2)
		{
			const string __id = "getVoiceDataSizeInShort.(III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='getWifiOr2gOr3G' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getWifiOr2gOr3G", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetWifiOr2gOr3G (global::Android.Content.Context p0)
		{
			const string __id = "getWifiOr2gOr3G.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='is2G' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("is2G", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool Is2G (global::Android.Content.Context p0)
		{
			const string __id = "is2G.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='isNetworkConnected' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='isWifiConnected' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isWifiConnected", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsWifiConnected (global::Android.Content.Context p0)
		{
			const string __id = "isWifiConnected.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Utility']/method[@name='urlEncode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("urlEncode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlEncode (string p0, string p1)
		{
			const string __id = "urlEncode.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
