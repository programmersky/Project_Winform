using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Phát_Wifi_Hẹn_giờ_tắt_máy
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            string commandText = @"/k netsh wlan show hostednetwork";
            System.Diagnostics.Process.Start("CMD.exe", commandText);                      
        }

        private void btndung_Click(object sender, EventArgs e)
        {
            string commandText = @"/c netsh wlan stop hostednetwork";
            System.Diagnostics.Process.Start("CMD.exe", commandText);         
        }
        private void btnphat_Click(object sender, EventArgs e)
        {
            string ten = txtname.Text;
            string pass = txtpass.Text;
            int sl = pass.Length;                         
                if (ten == "" || pass == "")
                {
                    MessageBox.Show("Error Name/Pass","Error");
                    if((ten == "" || ten == " "))
                    {
                        txtname.Focus();
                    }else                    
                    {
                        txtpass.Focus();
                    }
            }
            else { 
                if(sl < 8)
                {
                    MessageBox.Show(" Pass more than 8 characters", "Error");
                    txtpass.Focus();
                }
                else {          
            // khởi tạo 
            string commandText = @"/c netsh wlan set hostednetwork mode = allow ssid =" +ten+" key ="+pass;
            
            System.Diagnostics.Process.Start("CMD.exe", commandText);
            // Phát
            string command = @"/c netsh wlan start hostednetwork";
            System.Diagnostics.Process.Start("CMD.exe", command);
            btnkiemtra.Show();
            btndung.Show();
        }
        }
        }
        private void Form1_Load(object sender, EventArgs e)
        {         
            btnkiemtra.Hide();
            btndung.Hide();                                 
        }

        private void btntrogiup_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            MessageBox.Show(" Làm theo các hướng dẫn sau nếu chưa phát được Wifi","Hướng Dẫn cài đặt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            fr2.Show();
        }
    }
}
