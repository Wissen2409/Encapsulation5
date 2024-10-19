using System.Data.Common;

public class Personel
{

    private int id;
    private string name = "Hande";
    private string age;
    private int maas;

    // Property yazarken, set yada get değerlerini kapabiliriz.
    // yani bazen bir property yazarız ve property'nin değerinin değiştirilmemesini isteriz


    // yani set edilemez ancak get edilir bir prop yazabiliriz


    // Bir önceki projede yaptığımız gibi, eğer biz bu properylerde bazı kurallar koymak istersern nasıl yapabiliriz
    // Örnek : Id değeri, min 8 karakter olmalıdır kuralı işletelim
    public int Id
    {
        get { return this.id; }
        set
        {
            // set metodu içerisinde veriyi validasyon yapabiliriz
            // value keyword'ü, dışarıdan bu propery'e atanan değeri taşır!!!
            if (value.ToString().Length == 8)
            {
                this.id = value;
            }
            else{
                throw new ArgumentException("Id değeri kabul edilen aralıklarda değil");
            }

        }
    }
    public string Name
    {
        get { return this.name; }


        // property'i, read only yapabilmek için, set bloğunun önüne private ön ekibini koyabilirsiniz
        // private ifadesinden sonra artık bu prop dışarıdan set edilemez olacaktır(erişim beliteç tarafından korunan bir üye olacaktır)
        private set { this.name = value; }
        // aynı zamanda, set bloğunu tamamen kaldırada biliriz.
        // bu durumdada read only olacaktır
        //private set{this.name=value;}
    }


    public int Maas
    {
        get { return this.maas; }
        set { this.maas = value; }

    }

    // Calculated Property
    // bu yöntemde, property'ler bir field'i koruma altına almaz
    // sadece hesaplanmış değerleri döner!!!
    public double ZamOran
    {
        get { return this.maas * 1.8; }
    }








}