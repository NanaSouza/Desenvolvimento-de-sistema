namespace Aula_widows_forms__12_02
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
            label1 = new Label();
            txt_nome = new TextBox();
            button1 = new Button();
            text = new Button();
            button3 = new Button();
            lista_ecivil = new ComboBox();
            label2 = new Label();
            btn_ecivil = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label3 = new Label();
            btn_check = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Insira seu nome";
            label1.Click += label1_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(12, 44);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(234, 23);
            txt_nome.TabIndex = 1;
            txt_nome.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // text
            // 
            text.BackColor = SystemColors.Highlight;
            text.Location = new Point(252, 43);
            text.Name = "text";
            text.Size = new Size(147, 23);
            text.TabIndex = 3;
            text.Text = "Cadastro Usuario";
            text.UseVisualStyleBackColor = false;
            text.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Pergunta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lista_ecivil
            // 
            lista_ecivil.FormattingEnabled = true;
            lista_ecivil.Location = new Point(12, 124);
            lista_ecivil.Name = "lista_ecivil";
            lista_ecivil.Size = new Size(177, 23);
            lista_ecivil.TabIndex = 5;
            lista_ecivil.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "Estado Civil";
            // 
            // btn_ecivil
            // 
            btn_ecivil.BackColor = SystemColors.MenuHighlight;
            btn_ecivil.Location = new Point(195, 124);
            btn_ecivil.Name = "btn_ecivil";
            btn_ecivil.Size = new Size(75, 23);
            btn_ecivil.TabIndex = 7;
            btn_ecivil.Text = "Enviar";
            btn_ecivil.UseVisualStyleBackColor = false;
            btn_ecivil.Click += btn_ecivil_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 187);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Possui Carro";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 212);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(92, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Possui Moto";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 237);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(128, 19);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Mobilidade Publica";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 11;
            label3.Text = "Marque as Opções";
            // 
            // btn_check
            // 
            btn_check.Location = new Point(27, 262);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(90, 23);
            btn_check.TabIndex = 12;
            btn_check.Text = "Enviar";
            btn_check.UseVisualStyleBackColor = true;
            btn_check.Click += btn_check_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_check);
            Controls.Add(label3);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btn_ecivil);
            Controls.Add(label2);
            Controls.Add(lista_ecivil);
            Controls.Add(button3);
            Controls.Add(text);
            Controls.Add(button1);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nome;
        private Button button1;
        private Button text;
        private Button button3;
        private ComboBox lista_ecivil;
        private Label label2;
        private Button btn_ecivil;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label3;
        private Button btn_check;
    }
}
