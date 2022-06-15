namespace LifeIsHell
{
    partial class frmStartGame
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.txtIntroText = new System.Windows.Forms.TextBox();
            this.btnIntroContinue = new System.Windows.Forms.Button();
            this.boxDirections = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnInteract = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.picboxMainScreen = new System.Windows.Forms.PictureBox();
            this.txtMainScreen = new System.Windows.Forms.TextBox();
            this.btnEnterShop = new System.Windows.Forms.Button();
            this.boxCombat = new System.Windows.Forms.GroupBox();
            this.btnExitCombat = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnPotion = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.boxDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMainScreen)).BeginInit();
            this.boxCombat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(568, 280);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 228);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Life is Hell";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartGame.BackColor = System.Drawing.Color.Black;
            this.btnStartGame.Location = new System.Drawing.Point(701, 584);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(182, 95);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewGame.Location = new System.Drawing.Point(558, 643);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(224, 112);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoadGame.Location = new System.Drawing.Point(802, 643);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(224, 112);
            this.btnLoadGame.TabIndex = 3;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Visible = false;
            // 
            // txtIntroText
            // 
            this.txtIntroText.BackColor = System.Drawing.Color.Black;
            this.txtIntroText.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIntroText.ForeColor = System.Drawing.Color.White;
            this.txtIntroText.Location = new System.Drawing.Point(296, 79);
            this.txtIntroText.Multiline = true;
            this.txtIntroText.Name = "txtIntroText";
            this.txtIntroText.ReadOnly = true;
            this.txtIntroText.Size = new System.Drawing.Size(992, 488);
            this.txtIntroText.TabIndex = 5;
            this.txtIntroText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIntroText.Visible = false;
            // 
            // btnIntroContinue
            // 
            this.btnIntroContinue.BackColor = System.Drawing.Color.Black;
            this.btnIntroContinue.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIntroContinue.ForeColor = System.Drawing.Color.White;
            this.btnIntroContinue.Location = new System.Drawing.Point(660, 616);
            this.btnIntroContinue.Name = "btnIntroContinue";
            this.btnIntroContinue.Size = new System.Drawing.Size(264, 80);
            this.btnIntroContinue.TabIndex = 4;
            this.btnIntroContinue.Text = "Continue";
            this.btnIntroContinue.UseVisualStyleBackColor = false;
            this.btnIntroContinue.Visible = false;
            this.btnIntroContinue.Click += new System.EventHandler(this.btnIntroContinue_Click);
            // 
            // boxDirections
            // 
            this.boxDirections.BackColor = System.Drawing.Color.Transparent;
            this.boxDirections.Controls.Add(this.btnSearch);
            this.boxDirections.Controls.Add(this.btnSave);
            this.boxDirections.Controls.Add(this.btnInteract);
            this.boxDirections.Controls.Add(this.btnWest);
            this.boxDirections.Controls.Add(this.btnTalk);
            this.boxDirections.Controls.Add(this.btnExit);
            this.boxDirections.Controls.Add(this.btnSouth);
            this.boxDirections.Controls.Add(this.btnLoad);
            this.boxDirections.Controls.Add(this.btnEast);
            this.boxDirections.Controls.Add(this.btnNorth);
            this.boxDirections.Location = new System.Drawing.Point(588, 632);
            this.boxDirections.Name = "boxDirections";
            this.boxDirections.Size = new System.Drawing.Size(408, 192);
            this.boxDirections.TabIndex = 6;
            this.boxDirections.TabStop = false;
            this.boxDirections.Visible = false;
            this.boxDirections.Enter += new System.EventHandler(this.boxDirections_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(288, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 48);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(12, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInteract
            // 
            this.btnInteract.BackColor = System.Drawing.Color.Black;
            this.btnInteract.Location = new System.Drawing.Point(288, 132);
            this.btnInteract.Name = "btnInteract";
            this.btnInteract.Size = new System.Drawing.Size(100, 48);
            this.btnInteract.TabIndex = 10;
            this.btnInteract.Text = "Interact";
            this.btnInteract.UseVisualStyleBackColor = false;
            this.btnInteract.Click += new System.EventHandler(this.btnInteract_Click);
            // 
            // btnWest
            // 
            this.btnWest.BackColor = System.Drawing.Color.Black;
            this.btnWest.Location = new System.Drawing.Point(114, 80);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(48, 48);
            this.btnWest.TabIndex = 10;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = false;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnTalk
            // 
            this.btnTalk.BackColor = System.Drawing.Color.Black;
            this.btnTalk.Location = new System.Drawing.Point(288, 78);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(100, 48);
            this.btnTalk.TabIndex = 9;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(12, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 48);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.BackColor = System.Drawing.Color.Black;
            this.btnSouth.Location = new System.Drawing.Point(176, 136);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(48, 48);
            this.btnSouth.TabIndex = 9;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = false;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(12, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 48);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnEast
            // 
            this.btnEast.BackColor = System.Drawing.Color.Black;
            this.btnEast.Location = new System.Drawing.Point(240, 78);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(48, 48);
            this.btnEast.TabIndex = 8;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = false;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.BackColor = System.Drawing.Color.Black;
            this.btnNorth.Location = new System.Drawing.Point(176, 24);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(48, 48);
            this.btnNorth.TabIndex = 7;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = false;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // picboxMainScreen
            // 
            this.picboxMainScreen.BackColor = System.Drawing.Color.Transparent;
            this.picboxMainScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxMainScreen.Location = new System.Drawing.Point(184, 16);
            this.picboxMainScreen.Name = "picboxMainScreen";
            this.picboxMainScreen.Size = new System.Drawing.Size(600, 600);
            this.picboxMainScreen.TabIndex = 7;
            this.picboxMainScreen.TabStop = false;
            this.picboxMainScreen.Visible = false;
            this.picboxMainScreen.Click += new System.EventHandler(this.picboxMainScreen_Click);
            // 
            // txtMainScreen
            // 
            this.txtMainScreen.Location = new System.Drawing.Point(792, 16);
            this.txtMainScreen.Multiline = true;
            this.txtMainScreen.Name = "txtMainScreen";
            this.txtMainScreen.ReadOnly = true;
            this.txtMainScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainScreen.Size = new System.Drawing.Size(600, 600);
            this.txtMainScreen.TabIndex = 8;
            this.txtMainScreen.Visible = false;
            this.txtMainScreen.TextChanged += new System.EventHandler(this.txtMainScren_TextChanged);
            // 
            // btnEnterShop
            // 
            this.btnEnterShop.BackColor = System.Drawing.Color.Black;
            this.btnEnterShop.Location = new System.Drawing.Point(1002, 657);
            this.btnEnterShop.Name = "btnEnterShop";
            this.btnEnterShop.Size = new System.Drawing.Size(100, 48);
            this.btnEnterShop.TabIndex = 15;
            this.btnEnterShop.Text = "Enter Shop";
            this.btnEnterShop.UseVisualStyleBackColor = false;
            this.btnEnterShop.Visible = false;
            this.btnEnterShop.Click += new System.EventHandler(this.btnEnterShop_Click);
            // 
            // boxCombat
            // 
            this.boxCombat.Controls.Add(this.btnExitCombat);
            this.boxCombat.Controls.Add(this.btnDefend);
            this.boxCombat.Controls.Add(this.btnPotion);
            this.boxCombat.Controls.Add(this.btnRun);
            this.boxCombat.Controls.Add(this.btnAttack);
            this.boxCombat.Location = new System.Drawing.Point(568, 624);
            this.boxCombat.Name = "boxCombat";
            this.boxCombat.Size = new System.Drawing.Size(445, 200);
            this.boxCombat.TabIndex = 16;
            this.boxCombat.TabStop = false;
            this.boxCombat.Visible = false;
            // 
            // btnExitCombat
            // 
            this.btnExitCombat.BackColor = System.Drawing.Color.Black;
            this.btnExitCombat.Location = new System.Drawing.Point(172, 80);
            this.btnExitCombat.Name = "btnExitCombat";
            this.btnExitCombat.Size = new System.Drawing.Size(100, 48);
            this.btnExitCombat.TabIndex = 19;
            this.btnExitCombat.Text = "Exit";
            this.btnExitCombat.UseVisualStyleBackColor = false;
            this.btnExitCombat.Visible = false;
            this.btnExitCombat.Click += new System.EventHandler(this.btnExitCombat_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.BackColor = System.Drawing.Color.Black;
            this.btnDefend.Location = new System.Drawing.Point(115, 81);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(100, 48);
            this.btnDefend.TabIndex = 18;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = false;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnPotion
            // 
            this.btnPotion.BackColor = System.Drawing.Color.Black;
            this.btnPotion.Location = new System.Drawing.Point(233, 81);
            this.btnPotion.Name = "btnPotion";
            this.btnPotion.Size = new System.Drawing.Size(100, 48);
            this.btnPotion.TabIndex = 17;
            this.btnPotion.Text = "Potion";
            this.btnPotion.UseVisualStyleBackColor = false;
            this.btnPotion.Click += new System.EventHandler(this.btnPotion_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(172, 135);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 48);
            this.btnRun.TabIndex = 16;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Black;
            this.btnAttack.Location = new System.Drawing.Point(172, 26);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(100, 48);
            this.btnAttack.TabIndex = 15;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // frmStartGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.boxCombat);
            this.Controls.Add(this.btnEnterShop);
            this.Controls.Add(this.txtMainScreen);
            this.Controls.Add(this.picboxMainScreen);
            this.Controls.Add(this.boxDirections);
            this.Controls.Add(this.txtIntroText);
            this.Controls.Add(this.btnIntroContinue);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "frmStartGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life is Hell";
            this.Load += new System.EventHandler(this.frmStartGame_Load);
            this.boxDirections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxMainScreen)).EndInit();
            this.boxCombat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnStartGame;
        private Button btnNewGame;
        private Button btnLoadGame;
        private Button btnIntroContinue;
        private GroupBox boxDirections;
        private Button btnSearch;
        private Button btnSave;
        private Button btnInteract;
        private Button btnTalk;
        private Button btnExit;
        private Button btnLoad;
        public TextBox txtIntroText;
        public PictureBox picboxMainScreen;
        public TextBox txtMainScreen;
        private Button btnEnterShop;
        private GroupBox boxCombat;
        private Button btnDefend;
        private Button btnPotion;
        private Button btnRun;
        private Button btnAttack;
        private Button btnExitCombat;
        public Button btnEast;
        public Button btnWest;
        public Button btnSouth;
        public Button btnNorth;
    }
}