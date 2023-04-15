using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace criptografia
{
    public partial class Form1 : Form
    {
        //A chave de Criptografia é Rijndael/AES
        public Form1()
        {
            InitializeComponent();
        }

        //Vetor de byte utilizados para a criptografia (Chave Externa)
        private static byte[] biv = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC};

        public static string Encrypt(string text, string cryptoKey)
        {
            if (!string.IsNullOrEmpty(text))
            {
                //Cria instancias de vetores de bytes com as chaves
                byte[] bkey = Convert.FromBase64String(cryptoKey);
                byte[] btext = new UTF8Encoding().GetBytes(text);

                //Instancia a classe de criptografia Rijndael
                Rijndael rijndael = new RijndaelManaged();

                //Define o tamanho da chave "8 * 32 = 256"
                //128(16 caracteres)
                rijndael.KeySize = 256;

                //Cria o espaço de memória para guardar o valor criptografado
                MemoryStream mStream = new MemoryStream();
                //Instancia o encriptador 
                CryptoStream encryptor = new CryptoStream(mStream, rijndael.CreateEncryptor(bkey, biv), CryptoStreamMode.Write);

                //Faz a escrita dos dados criptografados no espaço da memória 
                encryptor.Write(btext, 0, btext.Length);
                //Despeja toda a memória
                encryptor.FlushFinalBlock();

                return Convert.ToBase64String(mStream.ToArray());
            }
            else
            {
                return null;
            }
        }

        public static string Decrypt(string text, string cryptoKey)
        {
            if (!string.IsNullOrEmpty(text))
            {
                byte[] bkey = Convert.FromBase64String(cryptoKey);
                byte[] btext = Convert.FromBase64String(text);
                Rijndael rijndael = new RijndaelManaged();
                rijndael.KeySize = 256;
                MemoryStream mStream = new MemoryStream();
                CryptoStream decryptor = new CryptoStream(mStream, rijndael.CreateDecryptor(bkey, biv), CryptoStreamMode.Write); 
                decryptor.Write(btext, 0, btext.Length);
                decryptor.FlushFinalBlock();

                UTF8Encoding utf8 = new UTF8Encoding();

                return utf8.GetString(mStream.ToArray());
            }
            else
            {
                return null;
            }
        }

        private void btn_criptografar_Click(object sender, EventArgs e)
        {
            string input = txt_Input.Text;
            string token = txt_Key.Text;
            string output;
            output = Encrypt(input, token);
            txt_Output.Text = output;
        }

        private void btn_descriptografar_Click(object sender, EventArgs e)
        {
            string input = txt_Input.Text;
            string token = txt_Key.Text;
            string output;
            output = Decrypt(input, token);
            txt_Output.Text = output;
        }
    }
}
