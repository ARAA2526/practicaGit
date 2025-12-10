namespace ejercicioTelegrama
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
            txtTelegrama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            btnCalcularPrecio = new Button();
            rdiOrdinario = new RadioButton();
            rdiUrgente = new RadioButton();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(32, 49);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(416, 124);
            txtTelegrama.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Texto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 249);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(93, 247);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(214, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(326, 234);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(122, 36);
            btnCalcularPrecio.TabIndex = 5;
            btnCalcularPrecio.Text = "Calcular";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // rdiOrdinario
            // 
            rdiOrdinario.AutoSize = true;
            rdiOrdinario.Checked = true;
            rdiOrdinario.Location = new Point(34, 201);
            rdiOrdinario.Name = "rdiOrdinario";
            rdiOrdinario.Size = new Size(75, 19);
            rdiOrdinario.TabIndex = 6;
            rdiOrdinario.TabStop = true;
            rdiOrdinario.Text = "Ordinario";
            rdiOrdinario.UseVisualStyleBackColor = true;
            // 
            // rdiUrgente
            // 
            rdiUrgente.AutoSize = true;
            rdiUrgente.Location = new Point(128, 201);
            rdiUrgente.Name = "rdiUrgente";
            rdiUrgente.Size = new Size(67, 19);
            rdiUrgente.TabIndex = 7;
            rdiUrgente.Text = "Urgente";
            rdiUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 303);
            Controls.Add(rdiUrgente);
            Controls.Add(rdiOrdinario);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelegrama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private Label label1;
        private Label label2;
        private TextBox txtPrecio;
        private Button btnCalcularPrecio;
        private RadioButton rdiOrdinario;
        private RadioButton rdiUrgente;
    }
}
