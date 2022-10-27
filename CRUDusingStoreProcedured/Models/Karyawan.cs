using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace CRUDusingStoreProcedured.Models
{
    public class Karyawan
    {
        [Key]
        public int NIKId { get; set; } = 0;
        public string Name { get; set; } = "";

        public DateTime TglLahir { get; set; } = DateTime.Now;
        public DateTime TglMasuk { get; set; } = DateTime.Now;
        public string Alamat { get; set; } = "";
    }
}
