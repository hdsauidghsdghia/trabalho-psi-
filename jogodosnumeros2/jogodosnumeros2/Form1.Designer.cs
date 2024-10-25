namespace jogodosnumeros2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jogador2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Jogador1 = new System.Windows.Forms.Label();
            this.botaoJogar1 = new System.Windows.Forms.Button();
            this.botaoJogar2 = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.lblVitoriasJogador1 = new System.Windows.Forms.Label();
            this.lblVitoriasJogador2 = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Jogador2
            // 
            this.Jogador2.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Italic);
            this.Jogador2.ForeColor = System.Drawing.Color.Indigo;
            this.Jogador2.Location = new System.Drawing.Point(620, 123);
            this.Jogador2.Name = "Jogador2";
            this.Jogador2.Size = new System.Drawing.Size(156, 50);
            this.Jogador2.TabIndex = 23;
            this.Jogador2.Text = "Jogador 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 54);
            this.label1.TabIndex = 21;
            this.label1.Text = "Jogo dos números";
            // 
            // Jogador1
            // 
            this.Jogador1.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Italic);
            this.Jogador1.ForeColor = System.Drawing.Color.Indigo;
            this.Jogador1.Location = new System.Drawing.Point(48, 123);
            this.Jogador1.Name = "Jogador1";
            this.Jogador1.Size = new System.Drawing.Size(156, 50);
            this.Jogador1.TabIndex = 13;
            this.Jogador1.Text = "Jogador 1";
            // 
            // botaoJogar1
            // 
            this.botaoJogar1.Location = new System.Drawing.Point(8, 4);
            this.botaoJogar1.Name = "botaoJogar1";
            this.botaoJogar1.Size = new System.Drawing.Size(100, 30);
            this.botaoJogar1.TabIndex = 15;
            this.botaoJogar1.Text = "Jogar 1";
            // 
            // botaoJogar2
            // 
            this.botaoJogar2.Location = new System.Drawing.Point(104, 4);
            this.botaoJogar2.Name = "botaoJogar2";
            this.botaoJogar2.Size = new System.Drawing.Size(100, 30);
            this.botaoJogar2.TabIndex = 16;
            this.botaoJogar2.Text = "Jogar 2";
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(201, 4);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(100, 30);
            this.botaoSair.TabIndex = 17;
            this.botaoSair.Text = "Sair";
            // 
            // lblVitoriasJogador1
            // 
            this.lblVitoriasJogador1.AutoSize = true;
            this.lblVitoriasJogador1.Location = new System.Drawing.Point(17, 434);
            this.lblVitoriasJogador1.Name = "lblVitoriasJogador1";
            this.lblVitoriasJogador1.Size = new System.Drawing.Size(103, 13);
            this.lblVitoriasJogador1.TabIndex = 18;
            this.lblVitoriasJogador1.Text = "Vitórias Jogador 1: 0";
            // 
            // lblVitoriasJogador2
            // 
            this.lblVitoriasJogador2.AutoSize = true;
            this.lblVitoriasJogador2.Location = new System.Drawing.Point(690, 434);
            this.lblVitoriasJogador2.Name = "lblVitoriasJogador2";
            this.lblVitoriasJogador2.Size = new System.Drawing.Size(103, 13);
            this.lblVitoriasJogador2.TabIndex = 19;
            this.lblVitoriasJogador2.Text = "Vitórias Jogador 2: 0";
            // 
            // lblEmpates
            // 
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.Location = new System.Drawing.Point(371, 434);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(60, 13);
            this.lblEmpates.TabIndex = 20;
            this.lblEmpates.Text = "Empates: 0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::jogodosnumeros2.Properties.Resources.mario_jorhe;
            this.pictureBox3.Location = new System.Drawing.Point(593, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jogodosnumeros2.Properties.Resources.kazzio_gay;
            this.pictureBox1.Location = new System.Drawing.Point(17, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(374, 359);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(77, 32);
            this.btnstart.TabIndex = 26;
            this.btnstart.Text = "Jogar";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Jogador2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jogador1);
            this.Controls.Add(this.botaoJogar1);
            this.Controls.Add(this.botaoJogar2);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.lblVitoriasJogador1);
            this.Controls.Add(this.lblVitoriasJogador2);
            this.Controls.Add(this.lblEmpates);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Jogador2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Jogador1;
        private System.Windows.Forms.Button botaoJogar1;
        private System.Windows.Forms.Button botaoJogar2;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Label lblVitoriasJogador1;
        private System.Windows.Forms.Label lblVitoriasJogador2;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnstart;
    }
}

