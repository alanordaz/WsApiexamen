namespace ABC.Vista
{
    partial class TabEditar
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
            label2 = new Label();
            label1 = new Label();
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            LbID = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 204);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 142);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 10;
            label1.Text = "Descipcion";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(25, 97);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(216, 34);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(25, 47);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(216, 34);
            BtnAceptar.TabIndex = 8;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(25, 170);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(216, 31);
            txtDescripcion.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 232);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 31);
            txtNombre.TabIndex = 6;
            // 
            // LbID
            // 
            LbID.AutoSize = true;
            LbID.Location = new Point(94, 9);
            LbID.Name = "LbID";
            LbID.Size = new Size(0, 25);
            LbID.TabIndex = 12;
            // 
            // TabEditar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 306);
            Controls.Add(LbID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Name = "TabEditar";
            Text = "TabEditar";
            Load += TabEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button BtnCancelar;
        private Button BtnAceptar;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label LbID;
    }
}