namespace OrderManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCustomerId = new TextBox();
            label2 = new Label();
            cmbState = new ComboBox();
            btnSorgula = new Button();
            btnCiftKimlik = new Button();
            dgvListe = new DataGridView();
            label3 = new Label();
            txtEmail = new TextBox();
            btnMailGonder = new Button();
            label4 = new Label();
            txtOrderNo = new TextBox();
            label5 = new Label();
            txtDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 331);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Kodu:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(141, 328);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(125, 27);
            txtCustomerId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 366);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "Sipariş Durumu:";
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Items.AddRange(new object[] { "All", "Planned", "Released", "Delivered", "Cancelled", "Invoiced/Closed", "Picked", "Reserved", "Blocked", "Partially", "Delivered" });
            cmbState.Location = new Point(411, 363);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(151, 28);
            cmbState.TabIndex = 3;
            // 
            // btnSorgula
            // 
            btnSorgula.Location = new Point(584, 324);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(188, 29);
            btnSorgula.TabIndex = 4;
            btnSorgula.Text = "Siparişleri Getir";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // btnCiftKimlik
            // 
            btnCiftKimlik.Location = new Point(584, 363);
            btnCiftKimlik.Name = "btnCiftKimlik";
            btnCiftKimlik.Size = new Size(188, 29);
            btnCiftKimlik.TabIndex = 5;
            btnCiftKimlik.Text = "Müşteri - Tedarikçi Bul";
            btnCiftKimlik.UseVisualStyleBackColor = true;
            btnCiftKimlik.Click += btnCiftKimlik_Click;
            // 
            // dgvListe
            // 
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Location = new Point(26, 35);
            dgvListe.Name = "dgvListe";
            dgvListe.RowHeadersWidth = 51;
            dgvListe.Size = new Size(746, 261);
            dgvListe.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 414);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 7;
            label3.Text = "E-posta Adresi:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 411);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 27);
            txtEmail.TabIndex = 8;
            // 
            // btnMailGonder
            // 
            btnMailGonder.Location = new Point(389, 411);
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.Size = new Size(188, 29);
            btnMailGonder.TabIndex = 9;
            btnMailGonder.Text = "E-posta Gönder";
            btnMailGonder.UseVisualStyleBackColor = true;
            btnMailGonder.Click += btnMailGonder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 366);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 10;
            label4.Text = "Sipariş No:";
            // 
            // txtOrderNo
            // 
            txtOrderNo.Location = new Point(141, 364);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.Size = new Size(125, 27);
            txtOrderNo.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 331);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 12;
            label5.Text = "Tarih:";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(411, 324);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDate);
            Controls.Add(label5);
            Controls.Add(txtOrderNo);
            Controls.Add(label4);
            Controls.Add(btnMailGonder);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(dgvListe);
            Controls.Add(btnCiftKimlik);
            Controls.Add(btnSorgula);
            Controls.Add(cmbState);
            Controls.Add(label2);
            Controls.Add(txtCustomerId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerId;
        private Label label2;
        private ComboBox cmbState;
        private Button btnSorgula;
        private Button btnCiftKimlik;
        private DataGridView dgvListe;
        private Label label3;
        private TextBox txtEmail;
        private Button btnMailGonder;
        private Label label4;
        private TextBox txtOrderNo;
        private Label label5;
        private TextBox txtDate;
    }
}
