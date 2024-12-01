using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
/*
 Entity'e özgü olmayan metotlar:
 Ekle, sil, güncelle, listele ve Id'ye göre getir
 //içinde a harfi geçmeyen kullanıcıları listele => Entity'e özgü
 */
