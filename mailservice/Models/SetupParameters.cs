namespace mailservice.Models
{
    public class SetupParameters
    {
        public bool durum { get; set; }
        public string? aciklama { get; set; }
        public Data? data { get; set; }
    }

    public class Data
    {
        public string? TypeId { get; set; }
        public string? ArchivePath { get; set; }
    }

}
