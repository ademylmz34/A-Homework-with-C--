
namespace SORU2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_okuma = new System.Windows.Forms.Button();
            this.btn_tersial = new System.Windows.Forms.Button();
            this.btn_izbul = new System.Windows.Forms.Button();
            this.btn_transpoze = new System.Windows.Forms.Button();
            this.btn_metindosyasıgöster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yazdir.Location = new System.Drawing.Point(0, 77);
            this.btn_yazdir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(152, 63);
            this.btn_yazdir.TabIndex = 0;
            this.btn_yazdir.Text = "MATRİSLERİ YAZDIR";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaça kaçlık bir kare matris oluşturmak istersiniz?";
            // 
            // btn_topla
            // 
            this.btn_topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_topla.Location = new System.Drawing.Point(146, 77);
            this.btn_topla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(169, 63);
            this.btn_topla.TabIndex = 5;
            this.btn_topla.Text = "MATRİSLERİ TOPLA";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carp.Location = new System.Drawing.Point(313, 77);
            this.btn_carp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(173, 63);
            this.btn_carp.TabIndex = 6;
            this.btn_carp.Text = "MATRİSLERİ ÇARP";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_okuma
            // 
            this.btn_okuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_okuma.Location = new System.Drawing.Point(0, 136);
            this.btn_okuma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_okuma.Name = "btn_okuma";
            this.btn_okuma.Size = new System.Drawing.Size(152, 63);
            this.btn_okuma.TabIndex = 7;
            this.btn_okuma.Text = "MATRİS OKUMA";
            this.btn_okuma.UseVisualStyleBackColor = true;
            this.btn_okuma.Click += new System.EventHandler(this.btn_okuma_Click);
            // 
            // btn_tersial
            // 
            this.btn_tersial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tersial.Location = new System.Drawing.Point(146, 136);
            this.btn_tersial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_tersial.Name = "btn_tersial";
            this.btn_tersial.Size = new System.Drawing.Size(169, 63);
            this.btn_tersial.TabIndex = 8;
            this.btn_tersial.Text = "MATRİS TERSİ AL";
            this.btn_tersial.UseVisualStyleBackColor = true;
            this.btn_tersial.Click += new System.EventHandler(this.btn_tersial_Click);
            // 
            // btn_izbul
            // 
            this.btn_izbul.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izbul.Location = new System.Drawing.Point(313, 136);
            this.btn_izbul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_izbul.Name = "btn_izbul";
            this.btn_izbul.Size = new System.Drawing.Size(173, 63);
            this.btn_izbul.TabIndex = 9;
            this.btn_izbul.Text = "MATRİS İZİ BUL";
            this.btn_izbul.UseVisualStyleBackColor = true;
            this.btn_izbul.Click += new System.EventHandler(this.btn_izbul_Click);
            // 
            // btn_transpoze
            // 
            this.btn_transpoze.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transpoze.Location = new System.Drawing.Point(0, 197);
            this.btn_transpoze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_transpoze.Name = "btn_transpoze";
            this.btn_transpoze.Size = new System.Drawing.Size(486, 63);
            this.btn_transpoze.TabIndex = 10;
            this.btn_transpoze.Text = "MATRİS TRANSPOZE ET";
            this.btn_transpoze.UseVisualStyleBackColor = true;
            this.btn_transpoze.Click += new System.EventHandler(this.btn_transpoze_Click);
            // 
            // btn_metindosyasıgöster
            // 
            this.btn_metindosyasıgöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_metindosyasıgöster.Location = new System.Drawing.Point(0, 257);
            this.btn_metindosyasıgöster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_metindosyasıgöster.Name = "btn_metindosyasıgöster";
            this.btn_metindosyasıgöster.Size = new System.Drawing.Size(486, 56);
            this.btn_metindosyasıgöster.TabIndex = 11;
            this.btn_metindosyasıgöster.Text = "METİN DOSYASINI GÖSTER";
            this.btn_metindosyasıgöster.UseVisualStyleBackColor = true;
            this.btn_metindosyasıgöster.Click += new System.EventHandler(this.btn_metindosyasıgöster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 310);
            this.Controls.Add(this.btn_metindosyasıgöster);
            this.Controls.Add(this.btn_transpoze);
            this.Controls.Add(this.btn_izbul);
            this.Controls.Add(this.btn_tersial);
            this.Controls.Add(this.btn_okuma);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_yazdir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_okuma;
        private System.Windows.Forms.Button btn_tersial;
        private System.Windows.Forms.Button btn_izbul;
        private System.Windows.Forms.Button btn_transpoze;
        private System.Windows.Forms.Button btn_metindosyasıgöster;
    }
}

