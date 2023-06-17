namespace ABC.Vista
{
    partial class TabAgregar
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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(64, 197);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 31);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(64, 135);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(216, 31);
            txtDescripcion.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(64, 12);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(216, 34);
            BtnAceptar.TabIndex = 2;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(64, 62);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(216, 34);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 107);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 4;
            label1.Text = "Descipcion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 169);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // TabAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 240);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            MaximizeBox = false;
            Name = "TabAgregar";
            Text = "TabAgregar";
            Load += TabAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private Label label1;
        private Label label2;
    }
}