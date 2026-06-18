# Order Management System (Teknik Değerlendirme Projesi)

Bu proje, teknik değerlendirme süreci kapsamında geliştirilmiş bir sipariş yönetim ve takip uygulamasıdır. Windows Forms kullanılarak geliştirilmiş olup, müşteri sipariş detaylarına ulaşılmasını ve bu detayların e-posta ile paylaşılmasını sağlar.

## 🚀 Özellikler

- **Çift Kimlik Tespiti:** Hem müşteri hem de tedarikçi olarak açılan ortak vergi/kimlik numarasına sahip firmaların tespiti ve listelenmesi.
- **Detaylı Sipariş Filtreleme:** Müşteri numarası, sipariş durumu (Planned, Released, Delivered vb.), sipariş numarası ve tarih kriterlerine göre tek ekran üzerinden dinamik sorgulama.
- **Anlık E-posta Gönderimi:** Seçilen sipariş bilgilerinin anlık olarak istenen mail adresine gönderilmesi.

## 🛠️ Kullanılan Teknolojiler

- **Dil:** C#
- **Platform:** .NET 8.0
- **Arayüz:** Windows Forms
- **Mimari:** Katmanlı Mimari (Modeller, Servisler, Veri, Form Arayüzü)

## 💻 Nasıl Çalıştırılır?

1. Bu projeyi bilgisayarınıza klonlayın veya `.zip` olarak indirin:
   ```bash
   git clone [https://github.com/ziyaipek/OrderManagement.git](https://github.com/ziyaipek/OrderManagement.git)
   ```

2. İndirdiğiniz klasördeki .sln uzantılı solution dosyasını Visual Studio ile açın.
3. Proje içerisinde sabit bir veri seti (Mock Data) kullanılmıştır, herhangi bir veritabanı kurulumuna gerek yoktur.
4. Üst menüden Start (Başlat) butonuna basarak projeyi anında çalıştırabilir ve test edebilirsiniz.

**Geliştirici:** Ziya İpek
