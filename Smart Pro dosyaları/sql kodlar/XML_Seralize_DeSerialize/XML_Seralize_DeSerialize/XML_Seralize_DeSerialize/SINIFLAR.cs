using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Seralize_DeSerialize
{
     public class yemeklistesi
     {
          public string baslik;
          //public menu menu1;
          public List<menu> menuList;
     }

     [Serializable]
     public class menu
     {
          [XmlAttribute]
          public string menuAdi;

          public string corba;
          public string anayemek;
          public string tatli;
     }
     













     class SINIFLAR
     {
     }

}
