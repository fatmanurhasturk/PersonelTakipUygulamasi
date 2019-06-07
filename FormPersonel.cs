using _04_PersonelTakipUygulamasi.Database;
using _04_PersonelTakipUygulamasi.Entities;
using _04_PersonelTakipUygulamasi.Entity;
using _04_PersonelTakipUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace _04_PersonelTakipUygulamasi
{
    public partial class FormPersonel : Form
    {
        Personel _uzerindeIslemYapilanPersonel;
        public FormPersonel()
        {
            InitializeComponent();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            Helper.ComboBoxDoldur(cmbDepartmanlar, Db_Context.Departmanlar);
            ListViewYukle(Db_Context.Personeller);
        }
        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region Validation
            //validation => errorprovider
            errorProvider.Clear();
            string butunHatalar = "";
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                errorProvider.SetError(txtAd, "Ad bölümü boş geçilemez.");
                butunHatalar += "- Ad bölümü boş geçilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                errorProvider.SetError(txtSoyad, "Soyad bölümü boş geçilemez.");
                butunHatalar += "- Soyad bölümü boş geçilemez.\n";
            }
            if ((DateTime.Now - dtpDogumTarihi.Value.Date).TotalDays / 365 < 18)
            {
                errorProvider.SetError(dtpDogumTarihi, "18 yaşından küçükler personel olamaz.");
                butunHatalar += "- 18 yaşından küçükler personel olamaz.\n";
            }
            if (!(rdbErkek.Checked || rdbKadin.Checked || rdbDiger.Checked))
            {
                errorProvider.SetError(pnlCinsiyet, "Cinsiyet Seçimi yapılmadı.");
                butunHatalar += "- Cinsiyet Seçimi yapılmadı.\n";
            }
            if (cmbDepartmanlar.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbDepartmanlar, "Departman seçimi yapılmalıdır.");
                butunHatalar += "- Departman seçimi yapılmalıdır.\n";
            }

            //hata kontrolü
            if (dtpIseBaslamaTarihi.Value < dtpDogumTarihi.Value.AddYears(18))
            {
                errorProvider.SetError(dtpDogumTarihi, "18 yaşından küçükler personel olamaz.");
                butunHatalar += "- 18 yaşından küçükler personel olamaz.\n";
            }

            if (butunHatalar.Length > 0)
            {
                MessageBox.Show(butunHatalar);
                return;
            }
            #endregion

            Personel personel = null;
            if (btnKaydet.Text == "KAYDET")
            {
                personel = new Personel();
            }
            else if (btnKaydet.Text == "GÜNCELLE")
            {
                personel = _uzerindeIslemYapilanPersonel;
            }

            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.Adres = txtAdres.Text;
            personel.CocukSayisi = (int)nudCocukSayisi.Value;
            personel.Departman = (Departman)cmbDepartmanlar.SelectedItem;
            personel.DogumTarihi = dtpDogumTarihi.Value.Date;
            personel.Email = txtEmail.Text;
            personel.IseBaslamaTarihi = dtpIseBaslamaTarihi.Value.Date;
            personel.ResimYolu = pcbPersonelResmi.ImageLocation;
            personel.Telefon = mtxtTelefon.Text;
            personel.IsDeleted = false;
            if (rdbBekar.Checked)
            {
                personel.MedeniHal = MedeniHalEnum.Bekar;
            }
            else if (rdbEvli.Checked)
            {
                personel.MedeniHal = MedeniHalEnum.Evli;
            }

            if (rdbKadin.Checked)
            {
                personel.Cinsiyet = CinsiyetEnum.Kadın;
            }
            else if (rdbErkek.Checked)
            {
                personel.Cinsiyet = CinsiyetEnum.Erkek;
            }
            else if (rdbDiger.Checked)
            {
                personel.Cinsiyet = CinsiyetEnum.Diger;
            }

            if (chbA1.Checked)
            {
                personel.Ehliyetler.Add(EhliyetEnum.A1);
            }
            if (chbA2.Checked)
            {
                personel.Ehliyetler.Add(EhliyetEnum.A2);
            }
            if (chbB.Checked)
            {
                personel.Ehliyetler.Add(EhliyetEnum.B);
            }
            if (chbC.Checked)
            {
                personel.Ehliyetler.Add(EhliyetEnum.C);
            }
            if (chbE.Checked)
            {
                personel.Ehliyetler.Add(EhliyetEnum.E);
            }

            Db_Context.Personeller.Add(personel);
            ListViewYukle(Db_Context.Personeller);
            if (btnKaydet.Text == "KAYDET")
            {
                MessageBox.Show("Kayıt işlemi başarılıdır.");
            }
            else if (btnKaydet.Text == "GÜNCELLE")
            {
                MessageBox.Show("Güncelleme işlemi başarılıdır.");
            }

            Helper.ControlTemizle(grbPersonelBilgileri);
            _uzerindeIslemYapilanPersonel = null;
            btnKaydet.Text = "KAYDET";
        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialogResim.ShowDialog();
            if (res == DialogResult.OK)
            {
                pcbPersonelResmi.ImageLocation = openFileDialogResim.FileName;
            }
        }
        private void kaldirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pcbPersonelResmi.Image = null;
        }
        private void grbPersonelBilgileri_Enter(object sender, EventArgs e)
        {

        }
        private void txtAd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                errorProvider.SetError(txtAd, "Ad bölümü boş geçilemez.");
                txtAd.BackColor = Color.Turquoise;
            }
        }
        private void lstPersoneller_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            //secilen personeli yakala
            if (listView.SelectedIndices.Count > 0)
            {
                Helper.ControlTemizle(grbPersonelBilgileri);
                ListViewItem item = listView.SelectedItems[0];
                Personel personel = (Personel)item.Tag;
                //personel propertylerini ilgili controllere ata
                txtAd.Text = personel.Ad;
                txtSoyad.Text = personel.Soyad;
                dtpDogumTarihi.Value = personel.DogumTarihi;

                if (personel.Cinsiyet == CinsiyetEnum.Erkek)
                {
                    rdbErkek.Checked = true;
                }
                else if (personel.Cinsiyet == CinsiyetEnum.Kadın)
                {
                    rdbKadin.Checked = true;
                }
                else if (personel.Cinsiyet == CinsiyetEnum.Diger)
                {
                    rdbDiger.Checked = true;
                }

                mtxtTelefon.Text = personel.Telefon;
                txtEmail.Text = personel.Email;
                txtAdres.Text = personel.Adres;

                cmbDepartmanlar.SelectedItem = personel.Departman;

                dtpIseBaslamaTarihi.Value = personel.IseBaslamaTarihi;

                if (personel.MedeniHal == MedeniHalEnum.Evli)
                {
                    rdbEvli.Checked = true;
                }
                else if (personel.MedeniHal == MedeniHalEnum.Bekar)
                {
                    rdbBekar.Checked = true;
                }

                foreach (var ehliyet in personel.Ehliyetler)
                {
                    if (ehliyet == EhliyetEnum.A1)
                    {
                        chbA1.Checked = true;
                    }
                    else if (ehliyet == EhliyetEnum.A2)
                    {
                        chbA2.Checked = true;
                    }
                    else if (ehliyet == EhliyetEnum.B)
                    {
                        chbB.Checked = true;
                    }
                    else if (ehliyet == EhliyetEnum.C)
                    {
                        chbC.Checked = true;
                    }
                    else if (ehliyet == EhliyetEnum.E)
                    {
                        chbE.Checked = true;
                    }
                }

                nudCocukSayisi.Value = personel.CocukSayisi;
                pcbPersonelResmi.ImageLocation = personel.ResimYolu;
                btnKaydet.Text = "GÜNCELLE";
                _uzerindeIslemYapilanPersonel = personel;
            }


        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            Helper.ControlTemizle(grbPersonelBilgileri);
            _uzerindeIslemYapilanPersonel = null;
            btnKaydet.Text = "KAYDET";
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedIndices.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçilen ögeler silinecektir. Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                foreach (ListViewItem item in lstPersoneller.SelectedItems)
                {
                    Personel personel = (Personel)item.Tag;
                    personel.IsDeleted = true;
                }
                ListViewYukle(Db_Context.Personeller);
            }
        }
        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            if (btnSilinenleriGoster.Text == "Silinenleri Göster")
            {
                ListViewSilinenlerYukle(Db_Context.Personeller);
                btnSilinenleriGoster.Text = "Geri";
            }
            else if (btnSilinenleriGoster.Text == "Geri")
            {
                ListViewYukle(Db_Context.Personeller);
                btnSilinenleriGoster.Text = "Silinenleri Göster";
            }

        }


        private void ListViewSilinenlerYukle(ICollection<Personel> personeller)
        {
            lstPersoneller.Items.Clear();
            foreach (var personel in personeller)
            {
                //Elimdeki collectionun ögelerini tek tek listviewItem a çevir
                if (personel.IsDeleted == false)
                {
                    continue;
                }
                ListViewItem listViewItem = PersonelToListViewItem(personel);
                //List view e ekle lstPersoneller.Items.Add()
                lstPersoneller.Items.Add(listViewItem);
            }

        }
        private void ListViewYukle(ICollection<Personel> personeller)
        {
            lstPersoneller.Items.Clear();
            foreach (var personel in personeller)
            {
                //Elimdeki collectionun ögelerini tek tek listviewItem a çevir
                if (personel.IsDeleted == true)
                {
                    continue;
                }
                ListViewItem listViewItem = PersonelToListViewItem(personel);
                //List view e ekle lstPersoneller.Items.Add()
                lstPersoneller.Items.Add(listViewItem);
            }

        }
        private ListViewItem PersonelToListViewItem(Personel personel)
        {
            string[] degerlerim =
            {
                personel.Ad,
                personel.Soyad,                personel.DogumTarihi.ToShortDateString(),
                personel.Telefon,
                personel.Email,
                personel.Departman.ToString()
            };
            ListViewItem item = new ListViewItem(degerlerim);
            item.Tag = personel;
            return item;
        }

        private void KontrolluHarfAl(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;
            if (!char.IsLetter(karakter) && karakter!=32)
            {
                e.Handled = true;
            }
        }
    }
}
