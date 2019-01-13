using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase']"
	[global::Android.Runtime.Register ("com/baidu/speech/core/BDSParamBase", DoNotGenerateAcw=true)]
	public abstract partial class BDSParamBase : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase']/field[@name='iParamType']"
		[Register ("iParamType")]
		public string IParamType {
			get {
				const string __id = "iParamType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "iParamType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSBooleanParam']"
		[global::Android.Runtime.Register ("com/baidu/speech/core/BDSParamBase$BDSBooleanParam", DoNotGenerateAcw=true)]
		public partial class BDSBooleanParam : global::Com.Baidu.Speech.Core.BDSParamBase {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSBooleanParam']/field[@name='iValue']"
			[Register ("iValue")]
			public bool IValue {
				get {
					const string __id = "iValue.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "iValue.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSParamBase$BDSBooleanParam", typeof (BDSBooleanParam));
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

			protected BDSBooleanParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSBooleanParam']/constructor[@name='BDSParamBase.BDSBooleanParam' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register (".ctor", "(Z)V", "")]
			public unsafe BDSBooleanParam (bool p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSFloatParam']"
		[global::Android.Runtime.Register ("com/baidu/speech/core/BDSParamBase$BDSFloatParam", DoNotGenerateAcw=true)]
		public partial class BDSFloatParam : global::Com.Baidu.Speech.Core.BDSParamBase {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSFloatParam']/field[@name='iValue']"
			[Register ("iValue")]
			public float IValue {
				get {
					const string __id = "iValue.F";

					var __v = _members.InstanceFields.GetSingleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "iValue.F";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSParamBase$BDSFloatParam", typeof (BDSFloatParam));
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

			protected BDSFloatParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSFloatParam']/constructor[@name='BDSParamBase.BDSFloatParam' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register (".ctor", "(F)V", "")]
			public unsafe BDSFloatParam (float p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(F)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSIntParam']"
		[global::Android.Runtime.Register ("com/baidu/speech/core/BDSParamBase$BDSIntParam", DoNotGenerateAcw=true)]
		public partial class BDSIntParam : global::Com.Baidu.Speech.Core.BDSParamBase {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSIntParam']/field[@name='iValue']"
			[Register ("iValue")]
			public int IValue {
				get {
					const string __id = "iValue.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "iValue.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSParamBase$BDSIntParam", typeof (BDSIntParam));
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

			protected BDSIntParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSIntParam']/constructor[@name='BDSParamBase.BDSIntParam' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe BDSIntParam (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSObjectParam']"
		[global::Android.Runtime.Register ("com/baidu/speech/core/BDSParamBase$BDSObjectParam", DoNotGenerateAcw=true)]
		public partial class BDSObjectParam : global::Com.Baidu.Speech.Core.BDSParamBase {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSObjectParam']/field[@name='iValue']"
			[Register ("iValue")]
			public global::Java.Lang.Object IValue {
				get {
					const string __id = "iValue.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "iValue.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSParamBase$BDSObjectParam", typeof (BDSObjectParam));
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

			protected BDSObjectParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase.BDSObjectParam']/constructor[@name='BDSParamBase.BDSObjectParam' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe BDSObjectParam (global::Java.Lang.Object p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Object;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSParamBase", typeof (BDSParamBase));
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

		protected BDSParamBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase']/constructor[@name='BDSParamBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDSParamBase ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase']/method[@name='boolParam' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("boolParam", "(Z)Lcom/baidu/speech/core/BDSParamBase$BDSBooleanParam;", "")]
		public static unsafe global::Com.Baidu.Speech.Core.BDSParamBase.BDSBooleanParam BoolParam (bool p0)
		{
			const string __id = "boolParam.(Z)Lcom/baidu/speech/core/BDSParamBase$BDSBooleanParam;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSParamBase.BDSBooleanParam> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase']/method[@name='floatParam' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("floatParam", "(F)Lcom/baidu/speech/core/BDSParamBase$BDSFloatParam;", "")]
		public static unsafe global::Com.Baidu.Speech.Core.BDSParamBase.BDSFloatParam FloatParam (float p0)
		{
			const string __id = "floatParam.(F)Lcom/baidu/speech/core/BDSParamBase$BDSFloatParam;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSParamBase.BDSFloatParam> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase']/method[@name='intParam' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("intParam", "(I)Lcom/baidu/speech/core/BDSParamBase$BDSIntParam;", "")]
		public static unsafe global::Com.Baidu.Speech.Core.BDSParamBase.BDSIntParam IntParam (int p0)
		{
			const string __id = "intParam.(I)Lcom/baidu/speech/core/BDSParamBase$BDSIntParam;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSParamBase.BDSIntParam> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSParamBase']/method[@name='objectParam' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("objectParam", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/baidu/speech/core/BDSParamBase$BDSObjectParam;", "")]
		public static unsafe global::Com.Baidu.Speech.Core.BDSParamBase.BDSObjectParam ObjectParam (global::Java.Lang.Object p0, string p1)
		{
			const string __id = "objectParam.(Ljava/lang/Object;Ljava/lang/String;)Lcom/baidu/speech/core/BDSParamBase$BDSObjectParam;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSParamBase.BDSObjectParam> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	[global::Android.Runtime.Register ("com/baidu/speech/core/BDSParamBase", DoNotGenerateAcw=true)]
	internal partial class BDSParamBaseInvoker : BDSParamBase {

		public BDSParamBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/speech/core/BDSParamBase", typeof (BDSParamBaseInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
