using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Asr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']"
	[global::Android.Runtime.Register ("com/baidu/speech/asr/PrivateConstant", DoNotGenerateAcw=true)]
	public partial class PrivateConstant : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='APIKEY']"
		[Register ("APIKEY")]
		public static string Apikey {
			get {
				const string __id = "APIKEY.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "APIKEY.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ASR_AUDIO_HANDLER_ERROR']"
		[Register ("ASR_AUDIO_HANDLER_ERROR")]
		public static int AsrAudioHandlerError {
			get {
				const string __id = "ASR_AUDIO_HANDLER_ERROR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ASR_AUDIO_HANDLER_ERROR.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ASR_HTTP_ERROR']"
		[Register ("ASR_HTTP_ERROR")]
		public static int AsrHttpError {
			get {
				const string __id = "ASR_HTTP_ERROR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ASR_HTTP_ERROR.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ASR_LOCAL_NETWORK_ERROR']"
		[Register ("ASR_LOCAL_NETWORK_ERROR")]
		public static int AsrLocalNetworkError {
			get {
				const string __id = "ASR_LOCAL_NETWORK_ERROR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ASR_LOCAL_NETWORK_ERROR.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ASR_OFFLINE_ENGINE_ERROR']"
		[Register ("ASR_OFFLINE_ENGINE_ERROR")]
		public static int AsrOfflineEngineError {
			get {
				const string __id = "ASR_OFFLINE_ENGINE_ERROR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ASR_OFFLINE_ENGINE_ERROR.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ASR_ONLINE_ENGINE_ERROR']"
		[Register ("ASR_ONLINE_ENGINE_ERROR")]
		public static int AsrOnlineEngineError {
			get {
				const string __id = "ASR_ONLINE_ENGINE_ERROR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ASR_ONLINE_ENGINE_ERROR.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ASR_OTHER_ERROR']"
		[Register ("ASR_OTHER_ERROR")]
		public static int AsrOtherError {
			get {
				const string __id = "ASR_OTHER_ERROR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ASR_OTHER_ERROR.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ASR_RECORDER_ERROR']"
		[Register ("ASR_RECORDER_ERROR")]
		public static int AsrRecorderError {
			get {
				const string __id = "ASR_RECORDER_ERROR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ASR_RECORDER_ERROR.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ASR_SERVER_ERROR']"
		[Register ("ASR_SERVER_ERROR")]
		public static int AsrServerError {
			get {
				const string __id = "ASR_SERVER_ERROR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ASR_SERVER_ERROR.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='AUTH']"
		[Register ("AUTH")]
		public static string Auth {
			get {
				const string __id = "AUTH.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "AUTH.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='BUA']"
		[Register ("BUA")]
		public static string Bua {
			get {
				const string __id = "BUA.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "BUA.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='COK']"
		[Register ("COK")]
		public static string Cok {
			get {
				const string __id = "COK.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "COK.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ENABLE_EARLY_RETURN']"
		[Register ("ENABLE_EARLY_RETURN")]
		public static string EnableEarlyReturn {
			get {
				const string __id = "ENABLE_EARLY_RETURN.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ENABLE_EARLY_RETURN.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='ENABLE_LONG_SPEECH']"
		[Register ("ENABLE_LONG_SPEECH")]
		public static string EnableLongSpeech {
			get {
				const string __id = "ENABLE_LONG_SPEECH.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ENABLE_LONG_SPEECH.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='FRM']"
		[Register ("FRM")]
		public static string Frm {
			get {
				const string __id = "FRM.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "FRM.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='KEY_WORD']"
		[Register ("KEY_WORD")]
		public static string KeyWord {
			get {
				const string __id = "KEY_WORD.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "KEY_WORD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='LM_RES_FILE_PATH']"
		[Register ("LM_RES_FILE_PATH")]
		public static string LmResFilePath {
			get {
				const string __id = "LM_RES_FILE_PATH.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "LM_RES_FILE_PATH.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='OFFLINE_ENGINE']"
		[Register ("OFFLINE_ENGINE")]
		public static string OfflineEngine {
			get {
				const string __id = "OFFLINE_ENGINE.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "OFFLINE_ENGINE.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='OFF_GRAMM_LM']"
		[Register ("OFF_GRAMM_LM")]
		public static string OffGrammLm {
			get {
				const string __id = "OFF_GRAMM_LM.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "OFF_GRAMM_LM.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='PFM']"
		[Register ("PFM")]
		public static string Pfm {
			get {
				const string __id = "PFM.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "PFM.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='PTC']"
		[Register ("PTC")]
		public static string Ptc {
			get {
				const string __id = "PTC.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "PTC.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='PU']"
		[Register ("PU")]
		public static string Pu {
			get {
				const string __id = "PU.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "PU.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='RSV']"
		[Register ("RSV")]
		public static string Rsv {
			get {
				const string __id = "RSV.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "RSV.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='SERVER_VAD']"
		[Register ("SERVER_VAD")]
		public static string ServerVad {
			get {
				const string __id = "SERVER_VAD.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "SERVER_VAD.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='UID']"
		[Register ("UID")]
		public static string Uid {
			get {
				const string __id = "UID.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "UID.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='UPLOAD_CONTRACT_DATA']"
		[Register ("UPLOAD_CONTRACT_DATA")]
		public static string UploadContractData {
			get {
				const string __id = "UPLOAD_CONTRACT_DATA.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "UPLOAD_CONTRACT_DATA.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='UPLOAD_SLOT_NAME']"
		[Register ("UPLOAD_SLOT_NAME")]
		public static string UploadSlotName {
			get {
				const string __id = "UPLOAD_SLOT_NAME.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "UPLOAD_SLOT_NAME.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='UPLOAD_WORDS']"
		[Register ("UPLOAD_WORDS")]
		public static string UploadWords {
			get {
				const string __id = "UPLOAD_WORDS.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "UPLOAD_WORDS.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/field[@name='VER']"
		[Register ("VER")]
		public static string Ver {
			get {
				const string __id = "VER.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "VER.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']"
		[global::Android.Runtime.Register ("com/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus", DoNotGenerateAcw=true)]
		public sealed partial class VoiceRecognitionClientWorkStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusCancel']"
			[Register ("EVoiceRecognitionClientWorkStatusCancel")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusCancel {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusCancel.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusEnd']"
			[Register ("EVoiceRecognitionClientWorkStatusEnd")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusEnd {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusEnd.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusError']"
			[Register ("EVoiceRecognitionClientWorkStatusError")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusError {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusError.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusFinish']"
			[Register ("EVoiceRecognitionClientWorkStatusFinish")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusFinish {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusFinish.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusFlushData']"
			[Register ("EVoiceRecognitionClientWorkStatusFlushData")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusFlushData {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusFlushData.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusLoaded']"
			[Register ("EVoiceRecognitionClientWorkStatusLoaded")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusLoaded {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusLoaded.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusMeterLevel']"
			[Register ("EVoiceRecognitionClientWorkStatusMeterLevel")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusMeterLevel {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusMeterLevel.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusNewRecordData']"
			[Register ("EVoiceRecognitionClientWorkStatusNewRecordData")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusNewRecordData {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusNewRecordData.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusStart']"
			[Register ("EVoiceRecognitionClientWorkStatusStart")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusStart {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusStart.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusStartWorkIng']"
			[Register ("EVoiceRecognitionClientWorkStatusStartWorkIng")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusStartWorkIng {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusStartWorkIng.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/field[@name='EVoiceRecognitionClientWorkStatusUnLoaded']"
			[Register ("EVoiceRecognitionClientWorkStatusUnLoaded")]
			public static global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus EVoiceRecognitionClientWorkStatusUnLoaded {
				get {
					const string __id = "EVoiceRecognitionClientWorkStatusUnLoaded.Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus", typeof (VoiceRecognitionClientWorkStatus));
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

			internal VoiceRecognitionClientWorkStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Ljava/lang/Enum;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant.VoiceRecognitionClientWorkStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;", "")]
			public static unsafe global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/speech/asr/PrivateConstant$VoiceRecognitionClientWorkStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Speech.Asr.PrivateConstant.VoiceRecognitionClientWorkStatus));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/asr/PrivateConstant", typeof (PrivateConstant));
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

		protected PrivateConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.asr']/class[@name='PrivateConstant']/constructor[@name='PrivateConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrivateConstant ()
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
