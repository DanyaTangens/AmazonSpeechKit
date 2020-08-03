using Amazon.Polly;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace AmazonSpeechKit
{
    public partial class Form1 : Form
    {
        private VoiceId _voiceId = VoiceId.Maxim;
        private SpeechKitHelper _speechKitHelper = new SpeechKitHelper();

        public static SaveFileDialog SaveFile;

        public Form1()
        {
            InitializeComponent();
            SaveFile = saveFile;           
        }

        private void maleVoice_CheckedChanged(object sender, EventArgs e)
        {
            _voiceId = VoiceId.Maxim;
        }

        private void femaleVoice_CheckedChanged(object sender, EventArgs e)
        {
            _voiceId = VoiceId.Tatyana;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"AmazonKey.json"))
            {
                dynamic json = JObject.Parse(File.ReadAllText(@"AmazonKey.json"));
                string _accessKeyID = json.AccessKeyID;
                string _secretAccessKey = json.SecretAccessKey;
                _speechKitHelper.Start(richText, _accessKeyID, _secretAccessKey, _voiceId);
            }
            else
            {
                MessageBox.Show("File not exists");
            }
        }
    }
}
