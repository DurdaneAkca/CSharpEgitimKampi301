using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}


/*
 Field-Variable-Property
 */
/*
Eğer bir değişken (int x) direkt olarak sınıfın içine tanımlanırsa bu bir Field olarak karşılar.
int x; --> Field
Eğer değişken yapısı sonuna get ve set diye iki değişken alırsa Property olur.
puplic int y { get; set; }
Eğer bir değer metot içinde tanımlanırsa Variable (değişken) olur.
void test()
{
    int z;
}
public int MyProperty { get; set; } --> MyProperty sınırlandırılabilir. Burada get (almak) set(ayarlamak) kullanılabilir.
 */
