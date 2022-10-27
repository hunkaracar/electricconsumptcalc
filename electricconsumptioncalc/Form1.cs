using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electricconsumptioncalc
{
    public partial class Form1 : Form
    {
        public const double tesla = 2.6; //elektrik birim fiyatı(tek zamanlı mesken tarifesi esas alınmıştır.)
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            
            float powerval = float.Parse(powerbox.Text); //Convert.ToInt32(powerbox.Text)
            int numberval = int.Parse(numberbox.Text);//adet
            int dhourval = int.Parse(dailyhbox.Text);//günlükcalismasaati
            int mhourval = int.Parse(monthlyhbox.Text);//aylıkcalismasaati

            double denergyc = (dhourval * powerval)*numberval;//günlükenerjitüketimi
            double menergyc = (mhourval* powerval)*numberval;//aylık enerjitüketimi

            double melectricc = menergyc * tesla;//aylık elektirk tüketimi


            dailycbox.Text = denergyc.ToString();//text string nesne olarak kabul eder int degeri stringe donusturerek hata almayı onledik. 
            monthlycbox.Text = menergyc.ToString();//yukarıdaki ile aynı misyon.
            electricbox.Text = melectricc.ToString();//aynısı

            


        }
    }
}
