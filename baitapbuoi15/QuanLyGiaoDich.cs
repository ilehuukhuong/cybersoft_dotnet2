using Newtonsoft.Json;

namespace baitapbuoi15
{
    public class QuanLyGiaoDich
    {
        private const string FilePath = "lichsu_giaodich.json";
        public List<GiaoDich> LichSuGiaoDich { get; set; }

        public QuanLyGiaoDich()
        {
            LoadLichSu();
        }

        public void ThemGiaoDich(GiaoDich giaoDich)
        {
            LichSuGiaoDich.Add(giaoDich);
            SaveLichSu();
        }

        private void LoadLichSu()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                LichSuGiaoDich = JsonConvert.DeserializeObject<List<GiaoDich>>(json) ?? new List<GiaoDich>();
            }
            else
            {
                LichSuGiaoDich = new List<GiaoDich>();
            }
        }

        private void SaveLichSu()
        {
            string json = JsonConvert.SerializeObject(LichSuGiaoDich, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public void XemLichSu()
        {
            Console.WriteLine("=== LỊCH SỬ GIAO DỊCH ===");
            foreach (var giaoDich in LichSuGiaoDich)
            {
                Console.WriteLine($"Phương thức: {giaoDich.PhuongThuc}, Số tiền: {giaoDich.SoTien}, Ngày: {giaoDich.NgayGiaoDich}");
            }
        }
    }
}