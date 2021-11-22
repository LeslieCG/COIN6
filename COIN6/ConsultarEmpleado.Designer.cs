
namespace COIN6
{
    partial class ConsultarEmpleado
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
            this.RegEmp = new System.Windows.Forms.Label();
            this.PanelEmpleados = new System.Windows.Forms.Panel();
            this.BtnTerminar = new COIN6.Botones();
            this.BtnOtraOp = new COIN6.Botones();
            this.SuspendLayout();
            // 
            // RegEmp
            // 
            this.RegEmp.AutoSize = true;
            this.RegEmp.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegEmp.Location = new System.Drawing.Point(307, 15);
            this.RegEmp.Name = "RegEmp";
            this.RegEmp.Size = new System.Drawing.Size(385, 39);
            this.RegEmp.TabIndex = 83;
            this.RegEmp.Text = "REGISTRO DE EMPLEADOS";
            // 
            // PanelEmpleados
            // 
            this.PanelEmpleados.BackColor = System.Drawing.Color.White;
            this.PanelEmpleados.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEmpleados.Location = new System.Drawing.Point(179, 67);
            this.PanelEmpleados.Name = "PanelEmpleados";
            this.PanelEmpleados.Size = new System.Drawing.Size(639, 505);
            this.PanelEmpleados.TabIndex = 82;
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
            this.BtnTerminar.TabIndex = 85;
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
            this.BtnOtraOp.TabIndex = 84;
            this.BtnOtraOp.Text = "OTRA OPERACIÓN";
            this.BtnOtraOp.TextColor = System.Drawing.Color.Black;
            this.BtnOtraOp.UseVisualStyleBackColor = false;
            this.BtnOtraOp.Click += new System.EventHandler(this.BtnOtraOp_Click);
            // 
            // ConsultarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnTerminar);
            this.Controls.Add(this.BtnOtraOp);
            this.Controls.Add(this.RegEmp);
            this.Controls.Add(this.PanelEmpleados);
            this.Name = "ConsultarEmpleado";
            this.Text = "Consultar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RegEmp;
        private System.Windows.Forms.Panel PanelEmpleados;
        private Botones BtnTerminar;
        private Botones BtnOtraOp;
    }
}