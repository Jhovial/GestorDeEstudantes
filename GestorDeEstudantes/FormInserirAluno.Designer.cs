namespace GestorDeEstudantes
{
    partial class FormInserirAluno
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelGênero = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonOutro = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(187, 22);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 30);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged_1);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.Location = new System.Drawing.Point(187, 70);
            this.textBoxSobrenome.Multiline = true;
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.PasswordChar = '0';
            this.textBoxSobrenome.Size = new System.Drawing.Size(237, 30);
            this.textBoxSobrenome.TabIndex = 7;
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobrenome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSobrenome.Location = new System.Drawing.Point(61, 70);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(114, 26);
            this.labelSobrenome.TabIndex = 6;
            this.labelSobrenome.Text = "Sobrenome";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.SystemColors.Control;
            this.labelNome.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNome.Location = new System.Drawing.Point(63, 25);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(66, 26);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNascimento.Location = new System.Drawing.Point(61, 112);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(120, 26);
            this.labelNascimento.TabIndex = 9;
            this.labelNascimento.Text = "Nascimento";
            this.labelNascimento.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelGênero
            // 
            this.labelGênero.AutoSize = true;
            this.labelGênero.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGênero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGênero.Location = new System.Drawing.Point(61, 163);
            this.labelGênero.Name = "labelGênero";
            this.labelGênero.Size = new System.Drawing.Size(77, 26);
            this.labelGênero.TabIndex = 10;
            this.labelGênero.Text = "Gênero";
            // 
            // Nascimento
            // 
            this.Nascimento.Location = new System.Drawing.Point(187, 116);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(237, 20);
            this.Nascimento.TabIndex = 11;
            this.Nascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOutro);
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Location = new System.Drawing.Point(187, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 45);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(164, 19);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(57, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(58, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Endereço";
            // 
            // radioButtonOutro
            // 
            this.radioButtonOutro.AutoSize = true;
            this.radioButtonOutro.Location = new System.Drawing.Point(96, 19);
            this.radioButtonOutro.Name = "radioButtonOutro";
            this.radioButtonOutro.Size = new System.Drawing.Size(51, 17);
            this.radioButtonOutro.TabIndex = 2;
            this.radioButtonOutro.TabStop = true;
            this.radioButtonOutro.Text = "Outro";
            this.radioButtonOutro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(82, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Foto";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(187, 211);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(187, 250);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 60);
            this.textBox2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(187, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 219);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Enviar Foto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 621);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 49);
            this.button3.TabIndex = 21;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormInserirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 682);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.labelGênero);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.labelNome);
            this.Name = "FormInserirAluno";
            this.Text = "FormInserirAluno";
            this.Load += new System.EventHandler(this.FormInserirAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelGênero;
        private System.Windows.Forms.DateTimePicker Nascimento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonOutro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}