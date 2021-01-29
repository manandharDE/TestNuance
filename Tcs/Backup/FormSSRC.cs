using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tcs_MbsCtrl
{
    public partial class FormSSRC : Form
    {
        private FormMain formMain;

        public FormSSRC(FormMain form)
        {
            InitializeComponent();

            formMain = form;
        }

        public void AddOutputText(string text)
        {
            txtOutput.Text += text + "\r\n";
        }

        private void btnStartSSRC_Click(object sender, EventArgs e)
        {
            string xmlSSRC = "";
            if (true == chkDeferredCorrection.Checked)
            {
                xmlSSRC = "<structuredDictation enableDeferredCorrection=\"true\">";
            }
            else
            {
                xmlSSRC = "<structuredDictation>";
            }
            xmlSSRC += "<form patientInfo=\"" + txtPatient.Text + "\">" +
                "Allgemeiner Text<field name=\"" + txtSpeechField1.Text + "\">" + txtPreText1.Text + "</field>" +
                "<field name=\"" + txtSpeechField2.Text + "\">" + txtPreText2.Text + "</field>" +
                "<field name=\"" + txtSpeechField3.Text + "\">" + txtPreText3.Text + "</field>" +
                "<field name=\"" + txtSpeechField4.Text + "\">" + txtPreText4.Text + "</field>" +
                "</form></structuredDictation>";

            formMain.startStructuredDictation(xmlSSRC);
        }
    }
}
