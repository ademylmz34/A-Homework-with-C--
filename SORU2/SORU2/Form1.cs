/***************************************************************************************************************************
**                                                 SAKARYA ÜNİVERSİTESİ
**                                         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKULTESİ
**                                            BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                           NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                                 2020-2021 BAHAR DÖNEMİ
**
**
**                                            ÖDEV NUMARASI........: ...........
**                                            ÖĞRENCİ ADI..........: ADEM YILMAZ
**                                            ÖĞRENCİ NUMARASI.....: G191210305
**                                            DERSİN ALINDIĞI GRUP.: 2D
**
**
****************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SORU2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class matris
        {

            public static void yazdir(int sayi, int[,] matris1, int[,] matris2)
            {
                //textboxa değer girdiğimizde otamatik olarak  1.matris ve 2.matrisi oluşturuyor.
                Random Rastgele = new Random();
                for (int i = 0; i < sayi; i++)
                {

                    for (int j = 0; j < sayi; j++)
                    {
                        matris1[i, j] = Rastgele.Next(1, 10);
                        matris2[i, j] = Rastgele.Next(1, 10);
                    }

                }
            }
            public static void topla(int[,] matris1, int[,] matris2, int[,] toplamsonuc)
            {

                for (int i = 0; i <= toplamsonuc.GetUpperBound(0); i++)
                {

                    for (int j = 0; j <= toplamsonuc.GetUpperBound(1); j++)
                    {
                        toplamsonuc[i, j] = matris1[i, j] + matris2[i, j];
                    }

                }
            }
            public static void carpma(int[,] matris1, int[,] matris2, int[,] carpımsonuc)
            {
                for (int i = 0; i <= matris1.GetUpperBound(0); i++)
                {

                    for (int j = 0; j <= matris1.GetUpperBound(1); j++)
                    {
                        for (int k = 0; k <= matris1.GetUpperBound(0); k++)
                        {
                            carpımsonuc[i, j] += matris1[i, k] * matris2[k, j];
                        }

                    }

                }
            }
            public static void degerokuma(int Satir, int Sütun, int[,] matris1, int[,] matris2, int[] deger, bool rdn1, bool rdn2)
            {

                if (Satir > matris1.GetUpperBound(0) + 1)
                {
                    MessageBox.Show("Dizi sınırlarında satır değeri giriniz");
                }
                else if (Sütun > matris1.GetUpperBound(0) + 1)
                {
                    MessageBox.Show("Dizi sınırlarında sütun değeri giriniz");
                }
                else if (rdn1)
                {

                    deger[0] = matris1[Satir - 1, Sütun - 1];


                }
                else if (rdn2)
                {
                    deger[0] = matris2[Satir - 1, Sütun - 1];
                }
            }
            public static void tersialma()
            {

            }
            public static void izibulma(int[,] matris, int[] toplam)
            {
                toplam[0] = 0;

                for (int i = 0; i <= matris.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= matris.GetUpperBound(1); j++)
                    {
                        if (i == j)
                        {
                            toplam[0] += matris[i, j];

                        }
                    }
                }
            }
            public static void transpozet(int[,] matris)
            {
                int[] gecici = new int[1];
                for (int i = 0; i <= matris.GetUpperBound(0); i++)
                {
                    
                    for (int j = i; j <= matris.GetUpperBound(0); j++)
                    {
                        gecici[0] = matris[i, j];
                        matris[i, j] = matris[j, i];
                        matris[j, i] = gecici[0];
                    }
                }
            }
        }
        public void kontrollerigizle()
        {

            btn_carp.Visible = false;
            btn_izbul.Visible = false;
            btn_okuma.Visible = false;
            btn_tersial.Visible = false;
            btn_topla.Visible = false;
            btn_transpoze.Visible = false;
            btn_yazdir.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            btn_metindosyasıgöster.Visible = false;

            Controls.Remove(lblesitsembol);
            Controls.Remove(lblsembol);



            Controls.Remove(lblmatrissecim);
            Controls.Remove(rdnmatris1);
            Controls.Remove(rdnmatris2);
            Controls.Remove(lblsatir);
            Controls.Remove(lblsütun);
            Controls.Remove(txtsatir);
            Controls.Remove(txtsütun);
            Controls.Remove(lbldeger);
            Controls.Remove(txtdeger);
            Controls.Remove(Rchsonuc);
            Controls.Remove(lblesitsembol);
            Controls.Remove(lblsembol);
            Controls.Remove(degerokut);


            Controls.Remove(btntranspoze);


            Controls.Remove(sonuc);
            Controls.Remove(txtsonuc);
            Controls.Remove(lblsecim);
            Controls.Remove(btn_anamenü);
            Controls.Remove(rchizmatrisi);
            Controls.Remove(hesapla);
            Controls.Remove(rdnmatris_1);
            Controls.Remove(rdnmatris_2);

            Controls.Remove(Rchmetindosyasigöster);
        }
        public void kontrollerigerial()
        {

            btn_carp.Visible = true;
            btn_izbul.Visible = true;
            btn_okuma.Visible = true;
            btn_tersial.Visible = true;
            btn_topla.Visible = true;
            btn_transpoze.Visible = true;
            btn_yazdir.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;
            btn_metindosyasıgöster.Visible = true;

        }
        Button btn_anamenü = new Button
        {

            Left = 39,
            Top = 291,
            Width = 602,
            Height = 51,
            Font = new Font("Arial", 14),
            Text = "ANA MENÜYE DÖN",

        };
        Button btntranspoze = new Button
        {
            Left = 27,
            Top = 99,
            AutoSize = true,
            Font = new Font("Arial", 14),
            Text = "TRANSPOZE ET",

        };
        Button degerokut = new Button
        {
            Left = 323,
            Top = 180,
            AutoSize = true,
            Text = "DEĞERİ OKUT   ",
        };

        RichTextBox Rchmatris1 = new RichTextBox
        {
            Left = 38,
            Top = 50,
            Width = 293,
            Height = 235,
            Font = new Font("Arial", 16),
        };
        RichTextBox Rchmatris2 = new RichTextBox
        {
            Left = 347,
            Top = 50,
            Width = 293,
            Height = 235,
            Font = new Font("Arial", 16),
        };
        RichTextBox Rchsonuc = new RichTextBox
        {
            Left = 711,
            Top = 50,
            Width = 293,
            Height = 235,
            Font = new Font("Arial", 16),
        };
        RichTextBox Rchmetindosyasigöster = new RichTextBox
        {
            Left = 12,
            Top = 12,
            Width = 916,
            Height = 607,
            Font = new Font("Arial", 10),
        };
        Label lblsembol = new Label
        {
            Left = 338,
            Top = 165,
            Text = "+",
            Font = new Font("Arial", 16),
        };
        Label lblesitsembol = new Label
        {
            Left = 674,
            Top = 165,
            Text = "=",
            Font = new Font("Arial", 16),
        };
        Label lblmatrissecim = new Label
        {
            Left = 21,
            Top = 30,
            AutoSize = true,
            Text = "Hangi matris için okuma yapmak istersiniz?",

        };
        RadioButton rdnmatris1 = new RadioButton
        {
            Left = 323,
            Top = 28,
            Text = "1.MATRİS",
            Checked = true,

        };
        RadioButton rdnmatris2 = new RadioButton
        {
            Left = 431,
            Top = 28,
            Text = "2.MATRİS",
        };
        RadioButton rdnmatris_1 = new RadioButton
        {
            Left = 27,
            Top = 30,
            Text = "1.MATRİS",
            Checked = true,
        };
        RadioButton rdnmatris_2 = new RadioButton
        {
            Left = 182,
            Top = 30,
            Text = "2.MATRİS",
        };
        Label lblsatir = new Label
        {
            Left = 24,
            Top = 88,
            AutoSize = true,
            Text = "Okutmak istediğiniz satırı giriniz",

        };
        TextBox txtsatir = new TextBox
        {
            Left = 323,
            Top = 88,
            Text = "1",

        };
        Label lblsütun = new Label
        {
            Left = 24,
            Top = 135,
            AutoSize = true,
            Text = "Okutmak istediğiniz sütunu giriniz",

        };
        TextBox txtsütun = new TextBox
        {
            Left = 323,
            Top = 135,
            Text = "1",


        };
        Label lbldeger = new Label
        {
            Left = 24,
            Top = 250,
            Text = "Değer",

        };
        TextBox txtdeger = new TextBox
        {
            Left = 323,
            Top = 250,

        };
        Label lblsecim = new Label
        {
            Left = 24,
            Top = 28,
            AutoSize = true,
            Text = "Hangi matrisin izini bulmak istersiniz?",
            Font = new Font("Arial", 10, FontStyle.Bold),
        };
        Label sonuc = new Label
        {
            Left = 24,
            Top = 97,
            AutoSize = true,
            Font = new Font("Arial", 13, FontStyle.Bold),
            Text = "Sonuc",
        };
        TextBox txtsonuc = new TextBox
        {
            Left = 166,
            Top = 97,
            AutoSize = true,
            Font = new Font("Arial", 13, FontStyle.Bold),
        };
        RichTextBox rchizmatrisi = new RichTextBox
        {
            Left = 576,
            Top = 20,
            Width = 270,
            Height = 220,
            Font = new Font("Arial", 13),

        };
        Button hesapla = new Button
        {
            Left = 323,
            Top = 97,
            Text = "HESAPLA",
            AutoSize = true,
            Font = new Font("Arial", 13),
        };
        public void matrisleriyazdir()//matrisleri richtextboxlara yazdırıyor.
        {
            Rchmatris1.Clear();
            Rchmatris2.Clear();
            for (int i = 0; i <= matris1.GetUpperBound(0); i++)
            {

                Rchmatris1.Text += "| ";
                for (int j = 0; j <= matris1.GetUpperBound(1); j++)
                {
                    Rchmatris1.Text += matris1[i, j] + "  ";

                }
                Rchmatris1.Text += "|";
                Rchmatris1.Text += "\n";

            }

            for (int i = 0; i <= matris2.GetUpperBound(0); i++)
            {
                Rchmatris2.Text += "| ";
                for (int j = 0; j <= matris2.GetUpperBound(1); j++)
                {
                    Rchmatris2.Text += matris2[i, j] + "  ";

                }
                Rchmatris2.Text += "|";
                Rchmatris2.Text += "\n";

            }
        }
        public void matrislerimetindosyasınaişle()
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("1.Matris:");
            for (int i = 0; i <= matris1.GetUpperBound(0); i++)
            {
                sw.Write("| ");

                for (int j = 0; j <= matris1.GetUpperBound(1); j++)
                {

                    sw.Write(matris1[i, j] + "  ");
                }

                sw.Write("|");
                sw.WriteLine();
            }

            sw.WriteLine("**************************");
            sw.WriteLine("2.Matris:");
            for (int i = 0; i <= matris2.GetUpperBound(0); i++)
            {

                sw.Write("| ");
                for (int j = 0; j <= matris2.GetUpperBound(1); j++)
                {

                    sw.Write(matris2[i, j] + "  ");
                }

                sw.Write("|");
                sw.WriteLine();
            }
            if (butontoplama != 0)
            {
                sw.WriteLine("*********************");
                sw.WriteLine("Matrislerin Toplamı:");
                for (int i = 0; i <= toplamsonuc.GetUpperBound(0); i++)
                {
                    sw.Write("|");
                    for (int j = 0; j <= toplamsonuc.GetUpperBound(1); j++)
                    {
                        sw.Write(toplamsonuc[i, j] + "\t");

                    }
                    sw.Write("|");
                    sw.WriteLine();

                }
            }

            if (butoncarpma != 0)
            {
                sw.WriteLine("*********************");
                sw.WriteLine("Matrislerin Çarpımı:");
                for (int i = 0; i <= carpımsonuc.GetUpperBound(0); i++)
                {
                    sw.Write("|");
                    for (int j = 0; j <= carpımsonuc.GetUpperBound(1); j++)
                    {
                        sw.Write(carpımsonuc[i, j] + "\t");

                    }
                    sw.WriteLine("|");
                    

                }
            }
            
            
            if (btnokuma != 0)
            {
                sw.WriteLine("**********************");
                sw.WriteLine("Değer Okuma:");
                if (butondegerokut==0)
                {
                    sw.WriteLine("Herhangi bir değer işlem yapılmadı.");
                }
                else
                { 
                  sw.WriteLine("1.Matris için\n" + satir1 + ". satırın " + sütun1 + ". sütunundaki değeri : " + deger1[0]);
                  sw.WriteLine("2.Matris için\n" + satir2 + ". satırın " + sütun2 + ". sütunundaki değeri : " + deger2[0]);
                  
                }
       
            }
            

            
           if (btnizibul != 0)
            {
                sw.WriteLine("**********************");
                sw.WriteLine("Matrisin İzi:");
                if (txtsonuc.Text == "")
                {
                    sw.WriteLine("Herhangi bir işlem yapılmadı");
                }
                else
                {
                    sw.WriteLine("1.Matris'in izi = {0}", toplam1[0]);
                    sw.WriteLine("2.Matris'in izi ={0}", toplam2[0]);
                }
                
            }
            
           if (btntranspoz != 0)
            {
                sw.WriteLine("**********************");
                sw.WriteLine("Matrislerin Transpozlari:");
                if (eklenentranspozbutonu==0)
                {
                    sw.WriteLine("Herhangi bir işlem yapılmadı");
                }
                else
                {
                    sw.WriteLine("1.MATRİSİN TRANSPOZU:");

                    for (int i = 0; i <= transpozematris1.GetUpperBound(0); i++)
                    {

                        sw.Write("|");
                        for (int j = 0; j <= transpozematris1.GetUpperBound(1); j++)
                        {

                            sw.Write(transpozematris1[i, j] + "  ");
                        }
                        sw.WriteLine("|");

                    }
                    sw.Write("\n");
                    sw.WriteLine("2.MATRİSİN TRANSPOZU:");
                    for (int i = 0; i <= transpozematris2.GetUpperBound(0); i++)
                    {

                        sw.Write("|");
                        for (int j = 0; j <= transpozematris2.GetUpperBound(1); j++)
                        {
                            sw.Write(transpozematris2[i, j] + "  ");
                        }
                        sw.WriteLine("|");

                    }
                }
                
            }
            else
            {
                sw.WriteLine("Daha fazla işlem yapılmadı!!!");
            }
            
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        int buttonyazdır = 0;
        public int[,] matris1 { get; set; }
        public int[,] matris2 { get; set; }
        public int[,] toplamsonuc { get; set; }
        public int[,] carpımsonuc { get; set; }


        string dosya_yolu = @"C:\Users\cotan\Desktop\ndp ödev2\SORU2\kayit.txt";
        int sayi;
        private void btn_yazdir_Click(object sender, EventArgs e)
        {

            buttonyazdır++;
            btn_anamenü.Left = 39;
            btn_anamenü.Top = 291;
            btn_anamenü.Width = 602;
            btn_anamenü.Height = 51;
            this.Height = 400;
            this.Width = 700;
            kontrollerigizle();

            Controls.Add(Rchmatris1);
            Controls.Add(Rchmatris2);
            Controls.Add(btn_anamenü);
            btn_anamenü.Click += new EventHandler(btn_anamenü_Click);



            if (buttonyazdır > 1)
            {
                Rchmatris1.Left = 38;
                Rchmatris1.Top = 50;
                Rchmatris2.Left = 347;
                Rchmatris2.Top = 50;
                matrisleriyazdir();

            }

            else
            {
                Rchmatris1.Left = 38;
                Rchmatris1.Top = 50;
                Rchmatris2.Left = 347;
                Rchmatris2.Top = 50;
                matrisleriyazdir();
                TextWriter tw = new StreamWriter(dosya_yolu);
                tw.Write("");
                tw.Close();
                matrislerimetindosyasınaişle();

            }



        }
        private void btn_anamenü_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            this.Height = 350;
            this.Width = 500;
            kontrollerigerial();
            Controls.Remove(Rchmatris2);
            Controls.Remove(Rchmatris1);
            Controls.Remove(btn_anamenü);
            
            if (btnokuma != 0)
            {
                Controls.Remove(lblmatrissecim);
                Controls.Remove(rdnmatris1);
                Controls.Remove(rdnmatris2);
                Controls.Remove(lblsatir);
                Controls.Remove(lblsütun);
                Controls.Remove(txtsatir);
                Controls.Remove(txtsütun);
                Controls.Remove(lbldeger);
                Controls.Remove(txtdeger);
                Controls.Remove(degerokut);
            }
            if (btnizibul != 0)
            {
                Controls.Remove(sonuc);
                Controls.Remove(txtsonuc);
                Controls.Remove(lblsecim);
                Controls.Remove(btn_anamenü);
                Controls.Remove(rchizmatrisi);
                Controls.Remove(rdnmatris1);
                Controls.Remove(rdnmatris2);
                Controls.Remove(hesapla);
            }
            if (btntranspoz != 0)
            {
                Controls.Remove(rdnmatris_1);
                Controls.Remove(rdnmatris_2);
                Controls.Remove(btntranspoze);
                
            }
            
            if (butonmetindosyasigöster != 0)
            {
                Controls.Remove(Rchmetindosyasigöster);
            }
            

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*1 veya 0 girdiğinde uyarı mesajı vericek ve butonları devre dışı bırakacağım
             else de butonları tekrar erişebilir yapmamın nedeni kullanıcı ilk başda 0 veya 1 girip sonradan 2,3... değerlerini 
            girdiğinde işlemlerini yapsın diye  öyle yaptım.*/
            sayi = int.Parse(textBox1.Text);
            if (sayi == 0 || sayi == 1)
            {
                MessageBox.Show("Kare matris oluşturmak için en az 2 değerini girmelisinizi!!!");
                btn_yazdir.Enabled = false;
                btn_topla.Enabled = false;
                btn_carp.Enabled = false;
                btn_okuma.Enabled = false;
                btn_tersial.Enabled = false;
                btn_izbul.Enabled = false;
                btn_transpoze.Enabled = false;
                btn_metindosyasıgöster.Enabled = false;
            }
            else
            {
                btn_yazdir.Enabled = true;
                btn_topla.Enabled = true;
                btn_carp.Enabled = true;
                btn_okuma.Enabled = true;
                btn_tersial.Enabled = true;
                btn_izbul.Enabled = true;
                btn_transpoze.Enabled = true;
                btn_metindosyasıgöster.Enabled = true;
                matris1 = new int[sayi, sayi];
                matris2 = new int[sayi, sayi];
                matris.yazdir(sayi, matris1, matris2);
            }
            
        }
        int butontoplama = 0;
        private void btn_topla_Click(object sender, EventArgs e)
        {
            butontoplama++;
            matrisleriyazdir();
            btn_anamenü.Click += new EventHandler(btn_anamenü_Click);
            this.Width = 1086;
            this.Height = 450;
            Rchmatris1.Width = 293;
            Rchmatris1.Height = 235;
            Rchmatris2.Width = 293;
            Rchmatris2.Height = 235;
            Rchmatris1.Left = 39;
            Rchmatris1.Top = 50;
            Rchmatris2.Left = 375;
            Rchmatris2.Top = 50;
            btn_anamenü.Left = 215;
            btn_anamenü.Top = 302;
            btn_anamenü.Width = 602;
            btn_anamenü.Height = 51;
            kontrollerigizle();
            Controls.Add(Rchmatris1);
            Controls.Add(Rchmatris2);
            Controls.Add(Rchsonuc);
            Controls.Add(lblsembol);
            Controls.Add(lblesitsembol);
            Controls.Add(btn_anamenü);
            lblsembol.Text = "+";

            if (butontoplama > 1)
            {
                Rchmatris1.Top = 50;

                Rchsonuc.Clear();
                for (int i = 0; i <= toplamsonuc.GetUpperBound(0); i++)
                {

                    for (int j = 0; j <= toplamsonuc.GetUpperBound(1); j++)
                    {
                        Rchsonuc.Text += toplamsonuc[i, j] + "\t";

                    }

                    Rchsonuc.Text += "\n";

                }

            }
            else
            {
                Rchsonuc.Clear();
                Rchmatris1.Top = 50;
                toplamsonuc = new int[matris1.GetUpperBound(0) + 1, matris1.GetUpperBound(1) + 1];
                matris.topla(matris1, matris2, toplamsonuc);
                for (int i = 0; i <= toplamsonuc.GetUpperBound(0); i++)
                {

                    for (int j = 0; j <= toplamsonuc.GetUpperBound(1); j++)
                    {
                        Rchsonuc.Text += toplamsonuc[i, j] + "\t";

                    }

                    Rchsonuc.Text += "\n";

                }

                matrislerimetindosyasınaişle();
            }


        }
        int butoncarpma = 0;
        private void btn_carp_Click(object sender, EventArgs e)
        {
            butoncarpma++;
            matrisleriyazdir();
            btn_anamenü.Click += new EventHandler(btn_anamenü_Click);
            this.Width = 1086;
            this.Height = 450;
            lblsembol.Text = "X";
            Rchmatris1.Width = 293;
            Rchmatris1.Height = 235;
            Rchmatris2.Width = 293;
            Rchmatris2.Height = 235;
            Rchmatris1.Left = 39;
            Rchmatris1.Top = 50;
            Rchmatris2.Left = 375;
            Rchmatris2.Top = 50;
            btn_anamenü.Left = 215;
            btn_anamenü.Top = 302;
            btn_anamenü.Width = 602;
            btn_anamenü.Height = 51;
            kontrollerigizle();
            Controls.Add(Rchmatris1);
            Controls.Add(Rchmatris2);
            Controls.Add(Rchsonuc);
            Controls.Add(lblsembol);
            Controls.Add(lblesitsembol);
            Controls.Add(btn_anamenü);
            if (butoncarpma > 1)
            {
                Rchmatris1.Top = 50;
                lblsembol.Text = "X";
                Rchsonuc.Clear();
                for (int i = 0; i <= carpımsonuc.GetUpperBound(0); i++)
                {

                    for (int j = 0; j <= carpımsonuc.GetUpperBound(1); j++)
                    {
                        Rchsonuc.Text += carpımsonuc[i, j] + "\t";

                    }

                    Rchsonuc.Text += "\n";

                }

            }
            else
            {
                Rchmatris1.Top = 50;
                Rchsonuc.Clear();
                carpımsonuc = new int[matris1.GetUpperBound(0) + 1, matris1.GetUpperBound(1) + 1];
                matris.carpma(matris1, matris2, carpımsonuc);
                for (int i = 0; i <= carpımsonuc.GetUpperBound(0); i++)
                {

                    for (int j = 0; j <= carpımsonuc.GetUpperBound(1); j++)
                    {
                        Rchsonuc.Text += carpımsonuc[i, j] + "\t";

                    }

                    Rchsonuc.Text += "\n";

                }
                matrislerimetindosyasınaişle();
            }
        }
        int btnokuma = 0;
        private void btn_okuma_Click(object sender, EventArgs e)
        {
            btnokuma++;
            kontrollerigizle();
           
            btn_anamenü.Click += new EventHandler(btn_anamenü_Click);
            degerokut.Click += new EventHandler(degerokut_Click);
            rdnmatris1.Click += new EventHandler(rdnmatris1_CheckedChanged);
            rdnmatris2.Click += new EventHandler(rdnmatris2_CheckedChanged);
            txtsatir.KeyPress += new KeyPressEventHandler(txtsatir_KeyPress);
            txtsütun.KeyPress += new KeyPressEventHandler(txtsütun_KeyPress);
            rdn1 = rdnmatris1.Checked;
            rdn2 = rdnmatris2.Checked;
            this.Width = 881;
            this.Height = 410;
            rdnmatris1.Left = 323;
            rdnmatris1.Top = 28;
            rdnmatris2.Left = 431;
            rdnmatris2.Top = 28;
            btn_anamenü.Width = 554;
            btn_anamenü.Height = 51;
            btn_anamenü.Left = 27;
            btn_anamenü.Top = 291;
            Rchmatris1.Left = 557;
            Rchmatris1.Top = 30;
            Controls.Add(degerokut);
            Controls.Add(Rchmatris1);
            Controls.Add(btn_anamenü);
            Controls.Add(lblmatrissecim);
            Controls.Add(rdnmatris1);
            Controls.Add(rdnmatris2);
            Controls.Add(lblsatir);
            Controls.Add(lblsütun);
            Controls.Add(txtsatir);
            Controls.Add(txtsütun);
            Controls.Add(lbldeger);
            Controls.Add(txtdeger);
            Rchmatris1.Clear();
            if (rdnmatris1.Checked == true)
            {
                for (int i = 0; i <= matris1.GetUpperBound(0); i++)
                {

                    Rchmatris1.Text += "|";

                    for (int j = 0; j <= matris1.GetUpperBound(1); j++)
                    {
                        Rchmatris1.Text += matris1[i, j] + "  ";

                    }
                    Rchmatris1.Text += "|";
                    Rchmatris1.Text += "\n";
                }
            }
            else
            {
                for (int i = 0; i <= matris2.GetUpperBound(0); i++)
                {

                    Rchmatris1.Text += "|";

                    for (int j = 0; j <= matris2.GetUpperBound(1); j++)
                    {
                        Rchmatris1.Text += matris2[i, j] + "  ";

                    }
                    Rchmatris1.Text += "|";
                    Rchmatris1.Text += "\n";
                }
            }
            if (butondegerokut == 0)
            {
                txtdeger.Text = "İşlem Yapılmadı";
                
            }
            

        }
        int satir1, satir2, sütun1, sütun2;
        int[] deger1 = new int[1]; /*burada int kullanarak yapmaya çalıştım olmadı . parametreye bu int i gönderdiğimde unnecessary assignmetn of to value diye altını beyaz çiziyordu.
                                   dizinin değerini convertoint32 ile çevirmeye çalıştım yine aynı sorun bende tek elemanlı dizi tanımladım */
        int[] deger2 = new int[1];
        bool rdn1, rdn2;
        int butondegerokut=0;
        private void txtsatir_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxa sadece rakam girişi yapıyor.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtsütun_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxa sadece rakam girişi yapıyor.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void degerokut_Click(object sender, EventArgs e)
        {
            
            butondegerokut++;
            rdn1 = rdnmatris1.Checked;
            rdn2 = rdnmatris2.Checked;
            if (rdn1)
            {
                satir1 = int.Parse(txtsatir.Text);
                sütun1 = int.Parse(txtsütun.Text);
                matris.degerokuma(satir1, sütun1, matris1, matris2, deger1, rdn1, rdn2);
                txtdeger.Text = deger1[0].ToString();
                matrislerimetindosyasınaişle();
            }
            else
            {
                satir2 = int.Parse(txtsatir.Text);
                sütun2 = int.Parse(txtsütun.Text);
                matris.degerokuma(satir2, sütun2, matris1, matris2, deger2, rdn1, rdn2);
                txtdeger.Text = deger2[0].ToString();
                matrislerimetindosyasınaişle();
            }
            
        }
        
        private void rdnmatris1_CheckedChanged(object sender, EventArgs e)
        {
            
            Rchmatris1.Clear();
            rchizmatrisi.Clear();
            for (int i = 0; i <= matris1.GetUpperBound(0); i++)
            {

                Rchmatris1.Text += "|";
                rchizmatrisi.Text += "|";
                for (int j = 0; j <= matris1.GetUpperBound(1); j++)
                {
                    Rchmatris1.Text += matris1[i, j] + "  ";
                    rchizmatrisi.Text += matris1[i, j] + "  ";

                }
                Rchmatris1.Text += "|";
                Rchmatris1.Text += "\n";
                rchizmatrisi.Text += "|";
                rchizmatrisi.Text += "\n";

            }

        }
        
        private void rdnmatris2_CheckedChanged(object sender, EventArgs e)
        {

            
            Rchmatris1.Clear();
            rchizmatrisi.Clear();
            for (int i = 0; i <= matris2.GetUpperBound(0); i++)
            {

                Rchmatris1.Text += "| ";
                rchizmatrisi.Text += "| ";
                for (int j = 0; j <= matris2.GetUpperBound(1); j++)
                {
                    Rchmatris1.Text += matris2[i, j] + "  ";
                    rchizmatrisi.Text += matris2[i, j] + "  ";

                }
                Rchmatris1.Text += "|";
                Rchmatris1.Text += "\n";
                rchizmatrisi.Text += "|";
                rchizmatrisi.Text += "\n";

            }

        }
        private void rdnmatris_1_CheckedChanged(object sender, EventArgs e)
        {
                Rchmatris1.Clear();
                Rchmatris2.Clear();
                for (int i = 0; i <= matris1.GetUpperBound(0); i++)
                {

                    Rchmatris1.Text += "|";
                    for (int j = 0; j <= matris1.GetUpperBound(1); j++)
                    {
                        Rchmatris1.Text += matris1[i, j] + "  ";
                    }
                    Rchmatris1.Text += "|";
                    Rchmatris1.Text += "\n";
                }
     
        }
        private void rdnmatris_2_CheckedChanged(object sender, EventArgs e)
        {
                Rchmatris1.Clear();
                Rchmatris2.Clear();
                for (int i = 0; i <= matris2.GetUpperBound(0); i++)
                {

                    Rchmatris1.Text += "|";
                    for (int j = 0; j <= matris2.GetUpperBound(1); j++)
                    {
                        Rchmatris1.Text += matris2[i, j] + "  ";
                    }
                    Rchmatris1.Text += "|";
                    Rchmatris1.Text += "\n";
                }
          
        }

        

        private void btn_tersial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bunu yapamadım.");
        }
        int btnizibul = 0;
        private void btn_izbul_Click(object sender, EventArgs e)
        {
            kontrollerigizle();
            btnizibul++;
            
            this.Width = 870;
            this.Height = 287;
            rdnmatris1.Left = 323;
            rdnmatris1.Top = 28;
            rdnmatris2.Left = 431;
            rdnmatris2.Top = 28;
            rdnmatris1.Font = new Font("Arial", 10);
            rdnmatris2.Font = new Font("Arial", 10);
            btn_anamenü.Click += new EventHandler(btn_anamenü_Click);
            hesapla.Click += new EventHandler(hesapla_Click);
            rdnmatris1.Click += new EventHandler(rdnmatris1_CheckedChanged);
            rdnmatris2.Click += new EventHandler(rdnmatris2_CheckedChanged);
            sonuc.Click += new EventHandler(sonuc_TextChanged);
            btn_anamenü.Left = 16;
            btn_anamenü.Top = 183;
            btn_anamenü.Width = 554;
            btn_anamenü.Height = 51;
            Controls.Add(hesapla);
            Controls.Add(rdnmatris1);
            Controls.Add(rdnmatris2);
            Controls.Add(sonuc);
            Controls.Add(txtsonuc);
            Controls.Add(lblsecim);
            Controls.Add(btn_anamenü);
            Controls.Add(rchizmatrisi);
            if (rdnmatris1.Checked == true)
            {
                for (int i = 0; i <= matris1.GetUpperBound(0); i++)
                {

                    Rchmatris1.Text += "|";
                    for (int j = 0; j <= matris1.GetUpperBound(1); j++)
                    {

                        Rchmatris1.Text += matris1[i, j] + "  ";
                    }
                    Rchmatris1.Text += "|";
                    Rchmatris1.Text += "\n";
                }
            }
            else
            {
                for (int i = 0; i <= matris2.GetUpperBound(0); i++)
                {

                    Rchmatris1.Text += "|";
                    for (int j = 0; j <= matris2.GetUpperBound(1); j++)
                    {

                        Rchmatris1.Text += matris2[i, j] + "  ";
                    }
                    Rchmatris1.Text += "|";
                    Rchmatris1.Text += "\n";
                }
            }
            if (izbulbutonu == 0) { matrislerimetindosyasınaişle(); }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_yazdir.Enabled = false;
            btn_topla.Enabled = false;
            btn_carp.Enabled = false;
            btn_okuma.Enabled = false;
            btn_tersial.Enabled = false;
            btn_izbul.Enabled = false;
            btn_transpoze.Enabled = false;
            btn_metindosyasıgöster.Enabled = false;
            TextWriter tw = new StreamWriter(dosya_yolu);
            tw.Write("");
            tw.Close();
            MessageBox.Show("Textboxa değer girdiğinizde otamatik olarak matris oluşturuyor.");
            
            
        }


        private void sonuc_TextChanged(object sender, EventArgs e)
        {

        }
        
        int btntranspoz = 0;
        bool rdn_1;
        private void btn_transpoze_Click(object sender, EventArgs e)
        {
            Rchmatris1.Clear();
            btntranspoz++;
            kontrollerigizle();
            rdnmatris_1.Click += new EventHandler(rdnmatris_1_CheckedChanged);
            rdnmatris_2.Click += new EventHandler(rdnmatris_2_CheckedChanged);
            btn_anamenü.Click += new EventHandler(btn_anamenü_Click);
            btntranspoze.Click += new EventHandler(btntranspoze_Click);
            this.Width = 870;
            this.Height = 287;
            btn_anamenü.Left = 27;
            btn_anamenü.Top = 184;
            btn_anamenü.Width = 247;
            btn_anamenü.Height = 51;
            Rchmatris1.Left = 295;
            Rchmatris1.Top = 28;
            Rchmatris2.Left = 570;
            Rchmatris2.Top = 28;
            Rchmatris1.Width = 274;
            Rchmatris1.Height = 206;
            Rchmatris2.Width = 274;
            Rchmatris2.Height = 206;
            Rchmatris2.Clear();
            Controls.Add(rdnmatris_1);
            Controls.Add(rdnmatris_2);
            Controls.Add(btn_anamenü);
            Controls.Add(Rchmatris1);
            Controls.Add(Rchmatris2);
            Controls.Add(btntranspoze);
            Rchmatris2.Clear();
            Rchmatris1.Clear();
            if (rdnmatris_1.Checked == true)
            {
                for (int i = 0; i <= matris1.GetUpperBound(0); i++)
                {
                    
                    Rchmatris1.Text += "|";
                    for (int j = 0; j <= matris1.GetUpperBound(1); j++)
                    {

                        Rchmatris1.Text += matris1[i, j] + "  ";
                        
                    }
                    Rchmatris1.Text += "|";
                    Rchmatris1.Text += "\n";
                  
                }


            }
            else
            {
                for (int i = 0; i <= matris2.GetUpperBound(0); i++)
                {
                   
                    Rchmatris1.Text += "|";
                    for (int j = 0; j <= matris2.GetUpperBound(1); j++)
                    {

                        Rchmatris1.Text += matris2[i, j] + "  ";
                       
                    }
                    Rchmatris1.Text += "|";
                    Rchmatris1.Text += "\n";
                    
                }
            }
            if (eklenentranspozbutonu == 0)
            {
                matrislerimetindosyasınaişle();
            }
        }
        int[] toplam1 = new int[1];
        int[] toplam2 = new int[1];
        int butonmetindosyasigöster = 0;
        private void btn_metindosyasıgöster_Click(object sender, EventArgs e)
        {
            Rchmetindosyasigöster.Text = "";
            
            btn_anamenü.Click += new EventHandler(btn_anamenü_Click);
            butonmetindosyasigöster++;
            kontrollerigizle();
            this.Width = 964;
            this.Height = 750;
            btn_anamenü.Left = 13;
            btn_anamenü.Top = 636;
            btn_anamenü.Width = 915;
            btn_anamenü.Height = 47;
            Controls.Add(btn_anamenü);
            Controls.Add(Rchmetindosyasigöster);
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                Rchmetindosyasigöster.Text += yazi + "\n";
                yazi = sw.ReadLine();
                
            }
            sw.Close();
            fs.Close();
        }
        int izbulbutonu = 0;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxa sadece rakam girişi yapıyor.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            izbulbutonu++;
            rdn1 = rdnmatris1.Checked;
            rdn2 = rdnmatris2.Checked;

            if (rdn1)
            {
                matris.izibulma(matris1, toplam1);
                txtsonuc.Text = toplam1[0].ToString();
                matrislerimetindosyasınaişle();
            }
            else
            {

                matris.izibulma(matris2, toplam2);
                txtsonuc.Text = toplam2[0].ToString();
                matrislerimetindosyasınaişle();
            }
        }
        int[,] transpozematris1, transpozematris2;
        int eklenentranspozbutonu = 0;
        private void btntranspoze_Click(object sender, EventArgs e)
        {
            eklenentranspozbutonu++;
            transpozematris1 = new int[matris1.GetUpperBound(0) + 1, matris1.GetUpperBound(1) + 1];
            transpozematris2 = new int[matris2.GetUpperBound(0) + 1, matris2.GetUpperBound(1) + 1];
            for(int i = 0; i <= matris1.GetUpperBound(0); i++)
            {
                for(int j=0;j<= matris1.GetUpperBound(0); j++)
                {
                    transpozematris1[i, j] = matris1[i, j];
                    transpozematris2[i, j] = matris2[i, j];
                }
            }           

            rdn_1 = rdnmatris_1.Checked;
            
            matris.transpozet(transpozematris1);
            matris.transpozet(transpozematris2);
            
            
            if (rdn_1)
            {
                Rchmatris2.Clear();
                for (int i = 0; i <= transpozematris1.GetUpperBound(0); i++)
                {

                    Rchmatris2.Text += "|";
                    for (int j = 0; j <= transpozematris1.GetUpperBound(1); j++)
                    {
                        
                        Rchmatris2.Text += transpozematris1[i, j] + "  ";
                    }
                    Rchmatris2.Text += "|";
                    Rchmatris2.Text += "\n";
                }
            }
            else
            {
                Rchmatris2.Clear();
                for (int i = 0; i <= transpozematris2.GetUpperBound(0); i++)
                {

                    Rchmatris2.Text += "|";
                    for (int j = 0; j <= transpozematris2.GetUpperBound(1); j++)
                    {
                        
                        Rchmatris2.Text += transpozematris2[i, j] + "  ";
                    }
                    Rchmatris2.Text += "|";
                    Rchmatris2.Text += "\n";
                }
            }

            matrislerimetindosyasınaişle();


        }
    }
}
