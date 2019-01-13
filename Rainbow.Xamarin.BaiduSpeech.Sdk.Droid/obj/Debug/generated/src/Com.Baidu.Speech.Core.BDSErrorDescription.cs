using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSErrorDescription']"
	[global::Android.Runtime.Register ("com/baidu/speech/core/BDSErrorDescription", DoNotGenerateAcw=true)]
	public partial class BDSErrorDescription : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSErrorDescription']/field[@name='errorCode']"
		[Register ("errorCode")]
		public int ErrorCode {
			get {
				const string __id = "errorCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "errorCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSErrorDescription']/field[@name='errorDescription']"
		[Register ("errorDescription")]
		public string ErrorDescription {
			get {
				const string __id = "errorDescription.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorDescription.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSErrorDescription']/field[@name='errorDomain']"
		[Register ("errorDomain")]
		public int ErrorDomain {
			get {
				const string __id = "errorDomain.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "errorDomain.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSErrorDescription", typeof (BDSErrorDescription));
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

		protected BDSErrorDescription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSErrorDescription']/constructor[@name='BDSErrorDescription' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDSErrorDescription ()
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

		static Delegate cb_getDetailCode;
#pragma warning disable 0169
		static Delegate GetGetDetailCodeHandler ()
		{
			if (cb_getDetailCode == null)
				cb_getDetailCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDetailCode);
			return cb_getDetailCode;
		}

		static int n_GetDetailCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Speech.Core.BDSErrorDescription __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSErrorDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DetailCode;
		}
#pragma warning restore 0169

		public virtual unsafe int DetailCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSErrorDescription']/method[@name='getDetailCode' and count(parameter)=0]"
			[Register ("getDetailCode", "()I", "GetGetDetailCodeHandler")]
			get {
				const string __id = "getDetailCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
