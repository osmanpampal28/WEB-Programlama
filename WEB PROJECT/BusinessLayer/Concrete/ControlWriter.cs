using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ControlWriter
    {
        Repository<Writer> writerrp = new Repository<Writer>();

        // degerleri listeleme
        public List<Writer> ListAll()
        {
            return writerrp.List();
        }

        //yeni yazar ekleme ve kontrol işlemleri

        public int AddWriterBLayer(Writer p)
        {
            //parametreden gönderilen değerlerin geçerliliğin kontrolleri
            if (p.WriterN_S == "" || p.ShortAbout == "" || p.WriterTitle == "")  //burası artırılabilir{
                return -1;
            return writerrp.Insert(p);
        }

        //yazarı id değerine göre edit sayfasına taşıma
        public Writer FindWriter(int id)
        {
            return writerrp.Find(x => x.WriterID == id);
        }

        public int EditWriter(Writer p)
        {
            Writer writer = writerrp.Find(x => x.WriterID == p.WriterID);
            writer.ShortAbout = p.ShortAbout;
            writer.WriterN_S = p.WriterN_S;
            writer.WriterImage = p.WriterImage;
            writer.WriterAbout = p.WriterAbout;
            writer.WriterTitle = p.WriterTitle;
            writer.Mail = p.Mail;
            writer.Password = p.Password;
            writer.PhoneNumber = p.PhoneNumber;
            return writerrp.Update(writer);
        }
    }
}
