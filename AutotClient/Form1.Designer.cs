namespace AutotClient
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.prvbtn = new System.Windows.Forms.Button();
            this.Fuelbox = new System.Windows.Forms.ComboBox();
            this.Mallibox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextbtn = new System.Windows.Forms.Button();
            this.Lukemabox = new System.Windows.Forms.TextBox();
            this.Motorbox = new System.Windows.Forms.TextBox();
            this.Merkkibox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Hintabox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(923, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Tyhjää kentät";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Väri";
            // 
            // colorbox
            // 
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Location = new System.Drawing.Point(692, 352);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(121, 21);
            this.colorbox.TabIndex = 49;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(120, 429);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(430, 23);
            this.Savebutton.TabIndex = 48;
            this.Savebutton.Text = "Tallena";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click_1);
            // 
            // prvbtn
            // 
            this.prvbtn.Location = new System.Drawing.Point(120, 458);
            this.prvbtn.Name = "prvbtn";
            this.prvbtn.Size = new System.Drawing.Size(430, 23);
            this.prvbtn.TabIndex = 47;
            this.prvbtn.Text = "Edellinen";
            this.prvbtn.UseVisualStyleBackColor = true;
            this.prvbtn.Click += new System.EventHandler(this.prvbtn_Click_1);
            // 
            // Fuelbox
            // 
            this.Fuelbox.FormattingEnabled = true;
            this.Fuelbox.Location = new System.Drawing.Point(819, 352);
            this.Fuelbox.Name = "Fuelbox";
            this.Fuelbox.Size = new System.Drawing.Size(121, 21);
            this.Fuelbox.TabIndex = 46;
            // 
            // Mallibox
            // 
            this.Mallibox.FormattingEnabled = true;
            this.Mallibox.Location = new System.Drawing.Point(565, 352);
            this.Mallibox.Name = "Mallibox";
            this.Mallibox.Size = new System.Drawing.Size(121, 21);
            this.Mallibox.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Polttoaine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Malli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Autonmerkki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mittarilukema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Moottorin Tilavuus";
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(577, 458);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(466, 23);
            this.nextbtn.TabIndex = 39;
            this.nextbtn.Text = "Seuraava";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click_1);
            // 
            // Lukemabox
            // 
            this.Lukemabox.Location = new System.Drawing.Point(332, 353);
            this.Lukemabox.Name = "Lukemabox";
            this.Lukemabox.Size = new System.Drawing.Size(100, 20);
            this.Lukemabox.TabIndex = 38;
            // 
            // Motorbox
            // 
            this.Motorbox.Location = new System.Drawing.Point(226, 352);
            this.Motorbox.Name = "Motorbox";
            this.Motorbox.Size = new System.Drawing.Size(100, 20);
            this.Motorbox.TabIndex = 37;
            // 
            // Merkkibox
            // 
            this.Merkkibox.FormattingEnabled = true;
            this.Merkkibox.Location = new System.Drawing.Point(438, 352);
            this.Merkkibox.Name = "Merkkibox";
            this.Merkkibox.Size = new System.Drawing.Size(121, 21);
            this.Merkkibox.TabIndex = 36;
            this.Merkkibox.SelectedValueChanged += new System.EventHandler(this.LisaaMallit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Hinta";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(577, 429);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(466, 23);
            this.Deletebtn.TabIndex = 34;
            this.Deletebtn.Text = "Poista auto";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Hintabox
            // 
            this.Hintabox.Location = new System.Drawing.Point(120, 351);
            this.Hintabox.Name = "Hintabox";
            this.Hintabox.Size = new System.Drawing.Size(100, 20);
            this.Hintabox.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 766);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.prvbtn);
            this.Controls.Add(this.Fuelbox);
            this.Controls.Add(this.Mallibox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.Lukemabox);
            this.Controls.Add(this.Motorbox);
            this.Controls.Add(this.Merkkibox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Hintabox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox colorbox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button prvbtn;
        private System.Windows.Forms.ComboBox Fuelbox;
        private System.Windows.Forms.ComboBox Mallibox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.TextBox Lukemabox;
        private System.Windows.Forms.TextBox Motorbox;
        private System.Windows.Forms.ComboBox Merkkibox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox Hintabox;
    }
}

