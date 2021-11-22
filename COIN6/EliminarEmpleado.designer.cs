
namespace COIN6
{
    partial class EliminarEmpleado
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
            this.labelID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.EliminaEmp = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new COIN6.Botones();
            this.BtnEliminar = new COIN6.Botones();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(80, 89);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 36);
            this.labelID.TabIndex = 83;
            this.labelID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(533, 85);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(422, 40);
            this.txtID.TabIndex = 82;
            // 
            // EliminaEmp
            // 
            this.EliminaEmp.AutoSize = true;
            this.EliminaEmp.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminaEmp.Location = new System.Drawing.Point(335, 15);
            this.EliminaEmp.Name = "EliminaEmp";
            this.EliminaEmp.Size = new System.Drawing.Size(322, 39);
            this.EliminaEmp.TabIndex = 81;
            this.EliminaEmp.Text = "ELIMINAR EMPLEADO";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(80, 176);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(125, 36);
            this.labelNombre.TabIndex = 85;
            this.labelNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(533, 172);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(422, 40);
            this.txtNombre.TabIndex = 84;
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
            this.BtnRegresar.TabIndex = 87;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.TextColor = System.Drawing.Color.Black;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Yellow;
            this.BtnEliminar.BackgroundColor = System.Drawing.Color.Yellow;
            this.BtnEliminar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BorderRadius = 30;
            this.BtnEliminar.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(410, 625);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(265, 65);
            this.BtnEliminar.TabIndex = 86;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextColor = System.Drawing.Color.Black;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // EliminarEmpleado
            // 
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.EliminaEmp);
            this.Name = "EliminarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label EliminaEmp;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private Botones BtnRegresar;
        private Botones BtnEliminar;
    }
}