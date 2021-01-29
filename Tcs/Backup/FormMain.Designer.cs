namespace Tcs_MbsCtrl
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblConnectedDevice = new System.Windows.Forms.Label();
            this.lblKeySource = new System.Windows.Forms.Label();
            this.txtKeySource = new System.Windows.Forms.TextBox();
            this.txtKeyEvent = new System.Windows.Forms.TextBox();
            this.lblKeyEvent = new System.Windows.Forms.Label();
            this.btnStartBackend = new System.Windows.Forms.Button();
            this.btnStartFrontend = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblReportId = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtReportId = new System.Windows.Forms.TextBox();
            this.btnGenerateReportId = new System.Windows.Forms.Button();
            this.btnSbInitialize = new System.Windows.Forms.Button();
            this.btnSbUninitialize = new System.Windows.Forms.Button();
            this.btnStartTranscription = new System.Windows.Forms.Button();
            this.lblReportStatus = new System.Windows.Forms.Label();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.txtReportStatus = new System.Windows.Forms.TextBox();
            this.btnStartStructured = new System.Windows.Forms.Button();
            this.tabFormMain = new System.Windows.Forms.TabControl();
            this.tabPageWorkflow = new System.Windows.Forms.TabPage();
            this.checkWorkflowSubmitGuest = new System.Windows.Forms.CheckBox();
            this.grpWorkflowEvents = new System.Windows.Forms.GroupBox();
            this.txtWorkflowEvents = new System.Windows.Forms.TextBox();
            this.tabPageDataRetrieval = new System.Windows.Forms.TabPage();
            this.rtfGetDictationText = new System.Windows.Forms.RichTextBox();
            this.grpGetDictationTextFormat = new System.Windows.Forms.GroupBox();
            this.radioGetDictationTextFormatTxt = new System.Windows.Forms.RadioButton();
            this.radioGetDictationTextFormatRtf = new System.Windows.Forms.RadioButton();
            this.btnGetDictationText = new System.Windows.Forms.Button();
            this.grpMainData = new System.Windows.Forms.GroupBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.tabFormMain.SuspendLayout();
            this.tabPageWorkflow.SuspendLayout();
            this.grpWorkflowEvents.SuspendLayout();
            this.tabPageDataRetrieval.SuspendLayout();
            this.grpGetDictationTextFormat.SuspendLayout();
            this.grpMainData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnectedDevice
            // 
            this.lblConnectedDevice.AutoSize = true;
            this.lblConnectedDevice.Location = new System.Drawing.Point(168, 16);
            this.lblConnectedDevice.Name = "lblConnectedDevice";
            this.lblConnectedDevice.Size = new System.Drawing.Size(96, 13);
            this.lblConnectedDevice.TabIndex = 0;
            this.lblConnectedDevice.Text = "Connected Device";
            // 
            // lblKeySource
            // 
            this.lblKeySource.AutoSize = true;
            this.lblKeySource.Location = new System.Drawing.Point(13, 47);
            this.lblKeySource.Name = "lblKeySource";
            this.lblKeySource.Size = new System.Drawing.Size(62, 13);
            this.lblKeySource.TabIndex = 1;
            this.lblKeySource.Text = "KeySource:";
            // 
            // txtKeySource
            // 
            this.txtKeySource.Location = new System.Drawing.Point(102, 40);
            this.txtKeySource.Name = "txtKeySource";
            this.txtKeySource.Size = new System.Drawing.Size(365, 20);
            this.txtKeySource.TabIndex = 2;
            // 
            // txtKeyEvent
            // 
            this.txtKeyEvent.Location = new System.Drawing.Point(102, 68);
            this.txtKeyEvent.Name = "txtKeyEvent";
            this.txtKeyEvent.Size = new System.Drawing.Size(365, 20);
            this.txtKeyEvent.TabIndex = 4;
            // 
            // lblKeyEvent
            // 
            this.lblKeyEvent.AutoSize = true;
            this.lblKeyEvent.Location = new System.Drawing.Point(13, 75);
            this.lblKeyEvent.Name = "lblKeyEvent";
            this.lblKeyEvent.Size = new System.Drawing.Size(56, 13);
            this.lblKeyEvent.TabIndex = 3;
            this.lblKeyEvent.Text = "KeyEvent:";
            // 
            // btnStartBackend
            // 
            this.btnStartBackend.Location = new System.Drawing.Point(12, 9);
            this.btnStartBackend.Name = "btnStartBackend";
            this.btnStartBackend.Size = new System.Drawing.Size(106, 36);
            this.btnStartBackend.TabIndex = 5;
            this.btnStartBackend.Text = "Start Report Recording";
            this.btnStartBackend.UseVisualStyleBackColor = true;
            this.btnStartBackend.Click += new System.EventHandler(this.btnStartBackend_Click);
            // 
            // btnStartFrontend
            // 
            this.btnStartFrontend.Location = new System.Drawing.Point(131, 9);
            this.btnStartFrontend.Name = "btnStartFrontend";
            this.btnStartFrontend.Size = new System.Drawing.Size(106, 36);
            this.btnStartFrontend.TabIndex = 6;
            this.btnStartFrontend.Text = "Start Frontend Recognition";
            this.btnStartFrontend.UseVisualStyleBackColor = true;
            this.btnStartFrontend.Click += new System.EventHandler(this.btnStartFrontend_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(13, 99);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "Author:";
            // 
            // lblReportId
            // 
            this.lblReportId.AutoSize = true;
            this.lblReportId.Location = new System.Drawing.Point(13, 126);
            this.lblReportId.Name = "lblReportId";
            this.lblReportId.Size = new System.Drawing.Size(56, 13);
            this.lblReportId.TabIndex = 8;
            this.lblReportId.Text = "Report ID:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(102, 96);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(365, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtReportId
            // 
            this.txtReportId.Location = new System.Drawing.Point(102, 123);
            this.txtReportId.Name = "txtReportId";
            this.txtReportId.Size = new System.Drawing.Size(293, 20);
            this.txtReportId.TabIndex = 10;
            // 
            // btnGenerateReportId
            // 
            this.btnGenerateReportId.Location = new System.Drawing.Point(401, 122);
            this.btnGenerateReportId.Name = "btnGenerateReportId";
            this.btnGenerateReportId.Size = new System.Drawing.Size(66, 20);
            this.btnGenerateReportId.TabIndex = 11;
            this.btnGenerateReportId.Text = "Generate";
            this.btnGenerateReportId.UseVisualStyleBackColor = true;
            this.btnGenerateReportId.Click += new System.EventHandler(this.btnGenerateReportId_Click);
            // 
            // btnSbInitialize
            // 
            this.btnSbInitialize.Location = new System.Drawing.Point(90, 12);
            this.btnSbInitialize.Name = "btnSbInitialize";
            this.btnSbInitialize.Size = new System.Drawing.Size(136, 25);
            this.btnSbInitialize.TabIndex = 12;
            this.btnSbInitialize.Text = "Initialize SB Interfaces";
            this.btnSbInitialize.UseVisualStyleBackColor = true;
            this.btnSbInitialize.Click += new System.EventHandler(this.btnSbInitialize_Click);
            // 
            // btnSbUninitialize
            // 
            this.btnSbUninitialize.Location = new System.Drawing.Point(248, 12);
            this.btnSbUninitialize.Name = "btnSbUninitialize";
            this.btnSbUninitialize.Size = new System.Drawing.Size(136, 25);
            this.btnSbUninitialize.TabIndex = 13;
            this.btnSbUninitialize.Text = "Uninitialize SB Interfaces";
            this.btnSbUninitialize.UseVisualStyleBackColor = true;
            this.btnSbUninitialize.Click += new System.EventHandler(this.btnSbUninitialize_Click);
            // 
            // btnStartTranscription
            // 
            this.btnStartTranscription.Location = new System.Drawing.Point(359, 9);
            this.btnStartTranscription.Name = "btnStartTranscription";
            this.btnStartTranscription.Size = new System.Drawing.Size(106, 36);
            this.btnStartTranscription.TabIndex = 14;
            this.btnStartTranscription.Text = "Start Transcription/ Correction";
            this.btnStartTranscription.UseVisualStyleBackColor = true;
            this.btnStartTranscription.Click += new System.EventHandler(this.btnStartTranscription_Click);
            // 
            // lblReportStatus
            // 
            this.lblReportStatus.AutoSize = true;
            this.lblReportStatus.Location = new System.Drawing.Point(13, 207);
            this.lblReportStatus.Name = "lblReportStatus";
            this.lblReportStatus.Size = new System.Drawing.Size(75, 13);
            this.lblReportStatus.TabIndex = 15;
            this.lblReportStatus.Text = "Report Status:";
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(401, 203);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(66, 20);
            this.btnGetStatus.TabIndex = 17;
            this.btnGetStatus.Text = "Get Status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // txtReportStatus
            // 
            this.txtReportStatus.Location = new System.Drawing.Point(102, 204);
            this.txtReportStatus.Name = "txtReportStatus";
            this.txtReportStatus.ReadOnly = true;
            this.txtReportStatus.Size = new System.Drawing.Size(293, 20);
            this.txtReportStatus.TabIndex = 16;
            // 
            // btnStartStructured
            // 
            this.btnStartStructured.Location = new System.Drawing.Point(245, 9);
            this.btnStartStructured.Name = "btnStartStructured";
            this.btnStartStructured.Size = new System.Drawing.Size(106, 36);
            this.btnStartStructured.TabIndex = 18;
            this.btnStartStructured.Text = "Start Structured Dictation";
            this.btnStartStructured.UseVisualStyleBackColor = true;
            this.btnStartStructured.Click += new System.EventHandler(this.btnStartStructured_Click);
            // 
            // tabFormMain
            // 
            this.tabFormMain.Controls.Add(this.tabPageWorkflow);
            this.tabFormMain.Controls.Add(this.tabPageDataRetrieval);
            this.tabFormMain.Location = new System.Drawing.Point(16, 288);
            this.tabFormMain.Name = "tabFormMain";
            this.tabFormMain.SelectedIndex = 0;
            this.tabFormMain.Size = new System.Drawing.Size(483, 251);
            this.tabFormMain.TabIndex = 19;
            // 
            // tabPageWorkflow
            // 
            this.tabPageWorkflow.Controls.Add(this.checkWorkflowSubmitGuest);
            this.tabPageWorkflow.Controls.Add(this.grpWorkflowEvents);
            this.tabPageWorkflow.Controls.Add(this.btnStartBackend);
            this.tabPageWorkflow.Controls.Add(this.btnStartStructured);
            this.tabPageWorkflow.Controls.Add(this.btnStartFrontend);
            this.tabPageWorkflow.Controls.Add(this.btnStartTranscription);
            this.tabPageWorkflow.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkflow.Name = "tabPageWorkflow";
            this.tabPageWorkflow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkflow.Size = new System.Drawing.Size(475, 225);
            this.tabPageWorkflow.TabIndex = 0;
            this.tabPageWorkflow.Text = "Workflow";
            this.tabPageWorkflow.UseVisualStyleBackColor = true;
            // 
            // checkWorkflowSubmitGuest
            // 
            this.checkWorkflowSubmitGuest.AutoSize = true;
            this.checkWorkflowSubmitGuest.Checked = true;
            this.checkWorkflowSubmitGuest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWorkflowSubmitGuest.Location = new System.Drawing.Point(18, 51);
            this.checkWorkflowSubmitGuest.Name = "checkWorkflowSubmitGuest";
            this.checkWorkflowSubmitGuest.Size = new System.Drawing.Size(279, 17);
            this.checkWorkflowSubmitGuest.TabIndex = 20;
            this.checkWorkflowSubmitGuest.Text = "Submit \"/GUEST\" parameter for all workflow methods";
            this.checkWorkflowSubmitGuest.UseVisualStyleBackColor = true;
            // 
            // grpWorkflowEvents
            // 
            this.grpWorkflowEvents.Controls.Add(this.txtWorkflowEvents);
            this.grpWorkflowEvents.Location = new System.Drawing.Point(12, 78);
            this.grpWorkflowEvents.Name = "grpWorkflowEvents";
            this.grpWorkflowEvents.Size = new System.Drawing.Size(450, 134);
            this.grpWorkflowEvents.TabIndex = 19;
            this.grpWorkflowEvents.TabStop = false;
            this.grpWorkflowEvents.Text = "Workflow Events";
            // 
            // txtWorkflowEvents
            // 
            this.txtWorkflowEvents.AcceptsReturn = true;
            this.txtWorkflowEvents.Location = new System.Drawing.Point(14, 19);
            this.txtWorkflowEvents.Multiline = true;
            this.txtWorkflowEvents.Name = "txtWorkflowEvents";
            this.txtWorkflowEvents.ReadOnly = true;
            this.txtWorkflowEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWorkflowEvents.Size = new System.Drawing.Size(425, 98);
            this.txtWorkflowEvents.TabIndex = 0;
            // 
            // tabPageDataRetrieval
            // 
            this.tabPageDataRetrieval.Controls.Add(this.rtfGetDictationText);
            this.tabPageDataRetrieval.Controls.Add(this.grpGetDictationTextFormat);
            this.tabPageDataRetrieval.Controls.Add(this.btnGetDictationText);
            this.tabPageDataRetrieval.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataRetrieval.Name = "tabPageDataRetrieval";
            this.tabPageDataRetrieval.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataRetrieval.Size = new System.Drawing.Size(475, 225);
            this.tabPageDataRetrieval.TabIndex = 1;
            this.tabPageDataRetrieval.Text = "Data Retrieval";
            this.tabPageDataRetrieval.UseVisualStyleBackColor = true;
            // 
            // rtfGetDictationText
            // 
            this.rtfGetDictationText.Location = new System.Drawing.Point(12, 65);
            this.rtfGetDictationText.Name = "rtfGetDictationText";
            this.rtfGetDictationText.Size = new System.Drawing.Size(451, 141);
            this.rtfGetDictationText.TabIndex = 8;
            this.rtfGetDictationText.Text = "";
            // 
            // grpGetDictationTextFormat
            // 
            this.grpGetDictationTextFormat.Controls.Add(this.radioGetDictationTextFormatTxt);
            this.grpGetDictationTextFormat.Controls.Add(this.radioGetDictationTextFormatRtf);
            this.grpGetDictationTextFormat.Location = new System.Drawing.Point(153, 11);
            this.grpGetDictationTextFormat.Name = "grpGetDictationTextFormat";
            this.grpGetDictationTextFormat.Size = new System.Drawing.Size(238, 48);
            this.grpGetDictationTextFormat.TabIndex = 7;
            this.grpGetDictationTextFormat.TabStop = false;
            this.grpGetDictationTextFormat.Text = "Text Format";
            // 
            // radioGetDictationTextFormatTxt
            // 
            this.radioGetDictationTextFormatTxt.AutoSize = true;
            this.radioGetDictationTextFormatTxt.Location = new System.Drawing.Point(142, 19);
            this.radioGetDictationTextFormatTxt.Name = "radioGetDictationTextFormatTxt";
            this.radioGetDictationTextFormatTxt.Size = new System.Drawing.Size(69, 17);
            this.radioGetDictationTextFormatTxt.TabIndex = 1;
            this.radioGetDictationTextFormatTxt.Text = "Ansi Text";
            this.radioGetDictationTextFormatTxt.UseVisualStyleBackColor = true;
            // 
            // radioGetDictationTextFormatRtf
            // 
            this.radioGetDictationTextFormatRtf.AutoSize = true;
            this.radioGetDictationTextFormatRtf.Checked = true;
            this.radioGetDictationTextFormatRtf.Location = new System.Drawing.Point(17, 19);
            this.radioGetDictationTextFormatRtf.Name = "radioGetDictationTextFormatRtf";
            this.radioGetDictationTextFormatRtf.Size = new System.Drawing.Size(100, 17);
            this.radioGetDictationTextFormatRtf.TabIndex = 0;
            this.radioGetDictationTextFormatRtf.TabStop = true;
            this.radioGetDictationTextFormatRtf.Text = "RichTextFormat";
            this.radioGetDictationTextFormatRtf.UseVisualStyleBackColor = true;
            // 
            // btnGetDictationText
            // 
            this.btnGetDictationText.Location = new System.Drawing.Point(12, 23);
            this.btnGetDictationText.Name = "btnGetDictationText";
            this.btnGetDictationText.Size = new System.Drawing.Size(106, 36);
            this.btnGetDictationText.TabIndex = 6;
            this.btnGetDictationText.Text = "Retrieve Dictation Text";
            this.btnGetDictationText.UseVisualStyleBackColor = true;
            this.btnGetDictationText.Click += new System.EventHandler(this.btnGetDictationText_Click);
            // 
            // grpMainData
            // 
            this.grpMainData.Controls.Add(this.lblDepartment);
            this.grpMainData.Controls.Add(this.txtDepartment);
            this.grpMainData.Controls.Add(this.lblPatient);
            this.grpMainData.Controls.Add(this.txtPatient);
            this.grpMainData.Controls.Add(this.lblConnectedDevice);
            this.grpMainData.Controls.Add(this.lblKeySource);
            this.grpMainData.Controls.Add(this.btnGetStatus);
            this.grpMainData.Controls.Add(this.txtKeySource);
            this.grpMainData.Controls.Add(this.txtReportStatus);
            this.grpMainData.Controls.Add(this.lblKeyEvent);
            this.grpMainData.Controls.Add(this.lblReportStatus);
            this.grpMainData.Controls.Add(this.txtKeyEvent);
            this.grpMainData.Controls.Add(this.lblAuthor);
            this.grpMainData.Controls.Add(this.lblReportId);
            this.grpMainData.Controls.Add(this.btnGenerateReportId);
            this.grpMainData.Controls.Add(this.txtAuthor);
            this.grpMainData.Controls.Add(this.txtReportId);
            this.grpMainData.Location = new System.Drawing.Point(16, 43);
            this.grpMainData.Name = "grpMainData";
            this.grpMainData.Size = new System.Drawing.Size(483, 239);
            this.grpMainData.TabIndex = 20;
            this.grpMainData.TabStop = false;
            this.grpMainData.Text = "Main Data";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(12, 154);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(43, 13);
            this.lblPatient.TabIndex = 18;
            this.lblPatient.Text = "Patient:";
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(101, 151);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(365, 20);
            this.txtPatient.TabIndex = 19;
            this.txtPatient.Text = "COM SDK demo";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(12, 180);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 20;
            this.lblDepartment.Text = "Department:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(101, 177);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(365, 20);
            this.txtDepartment.TabIndex = 21;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 559);
            this.Controls.Add(this.grpMainData);
            this.Controls.Add(this.tabFormMain);
            this.Controls.Add(this.btnSbUninitialize);
            this.Controls.Add(this.btnSbInitialize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Tcs_MbsCtrl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabFormMain.ResumeLayout(false);
            this.tabPageWorkflow.ResumeLayout(false);
            this.tabPageWorkflow.PerformLayout();
            this.grpWorkflowEvents.ResumeLayout(false);
            this.grpWorkflowEvents.PerformLayout();
            this.tabPageDataRetrieval.ResumeLayout(false);
            this.grpGetDictationTextFormat.ResumeLayout(false);
            this.grpGetDictationTextFormat.PerformLayout();
            this.grpMainData.ResumeLayout(false);
            this.grpMainData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConnectedDevice;
        private System.Windows.Forms.Label lblKeySource;
        private System.Windows.Forms.TextBox txtKeySource;
        private System.Windows.Forms.TextBox txtKeyEvent;
        private System.Windows.Forms.Label lblKeyEvent;
        private System.Windows.Forms.Button btnStartBackend;
        private System.Windows.Forms.Button btnStartFrontend;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblReportId;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtReportId;
        private System.Windows.Forms.Button btnGenerateReportId;
        private System.Windows.Forms.Button btnSbInitialize;
        private System.Windows.Forms.Button btnSbUninitialize;
        private System.Windows.Forms.Button btnStartTranscription;
        private System.Windows.Forms.Label lblReportStatus;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.TextBox txtReportStatus;
        private System.Windows.Forms.Button btnStartStructured;
        private System.Windows.Forms.TabControl tabFormMain;
        private System.Windows.Forms.TabPage tabPageWorkflow;
        private System.Windows.Forms.TabPage tabPageDataRetrieval;
        private System.Windows.Forms.GroupBox grpMainData;
        private System.Windows.Forms.GroupBox grpGetDictationTextFormat;
        private System.Windows.Forms.Button btnGetDictationText;
        private System.Windows.Forms.RadioButton radioGetDictationTextFormatTxt;
        private System.Windows.Forms.RadioButton radioGetDictationTextFormatRtf;
        private System.Windows.Forms.RichTextBox rtfGetDictationText;
        private System.Windows.Forms.GroupBox grpWorkflowEvents;
        private System.Windows.Forms.TextBox txtWorkflowEvents;
        private System.Windows.Forms.CheckBox checkWorkflowSubmitGuest;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
    }
}

