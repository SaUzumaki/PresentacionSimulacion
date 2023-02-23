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
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnSistema.Location = new System.Drawing.Point(57, 126);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(236, 87);
            this.btnSistema.TabIndex = 3;
            this.btnSistema.Text = "Sistema";
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSistema);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOpciones);
            this.Name = "Menu";
            this.Text = "3EAWQTRE YR B  ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSistema;
    }
}