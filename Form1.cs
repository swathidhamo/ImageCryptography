using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Algorithm
{
    public partial class Form1 : Form
    {

        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String line;
            FileInfo MyFile = new FileInfo(@"C:\Users\lenovo\source\repos\ImageProcessingInit\ImageProcessingInit\bin\Debug\gray.txt");
            //Instantiate a StreamReader to read from the text file.
            StreamReader sr = MyFile.OpenText();
            //Read a single character.
            string fileInput = sr.ReadToEnd();
            plaintext = ByteConverter.GetBytes("#F324DF");

            //Console.WriteLine(ByteConverter.GetString(plaintext)); 
            encryptedtext = Convert.Encryption(plaintext, RSA.ExportParameters(false), false);
            StreamWriter sw = new StreamWriter(@"C: \Users\lenovo\writefile1.txt");
            Console.WriteLine(ByteConverter.GetString(encryptedtext));

            sw.Close();
            sr.Close();

        }
        public static byte[] ConvertInt32ToByteArray(Int32 I32)

        {

            return BitConverter.GetBytes(I32);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //  StreamReader sr = new StreamReader(@"C:\Users\lenovo\writefile.txt");
            String line;
            //line = sr.ReadLine();

            byte[] decryptedtex = Convert.Decryption(encryptedtext, RSA.ExportParameters(true), false);
            Console.WriteLine(ByteConverter.GetString(decryptedtex));
            Console.WriteLine("HI thre");
            //while (line != null)
            //{
            //decy = ByteConverter.GetBytes(line);
            //decryptedtex = Convert.Decryption(decy, RSA.ExportParameters(true), false);
            //line = sr.ReadLine();
            //decy = ByteConverter.GetBytes(line); 

            //}
            //decryptedtex = Convert.Decryption(test, RSA.ExportParameters(true), false);
            //Console.WriteLine(decryptedtex); 
            //  StreamWriter sw = new StreamWriter(@"C:\Users\lenovo\images1.txt");

            //  sw.WriteLine(decryptedtex);
            //  sr.Close();

        }


    }

}
