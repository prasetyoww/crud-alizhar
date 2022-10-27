using CRUDusingStoreProcedured.Models;
using System;
using System.Collections.Generic;

namespace CRUDusingStoreProcedured.Service
{
    public interface iKaryawanService
    {
        List<Karyawan> GetKaryawanList(string name);
        void SaveOrUpdate(Karyawan karyawan);
        void Delete(int nikid);
        List<Karyawan> GetKaryawans(string name);
    }
}
