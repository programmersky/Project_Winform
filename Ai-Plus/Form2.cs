using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIPlus
{
    public partial class Form2 : Form
    {
        public string strdiemhocphan { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }
        public int tinchi;
        public double diemchuquydoi, a, tgtinchi;
        public string hoten, namhoc;
        public bool blki1, blkisau;

        private void linkqlcl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sv.qlcl.edu.vn");
        }

        private void lsvbangdiem_DoubleClick(object sender, EventArgs e)
        {

            {
                //Để selectedItem[0] là nó sẽ tự động nhảy khi click dòng mới
                // SubItems là các cột trên dòng
                txttenmon.Text = lsvbangdiem.SelectedItems[0].SubItems[0].Text;
                txttinchi.Text = lsvbangdiem.SelectedItems[0].SubItems[1].Text;
                txtdiemtb.Text = lsvbangdiem.SelectedItems[0].SubItems[2].Text;
                txtdiemthi.Text = lsvbangdiem.SelectedItems[0].SubItems[3].Text;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {            
            //tạo ra các cột 
            lsvbangdiem.Columns.Add("Môn Học",130);
            lsvbangdiem.Columns.Add("Tín Chỉ", 100);
            lsvbangdiem.Columns.Add("Điểm TB", 80);
            lsvbangdiem.Columns.Add("Điểm Thi", 85);
            lsvbangdiem.Columns.Add("Điểm Học Phần", 130);
            lsvbangdiem.Columns.Add("Điểm Chữ", 95);
            lsvbangdiem.Columns.Add("Xếp Loại", 150);
            lbtthongtin.Text = " Sinh Viên:      " + hoten;
            lblnam.Text = namhoc;                  
           
        }
    

        private void btntinh_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Kết quả là điểm Trung Bình Trung tích lũy/ Trung Bình Trung Học Kì");
            double kq = a / tgtinchi;
            kq = Math.Round(kq, 1);
            if (kq.ToString() == "NaN")
            {
                MessageBox.Show("Error! Không có dữ kiện ");

            }
            else {
                txtketqua.Text = "Trung Bình Chung = " + kq.ToString();
            }
            if(blki1 == true)
            {
                if(kq < 0.8)
                {
                    MessageBox.Show(" Bị cảnh cáo rồi nhé ! ");
                }
            }
            else
            {
                if (blkisau == true)
                {
                    if (kq < 1.0)
                    {
                        MessageBox.Show(" Bị cảnh cáo rồi nhé ! ");
                    }
                }
            }

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txttenmon.Text == "" || txttinchi.Text == "" || txtdiemtb.Text == "" || txtdiemthi.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin ");
            }
            else {
                double tinchi;
                double diemthi, diemtb, diemhocphan;
                string strdiemhocphan, diemchu, xeploai;
                // Khởi tạo giá trị X cho Điểm chữ và Xếp loại
                diemchu = " X";
                xeploai = " X";
                // Chuyển các giá trị về đơn vị đúng để tính toán

                diemthi = Convert.ToDouble(txtdiemthi.Text);
                diemtb = Convert.ToDouble(txtdiemtb.Text);
                if (((diemtb > 10) || (diemtb < 0)) && ((diemthi > 10) || (diemthi < 0)))
                {
                    MessageBox.Show("Điểm thi không hợp lệ. Vui lòng nhập lại :)) ");
                }
                else {
                    diemhocphan = (diemtb + diemthi * 2) / 3;
                    diemhocphan = Math.Round(diemhocphan, 1);
                    strdiemhocphan = diemhocphan.ToString();

                    // KIỂM TRA ĐIỂM  HỌC PHẦN VÀ PHÂN LOẠI ĐIỂM SỐ
                    if (diemhocphan < 4.0)
                    {
                        diemchu = "F";
                        xeploai = " Không Đạt";
                        diemchuquydoi = 0;
                    }
                    else
                    {
                        if (diemhocphan >= 4.0 && diemhocphan <= 4.6)
                        {
                            diemchu = "D";
                            xeploai = " Trung Bình Yếu";
                            diemchuquydoi = 1;
                        }
                        else
                        {
                            if (diemhocphan >= 4.7 && diemhocphan <= 5.4)
                            {
                                diemchu = "D+";
                                xeploai = " Trung Bình Yếu";
                                diemchuquydoi = 1.5;

                            }
                            else
                            {
                                if (diemhocphan >= 5.5 && diemhocphan <= 6.1)
                                {
                                    diemchu = "C";
                                    xeploai = " Trung Bình";
                                    diemchuquydoi = 2;
                                }
                                else
                                {
                                    if (diemhocphan >= 6.2 && diemhocphan <= 6.9)
                                    {
                                        diemchu = "C+";
                                        xeploai = " Trung Bình";
                                        diemchuquydoi = 2.5;
                                    }
                                    else
                                    {
                                        if (diemhocphan >= 7.0 && diemhocphan <= 7.6)
                                        {
                                            diemchu = "B";
                                            xeploai = " Khá";
                                            diemchuquydoi = 3;
                                        }
                                        else
                                        {
                                            if (diemhocphan >= 7.7 && diemhocphan <= 8.4)
                                            {
                                                diemchu = "B+";
                                                xeploai = " Khá";
                                                diemchuquydoi = 3.5;
                                            }
                                            else
                                            {
                                                if (diemhocphan >= 8.5 && diemhocphan <= 10)
                                                {
                                                    diemchu = "A";
                                                    xeploai = " Giỏi";
                                                    diemchuquydoi = 4;
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                    // Xử lý số tín chỉ và tổng tín chỉ
                    // Tính A : Trung bình trung tích lũy
                    tinchi = Convert.ToDouble(txttinchi.Text);
                    a = a + diemchuquydoi * tinchi;
                    tgtinchi = tgtinchi + tinchi;
                    // Khởi tạo lvs
                    string[] arr = new string[7];
                    ListViewItem item;//add item vào mảng
                                      // Đổ dữ liệu vào mảng
                    arr[0] = txttenmon.Text;
                    arr[1] = txttinchi.Text;
                    arr[2] = txtdiemtb.Text;
                    arr[3] = txtdiemthi.Text;
                    arr[4] = strdiemhocphan;
                    arr[5] = diemchu.ToString();
                    arr[6] = xeploai.ToString();
                    // đổ mảng vào item
                    item = new ListViewItem(arr);
                    lsvbangdiem.Items.Add(item);// Đổ từ mảng vào item
                                                // Trả lại giá trị cho textbox
                    txttenmon.Text = "";
                    txtdiemthi.Text = "";
                    txttinchi.Text = "";
                    txtdiemtb.Text = "";
                }
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Thank U For Using It !", "Từ từ đã", MessageBoxButtons.OK, MessageBoxIcon.None) == DialogResult.Yes)
            {
                // đóng form
            }
            else
            {
                //xử lí khác
            }
        }
    }
    
}
