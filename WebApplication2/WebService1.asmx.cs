using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Web.Script.Services;
using System.Web.Script.Serialization;
namespace SaglikGozcusuWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)] // Veriyi Json formatında sakla

        public string HelloWorld()
        {
            return "Merhaba Dünya";
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)] // Veriyi Json formatında sakla

        public string SG_WebService()
        {
            Maddeler[] maddearray = new Maddeler[]
            {
              new Maddeler() 
              { MaddeAdi="Paraben",MaddeAciklamasi="İlaç ve kozmetik sektöründe kullanılan koruyucu bir kimyasal maddedir. 15 Mart 2011 tarihinden itibaren Danimarka, paraben’in bebek ve 3 yaş altı çocuklar için üretilen kozmetik ürünlerinde kullanılmasını yasaklamıştır."},
              new Maddeler()
              { MaddeAdi="Peyniraltı Suyu Tozu",MaddeAciklamasi="Peyniraltı suyu tozu, peynir oluşumu sırasında, çökeltiden süzülerek elde edilen sıvının ısıl işlemlerle toz haline getіrіlmesіnden elde edilir. Gıdaların besin değerini (özellikle protein) zenginleştirmek amacı ile içecek ve yiyecek sanayisinde PAST katkı maddesi olarak kullanılır. Bağışıklık sistemini güçlendirdiği ve prоstat büyümesini еngеllеdiği için, ilaç sanayisinde kullanılır. Kanser beslenmesinde kullanılır. Peynir altı suyu proteіnlerіnіn tamamı antikanserojenik etki göstermektedir ve kemoterapi sırasında PAST alınırsa, kanserli hücrelerin çevresindeki koruyucu tabakayı inceltiyor, sağlıklı hücreleri güçlendiriyor."},
              new Maddeler()
              { MaddeAdi="Phenoxyethanol",MaddeAciklamasi="Deri tahrişine, böbrek ve karaciğer hasarına sebep olabilen koruyucu maddedir."},
              new Maddeler()
              { MaddeAdi="Polidekstroz",MaddeAciklamasi="Polidekstroz düzensiz bir şekilde birbirine bağlanan ve molekül ağırlığı ortalama 2000 olan glikoz polimeridir. Kıvam arttırıcı ve dolgu malzemesi özelliğindedir. Suyu bağlar ve donma tehlikesine karşı korur. 1980’li yıllarda başlayan ticari satışından itibaren, yıllardır düşük kalorili ürünlerde ürünün yapısını bozmadan şekerin ve yağın bir kısmını ikame ederek kalori düşümünü sağlaması amacıyla kullanılmaktadır. Kalori değeri 1 kcal/gr’dır. Şeker ve yağ ile kıyaslandığında büyük bir avantaj oluşturur. Normal kullanım şekliyle bilinen herhangi bir yan etkisi yoktur fakat yüksek dozlarda (90 gramın üstünde) laksatif (ishal) etkisi yaratır."},
              new Maddeler()
              { MaddeAdi="Polysorbate 61",MaddeAciklamasi="Parfüm içerikli emülgatördür. Toksik içeriklidir; üreme sorunları, kanser ve karaciğer rahatsızlıklarına sebep olmaktadır."},
              new Maddeler()
              { MaddeAdi="Propylene Glycol",MaddeAciklamasi="Petrolden elde edilmiş bir maddedir. Sinir sitemine ve bazı hassas organlara zarar verebilmektedir."},
              new Maddeler()
              { MaddeAdi="Sodyum Aljinat",MaddeAciklamasi="Sodyum aljinat, gıda ürünlerinde kıvam arttırıcı olarak kullanılan sodyum aljinat (E401) asit sodyum tuzu olmaktadır. Aljinik asit ise kahve renkli deniz yosununun hücre duvarından elde edilen bir maddedir. Doğal bir selüloz olan bu etken kanda bulunan yağ asitlerinin, safra tuzunun ve şekerin emilimini azaltır. Güvenilir olan bu katkı maddesi pek çok gıdanın içerisinde kullanılmaktadır."},
              new Maddeler()
              { MaddeAdi="Sodium Benzoate",MaddeAciklamasi="Uzun vadede üreme sistemi, karaciğer ve merkezi sinir sistemine zarar verir."},
              new Maddeler()
              { MaddeAdi="Sodyum hidrojen karbonat",MaddeAciklamasi="Sodyum hidrojen karbonat,  kimya sektöründe E500 koduyla anılan bir tür gıda maddesidir. Mide asidini düzenlemek amacıyla da kullanılabilir. Sodyum hidrojen karbonat, doğrudan alındığında ph seviyesini düşürür. Bu nedenle mümkün olduğunca en basit şekilde suyla karıştırılarak alınmalıdır. Sodyum hidrojen karbonat, kek, pasta, ekmek, börek gibi hamur işlerinde yoğun olarak kullanılır. Bu gıdalardaki sodyum hidrojen karbonat vücutta yağ depolanmasına neden olur ve beraberinde kilo alımına yol açar."},
              new Maddeler()
              { MaddeAdi="Sodyum Hidroksit", MaddeAciklamasi="Cilt yanmalarına sebep olur ve kişiyi diğer kimyasallara karşı hassaslaştırır. Yutulursa öldürücüdür. Fırın, kanal ve boruların, tıkanmış lavaboların temizliğinde kullanılır." },
              new Maddeler()
              { MaddeAdi="Sorbitol", MaddeAciklamasi="Elma, kuru erik, kiraz ve üzüm gibi taneli ve tanesiz birçok meyvede bulunan doğal bir karbonhidrat alkolüdür. Yüksek dozda kullanımı laksatif etkiye (ishal) neden olabilmektedir." },
              new Maddeler()
              { MaddeAdi="Soya Lesitini (E322)", MaddeAciklamasi="Vücut içinde lesitin; ana organlar ile arterleri yağ bloklarının oluşmasına karşı korumakta, hücre membranlarını onarmakta, A vitaminin ise bağırsaklar tarafından emilmesine ve karaciğerde yüksek alkol tüketiminden kaynaklanan zedelenmeleri giderilmesine yardımcı olmaktadır. Ayrıca bileşiminde beyin fonksiyonları üzerinde olumlu etkisi olan asetilkolin gibi bileşenler içermektedir." },
            };


            return new JavaScriptSerializer().Serialize(maddearray);
        }




    }
}
