
// JavaScript source code
class Personel {
    constructor() {
        this.tc = "";
        this.ad = "";
    }
    PersonelBilgiGoster() {
        alert("Personel TC:" + this.tc + "Personel Adı:" + this.ad);
    }
}
function bilgiGoster() {
    var pr1 = new Personel();
    pr1.tc = document.getElementById("input_tc").value;
    pr1.ad = document.getElementById("input_ad").value;
    pr1.PersonelBilgiGoster();
}


function classListele()
{
    var siniflar = document.getElementById("classListe").classList;
    var i = 0;
    var txt = "";
    for(i;i<siniflar.length;i++)
    {//liste içinde düzenleme yapıalcaksa(sinif silmek gibi...)
        if (siniflar[i] == 'test1') {
            var siniflar = document.getElementById("classListe").classList.remove('test1');
            i--;
        }
        else
        {
            txt = txt + " " + siniflar[i];
        }

    }

    document.getElementById("classListe").innerHTML = txt;

    
}