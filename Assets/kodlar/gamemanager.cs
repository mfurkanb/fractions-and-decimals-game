using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gamemanager : MonoBehaviour
{
    string[] yazılar = {
        "Selam, Ben Deniz. Seninle güzel bir yolculuğa çıkacağız bu yüzden seni tanımak isterim. İsmini benimle paylaşır mısın?",
        "", //input aldık
        "", // adını kullandık
        "Başlamadan önce seni mutfağımızın önemli bir üyesi ile tanıştıracağım. Bu gördüğün mutfak robotu. Birçok görevde yardımcın o olacak.",
        "Haydi bakalım ilk göreve! İlk olarak restorana gelen malları tartarak kayıt etmemiz gerekiyor fakat bu işlemi baş şefin istediği gibi yapmalıyız.",
        "Baş şef çok titiz ve malları tek tek kayıt ediyor. Sende onun gibi tartılan malların okunuşunu deftere kayıt etmelisin!", // 5
        "İlk ürün patates ve 3.2 gram gelmiş.  Baş şefin kurallarına göre okunuşu noktalı yere yazıp deftere de kayıt etmelisin. Ama önce işlemi mutfak robotumuz ile analiz etmeliyiz",
        "Patatesi mutfak robotuna sürükleyip ve analize yardım eder misin?",
        "Şimdi ise patatesin ağırlığını noktalı yerlere yazıp deftere de kayıt etmelisin. Haydi devam et!",
        "Patates toplam 3.2kg gelmiş. Şimdi bunu nasıl okuduğumuzu analiz edelim. Lütfen aşağıda verilen elemanları noktalı yerlere yazar mısın?",
        "Bravo haydi bir sonraki ürüne geçelim :)", //10
        "Sıradaki ürün soğan. Önce tartıda yazan ondalık gösterimin okunuşunu noktalı yere yaz ardından deftere kayıt et. Ama önce analiz etmeliyiz.\n",
        "Soğan toplam 1.35kg gelmiş. Şimdi bunu nasıl okuduğumuzu analiz edelim. Analiz etmek için soğanı robotun üstüne bırak.",
        "Soğan toplam 1.35kg gelmişti. Lütfen aşağıda verilen elemanları noktalı yerlere doğru sırayla yerleştirir misin?",
        "Tebrik ederim, başarılı gidiyorsun. Bir sonraki ürüne geçelim haydi",
        "Sıradaki ürünümüz elma ancak bir sorun var. Elmalar 4.758 kg olarak ölçüldü ancak mutfak robotunun şarjı bittiği için sıradaki ürünü analiz etmeden yapmalısın.\n", //15
        "Bravo! Harika bir iş başardın.\n",
        "Şimdiki görevimiz kek yapmak fakat şefimizin tarifine uygun bir kek yapmalıyız. Bunun için bazı ölçüler var. Bu ölçüleri ayarlamak için terazi kullanmalıyız. Tartıdaki yüke uygun ürünü tartının diğer ucuna sürükle ve not et.",
        "",
        "Evet X! Buradaki eğitimin tam 100 gün sürecek her günü işaretlemen için bir tablo vereceğim sana.",
        "Bu senin tablon. \n", // 20
        "Tabloyu kullanmayı öğrenmen için diğer çalışanımızın örnek tablosunu gözlemleyip notlarını okumalısın ve sorulara cevap vermelisin.\n",
        "Diğer arkadaşının tablosunu ve notlarını görmek için devam et\n",
        "",
        "",
        "Sen toplamda 8 gün çalıştın artık tablonda işaretleyip not defterine kaydedebilirsin.\n", //25
        "Bravoo. Sıradaki görevimiz için seni bir makine ile tanıştıracağım. \n",
        "Bu makinenin ismi \"ekle-sil\" Peki ne işe yarıyor bu makine hemen bahsedelim.\n",
        "Sunduğumuz yiyecekleri yaparken tariflere uymak zorundayız ve bazı tariflerdeki ürünlerin tam miktarını çıkarmak için ekleme yada çıkarma yapmalıyız. " +
            "İşte bu makine bu göreve yardımcı oluyor\n",
        "Görevin ilk aşamasında kalan yiyecekleri bir araya getirmemiz yani toplamamız gerekiyor.",
        "Önce makinenin kurallarına göz at sonra ürünleri sürükleyerek makineyi kullanabiliriz.", // 30
        "",
        "Bravo. Şimdi ise malzemeleri yapılacak yemeklere göre eksiltmemiz gerekiyor. Haydi devam et!",
        "Şimdi 4 kg mercimekten 2.15 kilogramını kullanmayacağımız için ayıracağız. Ben senin yerine makinenin sonuçlarına baktım. " +
            "Mercimekteki fazlalığı almamız için ekrandaki işlemi yapmamız gerek.",
        "Çok iyi ilerliyorsun. Şimdi seni mutfağımızın önemli bir diğer üyesi ile tanıştıracağım. Bu gördüğün bizim mutfağımıza özel büyük bir oklava.",
        "Bu oklavanın e önemli özelliği ise üzerinde sayı doğrusundaki tüm sayıları barındırmasıdır.", // 35
        "Mutfak robotumuz burada da bize yardımcı olacak. Buradaki görevi ise istediğimiz uzunlukta malzemeler yapabilmesi olacak.",
        "Sıradaki görevin miktarı verilen ürünleri robot ile yapıp bunları oklava üzerinde karşılaştırmak.",
        "İlk olarak 2.7 daha sonra 2.4 ve 2.6 uzunluklarında ekmek yapman gerekiyor. Ardından büyüklük ve küçüklüklerini de oklava üzerinde karşılaştırmalısın.",
        "Haydi robotumuzdan yardım isteyelim.",
        "Şimdi büyüklük ve küçüklüklerini de oklava üzerinde karşılaştırmalısın.", // 40
        "Yukarı ve aşağı ok tuşlarına basarak ekmeklerin sırasıyla hangi iki sayı aralığında olması gerektiğini yazmalısın. Ve ekmekleri büyüklüklerine göre yerleştirmelisin.",
        "",
        "",
        "",
        "",
        "", // 45
        "",
        "",
        "Henüz mutfak robotu ile görevimiz bitmedi. Onun diğer önemli özelliği ise bir dönüştürücü  olması.",
        "Bileşik kesirleri, basit kesirleri, ondalık sayılara dönüştürebiliyor. Hadi biraz pratik yapalım.",
        "Bu görevde pizza dilimlerini kutulara yerleştirmelisin ama önce bu işlemi birlikte analiz edelim.",
        "1 kutuya 4 dilimi yerleştirdiğinde siparişin hazır hale gelecek. Şimdi pizza dilimlerini kutulara yerleştir", // 51
        "",
        "Şimdi ise raporlama kısmına geldik. Lütfen raporla butonuna bas ve raporu tamamla.",
        "",
        "Sayıları doğru yerlere yerleştir ve işlemi yap.", // 55
        "",
        "",
        "Renkleri göz önüne alarak boş yerlere sayıları yazar  mısın?",
        "",
        "Olamaz mutfak robotu bozuldu. Artık renkler olmadan işlemleri tamamlamalısın.", // 60
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",

    };

    public TextMeshProUGUI text;
    public SpriteRenderer ust_bar;

    public static int sayfa = 0;

    public GameObject isim_al;

    public TMP_InputField input;

    public GameObject next_buton;
    public GameObject karakter;

    public Animator anim;
    public Animator robot;
    public GameObject[] ogeler;
    public GameObject[] canvaslar;

    public GameObject[] soru1;
    public TMP_InputField uc;
    public TMP_InputField iki;

    public GameObject[] soru2;
    public TMP_InputField bir;
    public TMP_InputField otuz_bes;

    public GameObject[] soru3;
    public TMP_InputField dort;
    public TMP_InputField yedi;

    public GameObject[] soru4;
    public TextMeshProUGUI kg;

    int dd = 3;

    Vector3 pos1;
    Vector3 pos2;
    Vector3 pos3;
    Vector3 pos4;

    public Image[] tablo1;
    public TMP_InputField sekiz;
    public TMP_InputField yuz;
    public TMP_InputField sekiz_;


    public TMP_InputField bes;
    public TMP_InputField altmis;
    public TMP_InputField bes_;

    public TMP_InputField bir_;
    public TMP_InputField seksen;
    public TMP_InputField bes__;


    public Animator ekmek1;
    public Animator ekmek2;
    public Animator ekmek3;

    public TextMeshProUGUI sol_;
    public TextMeshProUGUI sag_;

    int sol = 10;
    int sag = 20;

    public Animator pizza1;
    public Animator pizza2;
    public Animator pizza3;
    public Animator pizza4;

    public TMP_InputField _bir;
    public TMP_InputField _iki;
    public TMP_InputField _dort;


    public TMP_InputField _alti;
    public TMP_InputField _dort_;

    public TMP_InputField dort2;
    public TMP_InputField bir2;
    public TMP_InputField iki2;

    public TMP_InputField dort3;
    public TMP_InputField bir3;
    public TMP_InputField iki3;


    public TMP_InputField sekiz4;
    public TMP_InputField uc4;
    public TMP_InputField alti4;
    public TMP_InputField iki4;
    public TMP_InputField iki4_;

    public TMP_InputField iki5;
    public TMP_InputField iki5_;
    public TMP_InputField uc5;

    int act = 0;


    void Start()
    {
        input = input.GetComponent<TMP_InputField>();
        text = text.GetComponent<TextMeshProUGUI>();
        ust_bar = ust_bar.GetComponent<SpriteRenderer>();
        ust_bar.color = Color.green;

        uc = uc.GetComponent<TMP_InputField>();
        iki = iki.GetComponent<TMP_InputField>();



        text.text = yazılar[0];

        anim = anim.GetComponent<Animator>();
        robot = robot.GetComponent<Animator>();


        anim.Play("hello");

        kg = kg.GetComponent<TextMeshProUGUI>();

        pos1 = soru4[7].transform.position;
        pos2 = soru4[8].transform.position;
        pos3 = soru4[9].transform.position;
        pos4 = soru4[10].transform.position;

        sekiz = sekiz.GetComponent<TMP_InputField>();
        yuz = yuz.GetComponent<TMP_InputField>();
        sekiz_ = sekiz_.GetComponent<TMP_InputField>();


        bes = bes.GetComponent<TMP_InputField>();
        altmis = altmis.GetComponent<TMP_InputField>();
        bes_ = bes_.GetComponent<TMP_InputField>();

        bir_ = bir_.GetComponent<TMP_InputField>();
        seksen = seksen.GetComponent<TMP_InputField>();
        bes__ = bes__.GetComponent<TMP_InputField>();



        ekmek1 = ekmek1.GetComponent<Animator>();
        ekmek2 = ekmek2.GetComponent<Animator>();
        ekmek3 = ekmek3.GetComponent<Animator>();

        pizza1 = pizza1.GetComponent<Animator>();
        pizza2 = pizza2.GetComponent<Animator>();
        pizza3 = pizza3.GetComponent<Animator>();
        pizza4 = pizza4.GetComponent<Animator>();

        _bir = _bir.GetComponent<TMP_InputField>();
        _iki = _iki.GetComponent<TMP_InputField>();
        _dort = _dort.GetComponent<TMP_InputField>();

        _alti = _alti.GetComponent<TMP_InputField>();
        _dort_ = _dort_.GetComponent<TMP_InputField>();

        dort2 = dort2.GetComponent<TMP_InputField>();
        bir2 = bir2.GetComponent<TMP_InputField>();
        iki2 = iki2.GetComponent<TMP_InputField>();

        dort3 = dort3.GetComponent<TMP_InputField>();
        bir3 = bir3.GetComponent<TMP_InputField>();
        iki3 = iki3.GetComponent<TMP_InputField>();


        sekiz4 = sekiz4.GetComponent<TMP_InputField>();
        alti4 = alti4.GetComponent<TMP_InputField>();
        uc4 = uc4.GetComponent<TMP_InputField>();
        iki4 = iki4.GetComponent<TMP_InputField>();
        iki4_ = iki4_.GetComponent<TMP_InputField>();

        iki5 = iki5.GetComponent<TMP_InputField>();
        iki5_ = iki5_.GetComponent<TMP_InputField>();
        uc5 = uc5.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ileri()
    {
        sayfa += 1;
        Debug.Log(sayfa);
        text.text = yazılar[sayfa];

        if (sayfa == 1)
        {
            next_buton.SetActive(false);
            isim_al.gameObject.SetActive(true);
        }

        if (sayfa == 3)
        {
            canvaslar[0].SetActive(false);
            canvaslar[1].SetActive(true);
            anim.Play("giris");
        }
        if (sayfa == 6)
        {
            robot.Play("robot_ilk");
            ogeler[0].SetActive(true);

        }
        if (sayfa == 7)
        {
            anim.Play("git");
            ogeler[1].SetActive(true);
            ogeler[0].SetActive(false);
            ogeler[2].SetActive(true);
            next_buton.gameObject.SetActive(false);

        }
        if (sayfa == 9)
        {
            ogeler[2].SetActive(false);
            ogeler[1].SetActive(false);
            ogeler[0].SetActive(true);
            soru1[0].SetActive(true);
        }

        if (sayfa == 10)
        {

            if (uc.text.ToString() == "üç" && iki.text.ToString() == "iki" && soru1[1].GetComponent<TMP_Dropdown>().value == 1 && soru1[2].GetComponent<TMP_Dropdown>().value == 2)
            {
                text.text = yazılar[sayfa];
                ust_bar.color = Color.blue;
            }
            else if (uc.text.ToString() != "üç" && iki.text.ToString() == "iki" && soru1[1].GetComponent<TMP_Dropdown>().value == 1 && soru1[2].GetComponent<TMP_Dropdown>().value == 2)
            {
                text.text = "Tam kısımı yazarken hata yaptın haydi tekrar dene! Unutma patatesler 3.2 kg.";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (uc.text.ToString() == "üç" && iki.text.ToString() != "iki" && soru1[1].GetComponent<TMP_Dropdown>().value == 1 && soru1[2].GetComponent<TMP_Dropdown>().value == 2)
            {
                text.text = "Ondalık kısımı yazarken hata yaptın haydi tekrar dene! Unutma patatesler 3.2 kg.";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (uc.text.ToString() == "üç" && iki.text.ToString() == "iki" && soru1[1].GetComponent<TMP_Dropdown>().value != 1 && soru1[2].GetComponent<TMP_Dropdown>().value == 2)
            {
                text.text = "Tam kısımı seçerken hata yaptın haydi tekrar dene! Unutma patatesler 3.2 kg.";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (uc.text.ToString() == "üç" && iki.text.ToString() == "iki" && soru1[1].GetComponent<TMP_Dropdown>().value == 1 && soru1[2].GetComponent<TMP_Dropdown>().value != 2)
            {
                text.text = "Ondalık kısımı seçerken hata yaptın haydi tekrar dene! Unutma patatesler 3.2 kg.";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else
            {
                text.text = "Bir hata yaptın haydi tekrar dene! Unutma patatesler 3.2 kg.";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
        }
        if (sayfa == 11)
        {
            ust_bar.color = Color.green;


            ogeler[6].SetActive(false); // patates kapandı
            ogeler[7].SetActive(true);  //soğan aç
            ogeler[3].SetActive(false);
        }
        if (sayfa == 12)
        {
            ogeler[0].SetActive(false); // masa kapandı
            ogeler[5].SetActive(true);
            ogeler[4].SetActive(true); // soğan açıldı
            next_buton.SetActive(false);
        }
        if (sayfa == 13)
        {
            ogeler[0].SetActive(true); // masa açıldı
            ogeler[4].SetActive(false);
            ogeler[5].SetActive(false);
            soru2[0].SetActive(true);

        }
        if (sayfa == 14)
        {

            if (bir.text.ToString() == "bir" && otuz_bes.text.ToString() == "otuz beş" && soru2[1].GetComponent<TMP_Dropdown>().value == 1 && soru2[2].GetComponent<TMP_Dropdown>().value == 1)
            {
                text.text = yazılar[sayfa];
                ust_bar.color = Color.blue;
            }
            else if (bir.text.ToString() != "bir" && otuz_bes.text.ToString() == "otuz beş" && soru2[1].GetComponent<TMP_Dropdown>().value == 1 && soru2[2].GetComponent<TMP_Dropdown>().value == 1)
            {
                text.text = "Tam kısımı yazarken hata yaptın haydi tekrar dene! Unutma soğanlar 1.35 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (bir.text.ToString() == "bir" && otuz_bes.text.ToString() != "otuz beş" && soru2[1].GetComponent<TMP_Dropdown>().value == 1 && soru2[2].GetComponent<TMP_Dropdown>().value == 1)
            {
                text.text = "Ondalık kısımı yazarken hata yaptın haydi tekrar dene! Unutma soğanlar 1.35 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (bir.text.ToString() == "bir" && otuz_bes.text.ToString() == "otuz beş" && soru2[1].GetComponent<TMP_Dropdown>().value != 1 && soru2[2].GetComponent<TMP_Dropdown>().value == 1)
            {
                text.text = "Tam kısımı seçerken hata yaptın haydi tekrar dene! Unutma soğanlar 1.35 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (bir.text.ToString() == "bir" && otuz_bes.text.ToString() == "otuz beş" && soru2[1].GetComponent<TMP_Dropdown>().value == 1 && soru2[2].GetComponent<TMP_Dropdown>().value != 1)
            {
                text.text = "Ondalık kısımı seçerken hata yaptın haydi tekrar dene! Unutma soğanlar 1.35 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else
            {
                text.text = "Bir hata yaptın haydi tekrar dene! Unutma soğanlar 1.35 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
        }


        if (sayfa == 15)
        {
            ust_bar.color = Color.green;
            soru2[0].SetActive(false);
            ogeler[8].SetActive(true);
            ogeler[7].SetActive(false);
            anim.Play("gir3");
            robot.gameObject.SetActive(false);
            soru3[0].SetActive(true);

        }
        if (sayfa == 16)
        {

            if (dort.text.ToString() == "dört" && yedi.text.ToString() == "yedi yüz elli sekiz" && soru3[1].GetComponent<TMP_Dropdown>().value == 1 && soru3[2].GetComponent<TMP_Dropdown>().value == 0)
            {
                text.text = yazılar[sayfa];
                ust_bar.color = Color.blue;
            }
            else if (dort.text.ToString() != "dört" && yedi.text.ToString() == "yedi yüz elli sekiz" && soru3[1].GetComponent<TMP_Dropdown>().value == 1 && soru3[2].GetComponent<TMP_Dropdown>().value == 0)
            {
                text.text = "Tam kısımı yazarken hata yaptın haydi tekrar dene! Unutma elmalar 4.758 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (dort.text.ToString() == "dört" && yedi.text.ToString() != "yedi yüz elli sekiz" && soru3[1].GetComponent<TMP_Dropdown>().value == 1 && soru3[2].GetComponent<TMP_Dropdown>().value == 0)
            {
                text.text = "Ondalık kısımı yazarken hata yaptın haydi tekrar dene! Unutma elmalar 4.758 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (dort.text.ToString() == "dört" && yedi.text.ToString() == "yedi yüz elli sekiz" && soru3[1].GetComponent<TMP_Dropdown>().value != 1 && soru3[2].GetComponent<TMP_Dropdown>().value == 0)
            {
                text.text = "Tam kısımı seçerken hata yaptın haydi tekrar dene! Unutma elmalar 4.758 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else if (dort.text.ToString() == "dört" && yedi.text.ToString() == "yedi yüz elli sekiz" && soru3[1].GetComponent<TMP_Dropdown>().value == 1 && soru3[2].GetComponent<TMP_Dropdown>().value != 0)
            {
                text.text = "Ondalık kısımı seçerken hata yaptın haydi tekrar dene! Unutma elmalar 4.758 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
            else
            {
                text.text = "Bir hata yaptın haydi tekrar dene! Unutma elmalar 4.758 kg";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
        }
        if (sayfa == 17)
        {
            soru3[0].SetActive(false);
            ogeler[8].SetActive(false);
            ogeler[0].SetActive(false);
            anim.Play("gir2");
            canvaslar[1].SetActive(false);
            canvaslar[2].SetActive(true);
            ust_bar.color = Color.green;


        }
        if (sayfa == 18)
        {
            anim.Play("git");
            canvaslar[1].SetActive(false);
            canvaslar[2].SetActive(true);
            next_buton.SetActive(false);
            kg.text = "2.5 L";
            next_buton.SetActive(false);
        }
        if (sayfa == 19)
        {
            anim.Play("gir3");
            canvaslar[2].SetActive(false);
            canvaslar[3].SetActive(true);
            text.text = "Evet " + input.text.ToString() + "Buradaki eğitimin tam 100 gün sürecek her günü işaretlemen için bir tablo vereceğim sana.\n";

        }
        if (sayfa == 20)
        {

            ogeler[9].SetActive(true);
        }
        if (sayfa == 22)
        {

            ogeler[9].SetActive(false);
        }
        if (sayfa == 23)
        {

            ogeler[10].SetActive(true);
            next_buton.SetActive(false);
        }
        if (sayfa == 24)
        {

            ogeler[12].SetActive(true);
        }
        if (sayfa == 25)
        {

            if (ogeler[14].GetComponent<TMP_Dropdown>().value == 2)
            {
                ogeler[10].SetActive(false);
                ogeler[9].SetActive(true);
                next_buton.SetActive(false);
                ust_bar.color = Color.green;
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
        }

        if (sayfa == 26)
        {

            if (sekiz.text == "8" && yuz.text == "100" && sekiz_.text == "8")
            {
                text.text = yazılar[sayfa];
                ust_bar.color = Color.blue;
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
        }
        if (sayfa == 27)
        {
            ust_bar.color = Color.green;
            canvaslar[3].SetActive(false);
            canvaslar[4].SetActive(true);
            anim.Play("gir2");
        }
        if (sayfa == 30)
        {
            anim.Play("cik2");
            next_buton.SetActive(false);
            ogeler[17].SetActive(true);
        }
        if (sayfa == 31)
        {
            ogeler[16].SetActive(false);
            ogeler[17].SetActive(false);
            ogeler[18].SetActive(false);
            ogeler[19].SetActive(true);
            ogeler[20].SetActive(true);

        }
        if (sayfa == 32)
        {
            if (bes.text == "5" && altmis.text == "6" && bes_.text == "5")
            {
                text.text = yazılar[sayfa];
                ust_bar.color = Color.blue;
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
        }
        if (sayfa == 33)
        {
            ogeler[19].SetActive(false);
            ogeler[22].SetActive(true);
            ust_bar.color = Color.green;

        }
        if (sayfa == 34)
        {
            if (bir_.text == "1" && seksen.text == "8" && bes__.text == "5")
            {
                text.text = yazılar[sayfa];
                ust_bar.color = Color.blue;
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
                sayfa -= 1;
            }
        }
        if (sayfa == 35)
        {
            ust_bar.color = Color.green;
            canvaslar[4].SetActive(false);
            canvaslar[5].SetActive(true);
            anim.Play("gir2");
        }
        if (sayfa == 39)
        {
            ogeler[24].SetActive(true);
            next_buton.SetActive(false);
            ogeler[26].SetActive(true);
            anim.Play("cik2");
        }
        if (sayfa == 41)
        {
            ogeler[24].SetActive(false);
            ogeler[25].SetActive(true);
            ogeler[30].SetActive(true);
            ekmek1.Play("ekmek1_1");
        }
        if (sayfa == 42)
        {
            if (sol_.text == "15" && sag_.text == "16")
            {
                ogeler[27].SetActive(false);
                ekmek2.Play("ekmek2_2");
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 43)
        {
            if (sol_.text == "15" && sag_.text == "16")
            {
                ogeler[28].SetActive(false);
                ekmek3.Play("ekmek3_3");
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 44)
        {
            if (sol_.text == "15" && sag_.text == "16")
            {
                ogeler[29].SetActive(false);
                text.text = "Bravo çok başarılısın. Robotumuz diğer ürünümüz için de hazırlıklarını yaptı. Aynı işlemi onlar için de yapar mısın, haydi devam et";
                ogeler[30].SetActive(true);
                ogeler[31].SetActive(true);
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 45)
        {
            if (sol_.text == "0" && sag_.text == "1")
            {
                ogeler[32].SetActive(true);
                ogeler[31].SetActive(false);
            }
        }
        if (sayfa == 46)
        {
            if (sol_.text == "0" && sag_.text == "1")
            {
                ogeler[32].SetActive(false);
                ogeler[33].SetActive(true);
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 47)
        {
            if (sol_.text == "0" && sag_.text == "1")
            {
                text.text = "Bravo! Harika bir iş başardın.";
                ust_bar.color = Color.green;
                ogeler[33].SetActive(false);
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 48)
        {
            canvaslar[5].SetActive(false);
            canvaslar[6].SetActive(true);
        }
        if (sayfa == 50)
        {
            ogeler[34].SetActive(true);
        }
        if (sayfa == 51)
        {
            pizza1.Play("pizza1");
            pizza2.Play("pizza2");
            pizza3.Play("pizza3");
            pizza4.Play("pizza4");
        }
        if (sayfa == 53)
        {
            ogeler[36].SetActive(true);
            ogeler[35].SetActive(false);
        }
        if (sayfa == 54)
        {
            if (_bir.text == "1" && _dort.text == "4" && _iki.text == "2")
            {
                ust_bar.color = Color.cyan;
                text.text = "Tebrikler, çok iyisin. Haydi devam edelim";
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 55)
        {
            ogeler[37].SetActive(true);
            ogeler[36].SetActive(false);
            ogeler[38].SetActive(true);
            ogeler[34].SetActive(false);
        }
        if (sayfa == 56)
        {
            if (_alti.text == "6" && _dort_.text == "4")
            {
                ust_bar.color = Color.cyan;
                text.text = "Tebrikler, çok iyisin. Haydi devam kalan boşlukları da doldur.";
                ogeler[39].SetActive(true);
                ogeler[40].SetActive(true);
                ogeler[41].SetActive(true);
            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 57)
        {


            if (dort2.text == "4" && bir2.text == "1" && iki2.text == "2")
            {
                ust_bar.color = Color.cyan;
                text.text = "Bravo! İşlemi doğru tamamladın. Devam et";

            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 58)
        {
            text.text = "Renkleri göz önüne alarak boş yerlere sayıları yazar  mısın?";
            ust_bar.color = Color.green;
            ogeler[37].SetActive(false);
            ogeler[38].SetActive(false);
            ogeler[42].SetActive(true);
            ogeler[43].SetActive(true);
        }
        if (sayfa == 59)
        {
            if (dort3.text == "4" && bir3.text == "1" && iki3.text == "2")
            {
                ust_bar.color = Color.cyan;
                text.text = "Bravo! Bileşik kesri başarıyla tam sayılı kesre dönüştürdün. Devam et";

            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 60)
        {
            text.text = "Olamaz mutfak robotu bozuldu. Artık renkler olmadan işlemleri tamamlamalısın.";
            canvaslar[6].SetActive(false);
            canvaslar[7].SetActive(true);
        }
        if (sayfa == 61)
        {
            if (sekiz4.text == "8" && uc4.text == "3")
            {
                ust_bar.color = Color.cyan;
                text.text = "Bravo! Bileşik kesri başarıyla tam sayılı kesre dönüştürdün. Devam et ve kalan kısımları yaz";

            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 62)
        {
            ogeler[44].SetActive(true);
            ogeler[45].SetActive(true);
            ogeler[46].SetActive(true);

            if (alti4.text == "6" && iki4.text == "2" && iki4_.text == "2")
            {
                ust_bar.color = Color.cyan;
                text.text = "Bravo! haydi son kısıma geçelim";

            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 63)
        {
            ogeler[47].SetActive(false);
            ogeler[48].SetActive(false);
            ogeler[49].SetActive(true);
            ogeler[50].SetActive(true);

            if (iki5.text == "2" && iki5_.text == "2" && uc4.text == "3")
            {
                ust_bar.color = Color.cyan;
                text.text = "Bravo! Bileşik kesri başarıyla tam sayılı kesre dönüştürdün!";

            }
            else
            {
                text.text = "Bir hata oldu, tekrar dene";
                ust_bar.color = Color.red;
            }
        }
        if (sayfa == 64)
        {

            ogeler[49].SetActive(false);
            ogeler[50].SetActive(false);
            anim.Play("gir2");
            ogeler[51].SetActive(true);
            next_buton.SetActive(false);
            ust_bar.color = Color.cyan;
            text.text = "Tebrik ederim, senden çok iyi bir aşçı olacağına şüphem yoktu :) " + input.text.ToString();
        }




    }
    public void isim_al_()
    {
        sayfa += 1;
        isim_al.gameObject.SetActive(false);
        text.text = "Tekrar merhaba, " + input.text.ToString() + "! Arkada gördüğün mutfak ileride şef olarak çalışmak istediğim mutfak fakat burada işe girmek için geçmem gereken aşamalar var. Bu işe girmemde bana yardımcı olur musun " + input.text.ToString() + "!";
        next_buton.SetActive(true);
    }
    public void not_kapat()
    {
        if (dd == 3 && soru4[dd].GetComponent<TMP_Dropdown>().value == 1)
        {
            soru4[2].SetActive(false);
            dd += 1;
            kg.text = "0.250 kg";
            soru4[1].SetActive(false);
            soru4[0].SetActive(true);
            soru4[7].transform.position = new Vector3(pos1.x, pos1.y, pos1.z);
        }
        else if (dd == 4 && soru4[dd].GetComponent<TMP_Dropdown>().value == 1 && soru4[dd - 1].GetComponent<TMP_Dropdown>().value == 1)
        {
            soru4[2].SetActive(false);
            dd += 1;
            kg.text = "0.7 L";
            soru4[0].SetActive(false);
            soru4[1].SetActive(true);
            soru4[8].transform.position = new Vector3(pos2.x, pos2.y, pos2.z);
        }
        else if (dd == 5 && soru4[dd].GetComponent<TMP_Dropdown>().value == 1 && soru4[dd - 1].GetComponent<TMP_Dropdown>().value == 1 && soru4[dd - 2].GetComponent<TMP_Dropdown>().value == 1)
        {
            soru4[2].SetActive(false);
            dd += 1;
            kg.text = "0.65 kg";
            soru4[1].SetActive(false);
            soru4[0].SetActive(true);
            soru4[9].transform.position = new Vector3(pos3.x, pos3.y, pos3.z);
        }
        else if (dd == 6 && soru4[dd].GetComponent<TMP_Dropdown>().value == 1 && soru4[dd - 1].GetComponent<TMP_Dropdown>().value == 1 && soru4[dd - 2].GetComponent<TMP_Dropdown>().value == 1 && soru4[dd - 2].GetComponent<TMP_Dropdown>().value == 1)
        {
            soru4[2].SetActive(false);
            soru4[10].transform.position = new Vector3(pos4.x, pos4.y, pos4.z);
            text.text = "Tebrikler, mükemmelsin. Haydi devam et butonuna bas ve ilerle.";
            next_buton.SetActive(true);
            ust_bar.color = Color.green;
        }
        else
        {
            text.text = "Bir hata yaptın haydi tekrar dene!";
            ust_bar.color = Color.red;
        }

    }
    public void sena_kapat()
    {

        ogeler[11].SetActive(false);
        next_buton.SetActive(true);
        ogeler[13].SetActive(true);
        text.text = "Sena'nın notlarını inceledin, şimdi devam et ve soruyu cevapla haydi!";
    }

    public void sena_ac()
    {

        ogeler[11].SetActive(true);
    }

    public void tabloyu_doldur()
    {
        foreach (Image oge in tablo1)
        {
            oge.color = Color.cyan;
            text.text = "Tebrikler, kaç gün çalışman gerektiğini doğru doldurdun. Şimdi devam edip kaç gün çalıştığını not defterine kaydedebilirsin.";

        }
        ogeler[15].SetActive(true);
        next_buton.SetActive(true);
    }
    public void kurallari_ac()
    {
        next_buton.SetActive(true);
        ogeler[16].SetActive(true);
        ogeler[18].SetActive(true);
        ogeler[17].SetActive(false);
    }
    public void kurallari_kapat()
    {
        next_buton.SetActive(true);
        ogeler[16].SetActive(false);
        ogeler[18].SetActive(false);
        ogeler[17].SetActive(true);
    }
    public void ekmek_yap()
    {
        ekmek1.Play("ekmek1");
        ekmek2.Play("ekmek2");
        ekmek3.Play("ekmek3");
        next_buton.SetActive(true);
        ogeler[26].SetActive(false);
    }



    public void sag_ekle()
    {
        sag += 1;
        sag_.text = sag.ToString();
    }
    public void sag_cıkar()
    {
        sag -= 1;
        sag_.text = sag.ToString();
    }


    public void sol_cıkar()
    {
        sol -= 1;
        sol_.text = sol.ToString();
    }
    public void sol_ekle()
    {
        sol += 1;
        sol_.text = sol.ToString();
    }


    public void kapat()
    {
        Application.Quit();
    }
    public void sonraki_act()
    {
        act += 1;
        Debug.Log(act);
        if (act == 1)
        {
            sayfa = 16;
            text.text = yazılar[17];

            canvaslar[1].SetActive(false);
            canvaslar[2].SetActive(true);
        }
        if (act == 2)
        {
            sayfa = 18;
            text.text = "bir sonraki aktiviteye geçmek için devam et butonuna bas";
            canvaslar[2].SetActive(false);
            canvaslar[3].SetActive(true);
            next_buton.SetActive(true);

        }
        if (act == 3)
        {
            sayfa = 26;
            text.text = "bir sonraki aktiviteye geçmek için devam et butonuna bas";
            ust_bar.color = Color.green;
            canvaslar[3].SetActive(false);
            canvaslar[4].SetActive(true);
            next_buton.SetActive(true);

        }
        if (act == 4)
        {
            sayfa = 34;
            text.text = "bir sonraki aktiviteye geçmek için devam et butonuna bas";
            ust_bar.color = Color.green;
            canvaslar[4].SetActive(false);
            canvaslar[5].SetActive(true);
            next_buton.SetActive(true);

        }
        if (act == 5)
        {
            sayfa = 47;
            canvaslar[5].SetActive(false);
            canvaslar[6].SetActive(true);
            text.text = "bir sonraki aktiviteye geçmek için devam et butonuna bas";
            ust_bar.color = Color.green;
        }
        if (act == 6)
        {
            sayfa = 59;
            text.text = "bir sonraki aktiviteye geçmek için devam et butonuna bas";
            ust_bar.color = Color.green;
            canvaslar[6].SetActive(false);
            canvaslar[7].SetActive(true);
        }

    }
    public void önceki_act()
    {
        act -= 1;
        Debug.Log(act);
        if (act == 0)
        {
            sayfa = 2;
            text.text = yazılar[3];
            next_buton.SetActive(true);
            canvaslar[1].SetActive(true);
            canvaslar[2].SetActive(false);
        }
        if (act == 1)
        {
            sayfa = 16;
            text.text = "bir önceki aktiviteye geçmek için devam et butonuna bas";
            canvaslar[2].SetActive(true);
            canvaslar[3].SetActive(false);
            next_buton.SetActive(true);

        }
        if (act == 2)
        {
            sayfa = 18;
            text.text = "bir önceki aktiviteye geçmek için devam et butonuna bas";
            ust_bar.color = Color.green;
            canvaslar[3].SetActive(true);
            canvaslar[4].SetActive(false);
            next_buton.SetActive(true);

        }
        if (act == 3)
        {
            sayfa = 26;
            text.text = "bir önceki aktiviteye geçmek için devam et butonuna bas";
            ust_bar.color = Color.green;
            canvaslar[4].SetActive(true);
            canvaslar[5].SetActive(false);
            next_buton.SetActive(true);

        }
        if (act == 4)
        {
            sayfa = 34;
            canvaslar[5].SetActive(true);
            canvaslar[6].SetActive(false);
            text.text = "bir önceki aktiviteye geçmek için devam et butonuna bas";
            ust_bar.color = Color.green;
        }
        if (act == 5)
        {
            sayfa = 47;
            text.text = "bir önceki aktiviteye geçmek için devam et butonuna bas";
            ust_bar.color = Color.green;
            canvaslar[6].SetActive(true);
            canvaslar[7].SetActive(false);
            next_buton.SetActive(true);
        }
    }
}