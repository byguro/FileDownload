using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloader
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        public static HttpWebRequest dIstek;
        public static HttpWebResponse dYanit;
        public static Stream strLocal, strYanit;
        public delegate void Guncelle(Int64 okunanInt, Int64 tamamInt, string fileUri);
        public string ImageServer = "";
        static string _saveFilePath { get; set; }
        public string saveFilePath
        {
            get
            {
                return _saveFilePath;
            }
            set
            {
                txtSaveFilePath.Text = value;
                _saveFilePath = value;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadProccess();
        }

        public void durumGuncelle(Int64 okunan_, Int64 tamami_, string fileUri)
        {
            int yuzdeDeger = Convert.ToInt32((okunan_ * 100 / tamami_));
            drmProgress.Value = yuzdeDeger;

            int indirilenKB = Convert.ToInt32(okunan_ / 1024);
            int tamamiKB = Convert.ToInt32(tamami_ / 1024);

            string durum = string.Format("{3}{4}İndirilen : {0} KB | Tamamı : {1} | İndirme Durum : {2}", indirilenKB, tamamiKB, yuzdeDeger, fileUri, Environment.NewLine);
            lblBilgi.Text = durum;
        }

        public void DownloadIslem(string fileUri)
        {
            if (File.Exists(saveFilePath + fileUri)) return;

            try
            {
                using (WebClient dWebClient = new WebClient())
                {
                    dIstek = (HttpWebRequest)WebRequest.Create(new Uri(ImageServer + fileUri));
                    dIstek.Credentials = CredentialCache.DefaultCredentials;
                    dIstek.Proxy = WebRequest.GetSystemWebProxy();
                    dIstek.UserAgent = ".New 4.0 HTTP Downloader";
                    dIstek.Timeout = 1800000;
                    dIstek.AllowAutoRedirect = false;
                    dYanit = (HttpWebResponse)dIstek.GetResponse();

                    Int64 dosyaBoyutu = dYanit.ContentLength;
                    strYanit = dWebClient.OpenRead(new Uri(ImageServer + fileUri));

                     var fname = fileUri.Substring(fileUri.LastIndexOf("/")+1,fileUri.Length- fileUri.LastIndexOf("/")-1);

                    strLocal = new FileStream(saveFilePath + fname, FileMode.Create, FileAccess.Write, FileShare.None);

                    int byteOkunan = 0;

                    byte[] indirmeAkisi = new byte[2048];
                    while ((byteOkunan = strYanit.Read(indirmeAkisi, 0, indirmeAkisi.Length)) > 0)
                    {
                        strLocal.Write(indirmeAkisi, 0, byteOkunan);
                        this.Invoke(new Guncelle(durumGuncelle), new object[] { strLocal.Length, dosyaBoyutu, fileUri });
                    }

                }
            }
            catch (WebException exp)
            {
                if (exp.Status == WebExceptionStatus.ProtocolError)
                {
                    MessageBox.Show("Protokol hatasına uğradı\n" + exp.Message, "Protocol Exception");
                }
                else if (exp.Status == WebExceptionStatus.Timeout)
                {
                    MessageBox.Show("Time out hatası", "Timeout Exception");
                }
                else
                {
                    MessageBox.Show(exp.Message, "General Exception");
                }
            }
            finally
            {
                if (strLocal != null)
                    strLocal.Close();
                if (strYanit != null)
                    strYanit.Close();
                if (dYanit != null)
                    dYanit.Close();
            }


        }

        public void DownloadProccess()
        {
            if (!Control_FileText()) return;

            //if (!Control_ServerUrl()) return;

            if (!Control_SaveFilePath()) return;
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread myTask = new Thread(DownloadProccessAsync);
            btnDownload.Visible = false;
            myTask.Start();
        }

        private void DownloadProccessAsync()
        {

            List<string> fileList = txtFiles.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None).ToList();
            ImageServer = txtImageServerUrl.Text;

            foreach (var file in fileList)
            {
                DownloadIslem(file);
            }
            btnDownload.Visible = true;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = directchoosedlg.SelectedPath + @"\";
            }
            else {
                saveFilePath = "";
            }
        }

        #region Controls
        private bool Control_SaveFilePath()
        {
            var kontrol = false;

            if (string.IsNullOrEmpty(txtSaveFilePath.Text))
            {
                MessageBox.Show("Dosyaların kayıt edileceği dizini seçmediniz. Dosya yolu seçip indirme işlemini başlatınız.", "Dosya dizini seçilmedi");
            }
            else
            {
                kontrol = true;
            }
            return kontrol;
        }

        private bool Control_FileText()
        {
            var kontrol = false;

            if (string.IsNullOrEmpty(txtFiles.Text))
            {
                MessageBox.Show("Metin alanına dosya adını, uzantısı ile girip, her dosya için alt satıra geçiniz", "Metin alanı boş");
            }
            else
            {
                kontrol = true;
            }
            return kontrol;
        }

        private bool Control_ServerUrl()
        {
            var kontrol = false;

            if (string.IsNullOrEmpty(txtImageServerUrl.Text))
            {
                MessageBox.Show("İndirilecek dosyaların bulunduğu URL i boş bırakmayınız", "Image server URL alanı boş");
            }
            else
            {
                kontrol = true;
            }
            return kontrol;
        }
        #endregion
    }
}
