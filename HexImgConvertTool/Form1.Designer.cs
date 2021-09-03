namespace hexProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DEC_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Delimitier_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HEX_TEXTBOX = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.CodeTable = new System.Windows.Forms.Button();
            this.add_check_sum = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.picBmp = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.OpenDlg = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBmp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 160);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(416, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 78);
            this.textBox2.TabIndex = 1;
            // 
            // DEC_TEXTBOX
            // 
            this.DEC_TEXTBOX.Location = new System.Drawing.Point(818, 56);
            this.DEC_TEXTBOX.Name = "DEC_TEXTBOX";
            this.DEC_TEXTBOX.Size = new System.Drawing.Size(182, 21);
            this.DEC_TEXTBOX.TabIndex = 7;
            // 
            // Delimitier_box
            // 
            this.Delimitier_box.Location = new System.Drawing.Point(819, 244);
            this.Delimitier_box.Name = "Delimitier_box";
            this.Delimitier_box.Size = new System.Drawing.Size(184, 21);
            this.Delimitier_box.TabIndex = 9;
            this.Delimitier_box.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delimiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Checksum (DEC)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = " -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Checksum (HEX)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(816, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            // 
            // HEX_TEXTBOX
            // 
            this.HEX_TEXTBOX.Location = new System.Drawing.Point(818, 138);
            this.HEX_TEXTBOX.Name = "HEX_TEXTBOX";
            this.HEX_TEXTBOX.Size = new System.Drawing.Size(184, 21);
            this.HEX_TEXTBOX.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(416, 123);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(380, 78);
            this.textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(30, 229);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(380, 164);
            this.textBox5.TabIndex = 3;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(416, 229);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(380, 164);
            this.textBox6.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hex Value Input";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "ASCII Value Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(817, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "Required Byte";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(819, 304);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 21);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "10";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "KSC5601 Value Input";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(417, 420);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox8.Size = new System.Drawing.Size(380, 164);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(31, 420);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(380, 164);
            this.textBox9.TabIndex = 5;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(819, 444);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 16);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1byte";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(819, 466);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 16);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.Text = "2byte";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(817, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "Delimited Byte";
            // 
            // CodeTable
            // 
            this.CodeTable.Location = new System.Drawing.Point(817, 518);
            this.CodeTable.Name = "CodeTable";
            this.CodeTable.Size = new System.Drawing.Size(181, 34);
            this.CodeTable.TabIndex = 34;
            this.CodeTable.Text = "CodeTableTest";
            this.CodeTable.UseVisualStyleBackColor = true;
            this.CodeTable.Click += new System.EventHandler(this.CodeTable_Click);
            // 
            // add_check_sum
            // 
            this.add_check_sum.Location = new System.Drawing.Point(816, 177);
            this.add_check_sum.Name = "add_check_sum";
            this.add_check_sum.Size = new System.Drawing.Size(186, 24);
            this.add_check_sum.TabIndex = 25;
            this.add_check_sum.Text = "Apply Hex Value";
            this.add_check_sum.UseVisualStyleBackColor = true;
            this.add_check_sum.Click += new System.EventHandler(this.add_check_sum_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "B7",
            "B8",
            "B9",
            "BA",
            "BB",
            "BC",
            "BD",
            "BE",
            "BF",
            "C0",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "C7",
            "C8"});
            this.comboBox1.Location = new System.Drawing.Point(818, 488);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 20);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 34);
            this.button1.TabIndex = 35;
            this.button1.Text = "Notify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0.Code Example Test Table",
            "1.날짜/시간 전송",
            "2.성공/실패",
            "3.스코어 전달",
            "4.활동량 전달",
            "5.Upgrade",
            "6.Incoming Call",
            "7.사진촬영",
            "8.App이 Band를 제어",
            "9.신장, 몸무게 데이터 전달 (App->Band)",
            "10.화이트리스트(whitelist) MAC address 설정 (App->Band)",
            "11.스코어 인덱스에 대한 스코어 값 전달 (App->Band)",
            "12.Band 저장되어 있는 스코어 값 전달 (Band ->App)",
            "13.스코어 값 전달 (Band ->App)",
            "14.APP에서 BAND 연결 허락 요청 (APP ->Band)",
            "15.Paring 성공 여부 전달 (Band ->App)",
            "16.스코어 모드 진입(Band ->App)",
            "17.스코어 모드 진입 시 서비스권 선택(Band -> App)",
            "18.밴드에 저장 되어 있는 스코어 저장 유무 확인(APP -> BAND)",
            "19.게임 정상적인 종료 확인(APP ->Band)",
            "20.코트 체인지(Band ->APP)",
            "21.밴드에 저장 되어 있는 Pedo 데이터 값 전달(APP -> BAND)",
            "22.날씨 전송 (APP -> BAND)",
            "23.날씨 정보 요청(Band ->APP)",
            "24.앱 알림(APP ->Band)",
            "25.승률 정보 전송 (APP -> BAND)",
            "26.Device 찾기 요청"});
            this.comboBox2.Location = new System.Drawing.Point(32, 590);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(379, 20);
            this.comboBox2.TabIndex = 39;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 616);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(378, 76);
            this.button3.TabIndex = 38;
            this.button3.Text = "Code Example Table";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(417, 590);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(380, 102);
            this.textBox4.TabIndex = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 752);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.DEC_TEXTBOX);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.Delimitier_box);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.add_check_sum);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CodeTable);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.HEX_TEXTBOX);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "hexV";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox13);
            this.tabPage2.Controls.Add(this.textBox12);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.picBmp);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1041, 726);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "png2bmp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.AllowDrop = true;
            this.textBox13.Location = new System.Drawing.Point(317, 141);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox13.Size = new System.Drawing.Size(493, 21);
            this.textBox13.TabIndex = 52;
            // 
            // textBox12
            // 
            this.textBox12.AllowDrop = true;
            this.textBox12.Location = new System.Drawing.Point(317, 114);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox12.Size = new System.Drawing.Size(493, 21);
            this.textBox12.TabIndex = 51;
            // 
            // textBox10
            // 
            this.textBox10.AllowDrop = true;
            this.textBox10.Location = new System.Drawing.Point(317, 20);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox10.Size = new System.Drawing.Size(493, 88);
            this.textBox10.TabIndex = 50;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(842, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 34);
            this.button7.TabIndex = 49;
            this.button7.Text = "Copy ▼";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // picBmp
            // 
            this.picBmp.Image = global::HexImgConvertTool.Properties.Resources.charging;
            this.picBmp.Location = new System.Drawing.Point(29, 20);
            this.picBmp.Name = "picBmp";
            this.picBmp.Size = new System.Drawing.Size(264, 137);
            this.picBmp.TabIndex = 48;
            this.picBmp.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(842, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 34);
            this.button4.TabIndex = 46;
            this.button4.Text = "Convert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(842, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 34);
            this.button5.TabIndex = 45;
            this.button5.Text = "PNG2BMP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox11
            // 
            this.textBox11.AllowDrop = true;
            this.textBox11.Location = new System.Drawing.Point(29, 168);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox11.Size = new System.Drawing.Size(997, 552);
            this.textBox11.TabIndex = 44;
            // 
            // OpenDlg
            // 
            this.OpenDlg.FileName = "OpenDlg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1080, 776);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "hexProject";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox DEC_TEXTBOX;
        private System.Windows.Forms.TextBox Delimitier_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HEX_TEXTBOX;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CodeTable;
        private System.Windows.Forms.Button add_check_sum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog OpenDlg;
        private System.Windows.Forms.PictureBox picBmp;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox10;
    }
}

