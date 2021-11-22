
namespace COIN6
{
    partial class Ticket
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
            this.PanelTicket = new System.Windows.Forms.Panel();
            this.BtnRegresar = new COIN6.Botones();
            this.BtnImprimir = new COIN6.Botones();
            this.tic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.BackColor = System.Drawing.Color.MediumBlue;
            this.Calendario.Location = new System.Drawing.Point(690, 60);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 72;
            this.Calendario.TitleForeColor = System.Drawing.Color.Blue;
            // 
            // PanelTicket
            // 
            this.PanelTicket.BackColor = System.Drawing.Color.White;
            this.PanelTicket.Location = new System.Drawing.Point(35, 60);
            this.PanelTicket.Name = "PanelTicket";
            this.PanelTicket.Size = new System.Drawing.Size(650, 630);
            this.PanelTicket.TabIndex = 71;
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
            this.BtnRegresar.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegresar.Location = new System.Drawing.Point(690, 625);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(265, 65);
            this.BtnRegresar.TabIndex = 70;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.TextColor = System.Drawing.Color.Black;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Blue;
            this.BtnImprimir.BackgroundColor = System.Drawing.Color.Blue;
            this.BtnImprimir.BorderColor = System.Drawing.Color.Transparent;
            this.BtnImprimir.BorderRadius = 30;
            this.BtnImprimir.BorderSize = 0;
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.Black;
            this.BtnImprimir.Location = new System.Drawing.Point(690, 547);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(265, 65);
            this.BtnImprimir.TabIndex = 73;
            this.BtnImprimir.Text = "IMPRIMIR";
            this.BtnImprimir.TextColor = System.Drawing.Color.Black;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // tic
            // 
            this.tic.AutoSize = true;
            this.tic.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic.Location = new System.Drawing.Point(470, 15);
            this.tic.Name = "tic";
            this.tic.Size = new System.Drawing.Size(114, 39);
            this.tic.TabIndex = 81;
            this.tic.Text = "TICKET";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tic);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.PanelTicket);
            this.Controls.Add(this.BtnRegresar);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Panel PanelTicket;
        private Botones BtnRegresar;
        private Botones BtnImprimir;
        private System.Windows.Forms.Label tic;
    }
}