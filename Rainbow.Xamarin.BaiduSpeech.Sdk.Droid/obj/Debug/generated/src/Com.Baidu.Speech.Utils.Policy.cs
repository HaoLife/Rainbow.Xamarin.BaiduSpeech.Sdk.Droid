using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']"
	[global::Android.Runtime.Register ("com/baidu/speech/utils/Policy", DoNotGenerateAcw=true)]
	public partial class Policy : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/Policy", typeof (Policy));
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

		protected Policy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/constructor[@name='Policy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Policy ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/method[@name='app' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("app", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string App (global::Android.Content.Context p0)
		{
			const string __id = "app.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/method[@name='modelVadDefaultResFile' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("modelVadDefaultResFile", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string ModelVadDefaultResFile (global::Android.Content.Context p0)
		{
			const string __id = "modelVadDefaultResFile.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/method[@name='pfm' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sample", "(Landroid/content/Context;)I", "")]
		public static unsafe int Sample (global::Android.Content.Context p0)
		{
			const string __id = "sample.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/method[@name='taskTimeout' and count(parameter)=0]"
		[Register ("taskTimeout", "()I", "")]
		public static unsafe int TaskTimeout ()
		{
			const string __id = "taskTimeout.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/method[@name='uiRetryFile' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("uiRetryFile", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string UiRetryFile (global::Android.Content.Context p0)
		{
			const string __id = "uiRetryFile.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/method[@name='uid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("uid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string Uid (global::Android.Content.Context p0)
		{
			const string __id = "uid.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='Policy']/method[@name='ver' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("ver", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string Ver (global::Android.Content.Context p0)
		{
			const string __id = "ver.(Landroid/content/Context;)Ljava/lang/String;";
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
