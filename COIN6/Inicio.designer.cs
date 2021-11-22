
namespace COIN6
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogoSistema = new System.Windows.Forms.PictureBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoSistema
            // 
            this.LogoSistema.Image = global::COIN6.Properties.Resources.COIN6;
            this.LogoSistema.Location = new System.Drawing.Point(256, 160);
            this.LogoSistema.Name = "LogoSistema";
            this.LogoSistema.Size = new System.Drawing.Size(512, 384);
            this.LogoSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoSistema.TabIndex = 1;
            this.LogoSistema.TabStop = false;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.Black;
            this.BtnIniciar.Location = new System.Drawing.Point(-3, -4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(1015, 737);
            this.BtnIniciar.TabIndex = 2;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.LogoSistema);
            this.Controls.Add(this.BtnIniciar);
            this.Name = "Inicio";
            this.Text = "COIN6";
            ((System.ComponentModel.ISupportInitialize)(this.LogoSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoSistema;
        private System.Windows.Forms.Button BtnIniciar;
    }
}

