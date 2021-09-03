using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hexProject
{
    public partial class Form1 : Form
    {
        int sum;
        public string[] temp;
        public string[] ascii_temp;
        public string[] ksc5601_temp;
        Bitmap loadBmp;
        public Form1()
        {
            InitializeComponent();
            loadBmp = new Bitmap(picBmp.Image);
        }

        private int StringToInt(string str)
        {
            int strInt;
            if (int.TryParse(str, out strInt))
            {
                strInt = Convert.ToInt32(str);
            }
            return strInt;
        }
        private int StringToHex(string str)
        {
            int strInt;
            if (int.TryParse(str, out strInt))
            {
                strInt = Convert.ToInt32(str, 16);
            }
            return strInt;
        }
        private string StringHexToDec(string str)
        {
            string strDec = Convert.ToInt32(str, 16).ToString();
            return strDec;
        }
        public static string ConvertHex(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }

        public static string ByteToHex(byte hexByte)
        {
            try
            {
                string hex = string.Empty;
                hex = hexByte.ToString();

                uint decval = System.Convert.ToUInt32(hex, 16);
                hex += decval;

                return hex;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }

        public static string ToHexString(string str)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            label3.Text = " - ";
            label5.Text = " - ";

            sum = 0;
            textBox1.Text.Trim();
            temp = textBox1.Text.Split(new string[] { Delimitier_box.Text }, StringSplitOptions.None);
            for (int i = 0; i < temp.Length; i++)
            {
                textBox2.Text += temp[i];
                textBox2.Text += " ";
                textBox3.Text += ConvertHex(temp[i]);
                textBox3.Text += " ";

                try
                {
                    temp[i] = temp[i].Trim();
                    sum += StringToInt(StringHexToDec(temp[i]));
                }
                catch (Exception ex)
                {
                    if (ex.HResult.ToString() == "-2146233086")
                    {
                        label3.Text = ex.Message.ToString();
                        label3.Text = "Check Delimiter";
                    }
                    else if (ex.HResult.ToString() == "-2146233033")
                    {
                        label3.Text = ex.Message.ToString();
                        label3.Text = "Not Hex Value";
                    }
                    else if (ex.HResult.ToString() == "-2147024809")
                    {
                        label3.Text = ex.Message.ToString();
                        label3.Text = "Negative values cannot be entered";
                    }
                    else if (ex.HResult.ToString() == "-2146233066")
                    {
                        label3.Text = ex.Message.ToString();
                        label3.Text = "Value too large or too small";
                    }
                    else
                    {
                        label3.Text = ex.Message.ToString();
                    }

                    //label3.Text = ex.HResult.ToString();

                }
            }
            try
            {
                HEX_TEXTBOX.Text = String.Format("{0:X}", sum);
            }
            catch (Exception ex)
            {
                label5.Text = ex.Message.ToString();
            }
            DEC_TEXTBOX.Text = sum.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
            ascii_temp = textBox5.Text.Split(new string[] { " " }, StringSplitOptions.None);
            try
            {
                for (int i = 0; i < ascii_temp.Length; i++)
                {
                    textBox6.Text += ToHexString(ascii_temp[i]).Replace("00", "");
                    textBox6.Text += Delimitier_box.Text;
                }
                for (int j = 0; j < StringToInt(textBox7.Text) - ascii_temp.Length; j++)
                {
                    textBox6.Text += "00:";
                }
            }
            catch (Exception ex)
            {
                textBox6.Text = ex.Message;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox5_TextChanged(0, e);
            textBox9_TextChanged(0, e);
        }
        string tmpp, tmppp, tmpppp;
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = "";
            tmpp = "";
            tmppp = "";
            Encoding ksc5601 = Encoding.GetEncoding(949);

            /* ENC ("ks-c-5601", 949), 
               ENC("ks-c5601", 949), 
               ENC("KSC5601", 949), 
               ENC("KSC_5601", 949), 
               ENC("ks_c_5601", 949),*/

            string tmp = textBox9.Text;
            byte[] tm = ksc5601.GetBytes(tmp);


            try
            {
                if (radioButton2.Checked == true)
                {
                    for (int i = 0; i < tm.Length; i++)
                    {
                        if (tm[i] >= 0xB0 && tm[i] <= 0xC8)
                        {
                            /*textBox8.Text += tmpp = string.Format("{0:X}", tm[i++]);
                            textBox8.Text += tmppp = string.Format("{0:X}", tm[i]);
                            textBox8.Text += "-";
                            */

                            tmpp = string.Format("{0:X}", tm[i++]);
                            tmppp = string.Format("{0:X}", tm[i]);

                            tmpppp = "0x" + tmpp + tmppp;
                            textBox8.Text += tmpppp;
                            /*int index = Array.BinarySearch(KSHangulTable, tmpppp);
                            textBox8.Text += string.Format("{0:D}", index); 
                            
                            textBox8.Text += "-";
                            textBox8.Text += Delimitier_box.Text;
                            */
                            textBox8.Text += ", ";
                        }
                        else
                        {
                            textBox8.Text += "\r\n";

                            /*textBox8.Text += string.Format("{0:X}", tm[i]);
                            textBox8.Text += Delimitier_box.Text;*/
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < tm.Length; i++)
                    {
                        textBox8.Text += string.Format("{0:X}", tm[i]);
                        //if(i != tm.Length - 1 || StringToInt(textBox7.Text) - tm.Length !=0)
                        textBox8.Text += Delimitier_box.Text;
                    }
                }

                for (int j = 0; j < StringToInt(textBox7.Text) - tm.Length; j++)
                {
                    textBox8.Text += "00";
                    if (j != StringToInt(textBox7.Text) - tm.Length - 1)
                        textBox8.Text += Delimitier_box.Text;
                }   

            }
            catch (Exception ex)
            {
                textBox8.Text = ex.Message;
            }
        }

        private void CodeTable_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";

            int a = 0xA1;
            int b = 0xB0;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    b = 0xB0;
                    break;
                case 1:
                    b = 0xB1;
                    break;
                case 2:
                    b = 0xB2;
                    break;
                case 3:
                    b = 0xB3;
                    break;
                case 4:
                    b = 0xB4;
                    break;
                case 5:
                    b = 0xB5;
                    break;
                case 6:
                    b = 0xB6;
                    break;
                case 7:
                    b = 0xB7;
                    break;
                case 8:
                    b = 0xB8;
                    break;
                case 9:
                    b = 0xB9;
                    break;
                case 10:
                    b = 0xBA;
                    break;
                case 11:
                    b = 0xBB;
                    break;
                case 12:
                    b = 0xBC;
                    break;
                case 13:
                    b = 0xBD;
                    break;
                case 14:
                    b = 0xBE;
                    break;
                case 15:
                    b = 0xBF;
                    break;
                case 16:
                    b = 0xC0;
                    break;
                case 17:
                    b = 0xC1;
                    break;
                case 18:
                    b = 0xC2;
                    break;
                case 19:
                    b = 0xC3;
                    break;
                case 20:
                    b = 0xC4;
                    break;
                case 21:
                    b = 0xC5;
                    break;
                case 22:
                    b = 0xC6;
                    break;
                case 23:
                    b = 0xC7;
                    break;
                case 24:
                    b = 0xC8;
                    break;

                default:
                    MessageBox.Show("check value");
                    break;

            }

            for (int i = 0; i < 94; i++)
            {
                textBox8.Text += string.Format("{0:X}", b);
                textBox8.Text += Delimitier_box.Text;
                textBox8.Text += string.Format("{0:X}", a + i);
                if (i != 93)
                    textBox8.Text += Delimitier_box.Text;
            }
        }

        private void add_check_sum_Click(object sender, EventArgs e)
        {
            char tmp1, tmp2;

            tmp1 = HEX_TEXTBOX.Text[HEX_TEXTBOX.Text.Length - 2];
            tmp2 = HEX_TEXTBOX.Text[HEX_TEXTBOX.Text.Length - 1];

            textBox1.Text += ":" + string.Format("{0:X}", tmp1) + string.Format("{0:X}", tmp2);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox9_TextChanged(0, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox9_TextChanged(0, e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CodeTable_Click(0, e);
                button1_Click(0, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1A:02:C7:D1:B1:DB:20:20:C5:D7:BD:BA:C6:AE:00:00:00:00:00:00:00:00:";
            textBox1.Text += textBox8.Text;
            add_check_sum_Click(0, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                textBox4.Text = "";

                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        textBox4.Text = "Ble RX Example Code";
                        break;
                    case 1:
                        textBox4.Text = "01:02:32:30:32:30:30:31:31:30:31:32:35:37:30:30:10:C8 \r\n";
                        textBox4.Text += "\r\n";
                        textBox4.Text += "01:02:32:30:32:31:";
                        textBox4.Text += (DateTime.Now.Month / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Month % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Day / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Day % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Hour / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Hour % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Minute / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Minute % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Second / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Second % 10 + 30).ToString();
                        textBox4.Text += ":10";

                        textBox4.Text += "\r\n";

                        break;
                    case 2:
                        textBox4.Text = "RECEIVE_STATUS";
                        break;
                    case 3:
                        textBox4.Text = "02:02:04";
                        break;
                    case 4:
                        textBox4.Text = "03:02:02:07";
                        break;
                    case 5:
                        textBox4.Text = "04:02:01:07\r\nOTA-\r\n04:02:01:03:0A";
                        break;
                    case 6:
                        textBox4.Text = "어플과 협의 프로토콜 협의 후 진행 - 앱 알림";
                        break;
                    case 7:
                        textBox4.Text = "어플과 협의 프로토콜 협의 후 진행 - 예정 없음";
                        break;
                    case 8:
                        textBox4.Text = "05:02:32:30:31:39:31:31:31:33:31:39:32:32:30:30:01:11:D9";
                        break;
                    case 9:
                        textBox4.Text = "전달- \r\n06:02:32:30:32:30:30:31:30:38:31:35:30:39:30:30:AF:50:01:F7:BB \r\n확인- \r\n16:02:18";
                        break;
                    case 10:
                        textBox4.Text = "07:02:01:00:00:0A:00:05:00:0E:08:09:0A:09:07:0F:61";
                        break;
                    case 11:
                        textBox4.Text = "08:02:05:00:20:07:36";
                        break;
                    case 12:
                        textBox4.Text = "09:02:00:00:00:07:00:00:12";
                        break;
                    case 13:
                        textBox4.Text = "0A:02:02:0E";
                        break;
                    case 14:
                        textBox4.Text = "13:02:01:16";
                        break;
                    case 15:
                        textBox4.Text = "Band -> App";
                        break;
                    case 16:
                        textBox4.Text = "Band -> App";
                        break;
                    case 17:
                        textBox4.Text = "Band -> App";
                        break;
                    case 18:
                        textBox4.Text = "12:02:14";
                        break;
                    case 19:
                        textBox4.Text = "정상종료-14:02:01:17\r\n비정상종료-14:02:02:18";
                        break;
                    case 20:
                        textBox4.Text = "Band -> App \r\n15:01:17";
                        break;
                    case 21:
                        textBox4.Text = "17:02:19";
                        break;
                    case 22:
                        textBox4.Text = "안양시 관양동 : 시간 0x06(18시~21시) : 기온 0x1A(26도)\r\n18:02:" + "32:30:32:31:";
                        textBox4.Text += (DateTime.Now.Month / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Month % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Day / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Day % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Hour / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Hour % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Minute / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Minute % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Second / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Second % 10 + 30).ToString();
                        textBox4.Text += ":";
                        /*textBox4.Text += "BE:C8:BE:E7:BD:C3:20:B0:FC:BE:E7:B5:BF:00:00:00:00:00:00:00:" + // 안양시 관양동
                            //일자:시간:온도:날씨:최저온도:최고온도
                            "00:05:08:00:FF:FF:" +      //0
                            "00:06:11:01:10:20:" +      //1
                            "00:07:13:02:01:02:" +      //2
                            "01:00:07:03:0A:0B:" +      //3
                            "01:01:06:04:0C:0D:" +      //4
                            "01:02:05:05:0E:0F:" +      //5
                            "01:03:04:06:10:11:" +      //6
                            "01:04:03:07:12:13:" +      //7
                            "01:05:02:00:14:15:" +      //8
                            "01:06:01:01:16:17:" +      //9
                            "01:07:00:02:18:19:" +      //a
                            "02:00:10:03:1A:1B:" +      //b
                            "02:01:20:04:1C:1D:" +      //c
                            "02:02:30:05:1E:1F:" +      //d
                            "02:03:40:06:20:21:" +      //e
                            "02:04:50:07:22:23:" +      //f                        
                            "86";*/
                        textBox4.Text += "BC:AD:C3:CA:B1:B8:20:BE:E7:C0:E7:B5:BF:00:00:00:00:00:00:00:" + // 서초구 양재동
                                                                                                          //일자:시간:온도:날씨
                            "04:12:20:00:" +
                            "04:15:1A:01:" +
                            "05:00:19:02:" +
                            "05:03:18:03:" +
                            "05:06:17:04:" +
                            "05:09:16:05:" +
                            "05:0C:15:06:" +
                            "05:0F:05:01:" +
                            "05:12:04:02:" +
                            "05:15:03:03:" +
                            "06:00:02:04:" +
                            "06:03:01:05:" +
                            "06:06:FE:06:" +
                            "06:09:F2:00:" +
                            "06:0C:E8:01:" +
                            "06:0F:DE:02:";
                        break;
                    case 23:
                        textBox4.Text = "Band -> App" + "\r\n 19:01:01:03:1E ";
                        break;
                    case 24:
                        textBox4.Text = "잘 지내시죠? 늘 건강하시고 만사에 평강하시길 기원 드립니다.\r\n\r\n" +
                                        "1A:02:" + "32:30:32:31:";
                        textBox4.Text += (DateTime.Now.Month / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Month % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Day / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Day % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Hour / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Hour % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Minute / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Minute % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Second / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Second % 10 + 30).ToString();
                        textBox4.Text += ":C7:D1:B1:DB:20:20:C5:D7:BD:BA:C6:AE:00:00:00:00:00:00:00:00:C0:DF:20:20:C1:F6:B3:BB:BD:C3:C1:D2:3F:20:B4:C3:20:20:B0:C7:B0:AD:C7:CF:BD:C3:B0:ED:20:20:B8:B8:BB:E7:BF:A1:20:20:C6:F2:B0:AD:C7:CF:BD:C3:B1:E6:20:20:B1:E2:BF:F8:20:20:B5:E5:B8:B3:B4:CF:B4:D9:2E";
                        textBox4.Text += "\r\n Engtest \r\n";
                        textBox4.Text += "1A:02:32:30:32:31:30:35:30:33:31:35:35:30:31:39:45:6E:67:6C:69:73:68:54:65:73:74:00:00:00:00:00:00:00:00:00:41:42:43:44:45:46:47:48:49:4A:4B:4C:4D:4E:4F:50:51:52:53:54:55:56:57:58:59:5A:61:62:63:64:65:66:67:68:69:6A:6B:6C:6D:6E:6F:70:71:72:73:74:75:76:77:78:79:7A:46";
                        textBox4.Text += "\r\n 특문 Test \r\n";
                        textBox4.Text += "1A:02:32:30:32:31:30:35:30:33:31:35:35:30:31:39:C6:AF:B9:AE:54:65:73:74:00:00:00:00:00:00:00:00:00:00:00:00:20:21:22:23:24:25:26:27:28:29:2A:2B:2C:2D:2E:2F:3A:3B:3C:3D:3E:3F:40:5B:5C:5D:5E:5F:60:7B:7C:7D:7E:A0";

                        break;
                    case 25:
                        textBox4.Text = "300전 199승 101패\r\n\r\n" +
                            "1B:02:" + "32:30:32:31:";
                        textBox4.Text += (DateTime.Now.Month / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Month % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Day / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Day % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Hour / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Hour % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Minute / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Minute % 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Second / 10 + 30).ToString();
                        textBox4.Text += ":";
                        textBox4.Text += (DateTime.Now.Second % 10 + 30).ToString();
                        textBox4.Text += ":01:2C:00:C7:00:65";
                        break;

                    case 26:
                        textBox4.Text += "A>B 22:02:01:03:28-BAND 찾기(진동)";
                        textBox4.Text += "\r\n";
                        textBox4.Text += "A>B 22:02:02:03:29-BAND 찾기 중지(진동 끔)";
                        textBox4.Text += "\r\n";
                        textBox4.Text += "B>A 22:01:03:03:29-BAND 찾기 완료(진동 끔)";
                        textBox4.Text += "\r\n" + "\r\n";
                        textBox4.Text += "B>A 22:01:01:03:27-MOBILE 찾기(진동 및 벨소리)";
                        textBox4.Text += "\r\n";
                        textBox4.Text += "B>A 22:01:02:03:28-MOBILE 찾기 중지(진동 및 벨소리 끔)";
                        textBox4.Text += "\r\n";
                        textBox4.Text += "A>B 22:02:03:03:2A-MOBILE 찾기 완료(진동 및 벨소리 끔)";
                        textBox4.Text += "\r\n";
                        break;

                    default:
                        textBox4.Text = "check value";
                        break;

                }
            }
        }

        #region bmp2hex
        //public static string lastPath;
        private void button5_Click(object sender, EventArgs e)
        {
            OpenDlg.InitialDirectory = "./";
            OpenDlg.Filter = "bmp Files|*.bmp|png Files|*.png|All Files|*.*";
            OpenDlg.FilterIndex = 2;
            OpenDlg.RestoreDirectory = true;
            
            try
            {
                if (OpenDlg.ShowDialog() == DialogResult.OK)
                {
                    loadBmp = new Bitmap(OpenDlg.FileName);
                    picBmp.Image = loadBmp;
                    textBox11.Text = "";

                    Bitmap bmp = new Bitmap(picBmp.Image);
                    StringBuilder sb = new StringBuilder();

                    var fPath = OpenDlg.FileName;
                    string[] fN = fPath.Split('\\');
                    string fileName = fN[fN.Length - 1].Replace(".png", "");

                    sb.Append("const GUI_BITMAP IMG_" + fileName + "_ = {\r\n");
                    sb.Append("    " + bmp.Width + ", \r\n");
                    sb.Append("    " + bmp.Height + ", \r\n");
                    sb.Append("    (uint8_t *) IMG_" + fileName + ", \r\n");
                    sb.Append("    _IMG_" + fileName + ", \r\n");
                    sb.Append("}; \r\n");
                    textBox10.Text = sb.ToString();

                    sb.Clear();
                    sb.Append("extern const GUI_BITMAP IMG_" + fileName + "_;");
                    textBox12.Text = sb.ToString();

                    sb.Clear();
                    sb.Append("    _IMG_" + fileName + "                         = 0x0,");
                    textBox13.Text = sb.ToString();

                    button4_Click(0,e);
                }
            }
            catch
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, y, bf, n, r, g, b;

            Color color;
            Bitmap bmp = new Bitmap(picBmp.Image);
            StringBuilder sb = new StringBuilder();

            var fPath = OpenDlg.FileName;
            string[] fN = fPath.Split('\\');
            string fileName = fN[fN.Length - 1].Replace(".png", "");


            sb.Append("/* \r\n           CHANHIHI RGB565_16bit Image Converter tool \r\n*/");
            sb.Append("\r\n/*" +
                "\r\n           Image size x = " + bmp.Width+ "    y = " + bmp.Height +
                "\r\n                    Total: " + (bmp.Width * bmp.Height * 2) + " Bytes " +
                "\r\n           Convert to Color RGB565 16bit / pixel      \r\n*/\r\n");
            sb.Append("const unsigned char IMG_" + fileName + "[] = {\r\n");

            y = 0; x = 0;

            for (y = 0; y < bmp.Height; ++y) // row
            {
                n = 0;
                for (x = 0; x < bmp.Width; ++x)
                {
                    color = bmp.GetPixel(x, y);
                    r = color.R; r >>= 3; r <<= 11; bf = r; // 5
                    g = color.G; g >>= 2; g <<= 5; bf |= g; // 6
                    b = color.B; b >>= 3; bf |= b; // 5


                    sb.Append("0x");
                    sb.Append(string.Format("{0:X2}", (byte)(bf >> 8)));

                    sb.Append(",0x");
                    sb.Append(string.Format("{0:X2}", (byte)(bf & 0xff)));



                    if (y == (bmp.Height+1) && x == (bmp.Width+1))
                    {
                        sb.Append("};");
                    }
                    else
                    {
                        sb.Append(",");
                        if (++n >= (bmp.Width))
                        {
                            n = 0;
                            sb.Append("\r\n");
                        }
                    }
                }
            }
            sb.Append("};");
            textBox11.Text = sb.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picBmp.Image);
            StringBuilder sb = new StringBuilder();

            var fPath = OpenDlg.FileName;
            string[] fN = fPath.Split('\\');
            string fileName = fN[fN.Length - 1].Replace(".png", "");

            sb.Append("const GUI_BITMAP IMG_" + fileName + "_ = {\r\n");
            sb.Append("    " + bmp.Width + ", \r\n");
            sb.Append("    " + bmp.Height + ", \r\n");
            sb.Append("    (uint8_t *) IMG_" + fileName + ", \r\n");
            sb.Append("    _IMG_" + fileName + ", \r\n");
            sb.Append("}; \r\n");
            sb.Append("\r\n");
            sb.Append("extern const GUI_BITMAP IMG_" + fileName + "_;\r\n\r\n");
            sb.Append("    _IMG_" + fileName + "                         = 0x0,\r\n");
            
            textBox12.Text = sb.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox11.Text);
            }
            catch
            {
                MessageBox.Show("Error","None text");
            }            
        }

        #endregion
    }
}
