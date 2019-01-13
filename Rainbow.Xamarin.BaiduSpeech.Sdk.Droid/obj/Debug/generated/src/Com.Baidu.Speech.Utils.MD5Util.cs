using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='MD5Util']"
	[global::Android.Runtime.Register ("com/baidu/speech/utils/MD5Util", DoNotGenerateAcw=true)]
	public partial class MD5Util : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='MD5Util']/field[@name='hexDigits']"
		[Register ("hexDigits")]
		protected static IList<char> HexDigits {
			get {
				const string __id = "hexDigits.[C";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<char>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "hexDigits.[C";

				IntPtr native_value = global::Android.Runtime.JavaArray<char>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='MD5Util']/field[@name='messagedigest']"
		[Register ("messagedigest")]
		protected static global::Java.Security.MessageDigest Messagedigest {
			get {
				const string __id = "messagedigest.Ljava/security/MessageDigest;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "messagedigest.Ljava/security/MessageDigest;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/MD5Util", typeof (MD5Util));
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

		protected MD5Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='MD5Util']/constructor[@name='MD5Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MD5Util ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='MD5Util']/method[@name='getFileMD5String' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getFileMD5String", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string GetFileMD5String (global::Java.IO.File p0)
		{
			const string __id = "getFileMD5String.(Ljava/io/File;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='MD5Util']/method[@name='toHexString' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("toHexString", "([BLjava/lang/String;Z)Ljava/lang/String;", "")]
		public static unsafe string ToHexString (byte[] p0, string p1, bool p2)
		{
			const string __id = "toHexString.([BLjava/lang/String;Z)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='MD5Util']/method[@name='toMd5' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
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
