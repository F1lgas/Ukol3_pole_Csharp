namespace Ukol3_pole_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vstup = new System.Windows.Forms.TextBox();
            this.vystup = new System.Windows.Forms.TextBox();
            this.zmena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vstup
            // 
            this.vstup.Location = new System.Drawing.Point(13, 13);
            this.vstup.Name = "vstup";
            this.vstup.Size = new System.Drawing.Size(100, 20);
            this.vstup.TabIndex = 0;
            // 
            // vystup
            // 
            this.vystup.Location = new System.Drawing.Point(13, 39);
            this.vystup.Name = "vystup";
            this.vystup.ReadOnly = true;
            this.vystup.Size = new System.Drawing.Size(100, 20);
            this.vystup.TabIndex = 1;
            // 
            // zmena
            // 
            this.zmena.Location = new System.Drawing.Point(119, 24);
            this.zmena.Name = "zmena";
            this.zmena.Size = new System.Drawing.Size(75, 23);
            this.zmena.TabIndex = 2;
            this.zmena.Text = "Změna";
            this.zmena.UseVisualStyleBackColor = true;
            this.zmena.Click += new System.EventHandler(this.zmena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 72);
            this.Controls.Add(this.zmena);
            this.Controls.Add(this.vystup);
            this.Controls.Add(this.vstup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Úkol 3 pole C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vstup;
        private System.Windows.Forms.TextBox vystup;
        private System.Windows.Forms.Button zmena;
    }
}

