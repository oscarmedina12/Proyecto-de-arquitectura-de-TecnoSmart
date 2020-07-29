namespace TecnoSmart
{
    partial class Menu
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
            this.btn_agregar_nuevo_servicio = new System.Windows.Forms.Button();
            this.btn_form_actualiza_entregaServicio = new System.Windows.Forms.Button();
            this.btn_form_lista_clienteServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregar_nuevo_servicio
            // 
            this.btn_agregar_nuevo_servicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_nuevo_servicio.Location = new System.Drawing.Point(123, 220);
            this.btn_agregar_nuevo_servicio.Name = "btn_agregar_nuevo_servicio";
            this.btn_agregar_nuevo_servicio.Size = new System.Drawing.Size(213, 38);
            this.btn_agregar_nuevo_servicio.TabIndex = 20;
            this.btn_agregar_nuevo_servicio.Text = "Agregar Nuevo Servicio";
            this.btn_agregar_nuevo_servicio.UseVisualStyleBackColor = true;
            this.btn_agregar_nuevo_servicio.Click += new System.EventHandler(this.btn_agregar_nuevo_servicio_Click);
            // 
            // btn_form_actualiza_entregaServicio
            // 
            this.btn_form_actualiza_entregaServicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_form_actualiza_entregaServicio.Location = new System.Drawing.Point(83, 132);
            this.btn_form_actualiza_entregaServicio.Name = "btn_form_actualiza_entregaServicio";
            this.btn_form_actualiza_entregaServicio.Size = new System.Drawing.Size(287, 38);
            this.btn_form_actualiza_entregaServicio.TabIndex = 19;
            this.btn_form_actualiza_entregaServicio.Text = "Actualizar Entregas de Servicio";
            this.btn_form_actualiza_entregaServicio.UseVisualStyleBackColor = true;
            this.btn_form_actualiza_entregaServicio.Click += new System.EventHandler(this.btn_form_actualiza_entregaServicio_Click);
            // 
            // btn_form_lista_clienteServicio
            // 
            this.btn_form_lista_clienteServicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_form_lista_clienteServicio.Location = new System.Drawing.Point(126, 40);
            this.btn_form_lista_clienteServicio.Name = "btn_form_lista_clienteServicio";
            this.btn_form_lista_clienteServicio.Size = new System.Drawing.Size(210, 38);
            this.btn_form_lista_clienteServicio.TabIndex = 18;
            this.btn_form_lista_clienteServicio.Text = "Ver Clientes y Servicios";
            this.btn_form_lista_clienteServicio.UseVisualStyleBackColor = true;
            this.btn_form_lista_clienteServicio.Click += new System.EventHandler(this.btn_form_lista_clienteServicio_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 305);
            this.Controls.Add(this.btn_agregar_nuevo_servicio);
            this.Controls.Add(this.btn_form_actualiza_entregaServicio);
            this.Controls.Add(this.btn_form_lista_clienteServicio);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar_nuevo_servicio;
        private System.Windows.Forms.Button btn_form_actualiza_entregaServicio;
        private System.Windows.Forms.Button btn_form_lista_clienteServicio;
    }
}