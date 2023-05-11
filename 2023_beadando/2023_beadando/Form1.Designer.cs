
namespace _2023_beadando
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
            this.baladatsor = new System.Windows.Forms.ListBox();
            this.jobbadatsor = new System.Windows.Forms.ListBox();
            this.generalas = new System.Windows.Forms.Button();
            this.mutat = new System.Windows.Forms.Button();
            this.mennyiseg = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.v7 = new System.Windows.Forms.CheckBox();
            this.v6 = new System.Windows.Forms.CheckBox();
            this.v5 = new System.Windows.Forms.CheckBox();
            this.v4 = new System.Windows.Forms.CheckBox();
            this.v3 = new System.Windows.Forms.CheckBox();
            this.v2 = new System.Windows.Forms.CheckBox();
            this.v1 = new System.Windows.Forms.CheckBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // baladatsor
            // 
            this.baladatsor.FormattingEnabled = true;
            this.baladatsor.ItemHeight = 16;
            this.baladatsor.Location = new System.Drawing.Point(31, 108);
            this.baladatsor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baladatsor.Name = "baladatsor";
            this.baladatsor.Size = new System.Drawing.Size(159, 420);
            this.baladatsor.TabIndex = 0;
            // 
            // jobbadatsor
            // 
            this.jobbadatsor.FormattingEnabled = true;
            this.jobbadatsor.ItemHeight = 16;
            this.jobbadatsor.Location = new System.Drawing.Point(499, 108);
            this.jobbadatsor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jobbadatsor.Name = "jobbadatsor";
            this.jobbadatsor.Size = new System.Drawing.Size(159, 420);
            this.jobbadatsor.TabIndex = 1;
            // 
            // generalas
            // 
            this.generalas.Location = new System.Drawing.Point(31, 60);
            this.generalas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generalas.Name = "generalas";
            this.generalas.Size = new System.Drawing.Size(100, 28);
            this.generalas.TabIndex = 2;
            this.generalas.Text = "Generálás";
            this.generalas.UseVisualStyleBackColor = true;
            this.generalas.Click += new System.EventHandler(this.generalas_Click);
            // 
            // mutat
            // 
            this.mutat.Location = new System.Drawing.Point(295, 336);
            this.mutat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mutat.Name = "mutat";
            this.mutat.Size = new System.Drawing.Size(100, 28);
            this.mutat.TabIndex = 3;
            this.mutat.Text = "Mutat";
            this.mutat.UseVisualStyleBackColor = true;
            this.mutat.Click += new System.EventHandler(this.mutat_Click);
            // 
            // mennyiseg
            // 
            this.mennyiseg.AutoSize = true;
            this.mennyiseg.Location = new System.Drawing.Point(322, 368);
            this.mennyiseg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.Size = new System.Drawing.Size(46, 17);
            this.mennyiseg.TabIndex = 5;
            this.mennyiseg.Text = "label1";
            this.mennyiseg.Click += new System.EventHandler(this.mennyiseg_Click);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.v7);
            this.gb.Controls.Add(this.v6);
            this.gb.Controls.Add(this.v5);
            this.gb.Controls.Add(this.v4);
            this.gb.Controls.Add(this.v3);
            this.gb.Controls.Add(this.v2);
            this.gb.Controls.Add(this.v1);
            this.gb.Location = new System.Drawing.Point(223, 108);
            this.gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb.Name = "gb";
            this.gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb.Size = new System.Drawing.Size(239, 220);
            this.gb.TabIndex = 6;
            this.gb.TabStop = false;
            // 
            // v7
            // 
            this.v7.AutoSize = true;
            this.v7.Location = new System.Drawing.Point(8, 192);
            this.v7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v7.Name = "v7";
            this.v7.Size = new System.Drawing.Size(130, 21);
            this.v7.TabIndex = 6;
            this.v7.Text = "Négyzetszámok";
            this.v7.UseVisualStyleBackColor = true;
            // 
            // v6
            // 
            this.v6.AutoSize = true;
            this.v6.Location = new System.Drawing.Point(8, 165);
            this.v6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v6.Name = "v6";
            this.v6.Size = new System.Drawing.Size(164, 21);
            this.v6.TabIndex = 5;
            this.v6.Text = "9-el osztható számok";
            this.v6.UseVisualStyleBackColor = true;
            // 
            // v5
            // 
            this.v5.AutoSize = true;
            this.v5.Location = new System.Drawing.Point(8, 137);
            this.v5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v5.Name = "v5";
            this.v5.Size = new System.Drawing.Size(164, 21);
            this.v5.TabIndex = 4;
            this.v5.Text = "6-al osztható számok";
            this.v5.UseVisualStyleBackColor = true;
            // 
            // v4
            // 
            this.v4.AutoSize = true;
            this.v4.Location = new System.Drawing.Point(8, 108);
            this.v4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(164, 21);
            this.v4.TabIndex = 3;
            this.v4.Text = "3-al osztható számok";
            this.v4.UseVisualStyleBackColor = true;
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.Location = new System.Drawing.Point(8, 80);
            this.v3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(137, 21);
            this.v3.TabIndex = 2;
            this.v3.Text = "Páratlan Számok";
            this.v3.UseVisualStyleBackColor = true;
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.Location = new System.Drawing.Point(8, 52);
            this.v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(121, 21);
            this.v2.TabIndex = 1;
            this.v2.Text = "Páros Számok";
            this.v2.UseVisualStyleBackColor = true;
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.Location = new System.Drawing.Point(8, 23);
            this.v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(73, 21);
            this.v1.TabIndex = 0;
            this.v1.Text = "Prímek";
            this.v1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 554);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.mennyiseg);
            this.Controls.Add(this.mutat);
            this.Controls.Add(this.generalas);
            this.Controls.Add(this.jobbadatsor);
            this.Controls.Add(this.baladatsor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox baladatsor;
        private System.Windows.Forms.ListBox jobbadatsor;
        private System.Windows.Forms.Button generalas;
        private System.Windows.Forms.Button mutat;
        private System.Windows.Forms.Label mennyiseg;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.CheckBox v7;
        private System.Windows.Forms.CheckBox v6;
        private System.Windows.Forms.CheckBox v5;
        private System.Windows.Forms.CheckBox v4;
        private System.Windows.Forms.CheckBox v3;
        private System.Windows.Forms.CheckBox v2;
        private System.Windows.Forms.CheckBox v1;
    }
}

