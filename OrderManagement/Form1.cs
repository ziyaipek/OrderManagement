using System;
using System.Windows.Forms;
using OrderManagement.Models;
using OrderManagement.Services;

namespace OrderManagement
{
    public partial class Form1 : Form
    {
        private OrderService _orderService;

        public Form1()
        {
            InitializeComponent();
            dgvListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListe.BackgroundColor = System.Drawing.SystemColors.Window;
            _orderService = new OrderService();

            cmbState.Items.Clear();
            cmbState.Items.AddRange(new string[] {
                "All",
                "Planned",
                "Released",
                "Delivered",
                "Cancelled",
                "Invoiced/Closed",
                "Picked",
                "Reserved",
                "Blocked",
                "Partially Delivered"
            });

            cmbState.SelectedIndex = 0;

            dgvListe.DataSource = _orderService.GetFilteredOrders("", "", "", "");
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            string state = cmbState.SelectedItem?.ToString();
            string orderNo = txtOrderNo.Text;
            string date = txtDate.Text;

            var filteredOrders = _orderService.GetFilteredOrders(customerId, state, orderNo, date);
            dgvListe.DataSource = filteredOrders;
        }

        private void btnCiftKimlik_Click(object sender, EventArgs e)
        {
            var dualIdentities = _orderService.GetDualIdentities();
            dgvListe.DataSource = dualIdentities;
            MessageBox.Show("Müşteri ve Tedarikçi kayıtlarındaki ortak vergi/kimlik numarasına sahip firmalar listelendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvListe.SelectedRows.Count > 0)
            {
                var selectedRow = dgvListe.SelectedRows[0].DataBoundItem as Order;

                if (selectedRow != null)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _orderService.SendOrderEmail(selectedRow, email);
                        MessageBox.Show("Mail başarıyla gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mail gönderilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show("Mail göndermek için lütfen ekranda sipariş listesi açıkken bir sipariş satırı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tablodan mail atmak istediğiniz siparişin tamamını (en soldaki ok işaretine basarak) seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}