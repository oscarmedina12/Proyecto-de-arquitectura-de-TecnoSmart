namespace TecnoSmart
{
    partial class IngresoTecnoSmart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoTecnoSmart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdPro = new System.Windows.Forms.Label();
            this.lblIdRep = new System.Windows.Forms.Label();
            this.txt_detalle_problema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_Reparacion = new System.Windows.Forms.ComboBox();
            this.cbox_Producto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_telefono_cliente = new System.Windows.Forms.TextBox();
            this.txt_email_cliente = new System.Windows.Forms.TextBox();
            this.txt_direccion_cliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_apellido_cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Ingresar_Cliente_Reparacion = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblIdPro);
            this.panel1.Controls.Add(this.lblIdRep);
            this.panel1.Controls.Add(this.txt_detalle_problema);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbox_Reparacion);
            this.panel1.Controls.Add(this.cbox_Producto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 310);
            this.panel1.TabIndex = 9;
            // 
            // lblIdPro
            // 
            this.lblIdPro.AutoSize = true;
            this.lblIdPro.BackColor = System.Drawing.Color.Transparent;
            this.lblIdPro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPro.Location = new System.Drawing.Point(374, 40);
            this.lblIdPro.Name = "lblIdPro";
            this.lblIdPro.Size = new System.Drawing.Size(11, 13);
            this.lblIdPro.TabIndex = 17;
            this.lblIdPro.Text = ".";
            this.lblIdPro.Visible = false;
            // 
            // lblIdRep
            // 
            this.lblIdRep.AutoSize = true;
            this.lblIdRep.BackColor = System.Drawing.Color.Transparent;
            this.lblIdRep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRep.Location = new System.Drawing.Point(374, 93);
            this.lblIdRep.Name = "lblIdRep";
            this.lblIdRep.Size = new System.Drawing.Size(11, 13);
            this.lblIdRep.TabIndex = 18;
            this.lblIdRep.Text = ".";
            this.lblIdRep.Visible = false;
            // 
            // txt_detalle_problema
            // 
            this.txt_detalle_problema.Location = new System.Drawing.Point(18, 172);
            this.txt_detalle_problema.Multiline = true;
            this.txt_detalle_problema.Name = "txt_detalle_problema";
            this.txt_detalle_problema.Size = new System.Drawing.Size(340, 120);
            this.txt_detalle_problema.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(14, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Deatelle del Problema:";
            // 
            // cbox_Reparacion
            // 
            this.cbox_Reparacion.FormattingEnabled = true;
            this.cbox_Reparacion.Location = new System.Drawing.Point(127, 85);
            this.cbox_Reparacion.Name = "cbox_Reparacion";
            this.cbox_Reparacion.Size = new System.Drawing.Size(241, 27);
            this.cbox_Reparacion.TabIndex = 9;
            this.cbox_Reparacion.SelectedIndexChanged += new System.EventHandler(this.cbox_Reparacion_SelectedIndexChanged);
            // 
            // cbox_Producto
            // 
            this.cbox_Producto.FormattingEnabled = true;
            this.cbox_Producto.Location = new System.Drawing.Point(127, 32);
            this.cbox_Producto.Name = "cbox_Producto";
            this.cbox_Producto.Size = new System.Drawing.Size(241, 27);
            this.cbox_Producto.TabIndex = 8;
            this.cbox_Producto.SelectedIndexChanged += new System.EventHandler(this.cbox_Producto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reparacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(182, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datos Servicio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_telefono_cliente);
            this.panel2.Controls.Add(this.txt_email_cliente);
            this.panel2.Controls.Add(this.txt_direccion_cliente);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_apellido_cliente);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_nombre_cliente);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(411, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 257);
            this.panel2.TabIndex = 11;
            // 
            // txt_telefono_cliente
            // 
            this.txt_telefono_cliente.Location = new System.Drawing.Point(104, 217);
            this.txt_telefono_cliente.Name = "txt_telefono_cliente";
            this.txt_telefono_cliente.Size = new System.Drawing.Size(201, 27);
            this.txt_telefono_cliente.TabIndex = 18;
            // 
            // txt_email_cliente
            // 
            this.txt_email_cliente.Location = new System.Drawing.Point(104, 176);
            this.txt_email_cliente.Name = "txt_email_cliente";
            this.txt_email_cliente.Size = new System.Drawing.Size(202, 27);
            this.txt_email_cliente.TabIndex = 17;
            // 
            // txt_direccion_cliente
            // 
            this.txt_direccion_cliente.Location = new System.Drawing.Point(104, 139);
            this.txt_direccion_cliente.Name = "txt_direccion_cliente";
            this.txt_direccion_cliente.Size = new System.Drawing.Size(202, 27);
            this.txt_direccion_cliente.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(14, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(14, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(13, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Direccion:";
            // 
            // txt_apellido_cliente
            // 
            this.txt_apellido_cliente.Location = new System.Drawing.Point(104, 62);
            this.txt_apellido_cliente.Name = "txt_apellido_cliente";
            this.txt_apellido_cliente.Size = new System.Drawing.Size(202, 27);
            this.txt_apellido_cliente.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(14, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellido:";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Location = new System.Drawing.Point(104, 19);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(202, 27);
            this.txt_nombre_cliente.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(561, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Datos Cliente";
            // 
            // btn_Ingresar_Cliente_Reparacion
            // 
            this.btn_Ingresar_Cliente_Reparacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar_Cliente_Reparacion.Location = new System.Drawing.Point(550, 364);
            this.btn_Ingresar_Cliente_Reparacion.Name = "btn_Ingresar_Cliente_Reparacion";
            this.btn_Ingresar_Cliente_Reparacion.Size = new System.Drawing.Size(106, 31);
            this.btn_Ingresar_Cliente_Reparacion.TabIndex = 13;
            this.btn_Ingresar_Cliente_Reparacion.Text = "INGRESAR";
            this.btn_Ingresar_Cliente_Reparacion.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(520, 397);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(24, 19);
            this.lblMensaje.TabIndex = 16;
            this.lblMensaje.Text = "...";
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(619, 24);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(98, 30);
            this.btn_menu.TabIndex = 17;
            this.btn_menu.Text = "Ir a Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(274, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Registro TecnoSmart";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(14, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Rut:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 27);
            this.textBox1.TabIndex = 20;
            // 
            // IngresoTecnoSmart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 430);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btn_Ingresar_Cliente_Reparacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "IngresoTecnoSmart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_detalle_problema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_Reparacion;
        private System.Windows.Forms.ComboBox cbox_Producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_telefono_cliente;
        private System.Windows.Forms.TextBox txt_email_cliente;
        private System.Windows.Forms.TextBox txt_direccion_cliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_apellido_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Ingresar_Cliente_Reparacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblIdPro;
        private System.Windows.Forms.Label lblIdRep;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;

    }
}