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
        bool angkaNegatif = false;

        string tampilan = "";
        string operasi = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void TambahOperasi(string op, string simbol)
        {
            if (setelahSamaDengan)
            {
                angkaSekarang = double.Parse(tampilan);

                daftarAngka.Clear();
                daftarOperasi.Clear();

                setelahSamaDengan = false;
                inputBaru = false;
            }

            // Kalau sedang memasukkan angka negatif,
            // jangan izinkan operator masuk
            if (angkaNegatif)
            {
                return;
            }

            // Kalau sebelumnya sudah menekan operator,
            // ganti operator terakhir
            if (inputBaru)
            {
                if (daftarOperasi.Count > 0)
                {
                    daftarOperasi[daftarOperasi.Count - 1] = op;

                    // Hapus operator terakhir dari tampilan
                    if (tampilan.EndsWith("×") ||
                        tampilan.EndsWith("÷") ||
                        tampilan.EndsWith("+") ||
                        tampilan.EndsWith("-"))
                    {
                        tampilan = tampilan.Substring(0, tampilan.Length - 1);
                    }

                    tampilan += simbol;
                    textBox1.Text = tampilan;

                    return;
                }
            }

            daftarAngka.Add(angkaSekarang);
            daftarOperasi.Add(op);

            tampilan += simbol;
            textBox1.Text = tampilan;

            inputBaru = true;
        }
        

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            TambahOperasi("+", "+");

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
                angkaNegatif = false;
            }

            if (inputBaru && !angkaNegatif)
            {
                angkaSekarang = 0;
                inputBaru = false;
            }

            angkaSekarang = angkaSekarang * 10 + double.Parse(tombol.Text);

            if (angkaNegatif)
            {
                angkaSekarang = -Math.Abs(angkaSekarang);
                angkaNegatif = false;
            }

            tampilan += tombol.Text;

            textBox1.Text = tampilan;

            inputBaru = false;
        }

        private void buttonSamadengan_Click(object sender, EventArgs e)
        {
            if (inputBaru && !angkaNegatif)
            {
                return;
            }

            if (angkaNegatif)
            {
                angkaSekarang = -Math.Abs(angkaSekarang);

                if (tampilan.EndsWith("(-"))
                {
                    tampilan += ")";
                    textBox1.Text = tampilan;
                }

                angkaNegatif = false;
                inputBaru = false;
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
            // Minus di awal = angka negatif
            if (tampilan == "")
            {
                tampilan = "-";
                textBox1.Text = tampilan;

                angkaNegatif = true;
                inputBaru = true;

                return;
            }

            // Kalau sedang setelah operator
            if (inputBaru && daftarOperasi.Count > 0)
            {
                string operasiTerakhir = daftarOperasi[daftarOperasi.Count - 1];

                // Kalau operator terakhir +, ×, ÷
                // lalu tekan - = angka negatif
                if (operasiTerakhir == "+" ||
                    operasiTerakhir == "*" ||
                    operasiTerakhir == "/")
                {
                    tampilan += "(-";
                    textBox1.Text = tampilan;

                    angkaSekarang = 0;
                    angkaNegatif = true;
                    inputBaru = true;

                    return;
                }

                // Kalau operator terakhir -
                // jangan buat (- lagi
                if (operasiTerakhir == "-")
                {
                    tampilan += "(-";
                    textBox1.Text = tampilan;

                    angkaSekarang = 0;
                    angkaNegatif = true;
                    inputBaru = true;

                    return;
                }
            }

            // Minus biasa
            TambahOperasi("-", "-");
        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {
            TambahOperasi("/", "÷");
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {
            TambahOperasi("*", "×");
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
            if (tampilan.Length == 0)
            {
                return;
            }

            // Hapus blok angka negatif: (-3)
            int posisiKurung = tampilan.LastIndexOf("(-");

            if (posisiKurung >= 0)
            {
                // Kalau (-...) adalah bagian paling belakang
                if (tampilan.EndsWith(")") || angkaNegatif)
                {
                    tampilan = tampilan.Substring(0, posisiKurung);

                    angkaSekarang = 0;
                    angkaNegatif = false;
                    inputBaru = true;

                    textBox1.Text = tampilan;
                    return;
                }
            }

            // Hapus angka biasa satu digit
            tampilan = tampilan.Substring(0, tampilan.Length - 1);

            if (angkaSekarang > 0)
            {
                angkaSekarang = Math.Floor(angkaSekarang / 10);
            }

            textBox1.Text = tampilan;
        }
    }
}
