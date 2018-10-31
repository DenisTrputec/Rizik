using Igraca_ploca.Klase;
using System;
using System.Collections.Generic;
using System.IO;

namespace Rizik.Klase
{
    public static class Statistika
    {
        private static List<HallOfFame> listaIgraca;

        public static void Spremi(Igrac pobjednik, Igrac gubitnik, DateTime vrijemePocetkaPartije)
        {
            if (listaIgraca == null)
                Ucitaj();

            long protekloVrijemeIgre = (DateTime.Now - vrijemePocetkaPartije).Minutes;

            HallOfFame hofPobjednik = new HallOfFame();
            HallOfFame hofGubitnik = new HallOfFame();

            foreach(var hof in listaIgraca)
            {
                if (hof.ImeIgraca == pobjednik.ImeIgraca)
                    hofPobjednik = hof;
                if (hof.ImeIgraca == gubitnik.ImeIgraca)
                    hofGubitnik = hof;
            }

            hofPobjednik.ImeIgraca = pobjednik.ImeIgraca;
            hofPobjednik.BrojOdigranihIgra++;
            hofPobjednik.BrojPobjeda++;
            hofPobjednik.UkupnoVrijemeIgranja += protekloVrijemeIgre;

            hofGubitnik.ImeIgraca = gubitnik.ImeIgraca;
            hofGubitnik.BrojOdigranihIgra++;
            hofGubitnik.UkupnoVrijemeIgranja += protekloVrijemeIgre;

            if (!listaIgraca.Contains(hofPobjednik))
                listaIgraca.Add(hofPobjednik);
            if (!listaIgraca.Contains(hofGubitnik))
                listaIgraca.Add(hofGubitnik);

            string temp = "";
            foreach (var hof in listaIgraca)
                temp += hof.ToString() + Environment.NewLine;
            File.WriteAllText("HOF.txt", temp);
        }

        public static List<HallOfFame> Ucitaj()
        {
            listaIgraca = new List<HallOfFame>();
            string[] zapis;

            try
            {
                zapis = File.ReadAllLines("HOF.txt");
            } catch (Exception)
            {
                return listaIgraca;
            }

            foreach(var linija in zapis)
            {
                var strArray = linija.Split(',');
                HallOfFame hof = new HallOfFame(strArray[0], int.Parse(strArray[1]), int.Parse(strArray[2]), long.Parse(strArray[3]));
                listaIgraca.Add(hof);
            }

            listaIgraca.Sort((prviIgrac, drugiIgrac) => drugiIgrac.BrojPobjeda.CompareTo(prviIgrac.BrojPobjeda));

            return listaIgraca;
        }
    }
}
