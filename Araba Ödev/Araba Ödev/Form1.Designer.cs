
namespace Araba_Ödev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyakıt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nmid = new System.Windows.Forms.NumericUpDown();
            this.txtyıl = new System.Windows.Forms.TextBox();
            this.mtxttel = new System.Windows.Forms.MaskedTextBox();
            this.btntamam = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtmarka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka:";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(56, 99);
            this.model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(56, 20);
            this.model.TabIndex = 3;
            this.model.Text = "Model:";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(120, 96);
            this.txtmodel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(189, 26);
            this.txtmodel.TabIndex = 2;
            this.txtmodel.Validated += new System.EventHandler(this.txtmodel_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yakıt:";
            // 
            // txtyakıt
            // 
            this.txtyakıt.Location = new System.Drawing.Point(120, 141);
            this.txtyakıt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtyakıt.Name = "txtyakıt";
            this.txtyakıt.Size = new System.Drawing.Size(189, 26);
            this.txtyakıt.TabIndex = 3;
            this.txtyakıt.Validated += new System.EventHandler(this.txtyakıt_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Motor Hacmi:";
            // 
            // txtmotor
            // 
            this.txtmotor.Location = new System.Drawing.Point(120, 193);
            this.txtmotor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmotor.Name = "txtmotor";
            this.txtmotor.Size = new System.Drawing.Size(189, 26);
            this.txtmotor.TabIndex = 4;
            this.txtmotor.Validated += new System.EventHandler(this.txtmotor_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Renk:";
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(120, 243);
            this.txtrenk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(189, 26);
            this.txtrenk.TabIndex = 5;
            this.txtrenk.Validated += new System.EventHandler(this.txtrenk_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yıl:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kilometre:";
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(120, 350);
            this.txtkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(189, 26);
            this.txtkm.TabIndex = 7;
            this.txtkm.Validated += new System.EventHandler(this.txtkm_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fiyat:";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(120, 402);
            this.txtfiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(189, 26);
            this.txtfiyat.TabIndex = 8;
            this.txtfiyat.Validated += new System.EventHandler(this.txtfiyat_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 451);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "İletişim Tel:";
            // 
            // nmid
            // 
            this.nmid.Location = new System.Drawing.Point(120, 7);
            this.nmid.Name = "nmid";
            this.nmid.Size = new System.Drawing.Size(189, 26);
            this.nmid.TabIndex = 0;
            // 
            // txtyıl
            // 
            this.txtyıl.Location = new System.Drawing.Point(120, 301);
            this.txtyıl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtyıl.Name = "txtyıl";
            this.txtyıl.Size = new System.Drawing.Size(189, 26);
            this.txtyıl.TabIndex = 6;
            this.txtyıl.Validated += new System.EventHandler(this.txtyıl_Validated);
            // 
            // mtxttel
            // 
            this.mtxttel.Location = new System.Drawing.Point(120, 445);
            this.mtxttel.Mask = "(999) 000-0000";
            this.mtxttel.Name = "mtxttel";
            this.mtxttel.Size = new System.Drawing.Size(189, 26);
            this.mtxttel.TabIndex = 9;
            this.mtxttel.Validated += new System.EventHandler(this.mtxttel_Validated);
            // 
            // btntamam
            // 
            this.btntamam.Location = new System.Drawing.Point(120, 501);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(91, 41);
            this.btntamam.TabIndex = 10;
            this.btntamam.Text = "Tamam";
            this.btntamam.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(218, 501);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(91, 41);
            this.btniptal.TabIndex = 11;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID:";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(120, 50);
            this.txtmarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(189, 26);
            this.txtmarka.TabIndex = 1;
            this.txtmarka.Validated += new System.EventHandler(this.txtmarka_Validated);
            // 
            // Form1
            // 
            this.AcceptButton = this.btntamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(394, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btntamam);
            this.Controls.Add(this.mtxttel);
            this.Controls.Add(this.txtyıl);
            this.Controls.Add(this.nmid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmotor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyakıt);
            this.Controls.Add(this.model);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyakıt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmid;
        private System.Windows.Forms.TextBox txtyıl;
        private System.Windows.Forms.MaskedTextBox mtxttel;
        private System.Windows.Forms.Button btntamam;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmarka;
    }
}

