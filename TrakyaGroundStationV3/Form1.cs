using System;
using System.Globalization;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrakyaGroundStationV3
{
    public partial class Form1 : Form
    {
        private SerialPort mainPort;
        private SerialPort payloadPort;
        private SerialPort hyiPort;
        string fileName = @"C:\Users\samet\Documents\rocketData.txt";

        string dataMainSD;
        string dataPayloadSD;

        private StringBuilder mainBuffer = new StringBuilder();
        private StringBuilder payloadBuffer = new StringBuilder();
        byte[] hyiTransferPacket = new byte[78];
        private string[] mainDizi;
        private string[] payloadDizi;
        public bool stg1 = false;
        public bool stg2 = false;
        private byte sayac = 0x00;
        private bool readyMain = false;
        private bool readyPayload = false;

        public Form1()
        {
            InitializeComponent();
        }
        /* ----------------------------------- SONRADAN EKLENEN FONKSIYONLAR -------------------------------------------- */
        // CheckSum hesaplama fonksiyonu
        private byte CheckSumHesapla()
        {
            int checkSum = 0;

            for (int i = 4; i < 75; i++)
            {
                checkSum += hyiTransferPacket[i];
            }

            return (byte)(checkSum % 256);
        }

        // Float --> byte array dönüþümü
        private void SetFloatToArray(int startIndex, float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            //if (BitConverter.IsLittleEndian)
            //{
            //    Array.Reverse(bytes);
            //}
            int i = 0;

            foreach (byte b in bytes)
            {
                if (i == 4)
                    break;
                hyiTransferPacket[startIndex + i] = b;
                i++;
            }
        }

        // Float parse iþlemi
        private float ParseFloat(string value)
        {
            if (float.TryParse(value, out float result))
            {
                return result;
            }
            else
            {
                throw new FormatException("Geçersiz float deðeri: " + value);
            }
        }

        // CSV kaydetme fonksiyonu
        private void WriteToCsv(string fileName, string[] data)
        {
            // Zaman
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Satýr olarak oluþtur
            string newRow = timestamp + "," + string.Join(",", data);

            // CSV dosyasýna yaz
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(newRow);
            }
        }
        /* ----------------------------------- SONRADAN EKLENEN FONKSIYONLAR -------------------------------------------- */
        private void Form1_Load(object sender, EventArgs e)
        {
            // Mevcut portlarý listele
            mainPortComboBox.Items.AddRange(SerialPort.GetPortNames());
            payloadPortComboBox.Items.AddRange(SerialPort.GetPortNames());
            hyiPortComboBox.Items.AddRange(SerialPort.GetPortNames());

            // Baud rate seçenekleri
            string[] baudRates = { "4800", "9600", "14400", "19200", "38400", "57600", "115200" };
            mainBaudRateComboBox.Items.AddRange(baudRates);
            payloadBaudRateComboBox.Items.AddRange(baudRates);
            hyiBaudRateComboBox.Items.AddRange(baudRates);
        }

        private void mainPortButton_Click(object sender, EventArgs e) // main port connection
        {
            if (mainPort == null || !mainPort.IsOpen)
            {
                mainPort = new SerialPort(mainPortComboBox.Text, int.Parse(mainBaudRateComboBox.Text));
                mainPort.DataReceived += MainPort_DataReceived;
                mainPort.Open();
                mainPortActivePanel.BackColor = System.Drawing.Color.Green;
            }
        }

        private void payloadPortButton_Click(object sender, EventArgs e) // payload port connection
        {
            if (payloadPort == null || !payloadPort.IsOpen)
            {
                payloadPort = new SerialPort(payloadPortComboBox.Text, int.Parse(payloadBaudRateComboBox.Text));
                payloadPort.DataReceived += PayloadPort_DataReceived;
                payloadPort.Open();
                payloadPortActivePanel.BackColor = System.Drawing.Color.Green;
            }
        }

        private void hyiPortButton_Click(object sender, EventArgs e) // hakem yer istasyonu port connection
        {
            if (hyiPort == null || !hyiPort.IsOpen)
            {
                hyiPort = new SerialPort(hyiPortComboBox.Text, int.Parse(hyiBaudRateComboBox.Text));
                hyiPort.Open();
                hyiPortActivePanel.BackColor = System.Drawing.Color.Green;
            }
        }

        private void MainPort_DataReceived(object sender, SerialDataReceivedEventArgs e) // main port data
        {
            string data = mainPort.ReadExisting();
            ProcessMainData(data);
        }

        private void PayloadPort_DataReceived(object sender, SerialDataReceivedEventArgs e) // payload port data
        {
            string data = payloadPort.ReadExisting();
            ProcessPayloadData(data);
        }

        // Main Avionic verisi iþleme
        private void ProcessMainData(string data)
        {
            mainBuffer.Append(data);
            string content = mainBuffer.ToString();



            while (content.Contains("STR") && content.Contains("END"))
            {
                int start = content.IndexOf("STR");
                int end = content.IndexOf("END");

                if (start < end)
                {
                    string validData = content.Substring(start + 4, end - start - 5); // "STR," sonrasý ve "END" öncesi
                    mainBuffer.Remove(0, end + 3);
                    dataPayloadSD = validData;
                    mainDizi = validData.Split(',');

                    // TextBox'lara deðer atama
                    UpdateMainTextBoxes(mainDizi);
                }
                else
                {
                    // Eðer 'END' 'STR'den önce geliyorsa, 'END' karakterine kadar olan kýsmý atla
                    mainBuffer.Remove(0, start);
                }
                content = mainBuffer.ToString();
            }
        }

        // Payload verisi iþleme
        private void ProcessPayloadData(string data)
        {
            payloadBuffer.Append(data);
            string content = payloadBuffer.ToString();

            while (content.Contains("STR") && content.Contains("END"))
            {
                int start = content.IndexOf("STR");
                int end = content.IndexOf("END");

                if (start < end)
                {
                    string validData = content.Substring(start + 4, end - start - 5); // "STR," sonrasý ve "END" öncesi
                    payloadBuffer.Remove(0, end + 3);
                    dataPayloadSD = validData;
                    payloadDizi = validData.Split(',');

                    // TextBox'lara deðer atama
                    UpdatePayloadTextBoxes(payloadDizi);

                }
                else
                {
                    // Eðer end 'STR'den önce geliyorsa, 'END' karakterine kadar olan kýsmý atla
                    payloadBuffer.Remove(0, start);
                }
                content = payloadBuffer.ToString();
            }
        }

        // Ornek Veri -->60.3,345.2,40.325643,39.342545,124.2,153.2,43.2,14.4,23.2,12.3,23.0,2
        // Main textbox guncelleme
        private void UpdateMainTextBoxes(string[] mainDizi)
        {
            if (mainDizi.Length == 12) /* >= 12'ydi */
            {
                Invoke(new Action(() =>
                {
                    mainAltitudeTextBox.Text = mainDizi[0];
                    mainGPSAltitudeTextBox.Text = mainDizi[1];
                    mainLatitudeTextBox.Text = mainDizi[2];
                    mainLongtitudeTextBox.Text = mainDizi[3];
                    mainGyroXTextBox.Text = mainDizi[4];
                    mainGyroYTextBox.Text = mainDizi[5];
                    mainGyroZTextBox.Text = mainDizi[6];
                    mainAccelXTextBox.Text = mainDizi[7];
                    mainAccelYTextBox.Text = mainDizi[8];
                    mainAccelZTextBox.Text = mainDizi[9];
                    mainAngelTextBox.Text = mainDizi[10];
                    if(byte.Parse(mainDizi[11]) == 2 && byte.Parse(mainDizi[11]) == 4)
                    {
                        stage1Label.BackColor = System.Drawing.Color.Green;
                    }
                    if(byte.Parse(mainDizi[11]) == 3 && byte.Parse(mainDizi[11]) == 4)
                    {
                        stage2Label.BackColor = System.Drawing.Color.Green;
                    }
                    //mainStateLabel.Text = mainDizi[11];
                }));
                // `hyiTransferPacket` dizisini güncelleyin
                hyiTransferPacket[0] = 0xFF;
                hyiTransferPacket[1] = 0xFF;
                hyiTransferPacket[2] = 0x54;
                hyiTransferPacket[3] = 0x52;
                hyiTransferPacket[4] = 0x83;
                //hyiTransferPacket[5] = sayac; bunu da burdan aldik

                SetFloatToArray(6, float.Parse(mainDizi[0], CultureInfo.InvariantCulture));
                SetFloatToArray(10, float.Parse(mainDizi[1], CultureInfo.InvariantCulture));
                SetFloatToArray(14, float.Parse(mainDizi[2], CultureInfo.InvariantCulture));
                SetFloatToArray(18, float.Parse(mainDizi[3], CultureInfo.InvariantCulture));
                SetFloatToArray(34, 0.0f);
                SetFloatToArray(38, 0.0f);
                SetFloatToArray(42, 0.0f);
                SetFloatToArray(46, float.Parse(mainDizi[4], CultureInfo.InvariantCulture));
                SetFloatToArray(50, float.Parse(mainDizi[5], CultureInfo.InvariantCulture));
                SetFloatToArray(54, float.Parse(mainDizi[6], CultureInfo.InvariantCulture));
                SetFloatToArray(58, float.Parse(mainDizi[7], CultureInfo.InvariantCulture));
                SetFloatToArray(62, float.Parse(mainDizi[8], CultureInfo.InvariantCulture));
                SetFloatToArray(66, float.Parse(mainDizi[9], CultureInfo.InvariantCulture));
                SetFloatToArray(70, float.Parse(mainDizi[10], CultureInfo.InvariantCulture));

                hyiTransferPacket[74] = byte.Parse(mainDizi[11]);
                switch(hyiTransferPacket[74])
                { 
                    case 1:
                        panel1.BackColor = Color.Red;
                        panel2.BackColor = Color.Red;
                        break;
                    case 2:
                        panel1.BackColor = Color.Green;
                        panel2.BackColor = Color.Red;
                        break;
                    case 3:
                        panel1.BackColor = Color.Red;
                        panel2.BackColor = Color.Green;
                        break;
                     case 4:
                        panel1.BackColor = Color.Green;
                        panel2.BackColor = Color.Green;
                        break;

                }
                //hyiTransferPacket[75] = CheckSumHesapla(); buradan aldik bunu
                hyiTransferPacket[76] = 0x0D;
                hyiTransferPacket[77] = 0x0A;
                readyMain = true;
                SendDataToHyiPort();
                
            }
        }

        // Payload textbox güncelleme iþlemi
        private void UpdatePayloadTextBoxes(string[] payloadDizi)
        {
            if (payloadDizi.Length == 6) /* >= 7'ydi*/
            {
                Invoke(new Action(() =>
                {
                    payloadAltitudeTextBox.Text = payloadDizi[0];
                    payloadGPSAltitudeTextBox.Text = payloadDizi[1];
                    payloadLatitudeTextBox.Text = payloadDizi[2];
                    payloadLongtitudeTextBox.Text = payloadDizi[3];
                    payloadTemperatureTextBox.Text = payloadDizi[4];
                    payloadHumidityTextBox.Text = payloadDizi[5];
                }));
                SetFloatToArray(22, float.Parse(payloadDizi[1], CultureInfo.InvariantCulture));
                SetFloatToArray(26, float.Parse(payloadDizi[2], CultureInfo.InvariantCulture));
                SetFloatToArray(30, float.Parse(payloadDizi[3], CultureInfo.InvariantCulture));
                readyPayload = true;
                SendDataToHyiPort();
                
            }
        }

        // hakem yer istasyonu veri gönderme iþlemi
        private void SendDataToHyiPort()
        {
            if (mainDizi != null && payloadDizi != null && hyiPort != null)
            {
                if (sayac == 0xFF)
                    sayac = 0;
                sayac++;
                hyiTransferPacket[5] = sayac;
                hyiTransferPacket[75] = CheckSumHesapla();
                hyiPort.Write(hyiTransferPacket, 0, hyiTransferPacket.Length);

                //Array.Clear(hyiTransferPacket, 0, hyiTransferPacket.Length);
                readyPayload = false;
                readyMain = false;
                //string[] hyiDizi = new string[mainDizi.Length + payloadDizi.Length];
                //mainDizi.CopyTo(hyiDizi, 0);
                //payloadDizi.CopyTo(hyiDizi, mainDizi.Length);

                //string dataToSend = "{" + string.Join("},{", hyiDizi) + "}";
                //hyiPort.Write(dataToSend);
            }
        }

        private void SendDataToSDCard()
        {
            //Log kayýt kýsmý
            try
            {

                // Masaüstü yolunu alýyoruz
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // log.txt dosyasýnýn yolunu belirliyoruz
                string logFilePath = Path.Combine(desktopPath, "rocketData.txt");

                // Veriyi dosyaya yazýyoruz (append modunda, yani ekleyerek)
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now} - MAIN: {dataMainSD}"); // Veriyi ve zaman bilgisini yaz
                    writer.WriteLine($"{DateTime.Now} - PAYLOAD: {dataPayloadSD}"); // Veriyi ve zaman bilgisini yaz

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yazýlýrken bir hata oluþtu: " + ex.Message);
            }
            //Log kayýt kýsmý
        }
    }
}
