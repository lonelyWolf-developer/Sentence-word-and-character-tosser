namespace ProhazovacZnakuVet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxZadani = new System.Windows.Forms.TextBox();
            this.listBoxVystup = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProhazSlova = new System.Windows.Forms.Button();
            this.btnSlovaVety = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.tBZnakVstup = new System.Windows.Forms.TextBox();
            this.tBZnakVystup = new System.Windows.Forms.TextBox();
            this.btnNahrad = new System.Windows.Forms.Button();
            this.gBNahrazovani = new System.Windows.Forms.GroupBox();
            this.gBNahrazovani.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxZadani
            // 
            this.textBoxZadani.Location = new System.Drawing.Point(12, 67);
            this.textBoxZadani.Multiline = true;
            this.textBoxZadani.Name = "textBoxZadani";
            this.textBoxZadani.Size = new System.Drawing.Size(276, 417);
            this.textBoxZadani.TabIndex = 0;
            // 
            // listBoxVystup
            // 
            this.listBoxVystup.FormattingEnabled = true;
            this.listBoxVystup.ItemHeight = 17;
            this.listBoxVystup.Location = new System.Drawing.Point(618, 72);
            this.listBoxVystup.Name = "listBoxVystup";
            this.listBoxVystup.Size = new System.Drawing.Size(275, 412);
            this.listBoxVystup.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(366, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prohaž věty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(366, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ulož do souboru";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(366, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Načti poslední";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProhazSlova
            // 
            this.btnProhazSlova.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProhazSlova.Location = new System.Drawing.Point(366, 169);
            this.btnProhazSlova.Name = "btnProhazSlova";
            this.btnProhazSlova.Size = new System.Drawing.Size(164, 30);
            this.btnProhazSlova.TabIndex = 5;
            this.btnProhazSlova.Text = "Prohaž slova";
            this.btnProhazSlova.UseVisualStyleBackColor = true;
            this.btnProhazSlova.Click += new System.EventHandler(this.btnProhazSlova_Click);
            // 
            // btnSlovaVety
            // 
            this.btnSlovaVety.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSlovaVety.Location = new System.Drawing.Point(366, 215);
            this.btnSlovaVety.Name = "btnSlovaVety";
            this.btnSlovaVety.Size = new System.Drawing.Size(164, 30);
            this.btnSlovaVety.TabIndex = 6;
            this.btnSlovaVety.Text = "Prohaž slova i věty";
            this.btnSlovaVety.UseVisualStyleBackColor = true;
            this.btnSlovaVety.Click += new System.EventHandler(this.btnSlovaVety_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(6, 34);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(100, 21);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Nahraď znak";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblText2.Location = new System.Drawing.Point(156, 34);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(65, 21);
            this.lblText2.TabIndex = 8;
            this.lblText2.Text = "znakem";
            // 
            // tBZnakVstup
            // 
            this.tBZnakVstup.Location = new System.Drawing.Point(112, 30);
            this.tBZnakVstup.Name = "tBZnakVstup";
            this.tBZnakVstup.Size = new System.Drawing.Size(38, 25);
            this.tBZnakVstup.TabIndex = 9;
            // 
            // tBZnakVystup
            // 
            this.tBZnakVystup.Location = new System.Drawing.Point(227, 30);
            this.tBZnakVystup.Name = "tBZnakVystup";
            this.tBZnakVystup.Size = new System.Drawing.Size(38, 25);
            this.tBZnakVystup.TabIndex = 10;
            // 
            // btnNahrad
            // 
            this.btnNahrad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNahrad.Location = new System.Drawing.Point(67, 75);
            this.btnNahrad.Name = "btnNahrad";
            this.btnNahrad.Size = new System.Drawing.Size(164, 30);
            this.btnNahrad.TabIndex = 11;
            this.btnNahrad.Text = "Nahraď znaky";
            this.btnNahrad.UseVisualStyleBackColor = true;
            this.btnNahrad.Click += new System.EventHandler(this.btnNahrad_Click);
            // 
            // gBNahrazovani
            // 
            this.gBNahrazovani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gBNahrazovani.Controls.Add(this.lblText);
            this.gBNahrazovani.Controls.Add(this.btnNahrad);
            this.gBNahrazovani.Controls.Add(this.tBZnakVstup);
            this.gBNahrazovani.Controls.Add(this.tBZnakVystup);
            this.gBNahrazovani.Controls.Add(this.lblText2);
            this.gBNahrazovani.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBNahrazovani.Location = new System.Drawing.Point(309, 264);
            this.gBNahrazovani.Name = "gBNahrazovani";
            this.gBNahrazovani.Size = new System.Drawing.Size(291, 123);
            this.gBNahrazovani.TabIndex = 12;
            this.gBNahrazovani.TabStop = false;
            this.gBNahrazovani.Text = "Nahraď libovolný znak jiným";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 537);
            this.Controls.Add(this.gBNahrazovani);
            this.Controls.Add(this.btnSlovaVety);
            this.Controls.Add(this.btnProhazSlova);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxVystup);
            this.Controls.Add(this.textBoxZadani);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prohazovač vět a znaků - Vlk samotář";
            this.gBNahrazovani.ResumeLayout(false);
            this.gBNahrazovani.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxZadani;
        private ListBox listBoxVystup;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnProhazSlova;
        private Button btnSlovaVety;
        private Label lblText;
        private Label lblText2;
        private TextBox tBZnakVstup;
        private TextBox tBZnakVystup;
        private Button btnNahrad;
        private GroupBox gBNahrazovani;
    }
}