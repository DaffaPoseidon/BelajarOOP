using System;

namespace OOPDasar
{
    public class Android{
        public string nama;
        public int tinggiBadan;
        public string warnaRambut;

        public void PerkenalanDiri(){
            Console.WriteLine("Halo! Namaku " +nama+ " tinggiku " +tinggiBadan+ " cm dan warna rambutku adalah " +warnaRambut);
        }
    }

    public class Tales{
        //OOP Dasar dua
        public string nama;
        public int umur;
        public string peran;

        public void Perkenalan(){
            Console.WriteLine("Namaku adalah " +nama+ " umurku " +umur+ " tahun dan peranku " +peran); 
        }
    }

    public class FinalFantasy{
        public string nama;
        public int nomor;
        public string gelar;

        public void Perkenalan(){
            Console.WriteLine("Namaku adalah " +nama+ " aku ada di Final Fantasy ke " +nomor+ " gelarku adalah " +gelar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OOPDasarSatu();
            OOPDasarDua();
            OOPDasarTiga();
        }

        private static void OOPDasarSatu()
        {
            Console.WriteLine($"");

            Android android = new Android();

            android.nama = "YoRHa No. 2 Type B";
            android.tinggiBadan = 168;
            android.warnaRambut = "putih keperakan";

            android.PerkenalanDiri();
            Console.WriteLine($"");
        }
        private static void OOPDasarDua(){
            Tales tales = new Tales();

            tales.nama = "Shionne";
            tales.umur = 19;
            tales.peran = "Healer";

            tales.Perkenalan();
            Console.WriteLine("");
        }
        private static void OOPDasarTiga(){
            FinalFantasy ff = new FinalFantasy();
            ff.nama = "Elidibus";
            ff.nomor = 1;
            ff.gelar = "Warrior of Light";

            ff.Perkenalan();
        }
    }
}
