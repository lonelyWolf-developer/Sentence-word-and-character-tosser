namespace ProhazovacZnakuVet
{
    public partial class Form1 : Form
    {
        private Prohazovac prohazovac; // Instance t��dy Prohazova�
        public Form1()
        {
            InitializeComponent();
            string cesta = "";
            try // Vytvo�� slo�ku programu v appdata
            {
                cesta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProhazovacZnakuVet");
                if (!Directory.Exists(cesta))
                    Directory.CreateDirectory(cesta);
            }
            catch
            {
                MessageBox.Show("Nepoda�ilo se vytvo�it slo�ku" + cesta + ", zkontrolujte pros�m sv� opr�vn�n�.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            prohazovac = new Prohazovac(Path.Combine(cesta, "minuleZadani.csv")); // Inicializuje instanci se souborem pro ukl�d�n� dat
        }

        // Proh�e v�ty
        private void button1_Click(object sender, EventArgs e)
        {
            prohazovac.UlozRadky(textBoxZadani.Lines);
            prohazovac.ProhazejVety();
            listBoxVystup.Items.Clear();
            listBoxVystup.Items.AddRange(prohazovac.VratProhazeneRadky());
        }

        // Vyp�e data ze souboru
        private void button3_Click(object sender, EventArgs e)
        {
            prohazovac.ProjdiSoubor();
            textBoxZadani.Lines = prohazovac.VratVstup();
            listBoxVystup.Items.Clear();
            listBoxVystup.Items.AddRange(prohazovac.VratVystup());
        }

        // Ulo�� data do souboru
        private void button2_Click(object sender, EventArgs e)
        {
            prohazovac.UlozDoSouboru();
        }

        // Proh�e slova
        private void btnProhazSlova_Click(object sender, EventArgs e)
        {
            prohazovac.UlozRadky(textBoxZadani.Lines);
            prohazovac.ProhazejSlova();
            listBoxVystup.Items.Clear();
            listBoxVystup.Items.AddRange(prohazovac.VratProhazeneRadky());
        }

        // Proh�e slova i v�ty
        private void btnSlovaVety_Click(object sender, EventArgs e)
        {
            prohazovac.UlozRadky(textBoxZadani.Lines);
            prohazovac.ProhazejVetySlova();
            listBoxVystup.Items.Clear();
            listBoxVystup.Items.AddRange(prohazovac.VratProhazeneRadky());
        }

        // Nahrad� znak jin�m
        private void btnNahrad_Click(object sender, EventArgs e)
        {
            try
            {
                prohazovac.UlozRadky(textBoxZadani.Lines);
                prohazovac.NahradZnak(tBZnakVstup.Text, tBZnakVystup.Text);
                listBoxVystup.Items.Clear();
                listBoxVystup.Items.AddRange(prohazovac.VratProhazeneRadky());
            }
            catch
            {
                MessageBox.Show("Zadej platn� znak.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}