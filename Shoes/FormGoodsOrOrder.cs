using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shoes
{


    public partial class FormGoodsOrOrder : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormGoodsOrOrder()
        {
            User user = new User();
            bool guest = false;
            InitializeComponent();

            if (user != null)
            {
                CurrentUser = user;
                IsGuest = false;
            }
            else
            {
                CurrentUser = null;
                IsGuest = true;
            }
            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;
        }



        private void btnOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
