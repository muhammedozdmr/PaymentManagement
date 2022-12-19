using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuvenliAlımSatım
{
    public class Basvuru
    {
        public int Id { get; set; }
        public int ReferansKod { get; set; }
        public int GercekTuzel_IdSatici { get; set; }
        public int? GercekTuzel_IdAlici { get; set; }
        public string TCKimlikSatici { get; set; }
        public string SaticiAdSoyad { get; set; }
        public string SaticiCep { get; set; }
        public string SaticiEPosta { get; set; }
        public string SaticiIBAN { get; set; }
        public string? TCKimlikAlici { get; set; }
        public string? AliciAdSoyad { get; set; }
        public string? AliciCep { get; set; }
        public string? AliciEPosta { get; set; }
        public string AracPlaka { get; set; }
        public decimal SatisTutari { get; set; }
        public int? OdemeBanka_Id { get; set; }
        public bool? OdemeDurum { get; set; }
        public double? Masraf { get; set; }
        public bool IptalDurum { get; set; }
        public string? IptalNedeni { get; set; }
        public DateTime SaticiBasvuruTarih { get; set; }
        public DateTime? AliciBasvuruTarih { get; set; }
        public bool RizaMetni { get; set; }
        public bool? ReklamMetni { get; set; }
    }
}
