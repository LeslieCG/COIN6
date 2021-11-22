
namespace COIN6
{
    partial class Confirmacion
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
            this.BtnTerminar = new COIN6.Botones();
            this.BtnOtraOp = new COIN6.Botones();
            this.MensajeConfirma = new System.Windows.Forms.Label();
            this.Accion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.BackColor = System.Drawing.Color.Red;
            this.BtnTerminar.BackgroundColor = System.Drawing.Color.Red;
            this.BtnTerminar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnTerminar.BorderRadius = 30;
            this.BtnTerminar.BorderSize = 0;
            this.BtnTerminar.FlatAppearance.BorderSize = 0;
            this.BtnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTerminar.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTerminar.ForeColor = System.Drawing.Color.Black;
            this.BtnTerminar.Location = new System.Drawing.Point(690, 625);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(265, 65);
            this.BtnTerminar.TabIndex = 71;
            this.BtnTerminar.Text = "TERMINAR";
            this.BtnTerminar.TextColor = System.Drawing.Color.Black;
            this.BtnTerminar.UseVisualStyleBackColor = false;
            this.BtnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click);
            // 
            // BtnOtraOp
            // 
            this.BtnOtraOp.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnOtraOp.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.BtnOtraOp.BorderColor = System.Drawing.Color.Transparent;
            this.BtnOtraOp.BorderRadius = 30;
            this.BtnOtraOp.BorderSize = 0;
            this.BtnOtraOp.FlatAppearance.BorderSize = 0;
            this.BtnOtraOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOtraOp.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOtraOp.ForeColor = System.Drawing.Color.Black;
            this.BtnOtraOp.Location = new System.Drawing.Point(410, 625);
            this.BtnOtraOp.Name = "BtnOtraOp";
            this.BtnOtraOp.Size = new System.Drawing.Size(265, 65);
            this.BtnOtraOp.TabIndex = 70;
            this.BtnOtraOp.Text = "OTRA OPERACIÓN";
            this.BtnOtraOp.TextColor = System.Drawing.Color.Black;
            this.BtnOtraOp.UseVisualStyleBackColor = false;
            this.BtnOtraOp.Click += new System.EventHandler(this.BtnOtraOp_Click);
            // 
            // MensajeConfirma
            // 
            this.MensajeConfirma.AutoSize = true;
            this.MensajeConfirma.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeConfirma.Location = new System.Drawing.Point(310, 115);
            this.MensajeConfirma.Name = "MensajeConfirma";
            this.MensajeConfirma.Size = new System.Drawing.Size(369, 36);
            this.MensajeConfirma.TabIndex = 69;
            this.MensajeConfirma.Text = "MENSAJE DE CONFIRMACIÓN";
            // 
            // Accion
            // 
            this.Accion.AutoSize = true;
            this.Accion.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accion.Location = new System.Drawing.Point(335, 15);
            this.Accion.Name = "Accion";
            this.Accion.Size = new System.Drawing.Size(318, 39);
            this.Accion.TabIndex = 68;
            this.Accion.Text = "ACCIÓN A EMPLEADO";
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnTerminar);
            this.Controls.Add(this.BtnOtraOp);
            this.Controls.Add(this.MensajeConfirma);
            this.Controls.Add(this.Accion);
            this.Name = "Confirmacion";
            this.Text = "Confirmación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Botones BtnTerminar;
        private Botones BtnOtraOp;
        private System.Windows.Forms.Label MensajeConfirma;
        private System.Windows.Forms.Label Accion;
    }
}