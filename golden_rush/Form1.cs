using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldRush
{
    public partial class Form1 : Form, ICorporationView, ITimerMine
    {
        Corporation golder;
        Mine mine;
        public Form1()
        {
            InitializeComponent();
            golder = new Corporation(this);
            mine = new Mine(this);
        }

        public void showTotalDollars(int dollars, int cent)
        {
            string strdoll = dollars.ToString();
            string dot = ".";
            int tmp = cent / 100;
            string strcent = tmp.ToString();
            textMoney.Text = strdoll + dot + strcent;
        }
        public void showTotalDollars(int dollars)
        {
            textMoney.Text = dollars.ToString();
        }
        public void showTotalGold(int gold)
        {
            textGold.Text = gold.ToString();
        }
        public void showLV(int lv)
        {
            textLv.Text = lv.ToString();
        }
        private void diactivationBox()
        {
            CorporationBox.Enabled = false;
            RepairShopBox.Enabled = false;
            QuarryBox.Enabled = false;
            BonusBox.Enabled = false;
            MineBox.Enabled = false;
        }
        private void activationBox()
        {
            CorporationBox.Enabled = true;
            RepairShopBox.Enabled = true;
            QuarryBox.Enabled = true;
            BonusBox.Enabled = true;
            MineBox.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            golder.showMoney();
            golder.showGold();
            golder.showLv();
            
        }
        
        private void CorporationBox_MouseClick(object sender, MouseEventArgs e)
        {
            int[] arr = new int[9];
            arr[8] = 400;
            golder.plasMoney(arr);
        }
        //!!! !!! !!! !!!                           корпоратия                         !!! !!! !!! !!!
        private void CorporationBox_MouseMove(object sender, MouseEventArgs e)
        {
            CorporationBox.Image = Image.FromFile( @"D:\goldRush\GoldRush\Picture\ViewCorporation.png");
        }
        private void CorporationBox_MouseLeave(object sender, EventArgs e)
        {
            CorporationBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Corporation.png");
        }
        //!!! !!! !!!                   вид и действия в корпоратии                 !!! !!! !!! 
        private void CorporationBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            diactivationBox();
            panelCorporation.Location = new Point(95, -10);
            panelCorporation.Visible = true;
        }
        private void ImgComputer_MouseMove(object sender, MouseEventArgs e)
        {
            ImgComputer.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\corporation\ViewComputer.png");
        }
        private void ImgComputer_MouseLeave(object sender, EventArgs e)
        {
            ImgComputer.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\corporation\Computer.png");
        }
        private void ImgWeight_MouseMove(object sender, MouseEventArgs e)
        {
            ImgWeight.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\corporation\ViewWeight.png");
        }

        private void ImgWeight_MouseLeave(object sender, EventArgs e)
        {
            ImgWeight.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\corporation\Weight.png");
        }
        private void clousePanelCorporation_Click(object sender, EventArgs e)
        {
            activationBox();
            panelCorporation.Visible = false;
        }
        //!!! !!! !!!                   выход из корпоратии                             !!! !!! !!! 

        private void RepairShopBox_MouseMove(object sender, MouseEventArgs e)
        {
            RepairShopBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\ViewRepairShop.png");
        }
        private void RepairShopBox_MouseLeave(object sender, EventArgs e)
        {
            RepairShopBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\RepairShop.png");

        }

        //!!! !!! !!! !!!                           карьер                         !!! !!! !!! !!!
        private void QuarryBox_MouseMove(object sender, MouseEventArgs e)
        {
            QuarryBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\ViewQuarry.png");
        }
        private void QuarryBox_MouseLeave(object sender, EventArgs e)
        {
            QuarryBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Quarry.png");
        }
        //!!! !!! !!!                   вид и действия в карьере                 !!! !!! !!! 
        private void QuarryBox_DoubleClick(object sender, EventArgs e)
        {
            diactivationBox();
            panelQuarry.Location = new Point(255, 130);
            panelQuarry.Visible = true;
        }

        private void ImgExcovator_MouseMove(object sender, MouseEventArgs e)
        {
            ImgExcovator.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\quarry\ViewExcovator.png");
        }
        private void ImgExcovator_MouseLeave(object sender, EventArgs e)
        {
            ImgExcovator.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\quarry\Excovator.png");
        }

        private void ImgTruck_MouseMove(object sender, MouseEventArgs e)
        {
            ImgTruck.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\quarry\ViewTruck.png");
        }
        private void ImgTruck_MouseLeave(object sender, EventArgs e)
        {
            ImgTruck.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\quarry\Truck.png");
        }

        private void clousePanelQuarry_Click(object sender, EventArgs e)
        {
            activationBox();
            panelQuarry.Visible = false;
        }
        //!!! !!! !!!                   выход из карьера                             !!! !!! !!! 

        private void BonusBox_MouseMove(object sender, MouseEventArgs e)
        {
            BonusBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\ViewBonus.png");
        }
        private void BonusBox_MouseLeave(object sender, EventArgs e)
        {
            BonusBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Bonus.png");
        }

        //!!! !!! !!! !!!                           шахта                           !!! !!! !!! !!!
        
        private void MineBox_MouseMove(object sender, MouseEventArgs e)
        {
            MineBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\ViewMine.png");
        }
        private void MineBox_MouseLeave(object sender, EventArgs e)
        {
            MineBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Mine.png");
        }
        //!!! !!! !!!                   вид и действия в шахте                  !!! !!! !!! 
        private void MineBox_DoubleClick(object sender, EventArgs e)
        {
            diactivationBox();
            panelMine.Location = new Point(195, 40);
            panelMine.Visible = true;
        }

        private void ImgShaftMan_MouseMove(object sender, MouseEventArgs e)
        {
            ImgShaftMan.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Mine\ViewShaftMan.png");
        }
        private void ImgShaftMan_MouseLeave(object sender, EventArgs e)
        {
            ImgShaftMan.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Mine\ShaftMan.png");
        }
        public void iTimerShaftMan(int countMan)
        {
            int interval = 10 * countMan;
            timerShaftMan.Interval = interval * 1000;
            //ImgShaftMan.Enabled = false;
            timerShaftMan.Start();
            int prog = 1;
            
                ImgShaftMan.Enabled = false;
                //ImgShaftMan.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\mine\ViewShaftMan.png");
               
        }
        private void timerShaftMan_Tick(object sender, EventArgs e)
        {
            timerShaftMan.Stop();
            ImgShaftMan.Enabled = true;
            ImgShaftMan.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\mine\ClikShaftMan.png");
        }
        private void ImgShaftMan_Click(object sender, EventArgs e)
        {
            if (progressShaftMan.Visible == true)
            {
                progressShaftMan.Visible = false;
                
            }
            else
            {
                progressShaftMan.Visible = true;
                progressShaftMan.Value = 0;
                mine.goShaft();
            }
        }

        private void ImgDripMan_MouseMove(object sender, MouseEventArgs e)
        {
            ImgDripMan.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Mine\ViewDripMan.png");
        }
        private void ImgDripMan_MouseLeave(object sender, EventArgs e)
        {
            ImgDripMan.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Mine\DripMan.png");
        }
        public void iTimerDripMan(int countMan)
        {
            throw new NotImplementedException();
        }

        private void ImgBrigMan_MouseMove(object sender, MouseEventArgs e)
        {
            ImgBrigMan.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Mine\ViewBrigMan.png");
        }
        private void ImgBrigMan_MouseLeave(object sender, EventArgs e)
        {
            ImgBrigMan.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\Mine\BrigMan.png");
        }
        public void iTimerBrigMan(int countMan)
        {
            throw new NotImplementedException();
        }

        private void clousePanelMine_Click(object sender, EventArgs e)
        {
            activationBox();
            panelMine.Visible = false;
        }
        //!!! !!! !!!                   выход из шахты                             !!! !!! !!! 

        private void PromBox_MouseMove(object sender, MouseEventArgs e)
        {
            PromBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\ViewPromPribor.png");
        }

        private void PromBox_MouseLeave(object sender, EventArgs e)
        {
            PromBox.Image = Image.FromFile(@"D:\goldRush\GoldRush\Picture\PromPribor.png");
        }
    }
}
