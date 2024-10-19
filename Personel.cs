using System.Data.Common;

public class Personel{

    private int id;
    private string name="Hande";
    private string age;

    // Property yazarken, set yada get değerlerini kapabiliriz.
    // yani bazen bir property yazarız ve property'nin değerinin değiştirilmemesini isteriz


    // yani set edilemez ancak get edilir bir prop yazabiliriz
    public int Id{
        get{return this.id;}
        set{this.id=value;}
    }
    public string Name{
        get{return this.name;}


        // property'i, read only yapabilmek için, set bloğunun önüne private ön ekibini koyabilirsiniz
        // private ifadesinden sonra artık bu prop dışarıdan set edilemez olacaktır(erişim beliteç tarafından korunan bir üye olacaktır)
        private set{this.name=value;}
        // aynı zamanda, set bloğunu tamamen kaldırada biliriz.
        // bu durumdada read only olacaktır
        //private set{this.name=value;}
    }

}