using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSMessage']"
	[global::Android.Runtime.Register ("com/baidu/speech/core/BDSMessage", DoNotGenerateAcw=true)]
	public partial class BDSMessage : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSMessage']/field[@name='m_dataOffset']"
		[Register ("m_dataOffset")]
		public long MDataOffset {
			get {
				const string __id = "m_dataOffset.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "m_dataOffset.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSMessage']/field[@name='m_messageData']"
		[Register ("m_messageData")]
		public IList<byte> MMessageData {
			get {
				const string __id = "m_messageData.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "m_messageData.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSMessage']/field[@name='m_messageName']"
		[Register ("m_messageName")]
		public string MMessageName {
			get {
				const string __id = "m_messageName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "m_messageName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSMessage']/field[@name='m_messageParams']"
		[Register ("m_messageParams")]
		public global::System.Collections.IDictionary MMessageParams {
			get {
				const string __id = "m_messageParams.Ljava/util/HashMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "m_messageParams.Ljava/util/HashMap;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSMessage", typeof (BDSMessage));
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

		protected BDSMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSMessage']/constructor[@name='BDSMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDSMessage ()
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
}
