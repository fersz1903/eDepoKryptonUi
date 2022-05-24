using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace eDepoKryptonUi
{
    public partial class frmVeriDuzenle : KryptonForm
    {
        public int page;
        public bool duzenleme;// eger ekleme butonuna basıldıysa false, guncellemeye basıldıysa true
        public static string barkod=null;
        public frmVeriDuzenle(int page,bool duzen)
        {
            InitializeComponent();
            this.page = page;
            this.duzenleme = duzen;
        }

        private void frmVeriDuzenle_Load(object sender, EventArgs e)
        {
            switch (this.page)
            {
                case 1:
                    dock.SelectedPage = pageTeknolojiEkle;
                    if (duzenleme==false) //false ise ekleme butonu görünür olacak
                    {
                        btn_taGuncelle.Visible = false;
                    }
                    else
                    {
                        btn_taEkle.Visible = false;
                    }
                    break;
                case 2:
                    dock.SelectedPage = pageArabaEkle;
                    if (duzenleme == false) //false ise ekleme butonu görünür olacak
                    {
                        btn_ArabaGuncelle.Visible = false;
                    }
                    else
                    {
                        btn_ArabaEkle.Visible = false;
                    }
                    break;
                case 3:
                    dock.SelectedPage = pageEvEkle;
                    if (duzenleme == false) //false ise ekleme butonu görünür olacak
                    {
                        btn_EvGuncelle.Visible = false;
                    }
                    else
                    {
                        btn_EvEkle.Visible = false;
                    }
                    break;
                case 4:
                    dock.SelectedPage = pageAra;
                    Size = new Size(Width, 260); //arama sayfası küçük olacak
                    break;
            }
        }

        private void btn_taEkle_Click(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            ls = textboxListele(ls);
            VeriTabaniIslemleri veri = new VeriTabaniIslemleri();
            veri.urunEkle(ls);
        }


        private List<string> textboxListele(List<string> ls)
        {
            if (frmDataGridview.kategori.Equals("teknolojikAlet"))
            {
                ls.Add(txt_taMarkaEkle.Text);
                ls.Add(txt_taModelEkle.Text);
                ls.Add(txt_taTipEkle.Text);
                ls.Add(txt_taFiyatEkle.Text);
                ls.Add(txt_taYilEkle.Text);
                ls.Add(txt_taBarkodEkle.Text);
                ls.Add(txt_taNotEkle.Text);
            }
            else if (frmDataGridview.kategori.Equals("araba"))
            {
                ls.Add(txt_ArabaMarkaEkle.Text);
                ls.Add(txt_ArabaModelEkle.Text);
                ls.Add(txt_ArabaRenkEkle.Text);
                ls.Add(txt_ArabaKmEkle.Text);
                ls.Add(txt_ArabaTipEkle.Text);
                ls.Add(txt_ArabaFiyatEkle.Text);
                ls.Add(txt_ArabaYilEkle.Text);
                ls.Add(txt_ArabaBarkodEkle.Text);
                ls.Add(txt_ArabaNotEkle.Text);
            }
            else
            {
                ls.Add(txt_EvSehirEkle.Text);
                ls.Add(txt_EvIlceEkle.Text);
                ls.Add(txt_EvAdresEkle.Text);
                ls.Add(txt_EvOdaSEkle.Text);
                ls.Add(txt_EvKatEkle.Text);
                ls.Add(txt_EvMetreEkle.Text);
                ls.Add(txt_EvTipEkle.Text);
                ls.Add(txt_EvFiyatEkle.Text);
                ls.Add(txt_EvYilEkle.Text);
                ls.Add(txt_EvBarkodEkle.Text);
                ls.Add(txt_EvNotEkle.Text);
            }
            return ls;
        }

        private void btn_taGuncelle_Click(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            ls = textboxListele(ls);
            if (barkod !=null)
            {
                VeriTabaniIslemleri veri = new VeriTabaniIslemleri();
                veri.urunGuncelle(ls, barkod);
                barkod = null;
            }
            else
            {
                VeriTabaniIslemleri veri=new VeriTabaniIslemleri();
                if (frmDataGridview.kategori.Equals("teknolojikAlet"))
                {
                    barkod = txt_taBarkodEkle.Text;
                }
                else if (frmDataGridview.kategori.Equals("araba"))
                {
                    barkod = txt_ArabaBarkodEkle.Text;
                }
                else
                {
                    barkod = txt_EvBarkodEkle.Text;
                }
                veri.urunGuncelle(ls, barkod);
                barkod=null;
            }
        }

        private void txt_taBarkodEkle_Enter(object sender, EventArgs e)
        {
            if(duzenleme == true)
            {
                if (frmDataGridview.kategori.Equals("teknolojikAlet")) // barkod değiştirilirse eski değeri yakalar.
                {
                    barkod = txt_taBarkodEkle.Text;
                }
                else if (frmDataGridview.kategori.Equals("araba"))
                {
                    barkod = txt_ArabaBarkodEkle.Text;
                }
                else
                {
                    barkod = txt_EvBarkodEkle.Text;
                }
            } 
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            frmDataGridview frm = new frmDataGridview(frmDataGridview.kategori);
            frm.urunAra(txt_Ara.Text.ToLower());
        }
    }
}
