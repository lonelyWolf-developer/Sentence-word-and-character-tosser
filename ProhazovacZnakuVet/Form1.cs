namespace ProhazovacZnakuVet
{
    public partial class Form1 : Form
    {
        private Prohazovac prohazovac; // Instance tøídy Prohazovaè
        public Form1()
        {
            InitializeComponent();
            string cesta = "";
            try // Vytvoøí složku programu v appdata
            {
                cesta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProhazovacZnakuVet");
                if (!Directory.Exists(cesta))
                    Directory.CreateDirectory(cesta);
            }
            catch
            {
                MessageBox.Show("Nepodaøilo se vytvoøit složku" + cesta + ", zkontrolujte prosím svá oprávnìní.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            prohazovac = new Prohazovac(Path.Combine(cesta, "minuleZadani.csv")); // Inicializuje instanci se souborem pro ukládání dat
        }

        // Proháže vìty
        private void button1_Click(object sender, EventArgs e)
        {
            prohazovac.UlozRadky(textBoxZadani.Lines);
            prohazovac.ProhazejVety();
            listBoxVystup.Items.Clear();
            listBoxVystup.Items.AddRange(prohazovac.VratProhazeneRadky());
        }

        // Vypíše data ze souboru
        private void button3_Click(object sender, EventArgs e)
        {
            prohazovac.ProjdiSoubor();
            textBoxZadani.Lines = prohazovac.VratVstup();
            listBoxVystup.Items.Clear();
            listBoxVystup.Items.AddRange(prohazovac.VratVystup());
        }

        // Uloží data do souboru
        private void button2_Click(object sender, EventArgs e)
        {
            prohazovac.UlozDoSouboru();
        }

        // Proháže slova
        private void btnProhazSlova_Click(object sender, EventArgs e)
        {
            prohazovac.UlozRadky(textBoxZadani.Lines);
            prohazovac.ProhazejSlova();
            listBoxVystup.Items.Clear();
            listBoxVystup.Items.AddRange(prohazovac.VratProhazeneRadky());
        }

        // Proháže slova i vìty
        private void btnSlovaVety_Click(object sender, EventArgs e)
        {
            prohazovac.UlozRadky(textBoxZadani.Lines);
            prohazovac.ProhazejVetySlova();
            listBoxVystup.Items.Clear();
            listBoxVystup.Items.AddRange(prohazovac.VratProhazeneRadky());
        }

        // Nahradí znak jiným
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
                MessageBox.Show("Zadej platný znak.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}