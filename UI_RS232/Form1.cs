using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics.Tracing;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace UI_RS232
{
    
    public partial class UI_Form : Form
    {
        string ReceiveData = String.Empty; //Bien nhan data
        string TransmitData = String.Empty; //Bien gui data 
        int countsw1 = 0, countsw2 = 0, countsw3 = 0; //Gan bien dem sw(1,2,3) 
        public UI_Form()
        {
            InitializeComponent();
        }

        private void UI_Form_Load(object sender, EventArgs e)
        {
            UI_Form_Load(sender, e, serialPort1);
        }

        //
        //UI_From
        //
        private void UI_Form_Load(object sender, EventArgs e, SerialPort serialPort1)
        {
            string[] ports = SerialPort.GetPortNames(); //Lay cac COM Port hien dang co tren PC

            foreach (string port in ports) //Voi moi Port trong tat ca cac Port hien co PC 
            {
                dropdownlist_comPort.Items.Add(port); //Them cac COM Ports vao dropdownlist_comPort
            }
        }
        //
        //Chuong trinh con gui data
        //
        public void send_Data(string data)
        {
            serialPort1.Write(data);
            textBox_sendData.Text = data.ToString();
        }

        //
        //DropDownList (COM Port)
        //
        private void dropdownlist_comPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = dropdownlist_comPort.Text;
                if (dropdownlist_comPort.Text == "COM1" || dropdownlist_comPort.Text == "COM2")
                {
                    dropdownlist_baudRate.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM Port not found !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //
        //DropDownList (Baud Rate)
        //
        private void dropdownlist_baudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gan toc do truyen cua Port = voi gia tri trong Item duoc chon trong dropdownlist
            serialPort1.BaudRate = (int.Parse(dropdownlist_baudRate.Text)); //Method 1 
            //serialPort1.BaudRate = Convert.ToInt32(dropdownlist_baudRate.Text); //Method 2
            //MessageBox.Show(serialPort1.BaudRate.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //Test gia tri toc do truyen cua Port 
        }
        //
        //Conncect button
        //
        private void button_connect_Click(object sender, EventArgs e)
        {
            if (dropdownlist_comPort.Text == "")//Truong hop Port chua duoc chon 
            {
                MessageBox.Show("Select a COM Port ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra hop thoai canh bao
            }
            else if (dropdownlist_baudRate.Text == "") //Trong truong hop da chon Port nhung chua chon toc do truyen
            {
                MessageBox.Show("Select appropriate Baud Rate ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra hop thoai canh bao
            }
            else //Truong hop con lai
            {
                try
                {
                    if (serialPort1.IsOpen) //Trong truong cong COM da ket noi ma van nhan nut connect 
                    {
                        MessageBox.Show("COM Port is already connected !! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong dua ra hop thoai nhac nho
                    }
                    else //Neu cong COM chua duoc ket noi 
                    {
                        serialPort1.Open(); //Mo cong COM
                        textbox_currentState.BackColor = Color.Green; textbox_currentState.ForeColor = Color.Black; // Chuyen mau cua textbox trang thai sang mau xanh
                        textbox_currentState.Text = "Connected"; //thay doi ki tu thanh "connected" tren textbox trang thai 
                        textBox_vehicleStatus.BackColor = Color.Green; textbox_currentState.ForeColor = Color.Black;
                        button_disconnect.Enabled = true; //Kich hoat nut disconnect
                        checkbox_dataSend.Enabled = true; //Kich hoat nut gui data
                        dropdownlist_comPort.Enabled = false; //Khoa chon cong Com
                        dropdownlist_baudRate.Enabled = false; //Khoa chon toc do truyen
                    }
                }
                catch (Exception) //Truong hop cong COM duoc chon da duoc chon hoac xung dot cong COM
                {
                    MessageBox.Show("COM Port not found !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
                }
            }
        }
        //
        //Disconnect button 
        //
        private void button_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen) //Trong truong hop cong COM dang mo 
                {
                    serialPort1.Close(); //Dong cong COM
                    textbox_currentState.BackColor = Color.Red; textbox_currentState.ForeColor = Color.Black; //Chuyen mau cua textbox trang thai ve lai mau do
                    textbox_currentState.Text = "Disconnected"; //Thay doi lai chuoi "Disconnected" ban dau
                    textBox_vehicleStatus.Text = "Vehicle Status";
                    textBox_vehicleStatus.BackColor = Color.White;
                    checkbox_dataSend.Checked = false; //Khoa nut chon nhap data
                    checkbox_dataSend.Enabled = false; //Khoa nut gui data
                    dropdownlist_comPort.Enabled = true; //Kich hoat lai chuc nang chon cong COM
                    dropdownlist_baudRate.Enabled = false; //Khoa chuc nang chon toc do truyen
                    textBox_sendData.Text = string.Empty; //Reset lai textbox gui data
                    textBox_receiveData.Text = string.Empty; //Reset lai textbox nhan data
                    button_disconnect.Enabled = false; //Khoa chuc nang disconnect
                    MessageBox.Show("COM Port had been connected !! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//He thong dua ra thong bao cong COM da ngat ket noi 
                }
            }
            catch (Exception) //Truong hop phat sinh loi 
            {
                MessageBox.Show("Something gone wrong !!, Please try again later! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//He thong dua ra thong bao loi
            }
        }   
        //
        //Open gate Button (Not use)
        //
        private void button_openGate_Click(object sender, EventArgs e)
        {

        }
        //
        //Close gate button (Not use)
        //
        private void button_closeGate_Click(object sender, EventArgs e)
        {

        }
        //
        //Data send checkbox
        //
        private void checkbox_dataSend_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkbox_dataSend.Checked == true) //Truong hop checkbox gui data duoc tich 
                {
                    textBox_sendData.Enabled = true;//Textbox gui data cho phep nhap data
                    button_sendData.Enabled = true;//Kich hoat nut gui data
                }
                else//Truong hop checkbox chua duoc tich
                {
                    textBox_sendData.Text = string.Empty;//Chuoi hoac ki tu trong textbox gui data se bi xoa 
                    textBox_sendData.Enabled = false; //Khoa chuc nang nhap data tren textbox gui data
                    button_sendData.Enabled = false; //Khoa nut gui data
                }
            }
            catch (Exception) //Truong hop phat sinh loi 
            {
                MessageBox.Show("Something went wrong !!, Please try again later !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra thong bao loi
            }
        }
        //
        //Send Data textbox
        //
        private void textBox_sendData_TextChanged(object sender, EventArgs e)
        {
            textBox_sendData.ForeColor = Color.Green; //Doi thanh mau xanh cac chuoi ki tu trong textbox gui data
        }
        //
        //Receive Data textbox
        //
        private void textBox_receiveData_TextChanged(object sender, EventArgs e)
        {
            textBox_receiveData.ForeColor = Color.Red; //Doi thanh mau xanh cac chuoi ki tu trong textbox nhan data
        }
        //
        //Send Data button
        //
        private void button_sendData_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_sendData.Text == "" && serialPort1.IsOpen) //Truong hop trong textbox gui data chua duoc nhap va cong COM da ket not 
                {
                    MessageBox.Show("Please input data you wanna send !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//he thong se dua thong bao nhap data 
                }
                else if (textBox_sendData.Text.Length > 20) //Neu chuoi data vuot qua 20 ki tu
                {
                    textBox_sendData.Text = string.Empty;//Xoa toan bo ki tu da nhap trong textbox gui data
                    MessageBox.Show("characters in the data do not over 20 !!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);//he thong dua ra canh bao va nhap lai   
                }
                else//Neu khong gap phai cac truong hop tren 
                {
                    TransmitData = textBox_sendData.Text.ToString(); //Gan bien gui du lieu cho chuoi hoac ki tu trong textbox gui data
                    send_Data(TransmitData); //Gui data 
                    MessageBox.Show("Data had been sent !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//He thong dua ra thong bao gui thanh cong
                }
            }
            catch (Exception)//Truong hop phat sinh loi 
            {
                MessageBox.Show("Something went wrong, disconnect and retry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);//He thong dua ra canh bao 
            }   
        }
        //
        //Led1 control
        //
        private void button_on1_Click(object sender, EventArgs e) //Nut bat LED1 
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Led1 on.";//Gan bien gui data bat LED1
                    send_Data(TransmitData); //Gui data                                                                     
                }
                else //Truong hop cong COM chua ket noi
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception) //Truong hop phat sinh loi 
            {

                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//He thong dua ra canh bao
            }
        }

        private void button_off1_Click(object sender, EventArgs e) //Nut tat LED1 
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Led1 off."; //Gan bien gui data tat LED1
                    send_Data(TransmitData); //Gui data 
                }
                else //Truong hop cong COM chua ket noi
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch(Exception) //Truong hop phat sinh loi
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//He thong dua ra canh bao
            }
        }
        //
        //Led2 Control
        //
        private void button_on2_Click(object sender, EventArgs e) //Nut bat LED2 
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Led2 on."; //Gan bien gui data bat LED2
                    send_Data(TransmitData); //Gui data
                }
                else //Truong hop cong COM chua ket noi
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception) //Truong hop phat sinh loi
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//He thong dua ra canh bao
            }
        }

        private void button_off2_Click(object sender, EventArgs e) //Nut tat LED2
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Led2 off."; //Gan bien gui data tat LED2
                    send_Data(TransmitData); //Gui data
                }
                else //Truong hop cong COM chua ket noi
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
            }
        }
        //
        //Led3 control
        //
        private void button_on3_Click(object sender, EventArgs e) //Nut bat LED3
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Led3 on."; //Gan bien gui data bat LED3
                    send_Data(TransmitData); //Gui data
                }
                else
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
            }
        }

        private void button_off3_Click(object sender, EventArgs e) //Nut tat LED3
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Led3 off."; //Gan bien gui data bat LED3
                    send_Data(TransmitData); //Gui data
                }
                else
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
            }
        }
        //
        //Data receive 
        //
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; //Kiem tra xung dot data
            //ReceiveData = serialPort1.ReadExisting();
            ReceiveData = serialPort1.ReadTo("."); //Data nhan co ki tu cuoi cung la "."
            this.Invoke(new EventHandler(DoUpDate)); //Khai trien ham DoUpDate (de dang chinh sua neu co thay doi)
        }
        //
        //CounterSW and change Led images status
        //
        private void DoUpDate(object sender, EventArgs e) //Ham DoUpDate
        {
            textBox_receiveData.Text = ReceiveData.ToString() + "."; //textbox nhan Data ki tu cuoi se la &
            //Cac truong hop du lieu nhan duoc
            switch (ReceiveData)
            {
                case "+Switch A.": //Nhan duoc chuoi 
                    countsw1++; //Tang bien dem sw1
                    textBox_sw1.Text = countsw1.ToString(); //Gan bien dem vao textboxsw1
                    //ReceiveData = string.Empty; //Ko su dung
                    break;
                case "+Swith B.": //Nhan duoc chuoi 
                    countsw2++; //Tang bien dem sw2
                    textBox_sw2.Text = countsw2.ToString(); //Gan bien dem vao textboxsw2
                    //ReceiveData = string.Empty; //Ko su dung 
                    break;
                case "+Switch C.": //Nhan duoc chuoi 
                    countsw3++; //Tang bien dem sw3
                    textBox_sw3.Text = countsw3.ToString(); //Gan bien dem vao textboxsw3
                    //ReceiveData = string.Empty; //Ko su dung
                    break;
                case "+Led1 on.": //Nhan duoc chuoi 
                    picBox_led1.Image = UI_RS232.Properties.Resources.densang__1_; //Thay doi hinh anh thanh led sang cua led1
                    break;
                case "+Led1 off.": //Nhan duoc chuoi 
                    picBox_led1.Image = UI_RS232.Properties.Resources.dentat__1_; //Thay doi hinh anh thanh led tat cua led1
                    break;
                case "+Led2 on.": //Nhan duoc chuoi 
                    picBox_led2.Image = UI_RS232.Properties.Resources.densang__1_; //Thay doi hinh anh thanh led sang cua led2
                    break;
                case "+Led2 off.": //Nhan duoc chuoi 
                    picBox_led2.Image = UI_RS232.Properties.Resources.dentat__1_; //Thay doi hinh anh thanh led tat cua led2
                    break;
                case "+Led3 on.": //Nhan duoc chuoi 
                    picBox_led3.Image = UI_RS232.Properties.Resources.densang__1_; //Thay doi hinh anh thanh led sang cua led3
                    break;
                case "+Led3 off.": //Nhan duoc chuoi 
                    picBox_led3.Image = UI_RS232.Properties.Resources.dentat__1_;//Thay doi hinh anh thanh led tat cua led3
                    break;
                case "Turning left.": //Nhan duoc chuoi 
                    textBox_vehicleStatus.Text = "Turn left";
                    break;
                case "Turning right.": //Nhan duoc chuoi 
                    textBox_vehicleStatus.Text = "Turn right";
                    break;
                case "MV forward.": //Nhan duoc chuoi 
                    textBox_vehicleStatus.Text = "Forward";
                    break;
                case "MV backward.": //Nhan duoc chuoi 
                    textBox_vehicleStatus.Text = "Backward";
                    break;
                case "Stop.": //Nhan duoc chuoi 
                    textBox_vehicleStatus.Text = "Stop";
                    break;

                default:
                    //Gia tri mac dinh cua cac bien 
                    picBox_led1.Image = picBox_led2.Image = picBox_led3.Image = UI_RS232.Properties.Resources.dentat__1_;
                    countsw1 = countsw2 = countsw3 = 0;
                    textBox_sw1.Text = textBox_sw2.Text = textBox_sw3.Text = "0";
                    break;
            }

        }
        //
        //Vehicle control
        //
        private void button_turnLeft_Click(object sender, EventArgs e) // Turn left 
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Turn left."; //Gan bien gui data dieu khien motor trai
                    send_Data(TransmitData); //Gui data
                   //textBox_vehicleStatus.Text = "Turn left";
                }
                else
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
            }
        }

        private void button_turnRight_Click(object sender, EventArgs e) // Turn right
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Turn right."; //Gan bien gui data dieu khien motor phai
                    send_Data(TransmitData); //Gui data
                    //textBox_vehicleStatus.Text = "Turn right";
                }
                else
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
            }
        }

        private void button_forward_Click(object sender, EventArgs e) // Forward
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Forward."; //Gan bien gui data dieu khien 2 motor quay theo chieu kim dong ho 
                    send_Data(TransmitData); //Gui data
                    //textBox_vehicleStatus.Text = "Forward";
                }
                else
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
            }
        }

        private void button_backward_Click(object sender, EventArgs e) // Backward
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Backward."; //Gan bien gui data dieu khien 2 motor quay nguoc chieu kim dong ho  
                    send_Data(TransmitData); //Gui data
                    //textBox_vehicleStatus.Text = "Backward";
                }
                else
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
            }
        }

        private void button_stop_Click(object sender, EventArgs e) // Stop 
        {
            try
            {
                if (serialPort1.IsOpen) //Truong hop cong COM da ket noi
                {
                    TransmitData = "+Stop."; //Gan bien gui data dieu khien dung 2 motor
                    send_Data(TransmitData); //Gui data
                    //textBox_vehicleStatus.Text = "Stop";
                }
                else
                {
                    MessageBox.Show("Please connect to a COM Port to use this !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //He thong nhac nho ket noi cong COM
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra canh bao
            }
        }
        //
        //Text box vehicle status
        //
        private void textBox_vehicleStatus_TextChanged(object sender, EventArgs e)
        {

        }
        //
        //Reset counter sw(1,2,3)
        //
        private void button_resetCounterSw_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)//Khi cong COM da ket noi
                {
                    textBox_sw1.Text = textBox_sw2.Text = textBox_sw3.Text = "0"; //Gan du lieu cua textbox sw(1,2,3) thanh gia tri ban dau la 0
                    textBox_receiveData.Text = string.Empty; //Xoa du lieu cua textbox nhan data
                }
                else //Truong hop cong da ngat ket noi 
                {
                    MessageBox.Show("PLease connect to a COM Port to use this !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Dua ra thong bao ket noi cong COM 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, Please try again later !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //He thong dua ra thong bao loi
            }
        }
        //
        //Closing UI_RS232
        //
        private void UI_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you wanna close this program ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Dua ra hop thoai lua chon Yes/No
            if (answer == DialogResult.No) //Truong hop chon No
            {
                e.Cancel = true; //Hoan tac dong UI_RS232
            }
            else //Trong hop chon Yes
            {
                e.Cancel = false; //Dong UI_RS232
                if (serialPort1.IsOpen) //Neu cong COM dang ket noi 
                {
                    serialPort1.Close(); //Ngat ket not cong COM
                }
            }
        }
    }
}
