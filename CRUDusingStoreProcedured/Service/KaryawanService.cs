using CRUDusingStoreProcedured.Context;
using CRUDusingStoreProcedured.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDusingStoreProcedured.Service
{
    public class KaryawanService : iKaryawanService
    {
        DatabaseContext _dbContext = null;
        public KaryawanService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(int NIKId)
        {
            _dbContext.Database.ExecuteSqlRaw($"DeleteKaryawan {NIKId}");
            //Test
            var karyawans = _dbContext.Karyawans.ToList();
        }

        public List<Karyawan> GetKaryawanList(string name)
        {
            var karyawans = _dbContext.Karyawans.FromSqlRaw($"GetKaryawans{name}").ToList();
            return karyawans;
        }

        public List<Karyawan> GetKaryawans(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(Karyawan karyawan)
        {
            _dbContext.Database.ExecuteSqlRaw($"SaveOrUpdateKaryawan {karyawan.NIKId}, {karyawan.Name}, {karyawan.TglLahir}. {karyawan.TglMasuk}, {karyawan.Alamat}");

            //Test
            var karyawans = _dbContext.Karyawans.ToList();
        }
    }
}
