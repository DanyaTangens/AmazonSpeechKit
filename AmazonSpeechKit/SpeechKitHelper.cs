using Amazon;
using Amazon.Polly;
using Amazon.Polly.Model;
using Amazon.Runtime;
using System;
using System.IO;
using System.Windows.Forms;

namespace AmazonSpeechKit
{
    public class SpeechKitHelper
    {
        public void Start(RichTextBox richText, string AccessKeyID, string SecretAccessKey, VoiceId voiceId)
        {
            BasicAWSCredentials awsCredentials =
                new BasicAWSCredentials(AccessKeyID, SecretAccessKey);
            //"AccessKeyID", "SecretAccessKey"

            AmazonPollyClient amazonPollyClient =
                new AmazonPollyClient(awsCredentials, RegionEndpoint.EUCentral1);

            SynthesizeSpeechRequest synthesizeSpeechRequest = MakeSynthesizeSpeechRequest(richText.Text, voiceId);
            SynthesizeSpeechResponse synthesizeSpeechResponse =
                amazonPollyClient.SynthesizeSpeech(synthesizeSpeechRequest);

            CreateMp3File(synthesizeSpeechResponse.AudioStream);
        }

        private static SynthesizeSpeechRequest MakeSynthesizeSpeechRequest(string _text, VoiceId _voice)
        {
            SynthesizeSpeechRequest synthesizeSpeechRequest = new SynthesizeSpeechRequest();
            synthesizeSpeechRequest.Text = _text; 
            synthesizeSpeechRequest.LanguageCode = LanguageCode.RuRU;
            synthesizeSpeechRequest.OutputFormat = OutputFormat.Mp3;
            synthesizeSpeechRequest.VoiceId = _voice; 

            return synthesizeSpeechRequest;
        }

        private static void CreateMp3File(Stream audioStream)
        {
            if (Form1.SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            const string pathToMp3 = "audio\\test.mp3";
            string filename = Form1.SaveFile.FileName;
            using (FileStream fileStream = File.Create(filename))
            {
                audioStream.CopyTo(fileStream);
                fileStream.Flush();
                fileStream.Close();
            }
        }
    }
}
