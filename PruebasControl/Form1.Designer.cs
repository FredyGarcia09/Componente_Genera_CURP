namespace PruebasControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            miControlCURP = new FormularioCurp.ControlDeCURP();
            lblCurpGenerada = new Label();
            btnReestablecer = new Button();
            SuspendLayout();
            // 
            // miControlCURP
            // 
            miControlCURP.Location = new Point(12, 11);
            miControlCURP.Margin = new Padding(3, 2, 3, 2);
            miControlCURP.MinimumSize = new Size(685, 420);
            miControlCURP.Name = "miControlCURP";
            miControlCURP.Size = new Size(685, 420);
            miControlCURP.TabIndex = 0;
            miControlCURP.CurpGenerada += miControlCURP_CurpGenerada;
            // 
            // lblCurpGenerada
            // 
            lblCurpGenerada.AutoSize = true;
            lblCurpGenerada.Font = new Font("Segoe UI", 13F);
            lblCurpGenerada.Location = new Point(113, 508);
            lblCurpGenerada.Name = "lblCurpGenerada";
            lblCurpGenerada.Size = new Size(246, 25);
            lblCurpGenerada.TabIndex = 2;
            lblCurpGenerada.Text = "No se ha generado una CURP";
            // 
            // btnReestablecer
            // 
            btnReestablecer.Location = new Point(534, 494);
            btnReestablecer.Name = "btnReestablecer";
            btnReestablecer.Size = new Size(72, 54);
            btnReestablecer.TabIndex = 3;
            btnReestablecer.Text = "Reiniciar valores";
            btnReestablecer.UseVisualStyleBackColor = true;
            btnReestablecer.Click += btnReestablecer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 636);
            Controls.Add(btnReestablecer);
            Controls.Add(lblCurpGenerada);
            Controls.Add(miControlCURP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FormularioCurp.ControlDeCURP miControlCURP;
        private Label lblCurpGenerada;
        private Button btnReestablecer;
    }
}
