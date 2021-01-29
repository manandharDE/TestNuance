using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MBSCTRLLib;

namespace Tcs_MbsCtrl
{
    public partial class FormMain : Form
    {
        protected MBSCTRLLib.MBSRecorder iRecorder;
        protected MBSCTRLLib.MBSDevConfig iDevice;
        protected MBSCTRLLib.MBSDictationList iReportList;

        MBSCTRLLib.EMBSSpeechMikeDevices deviceConnected;

        Boolean isSbInitialized = false;

        FormSSRC formSSRC;

        public FormMain()
        {
             InitializeComponent();

             iDevice = new MBSCTRLLib.MBSDevConfig();
             iRecorder = new MBSCTRLLib.MBSRecorder();
             iReportList = new MBSCTRLLib.MBSDictationList();

             formSSRC = new FormSSRC(this);

             iDevice.KeyEvent += new MBSCTRLLib._IMBSDevConfigEvents_KeyEventEventHandler(iDevice_KeyEvent);

             iRecorder.DictationStarted += new MBSCTRLLib._IMBSRecorderEvents_DictationStartedEventHandler(iRecorder_DictationStarted);
             iRecorder.DictationFinishedEx += new MBSCTRLLib._IMBSRecorderEvents_DictationFinishedExEventHandler(iRecorder_DictationFinishedEx);
             iRecorder.TextForCommand += new MBSCTRLLib._IMBSRecorderEvents_TextForCommandEventHandler(iRecorder_TextForCommand);
             iRecorder.EndTextCommand += new MBSCTRLLib._IMBSRecorderEvents_EndTextCommandEventHandler(iRecorder_EndTextCommand);

             iReportList.TransscriptionReq += new MBSCTRLLib._IMBSDictationListEvents_TransscriptionReqEventHandler(iReportList_TransscriptionReq);
             iReportList.TransscriptionStarted += new MBSCTRLLib._IMBSDictationListEvents_TransscriptionStartedEventHandler(iReportList_TransscriptionStarted);
             iReportList.TransscriptionFinished += new MBSCTRLLib._IMBSDictationListEvents_TransscriptionFinishedEventHandler(iReportList_TransscriptionFinished);
        }

        void iRecorder_EndTextCommand(string bstrKeyID)
        {
            formSSRC.AddOutputText(bstrKeyID + " -> EndTextCommand reached.");
        }

        void iRecorder_TextForCommand(string bstrKeyID, string bstrKeyText, string bstrTextData)
        {
            formSSRC.AddOutputText(bstrKeyID + " -> " + bstrKeyText + ": " + bstrTextData);
        }

        void iReportList_TransscriptionFinished(string bstrKeyID, string bstrAuthor, string bstrConText, string bstrPatient, string bstrTypist, MBSCTRLLib.EMBSEasyDictationPrio lPrio, MBSCTRLLib.EMBSBilErrorCode lError, string bstrErrorText, MBSCTRLLib.EMBSBilCloseCode lClose, string bstrStatusText, MBSCTRLLib.EMBSBilWrongStatusCode lWrongStatus, string bstrWrongStatusText)
        {
            //MessageBox.Show("Transcription Finished event fired.");
            string text = @"IMBSDictationList::TranscriptionFinished(" + bstrKeyID + @", " + bstrAuthor + @", " + bstrConText + @", " + bstrPatient + @", " + bstrTypist + @", " + lPrio.ToString() + @", " + lError.ToString() + @", " + bstrErrorText + @", " + lClose.ToString() + @", " + bstrStatusText + @", " + lWrongStatus.ToString() + @", " + bstrWrongStatusText + @")";
            AddWorkflowEventOutput(text);
        }

        void iReportList_TransscriptionStarted(string bstrKeyID, MBSCTRLLib.EMBSBilTransscriptionStartCode lStatus, string bstrStatusText)
        {
            //MessageBox.Show("Transcription Started event fired.");
            string text = @"IMBSDictationList::TranscriptionStarted(" + bstrKeyID + @", " + lStatus + @", " + bstrStatusText + @")";
            AddWorkflowEventOutput(text);
        }

        void iReportList_TransscriptionReq(string bstrKeyID, string bstrAuthor, string bstrPatient, string bstrTypist, MBSCTRLLib.EMBSBilStatusCode lStatus, string bstrStatusText)
        {
            //MessageBox.Show("Transcription Requested event fired.");
            string text = @"IMBSDictationList::TranscriptionReq(" + bstrKeyID + @", " + bstrAuthor + @", " + bstrPatient + @", " + bstrTypist + @", " + lStatus.ToString() + @", " + bstrStatusText + @")";
            AddWorkflowEventOutput(text);
        }

        void iRecorder_DictationFinishedEx(string bstrKeyID, string bstrAuthor, string bstrConText, string bstrPatient, string bstrTypist, MBSCTRLLib.EMBSEasyDictationPrio lPrio, string bstrIntegration, string bstrInfo, string bstrErrorText, MBSCTRLLib.EMBSEasyCloseCode lCloseStatus, string bstrCloseDetailed, MBSCTRLLib.EMBSEasyCompletionCode lCompletionCode, string bstrCompletionCodeText, int lDictationLength)
        {
            //MessageBox.Show("Dictation Finished event fired.");
            string text = @"IMBSRecorder::DictationFinishedEx(" + bstrKeyID + @", " + bstrAuthor + @", " + bstrConText + @", " + bstrPatient + @", " + bstrTypist + @", " + lPrio.ToString() + @", " + bstrIntegration + @", " + bstrInfo + @", " + bstrErrorText + @", " + lCloseStatus.ToString() + @", " + bstrCloseDetailed + @", " + lCompletionCode.ToString() + @", " + bstrCompletionCodeText + @", " + lDictationLength.ToString() + @")";
            AddWorkflowEventOutput(text);
        }

        void iRecorder_DictationStarted(string bstrKeyID, MBSCTRLLib.EMBSEasyDictationCode lStatus, string bstrStatusText)
        {
            //MessageBox.Show("Dictation Started event fired.");
            string text = @"IMBSRecorder::DictationStarted(" + bstrKeyID + @", " + lStatus.ToString() + @", " + bstrStatusText + @")";
            AddWorkflowEventOutput(text);
        }

        void iDevice_KeyEvent(MBSCTRLLib.EMBSSpeechMikeDevices lDeviceCode, MBSCTRLLib.EMBSSpeechMikeBtnCodes lKey)
        {
            txtKeySource.Text = lDeviceCode.ToString();
            txtKeyEvent.Text = lKey.ToString();
        }

         private void Form1_FormClosed(object sender, FormClosedEventArgs e)
         {
             if (isSbInitialized)
             {
                 iDevice.Uninitialize();
                 iRecorder.Uninitialize();
                 iReportList.Uninitialize();
             }            
         }

         private void btnStartBackend_Click(object sender, EventArgs e)
         {
             MBSCTRLLib.EMBSEasyDictationCode lStatus;
             MBSCTRLLib.EMBSEasyCloseCode lClose;
             MBSCTRLLib.EMBSEasyCompletionCode lCompletion;
             MBSCTRLLib.EMBSEasyDictationPrio lPrio = MBSCTRLLib.EMBSEasyDictationPrio.EMEDPNormal;

             String szStatus;
             String szClose;
             String szCompletion;
             String szCmdLine = @"";
             int lLength = 0;

             if (true == checkWorkflowSubmitGuest.Checked)
             {
                 szCmdLine = @"/GUEST";
             }


            try
            {

                iRecorder.StartDictationEx(
                txtReportId.Text,
                txtAuthor.Text,
                "",
                txtPatient.Text,
                "",
                szCmdLine,
                ref lPrio,
                "",
                "",
                txtDepartment.Text,
                MBSCTRLLib.EMBSEasyExec.EMEEDoRec,
                MBSCTRLLib.EMBSEasyExtendedParams.EMEExtParamsDefault,
                out lStatus, out szStatus, out lClose, out szClose, out lCompletion, out szCompletion, out lLength
                );
            }
            catch (Exception ex)
            {

                MessageBox.Show("Couldnot start the recoring becasue of the exception " + ex.StackTrace);
                    
            }



        }

         private void btnStartFrontend_Click(object sender, EventArgs e)
         {
             MBSCTRLLib.EMBSEasyDictationCode lStatus;
             MBSCTRLLib.EMBSEasyCloseCode lClose;
             MBSCTRLLib.EMBSEasyCompletionCode lCompletion;
             MBSCTRLLib.EMBSEasyDictationPrio lPrio = MBSCTRLLib.EMBSEasyDictationPrio.EMEDPNormal;

             String szStatus;
             String szClose;
             String szCompletion;
             String szCmdLine = @"";
             int lLength = 0;

             if (true == checkWorkflowSubmitGuest.Checked)
             {
                 szCmdLine = @"/GUEST";
             }

             iRecorder.StartDictationEx(
                 txtReportId.Text,
                 txtAuthor.Text,
                 "",
                 txtPatient.Text,
                 "",
                 szCmdLine,
                 ref lPrio,
                 "",
                 "",
                 txtDepartment.Text,
                 MBSCTRLLib.EMBSEasyExec.EMEEDoOnline | MBSCTRLLib.EMBSEasyExec.EMEEDoCompletionFlag,
                 MBSCTRLLib.EMBSEasyExtendedParams.EMEExtParamsDefault,
                 out lStatus, out szStatus, out lClose, out szClose, out lCompletion, out szCompletion, out lLength
                 );

         }

         private void btnStartTranscription_Click(object sender, EventArgs e)
         {
             MBSCTRLLib.EMBSBilDisableControls disableControls = 0;
             MBSCTRLLib.EMBSBilTransscriptionStartCode startCode;
             MBSCTRLLib.EMBSEasyDictationPrio prio;
             MBSCTRLLib.EMBSBilErrorCode errorCode;
             MBSCTRLLib.EMBSBilCloseCode closeCode;
             MBSCTRLLib.EMBSBilWrongStatusCode wrongStatus;

             String szStatus;
             String szError;
             String szWrongStatus;
             String szCmdLine = @"";

             if (true == checkWorkflowSubmitGuest.Checked)
             {
                 szCmdLine = @"/GUEST";
             }

             iReportList.GetDictationEx(
                 txtReportId.Text,
                 szCmdLine,
                 MBSCTRLLib.EMBSBilExec.EMBEDoUndefined,
                 disableControls,
                 out startCode, out prio, out errorCode, out szError, out closeCode, out szStatus, out wrongStatus, out szWrongStatus
                 );
         }

         private void btnGenerateReportId_Click(object sender, EventArgs e)
         {
             txtReportId.Text = GenerateId();
         }

        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            MBSCTRLLib.EMBSDictationStates status;
            String szStatus;            

            try
            {
               iReportList.GetDictationStatus(
                txtReportId.Text,
                out status,
                out szStatus
                );
                txtReportStatus.Text = szStatus;
            }

            catch (Exception ex)
            {
                var t = ex;
            
            
            }
        }

        private String GenerateId()
        {
            DateTime report = DateTime.UtcNow;
            String idReport = string.Format("{0:yyy}{0:MM}{0:dd}-{0:HH}{0:mm}{0:ss}", report);
            return idReport;
        }

        private void btnSbInitialize_Click(object sender, EventArgs e)
        {
            //This method initializes the IMBSDevConfig interface and returns information about the connected control devices.The EMBSSpeechMikeDevices enumeration provides more information on the connected device(s).

            try
            {

                iDevice.GetConfig(out deviceConnected);
                iRecorder.Initialize();
                iReportList.Initialize();
                lblConnectedDevice.Text = deviceConnected.ToString();
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {

                switch ((uint)ex.ErrorCode)
                {
                    case 0x80040A01:
                    case 0x80040A03:
                        isSbInitialized = true;
                        System.Windows.Forms.MessageBox.Show("Es wurde keine Installation von DM Workflow Edition gefunden. Entweder ist das installierte System beschädigt oder es ist kein System verfügbar");
                        //Attach COM object to iRecorder when DWME is alread running
                        var isRecorderAlreadyRunning = Process.GetProcessesByName("easy").Any(); // The class name of the Recorder (easy.exe) is: MBS-Rekorder.
                        if (isRecorderAlreadyRunning)
                        {
                            Type comType = Type.GetTypeFromCLSID(Guid.Parse("08B6F5A5-C1C3-4A0F-9427-046475181755"));
                            iRecorder = Activator.CreateInstance(comType) as MBSRecorder;

                            //iRecorder.Initialize();

                        }  
                        break;
                    case 0x80040A0:
                        System.Windows.Forms.MessageBox.Show("Es wurde keine Installation von DM Workflow Edition gefunden. Entweder ist das installierte System beschädigt oder es ist kein System verfügbar");
                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("Fehler bei der Nuance Dragon Medical Workflow Edition");
                        isSbInitialized = false;
                        throw;

                }
            }

            

            isSbInitialized = true;
        }

        private void btnSbUninitialize_Click(object sender, EventArgs e)
        {
            iDevice.Uninitialize();
            iRecorder.Uninitialize();
            iReportList.Uninitialize();

            isSbInitialized = false;
        }

        private void btnStartStructured_Click(object sender, EventArgs e)
        {
            formSSRC.ShowDialog();
        }

        public void startStructuredDictation(string xmlSSRC)
        {
            iRecorder.StartStructuredDictation(GenerateId(), txtAuthor.Text, "", "", xmlSSRC);
        }

        private void btnGetDictationText_Click(object sender, EventArgs e)
        {
            MBSCTRLLib.EMBSBilFormatCode sbFormat = MBSCTRLLib.EMBSBilFormatCode.EMBFCFormatRtf;
            string szText = @"";

            if (true == radioGetDictationTextFormatTxt.Checked)
            {
                sbFormat = MBSCTRLLib.EMBSBilFormatCode.EMBFCFormatTxt;
            }

            iReportList.GetDictationText(txtReportId.Text, sbFormat, out szText);

            if (true == radioGetDictationTextFormatTxt.Checked)
            {
                rtfGetDictationText.Text = szText;
            }
            else
            {
                rtfGetDictationText.Rtf = szText;
            }
        }

        private void AddWorkflowEventOutput(string text)
        {
            txtWorkflowEvents.Text = text + Environment.NewLine + txtWorkflowEvents.Text;
        }

        private void btnSbInitialize_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
