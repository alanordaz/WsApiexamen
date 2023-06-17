namespace ABC.Vista
{
    partial class DataGrid
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            BtnElimi = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            BtnBuscar = new Button();
            BtnEliminar = new Button();
            BtnAgregar = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnElimi);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(BtnBuscar);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnAgregar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 95);
            panel1.TabIndex = 4;
            // 
            // BtnElimi
            // 
            BtnElimi.Dock = DockStyle.Right;
            BtnElimi.Location = new Point(544, 0);
            BtnElimi.Name = "BtnElimi";
            BtnElimi.Size = new Size(112, 95);
            BtnElimi.TabIndex = 7;
            BtnElimi.Text = "Eliminar";
            BtnElimi.UseVisualStyleBackColor = true;
            BtnElimi.Click += BtnElimi_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(69, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "si";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(202, 25);
            label2.TabIndex = 5;
            label2.Text = "¿Usar Store Procedures?";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(368, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 4;
            label1.Text = "ID Examen";
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtID.Location = new Point(295, 49);
            txtID.Name = "txtID";
            txtID.Size = new Size(238, 31);
            txtID.TabIndex = 3;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Dock = DockStyle.Right;
            BtnBuscar.Location = new Point(656, 0);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(112, 95);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Dock = DockStyle.Right;
            BtnEliminar.Location = new Point(768, 0);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 95);
            BtnEliminar.TabIndex = 1;
            BtnEliminar.Text = "Actualizar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Dock = DockStyle.Right;
            BtnAgregar.Location = new Point(880, 0);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(112, 95);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(885, 0);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 355);
            panel2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Column1 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(992, 355);
            dataGridView2.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Descripcion";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // DataGrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "DataGrid";
            Text = "DataGrid";
            Load += DataGrid_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DataGridView dataGridView2;
        private Button BtnEliminar;
        private Button BtnAgregar;
        private ContextMenuStrip contextMenuStrip1;
        private Button BtnBuscar;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private CheckBox checkBox1;
        private Button BtnElimi;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Column1;
    }
}