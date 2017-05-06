using Cryptography.AES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cryptography.WebClient
{
    public partial class AESClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                sbyte[] encr = AESImplementation.encrypt(this.txtPlainText.Text.GetBytes(), this.txtPrivateKey.Text.GetBytes());
                this.txtEncryptText.Text = string.Join(" ", encr);

                sbyte[] decr = AESImplementation.decrypt(encr, this.txtPrivateKey.Text.GetBytes());
                this.txtDecryptText.Text = string.Join(" ", StringHelperClass.NewString(decr));

                this.txtAesLog.Text = string.Join("\n", FileHelper.FileContent);
                FileHelper.FileContent.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}