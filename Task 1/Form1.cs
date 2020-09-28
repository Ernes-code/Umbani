using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            String key = "qwertyuioplkjhgfdsaz";
            string Message = txbTextToEncrypt.Text;
            txbEncrypt.Text = Crypto.EncryptData(Message, key);
            txbDecrypt.Text = Crypto.DecryptData(txbEncrypt.Text, key);
        }
    }
}
