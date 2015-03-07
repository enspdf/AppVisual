namespace AplicacionEncuestas
{
    partial class PreguntasLibre
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtRpta1 = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtRpta2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRpta3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRpta4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.Location = new System.Drawing.Point(12, 10);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(487, 29);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "¿Que ha tenido en cuenta a la hora de hablar de seguridad en el desarrollo, despi" +
    "egue y diseño de sus aplicaciones?";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRpta1
            // 
            this.txtRpta1.Location = new System.Drawing.Point(12, 42);
            this.txtRpta1.Multiline = true;
            this.txtRpta1.Name = "txtRpta1";
            this.txtRpta1.Size = new System.Drawing.Size(487, 47);
            this.txtRpta1.TabIndex = 1;
            this.txtRpta1.TextChanged += new System.EventHandler(this.txtRpta1_TextChanged);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(179, 379);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 20;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(260, 379);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtRpta2
            // 
            this.txtRpta2.Location = new System.Drawing.Point(12, 133);
            this.txtRpta2.Multiline = true;
            this.txtRpta2.Name = "txtRpta2";
            this.txtRpta2.Size = new System.Drawing.Size(487, 47);
            this.txtRpta2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "¿Ha tenido fugas de información? ¿cual cree usted que ha sido la causa, sustente " +
    "el motivo por el cual ha sucedido esto?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRpta3
            // 
            this.txtRpta3.Location = new System.Drawing.Point(12, 227);
            this.txtRpta3.Multiline = true;
            this.txtRpta3.Name = "txtRpta3";
            this.txtRpta3.Size = new System.Drawing.Size(487, 47);
            this.txtRpta3.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "¿En su trabajo o desarrollos ha pensado en la seguridad de la información y en la" +
    " posible fuga de datos? ¿Explique que ha implementado?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRpta4
            // 
            this.txtRpta4.Location = new System.Drawing.Point(12, 322);
            this.txtRpta4.Multiline = true;
            this.txtRpta4.Name = "txtRpta4";
            this.txtRpta4.Size = new System.Drawing.Size(487, 47);
            this.txtRpta4.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "¿Como realiza usted la correcta conexión y petición de datos, de una forma que cu" +
    "mpla con politicas en algun caso de un ataque?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PreguntasLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 411);
            this.Controls.Add(this.txtRpta4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRpta3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRpta2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtRpta1);
            this.Controls.Add(this.lblPregunta);
            this.Name = "PreguntasLibre";
            this.Text = "Sección 3";
            this.Load += new System.EventHandler(this.PreguntasLibre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.TextBox txtRpta1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtRpta2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRpta3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRpta4;
        private System.Windows.Forms.Label label4;
    }
}