namespace M318_Vebus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class EMail : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EMail"/> class.
        /// </summary>
        public EMail()
        {
            this.InitializeComponent();
        }

        private void ButtonAbschicken_Click(object sender, EventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.Vorname = this.TextVorname.Text;
            emailMessage.Nachname = this.TextNachname.Text;
            emailMessage.Email = this.TextEMail.Text;
        }

        private void EMail_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
