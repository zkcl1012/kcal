using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health
{
    public partial class Form1 : Form
    {
        public int m; //성인남자 평균 칼로리
        public int g; //성인여자 평균 칼로리
        public int a0 =0; //팔굽혀펴기 칼로리
        public int a1=0; //윗몸일으키기 칼로리
        public int a2=0; //턱걸이 칼로리
        public int a3=0; //달리기 칼로리
        public int a4=0; //스쿼트 칼로리

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check_man.Checked == true)
            {
                m = 2500;
            }
            if(check_girl.Checked == true)
            {
                g = 1900;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            all_kcal.Text = ((a0 + a1 + a2 + a3 + a4).ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count == 0)
            {
                a0 = 640;
            }
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                a1 = 588;
            }
            if(checkedListBox1.CheckedItems.Count == 2)
            {
                a2 = 560;
            }
            if (checkedListBox1.CheckedItems.Count == 3)
            {
                a3 = 590;
            }
            if (checkedListBox1.CheckedItems.Count == 4)
            {
                a4 = 588;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text; //하루 먹은 칼로리 입력받기
            if (check_man.Checked == true)
            {
                subtract_kcal.Text = "= " + (Convert.ToInt32(s)-m).ToString();
            }
            if(check_girl.Checked == true)
            {
                subtract_kcal.Text = "= " + (Convert.ToInt32(s)-g).ToString();
            }
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void health_information_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
