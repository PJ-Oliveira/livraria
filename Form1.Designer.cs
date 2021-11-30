namespace livraria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Titulo = new System.Windows.Forms.Label();
            this.Tema = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.Livraria = new System.Windows.Forms.Label();
            this.Novo = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Exibir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Consulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo.Location = new System.Drawing.Point(590, 109);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(46, 16);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Título";
            // 
            // Tema
            // 
            this.Tema.AutoSize = true;
            this.Tema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Tema.Location = new System.Drawing.Point(590, 149);
            this.Tema.Name = "Tema";
            this.Tema.Size = new System.Drawing.Size(47, 16);
            this.Tema.TabIndex = 1;
            this.Tema.Text = "Tema";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Autor.Location = new System.Drawing.Point(593, 184);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(43, 16);
            this.Autor.TabIndex = 2;
            this.Autor.Text = "Autor";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(652, 109);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 3;
            this.txtTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(652, 145);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(100, 20);
            this.txtTema.TabIndex = 4;
            this.txtTema.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(652, 184);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Livraria
            // 
            this.Livraria.AutoSize = true;
            this.Livraria.BackColor = System.Drawing.Color.Transparent;
            this.Livraria.Font = new System.Drawing.Font("Caladea", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Livraria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Livraria.Location = new System.Drawing.Point(203, -4);
            this.Livraria.Name = "Livraria";
            this.Livraria.Size = new System.Drawing.Size(247, 75);
            this.Livraria.TabIndex = 6;
            this.Livraria.Text = "Livraria";
            this.Livraria.Click += new System.EventHandler(this.label4_Click);
            // 
            // Novo
            // 
            this.Novo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Novo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Novo.Location = new System.Drawing.Point(652, 225);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(100, 23);
            this.Novo.TabIndex = 7;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Editar
            // 
            this.Editar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Editar.Location = new System.Drawing.Point(652, 254);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(100, 23);
            this.Editar.TabIndex = 8;
            this.Editar.Text = "Edite por Id";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Excluir.Location = new System.Drawing.Point(652, 283);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(100, 23);
            this.Excluir.TabIndex = 9;
            this.Excluir.Text = "Excluir por Id";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Exibir
            // 
            this.Exibir.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Exibir.Location = new System.Drawing.Point(652, 341);
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(100, 23);
            this.Exibir.TabIndex = 11;
            this.Exibir.Text = "Exibir Todos";
            this.Exibir.UseVisualStyleBackColor = true;
            this.Exibir.Click += new System.EventHandler(this.Exibir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(49, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 312);
            this.dataGridView1.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ID.Location = new System.Drawing.Point(610, 74);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(22, 16);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(652, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 14;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // Consulta
            // 
            this.Consulta.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Consulta.Location = new System.Drawing.Point(652, 312);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(100, 23);
            this.Consulta.TabIndex = 15;
            this.Consulta.Text = "Consulte por Id";
            this.Consulta.UseVisualStyleBackColor = true;
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exibir);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.Livraria);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Tema);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Tema;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label Livraria;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Exibir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button Consulta;
    }
}

