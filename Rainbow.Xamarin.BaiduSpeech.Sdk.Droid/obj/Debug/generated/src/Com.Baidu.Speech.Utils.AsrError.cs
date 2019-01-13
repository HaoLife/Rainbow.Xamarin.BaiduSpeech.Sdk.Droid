using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Speech.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']"
	[global::Android.Runtime.Register ("com/baidu/speech/utils/AsrError", DoNotGenerateAcw=true)]
	public sealed partial class AsrError : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_ASR_ENGINE_BUSY']"
		[Register ("ERROR_ASR_ENGINE_BUSY")]
		public const int ErrorAsrEngineBusy = (int) 8001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO']"
		[Register ("ERROR_AUDIO")]
		public const int ErrorAudio = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_FILE_CLOSE']"
		[Register ("ERROR_AUDIO_FILE_CLOSE")]
		public const int ErrorAudioFileClose = (int) 3010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_FILE_OPEN']"
		[Register ("ERROR_AUDIO_FILE_OPEN")]
		public const int ErrorAudioFileOpen = (int) 3008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_FILE_READ']"
		[Register ("ERROR_AUDIO_FILE_READ")]
		public const int ErrorAudioFileRead = (int) 3009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_INCORRECT']"
		[Register ("ERROR_AUDIO_INCORRECT")]
		public const int ErrorAudioIncorrect = (int) 3000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_RECORDER_CLOSE']"
		[Register ("ERROR_AUDIO_RECORDER_CLOSE")]
		public const int ErrorAudioRecorderClose = (int) 3007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_RECORDER_NOT_AVAILABLE']"
		[Register ("ERROR_AUDIO_RECORDER_NOT_AVAILABLE")]
		public const int ErrorAudioRecorderNotAvailable = (int) 3003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_RECORDER_OPEN']"
		[Register ("ERROR_AUDIO_RECORDER_OPEN")]
		public const int ErrorAudioRecorderOpen = (int) 3001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_RECORDER_PARAM']"
		[Register ("ERROR_AUDIO_RECORDER_PARAM")]
		public const int ErrorAudioRecorderParam = (int) 3002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_RECORDER_READ']"
		[Register ("ERROR_AUDIO_RECORDER_READ")]
		public const int ErrorAudioRecorderRead = (int) 3006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_SAMPLE_ERROR']"
		[Register ("ERROR_AUDIO_SAMPLE_ERROR")]
		public const int ErrorAudioSampleError = (int) 3011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_VAD_INCORRECT']"
		[Register ("ERROR_AUDIO_VAD_INCORRECT")]
		public const int ErrorAudioVadIncorrect = (int) 3100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_VAD_NO_SPEECH']"
		[Register ("ERROR_AUDIO_VAD_NO_SPEECH")]
		public const int ErrorAudioVadNoSpeech = (int) 3101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_AUDIO_VAD_SPEAK_TOO_SHORT']"
		[Register ("ERROR_AUDIO_VAD_SPEAK_TOO_SHORT")]
		public const int ErrorAudioVadSpeakTooShort = (int) 3102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_CLIENT']"
		[Register ("ERROR_CLIENT")]
		public const int ErrorClient = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_CLIENT_GET_TOKEN']"
		[Register ("ERROR_CLIENT_GET_TOKEN")]
		public const int ErrorClientGetToken = (int) 5003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_CLIENT_NEED_HTTPS_URL']"
		[Register ("ERROR_CLIENT_NEED_HTTPS_URL")]
		public const int ErrorClientNeedHttpsUrl = (int) 5005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_CLIENT_PARAM']"
		[Register ("ERROR_CLIENT_PARAM")]
		public const int ErrorClientParam = (int) 5002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_CLIENT_RESOLVE_URL']"
		[Register ("ERROR_CLIENT_RESOLVE_URL")]
		public const int ErrorClientResolveUrl = (int) 5004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_CLIENT_UNABLE_LOAD_LIBRARY']"
		[Register ("ERROR_CLIENT_UNABLE_LOAD_LIBRARY")]
		public const int ErrorClientUnableLoadLibrary = (int) 5001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_INSUFFICIENT_PERMISSIONS']"
		[Register ("ERROR_INSUFFICIENT_PERMISSIONS")]
		public const int ErrorInsufficientPermissions = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK']"
		[Register ("ERROR_NETWORK")]
		public const int ErrorNetwork = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_AGENT_CONNECT_DOWN']"
		[Register ("ERROR_NETWORK_FAIL_AGENT_CONNECT_DOWN")]
		public const int ErrorNetworkFailAgentConnectDown = (int) 2103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_AGENT_CONNECT_UP']"
		[Register ("ERROR_NETWORK_FAIL_AGENT_CONNECT_UP")]
		public const int ErrorNetworkFailAgentConnectUp = (int) 2106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_AGENT_DATA_DOWN']"
		[Register ("ERROR_NETWORK_FAIL_AGENT_DATA_DOWN")]
		public const int ErrorNetworkFailAgentDataDown = (int) 2105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_AGENT_READ_DOWN']"
		[Register ("ERROR_NETWORK_FAIL_AGENT_READ_DOWN")]
		public const int ErrorNetworkFailAgentReadDown = (int) 2104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_AGENT_READ_UP']"
		[Register ("ERROR_NETWORK_FAIL_AGENT_READ_UP")]
		public const int ErrorNetworkFailAgentReadUp = (int) 2102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_CONNECT']"
		[Register ("ERROR_NETWORK_FAIL_CONNECT")]
		public const int ErrorNetworkFailConnect = (int) 2000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_CONNECT_DOWN']"
		[Register ("ERROR_NETWORK_FAIL_CONNECT_DOWN")]
		public const int ErrorNetworkFailConnectDown = (int) 2004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_CONNECT_UP']"
		[Register ("ERROR_NETWORK_FAIL_CONNECT_UP")]
		public const int ErrorNetworkFailConnectUp = (int) 2002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_DATA_DOWN']"
		[Register ("ERROR_NETWORK_FAIL_DATA_DOWN")]
		public const int ErrorNetworkFailDataDown = (int) 2006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_READ']"
		[Register ("ERROR_NETWORK_FAIL_READ")]
		public const int ErrorNetworkFailRead = (int) 2001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_READ_DOWN']"
		[Register ("ERROR_NETWORK_FAIL_READ_DOWN")]
		public const int ErrorNetworkFailReadDown = (int) 2005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_FAIL_READ_UP']"
		[Register ("ERROR_NETWORK_FAIL_READ_UP")]
		public const int ErrorNetworkFailReadUp = (int) 2003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_NOT_AVAILABLE']"
		[Register ("ERROR_NETWORK_NOT_AVAILABLE")]
		public const int ErrorNetworkNotAvailable = (int) 2100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_NOT_GRANTED']"
		[Register ("ERROR_NETWORK_NOT_GRANTED")]
		public const int ErrorNetworkNotGranted = (int) 2101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_TIMEOUT']"
		[Register ("ERROR_NETWORK_TIMEOUT")]
		public const int ErrorNetworkTimeout = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_TIMEOUT_CONNECT']"
		[Register ("ERROR_NETWORK_TIMEOUT_CONNECT")]
		public const int ErrorNetworkTimeoutConnect = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_TIMEOUT_CONNECT_DOWN']"
		[Register ("ERROR_NETWORK_TIMEOUT_CONNECT_DOWN")]
		public const int ErrorNetworkTimeoutConnectDown = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_TIMEOUT_CONNECT_UP']"
		[Register ("ERROR_NETWORK_TIMEOUT_CONNECT_UP")]
		public const int ErrorNetworkTimeoutConnectUp = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_TIMEOUT_DNS']"
		[Register ("ERROR_NETWORK_TIMEOUT_DNS")]
		public const int ErrorNetworkTimeoutDns = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_TIMEOUT_READ']"
		[Register ("ERROR_NETWORK_TIMEOUT_READ")]
		public const int ErrorNetworkTimeoutRead = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_TIMEOUT_READ_DOWN']"
		[Register ("ERROR_NETWORK_TIMEOUT_READ_DOWN")]
		public const int ErrorNetworkTimeoutReadDown = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NETWORK_TIMEOUT_READ_UP']"
		[Register ("ERROR_NETWORK_TIMEOUT_READ_UP")]
		public const int ErrorNetworkTimeoutReadUp = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NO_MATCH']"
		[Register ("ERROR_NO_MATCH")]
		public const int ErrorNoMatch = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NO_MATCH_RESULT']"
		[Register ("ERROR_NO_MATCH_RESULT")]
		public const int ErrorNoMatchResult = (int) 7001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_NO_RECORD_PERMISSION']"
		[Register ("ERROR_NO_RECORD_PERMISSION")]
		public const int ErrorNoRecordPermission = (int) 9001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_ENGINE_FREE_FAIL']"
		[Register ("ERROR_OFFLINE_ENGINE_FREE_FAIL")]
		public const int ErrorOfflineEngineFreeFail = (int) 10010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_ENGINE_INITIAL_FAIL']"
		[Register ("ERROR_OFFLINE_ENGINE_INITIAL_FAIL")]
		public const int ErrorOfflineEngineInitialFail = (int) 10009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_ENGINE_NOT_SUPPORT']"
		[Register ("ERROR_OFFLINE_ENGINE_NOT_SUPPORT")]
		public const int ErrorOfflineEngineNotSupport = (int) 10011;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_ENGINE_RESET_FAIL']"
		[Register ("ERROR_OFFLINE_ENGINE_RESET_FAIL")]
		public const int ErrorOfflineEngineResetFail = (int) 10008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_EXCEPTION']"
		[Register ("ERROR_OFFLINE_EXCEPTION")]
		public const int ErrorOfflineException = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_INVALID_GRAMMAR']"
		[Register ("ERROR_OFFLINE_INVALID_GRAMMAR")]
		public const int ErrorOfflineInvalidGrammar = (int) 10007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_INVALID_LICENSE']"
		[Register ("ERROR_OFFLINE_INVALID_LICENSE")]
		public const int ErrorOfflineInvalidLicense = (int) 10003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_INVALID_MODEL']"
		[Register ("ERROR_OFFLINE_INVALID_MODEL")]
		public const int ErrorOfflineInvalidModel = (int) 10006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_NOT_INITIAL']"
		[Register ("ERROR_OFFLINE_NOT_INITIAL")]
		public const int ErrorOfflineNotInitial = (int) 10005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_NO_LICENSE']"
		[Register ("ERROR_OFFLINE_NO_LICENSE")]
		public const int ErrorOfflineNoLicense = (int) 10002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_PARAM']"
		[Register ("ERROR_OFFLINE_PARAM")]
		public const int ErrorOfflineParam = (int) 10004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_OFFLINE_RECOGNIZE_FAIL']"
		[Register ("ERROR_OFFLINE_RECOGNIZE_FAIL")]
		public const int ErrorOfflineRecognizeFail = (int) 10012;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_RECOGNIZER_BUSY']"
		[Register ("ERROR_RECOGNIZER_BUSY")]
		public const int ErrorRecognizerBusy = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_SERVER']"
		[Register ("ERROR_SERVER")]
		public const int ErrorServer = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_SERVER_APP']"
		[Register ("ERROR_SERVER_APP")]
		public const int ErrorServerApp = (int) 4004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_SERVER_BACKEND']"
		[Register ("ERROR_SERVER_BACKEND")]
		public const int ErrorServerBackend = (int) 4002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_SERVER_PARAM']"
		[Register ("ERROR_SERVER_PARAM")]
		public const int ErrorServerParam = (int) 4001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_SERVER_RECOGNITION']"
		[Register ("ERROR_SERVER_RECOGNITION")]
		public const int ErrorServerRecognition = (int) 4003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_SPEECH_TIMEOUT']"
		[Register ("ERROR_SPEECH_TIMEOUT")]
		public const int ErrorSpeechTimeout = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_SPEECH_TOO_LONG']"
		[Register ("ERROR_SPEECH_TOO_LONG")]
		public const int ErrorSpeechTooLong = (int) 6001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_ENGINE_EXCEPTION']"
		[Register ("ERROR_WAKEUP_ENGINE_EXCEPTION")]
		public const int ErrorWakeupEngineException = (int) 11001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_ENGINE_FREE_FAIL']"
		[Register ("ERROR_WAKEUP_ENGINE_FREE_FAIL")]
		public const int ErrorWakeupEngineFreeFail = (int) 11009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_ENGINE_INITIAL_FAIL']"
		[Register ("ERROR_WAKEUP_ENGINE_INITIAL_FAIL")]
		public const int ErrorWakeupEngineInitialFail = (int) 11006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_ENGINE_NOT_SUPPORT']"
		[Register ("ERROR_WAKEUP_ENGINE_NOT_SUPPORT")]
		public const int ErrorWakeupEngineNotSupport = (int) 11010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_ENGINE_RESET_FAIL']"
		[Register ("ERROR_WAKEUP_ENGINE_RESET_FAIL")]
		public const int ErrorWakeupEngineResetFail = (int) 11008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_EXCEPTION']"
		[Register ("ERROR_WAKEUP_EXCEPTION")]
		public const int ErrorWakeupException = (int) 11004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_INVALID_LICENSE']"
		[Register ("ERROR_WAKEUP_INVALID_LICENSE")]
		public const int ErrorWakeupInvalidLicense = (int) 11003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_MEM_ALLOC_FAIL']"
		[Register ("ERROR_WAKEUP_MEM_ALLOC_FAIL")]
		public const int ErrorWakeupMemAllocFail = (int) 11007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_MODEL_EXCEPTION']"
		[Register ("ERROR_WAKEUP_MODEL_EXCEPTION")]
		public const int ErrorWakeupModelException = (int) 11005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_NO_LICENSE']"
		[Register ("ERROR_WAKEUP_NO_LICENSE")]
		public const int ErrorWakeupNoLicense = (int) 11002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/field[@name='ERROR_WAKEUP_RECOGNIZE_FAIL']"
		[Register ("ERROR_WAKEUP_RECOGNIZE_FAIL")]
		public const int ErrorWakeupRecognizeFail = (int) 11011;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/speech/utils/AsrError", typeof (AsrError));
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

		internal AsrError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/constructor[@name='AsrError' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsrError ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.speech.utils']/class[@name='AsrError']/method[@name='getDescFromCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDescFromCode", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetDescFromCode (int p0)
		{
			const string __id = "getDescFromCode.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
