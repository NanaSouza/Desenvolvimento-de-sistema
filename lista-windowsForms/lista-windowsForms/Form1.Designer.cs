namespace lista_windowsForms
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
            txt_nome = new TextBox();
            btn_ad = new Button();
            lista_nomes = new ListBox();
            btn_rem = new Button();
            SuspendLayout();
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(101, 34);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 0;
            // 
            // btn_ad
            // 
            btn_ad.Location = new Point(115, 63);
            btn_ad.Name = "btn_ad";
            btn_ad.Size = new Size(75, 23);
            btn_ad.TabIndex = 1;
            btn_ad.Text = "Adicionar Nome";
            btn_ad.UseVisualStyleBackColor = true;
            btn_ad.Click += btn_ad_Click;
            // 
            // lista_nomes
            // 
            lista_nomes.FormattingEnabled = true;
            lista_nomes.ItemHeight = 15;
            lista_nomes.Location = new Point(91, 92);
            lista_nomes.Name = "lista_nomes";
            lista_nomes.Size = new Size(120, 94);
            lista_nomes.TabIndex = 2;
            // 
            // btn_rem
            // 
            btn_rem.Location = new Point(115, 192);
            btn_rem.Name = "btn_rem";
            btn_rem.RightToLeft = RightToLeft.No;
            btn_rem.Size = new Size(75, 23);
            btn_rem.TabIndex = 3;
            btn_rem.Text = "Remover Nome";
            btn_rem.UseVisualStyleBackColor = true;
            btn_rem.Click += btn_rem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 298);
            Controls.Add(btn_rem);
            Controls.Add(lista_nomes);
            Controls.Add(btn_ad);
            Controls.Add(txt_nome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nome;
        private Button btn_ad;
        private ListBox lista_nomes;
        private Button btn_rem;
    }
}
