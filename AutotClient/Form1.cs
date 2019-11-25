using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutotClient
{
    public partial class Form1 : Form
    {
        AutotClient.AutoPalvelu.Service1Client registerHandler = new AutoPalvelu.Service1Client();
        AutoPalvelu.Auto nykyinenAuto = new AutoPalvelu.Auto();
        //KaupanLogiikka registerHandler;
        //Autonmerkki autoMakeList = new Autonmerkki();
        public Form1()
        {
            //registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Merkkibox.DataSource = registerHandler.getAutoMakers();
            Merkkibox.DisplayMember = "Merkkinimi";
            Merkkibox.ValueMember = "Id";            
        }
        private void LisaaMallit(object sender, EventArgs e)
        {
            try
            {
                if (Merkkibox.SelectedValue is int)
                {
                    int nakki = (int)Merkkibox.SelectedValue;
                    Mallibox.DataSource = registerHandler.GetAutonmallits(nakki);
                    Mallibox.DisplayMember = "mallinimi";
                    Mallibox.ValueMember = "id";
                    colorbox.DataSource = registerHandler.GetVarits();
                    colorbox.DisplayMember = "Varin_nimi";
                    colorbox.ValueMember = "ID";
                    Fuelbox.DataSource = registerHandler.GetPolttoaines();
                    Fuelbox.DisplayMember = "Polttoaineen_nimi";
                    Fuelbox.ValueMember = "ID";
                }
            }
            catch
            {
                //tulee alussa kun merkkibox.valuemember ei ole määritetty
            }
        }
        //private void testaaYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (registerHandler.TestDatabaseConnection())
        //    {
        //        MessageBox.Show("jotai tapahtui jee");
        //    }
        //    else
        //    {
        //        MessageBox.Show("jotai ei tapahtunut");
        //    }
        //}
        void ClearBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }
                else
                {
                    ClearBoxes(c);
                }
            }
        }
        private void TulostaAuto(AutoPalvelu.Auto uusiAuto)
        {
            Merkkibox.SelectedValue = uusiAuto.AutonmerkkiID;
            Mallibox.SelectedValue = uusiAuto.AutonmalliID;
            colorbox.SelectedValue = uusiAuto.VaritID;
            Fuelbox.SelectedValue = uusiAuto.PolttoaineID;
            Hintabox.Text = uusiAuto.Hinta.ToString();
            Motorbox.Text = uusiAuto.Moottorin_tilavuus.ToString();
            dateTimePicker1.Text = uusiAuto.Rekisteri_Paivamaara.ToString();
            Lukemabox.Text = uusiAuto.Mittarilukema.ToString();
        }    
        private void Savebutton_Click_1(object sender, EventArgs e)
        {
            AutoPalvelu.Auto pirssi = new AutoPalvelu.Auto();
            pirssi.Hinta = Decimal.Parse(Hintabox.Text);
            pirssi.Moottorin_tilavuus = Decimal.Parse(Motorbox.Text);
            pirssi.Mittarilukema = int.Parse(Lukemabox.Text);
            pirssi.AutonmerkkiID = (int)Merkkibox.SelectedValue;
            pirssi.AutonmalliID = (int)Mallibox.SelectedValue;
            pirssi.VaritID = (int)colorbox.SelectedValue;
            pirssi.PolttoaineID = (int)Fuelbox.SelectedValue;
            pirssi.Rekisteri_Paivamaara = dateTimePicker1.Value;
            registerHandler.saveAuto(pirssi);
            MessageBox.Show("Auto tallennettu!");
            ClearBoxes(this);
        }
        private void prvbtn_Click_1(object sender, EventArgs e)
        {
            nykyinenAuto = registerHandler.PreviousCars(nykyinenAuto.ID);
            TulostaAuto(nykyinenAuto);
        }
        private void nextbtn_Click_1(object sender, EventArgs e)
        {
            nykyinenAuto = registerHandler.NextCars(nykyinenAuto.ID);
            TulostaAuto(nykyinenAuto);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearBoxes(this);
        }
    }
}

