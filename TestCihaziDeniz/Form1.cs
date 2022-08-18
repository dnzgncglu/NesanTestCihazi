using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace TestCihaziDeniz
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string sendWith;
        string dataIN;
        int dataINLength;
        int[] dataInDec;

        StreamWriter objStreamWriter;
        string pathFile;
        bool state_AppendText = true;

        #region My Own Method

        private void SaveDataToTxtFile()
        {
            if(saveToTxtFileToolStripMenuItem.Checked)
            {
                try
                {
                    objStreamWriter = new StreamWriter(pathFile, state_AppendText);
                    if (toolStripComboBox_writeLineOrwriteText.Text == "WriteLine")
                    {
                        objStreamWriter.WriteLine(dataIN);
                    }
                    else if (toolStripComboBox_writeLineOrwriteText.Text == "Write")
                    {
                        objStreamWriter.Write(dataIN + " ");
                    }

                    objStreamWriter.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        private void SaveDataToMySqlDatabese()
        {
            if(saveToMySQLDatabeseToolStripMenuItem.Checked)
            {
                try
                {
                    RefreshDataGridViewForm2();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        #region Custom EventHandler
        public delegate void UpdateDelegate(object sender, UpdateDataEventArgs args);

        public event UpdateDelegate UpdateDataEventHandler;
        public class UpdateDataEventArgs : EventArgs
        {

        }
        protected void RefreshDataGridViewForm2()
        {
            UpdateDataEventArgs args = new UpdateDataEventArgs();
            UpdateDataEventHandler.Invoke(this, args);
        }
        #endregion

        #region RX Data Format
        private string RxDataFormat(int[] dataInput)
        {
            string strOut = "";

            if(toolStripComboBox_RxDataFormat.Text == "Hex")
            {
                foreach(int element in dataInput)
                {
                    strOut += Convert.ToString(element, 16) + "\t";
                }
            }
            else if (toolStripComboBox_RxDataFormat.Text == "Decimal")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element) + "\t";
                }
            }
            else if (toolStripComboBox_RxDataFormat.Text == "Binary")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element, 2) + "\t";
                }
            }
            else if (toolStripComboBox_RxDataFormat.Text == "Char")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToChar(element);
                }
            }

            return strOut;
        }
        #endregion

        #region TX Data Format
        private void TxDataFormat()
        {
            if(toolStripComboBox_TxDataFormat.Text == "Char")
            {
                //Send the data in the textbox via serial port
                serialPort1.Write(tBoxDataOut.Text);

                //Calculate the length of the data sent and then show it
                int dataOUTLength = tBoxDataOut.TextLength;
                lblDataOutLength.Text = string.Format("{0:00}", dataOUTLength);
            }
            else
            {
                //Declare Local Variable
                string dataOutBuffer;
                int countComma = 0;
                string[] dataPrepareToSend;
                byte[] dataToSend;

                try
                {
                    //Move the data package in the textbox into a variable
                    dataOutBuffer = tBoxDataOut.Text;

                    //Count how much comma (,) punctuation in the data package
                    foreach(char c in dataOutBuffer) { if(c==',') { countComma++; } }

                    //Create one-dimensional array (string data type) with the length based on the countComma
                    dataPrepareToSend = new string[countComma];

                    //Parsing the data in dataOutBuffer and save it into an array dataPrepareToSend based on comma punctuation
                    countComma = 0; //Reset value to 0
                    foreach(char c in dataOutBuffer)
                    {
                        if(c!=',')
                        {
                            //Append the data to array of dataPrepareToSend
                            dataPrepareToSend[countComma] += c;
                        }
                        else
                        {
                            //If a comma finds in the data package, then increase the countComma variable. CountComma is using to determine the index of dataPrepareToSend array
                            countComma++;
                            //Stop foreach process if numbers of countComma equal to the size of dataPrepareToSend
                            if (countComma == dataPrepareToSend.GetLength(0)) { break; }
                        }
                    }

                    //Create one-dimensional array (byte data type) with the length based on the size of dataPrepareToSend
                    dataToSend = new byte[dataPrepareToSend.Length];

                    if (toolStripComboBox_TxDataFormat.Text == "Hex")
                    {
                        //Convert data in string array (dataPrepareToSend) into byte array(dataToSend)
                        for(int a = 0; a<dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 16);
                            //Convert string to an 8-bit unsigned integer with the specified base number
                            //Value 16 mean Hexa
                        }
                    }
                    else if (toolStripComboBox_TxDataFormat.Text == "Binary")
                    {
                        //Convert data in string array (dataPrepareToSend) into byte array(dataToSend)
                        for (int a = 0; a < dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 2);
                            //Convert string to an 8-bit unsigned integer with the specified base number
                            //Value 2 mean Binary
                        }
                    }
                    else if (toolStripComboBox_TxDataFormat.Text == "Decimal")
                    {
                        //Convert data in string array (dataPrepareToSend) into byte array(dataToSend)
                        for (int a = 0; a < dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 10);
                            //Convert string to an 8-bit unsigned integer with the specified base number
                            //Value 10 mean Decimal
                        }
                    }

                    //Send a specified number of bytes to the serial port
                    serialPort1.Write(dataToSend, 0, dataToSend.Length);

                    //Calculate the length of data sent and then show it
                    lblDataOutLength.Text = string.Format("{0:00}", dataToSend.Length);
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        private void TxSendData()
        {
            if (serialPort1.IsOpen)
            {
                //dataOUT = tBoxDataOut.Text;
                if (sendWith == "None")
                {
                    //serialPort1.Write(dataOUT);
                    TxDataFormat();
                }
                else if (sendWith == @"Both (\r\n)")
                {
                    //serialPort1.Write(dataOUT + "\r\n");
                    TxDataFormat();
                    serialPort1.Write("\r\n");
                }
                else if (sendWith == @"New Line (\n)")
                {
                    //serialPort1.Write(dataOUT + "\n");
                    TxDataFormat();
                    serialPort1.Write("\n");
                }
                else if (sendWith == @"Carriage Return (\r)")
                {
                    //serialPort1.Write(dataOUT + "\r");
                    TxDataFormat();
                    serialPort1.Write("\r");
                }
            }
            if (clearToolStripMenuItem.Checked)
            {
                if (tBoxDataOut.Text != "")
                {
                    tBoxDataOut.Text = "";
                }
            }
        }

        #endregion

        #endregion

        #region GUI Method
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = true;
            sendWith = @"Both (\r\n)";
            toolStripComboBox_RxDataPositon.Text = "BOTTOM";
            toolStripComboBox_RxShowDataWith.Text = "Add To Old Data";
            toolStripComboBox_TxEndLine.Text = @"Both (\r\n)";

            toolStripComboBox_appendOrOverwriteText.Text = "Append Text";
            toolStripComboBox_writeLineOrwriteText.Text = "WriteLine";

            pathFile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            saveToTxtFileToolStripMenuItem.Checked = false;
            saveToMySQLDatabeseToolStripMenuItem.Checked = false;

            toolStripComboBox_RxDataFormat.Text = "Char";
            toolStripComboBox_TxDataFormat.Text = "Char";

            this.toolStripComboBox_TxDataFormat.ComboBox.SelectionChangeCommitted += new System.EventHandler(this.toolStripComboBox_TxDataFormat_SelectionChangeCommitted);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            TxSendData();
        }
        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            //None
            //Both
            //New Line
            //Carriage Return

            if (toolStripComboBox_TxEndLine.Text == "None")
            {
                sendWith = "None";
            }
            else if (toolStripComboBox_TxEndLine.Text == @"Both (\r\n)")
            {
                sendWith = @"Both (\r\n)";
            }
            else if (toolStripComboBox_TxEndLine.Text == @"New Line (\n)")
            {
                sendWith = @"New Line (\n)";
            }
            else if (toolStripComboBox_TxEndLine.Text == @"Carriage Return (\r)")
            {
                sendWith = @"Carriage Return (\r)";
            }
        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.DtrEnable = false; }
        }

        private void chBoxRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRtsEnable.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.RtsEnable = false; }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
                if(e.KeyCode == Keys.Enter)
                {
                this.doSomething();
                e.Handled = true;
                e.SuppressKeyPress = true;
                }
        }

        private void doSomething()
        {
            TxSendData();
        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //dataIN = serialPort1.ReadExisting();

            List<int> dataBuffer = new List<int>();

            while(serialPort1.BytesToRead > 0)
            {
                try
                {
                    dataBuffer.Add(serialPort1.ReadByte());
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            dataINLength = dataBuffer.Count();
            dataInDec = new int[dataINLength];
            dataInDec = dataBuffer.ToArray();

            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            //int dataINLength = dataIN.Length;

            dataIN = RxDataFormat(dataInDec);

            lblDataInLength.Text = string.Format("{0.00", dataINLength);

            if(toolStripComboBox_RxShowDataWith.Text == "Always Update")
            {
                tBoxDataIN.Text = dataIN;
            }
            else if(toolStripComboBox_RxShowDataWith.Text == "Add To Old Data")
            {
                if(toolStripComboBox_RxDataPositon.Text == "TOP")
                {
                    tBoxDataIN.Text = tBoxDataIN.Text.Insert(0, dataIN);
                }
                else if(toolStripComboBox_RxDataPositon.Text == "BUTTON")
                {
                    tBoxDataIN.Text += dataIN;
                }             
            }

            SaveDataToTxtFile();
        }

        private void transmitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblDataInLength_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Hasan Deniz GENÇOĞLU", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox12.Width = panel1.Width - 273;
            groupBox12.Height = panel1.Height - 120;

            tBoxDataIN.Height = panel1.Height - 106;


        }

        private void toolStripComboBox_appendOrOverwriteText_DropDownClosed(object sender, EventArgs e)
        {
            if(toolStripComboBox_appendOrOverwriteText.Text == "Append Text")
            {
                state_AppendText = true;
            }
            else
            {
                state_AppendText = false;
            }
        }


        private void showDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2(this);
            objForm2.Show(); 
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 objForm3 = new Form3(this);
            objForm3.Show();
            this.Hide();
        }
        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox_RxDataPositon.Text == "BUTTON")
            {
                tBoxDataIN.SelectionStart = tBoxDataIN.Text.Length;
                tBoxDataIN.ScrollToCaret();
            }
        }
        private void cBoxCOMPORT_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.Clear();
            cBoxCOMPORT.Items.AddRange(ports);
        }

        private void tBoxDataOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (toolStripComboBox_TxDataFormat.Text == "Hex")
            {
                //In Hex format, the textbook only accepts the 0-9 key and A-F key
                //The lower case will convert to the upper case, so both can enter on the textbox
                char uppercase = char.ToUpper(c);

                //if it is not the numbers key pressed, not the backspace key pressed,  not the delete key pressed, not a comma key pressed, not the A-F key pressed
                if (!char.IsDigit(uppercase) && uppercase != 8 && uppercase != 46 && uppercase != ',' && !(uppercase >= 65 && uppercase <= 70))
                {
                    //Cancel the Keypress Event 
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Decimal")
            {
                //In Decimal format, the textbook only accepts the numbers key, that is 0-9

                //if it is not the numbers key pressed, not the backspace key pressed,  not the delete key pressed, not a comma key pressed
                if (!char.IsDigit(c) && c != 8 && c != 46 && c != ',')
                {
                    //Cancel the Keypress Event 
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Binary")
            {
                //In Binary Form, the textbook only take 1 and 0 key

                //if it is not the one (1) key pressed, not the zero (0) key pressed, not the backspace key pressed,  not the delete key pressed, not a comma key pressed
                if (c != 49 && c != 48 && c != 8 && c != 46 && c != ',')
                {
                    //Cancel the Keypress Event 
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Char")
            {
                //Do nothin
            }
        }
        private void toolStripComboBox_TxDataFormat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Every time selected different Tx data format, then delete all contents in the textbox data out
            tBoxDataOut.Clear();

            //Show a message every time I selected different Tx Data Format
            string message = "If you are not using char data format, append the comma (,) after each byte data. Otherwise, the byte data will ignore. \n" +
                "Example :\t255, -> One byte data \n" +
                "\t255, 128, 140, -> Two or more byte data \n" +
                "\t120, 144, 189, -> The 189 will ignore cause has no comma (,)";
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK);
        }
        #endregion

    }
}
