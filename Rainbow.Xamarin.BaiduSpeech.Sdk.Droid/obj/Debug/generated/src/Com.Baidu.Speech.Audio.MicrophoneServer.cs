using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer']"
	[global::Android.Runtime.Register ("com/baidu/speech/audio/MicrophoneServer", DoNotGenerateAcw=true)]
	public partial class MicrophoneServer : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer']/field[@name='S_DATA_LENGTH']"
		[Register ("S_DATA_LENGTH")]
		public const int SDataLength = (int) 1920000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer']/field[@name='S_LENGTH']"
		[Register ("S_LENGTH")]
		public const int SLength = (int) 640;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				const string __id = "TAG.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer.MicInputStream']"
		[global::Android.Runtime.Register ("com/baidu/speech/audio/MicrophoneServer$MicInputStream", DoNotGenerateAcw=true)]
		public partial class MicInputStream : global::Java.IO.InputStream {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/audio/MicrophoneServer$MicInputStream", typeof (MicInputStream));
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

			protected MicInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer.MicInputStream']/constructor[@name='MicrophoneServer.MicInputStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe MicInputStream (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_read;
#pragma warning disable 0169
			static Delegate GetReadHandler ()
			{
				if (cb_read == null)
					cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
				return cb_read;
			}

			static int n_Read (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Speech.Audio.MicrophoneServer.MicInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Audio.MicrophoneServer.MicInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Read ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer.MicInputStream']/method[@name='read' and count(parameter)=0]"
			[Register ("read", "()I", "GetReadHandler")]
			public override unsafe int Read ()
			{
				const string __id = "read.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/audio/MicrophoneServer", typeof (MicrophoneServer));
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

		protected MicrophoneServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("create", "(Ljava/lang/String;I)I", "")]
		public static unsafe int Create (string p0, int p1)
		{
			const string __id = "create.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Speech.Audio.MicrophoneServer __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Audio.MicrophoneServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.audio']/class[@name='MicrophoneServer']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
