namespace LifeIsHell
{
    partial class Shop
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
            this.txtShopPlayerStats = new System.Windows.Forms.TextBox();
            this.btnBuyArmor = new System.Windows.Forms.Button();
            this.btnBuyWeapon = new System.Windows.Forms.Button();
            this.btnBuyHealth = new System.Windows.Forms.Button();
            this.btnBuyPotion = new System.Windows.Forms.Button();
            this.btnBuyDiff = new System.Windows.Forms.Button();
            this.lblStoreItems = new System.Windows.Forms.Label();
            this.lblBuyWeapon = new System.Windows.Forms.Label();
            this.lblBuyArmor = new System.Windows.Forms.Label();
            this.lblBuyHealth = new System.Windows.Forms.Label();
            this.lblBuyPotion = new System.Windows.Forms.Label();
            this.lblBuyDiff = new System.Windows.Forms.Label();
            this.txtWeaponPrice = new System.Windows.Forms.TextBox();
            this.txtArmorPrice = new System.Windows.Forms.TextBox();
            this.txtHealthPrice = new System.Windows.Forms.TextBox();
            this.txtPotionPrice = new System.Windows.Forms.TextBox();
            this.txtDiffPrice = new System.Windows.Forms.TextBox();
            this.lblStoreStats = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNoMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtShopPlayerStats
            // 
            this.txtShopPlayerStats.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtShopPlayerStats.Location = new System.Drawing.Point(37, 50);
            this.txtShopPlayerStats.Multiline = true;
            this.txtShopPlayerStats.Name = "txtShopPlayerStats";
            this.txtShopPlayerStats.ReadOnly = true;
            this.txtShopPlayerStats.Size = new System.Drawing.Size(394, 179);
            this.txtShopPlayerStats.TabIndex = 0;
            // 
            // btnBuyArmor
            // 
            this.btnBuyArmor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyArmor.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuyArmor.ForeColor = System.Drawing.Color.White;
            this.btnBuyArmor.Location = new System.Drawing.Point(352, 350);
            this.btnBuyArmor.Name = "btnBuyArmor";
            this.btnBuyArmor.Size = new System.Drawing.Size(79, 28);
            this.btnBuyArmor.TabIndex = 1;
            this.btnBuyArmor.Text = "BUY";
            this.btnBuyArmor.UseVisualStyleBackColor = false;
            this.btnBuyArmor.Click += new System.EventHandler(this.btnBuyArmor_Click);
            // 
            // btnBuyWeapon
            // 
            this.btnBuyWeapon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyWeapon.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuyWeapon.ForeColor = System.Drawing.Color.White;
            this.btnBuyWeapon.Location = new System.Drawing.Point(352, 384);
            this.btnBuyWeapon.Name = "btnBuyWeapon";
            this.btnBuyWeapon.Size = new System.Drawing.Size(79, 28);
            this.btnBuyWeapon.TabIndex = 2;
            this.btnBuyWeapon.Text = "BUY";
            this.btnBuyWeapon.UseVisualStyleBackColor = false;
            this.btnBuyWeapon.Click += new System.EventHandler(this.btnBuyWeapon_Click);
            // 
            // btnBuyHealth
            // 
            this.btnBuyHealth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyHealth.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuyHealth.ForeColor = System.Drawing.Color.White;
            this.btnBuyHealth.Location = new System.Drawing.Point(352, 418);
            this.btnBuyHealth.Name = "btnBuyHealth";
            this.btnBuyHealth.Size = new System.Drawing.Size(79, 28);
            this.btnBuyHealth.TabIndex = 3;
            this.btnBuyHealth.Text = "BUY";
            this.btnBuyHealth.UseVisualStyleBackColor = false;
            this.btnBuyHealth.Click += new System.EventHandler(this.btnBuyHealth_Click);
            // 
            // btnBuyPotion
            // 
            this.btnBuyPotion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyPotion.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuyPotion.ForeColor = System.Drawing.Color.White;
            this.btnBuyPotion.Location = new System.Drawing.Point(352, 453);
            this.btnBuyPotion.Name = "btnBuyPotion";
            this.btnBuyPotion.Size = new System.Drawing.Size(79, 28);
            this.btnBuyPotion.TabIndex = 4;
            this.btnBuyPotion.Text = "BUY";
            this.btnBuyPotion.UseVisualStyleBackColor = false;
            this.btnBuyPotion.Click += new System.EventHandler(this.btnBuyPotion_Click);
            // 
            // btnBuyDiff
            // 
            this.btnBuyDiff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyDiff.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuyDiff.ForeColor = System.Drawing.Color.White;
            this.btnBuyDiff.Location = new System.Drawing.Point(352, 487);
            this.btnBuyDiff.Name = "btnBuyDiff";
            this.btnBuyDiff.Size = new System.Drawing.Size(79, 28);
            this.btnBuyDiff.TabIndex = 5;
            this.btnBuyDiff.Text = "BUY";
            this.btnBuyDiff.UseVisualStyleBackColor = false;
            this.btnBuyDiff.Click += new System.EventHandler(this.btnBuyDiff_Click);
            // 
            // lblStoreItems
            // 
            this.lblStoreItems.AutoSize = true;
            this.lblStoreItems.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreItems.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStoreItems.ForeColor = System.Drawing.Color.Black;
            this.lblStoreItems.Location = new System.Drawing.Point(37, 318);
            this.lblStoreItems.Name = "lblStoreItems";
            this.lblStoreItems.Size = new System.Drawing.Size(60, 20);
            this.lblStoreItems.TabIndex = 6;
            this.lblStoreItems.Text = "For Sale";
            this.lblStoreItems.Click += new System.EventHandler(this.lblStoreItems_Click);
            // 
            // lblBuyWeapon
            // 
            this.lblBuyWeapon.AutoSize = true;
            this.lblBuyWeapon.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuyWeapon.Location = new System.Drawing.Point(37, 352);
            this.lblBuyWeapon.Name = "lblBuyWeapon";
            this.lblBuyWeapon.Size = new System.Drawing.Size(201, 23);
            this.lblBuyWeapon.TabIndex = 7;
            this.lblBuyWeapon.Text = "Weapon Power Increase";
            // 
            // lblBuyArmor
            // 
            this.lblBuyArmor.AutoSize = true;
            this.lblBuyArmor.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuyArmor.Location = new System.Drawing.Point(37, 386);
            this.lblBuyArmor.Name = "lblBuyArmor";
            this.lblBuyArmor.Size = new System.Drawing.Size(178, 23);
            this.lblBuyArmor.TabIndex = 8;
            this.lblBuyArmor.Text = "Armor Value Increase";
            // 
            // lblBuyHealth
            // 
            this.lblBuyHealth.AutoSize = true;
            this.lblBuyHealth.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuyHealth.Location = new System.Drawing.Point(37, 420);
            this.lblBuyHealth.Name = "lblBuyHealth";
            this.lblBuyHealth.Size = new System.Drawing.Size(214, 23);
            this.lblBuyHealth.TabIndex = 9;
            this.lblBuyHealth.Text = "Maximum Health Increase";
            // 
            // lblBuyPotion
            // 
            this.lblBuyPotion.AutoSize = true;
            this.lblBuyPotion.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuyPotion.Location = new System.Drawing.Point(37, 454);
            this.lblBuyPotion.Name = "lblBuyPotion";
            this.lblBuyPotion.Size = new System.Drawing.Size(125, 23);
            this.lblBuyPotion.TabIndex = 10;
            this.lblBuyPotion.Text = "Healing Potion";
            // 
            // lblBuyDiff
            // 
            this.lblBuyDiff.AutoSize = true;
            this.lblBuyDiff.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuyDiff.Location = new System.Drawing.Point(37, 488);
            this.lblBuyDiff.Name = "lblBuyDiff";
            this.lblBuyDiff.Size = new System.Drawing.Size(155, 23);
            this.lblBuyDiff.TabIndex = 11;
            this.lblBuyDiff.Text = "Increase Difficulty";
            // 
            // txtWeaponPrice
            // 
            this.txtWeaponPrice.Location = new System.Drawing.Point(274, 384);
            this.txtWeaponPrice.Name = "txtWeaponPrice";
            this.txtWeaponPrice.ReadOnly = true;
            this.txtWeaponPrice.Size = new System.Drawing.Size(72, 23);
            this.txtWeaponPrice.TabIndex = 12;
            // 
            // txtArmorPrice
            // 
            this.txtArmorPrice.Location = new System.Drawing.Point(274, 354);
            this.txtArmorPrice.Name = "txtArmorPrice";
            this.txtArmorPrice.ReadOnly = true;
            this.txtArmorPrice.Size = new System.Drawing.Size(72, 23);
            this.txtArmorPrice.TabIndex = 13;
            // 
            // txtHealthPrice
            // 
            this.txtHealthPrice.Location = new System.Drawing.Point(274, 420);
            this.txtHealthPrice.Name = "txtHealthPrice";
            this.txtHealthPrice.ReadOnly = true;
            this.txtHealthPrice.Size = new System.Drawing.Size(72, 23);
            this.txtHealthPrice.TabIndex = 14;
            // 
            // txtPotionPrice
            // 
            this.txtPotionPrice.Location = new System.Drawing.Point(274, 454);
            this.txtPotionPrice.Name = "txtPotionPrice";
            this.txtPotionPrice.ReadOnly = true;
            this.txtPotionPrice.Size = new System.Drawing.Size(72, 23);
            this.txtPotionPrice.TabIndex = 15;
            // 
            // txtDiffPrice
            // 
            this.txtDiffPrice.Location = new System.Drawing.Point(274, 488);
            this.txtDiffPrice.Name = "txtDiffPrice";
            this.txtDiffPrice.ReadOnly = true;
            this.txtDiffPrice.Size = new System.Drawing.Size(72, 23);
            this.txtDiffPrice.TabIndex = 16;
            // 
            // lblStoreStats
            // 
            this.lblStoreStats.AutoSize = true;
            this.lblStoreStats.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreStats.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStoreStats.ForeColor = System.Drawing.Color.Black;
            this.lblStoreStats.Location = new System.Drawing.Point(37, 18);
            this.lblStoreStats.Name = "lblStoreStats";
            this.lblStoreStats.Size = new System.Drawing.Size(116, 20);
            this.lblStoreStats.TabIndex = 17;
            this.lblStoreStats.Text = "Player Statistics";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(352, 521);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNoMoney
            // 
            this.lblNoMoney.AutoSize = true;
            this.lblNoMoney.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoMoney.ForeColor = System.Drawing.Color.Red;
            this.lblNoMoney.Location = new System.Drawing.Point(54, 263);
            this.lblNoMoney.Name = "lblNoMoney";
            this.lblNoMoney.Size = new System.Drawing.Size(358, 26);
            this.lblNoMoney.TabIndex = 19;
            this.lblNoMoney.Text = "You do not have enough coins to do that.";
            this.lblNoMoney.Visible = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 588);
            this.ControlBox = false;
            this.Controls.Add(this.lblNoMoney);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStoreStats);
            this.Controls.Add(this.txtDiffPrice);
            this.Controls.Add(this.txtPotionPrice);
            this.Controls.Add(this.txtHealthPrice);
            this.Controls.Add(this.txtArmorPrice);
            this.Controls.Add(this.txtWeaponPrice);
            this.Controls.Add(this.lblBuyDiff);
            this.Controls.Add(this.lblBuyPotion);
            this.Controls.Add(this.lblBuyHealth);
            this.Controls.Add(this.lblBuyArmor);
            this.Controls.Add(this.lblBuyWeapon);
            this.Controls.Add(this.lblStoreItems);
            this.Controls.Add(this.btnBuyDiff);
            this.Controls.Add(this.btnBuyPotion);
            this.Controls.Add(this.btnBuyHealth);
            this.Controls.Add(this.btnBuyWeapon);
            this.Controls.Add(this.btnBuyArmor);
            this.Controls.Add(this.txtShopPlayerStats);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tom\'s Gift Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtShopPlayerStats;
        private Button btnBuyArmor;
        private Button btnBuyWeapon;
        private Button btnBuyHealth;
        private Button btnBuyPotion;
        private Button btnBuyDiff;
        private Label lblStoreItems;
        private Label lblBuyWeapon;
        private Label lblBuyArmor;
        private Label lblBuyHealth;
        private Label lblBuyPotion;
        private Label lblBuyDiff;
        private TextBox txtWeaponPrice;
        private TextBox txtArmorPrice;
        private TextBox txtHealthPrice;
        private TextBox txtPotionPrice;
        private TextBox txtDiffPrice;
        private Label lblStoreStats;
        private Button btnExit;
        private Label lblNoMoney;
    }
}