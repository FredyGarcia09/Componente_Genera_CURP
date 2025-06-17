namespace FormularioCurp
{
    partial class ControlDeCURP
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            cbEntidadF = new ComboBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            cbSexo = new ComboBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            txtFechaNac = new TextBox();
            lblFechaNac = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            txtApellidoM = new TextBox();
            lblApellidoM = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txtApellidoP = new TextBox();
            lblApellidoP = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtNombre = new TextBox();
            lblNombre = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            lblCURP = new Label();
            txtDigitosDiferenciales = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel6, 1, 5);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel5, 1, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 1, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel7, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(4);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.Size = new Size(650, 420);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(7, 346);
            label7.Name = "label7";
            label7.Size = new Size(218, 70);
            label7.TabIndex = 12;
            label7.Text = "CURP:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(cbEntidadF);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(231, 291);
            flowLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(412, 53);
            flowLayoutPanel6.TabIndex = 11;
            flowLayoutPanel6.WrapContents = false;
            // 
            // cbEntidadF
            // 
            cbEntidadF.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEntidadF.FormattingEnabled = true;
            cbEntidadF.Items.AddRange(new object[] { "Zacatecas", "Yucatán", "Veracruz ", "Tlaxcala", "Tamaulipas", "Tabasco", "Sonora", "Sinaloa", "San Luis Potosí", "Querétaro", "Puebla", "Oaxaca", "Nuevo León", "Nayarit", "Morelos", "Michoacán de Ocampo", "México", "Jalisco", "Hidalgo", "Guerrero", "Guanajuato", "Durango", "Ciudad de México (CDMX)", "Chihuahua", "Chiapas", "Colima", "Coahuila de Zaragoza", "Campeche", "Baja California Sur", "Baja California", "Aguascalientes", "Nacido en el Extranjero" });
            cbEntidadF.Location = new Point(3, 2);
            cbEntidadF.Margin = new Padding(3, 2, 3, 2);
            cbEntidadF.Name = "cbEntidadF";
            cbEntidadF.Size = new Size(260, 23);
            cbEntidadF.TabIndex = 0;
            cbEntidadF.SelectedIndexChanged += cbEntidadF_SelectedIndexChanged;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(cbSexo);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(231, 234);
            flowLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(412, 53);
            flowLayoutPanel5.TabIndex = 10;
            flowLayoutPanel5.WrapContents = false;
            // 
            // cbSexo
            // 
            cbSexo.Anchor = AnchorStyles.None;
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cbSexo.Location = new Point(3, 2);
            cbSexo.Margin = new Padding(3, 2, 3, 2);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(260, 23);
            cbSexo.TabIndex = 0;
            cbSexo.SelectedIndexChanged += cbSexo_SelectedIndexChanged;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(txtFechaNac);
            flowLayoutPanel4.Controls.Add(lblFechaNac);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(231, 177);
            flowLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(412, 53);
            flowLayoutPanel4.TabIndex = 9;
            flowLayoutPanel4.WrapContents = false;
            // 
            // txtFechaNac
            // 
            txtFechaNac.Anchor = AnchorStyles.None;
            txtFechaNac.Location = new Point(3, 2);
            txtFechaNac.Margin = new Padding(3, 2, 3, 2);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(260, 23);
            txtFechaNac.TabIndex = 0;
            txtFechaNac.Text = "Ej. 14/05/2001";
            txtFechaNac.MouseClick += SeleccionarTodo_MouseClick;
            txtFechaNac.TextChanged += txtFechaNac_TextChanged;
            txtFechaNac.Enter += SeleccionarTodo_Enter;
            // 
            // lblFechaNac
            // 
            lblFechaNac.Anchor = AnchorStyles.None;
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(133, 27);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(0, 15);
            lblFechaNac.TabIndex = 1;
            lblFechaNac.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(txtApellidoM);
            flowLayoutPanel3.Controls.Add(lblApellidoM);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(231, 120);
            flowLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(412, 53);
            flowLayoutPanel3.TabIndex = 8;
            flowLayoutPanel3.WrapContents = false;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Anchor = AnchorStyles.None;
            txtApellidoM.Location = new Point(3, 2);
            txtApellidoM.Margin = new Padding(3, 2, 3, 2);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(260, 23);
            txtApellidoM.TabIndex = 0;
            txtApellidoM.Text = "Ej. Calderon";
            txtApellidoM.MouseClick += SeleccionarTodo_MouseClick;
            txtApellidoM.TextChanged += txtApellidoM_TextChanged;
            txtApellidoM.Enter += SeleccionarTodo_Enter;
            // 
            // lblApellidoM
            // 
            lblApellidoM.Anchor = AnchorStyles.None;
            lblApellidoM.AutoSize = true;
            lblApellidoM.Location = new Point(133, 27);
            lblApellidoM.Name = "lblApellidoM";
            lblApellidoM.Size = new Size(0, 15);
            lblApellidoM.TabIndex = 1;
            lblApellidoM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(txtApellidoP);
            flowLayoutPanel2.Controls.Add(lblApellidoP);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(231, 63);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(412, 53);
            flowLayoutPanel2.TabIndex = 7;
            flowLayoutPanel2.WrapContents = false;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Anchor = AnchorStyles.None;
            txtApellidoP.Location = new Point(3, 2);
            txtApellidoP.Margin = new Padding(3, 2, 3, 2);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(260, 23);
            txtApellidoP.TabIndex = 0;
            txtApellidoP.Text = "Ej. Gonzales";
            txtApellidoP.MouseClick += SeleccionarTodo_MouseClick;
            txtApellidoP.TextChanged += txtApellidoP_TextChanged;
            txtApellidoP.Enter += SeleccionarTodo_Enter;
            // 
            // lblApellidoP
            // 
            lblApellidoP.Anchor = AnchorStyles.None;
            lblApellidoP.AutoSize = true;
            lblApellidoP.Location = new Point(133, 27);
            lblApellidoP.Name = "lblApellidoP";
            lblApellidoP.Size = new Size(0, 15);
            lblApellidoP.TabIndex = 1;
            lblApellidoP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(218, 57);
            label1.TabIndex = 0;
            label1.Text = "Nombre(s):";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(7, 61);
            label2.Name = "label2";
            label2.Size = new Size(218, 57);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(7, 118);
            label3.Name = "label3";
            label3.Size = new Size(218, 57);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(7, 175);
            label4.Name = "label4";
            label4.Size = new Size(218, 57);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(7, 232);
            label5.Name = "label5";
            label5.Size = new Size(218, 57);
            label5.TabIndex = 4;
            label5.Text = "Sexo:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(7, 289);
            label6.Name = "label6";
            label6.Size = new Size(218, 57);
            label6.TabIndex = 5;
            label6.Text = "Entidad Federativa:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(txtNombre);
            flowLayoutPanel1.Controls.Add(lblNombre);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(231, 6);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 53);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.WrapContents = false;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(3, 2);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Ej. Bartolome";
            txtNombre.MouseClick += SeleccionarTodo_MouseClick;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Enter += SeleccionarTodo_Enter;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(133, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 1;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.Controls.Add(lblCURP);
            flowLayoutPanel7.Controls.Add(txtDigitosDiferenciales);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.Location = new Point(231, 349);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(5);
            flowLayoutPanel7.Size = new Size(412, 64);
            flowLayoutPanel7.TabIndex = 13;
            // 
            // lblCURP
            // 
            lblCURP.AutoSize = true;
            lblCURP.Font = new Font("Segoe UI", 10F);
            lblCURP.Location = new Point(8, 5);
            lblCURP.Name = "lblCURP";
            lblCURP.Size = new Size(287, 19);
            lblCURP.TabIndex = 1;
            lblCURP.Text = "Llena los datos para generar una CURP valida";
            lblCURP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDigitosDiferenciales
            // 
            txtDigitosDiferenciales.Location = new Point(301, 8);
            txtDigitosDiferenciales.MaxLength = 2;
            txtDigitosDiferenciales.Name = "txtDigitosDiferenciales";
            txtDigitosDiferenciales.Size = new Size(65, 23);
            txtDigitosDiferenciales.TabIndex = 0;
            txtDigitosDiferenciales.TextChanged += txtDigitosDiferenciales_TextChanged;
            // 
            // ControlDeCURP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(630, 420);
            Name = "ControlDeCURP";
            Size = new Size(650, 420);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtNombre;
        private Label lblNombre;
        private FlowLayoutPanel flowLayoutPanel4;
        private TextBox txtFechaNac;
        private Label lblFechaNac;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox txtApellidoM;
        private Label lblApellidoM;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox txtApellidoP;
        private Label lblApellidoP;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel5;
        private ComboBox cbSexo;
        private ComboBox cbEntidadF;
        private Label label7;
        private Label lblCURP;
        private FlowLayoutPanel flowLayoutPanel7;
        private TextBox txtDigitosDiferenciales;
    }
}
