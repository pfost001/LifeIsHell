using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeIsHell
{
    
    public partial class InsertName : Form
    {
        public frmStartGame newPlayerName;
        public InsertName(frmStartGame callerForm)
        {
            InitializeComponent();
            newPlayerName = callerForm;
                      
        }

        private void btnInsertName_Click(object sender, EventArgs e)
        {
            lblNameError.Visible = false;

            if (!string.IsNullOrEmpty(txtInsertName.Text.Trim()))
            {
                frmStartGame.currentPlayer.PlayerName = txtInsertName.Text.Trim();

                //Player2 palyer2 = new Player2(txtInsertName.Text.Trim());

                this.Close();
            }
            else
            {
                lblNameError.Visible = true;
            }
                
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
