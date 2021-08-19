
namespace Wolf_Marathon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_esc = new System.Windows.Forms.Label();
            this.lbl_playagain = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_gameover = new System.Windows.Forms.Label();
            this.pnl_store = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_cactus = new System.Windows.Forms.Button();
            this.btn_duck = new System.Windows.Forms.Button();
            this.btn_bear = new System.Windows.Forms.Button();
            this.btn_wolf = new System.Windows.Forms.Button();
            this.pnl_skinSection = new System.Windows.Forms.Panel();
            this.lbl_wallettitle = new System.Windows.Forms.Label();
            this.lbl_wallet = new System.Windows.Forms.Label();
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.btn_resetsave = new System.Windows.Forms.Button();
            this.btn_defaultSkin = new System.Windows.Forms.Button();
            this.lbl_walletshop = new System.Windows.Forms.Label();
            this.btn_slot3 = new System.Windows.Forms.Button();
            this.btn_slot2 = new System.Windows.Forms.Button();
            this.btn_slot1 = new System.Windows.Forms.Button();
            this.slotSkin2 = new System.Windows.Forms.PictureBox();
            this.slotSkin3 = new System.Windows.Forms.PictureBox();
            this.slotSkin1 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.Dcoin = new System.Windows.Forms.PictureBox();
            this.Gcoin = new System.Windows.Forms.PictureBox();
            this.btn_store = new System.Windows.Forms.Button();
            this.duck = new System.Windows.Forms.PictureBox();
            this.cactus = new System.Windows.Forms.PictureBox();
            this.bear = new System.Windows.Forms.PictureBox();
            this.wolf_die = new System.Windows.Forms.PictureBox();
            this.wolf_jump = new System.Windows.Forms.PictureBox();
            this.wolf = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.pnl_store.SuspendLayout();
            this.pnl_skinSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slotSkin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotSkin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotSkin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dcoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gcoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf_die)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf_jump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 31);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(533, 93);
            this.lbl_title.TabIndex = 11;
            this.lbl_title.Text = "Wolf Marathon";
            // 
            // lbl_esc
            // 
            this.lbl_esc.AutoSize = true;
            this.lbl_esc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_esc.Location = new System.Drawing.Point(151, 148);
            this.lbl_esc.Name = "lbl_esc";
            this.lbl_esc.Size = new System.Drawing.Size(201, 22);
            this.lbl_esc.TabIndex = 17;
            this.lbl_esc.Text = "Press Esc to main menu";
            // 
            // lbl_playagain
            // 
            this.lbl_playagain.AutoSize = true;
            this.lbl_playagain.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playagain.Location = new System.Drawing.Point(146, 121);
            this.lbl_playagain.Name = "lbl_playagain";
            this.lbl_playagain.Size = new System.Drawing.Size(216, 22);
            this.lbl_playagain.TabIndex = 16;
            this.lbl_playagain.Text = "Press Space to play again";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(446, 41);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(145, 28);
            this.lbl_score.TabIndex = 15;
            this.lbl_score.Text = "Player score:";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.Location = new System.Drawing.Point(177, 148);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(171, 22);
            this.lbl_start.TabIndex = 18;
            this.lbl_start.Text = "Press Space to start";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_gameover
            // 
            this.lbl_gameover.AutoSize = true;
            this.lbl_gameover.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameover.Location = new System.Drawing.Point(99, 41);
            this.lbl_gameover.Name = "lbl_gameover";
            this.lbl_gameover.Size = new System.Drawing.Size(311, 70);
            this.lbl_gameover.TabIndex = 28;
            this.lbl_gameover.Text = "Game over!";
            // 
            // pnl_store
            // 
            this.pnl_store.BackColor = System.Drawing.Color.LightSalmon;
            this.pnl_store.Controls.Add(this.btn_back);
            this.pnl_store.Controls.Add(this.btn_cactus);
            this.pnl_store.Controls.Add(this.btn_duck);
            this.pnl_store.Controls.Add(this.btn_bear);
            this.pnl_store.Controls.Add(this.btn_wolf);
            this.pnl_store.Controls.Add(this.pnl_skinSection);
            this.pnl_store.Location = new System.Drawing.Point(325, 473);
            this.pnl_store.Name = "pnl_store";
            this.pnl_store.Size = new System.Drawing.Size(844, 550);
            this.pnl_store.TabIndex = 31;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Tomato;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(704, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 51);
            this.btn_back.TabIndex = 5;
            this.btn_back.TabStop = false;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_cactus
            // 
            this.btn_cactus.BackColor = System.Drawing.Color.LightGreen;
            this.btn_cactus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cactus.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cactus.Location = new System.Drawing.Point(533, 12);
            this.btn_cactus.Name = "btn_cactus";
            this.btn_cactus.Size = new System.Drawing.Size(117, 51);
            this.btn_cactus.TabIndex = 4;
            this.btn_cactus.TabStop = false;
            this.btn_cactus.Text = "Cactus";
            this.btn_cactus.UseVisualStyleBackColor = false;
            this.btn_cactus.Click += new System.EventHandler(this.btn_cactus_Click);
            // 
            // btn_duck
            // 
            this.btn_duck.BackColor = System.Drawing.Color.Khaki;
            this.btn_duck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_duck.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_duck.Location = new System.Drawing.Point(364, 12);
            this.btn_duck.Name = "btn_duck";
            this.btn_duck.Size = new System.Drawing.Size(117, 51);
            this.btn_duck.TabIndex = 3;
            this.btn_duck.TabStop = false;
            this.btn_duck.Text = "Duck";
            this.btn_duck.UseVisualStyleBackColor = false;
            this.btn_duck.Click += new System.EventHandler(this.btn_duck_Click);
            // 
            // btn_bear
            // 
            this.btn_bear.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_bear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bear.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bear.Location = new System.Drawing.Point(195, 12);
            this.btn_bear.Name = "btn_bear";
            this.btn_bear.Size = new System.Drawing.Size(117, 51);
            this.btn_bear.TabIndex = 2;
            this.btn_bear.TabStop = false;
            this.btn_bear.Text = "Bear";
            this.btn_bear.UseVisualStyleBackColor = false;
            this.btn_bear.Click += new System.EventHandler(this.btn_bear_Click);
            // 
            // btn_wolf
            // 
            this.btn_wolf.BackColor = System.Drawing.Color.Silver;
            this.btn_wolf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_wolf.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wolf.Location = new System.Drawing.Point(28, 12);
            this.btn_wolf.Name = "btn_wolf";
            this.btn_wolf.Size = new System.Drawing.Size(117, 51);
            this.btn_wolf.TabIndex = 1;
            this.btn_wolf.TabStop = false;
            this.btn_wolf.Text = "Wolf";
            this.btn_wolf.UseVisualStyleBackColor = false;
            this.btn_wolf.Click += new System.EventHandler(this.btn_wolf_Click);
            // 
            // pnl_skinSection
            // 
            this.pnl_skinSection.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_skinSection.Controls.Add(this.btn_defaultSkin);
            this.pnl_skinSection.Controls.Add(this.lbl_walletshop);
            this.pnl_skinSection.Controls.Add(this.lbl_wallettitle);
            this.pnl_skinSection.Controls.Add(this.btn_slot3);
            this.pnl_skinSection.Controls.Add(this.btn_slot2);
            this.pnl_skinSection.Controls.Add(this.btn_slot1);
            this.pnl_skinSection.Controls.Add(this.slotSkin2);
            this.pnl_skinSection.Controls.Add(this.slotSkin3);
            this.pnl_skinSection.Controls.Add(this.slotSkin1);
            this.pnl_skinSection.Location = new System.Drawing.Point(28, 82);
            this.pnl_skinSection.Name = "pnl_skinSection";
            this.pnl_skinSection.Size = new System.Drawing.Size(793, 437);
            this.pnl_skinSection.TabIndex = 0;
            // 
            // lbl_wallettitle
            // 
            this.lbl_wallettitle.AutoSize = true;
            this.lbl_wallettitle.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wallettitle.Location = new System.Drawing.Point(330, 15);
            this.lbl_wallettitle.Name = "lbl_wallettitle";
            this.lbl_wallettitle.Size = new System.Drawing.Size(134, 36);
            this.lbl_wallettitle.TabIndex = 6;
            this.lbl_wallettitle.Text = "Wallet";
            // 
            // lbl_wallet
            // 
            this.lbl_wallet.AutoSize = true;
            this.lbl_wallet.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wallet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_wallet.Location = new System.Drawing.Point(556, 138);
            this.lbl_wallet.Name = "lbl_wallet";
            this.lbl_wallet.Size = new System.Drawing.Size(128, 28);
            this.lbl_wallet.TabIndex = 32;
            this.lbl_wallet.Text = "Wallet:       ";
            // 
            // lbl_highscore
            // 
            this.lbl_highscore.AutoSize = true;
            this.lbl_highscore.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highscore.Location = new System.Drawing.Point(446, 13);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(131, 28);
            this.lbl_highscore.TabIndex = 34;
            this.lbl_highscore.Text = "High score:";
            // 
            // btn_resetsave
            // 
            this.btn_resetsave.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_resetsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resetsave.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetsave.Location = new System.Drawing.Point(609, 18);
            this.btn_resetsave.Name = "btn_resetsave";
            this.btn_resetsave.Size = new System.Drawing.Size(91, 41);
            this.btn_resetsave.TabIndex = 36;
            this.btn_resetsave.TabStop = false;
            this.btn_resetsave.Text = "Reset\r\nsave game";
            this.btn_resetsave.UseVisualStyleBackColor = false;
            this.btn_resetsave.Click += new System.EventHandler(this.btn_resetsave_Click);
            // 
            // btn_defaultSkin
            // 
            this.btn_defaultSkin.BackColor = System.Drawing.Color.DimGray;
            this.btn_defaultSkin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_defaultSkin.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defaultSkin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_defaultSkin.Location = new System.Drawing.Point(328, 109);
            this.btn_defaultSkin.Name = "btn_defaultSkin";
            this.btn_defaultSkin.Size = new System.Drawing.Size(138, 42);
            this.btn_defaultSkin.TabIndex = 8;
            this.btn_defaultSkin.TabStop = false;
            this.btn_defaultSkin.Text = "Default Skin";
            this.btn_defaultSkin.UseVisualStyleBackColor = false;
            this.btn_defaultSkin.Click += new System.EventHandler(this.btn_defaultSkin_Click);
            // 
            // lbl_walletshop
            // 
            this.lbl_walletshop.AutoSize = true;
            this.lbl_walletshop.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_walletshop.Image = ((System.Drawing.Image)(resources.GetObject("lbl_walletshop.Image")));
            this.lbl_walletshop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_walletshop.Location = new System.Drawing.Point(358, 56);
            this.lbl_walletshop.Name = "lbl_walletshop";
            this.lbl_walletshop.Size = new System.Drawing.Size(68, 33);
            this.lbl_walletshop.TabIndex = 7;
            this.lbl_walletshop.Text = "0      ";
            this.lbl_walletshop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_slot3
            // 
            this.btn_slot3.BackColor = System.Drawing.Color.Tomato;
            this.btn_slot3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_slot3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slot3.Image = ((System.Drawing.Image)(resources.GetObject("btn_slot3.Image")));
            this.btn_slot3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_slot3.Location = new System.Drawing.Point(592, 213);
            this.btn_slot3.Name = "btn_slot3";
            this.btn_slot3.Size = new System.Drawing.Size(138, 42);
            this.btn_slot3.TabIndex = 5;
            this.btn_slot3.TabStop = false;
            this.btn_slot3.Text = "Buy 75";
            this.btn_slot3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_slot3.UseVisualStyleBackColor = false;
            this.btn_slot3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_slot3_MouseClick);
            // 
            // btn_slot2
            // 
            this.btn_slot2.BackColor = System.Drawing.Color.Tomato;
            this.btn_slot2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_slot2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slot2.Image = ((System.Drawing.Image)(resources.GetObject("btn_slot2.Image")));
            this.btn_slot2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_slot2.Location = new System.Drawing.Point(328, 343);
            this.btn_slot2.Name = "btn_slot2";
            this.btn_slot2.Size = new System.Drawing.Size(138, 42);
            this.btn_slot2.TabIndex = 4;
            this.btn_slot2.TabStop = false;
            this.btn_slot2.Text = "Buy 50";
            this.btn_slot2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_slot2.UseVisualStyleBackColor = false;
            this.btn_slot2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_slot2_MouseClick);
            // 
            // btn_slot1
            // 
            this.btn_slot1.BackColor = System.Drawing.Color.Tomato;
            this.btn_slot1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_slot1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slot1.Image = ((System.Drawing.Image)(resources.GetObject("btn_slot1.Image")));
            this.btn_slot1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_slot1.Location = new System.Drawing.Point(62, 213);
            this.btn_slot1.Name = "btn_slot1";
            this.btn_slot1.Size = new System.Drawing.Size(138, 42);
            this.btn_slot1.TabIndex = 3;
            this.btn_slot1.TabStop = false;
            this.btn_slot1.Text = "Buy 25";
            this.btn_slot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_slot1.UseVisualStyleBackColor = false;
            this.btn_slot1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_slot1_MouseClick);
            // 
            // slotSkin2
            // 
            this.slotSkin2.Location = new System.Drawing.Point(289, 167);
            this.slotSkin2.Name = "slotSkin2";
            this.slotSkin2.Size = new System.Drawing.Size(213, 170);
            this.slotSkin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slotSkin2.TabIndex = 2;
            this.slotSkin2.TabStop = false;
            // 
            // slotSkin3
            // 
            this.slotSkin3.Location = new System.Drawing.Point(554, 37);
            this.slotSkin3.Name = "slotSkin3";
            this.slotSkin3.Size = new System.Drawing.Size(213, 170);
            this.slotSkin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slotSkin3.TabIndex = 1;
            this.slotSkin3.TabStop = false;
            // 
            // slotSkin1
            // 
            this.slotSkin1.Location = new System.Drawing.Point(28, 37);
            this.slotSkin1.Name = "slotSkin1";
            this.slotSkin1.Size = new System.Drawing.Size(213, 170);
            this.slotSkin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slotSkin1.TabIndex = 0;
            this.slotSkin1.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.Image = global::Wolf_Marathon.Properties.Resources.Ground;
            this.ground2.Location = new System.Drawing.Point(409, 431);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(857, 119);
            this.ground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground2.TabIndex = 20;
            this.ground2.TabStop = false;
            // 
            // Dcoin
            // 
            this.Dcoin.Image = global::Wolf_Marathon.Properties.Resources.coin2;
            this.Dcoin.Location = new System.Drawing.Point(513, 191);
            this.Dcoin.Name = "Dcoin";
            this.Dcoin.Size = new System.Drawing.Size(32, 29);
            this.Dcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dcoin.TabIndex = 35;
            this.Dcoin.TabStop = false;
            // 
            // Gcoin
            // 
            this.Gcoin.Image = global::Wolf_Marathon.Properties.Resources.coin;
            this.Gcoin.Location = new System.Drawing.Point(575, 191);
            this.Gcoin.Name = "Gcoin";
            this.Gcoin.Size = new System.Drawing.Size(59, 54);
            this.Gcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gcoin.TabIndex = 33;
            this.Gcoin.TabStop = false;
            // 
            // btn_store
            // 
            this.btn_store.BackgroundImage = global::Wolf_Marathon.Properties.Resources.store;
            this.btn_store.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_store.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_store.Location = new System.Drawing.Point(651, 179);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(135, 112);
            this.btn_store.TabIndex = 30;
            this.btn_store.TabStop = false;
            this.btn_store.UseVisualStyleBackColor = true;
            this.btn_store.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_store_MouseClick);
            // 
            // duck
            // 
            this.duck.Image = global::Wolf_Marathon.Properties.Resources.duck;
            this.duck.Location = new System.Drawing.Point(559, 0);
            this.duck.Name = "duck";
            this.duck.Size = new System.Drawing.Size(286, 124);
            this.duck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.duck.TabIndex = 27;
            this.duck.TabStop = false;
            // 
            // cactus
            // 
            this.cactus.Image = global::Wolf_Marathon.Properties.Resources.cactus;
            this.cactus.Location = new System.Drawing.Point(742, 343);
            this.cactus.Name = "cactus";
            this.cactus.Size = new System.Drawing.Size(79, 88);
            this.cactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cactus.TabIndex = 26;
            this.cactus.TabStop = false;
            // 
            // bear
            // 
            this.bear.Image = global::Wolf_Marathon.Properties.Resources.bear;
            this.bear.Location = new System.Drawing.Point(651, 343);
            this.bear.Name = "bear";
            this.bear.Size = new System.Drawing.Size(79, 59);
            this.bear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bear.TabIndex = 25;
            this.bear.TabStop = false;
            // 
            // wolf_die
            // 
            this.wolf_die.Image = global::Wolf_Marathon.Properties.Resources.player_die;
            this.wolf_die.Location = new System.Drawing.Point(275, 320);
            this.wolf_die.Name = "wolf_die";
            this.wolf_die.Size = new System.Drawing.Size(88, 111);
            this.wolf_die.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolf_die.TabIndex = 24;
            this.wolf_die.TabStop = false;
            // 
            // wolf_jump
            // 
            this.wolf_jump.Image = global::Wolf_Marathon.Properties.Resources.player_jump;
            this.wolf_jump.Location = new System.Drawing.Point(181, 320);
            this.wolf_jump.Name = "wolf_jump";
            this.wolf_jump.Size = new System.Drawing.Size(88, 111);
            this.wolf_jump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolf_jump.TabIndex = 23;
            this.wolf_jump.TabStop = false;
            this.wolf_jump.Tag = "";
            // 
            // wolf
            // 
            this.wolf.Image = global::Wolf_Marathon.Properties.Resources.player;
            this.wolf.Location = new System.Drawing.Point(87, 320);
            this.wolf.Name = "wolf";
            this.wolf.Size = new System.Drawing.Size(88, 111);
            this.wolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolf.TabIndex = 22;
            this.wolf.TabStop = false;
            this.wolf.Tag = "";
            // 
            // ground1
            // 
            this.ground1.Image = global::Wolf_Marathon.Properties.Resources.Ground;
            this.ground1.Location = new System.Drawing.Point(-447, 431);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(857, 119);
            this.ground1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground1.TabIndex = 19;
            this.ground1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(844, 550);
            this.Controls.Add(this.pnl_store);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.btn_resetsave);
            this.Controls.Add(this.Dcoin);
            this.Controls.Add(this.lbl_highscore);
            this.Controls.Add(this.Gcoin);
            this.Controls.Add(this.lbl_wallet);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.lbl_gameover);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.duck);
            this.Controls.Add(this.cactus);
            this.Controls.Add(this.bear);
            this.Controls.Add(this.wolf_die);
            this.Controls.Add(this.wolf_jump);
            this.Controls.Add(this.wolf);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_esc);
            this.Controls.Add(this.lbl_playagain);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wolf Marathon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnl_store.ResumeLayout(false);
            this.pnl_skinSection.ResumeLayout(false);
            this.pnl_skinSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slotSkin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotSkin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotSkin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dcoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gcoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf_die)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf_jump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_esc;
        private System.Windows.Forms.Label lbl_playagain;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox wolf;
        private System.Windows.Forms.PictureBox wolf_jump;
        private System.Windows.Forms.PictureBox wolf_die;
        private System.Windows.Forms.PictureBox bear;
        private System.Windows.Forms.PictureBox cactus;
        private System.Windows.Forms.PictureBox duck;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_gameover;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Panel pnl_store;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_cactus;
        private System.Windows.Forms.Button btn_duck;
        private System.Windows.Forms.Button btn_bear;
        private System.Windows.Forms.Button btn_wolf;
        private System.Windows.Forms.Panel pnl_skinSection;
        private System.Windows.Forms.PictureBox slotSkin2;
        private System.Windows.Forms.PictureBox slotSkin3;
        private System.Windows.Forms.PictureBox slotSkin1;
        private System.Windows.Forms.Button btn_slot1;
        private System.Windows.Forms.Label lbl_wallettitle;
        private System.Windows.Forms.Button btn_slot3;
        private System.Windows.Forms.Button btn_slot2;
        private System.Windows.Forms.Label lbl_walletshop;
        private System.Windows.Forms.Label lbl_wallet;
        private System.Windows.Forms.PictureBox Gcoin;
        private System.Windows.Forms.Label lbl_highscore;
        private System.Windows.Forms.PictureBox Dcoin;
        private System.Windows.Forms.Button btn_resetsave;
        private System.Windows.Forms.Button btn_defaultSkin;
    }
}

