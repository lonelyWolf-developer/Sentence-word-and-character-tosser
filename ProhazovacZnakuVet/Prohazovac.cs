using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProhazovacZnakuVet
{
    // Třída reprezentuje prohazovač vět, slov a znaků
    internal class Prohazovac
    {
        private List<string> radky; // Do kolekce se uloží vstup od uživatele
        private List<string> radkyProhazene; // Do kolekce se uloží upravený text
        private List<string> vstupZeSouboru; // Do kolekce se uloží vstupní data ze souboru
        private List<string> vystupZeSouboru; // Do kolekce se uloží výstupní data ze souboru
        
        private Random generator; // Generátor náhodných čísel

        private string soubor; // Název souboru
        
        // Vytvoří instanci třídy Prohazovač
        public Prohazovac(string soubor)
        {
            radky = new List<string>();
            radkyProhazene = new List<string>();
            vstupZeSouboru = new List<string>();
            vystupZeSouboru = new List<string>();

            generator = new Random();

            this.soubor = soubor;
        }

        // Vygeneruje náhodné pořadí prvků v kolekci
        private void Znahodnuj(List<string> vstup, List<string> vystup)
        {
            IEnumerable<int> sekvence = Enumerable.Range(0, vstup.Count);
            List<int> indexy = sekvence.ToList();            

            for (int i = 0; i < vstup.Count; i++)
            {
                int index = generator.Next(0, indexy.Count);
                vystup.Add(vstup[indexy[index]]);
                indexy.RemoveAt(index);
            }
        }

        // Proháže věty v náhodném pořadí
        public void ProhazejVety()
        {           
            radkyProhazene.Clear();
            Znahodnuj(radky, radkyProhazene);                      
        }

        // Proháže slova v náhodném pořadí
        public void ProhazejSlova()
        {
            radkyProhazene.Clear();
            
            for(int i = 0; i < radky.Count; i++)
            {
                string[] splitovane = radky[i].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                List<string> vystup = new List<string>();

                Znahodnuj(splitovane.ToList(), vystup);

                string s = String.Join(" ", vystup);
                radkyProhazene.Add(s);
            }
        }

        // Proháže věty i slova v náhodném pořadí
        public void ProhazejVetySlova()
        {
            radkyProhazene.Clear();
            Znahodnuj(radky, radkyProhazene);

            List<string> mezikolekce = new List<string>();
            mezikolekce.AddRange(radkyProhazene);
            radkyProhazene.Clear();

            for (int i = 0; i < mezikolekce.Count; i++)
            {
                string[] splitovane = mezikolekce[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<string> vystup = new List<string>();

                Znahodnuj(splitovane.ToList(), vystup);

                string s = String.Join(" ", vystup);
                radkyProhazene.Add(s);
            }

        }

        // Nahradí určitý znak jiným
        public void NahradZnak(string vstup, string vystup)
        {
            radkyProhazene.Clear();
            foreach(string s in radky)
            {
                string nahrazeno;
                nahrazeno = s.Replace(vstup, vystup);
                radkyProhazene.Add(nahrazeno);
            }
        }

        // Uloží pole do interní kolekce
        public void UlozRadky(string[] vstup)
        {
            radky.Clear();
            radky.AddRange(vstup);
        }

        // Uloží obě interní kolekce do souboru
        public void UlozDoSouboru()
        {
            using(StreamWriter zapisovac = new StreamWriter(soubor))
            {
                if(radky.Count == radkyProhazene.Count)
                {
                    for(int i = 0; i < radky.Count; i++)
                    {
                        zapisovac.WriteLine(radky[i] + ";" + radkyProhazene[i]);
                    }
                    zapisovac.Flush();
                }
            }
            
        }
        
        // Projde soubor a data uloží do interních kolekcí
        public void ProjdiSoubor()
        {
            using(StreamReader ctenar = new StreamReader(soubor))
            {
                string s = "";
                
                vstupZeSouboru.Clear();
                vystupZeSouboru.Clear();
                
                while(!ctenar.EndOfStream)
                {                    
                    s = ctenar.ReadLine();
                    string[] nadelene = s.Split(";");                   

                    vstupZeSouboru.Add(nadelene[0]);
                    vystupZeSouboru.Add(nadelene[1]);
                }
            }
        }

        // Navrátí vstupní data ze souboru
        public string[] VratVstup()
        {            
            return vstupZeSouboru.ToArray();
        }

        // Navrátí výstupní data ze souboru
        public string[] VratVystup()
        {            
            return vystupZeSouboru.ToArray();
        }

        // Navrátí proházené řádky
        public string[] VratProhazeneRadky()
        {
            return radkyProhazene.ToArray();
        }

    }
}
