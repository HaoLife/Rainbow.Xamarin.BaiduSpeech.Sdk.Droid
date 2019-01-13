using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']"
	[global::Android.Runtime.Register ("com/baidu/speech/core/BDSHttpRequestMaker", DoNotGenerateAcw=true)]
	public partial class BDSHttpRequestMaker : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/core/BDSHttpRequestMaker", typeof (BDSHttpRequestMaker));
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

		protected BDSHttpRequestMaker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/constructor[@name='BDSHttpRequestMaker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDSHttpRequestMaker ()
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

		static Delegate cb_cancelRequest;
#pragma warning disable 0169
		static Delegate GetCancelRequestHandler ()
		{
			if (cb_cancelRequest == null)
				cb_cancelRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelRequest);
			return cb_cancelRequest;
		}

		static void n_CancelRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Speech.Core.BDSHttpRequestMaker __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHttpRequestMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelRequest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/method[@name='cancelRequest' and count(parameter)=0]"
		[Register ("cancelRequest", "()V", "GetCancelRequestHandler")]
		public virtual unsafe void CancelRequest ()
		{
			const string __id = "cancelRequest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_makeRequest_Ljava_lang_String_arrayBarrayLjava_lang_String_FI;
#pragma warning disable 0169
		static Delegate GetMakeRequest_Ljava_lang_String_arrayBarrayLjava_lang_String_FIHandler ()
		{
			if (cb_makeRequest_Ljava_lang_String_arrayBarrayLjava_lang_String_FI == null)
				cb_makeRequest_Ljava_lang_String_arrayBarrayLjava_lang_String_FI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, int, IntPtr>) n_MakeRequest_Ljava_lang_String_arrayBarrayLjava_lang_String_FI);
			return cb_makeRequest_Ljava_lang_String_arrayBarrayLjava_lang_String_FI;
		}

		static IntPtr n_MakeRequest_Ljava_lang_String_arrayBarrayLjava_lang_String_FI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, float p3, int p4)
		{
			global::Com.Baidu.Speech.Core.BDSHttpRequestMaker __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHttpRequestMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MakeRequest (p0, p1, p2, p3, p4));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/method[@name='makeRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='float'] and parameter[5][@type='int']]"
		[Register ("makeRequest", "(Ljava/lang/String;[B[Ljava/lang/String;FI)Lcom/baidu/speech/core/BDSHTTPResponse;", "GetMakeRequest_Ljava_lang_String_arrayBarrayLjava_lang_String_FIHandler")]
		public virtual unsafe global::Com.Baidu.Speech.Core.BDSHTTPResponse MakeRequest (string p0, byte[] p1, string[] p2, float p3, int p4)
		{
			const string __id = "makeRequest.(Ljava/lang/String;[B[Ljava/lang/String;FI)Lcom/baidu/speech/core/BDSHTTPResponse;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHTTPResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/method[@name='newRequestMaker' and count(parameter)=0]"
		[Register ("newRequestMaker", "()Lcom/baidu/speech/core/BDSHttpRequestMaker;", "")]
		public static unsafe global::Com.Baidu.Speech.Core.BDSHttpRequestMaker NewRequestMaker ()
		{
			const string __id = "newRequestMaker.()Lcom/baidu/speech/core/BDSHttpRequestMaker;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHttpRequestMaker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readData;
#pragma warning disable 0169
		static Delegate GetReadDataHandler ()
		{
			if (cb_readData == null)
				cb_readData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadData);
			return cb_readData;
		}

		static IntPtr n_ReadData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Speech.Core.BDSHttpRequestMaker __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHttpRequestMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/method[@name='readData' and count(parameter)=0]"
		[Register ("readData", "()Lcom/baidu/speech/core/BDSHTTPResponse;", "GetReadDataHandler")]
		public virtual unsafe global::Com.Baidu.Speech.Core.BDSHTTPResponse ReadData ()
		{
			const string __id = "readData.()Lcom/baidu/speech/core/BDSHTTPResponse;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHTTPResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sendData_arrayBZ;
#pragma warning disable 0169
		static Delegate GetSendData_arrayBZHandler ()
		{
			if (cb_sendData_arrayBZ == null)
				cb_sendData_arrayBZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, int>) n_SendData_arrayBZ);
			return cb_sendData_arrayBZ;
		}

		static int n_SendData_arrayBZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Baidu.Speech.Core.BDSHttpRequestMaker __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHttpRequestMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SendData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/method[@name='sendData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("sendData", "([BZ)I", "GetSendData_arrayBZHandler")]
		public virtual unsafe int SendData (byte[] p0, bool p1)
		{
			const string __id = "sendData.([BZ)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setupConnection_Ljava_lang_String_arrayLjava_lang_String_FI;
#pragma warning disable 0169
		static Delegate GetSetupConnection_Ljava_lang_String_arrayLjava_lang_String_FIHandler ()
		{
			if (cb_setupConnection_Ljava_lang_String_arrayLjava_lang_String_FI == null)
				cb_setupConnection_Ljava_lang_String_arrayLjava_lang_String_FI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, int, int>) n_SetupConnection_Ljava_lang_String_arrayLjava_lang_String_FI);
			return cb_setupConnection_Ljava_lang_String_arrayLjava_lang_String_FI;
		}

		static int n_SetupConnection_Ljava_lang_String_arrayLjava_lang_String_FI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, int p3)
		{
			global::Com.Baidu.Speech.Core.BDSHttpRequestMaker __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHttpRequestMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.SetupConnection (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/method[@name='setupConnection' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='float'] and parameter[4][@type='int']]"
		[Register ("setupConnection", "(Ljava/lang/String;[Ljava/lang/String;FI)I", "GetSetupConnection_Ljava_lang_String_arrayLjava_lang_String_FIHandler")]
		public virtual unsafe int SetupConnection (string p0, string[] p1, float p2, int p3)
		{
			const string __id = "setupConnection.(Ljava/lang/String;[Ljava/lang/String;FI)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_setupDownloadConnection_Ljava_lang_String_arrayLjava_lang_String_FI;
#pragma warning disable 0169
		static Delegate GetSetupDownloadConnection_Ljava_lang_String_arrayLjava_lang_String_FIHandler ()
		{
			if (cb_setupDownloadConnection_Ljava_lang_String_arrayLjava_lang_String_FI == null)
				cb_setupDownloadConnection_Ljava_lang_String_arrayLjava_lang_String_FI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, int, int>) n_SetupDownloadConnection_Ljava_lang_String_arrayLjava_lang_String_FI);
			return cb_setupDownloadConnection_Ljava_lang_String_arrayLjava_lang_String_FI;
		}

		static int n_SetupDownloadConnection_Ljava_lang_String_arrayLjava_lang_String_FI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, int p3)
		{
			global::Com.Baidu.Speech.Core.BDSHttpRequestMaker __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHttpRequestMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.SetupDownloadConnection (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/method[@name='setupDownloadConnection' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='float'] and parameter[4][@type='int']]"
		[Register ("setupDownloadConnection", "(Ljava/lang/String;[Ljava/lang/String;FI)I", "GetSetupDownloadConnection_Ljava_lang_String_arrayLjava_lang_String_FIHandler")]
		public virtual unsafe int SetupDownloadConnection (string p0, string[] p1, float p2, int p3)
		{
			const string __id = "setupDownloadConnection.(Ljava/lang/String;[Ljava/lang/String;FI)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_setupUploadConnection_Ljava_lang_String_arrayLjava_lang_String_FI;
#pragma warning disable 0169
		static Delegate GetSetupUploadConnection_Ljava_lang_String_arrayLjava_lang_String_FIHandler ()
		{
			if (cb_setupUploadConnection_Ljava_lang_String_arrayLjava_lang_String_FI == null)
				cb_setupUploadConnection_Ljava_lang_String_arrayLjava_lang_String_FI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, int, int>) n_SetupUploadConnection_Ljava_lang_String_arrayLjava_lang_String_FI);
			return cb_setupUploadConnection_Ljava_lang_String_arrayLjava_lang_String_FI;
		}

		static int n_SetupUploadConnection_Ljava_lang_String_arrayLjava_lang_String_FI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, int p3)
		{
			global::Com.Baidu.Speech.Core.BDSHttpRequestMaker __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Core.BDSHttpRequestMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.SetupUploadConnection (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.core']/class[@name='BDSHttpRequestMaker']/method[@name='setupUploadConnection' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='float'] and parameter[4][@type='int']]"
		[Register ("setupUploadConnection", "(Ljava/lang/String;[Ljava/lang/String;FI)I", "GetSetupUploadConnection_Ljava_lang_String_arrayLjava_lang_String_FIHandler")]
		public virtual unsafe int SetupUploadConnection (string p0, string[] p1, float p2, int p3)
		{
			const string __id = "setupUploadConnection.(Ljava/lang/String;[Ljava/lang/String;FI)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
