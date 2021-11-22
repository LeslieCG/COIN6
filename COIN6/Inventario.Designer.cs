
namespace COIN6
{
    partial class Inventario
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
            this.inventa = new System.Windows.Forms.Label();
            this.BtnRegresar = new COIN6.Botones();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.PanelInventario = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // inventa
            // 
            this.inventa.AutoSize = true;
            this.inventa.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventa.Location = new System.Drawing.Point(330, 9);
            this.inventa.Name = "inventa";
            this.inventa.Size = new System.Drawing.Size(189, 39);
            this.inventa.TabIndex = 80;
            this.inventa.Text = "INVENTARIO";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Red;
            this.BtnRegresar.BackgroundColor = System.Drawing.Color.Red;
            this.BtnRegresar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.BorderRadius = 30;
            this.BtnRegresar.BorderSize = 0;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegresar.Location = new System.Drawing.Point(690, 625);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(265, 65);
            this.BtnRegresar.TabIndex = 85;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.TextColor = System.Drawing.Color.Black;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Calendario
            // 
            this.Calendario.BackColor = System.Drawing.Color.MediumBlue;
            this.Calendario.Location = new System.Drawing.Point(690, 60);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 84;
            this.Calendario.TitleForeColor = System.Drawing.Color.Blue;
            // 
            // PanelInventario
            // 
            this.PanelInventario.BackColor = System.Drawing.Color.White;
            this.PanelInventario.Location = new System.Drawing.Point(35, 60);
            this.PanelInventario.Name = "PanelInventario";
            this.PanelInventario.Size = new System.Drawing.Size(650, 630);
            this.PanelInventario.TabIndex = 83;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.PanelInventario);
            this.Controls.Add(this.inventa);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inventa;
        private Botones BtnRegresar;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Panel PanelInventario;
    }
}