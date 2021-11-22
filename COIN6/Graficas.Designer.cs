
namespace COIN6
{
    partial class Graficas
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
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.PanelGrafica = new System.Windows.Forms.Panel();
            this.grafi = new System.Windows.Forms.Label();
            this.BtnRegresar = new COIN6.Botones();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.BackColor = System.Drawing.Color.MediumBlue;
            this.Calendario.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario.Location = new System.Drawing.Point(690, 60);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 68;
            this.Calendario.TitleForeColor = System.Drawing.Color.Blue;
            // 
            // PanelGrafica
            // 
            this.PanelGrafica.BackColor = System.Drawing.Color.White;
            this.PanelGrafica.Location = new System.Drawing.Point(35, 60);
            this.PanelGrafica.Name = "PanelGrafica";
            this.PanelGrafica.Size = new System.Drawing.Size(650, 630);
            this.PanelGrafica.TabIndex = 67;
            this.PanelGrafica.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGrafica_Paint);
            // 
            // grafi
            // 
            this.grafi.AutoSize = true;
            this.grafi.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grafi.Location = new System.Drawing.Point(430, 15);
            this.grafi.Name = "grafi";
            this.grafi.Size = new System.Drawing.Size(156, 39);
            this.grafi.TabIndex = 81;
            this.grafi.Text = "GRÁFICAS";
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
            this.BtnRegresar.TabIndex = 82;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.TextColor = System.Drawing.Color.Black;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.grafi);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.PanelGrafica);
            this.Name = "Graficas";
            this.Text = "Gráficas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Panel PanelGrafica;
        private System.Windows.Forms.Label grafi;
        private Botones BtnRegresar;
    }
}