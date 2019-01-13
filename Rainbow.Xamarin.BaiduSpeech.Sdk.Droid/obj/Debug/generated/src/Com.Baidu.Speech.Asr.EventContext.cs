using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Asr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']"
	[global::Android.Runtime.Register ("com/baidu/speech/asr/EventContext", DoNotGenerateAcw=true)]
	public sealed partial class EventContext : global::Android.Content.ContextWrapper {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/asr/EventContext", typeof (EventContext));
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

		internal EventContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/constructor[@name='EventContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe EventContext (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

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

		public unsafe global::Android.Content.ISharedPreferences SdkSharedPreferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='getSdkSharedPreferences' and count(parameter)=0]"
			[Register ("getSdkSharedPreferences", "()Landroid/content/SharedPreferences;", "GetGetSdkSharedPreferencesHandler")]
			get {
				const string __id = "getSdkSharedPreferences.()Landroid/content/SharedPreferences;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='byteToShortArray' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("byteToShortArray", "([BII)[S", "")]
		public static unsafe short[] ByteToShortArray (byte[] p0, int p1, int p2)
		{
			const string __id = "byteToShortArray.([BII)[S";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (short[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (short));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='computePower' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("computePower", "([BI)J", "")]
		public unsafe long ComputePower (byte[] p0, int p1)
		{
			const string __id = "computePower.([BI)J";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='computePower' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='int']]"
		[Register ("computePower", "([SI)J", "")]
		public static unsafe long ComputePower (short[] p0, int p1)
		{
			const string __id = "computePower.([SI)J";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='httpRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean']]"
		[Register ("httpRequest", "(Ljava/lang/String;Ljava/util/Map;[BZ)Ljava/lang/String;", "")]
		public unsafe string HttpRequest (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, byte[] p2, bool p3)
		{
			const string __id = "httpRequest.(Ljava/lang/String;Ljava/util/Map;[BZ)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='join' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("join", "(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Join (global::System.Collections.Generic.IList<string> p0, string p1)
		{
			const string __id = "join.(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='loadBytesFromUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadBytesFromUri", "(Ljava/lang/String;)[B", "")]
		public unsafe byte[] LoadBytesFromUri (string p0)
		{
			const string __id = "loadBytesFromUri.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='loadJsonFromUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadJsonFromUri", "(Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject LoadJsonFromUri (string p0)
		{
			const string __id = "loadJsonFromUri.(Ljava/lang/String;)Lorg/json/JSONObject;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='loadJsonFromUri' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("loadJsonFromUri", "(Ljava/lang/String;ZZ)Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject LoadJsonFromUri (string p0, bool p1, bool p2)
		{
			const string __id = "loadJsonFromUri.(Ljava/lang/String;ZZ)Lorg/json/JSONObject;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='loadJsonFromUriOrThrow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadJsonFromUriOrThrow", "(Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject LoadJsonFromUriOrThrow (string p0)
		{
			const string __id = "loadJsonFromUriOrThrow.(Ljava/lang/String;)Lorg/json/JSONObject;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='loadJsonFromUriOrThrow' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("loadJsonFromUriOrThrow", "(Ljava/lang/String;ZZ)Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject LoadJsonFromUriOrThrow (string p0, bool p1, bool p2)
		{
			const string __id = "loadJsonFromUriOrThrow.(Ljava/lang/String;ZZ)Lorg/json/JSONObject;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='loadStringFromUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadStringFromUri", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string LoadStringFromUri (string p0)
		{
			const string __id = "loadStringFromUri.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='loadStringFromUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("loadStringFromUri", "(Ljava/lang/String;Z)Ljava/lang/String;", "")]
		public unsafe string LoadStringFromUri (string p0, bool p1)
		{
			const string __id = "loadStringFromUri.(Ljava/lang/String;Z)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='loggerIt' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String...']]"
		[Register ("loggerIt", "(Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object LoggerIt (global::Java.Lang.Object p0, params string[] p1)
		{
			const string __id = "loggerIt.(Ljava/lang/Object;[Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='EventContext']/method[@name='searchItemFromJson' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("searchItemFromJson", "(Lorg/json/JSONObject;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object SearchItemFromJson (global::Org.Json.JSONObject p0, string p1)
		{
			const string __id = "searchItemFromJson.(Lorg/json/JSONObject;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
