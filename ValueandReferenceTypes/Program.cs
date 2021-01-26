using System;

namespace ValueandReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 40;
            // number1 = 30 olur


            int[] sayılar1 = new int[] { 1, 2, 3, 4 };
            int[] sayılar2 = new int[] { 100, 200, 300, 400 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            // sayılar1[0] = 999 olur


            // int decimal float double bool = Value type olurlar(sayısal tip)
            // array[] class interface = Reference type olurlar(liste tip)

//          Stack:                                 Heap:
//          Value type                             int ile sayılar1 verisi oluşurken  
//         burada tutulur                         new dendiği anda "sayılar1 için [1 2 3 4]     
//        sayı1'in değeri 10'dur                  şeklinde liste oluşturur             
//        sayı1'in DEĞERİ sayı2'dir=30             sayılar1 ile sayılar2 eşitlendiğinde artık                   
//        sayı2'in değeri 40 olur ancak,          sayılar1 [100 200 300 400 ] olur ve bundan 1.elemanı                     
//        sayı1'in değeri değişmez                değiştirince sayılar1[999 200 300 400] olur
//                                                 Bu işlem new sayesinde bellekte adres oluşturmasıyla olur
//                                                yani sayılar1 ve sayılar2 için referans numarası oluşturur
//                                                Biz de sayılar2'in referans numarasıyla sayılar1'in numarasını değiştirince
//                                                otomatik olarak listedeki numaralar da değişiyor
        }  
    }
}
