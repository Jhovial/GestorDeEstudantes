namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
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
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelMeninos.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(387, 12);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(380, 201);
            this.panelMeninos.TabIndex = 0;
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.Location = new System.Drawing.Point(74, 79);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(236, 39);
            this.labelMeninos.TabIndex = 1;
            this.labelMeninos.Text = "Meninos: 50%";
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.HotPink;
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(387, 229);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(380, 209);
            this.panelMeninas.TabIndex = 1;
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(77, 85);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(226, 39);
            this.labelMeninas.TabIndex = 1;
            this.labelMeninas.Text = "Meninas 50%";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Brown;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(12, 12);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(369, 426);
            this.panelTotal.TabIndex = 1;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(11, 187);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(353, 33);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total de Estudantes: 9999";
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(778, 485);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelMeninos);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Label labelMeninas;
    }
}