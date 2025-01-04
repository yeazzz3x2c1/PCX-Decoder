using System.IO;
using System.Windows.Forms;

namespace PCX_Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += delegate
            {
                while (true)
                {
                    OpenFileDialog f = new OpenFileDialog();
                    f.Filter = "PCX檔案|*.pcx";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        FileStream stream = new FileStream(f.FileName, FileMode.Open);
                        byte[] data = new byte[stream.Length];
                        stream.Read(data, 0, data.Length);
                        stream.Close();
                        PCX_Decoded_Object decoded = PCX_Decoder.Decode(data);
                        if (decoded == null)
                            MessageBox.Show("無法解碼該影像，請選擇另一個PCX檔案");
                        else
                        {
                            pictureBox1.Image = decoded.Get_Result();
                            break;
                        }
                    }
                    MessageBox.Show("請開啟一個PCX檔案");
                }
            };
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}