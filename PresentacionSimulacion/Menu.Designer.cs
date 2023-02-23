namespace PresentacionSimulacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnSistemaAbierto = new System.Windows.Forms.Button();
            this.btnSistemaCerrado = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fronteras del Sistema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(218, 41);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(246, 49);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Selecciona la opcion:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(666, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.Location = new System.Drawing.Point(57, 168);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(236, 87);
            this.btnSistema.TabIndex = 3;
            this.btnSistema.Text = "Sistema";
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnSistemaAbierto
            // 
            this.btnSistemaAbierto.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistemaAbierto.Location = new System.Drawing.Point(57, 252);
            this.btnSistemaAbierto.Name = "btnSistemaAbierto";
            this.btnSistemaAbierto.Size = new System.Drawing.Size(236, 87);
            this.btnSistemaAbierto.TabIndex = 4;
            this.btnSistemaAbierto.Text = "Sistema Abierto";
            this.btnSistemaAbierto.UseVisualStyleBackColor = true;
            // 
            // btnSistemaCerrado
            // 
            this.btnSistemaCerrado.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistemaCerrado.Location = new System.Drawing.Point(57, 339);
            this.btnSistemaCerrado.Name = "btnSistemaCerrado";
            this.btnSistemaCerrado.Size = new System.Drawing.Size(236, 87);
            this.btnSistemaCerrado.TabIndex = 5;
            this.btnSistemaCerrado.Text = "Sistema Cerrrado";
            this.btnSistemaCerrado.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(311, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 87);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fronteras del Sistema";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(361, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 87);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clonado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSistemaCerrado);
            this.Controls.Add(this.btnSistemaAbierto);
            this.Controls.Add(this.btnSistema);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "3EAWQTRE YR B  ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnSistemaAbierto;
        private System.Windows.Forms.Button btnSistemaCerrado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}