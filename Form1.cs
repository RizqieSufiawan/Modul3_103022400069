using Microsoft.VisualBasic;
namespace Modul3_103022400069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
            
        private void Form1_Load(object sender, EventArgs e)
        {   
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            if(!double.TryParse(textBox1.Text, out double inputSuhu))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string satuanAwal = comboBox1.SelectedItem.ToString();
            string satuanAkhir = comboBox2.SelectedItem.ToString();

            double suhu = 0;

            if (satuanAwal == "Celcius")
                suhu = inputSuhu;
            else if (satuanAwal == "Fahrenheit")
                suhu = (inputSuhu - 32) * 5 / 9;
            else if (satuanAwal == "Kelvin")
                suhu = inputSuhu - 273;
            else if (satuanAwal == "Reamur")
                suhu = inputSuhu * 5 / 4;

            double hasil = 0;

            if (satuanAkhir == "Celcius")
                hasil = suhu;
            else if (satuanAkhir == "Fahrenheit")
                hasil = (suhu * 9 / 5) + 32;
            else if (satuanAkhir == "Kelvin")
                hasil = suhu + 273;
            else if (satuanAkhir == "Reamur")
                hasil = suhu * 4 / 5;

            textBox2.Text = Math.Round(hasil, 4).ToString();
        }
    }
}