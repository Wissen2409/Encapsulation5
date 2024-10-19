// See https://aka.ms/new-console-template for more information

//ReadyOnly prop

// Örnek : 

// Personel nesnesi içerisindeki Name alanı artık readyonly
// buradan nesne içerisindeki değişkene değer atamaya çalışalom


Personel p = new Personel();

try
{
    p.Id = 4;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


// Name isimli prop, set bloğuna private keyword'ü yada tamamen silebilirsiniz bu durumda dışarıdan erişilmeyen ve set edilemeyen bir prop yazmış olursunuz
// bu durumda field'a değer nasıl verilir ? 

// böyle durumlarda fieldlar genelde dış dünyadan değer almazlar, ya bir hesapma sonucu değer ortaya çıkar
// yada sınıf içerisinde field yazılırken değer direk elle, hard coded şekilde verilir.!!
//p.Name="Selçuk";

