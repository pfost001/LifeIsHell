namespace LifeIsHell
{
    partial class InsertName
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblInsertName = new System.Windows.Forms.Label();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.lblNameError = new System.Windows.Forms.Label();
            this.btnInsertName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblInsertName
            // 
            this.lblInsertName.AutoSize = true;
            this.lblInsertName.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInsertName.Location = new System.Drawing.Point(73, 32);
            this.lblInsertName.Name = "lblInsertName";
            this.lblInsertName.Size = new System.Drawing.Size(249, 29);
            this.lblInsertName.TabIndex = 0;
            this.lblInsertName.Text = "Please enter your name:";
            this.lblInsertName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInsertName
            // 
            this.txtInsertName.Location = new System.Drawing.Point(65, 72);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(264, 23);
            this.txtInsertName.TabIndex = 1;
            this.txtInsertName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(90, 104);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(215, 23);
            this.lblNameError.TabIndex = 2;
            this.lblNameError.Text = "Please enter a valid name.";
            this.lblNameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameError.Visible = false;
            // 
            // btnInsertName
            // 
            this.btnInsertName.BackColor = System.Drawing.Color.Black;
            this.btnInsertName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertName.ForeColor = System.Drawing.Color.White;
            this.btnInsertName.Location = new System.Drawing.Point(137, 136);
            this.btnInsertName.Name = "btnInsertName";
            this.btnInsertName.Size = new System.Drawing.Size(120, 48);
            this.btnInsertName.TabIndex = 3;
            this.btnInsertName.Text = "Continue";
            this.btnInsertName.UseVisualStyleBackColor = false;
            this.btnInsertName.Click += new System.EventHandler(this.btnInsertName_Click);
            // 
            // InsertName
            // 
            this.ClientSize = new System.Drawing.Size(395, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btnInsertName);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.txtInsertName);
            this.Controls.Add(this.lblInsertName);
            this.MaximumSize = new System.Drawing.Size(411, 229);
            this.MinimumSize = new System.Drawing.Size(411, 229);
            this.Name = "InsertName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblInsertName;
        private TextBox txtInsertName;
        private Label lblNameError;
        private Button btnInsertName;
    }
}