namespace win_forms_calc
{
    partial class calc_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calc_form));
            this.screen = new System.Windows.Forms.TextBox();
            this.strip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_a = new System.Windows.Forms.Button();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_e = new System.Windows.Forms.Button();
            this.btn_f = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.const_pi = new System.Windows.Forms.Button();
            this.alt = new System.Windows.Forms.Button();
            this.open_brackets = new System.Windows.Forms.Button();
            this.close_brackets = new System.Windows.Forms.Button();
            this.change_sign = new System.Windows.Forms.Button();
            this.clear_current = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.hex_switch = new System.Windows.Forms.Button();
            this.dec_switch = new System.Windows.Forms.Button();
            this.oct_switch = new System.Windows.Forms.Button();
            this.bin_switch = new System.Windows.Forms.Button();
            this.hex_text = new System.Windows.Forms.TextBox();
            this.dec_text = new System.Windows.Forms.TextBox();
            this.oct_text = new System.Windows.Forms.TextBox();
            this.bin_text = new System.Windows.Forms.TextBox();
            this.add_mem_to_current = new System.Windows.Forms.Button();
            this.plus_to_mem = new System.Windows.Forms.Button();
            this.min_to_mem = new System.Windows.Forms.Button();
            this.decorator_pic = new System.Windows.Forms.PictureBox();
            this.strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decorator_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Control;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screen.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.screen.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.screen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.screen.Location = new System.Drawing.Point(0, 24);
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(192, 19);
            this.screen.TabIndex = 0;
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // strip
            // 
            this.strip.BackColor = System.Drawing.SystemColors.Control;
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.strip.Location = new System.Drawing.Point(0, 0);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(298, 24);
            this.strip.TabIndex = 2;
            this.strip.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btn_a
            // 
            this.btn_a.Location = new System.Drawing.Point(0, 107);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(32, 32);
            this.btn_a.TabIndex = 5;
            this.btn_a.Text = "A";
            this.btn_a.UseVisualStyleBackColor = true;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // btn_b
            // 
            this.btn_b.Location = new System.Drawing.Point(32, 107);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(32, 32);
            this.btn_b.TabIndex = 11;
            this.btn_b.Text = "B";
            this.btn_b.UseVisualStyleBackColor = true;
            this.btn_b.Click += new System.EventHandler(this.btn_b_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(0, 139);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(32, 32);
            this.btn_c.TabIndex = 6;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_d
            // 
            this.btn_d.Location = new System.Drawing.Point(32, 139);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(32, 32);
            this.btn_d.TabIndex = 12;
            this.btn_d.Text = "D";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // btn_e
            // 
            this.btn_e.Location = new System.Drawing.Point(0, 171);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(32, 32);
            this.btn_e.TabIndex = 7;
            this.btn_e.Text = "E";
            this.btn_e.UseVisualStyleBackColor = true;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // btn_f
            // 
            this.btn_f.Location = new System.Drawing.Point(32, 171);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(32, 32);
            this.btn_f.TabIndex = 13;
            this.btn_f.Text = "F";
            this.btn_f.UseVisualStyleBackColor = true;
            this.btn_f.Click += new System.EventHandler(this.btn_f_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(96, 203);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(32, 32);
            this.btn_0.TabIndex = 26;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(64, 171);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(32, 32);
            this.btn_1.TabIndex = 19;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(96, 171);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(32, 32);
            this.btn_2.TabIndex = 25;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(128, 171);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(32, 32);
            this.btn_3.TabIndex = 31;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(64, 139);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(32, 32);
            this.btn_4.TabIndex = 18;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(96, 139);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(32, 32);
            this.btn_5.TabIndex = 24;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(128, 139);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(32, 32);
            this.btn_6.TabIndex = 30;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(64, 107);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(32, 32);
            this.btn_7.TabIndex = 17;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(96, 107);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(32, 32);
            this.btn_8.TabIndex = 23;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(128, 107);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(32, 32);
            this.btn_9.TabIndex = 29;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(128, 203);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(32, 32);
            this.btn_dot.TabIndex = 32;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(0, 43);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(32, 32);
            this.sin.TabIndex = 3;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(32, 43);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(32, 32);
            this.cos.TabIndex = 9;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(64, 43);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(32, 32);
            this.tg.TabIndex = 15;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            // 
            // const_pi
            // 
            this.const_pi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.const_pi.Location = new System.Drawing.Point(32, 75);
            this.const_pi.Name = "const_pi";
            this.const_pi.Size = new System.Drawing.Size(32, 32);
            this.const_pi.TabIndex = 10;
            this.const_pi.Text = "π";
            this.const_pi.UseVisualStyleBackColor = true;
            // 
            // alt
            // 
            this.alt.Location = new System.Drawing.Point(0, 75);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(32, 32);
            this.alt.TabIndex = 4;
            this.alt.Text = "↑";
            this.alt.UseVisualStyleBackColor = true;
            // 
            // open_brackets
            // 
            this.open_brackets.Enabled = false;
            this.open_brackets.Location = new System.Drawing.Point(0, 203);
            this.open_brackets.Name = "open_brackets";
            this.open_brackets.Size = new System.Drawing.Size(32, 32);
            this.open_brackets.TabIndex = 8;
            this.open_brackets.Text = "(";
            this.open_brackets.UseVisualStyleBackColor = true;
            // 
            // close_brackets
            // 
            this.close_brackets.Enabled = false;
            this.close_brackets.Location = new System.Drawing.Point(32, 203);
            this.close_brackets.Name = "close_brackets";
            this.close_brackets.Size = new System.Drawing.Size(32, 32);
            this.close_brackets.TabIndex = 14;
            this.close_brackets.Text = ")";
            this.close_brackets.UseVisualStyleBackColor = true;
            // 
            // change_sign
            // 
            this.change_sign.Enabled = false;
            this.change_sign.Location = new System.Drawing.Point(64, 203);
            this.change_sign.Name = "change_sign";
            this.change_sign.Size = new System.Drawing.Size(32, 32);
            this.change_sign.TabIndex = 20;
            this.change_sign.Text = "±";
            this.change_sign.UseVisualStyleBackColor = true;
            // 
            // clear_current
            // 
            this.clear_current.Location = new System.Drawing.Point(64, 75);
            this.clear_current.Name = "clear_current";
            this.clear_current.Size = new System.Drawing.Size(32, 32);
            this.clear_current.TabIndex = 16;
            this.clear_current.Text = "CE";
            this.clear_current.UseVisualStyleBackColor = true;
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(96, 75);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(32, 32);
            this.clear_all.TabIndex = 22;
            this.clear_all.Text = "C";
            this.clear_all.UseVisualStyleBackColor = true;
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(128, 75);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(32, 32);
            this.backspace.TabIndex = 28;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(96, 43);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(32, 32);
            this.ln.TabIndex = 21;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            // 
            // pow
            // 
            this.pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pow.Location = new System.Drawing.Point(128, 43);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(32, 32);
            this.pow.TabIndex = 27;
            this.pow.Text = "pow";
            this.pow.UseVisualStyleBackColor = true;
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(160, 43);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(32, 32);
            this.factorial.TabIndex = 33;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(160, 171);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(32, 32);
            this.plus.TabIndex = 37;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(160, 139);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(32, 32);
            this.minus.TabIndex = 36;
            this.minus.Text = "‒";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(160, 107);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(32, 32);
            this.product.TabIndex = 35;
            this.product.Text = "×";
            this.product.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(160, 75);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(32, 32);
            this.divide.TabIndex = 34;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(160, 203);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(32, 32);
            this.calculate.TabIndex = 38;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // hex_switch
            // 
            this.hex_switch.Location = new System.Drawing.Point(198, 47);
            this.hex_switch.Name = "hex_switch";
            this.hex_switch.Size = new System.Drawing.Size(40, 20);
            this.hex_switch.TabIndex = 39;
            this.hex_switch.Text = "HEX:";
            this.hex_switch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hex_switch.UseVisualStyleBackColor = true;
            this.hex_switch.Click += new System.EventHandler(this.hex_switch_Click);
            // 
            // dec_switch
            // 
            this.dec_switch.Location = new System.Drawing.Point(198, 67);
            this.dec_switch.Name = "dec_switch";
            this.dec_switch.Size = new System.Drawing.Size(40, 20);
            this.dec_switch.TabIndex = 40;
            this.dec_switch.Text = "DEC:";
            this.dec_switch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dec_switch.UseVisualStyleBackColor = true;
            this.dec_switch.Click += new System.EventHandler(this.dec_switch_Click);
            // 
            // oct_switch
            // 
            this.oct_switch.Location = new System.Drawing.Point(198, 87);
            this.oct_switch.Name = "oct_switch";
            this.oct_switch.Size = new System.Drawing.Size(40, 20);
            this.oct_switch.TabIndex = 41;
            this.oct_switch.Text = "OCT:";
            this.oct_switch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oct_switch.UseVisualStyleBackColor = true;
            this.oct_switch.Click += new System.EventHandler(this.oct_switch_Click);
            // 
            // bin_switch
            // 
            this.bin_switch.Location = new System.Drawing.Point(198, 107);
            this.bin_switch.Name = "bin_switch";
            this.bin_switch.Size = new System.Drawing.Size(40, 20);
            this.bin_switch.TabIndex = 45;
            this.bin_switch.Text = "BIN:";
            this.bin_switch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bin_switch.UseVisualStyleBackColor = true;
            this.bin_switch.Click += new System.EventHandler(this.bin_switch_Click);
            // 
            // hex_text
            // 
            this.hex_text.BackColor = System.Drawing.SystemColors.Control;
            this.hex_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hex_text.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hex_text.Location = new System.Drawing.Point(239, 51);
            this.hex_text.Name = "hex_text";
            this.hex_text.ReadOnly = true;
            this.hex_text.Size = new System.Drawing.Size(56, 13);
            this.hex_text.TabIndex = 47;
            // 
            // dec_text
            // 
            this.dec_text.BackColor = System.Drawing.SystemColors.Control;
            this.dec_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dec_text.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dec_text.Location = new System.Drawing.Point(239, 71);
            this.dec_text.Name = "dec_text";
            this.dec_text.ReadOnly = true;
            this.dec_text.Size = new System.Drawing.Size(56, 13);
            this.dec_text.TabIndex = 48;
            // 
            // oct_text
            // 
            this.oct_text.BackColor = System.Drawing.SystemColors.Control;
            this.oct_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oct_text.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oct_text.Location = new System.Drawing.Point(239, 90);
            this.oct_text.Name = "oct_text";
            this.oct_text.ReadOnly = true;
            this.oct_text.Size = new System.Drawing.Size(56, 13);
            this.oct_text.TabIndex = 49;
            // 
            // bin_text
            // 
            this.bin_text.BackColor = System.Drawing.SystemColors.Control;
            this.bin_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bin_text.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bin_text.Location = new System.Drawing.Point(239, 110);
            this.bin_text.Name = "bin_text";
            this.bin_text.ReadOnly = true;
            this.bin_text.Size = new System.Drawing.Size(56, 13);
            this.bin_text.TabIndex = 50;
            // 
            // add_mem_to_current
            // 
            this.add_mem_to_current.Location = new System.Drawing.Point(238, 23);
            this.add_mem_to_current.Name = "add_mem_to_current";
            this.add_mem_to_current.Size = new System.Drawing.Size(60, 20);
            this.add_mem_to_current.TabIndex = 42;
            this.add_mem_to_current.Text = "M:";
            this.add_mem_to_current.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_mem_to_current.UseVisualStyleBackColor = true;
            // 
            // plus_to_mem
            // 
            this.plus_to_mem.Location = new System.Drawing.Point(198, 23);
            this.plus_to_mem.Name = "plus_to_mem";
            this.plus_to_mem.Size = new System.Drawing.Size(20, 20);
            this.plus_to_mem.TabIndex = 43;
            this.plus_to_mem.Text = "+";
            this.plus_to_mem.UseVisualStyleBackColor = true;
            // 
            // min_to_mem
            // 
            this.min_to_mem.Location = new System.Drawing.Point(218, 23);
            this.min_to_mem.Name = "min_to_mem";
            this.min_to_mem.Size = new System.Drawing.Size(20, 20);
            this.min_to_mem.TabIndex = 44;
            this.min_to_mem.Text = "-";
            this.min_to_mem.UseVisualStyleBackColor = true;
            // 
            // decorator_pic
            // 
            this.decorator_pic.Image = global::Properties.Resources.pic;
            this.decorator_pic.Location = new System.Drawing.Point(199, 129);
            this.decorator_pic.Name = "decorator_pic";
            this.decorator_pic.Size = new System.Drawing.Size(97, 104);
            this.decorator_pic.TabIndex = 46;
            this.decorator_pic.TabStop = false;
            // 
            // calc_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 235);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.btn_a);
            this.Controls.Add(this.btn_b);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.btn_f);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.const_pi);
            this.Controls.Add(this.alt);
            this.Controls.Add(this.open_brackets);
            this.Controls.Add(this.close_brackets);
            this.Controls.Add(this.change_sign);
            this.Controls.Add(this.clear_current);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.product);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.hex_switch);
            this.Controls.Add(this.dec_switch);
            this.Controls.Add(this.oct_switch);
            this.Controls.Add(this.bin_switch);
            this.Controls.Add(this.hex_text);
            this.Controls.Add(this.dec_text);
            this.Controls.Add(this.oct_text);
            this.Controls.Add(this.bin_text);
            this.Controls.Add(this.add_mem_to_current);
            this.Controls.Add(this.plus_to_mem);
            this.Controls.Add(this.min_to_mem);
            this.Controls.Add(this.decorator_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.strip;
            this.MaximizeBox = false;
            this.Name = "calc_form";
            this.Text = "calc";
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decorator_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // main display
        private System.Windows.Forms.TextBox screen;
		
        // tool strip
        private System.Windows.Forms.MenuStrip strip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        // digit inputs
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_dot;

        // functions button
        // trig
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button const_pi;
        // alt modifier
        private System.Windows.Forms.Button alt;
        // brackets buttons
        private System.Windows.Forms.Button open_brackets;
        private System.Windows.Forms.Button close_brackets;
        // text edit
        private System.Windows.Forms.Button change_sign;
        private System.Windows.Forms.Button clear_current;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button backspace;
        // algebra
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button factorial;
        // arithmetic
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button calculate;
        // number systems selectors
        private System.Windows.Forms.Button hex_switch;
        private System.Windows.Forms.Button dec_switch;
        private System.Windows.Forms.Button oct_switch;
        private System.Windows.Forms.Button bin_switch;
        private System.Windows.Forms.TextBox hex_text;
        private System.Windows.Forms.TextBox dec_text;
        private System.Windows.Forms.TextBox oct_text;
        private System.Windows.Forms.TextBox bin_text;
        // memory operations
        private System.Windows.Forms.Button add_mem_to_current;
        private System.Windows.Forms.Button plus_to_mem;
        private System.Windows.Forms.Button min_to_mem;

        // decorator
        private System.Windows.Forms.PictureBox decorator_pic;
    }
}

