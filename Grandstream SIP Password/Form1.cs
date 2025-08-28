using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

//using System.Linq;
//using System.Text;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        private const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Digits = "0123456789";
        //private const string Symbols = "!@#$%^&*()-_=+[]{};:,.<>?";
        private const string SymbolsSIP = "~!@#$%^*";
        private const string SymbolsOVPN = "@!$%-_";
        //~!@#$%^*  SIP
        //@!$%-_    for openVPN

        public Form1()
        {
            InitializeComponent();
        }

        



        private void generate_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = GeneratePassword((int)passwordLength.Value);

        }

        private string GeneratePassword(int length)
        {
            if (length < 4) length = 4;

            // Ensure at least one from each category
            var chars = new List<char>();
            string all;

            chars.Add(GetRandomChar(Lowercase));
            chars.Add(GetRandomChar(Uppercase));
            chars.Add(GetRandomChar(Digits));

            //chars.Add(GetRandomChar(Symbols));
            if (SIPorOVPN.Checked == true)
            {
                //SymbolsSIP
                //SymbolsOVPN
                chars.Add(GetRandomChar(SymbolsSIP));
            }
            else
            {
                chars.Add(GetRandomChar(SymbolsOVPN));
            }



            // Fill the rest from all categories
            //string all = Lowercase + Uppercase + Digits + Symbols;

            if (SIPorOVPN.Checked == true)
            {
                //SymbolsSIP
                //SymbolsOVPN
                all = Lowercase + Uppercase + Digits + SymbolsSIP;
            }
            else
            {
                all = Lowercase + Uppercase + Digits + SymbolsOVPN;
            }




            while (chars.Count < length)
                chars.Add(GetRandomChar(all));

            // Shuffle
            Shuffle(chars);

            return new string(chars.ToArray());
        }

        // --- Random helpers ---
        private static char GetRandomChar(string allowed)
        {
            int index = GetRandomInt(allowed.Length);
            return allowed[index];
        }

        private static int GetRandomInt(int maxExclusive)
        {
            if (maxExclusive <= 0) throw new ArgumentOutOfRangeException("maxExclusive");
            byte[] buffer = new byte[4];
            using (var rng = new RNGCryptoServiceProvider())
            {
                uint value;
                do
                {
                    rng.GetBytes(buffer);
                    value = BitConverter.ToUInt32(buffer, 0);
                } while (value >= uint.MaxValue - (uint.MaxValue % (uint)maxExclusive));
                return (int)(value % (uint)maxExclusive);
            }
        }

        private static void Shuffle(IList<char> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = GetRandomInt(i + 1);
                char tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Password copied to clipboard!");
            }
            else
            {
                MessageBox.Show("No password to copy.");
            }

        }









/*
        private string GenerateSecurePassword(string pool, int length)
        {
            char[] password = new char[length];
            byte[] randomBytes = new byte[length];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            for (int i = 0; i < length; i++)
            {
                int index = randomBytes[i] % pool.Length;
                password[i] = pool[index];
            }

            return new string(password);
        }
*/





    }
}
