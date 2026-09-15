using System.Reflection.Emit;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double hasil = 0;
        double angkaSekarang = 0;

        double angkaSebelumnya = 0;
        List<double> daftarAngka = new List<double>();
        List<string> daftarOperasi = new List<string>();
        bool setelahSamaDengan = false;
        bool inputBaru = false;

        string tampilan = "";
        string operasi = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Hitung()
        {
            if (operasi == "+")
            {
                hasil += angkaSekarang;
            }
            else if (operasi == "-")
            {
                hasil -= angkaSekarang;
            }
            else if (operasi == "*")
            {
                hasil *= angkaSekarang;
            }
            else if (operasi == "/")
            {
                hasil /= angkaSekarang;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            daftarAngka.Add(angkaSekarang);
            daftarOperasi.Add("+");

            tampilan += "+";
            textBox1.Text = tampilan;

            inputBaru = true;
            setelahSamaDengan = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Angka_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (setelahSamaDengan)
            {
                daftarAngka.Clear();
                daftarOperasi.Clear();

                hasil = 0;
                angkaSekarang = 0;
                tampilan = "";

                setelahSamaDengan = false;
            }

            if (inputBaru)
            {
                angkaSekarang = 0;
                inputBaru = false;
            }

            angkaSekarang = angkaSekarang * 10 + double.Parse(tombol.Text);

            tampilan += tombol.Text;
            textBox1.Text = tampilan;
        }

        private void buttonSamadengan_Click(object sender, EventArgs e)
        {
            if (inputBaru)
            {
                return;
            }

            daftarAngka.Add(angkaSekarang);

            // Kerjakan * dan / terlebih dahulu
            for (int i = 0; i < daftarOperasi.Count; i++)
            {
                if (daftarOperasi[i] == "*")
                {
                    daftarAngka[i] = daftarAngka[i] * daftarAngka[i + 1];

                    daftarAngka.RemoveAt(i + 1);
                    daftarOperasi.RemoveAt(i);

                    i--;
                }
                else if (daftarOperasi[i] == "/")
                {
                    daftarAngka[i] = daftarAngka[i] / daftarAngka[i + 1];

                    daftarAngka.RemoveAt(i + 1);
                    daftarOperasi.RemoveAt(i);

                    i--;
                }
            }

            // Setelah * dan / selesai, kerjakan + dan -
            hasil = daftarAngka[0];

            for (int i = 0; i < daftarOperasi.Count; i++)
            {
                if (daftarOperasi[i] == "+")
                {
                    hasil += daftarAngka[i + 1];
                }
                else if (daftarOperasi[i] == "-")
                {
                    hasil -= daftarAngka[i + 1];
                }
            }

            textBox1.Text = hasil.ToString();
            tampilan = hasil.ToString();

            daftarAngka.Clear();
            daftarOperasi.Clear();

            angkaSekarang = 0;
            hasil = 0;

            inputBaru = true;
            setelahSamaDengan = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            daftarAngka.Add(angkaSekarang);
            daftarOperasi.Add("-");

            tampilan += "-";
            textBox1.Text = tampilan;

            inputBaru = true;
            setelahSamaDengan = false;
        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {
            daftarAngka.Add(angkaSekarang);
            daftarOperasi.Add("/");

            tampilan += "÷";
            textBox1.Text = tampilan;

            inputBaru = true;
            setelahSamaDengan = false;
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {
            daftarAngka.Add(angkaSekarang);
            daftarOperasi.Add("*");

            tampilan += "×";
            textBox1.Text = tampilan;

            inputBaru = true;
            setelahSamaDengan = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            hasil = 0;
            angkaSekarang = 0;
            angkaSebelumnya = 0;

            daftarAngka.Clear();
            daftarOperasi.Clear();

            tampilan = "";
            operasi = "";

            inputBaru = false;
            setelahSamaDengan = false;

            textBox1.Text = "0";
        }

        private void buttonTrash_Click(object sender, EventArgs e)
        {
            if (tampilan.Length > 0)
            {
                tampilan = tampilan.Substring(0, tampilan.Length - 1);

                textBox1.Text = tampilan;

                if (angkaSekarang > 0)
                {
                    angkaSekarang = Math.Floor(angkaSekarang / 10);
                }
            }
        }
    }
}
