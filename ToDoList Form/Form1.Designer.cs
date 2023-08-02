namespace ToDoList_Form
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
            this.Ekle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Değiştir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(311, 81);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(75, 23);
            this.Ekle.TabIndex = 1;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(502, 144);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(75, 23);
            this.Temizle.TabIndex = 3;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(502, 185);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 22);
            this.Sil.TabIndex = 4;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Değiştir
            // 
            this.Değiştir.Location = new System.Drawing.Point(502, 375);
            this.Değiştir.Name = "Değiştir";
            this.Değiştir.Size = new System.Drawing.Size(75, 23);
            this.Değiştir.TabIndex = 5;
            this.Değiştir.Text = "Değiştir";
            this.Değiştir.UseVisualStyleBackColor = true;
            this.Değiştir.Click += new System.EventHandler(this.Değiştir_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(502, 404);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 144);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 353);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 535);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Değiştir);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Değiştir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
    }
}

