// See https://aka.ms/new-console-template for more information

//ReadyOnly prop

// Örnek : 

// Personel nesnesi içerisindeki Name alanı artık readyonly
// buradan nesne içerisindeki değişkene değer atamaya çalışalom


Personel p = new Personel();
p.Id=4;

// Name isimli prop, set bloğuna private keyword'ü yada tamamen silebilirsiniz bu durumda dışarıdan erişilmeyen ve set edilemeyen bir prop yazmış olursunuz
// bu durumda field'a değer nasıl verilir ? 

// 
p.Name="Selçuk";