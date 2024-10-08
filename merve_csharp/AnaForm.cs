﻿using System;
using System.Windows.Forms;


namespace merve_csharp._000_Classlar
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 1 + 1 işleminin sonucu veren metot
        /// </summary>
        /// <returns> int 2 döner </returns>
        double topla()
        {
            return 1 + 1;
        }
        /// <summary>
        /// 0 ile n arasında kalan tüm sayıların toplamını veren metot
        /// </summary>
        /// <param name="n"> n </param>
        /// <returns></returns>
        double topla(double n)
        {
            for (int i = 0; i < n; i++)
            {
                n += i;
            }
            return n;
        }
        /// <summary>
        /// 0 ile n arasında kalan tüm sayıların toplamını veren metot
        /// </summary>
        /// <param name="n"> n </param>
        /// <returns></returns>
        double topla(int n)
        {
            for (int i = 0; i < n; i++)
            {
                n += i;
            }
            return n;
        }
        /// <summary>
        /// y ile x arasında kalan tüm sayıların toplamını veren metot
        /// </summary>
        /// <param name="x">max değer</param>
        /// <param name="y">min değer</param>
        /// <returns> asd </returns>
        double topla(int x, int y)
        {
            for (int i = y; i < x; i++)
            {
                x += i;
            }
            return x;
        }


        private void AnaForm_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Ders 001 - C# Kurulu Anti Virüs Programını Bulmak");
            treeView1.Nodes.Add("Ders 002 - C# FolderBrowserDialog Kullanimi");
            treeView1.Nodes.Add("Ders 003 - C# DataTable 'Bu satır başka bir tabloya ait' Hatası Çözümü");
            treeView1.Nodes.Add("Ders 004 - C# Thread Sleep ile İşlem Süresini Uzatmak");
            treeView1.Nodes.Add("Ders 005 - C# Textbox Sadece Sayı Harf Girişi Yaptırmak");
            treeView1.Nodes.Add("Ders 006 - C# String Sayısal Değer Kontrolü");
            treeView1.Nodes.Add("Ders 007 - C# Kelime Heceleme İşlemi");
            treeView1.Nodes.Add("Ders 008 - C# DataGridView'den Veri Çekme");
            treeView1.Nodes.Add("Ders 009 - C# NotifyIcon Kullanımı ve NotifyIcon Bildirimleri");
            treeView1.Nodes.Add("Ders 010 - C# Linq To XML ile XML Dosyalarla Çalışmak");
            treeView1.Nodes.Add("Ders 011 - C# Sayıyı Roma Rakamlarına Çevirme");
            treeView1.Nodes.Add("Ders 012 - C# Kombinasyon Hesaplama ");
            treeView1.Nodes.Add("Ders 013 - C# Permütasyon Hesaplama ");
            treeView1.Nodes.Add("Ders 014 - C# ToolTip Kullanımı - Nesneler İçin Açıklama");
            treeView1.Nodes.Add("Ders 015 - C# Extension Methods - Genişletme Metodları 1, 2, 3");
            treeView1.Nodes.Add("Ders 016 - C# ComboBox TXT Dosyası ile Doldurma");
            treeView1.Nodes.Add("Ders 017 - C# Kill Proccess - Otomatik Program Kapatmak");
            treeView1.Nodes.Add("Ders 018 - C# List<T> Listeler Arasındaki Farkları Bulmak - (Generic List)");
            treeView1.Nodes.Add("Ders 019 - C# Milisaniye Bilgisini Saniye ve Dakikaya Çevirmek");
            treeView1.Nodes.Add("Ders 020 - C# Excel OLEDB Bağlantı ve Veri Okuma – Class");
            treeView1.Nodes.Add("Ders 021 - C# Rastgele Şifre Oluşturma");
            treeView1.Nodes.Add("Ders 022 - C# Özel MessageBox Yapımı");
            treeView1.Nodes.Add("Ders 023 - C# XML İşlemleri");
            treeView1.Nodes.Add("Ders 024 - C# Drag Drop");
            treeView1.Nodes.Add("Ders 025 - C# Çoklu Excel Dosyası Okuma");
            treeView1.Nodes.Add("Ders 026 - C# User Control Kullanımı");
            treeView1.Nodes.Add("Ders 027 - C# Listboxlar Arası Sürükle Bırak");
            treeView1.Nodes.Add("Ders 028 - C# List Ögelerini DataGridView ve ListBox'a Bağlamak");
            treeView1.Nodes.Add("Ders 029 - C# Formdaki Tüm TextBox Nesnelerini Temizlemek");
            treeView1.Nodes.Add("Ders 030 - C# Process İşlemleri - Neler Yapılabilir?");
            treeView1.Nodes.Add("Ders 031 - C# Çalışan Bir Uygulamanın Sahibi Nasıl Bulunur?");
            treeView1.Nodes.Add("Ders 032 - C# XML Serialization ve Deserialization İşlemleri");
            treeView1.Nodes.Add("Ders 033 - C# TC Kimlik No Kontrol Programı");
            treeView1.Nodes.Add("Ders 034 - C# Exceptions");
            treeView1.Nodes.Add("Ders 035 - C# Klasördeki Dosya Adlarını Almak");
            treeView1.Nodes.Add("Ders 036 - C# Kredi Kartı Tipini Bulma");
            treeView1.Nodes.Add("Ders 037 - C# Kredi Kartı Doğrulama - Luhn Algoritması");
            treeView1.Nodes.Add("Ders 038 - C# Kredi Kartı Numarasındaki Bilgiler");
            treeView1.Nodes.Add("Ders 039 - C# Dinamik Form ve Nesneler Üretip Kullanmak");
            treeView1.Nodes.Add("Ders 040 - C# Metin Belgesi Okuma Yazma");
            treeView1.Nodes.Add("Ders 041 - C# Yardım Formları Hazırlamak");
            treeView1.Nodes.Add("Ders 042 - C# MD5 Şifreleme");
            treeView1.Nodes.Add("Ders 043 - C# SHA1 Şifreleme");
            treeView1.Nodes.Add("Ders 044 - C# SHA256 Şifreleme");
            treeView1.Nodes.Add("Ders 045 - C# SHA384 Şifreleme");
            treeView1.Nodes.Add("Ders 046 - C# SHA512 Şifreleme");

            // OtoAc();

        }
        void OtoAc()
        {
            // Otomatik son eklenen ders açılsın.
            int index = treeView1.Nodes.Count - 1;
            TreeNode myNode = treeView1.Nodes[index];
            TreeView1_NodeMouseClick(treeView1, new TreeNodeMouseClickEventArgs(myNode, MouseButtons.Left, 1, 0, 0));
        }


        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Index + 1)
            {
                case 1: new _001_Kurulu_Antivirus_Bulmak.AntivirusBulmak() { }.ShowDialog(); break;
                case 2: new _002_FolderBrowserDialog_Kullanimi.FolderBrowserDialogKullanimi_() { }.ShowDialog(); break;
                case 3: new _003_DataTable_Bu_Satir_Baska_Tabloya_Ait_Hatasi.form1() { }.ShowDialog(); break;
                case 4: new _004_Thread_Sleep_ile_Islem_Suresini_Uzatmak.thread_sleep() { }.ShowDialog(); break;
                case 5: new _005_TextBox_sadece_sayi_harf_girisi.Form1() { }.ShowDialog(); break;
                case 6: new _006_String_Sayisal_Deger_Kontrolu.Form1() { }.ShowDialog(); break;
                case 7: new _007_Kelime_heceleme_islemi.Form2() { }.ShowDialog(); break;
                case 8: new _008_Gridview_den_textbox_a_Veri_cekme.ListeForm() { }.ShowDialog(); break;
                case 9: new _009_NotiftyIcon_Kullanimi.AnaMenu() { }.ShowDialog(); break;
                case 10: new _010_LINQ_to_XML.LINQ_to_XML() { }.ShowDialog(); break;
                case 11: new _011_Sayilari_Roma_Rakamina_Cevir.Form1() { }.ShowDialog(); break;
                case 12: new _012_kombinasyon_hesaplama.Form1() { }.ShowDialog(); break;
                case 13: new _013_permutasyon_hesaplama.Form1() { }.ShowDialog(); break;
                case 14: new _014_Tooltip_Kullanimi.Form1() { }.ShowDialog(); break;
                case 15: new _015_Extension_Methods.Form1() { }.ShowDialog(); break;
                case 16: new _016_ComboBox_TXT_Dosyai_ile_Doldurma.Form1() { }.ShowDialog(); break;
                case 17: new _17_Kill_Proccess_Program_Kapatmak.Form1() { }.ShowDialog(); break;
                case 18: new _018_Listeler_Arasındaki_Farkları_Bulmak.Form1() { }.ShowDialog(); break;
                case 19: new _019_Milisaniye_Bilgisini_Saniye_ve_Dakikaya_Cevirmek.Form1() { }.ShowDialog(); break;
                case 20: new _020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class.Form1() { }.ShowDialog(); break;
                case 21: new _021_Rastgele_Sifre_Olusturma.Form1() { }.ShowDialog(); break;
                case 22: new _022_Ozel_MessageBox_Yapimi.AnaForm() { }.ShowDialog(); break;
                //case 23: new _023_XML_Islemleri.XML_AnaForm() { }.ShowDialog(); break;
                case 24: new _024_Drag_And_Drop.dragdrop() { }.ShowDialog(); break;
                case 25: new _020_Excel_OLEDB_Baglanti_ve_Veri_Okuma_Class.Form1() { }.ShowDialog(); break;
                case 26: new _026_UserControl_Kullanimi.Form1() { }.ShowDialog(); break;
                case 27: new _027_Listboxlar_Arasi_Surukle_Birak.Form1() { }.ShowDialog(); break;
                case 28: new _028_List_DataGridView_ListBox_Baglamak.Form1() { }.ShowDialog(); break;
                case 29: new _029_Formdaki_Tum_TextBox_Nesnelerini_Temizlemek.Form1() { }.ShowDialog(); break;
                case 30: new _030_Process_islemleri_Neler_Yapılabilir.Form1() { }.ShowDialog(); break;
                case 31: new _031_Calisan_Uygulamanin_Sahibi_Kim.Form1() { }.ShowDialog(); break;
                case 32: new _032_Serialization_Deserialization.Form1() { }.ShowDialog(); break;
                case 33: MessageBox.Show(_000_Classlar.TCKimlikNoKontrol.Kontrol("15735859942")); /*Kendi TC'niz ile Test edeilirsiniz.*/  break;
                case 34: new _034_Exceptions.Form1() { }.ShowDialog(); break;
                case 35: new _035_Klasordeki_Dosya_Bilgilerini_Almak.Form1 { }.ShowDialog(); break;
                case 36: new _036_Kredi_Karti_Tipini_Bulma.Form1 { }.ShowDialog(); break;
                case 37: new _037_Kredi_Karti_Luhn_Algoritmasi.Form1 { }.ShowDialog(); break;
                case 38: new _038_Kredi_Karti_Bilgileri.Form1 { }.ShowDialog(); break;
                case 39: new _039_Dinamik_Form_ve_Nesne_Uretme.Form1 { }.ShowDialog(); break;
                case 40: new _040_Metin_Belgesi_Okuma_Yazma.Form1 { }.ShowDialog(); break;
                case 41: new _041_Yardim_Formlari_Hazırlamak.Form1 { }.ShowDialog(); break;
                case 42: new _042_MD5_Sifreleme.Form1 { }.ShowDialog(); break;
                case 43: new _043_SHA1_Sifreleme.Form1 { }.ShowDialog(); break;
                case 44: new _044_SHA256_Sifreleme.Form1 { }.ShowDialog(); break;
                case 45: new _045_SHA384_Sifreleme.Form1 { }.ShowDialog(); break;
                case 46: new _046_SHA512_Sifreleme.Form1 { }.ShowDialog(); break;

            }
        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}