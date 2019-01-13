using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Utils.Analysis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis']"
	[global::Android.Runtime.Register ("com/baidu/speech/utils/analysis/Analysis", DoNotGenerateAcw=true)]
	public partial class Analysis : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']"
		[global::Android.Runtime.Register ("com/baidu/speech/utils/analysis/Analysis$Item", DoNotGenerateAcw=true)]
		public partial class Item : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='TYPE_ASR_LONGSPEECH']"
			[Register ("TYPE_ASR_LONGSPEECH")]
			public const string TypeAsrLongspeech = (string) "asr_longspeech";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='TYPE_NORMAL']"
			[Register ("TYPE_NORMAL")]
			public const string TypeNormal = (string) "asr_normal";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='TYPE_TTS']"
			[Register ("TYPE_TTS")]
			public const string TypeTts = (string) "tts";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='TYPE_WAKEUP']"
			[Register ("TYPE_WAKEUP")]
			public const string TypeWakeup = (string) "wakeup";


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='appId']"
			[Register ("appId")]
			public int AppId {
				get {
					const string __id = "appId.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "appId.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='decoder']"
			[Register ("decoder")]
			public int Decoder {
				get {
					const string __id = "decoder.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "decoder.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='error_code']"
			[Register ("error_code")]
			public int ErrorCode {
				get {
					const string __id = "error_code.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "error_code.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='pid']"
			[Register ("pid")]
			public int Pid {
				get {
					const string __id = "pid.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "pid.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='pkg']"
			[Register ("pkg")]
			public string Pkg {
				get {
					const string __id = "pkg.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pkg.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='time']"
			[Register ("time")]
			public long Time {
				get {
					const string __id = "time.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "time.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/field[@name='type']"
			[Register ("type")]
			public string Type {
				get {
					const string __id = "type.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "type.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/analysis/Analysis$Item", typeof (Item));
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

			protected Item (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis.Item']/constructor[@name='Analysis.Item' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Item ()
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

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/analysis/Analysis", typeof (Analysis));
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

		protected Analysis (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis']/constructor[@name='Analysis' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Analysis ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis']/method[@name='asyncUploadAll' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("asyncUploadAll", "(Landroid/content/Context;)V", "")]
		public static unsafe void AsyncUploadAll (global::Android.Content.Context p0)
		{
			const string __id = "asyncUploadAll.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils.analysis']/class[@name='Analysis']/method[@name='log' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.speech.utils.analysis.Analysis.Item']]"
		[Register ("log", "(Landroid/content/Context;Lcom/baidu/speech/utils/analysis/Analysis$Item;)V", "")]
		public static unsafe void Log (global::Android.Content.Context p0, global::Com.Baidu.Speech.Utils.Analysis.Analysis.Item p1)
		{
			const string __id = "log.(Landroid/content/Context;Lcom/baidu/speech/utils/analysis/Analysis$Item;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
