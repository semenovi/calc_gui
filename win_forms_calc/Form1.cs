using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_forms_calc
{
    public partial class calc_form : Form
    {
        Int64 a_operand = 0;
        Int64 b_operand = 0;
        string ab_operator = "";
        Int64 result = 0;
        Int64 mem = 0;
        Boolean alt_switch = false;
        Int64 screen_dec = 0;
        Int64 current_system = 1;

        public void update_switches()
        {
            hex_text.Text = Convert.ToString(screen_dec, 16);
            dec_text.Text = screen_dec.ToString();
            oct_text.Text = Convert.ToString(screen_dec, 8);
            bin_text.Text = Convert.ToString(screen_dec, 2);
        }

        public calc_form()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 1;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 2;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 3;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 4;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 5;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 6;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 7;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 8;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 9;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            screen_dec = screen_dec * 10 + 0;
            screen.Text = screen_dec.ToString();
            update_switches();
        }

        private void plus_Click(object sender, EventArgs e)
        {

        }
    }
}
