
//var degisken = { ad: "Rümeysa", soyad: "Bükecik", yas: 25 };
var x;
//"use strict";
var txt = "";
for (x in degisken) {
    txt += degisken[x] + " ";
}
alert(degisken['ad']);
document.getElementById("demo").innerHTML = txt;


//-----------------------------------------------
class Personel {
    constructer() {
        this.tc = "";
        this.ad = "";
    }

    PersonelBilgiGoster() {
        alert("Personel TC: " + this.tc + " Personel Adi: " + this.ad);
    }
}
function bilgiGoster() {
    var pr1 = new Personel();
    pr1.tc = document.getElementById("input_tc").value;
    pr1.ad = document.getElementById("input_ad").value;
    pr1.PersonelBilgiGoster();
}

function classListele() {
    var siniflar = document.getElementById("classListe").classList;
    var i = 0;
    var txt = "";
    for (i; i < siniflar.length; i++) {
        // liste içinde düzenleme yapılacaksa(sınıf silmek gibi...)
        if (siniflar[i] == 'test1') {
            document.getElementById("classListe").classList.remove('test1');
            i--;
        } else {
            txt = txt + " " + siniflar[i];
        }
        console.log(siniflar);
    }
    //
    document.getElementById("classListe").innerHTML = txt;

}

function dogumYiliKontrol()
{
    var element = document.getElementById("dogumYili").innerHTML;
    while (element < 1900)
    {
        alert("Tarih 1 Asırdan Eski !")
        break;
    }
}

function sayilar() {
    sayi = document.getElementById("input_sayi").value;
    var txt="";
    for(i=0;i<=sayi;i++)
    {
        if(i%3==0)
        {
            txt += " " + i;
        }
    }
    document.getElementById("sayilar").innerHTML=txt;
    
}

function renkdegis()
{
    var renkkodu = document.getElementById("renksecim").value;
    document.getElementById("renq").style.backgroundColor=renkkodu;
}


/*
    Genel Kurallar:
    ---------------
    1  ) CSS Grid özelliği kullanılacak.
    2  ) Her soru maddesi 1 bölüm(section) içerisinde olacak.

    Sorular:
    --------
    1 ) Bölümde: 1 adet input(text), 1 adet(p), 1 adet button olacak.
        Butona tıklandığında text inputtan sayı değeri alınacak.
        0'dan sayıya kadar olan 3'e tam bölünebilen sayılar <p> içine 
        yazdırılacak.

        
*/