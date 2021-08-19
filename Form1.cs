using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Wolf_Marathon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        const int nextGroundX = 852;
        const int lastGroundX = -848;
        const int groundY = 431;
        const int nextObsX = 845;
        const int lastObsX = -79;
        const int GcoinChance = 75;
        const int DcoinChance = 250;
        bool gameStarting;
        bool isShopping;
        bool coinHit;
        bool coinExist;
        bool increasedDiff;
        bool defaultWolfSkinEquip;
        bool defaultBearSkinEquip;
        bool defaultDuckSkinEquip;
        bool defaultCactusSkinEquip;
        int difficult = 5;
        int tickgame;
        int jump;
        int height;
        int player_score;
        int typeObs;
        int highScore;
        int wallet;
        int[] wolfPrice = { 21, 69, 113 };
        int[] bearPrice = { 29, 41, 150 };
        int[] duckPrice = { 26, 60, 130 };
        int[] cactusPrice = { 25, 50, 100 };
        int[] wolfSkin = { 0, 0, 0 };
        int[] bearSkin = { 0, 0, 0 };
        int[] duckSkin = { 0, 0, 0 };
        int[] cactusSkin = { 0, 0, 0 };

        Color equipColor = Color.LawnGreen;
        Color equippedColor = Color.Turquoise;
        Color buyColor = Color.Tomato;
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            #region load data
            var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Wolf Marathon");
            string filePath = folderPath + "\\Skins.txt";
            if (Directory.Exists(folderPath))
            {
                if (new FileInfo(filePath).Exists)
                {
                    using (StreamReader myFile = new StreamReader(filePath))
                    {
                        highScore = int.Parse(myFile.ReadLine());
                        wallet = int.Parse(myFile.ReadLine());
                        string s;
                        int arrCount = 0;
                        while ((s = myFile.ReadLine()) != null)
                        {
                            int i = 0;
                            foreach (char c in s)
                            {
                                switch (arrCount)
                                {
                                    case 0: wolfSkin[i++] = int.Parse(c.ToString()); break;
                                    case 1: bearSkin[i++] = int.Parse(c.ToString()); break;
                                    case 2: duckSkin[i++] = int.Parse(c.ToString()); break;
                                    case 3: cactusSkin[i++] = int.Parse(c.ToString()); break;
                                }
                            }
                            arrCount++;
                        }
                    }
                }
                else
                {
                    using (StreamWriter myFile = File.CreateText(filePath))
                    {
                        myFile.Write("0\r\n0\r\n000\r\n000\r\n000\r\n000");
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(folderPath);
                using (StreamWriter myFile = File.CreateText(filePath))
                {
                    myFile.Write("0\r\n0\r\n000\r\n000\r\n000\r\n000");
                }
            }
            checkDefaultSkinEquip();
            updateSkins();
            #endregion
            displayMainMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveGround();

            if (Gcoin.Location.X <= lastObsX && Dcoin.Location.X <= lastObsX)
            {
                coinExist = false;
            }
            spawnGCoin();
            spawnDCoin();
            if (coinExist)
            {
                moveGCoin();
                moveDCoin();
            }

            if (typeObs == 0)    //chua co obstacle
                typeObs = spawnObs();
            moveObs();

            playerJumping();
            checkHitCoin();
            checkGameOver();
            if (player_score % 100 == 0 && difficult < 12 && !increasedDiff) //tang do kho
            {
                increasedDiff = true;
                difficult++;
            }
            updateScore();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jump == 0 && gameStarting == true)
            {
                jump = 1;
                wolf.Visible = false;
                wolf_jump.Visible = true;
            }
            else if (e.KeyCode == Keys.Space && gameStarting == false && !isShopping)
            {
                startGame();
            }
            else if (e.KeyCode == Keys.Escape && !gameStarting && !isShopping)
            {
                displayMainMenu();
            }
            else if (e.KeyCode == Keys.Escape && isShopping)
            {
                btn_back.PerformClick();
            }
            e.Handled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Wolf Marathon");
            string filePath = folderPath + "\\Skins.txt"; ;
            if (Directory.Exists(folderPath))
            {
                if (!(new FileInfo(filePath).Exists))
                {
                    using (StreamWriter myFile = File.CreateText(filePath))
                    {
                        myFile.Write("0\r\n0\r\n000\r\n000\r\n000\r\n000");
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(folderPath);
                using (StreamWriter myFile = File.CreateText(filePath))
                {
                    myFile.Write("0\r\n0\r\n000\r\n000\r\n000\r\n000");
                }
            }
            using (StreamWriter myFile = File.CreateText(filePath))
            {
                myFile.WriteLine(highScore);
                myFile.WriteLine(wallet);
                string wolfStr = "", bearStr = "", duckStr = "", cactusStr = "";
                for (int i = 0; i < wolfSkin.Length; i++)
                {
                    wolfStr += wolfSkin[i].ToString();
                    bearStr += bearSkin[i].ToString();
                    duckStr += duckSkin[i].ToString();
                    cactusStr += cactusSkin[i].ToString();
                }
                myFile.WriteLine(wolfStr);
                myFile.WriteLine(bearStr);
                myFile.WriteLine(duckStr);
                myFile.WriteLine(cactusStr);
            }
        }

        private void btn_resetsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to reset the save game?", "Double check!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Wolf Marathon");
                string filePath = folderPath + "\\Skins.txt"; ;

                Directory.CreateDirectory(folderPath);
                using (StreamWriter myFile = File.CreateText(filePath))
                {
                    myFile.Write("0\r\n0\r\n000\r\n000\r\n000\r\n000");
                }
                MessageBox.Show("Save game has been reset!", "Don't regret!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wolf.Image = Properties.Resources.player;
                wolf_jump.Image = Properties.Resources.player_jump;
                wolf_die.Image = Properties.Resources.player_die;
                bear.Image = Properties.Resources.bear;
                duck.Image = Properties.Resources.duck;
                cactus.Image = Properties.Resources.cactus;
                Form1_Load(null, null);
            }
            Focus();
        }

        private void btn_store_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_store.Visible = true;
            isShopping = true;
            updateWalletShop();
            btn_wolf.PerformClick();
            Focus();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            btn_wolf.Enabled = true;
            btn_bear.Enabled = true;
            btn_duck.Enabled = true;
            btn_cactus.Enabled = true;
            pnl_store.Visible = false;
            isShopping = false;
            Focus();
        }

        private void btn_wolf_Click(object sender, EventArgs e)
        {
            btn_wolf.Enabled = false;
            btn_bear.Enabled = true;
            btn_duck.Enabled = true;
            btn_cactus.Enabled = true;
            loadSkinSlot(wolfSkin, wolfPrice);

            slotSkin1.Image = Properties.Resources.player_jump1;
            slotSkin2.Image = Properties.Resources.player_jump2;
            slotSkin3.Image = Properties.Resources.player_jump3;
            Focus();
        }

        private void btn_bear_Click(object sender, EventArgs e)
        {
            btn_wolf.Enabled = true;
            btn_bear.Enabled = false;
            btn_duck.Enabled = true;
            btn_cactus.Enabled = true;
            loadSkinSlot(bearSkin, bearPrice);

            slotSkin1.Image = Properties.Resources.bear1;
            slotSkin2.Image = Properties.Resources.bear2;
            slotSkin3.Image = Properties.Resources.bear3;
            Focus();
        }

        private void btn_duck_Click(object sender, EventArgs e)
        {
            btn_wolf.Enabled = true;
            btn_bear.Enabled = true;
            btn_duck.Enabled = false;
            btn_cactus.Enabled = true;
            loadSkinSlot(duckSkin, duckPrice);

            slotSkin1.Image = Properties.Resources.duck1;
            slotSkin2.Image = Properties.Resources.duck2;
            slotSkin3.Image = Properties.Resources.duck3;
            Focus();
        }

        private void btn_cactus_Click(object sender, EventArgs e)
        {
            btn_wolf.Enabled = true;
            btn_bear.Enabled = true;
            btn_duck.Enabled = true;
            btn_cactus.Enabled = false;
            loadSkinSlot(cactusSkin, cactusPrice);

            slotSkin1.Image = Properties.Resources.cactus1;
            slotSkin2.Image = Properties.Resources.cactus2;
            slotSkin3.Image = Properties.Resources.cactus3;
            Focus();
        }

        private void btn_slot1_MouseClick(object sender, MouseEventArgs e)
        {
            buyOrEquip(0);
            Focus();
        }

        private void btn_slot2_MouseClick(object sender, MouseEventArgs e)
        {
            buyOrEquip(1);
            Focus();
        }

        private void btn_slot3_MouseClick(object sender, MouseEventArgs e)
        {
            buyOrEquip(2);
            Focus();
        }

        private void btn_defaultSkin_Click(object sender, EventArgs e)
        {
            if (!btn_wolf.Enabled)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (wolfSkin[i] == 2)
                    {
                        wolfSkin[i] = 1;
                        break;
                    }
                }
                checkDefaultSkinEquip();
                loadSkinSlot(wolfSkin, wolfPrice);
                wolf.Image = Properties.Resources.player;
                wolf_jump.Image = Properties.Resources.player_jump;
                wolf_die.Image = Properties.Resources.player_die;
            }
            else if (!btn_bear.Enabled)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (bearSkin[i] == 2)
                    {
                        bearSkin[i] = 1;
                        break;
                    }
                }
                checkDefaultSkinEquip();
                loadSkinSlot(bearSkin, bearPrice);
                bear.Image = Properties.Resources.bear;
            }
            else if (!btn_duck.Enabled)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (duckSkin[i] == 2)
                    {
                        duckSkin[i] = 1;
                        break;
                    }
                }
                checkDefaultSkinEquip();
                loadSkinSlot(duckSkin, duckPrice);
                duck.Image = Properties.Resources.duck;
            }
            else // cactus
            {
                for (int i = 0; i < 3; i++)
                {
                    if (cactusSkin[i] == 2)
                    {
                        cactusSkin[i] = 1;
                        break;
                    }
                }
                checkDefaultSkinEquip();
                loadSkinSlot(cactusSkin, cactusPrice);
                cactus.Image = Properties.Resources.cactus;
            }
            Focus();
        }

        #region function
        private void displayMainMenu()
        {
            wolf_jump.Visible = true;
            wolf_die.Visible = false;
            wolf.Visible = false;
            lbl_score.Visible = false;
            lbl_highscore.Visible = false;
            lbl_title.Visible = true;
            lbl_start.Visible = true;
            lbl_gameover.Visible = false;
            lbl_playagain.Visible = false;
            lbl_esc.Visible = false;
            lbl_wallet.Visible = false;
            pnl_store.Visible = false;
            btn_store.Visible = true;
            Gcoin.Visible = false;
            Dcoin.Visible = false;
            btn_resetsave.Visible = true;
            isShopping = false;
            gameStarting = false;

            wolf_jump.Location = new Point(wolf.Location.X, wolf.Location.Y);
            cactus.Location = new Point(742, cactus.Location.Y);
            bear.Location = new Point(651, bear.Location.Y);
            ground1.Location = new Point(-857, 431);
            ground2.Location = new Point(0, 431);
            pnl_store.Location = new Point(0, 0);
        }

        private void startGame()
        {
            lbl_score.Visible = true;
            lbl_highscore.Visible = true;
            lbl_title.Visible = false;
            lbl_start.Visible = false;
            lbl_gameover.Visible = false;
            lbl_playagain.Visible = false;
            lbl_esc.Visible = false;
            lbl_wallet.Visible = true;
            wolf_die.Visible = false;
            wolf.Visible = true;
            btn_store.Visible = false;
            Gcoin.Visible = true;
            Dcoin.Visible = true;
            btn_resetsave.Visible = false;

            increasedDiff = false;
            gameStarting = true;
            cactus.Location = new Point(lastObsX, cactus.Location.Y);
            bear.Location = new Point(lastObsX, bear.Location.Y);
            Gcoin.Location = new Point(lastObsX, Gcoin.Location.Y);
            Dcoin.Location = new Point(lastObsX, Dcoin.Location.Y);
            ground1.Location = new Point(-857, 431);
            ground2.Location = new Point(0, 431);

            lbl_wallet.Text = "Wallet: " + wallet + "      ";
            lbl_highscore.Text = "High score: " + highScore;
            coinHit = false;
            coinExist = false;
            jump = 0;
            tickgame = 0;
            player_score = 1;
            difficult = 5;
            timer1.Start();
        }

        private void buyOrEquip(int indexSkin)
        {
            if (!btn_wolf.Enabled)
            {
                if (wolfSkin[indexSkin] == 0)
                {
                    int cost = 0;
                    switch (indexSkin)
                    {
                        case 0: cost = int.Parse(btn_slot1.Tag.ToString()); break;
                        case 1: cost = int.Parse(btn_slot2.Tag.ToString()); break;
                        case 2: cost = int.Parse(btn_slot3.Tag.ToString()); break;
                    }
                    if (wallet >= cost)
                    {
                        wolfSkin[indexSkin] = 1;
                        wallet -= cost;
                        lbl_walletshop.Text = wallet.ToString() + "      ";
                    }
                    else
                    {
                        MessageBox.Show("You too poor to buy this!", "SIKE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (wolfSkin[indexSkin] == 1) //an equip
                {
                    preEquip(wolfSkin);
                    wolfSkin[indexSkin] = 2;
                    defaultWolfSkinEquip = false;
                }
                loadSkinSlot(wolfSkin, wolfPrice);
            }
            else if (!btn_bear.Enabled)
            {
                if (bearSkin[indexSkin] == 0)
                {
                    int cost = 0;
                    switch (indexSkin)
                    {
                        case 0: cost = int.Parse(btn_slot1.Tag.ToString()); break;
                        case 1: cost = int.Parse(btn_slot2.Tag.ToString()); break;
                        case 2: cost = int.Parse(btn_slot3.Tag.ToString()); break;
                    }
                    if (wallet >= cost)
                    {
                        bearSkin[indexSkin] = 1;
                        wallet -= cost;
                        lbl_walletshop.Text = wallet.ToString() + "      ";
                    }
                    else
                    {
                        MessageBox.Show("You too poor to buy this!", "SIKE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (bearSkin[indexSkin] == 1) //click equip
                {
                    preEquip(bearSkin);
                    bearSkin[indexSkin] = 2;
                    defaultBearSkinEquip = false;
                }
                loadSkinSlot(bearSkin, bearPrice);
            }
            else if (!btn_duck.Enabled)
            {
                if (duckSkin[indexSkin] == 0)
                {
                    int cost = 0;
                    switch (indexSkin)
                    {
                        case 0: cost = int.Parse(btn_slot1.Tag.ToString()); break;
                        case 1: cost = int.Parse(btn_slot2.Tag.ToString()); break;
                        case 2: cost = int.Parse(btn_slot3.Tag.ToString()); break;
                    }
                    if (wallet >= cost)
                    {
                        duckSkin[indexSkin] = 1;
                        wallet -= cost;
                        lbl_walletshop.Text = wallet.ToString() + "      ";
                    }
                    else
                    {
                        MessageBox.Show("You too poor to buy this!", "SIKE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (duckSkin[indexSkin] == 1) //click equip
                {
                    preEquip(duckSkin);
                    duckSkin[indexSkin] = 2;
                    defaultDuckSkinEquip = false;
                }
                loadSkinSlot(duckSkin, duckPrice);
            }
            else //cactus
            {
                if (cactusSkin[indexSkin] == 0)
                {
                    int cost = 0;
                    switch (indexSkin)
                    {
                        case 0: cost = int.Parse(btn_slot1.Tag.ToString()); break;
                        case 1: cost = int.Parse(btn_slot2.Tag.ToString()); break;
                        case 2: cost = int.Parse(btn_slot3.Tag.ToString()); break;
                    }
                    if (wallet >= cost)
                    {
                        cactusSkin[indexSkin] = 1;
                        wallet -= cost;
                        lbl_walletshop.Text = wallet.ToString() + "      ";
                    }
                    else
                    {
                        MessageBox.Show("You too poor to buy this!", "SIKE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (cactusSkin[indexSkin] == 1) //an equip
                {
                    preEquip(cactusSkin);
                    cactusSkin[indexSkin] = 2;
                    defaultCactusSkinEquip = false;
                }
                loadSkinSlot(cactusSkin, cactusPrice);
            }
            updateSkins();
        }

        private void preEquip(int[] skin) //bo equip skin truoc do
        {
            for(int i = 0; i < 3; i++)
            {
                if(skin[i] == 2)
                {
                    skin[i] = 1;
                    break;
                }
            }

        }

        private void updateSkins()
        {
            #region wolf skin
            if (wolfSkin[0] == 2)
            {
                wolf.Image = Properties.Resources.player1;
                wolf_jump.Image = Properties.Resources.player_jump1;
                wolf_die.Image = Properties.Resources.player_die1;
            }
            else if (wolfSkin[1] == 2)
            {
                wolf.Image = Properties.Resources.player2;
                wolf_jump.Image = Properties.Resources.player_jump2;
                wolf_die.Image = Properties.Resources.player_die2;
            }
            else if (wolfSkin[2] == 2)
            {
                wolf.Image = Properties.Resources.player3;
                wolf_jump.Image = Properties.Resources.player_jump3;
                wolf_die.Image = Properties.Resources.player_die3;
            }
            #endregion

            #region bear skin
            if (bearSkin[0] == 2)
            {
                bear.Image = Properties.Resources.bear1;
            }
            else if (bearSkin[1] == 2)
            {
                bear.Image = Properties.Resources.bear2;
            }
            else if (bearSkin[2] == 2)
            {
                bear.Image = Properties.Resources.bear3;
            }
            #endregion

            #region duck skin
            if (duckSkin[0] == 2)
            {
                duck.Image = Properties.Resources.duck1;
            }
            else if (duckSkin[1] == 2)
            {
                duck.Image = Properties.Resources.duck2;
            }
            else if (duckSkin[2] == 2)
            {
                duck.Image = Properties.Resources.duck3;
            }
            #endregion

            #region cactus skin
            if (cactusSkin[0] == 2)
            {
                cactus.Image = Properties.Resources.cactus1;
            }
            else if (cactusSkin[1] == 2)
            {
                cactus.Image = Properties.Resources.cactus2;
            }
            else if (cactusSkin[2] == 2)
            {
                cactus.Image = Properties.Resources.cactus3;
            }
            #endregion
        }

        private void updateWalletShop()
        {
            lbl_walletshop.Text = wallet.ToString() + "      ";
            int x = (lbl_wallettitle.Size.Width) - (lbl_walletshop.Size.Width);
            x /= 2;
            lbl_walletshop.Location = new Point(lbl_wallettitle.Location.X + x, lbl_walletshop.Location.Y);
        }

        private void updateScore()
        {
            tickgame++;
            if (tickgame == 10)
            {
                increasedDiff = false;
                tickgame = 0;
                player_score++;
            }
            lbl_score.Text = "Player score: " + player_score;
        }

        private void loadSkinSlot(int[] skin, int[] price) //update button va skin slot
        {
            #region set button default
            if (!btn_wolf.Enabled)
            {
                if (defaultWolfSkinEquip)
                    btn_defaultSkin.Enabled = false;
                else
                    btn_defaultSkin.Enabled = true;
            }
            else if (!btn_bear.Enabled)
            {
                if (defaultBearSkinEquip)
                    btn_defaultSkin.Enabled = false;
                else
                    btn_defaultSkin.Enabled = true;
            }
            else if (!btn_duck.Enabled)
            {
                if (defaultDuckSkinEquip)
                    btn_defaultSkin.Enabled = false;
                else
                    btn_defaultSkin.Enabled = true;
            }
            else //cactus
            {
                if (defaultCactusSkinEquip)
                    btn_defaultSkin.Enabled = false;
                else
                    btn_defaultSkin.Enabled = true;
            }
            #endregion

            if (skin[0] == 0)
            {
                btn_slot1.Tag = price[0];
                btn_slot1.Text = "Buy " + btn_slot1.Tag;
                btn_slot1.BackColor = buyColor;
                btn_slot1.TextAlign = ContentAlignment.MiddleLeft;
                btn_slot1.Image = Properties.Resources.coin1;
                btn_slot1.Enabled = true;
            }
            else if (skin[0] == 1 || skin[0] == 2)
            {
                btn_slot1.TextAlign = ContentAlignment.MiddleCenter;
                btn_slot1.Image = null;
                if (skin[0] == 1)
                {
                    btn_slot1.Text = "Equip";
                    btn_slot1.BackColor = equipColor;
                    btn_slot1.Enabled = true;
                }
                else
                {
                    btn_slot1.Text = "Equipped";
                    btn_slot1.BackColor = equippedColor;
                    btn_slot1.Enabled = false;
                }
            }

            if (skin[1] == 0)
            {
                btn_slot2.Tag = price[1];
                btn_slot2.Text = "Buy " + btn_slot2.Tag;
                btn_slot2.BackColor = buyColor;
                btn_slot2.TextAlign = ContentAlignment.MiddleLeft;
                btn_slot2.Image = Properties.Resources.coin1;
                btn_slot2.Enabled = true;
            }
            else if (skin[1] == 1 || skin[1] == 2)
            {
                btn_slot2.TextAlign = ContentAlignment.MiddleCenter;
                btn_slot2.Image = null;
                if (skin[1] == 1)
                {
                    btn_slot2.Text = "Equip";
                    btn_slot2.BackColor = equipColor;
                    btn_slot2.Enabled = true;
                }
                else
                {
                    btn_slot2.Text = "Equipped";
                    btn_slot2.BackColor = equippedColor;
                    btn_slot2.Enabled = false;
                }
            }

            if (skin[2] == 0)
            {
                btn_slot3.Tag = price[2];
                btn_slot3.Text = "Buy " + btn_slot3.Tag;
                btn_slot3.BackColor = buyColor;
                btn_slot3.TextAlign = ContentAlignment.MiddleLeft;
                btn_slot3.Image = Properties.Resources.coin1;
                btn_slot3.Enabled = true;
            }
            else if (skin[2] == 1 || skin[2] == 2)
            {
                btn_slot3.TextAlign = ContentAlignment.MiddleCenter;
                btn_slot3.Image = null;
                if (skin[2] == 1)
                {
                    btn_slot3.Text = "Equip";
                    btn_slot3.BackColor = equipColor;
                    btn_slot3.Enabled = true;
                }
                else
                {
                    btn_slot3.Text = "Equipped";
                    btn_slot3.BackColor = equippedColor;
                    btn_slot3.Enabled = false;
                }
            }
        }

        private void checkDefaultSkinEquip()
        {
            defaultWolfSkinEquip = true;
            defaultBearSkinEquip = true;
            defaultDuckSkinEquip = true;
            defaultCactusSkinEquip = true;
            for(int i = 0; i < 3; i++)
            {
                if (wolfSkin[i] == 2)
                {
                    defaultWolfSkinEquip = false;
                }
                if (bearSkin[i] == 2)
                {
                    defaultBearSkinEquip = false;
                }
                if (duckSkin[i] == 2)
                {
                    defaultDuckSkinEquip = false;
                }
                if (cactusSkin[i] == 2)
                {
                    defaultCactusSkinEquip = false;
                }
            }
        }

        private void checkHitCoin()
        {
            if (Math.Min(wolf_jump.Bounds.Right, Gcoin.Bounds.Right) >= Math.Max(wolf_jump.Bounds.Left, Gcoin.Bounds.Left) &&
            Math.Min(wolf_jump.Bounds.Bottom, Gcoin.Bounds.Bottom) >= Math.Max(wolf_jump.Bounds.Top, Gcoin.Bounds.Top) && !coinHit)
            {
                coinHit = true;
                wallet++;
                Gcoin.Visible = false;
                lbl_wallet.Text = "Wallet: " + wallet + "      ";
            }
            if (Math.Min(wolf_jump.Bounds.Right, Dcoin.Bounds.Right) >= Math.Max(wolf_jump.Bounds.Left, Dcoin.Bounds.Left) &&
            Math.Min(wolf_jump.Bounds.Bottom, Dcoin.Bounds.Bottom) >= Math.Max(wolf_jump.Bounds.Top, Dcoin.Bounds.Top) && !coinHit)
            {
                coinHit = true;
                wallet += 5;
                Dcoin.Visible = false;
                lbl_wallet.Text = "Wallet: " + wallet + "      ";
            }
        }

        private void spawnGCoin()
        {
            int tmp = rand.Next(1, GcoinChance);
            if (tmp == 1 && !coinExist)
            {
                coinExist = true;
                coinHit = false;
                Gcoin.Visible = true;
                Gcoin.Location = new Point(nextObsX, Gcoin.Location.Y);
            }
        }

        private void moveGCoin()
        {
            Gcoin.Location = new Point(Gcoin.Location.X - difficult, Gcoin.Location.Y);
        }

        private void spawnDCoin()
        {
            int tmp = rand.Next(1, DcoinChance);
            if (tmp == 1 && !coinExist)
            {
                coinExist = true;
                coinHit = false;
                Dcoin.Visible = true;
                Dcoin.Location = new Point(nextObsX, Dcoin.Location.Y);
            }
        }

        private void moveDCoin()
        {
            Dcoin.Location = new Point(Dcoin.Location.X - difficult, Dcoin.Location.Y);
        }

        private void moveGround()
        {
            if (ground1.Location.X < lastGroundX)
                ground1.Location = new Point(nextGroundX, ground1.Location.Y);
            if (ground2.Location.X < lastGroundX)
                ground2.Location = new Point(nextGroundX, ground2.Location.Y);
            ground1.Location = new Point(ground1.Location.X - difficult, ground1.Location.Y);
            ground2.Location = new Point(ground2.Location.X - difficult, ground2.Location.Y);
        }

        private int spawnObs()
        {
            int tmp = rand.Next(1, 100);
            if (tmp <= 5)
            {
                switch (tmp)
                {
                    case 1: bear.Location = new Point(nextObsX, bear.Location.Y); return 1;
                    case 2:
                    case 3:
                    case 4:
                    case 5: cactus.Location = new Point(nextObsX, cactus.Location.Y); return 2;
                }
            }
            return 0;
        }

        private void moveObs()
        {
            if (typeObs == 1)
            {
                if (bear.Location.X < -79)
                    typeObs = 0;
                else
                    bear.Location = new Point(bear.Location.X - difficult, bear.Location.Y);
            }
            if (typeObs == 2)
            {
                if (cactus.Location.X < -79)
                    typeObs = 0;
                else
                    cactus.Location = new Point(cactus.Location.X - difficult, cactus.Location.Y);
            }
        }

        private void playerJumping()
        {
            height = (75 - jump) * jump / 10;
            if (jump < 75 && jump != 0)
                jump++;
            else
            {
                jump = 0;
                wolf_jump.Visible = false;
                wolf.Visible = true;
            }
            wolf_jump.Location = new Point(wolf.Location.X, groundY - wolf.Height - height);
        }

        private bool checkCollision()
        {
            if (Math.Min(wolf_jump.Bounds.Right, cactus.Bounds.Right) >= Math.Max(wolf_jump.Bounds.Left, cactus.Bounds.Left) &&
            Math.Min(wolf_jump.Bounds.Bottom, cactus.Bounds.Bottom) >= Math.Max(wolf_jump.Bounds.Top, cactus.Bounds.Top))
                return true;
            if (Math.Min(wolf_jump.Bounds.Right, bear.Bounds.Right) >= Math.Max(wolf_jump.Bounds.Left, bear.Bounds.Left) &&
            Math.Min(wolf_jump.Bounds.Bottom, bear.Bounds.Bottom) >= Math.Max(wolf_jump.Bounds.Top, bear.Bounds.Top))
                return true;
            return false;
        }

        private void checkGameOver()
        {
            if (checkCollision())
            {
                lbl_gameover.Visible = true;
                lbl_playagain.Visible = true;
                lbl_esc.Visible = true;
                wolf_jump.Visible = false;
                wolf.Visible = false;
                wolf_die.Location = new Point(wolf_jump.Location.X, wolf_jump.Location.Y);
                wolf_die.Visible = true;
                gameStarting = false;
                if (player_score > highScore)
                    highScore = player_score;
                timer1.Stop();
            }
        }
        #endregion
    }
}
