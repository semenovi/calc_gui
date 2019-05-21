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
        string screen_text = "";
        Int32 current_number = 0;
        Boolean input_type = false;
        Int64 mem = 0;
        Boolean alt_switch = false;

        const Boolean DIGIT_INPUT_ = false;
        const Boolean OPERATOR_INPUT_ = true;
        const Int16 HEX_SYSTEM_ = 16;
        const Int16 DEC_SYSTEM_ = 10;
        const Int16 OCT_SYSTEM_ = 8;
        const Int16 BIN_SYSTEM_ = 2;

        Int16 current_system = DEC_SYSTEM_;

        public void update_switches()
        {
            /*
            hex_text.Text = Convert.ToString(screen_dec, 16);
            dec_text.Text = screen_dec.ToString();
            oct_text.Text = Convert.ToString(screen_dec, 8);
            bin_text.Text = Convert.ToString(screen_dec, 2);
            */
        }

        public void change_system(Int16 new_system)
        {
            if (new_system == HEX_SYSTEM_)
            {
                this.btn_a.Enabled = true;
                this.btn_b.Enabled = true;
                this.btn_c.Enabled = true;
                this.btn_d.Enabled = true;
                this.btn_e.Enabled = true;
                this.btn_f.Enabled = true;
                this.btn_0.Enabled = true;
                this.btn_1.Enabled = true;
                this.btn_2.Enabled = true;
                this.btn_3.Enabled = true;
                this.btn_4.Enabled = true;
                this.btn_5.Enabled = true;
                this.btn_6.Enabled = true;
                this.btn_7.Enabled = true;
                this.btn_8.Enabled = true;
                this.btn_9.Enabled = true;
                this.btn_dot.Enabled = false;
            }
            else if (new_system == DEC_SYSTEM_)
            {
                this.btn_a.Enabled = false;
                this.btn_b.Enabled = false;
                this.btn_c.Enabled = false;
                this.btn_d.Enabled = false;
                this.btn_e.Enabled = false;
                this.btn_f.Enabled = false;
                this.btn_0.Enabled = true;
                this.btn_1.Enabled = true;
                this.btn_2.Enabled = true;
                this.btn_3.Enabled = true;
                this.btn_4.Enabled = true;
                this.btn_5.Enabled = true;
                this.btn_6.Enabled = true;
                this.btn_7.Enabled = true;
                this.btn_8.Enabled = true;
                this.btn_9.Enabled = true;
                this.btn_dot.Enabled = true;
            }
            else if (new_system == OCT_SYSTEM_)
            {
                this.btn_a.Enabled = false;
                this.btn_b.Enabled = false;
                this.btn_c.Enabled = false;
                this.btn_d.Enabled = false;
                this.btn_e.Enabled = false;
                this.btn_f.Enabled = false;
                this.btn_0.Enabled = true;
                this.btn_1.Enabled = true;
                this.btn_2.Enabled = true;
                this.btn_3.Enabled = true;
                this.btn_4.Enabled = true;
                this.btn_5.Enabled = true;
                this.btn_6.Enabled = true;
                this.btn_7.Enabled = true;
                this.btn_8.Enabled = false;
                this.btn_9.Enabled = false;
                this.btn_dot.Enabled = false;
            }
            else if (new_system == BIN_SYSTEM_)
            {
                this.btn_a.Enabled = false;
                this.btn_b.Enabled = false;
                this.btn_c.Enabled = false;
                this.btn_d.Enabled = false;
                this.btn_e.Enabled = false;
                this.btn_f.Enabled = false;
                this.btn_0.Enabled = true;
                this.btn_1.Enabled = true;
                this.btn_2.Enabled = false;
                this.btn_3.Enabled = false;
                this.btn_4.Enabled = false;
                this.btn_5.Enabled = false;
                this.btn_6.Enabled = false;
                this.btn_7.Enabled = false;
                this.btn_8.Enabled = false;
                this.btn_9.Enabled = false;
                this.btn_dot.Enabled = false;
            }
            current_system = new_system;
        }

        public void update_screen()
        {
            this.screen.Text = screen_text;
            if (current_number != 0)
            {
                if (screen_text != "0")
                {
                    this.screen.Text = this.screen.Text + current_number.ToString();
                }
                else
                {
                    this.screen.Text = current_number.ToString();
                }
            }
        }

        public void add_digit(Int16 base_, Int32 digit_in_dec)
        {
            if (input_type == OPERATOR_INPUT_)
            {
                // current_number = 0;
            }
            input_type = DIGIT_INPUT_;
            current_number = current_number * base_ + digit_in_dec;
        }

        public void add_operator(string operator_)
        {
            if (input_type == DIGIT_INPUT_)
            {
                stop_digit_input();
                input_type = OPERATOR_INPUT_;
                screen_text = screen_text + operator_;
            }
            else if (input_type == OPERATOR_INPUT_)
            {
                short result = 0;
                Boolean bool_res = false;
                bool_res = Int16.TryParse(screen_text[screen_text.Length - 1].ToString(), out result);
                while (bool_res != true)
                {
                    screen_text = screen_text.Substring(0, screen_text.Length - 1);
                    bool_res = Int16.TryParse(screen_text[screen_text.Length - 1].ToString(), out result);
                }
                input_type = OPERATOR_INPUT_;
                screen_text = screen_text + operator_;
            }
        }

        public void stop_digit_input()
        {
            if (current_number != 0)
            {
                screen_text = screen_text + current_number.ToString();
                current_number = 0;
            }
        }

        public calc_form()
        {
            InitializeComponent();
            change_system(DEC_SYSTEM_);
            update_screen();
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 10);
            update_screen();
            update_switches();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 11);
            update_screen();
            update_switches();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 12);
            update_screen();
            update_switches();
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 13);
            update_screen();
            update_switches();
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 14);
            update_screen();
            update_switches();
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 15);
            update_screen();
            update_switches();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 1);
            update_screen();
            update_switches();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 2);
            update_screen();
            update_switches();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 3);
            update_screen();
            update_switches();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 4);
            update_screen();
            update_switches();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 5);
            update_screen();
            update_switches();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 6);
            update_screen();
            update_switches();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 7);
            update_screen();
            update_switches();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 8);
            update_screen();
            update_switches();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            add_digit(current_system, 9);
            update_screen();
            update_switches();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            screen_text = screen_text + "0";
            /*
             * don't work.
             * add_digit(current_system, 0);
            */
            update_screen();
            update_switches();
        }

        private void hex_switch_Click(object sender, EventArgs e)
        {
            change_system(HEX_SYSTEM_);
            update_screen();
        }

        private void dec_switch_Click(object sender, EventArgs e)
        {
            change_system(DEC_SYSTEM_);
            update_screen();
        }

        private void oct_switch_Click(object sender, EventArgs e)
        {
            change_system(OCT_SYSTEM_);
            update_screen();
        }

        private void bin_switch_Click(object sender, EventArgs e)
        {
            change_system(BIN_SYSTEM_);
            update_screen();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (screen_text.Length != 0 || current_number != 0)
            {
                short result = 0;
                Boolean bool_res = false;
                stop_digit_input();
                bool_res = Int16.TryParse(screen_text[screen_text.Length - 1].ToString(), out result);

                if (input_type == DIGIT_INPUT_)
                {

                }

                if (bool_res == true)
                {
                    screen_text = screen_text.Substring(0, screen_text.Length - 1);
                }
                else
                {
                    bool_res = false;
                    while (bool_res == false)
                    {
                        screen_text = screen_text.Substring(0, screen_text.Length - 1);
                        if (screen_text.Length == 0)
                        {
                            break;
                        }
                        bool_res = Int16.TryParse(screen_text[screen_text.Length - 1].ToString(), out result);
                    }
                }
            }
            update_screen();
            update_switches();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            add_operator("+");
            update_screen();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            add_operator("-");
            update_screen();
        }

        private void sin_Click(object sender, EventArgs e)
        {

        }
    }
}
