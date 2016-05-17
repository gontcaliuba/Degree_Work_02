using CUETools.Codecs;
using CUETools.Codecs.FLAKE;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DegreeWork_01
{
    class SpeechRecognizer
    {
        public static string GoogleRequest(byte[] bytes, int sampleRate)
        {
            Stream stream = null;
            StreamReader sr = null;
            WebResponse response = null;
            string respFromServer;
            try
            {
                WebRequest request = WebRequest.Create("https://www.google.com/speech-api/v2/recognize?output=json&lang=ru-Ru&key=AIzaSyAIjj3M97AvHlt7N14wU-zczLkltX68QyQ");
                request.Method = "POST";
                request.ContentType = "audio/x-flac; rate=16000";
                request.ContentLength = bytes.Length;

                stream = request.GetRequestStream();

                stream.Write(bytes, 0, bytes.Length);
                stream.Close();

                response = request.GetResponse();

                stream = response.GetResponseStream();
                if (stream == null)
                {
                    throw new Exception("Can't get a response from server. Response stream is null.");
                }
                sr = new StreamReader(stream);

                //Get response in JSON format
                //string respFromServer = sr.ReadToEnd();
                respFromServer = sr.ReadToEnd();
            }
            finally
            {
                if (stream != null)
                    stream.Close();

                if (sr != null)
                    sr.Close();

                if (response != null)
                    response.Close();
            }

            //return result == null ? "" : result.utterance;
            return respFromServer;
        }

        public static string GoogleRequest(MemoryStream flacStream, int sampleRate)
        {
            flacStream.Position = 0;
            var bytes = new byte[flacStream.Length];
            flacStream.Read(bytes, 0, (int)flacStream.Length);
            return GoogleRequest(bytes, sampleRate);
        }

        public static string WavStreamToGoogle(Stream stream)
        {
            FlakeWriter audioDest = null;
            IAudioSource audioSource = null;
            string answer;
            try
            {
                var outStream = new MemoryStream();

                stream.Position = 0;

                audioSource = new WAVReader("", stream);

                var buff = new AudioBuffer(audioSource, 0x10000);

                audioDest = new FlakeWriter("", outStream, audioSource.PCM);

                var sampleRate = audioSource.PCM.SampleRate;

                while (audioSource.Read(buff, -1) != 0)
                {
                    audioDest.Write(buff);
                }

                answer = GoogleRequest(outStream, sampleRate);

            }
            finally
            {
                if (audioDest != null) audioDest.Close();
                if (audioSource != null) audioSource.Close();
            }
            return answer;
        }
    }
}
