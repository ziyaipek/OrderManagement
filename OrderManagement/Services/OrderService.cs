using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using OrderManagement.Data;
using OrderManagement.Models;

namespace OrderManagement.Services
{
    public class OrderService
    {
        public object GetDualIdentities()
        {
            var dualIdentities = from c in DataRepository.Customers
                                 join s in DataRepository.Suppliers
                                 on c.AssociationNo equals s.AssociationNo
                                 select new
                                 {
                                     SirketAdi = c.Name,
                                     VergiNo = c.AssociationNo,
                                     MusteriKodu = c.CustomerId,
                                     TedarikciKodu = s.SupplierId
                                 };

            return dualIdentities.ToList();
        }

        public List<Order> GetFilteredOrders(string customerId, string state, string orderNo, string date)
        {
            var query = DataRepository.Orders.AsQueryable();

            if (!string.IsNullOrWhiteSpace(customerId))
            {
                query = query.Where(o => o.CustomerNo.Contains(customerId.ToUpper()));
            }

            if (!string.IsNullOrWhiteSpace(state) && state != "All")
            {
                query = query.Where(o => o.State == state);
            }

            if (!string.IsNullOrWhiteSpace(orderNo))
            {
                query = query.Where(o => o.OrderNo.Contains(orderNo));
            }

            if (!string.IsNullOrWhiteSpace(date))
            {
                query = query.Where(o => o.DateEntered.Contains(date));
            }

            return query.ToList();
        }

        public void SendOrderEmail(Order order, string toEmail)
        {
            if (order == null || string.IsNullOrWhiteSpace(toEmail))
                throw new ArgumentException("Sipariş bilgisi veya mail adresi eksik.");

            MailMessage mail = new MailMessage();

            // Mail Adresi
            string gonderenMail = "mail@gmail.com";
            // Gmail Uygulama Şifresi
            string uygulamaSifresi = "xxxx xxxx xxxx xxxx";

            mail.From = new MailAddress(gonderenMail, "Sipariş Sistemi");
            mail.To.Add(toEmail);
            mail.Subject = $"Sipariş Detayı: {order.OrderNo}";

            mail.IsBodyHtml = true;
            mail.Body = $@"
                <div style='font-family: Arial, sans-serif; padding: 20px;'>
                    <h2 style='color: #2c3e50;'>Sipariş Bilgi Formu</h2>
                    <table border='1' cellpadding='10' cellspacing='0' style='border-collapse: collapse; width: 100%; max-width: 600px;'>
                        <tr style='background-color: #f8f9fa;'>
                            <td style='font-weight: bold; width: 150px;'>Sipariş No:</td>
                            <td>{order.OrderNo}</td>
                        </tr>
                        <tr>
                            <td style='font-weight: bold;'>Müşteri Kodu:</td>
                            <td>{order.CustomerNo}</td>
                        </tr>
                        <tr style='background-color: #f8f9fa;'>
                            <td style='font-weight: bold;'>Kayıt Tarihi:</td>
                            <td>{order.DateEntered}</td>
                        </tr>
                        <tr>
                            <td style='font-weight: bold;'>Sipariş Durumu:</td>
                            <td><b style='color: #e74c3c;'>{order.State}</b></td>
                        </tr>
                        <tr style='background-color: #f8f9fa;'>
                            <td style='font-weight: bold;'>IFS Objkey:</td>
                            <td style='font-size: 12px;'>{order.Objkey}</td>
                        </tr>
                    </table>
                    <p style='margin-top: 20px; font-size: 12px; color: #7f8c8d;'>Bu mail sistem tarafından otomatik olarak gönderilmiştir.</p>
                </div>";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(gonderenMail, uygulamaSifresi);
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}