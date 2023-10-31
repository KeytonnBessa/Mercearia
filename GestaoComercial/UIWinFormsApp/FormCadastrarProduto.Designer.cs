namespace UIWinFormsApp
{
    partial class FormCadastrarProduto
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.bindingSourceProduto = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.textBoxCodigoDeBarra = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.labelCodigoDeBarra = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.cadastrarProduto = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProduto, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(12, 115);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(178, 27);
            this.textBoxNome.TabIndex = 0;
            // 
            // bindingSourceProduto
            // 
            this.bindingSourceProduto.DataSource = typeof(Models.Produto);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProduto, "Preco", true));
            this.textBoxPreco.Location = new System.Drawing.Point(282, 115);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(174, 27);
            this.textBoxPreco.TabIndex = 0;
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProduto, "Estoque", true));
            this.textBoxEstoque.Location = new System.Drawing.Point(12, 242);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.Size = new System.Drawing.Size(178, 27);
            this.textBoxEstoque.TabIndex = 0;
            // 
            // textBoxCodigoDeBarra
            // 
            this.textBoxCodigoDeBarra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProduto, "CodigoDeBarra", true));
            this.textBoxCodigoDeBarra.Location = new System.Drawing.Point(282, 242);
            this.textBoxCodigoDeBarra.Name = "textBoxCodigoDeBarra";
            this.textBoxCodigoDeBarra.Size = new System.Drawing.Size(174, 27);
            this.textBoxCodigoDeBarra.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 92);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 20);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Location = new System.Drawing.Point(12, 219);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(62, 20);
            this.labelEstoque.TabIndex = 1;
            this.labelEstoque.Text = "Estoque";
            // 
            // labelCodigoDeBarra
            // 
            this.labelCodigoDeBarra.AutoSize = true;
            this.labelCodigoDeBarra.Location = new System.Drawing.Point(282, 219);
            this.labelCodigoDeBarra.Name = "labelCodigoDeBarra";
            this.labelCodigoDeBarra.Size = new System.Drawing.Size(118, 20);
            this.labelCodigoDeBarra.TabIndex = 1;
            this.labelCodigoDeBarra.Text = "Codigo de Barra";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(282, 92);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(46, 20);
            this.labelPreco.TabIndex = 1;
            this.labelPreco.Text = "Preço";
            // 
            // cadastrarProduto
            // 
            this.cadastrarProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadastrarProduto.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastrarProduto.Location = new System.Drawing.Point(0, 0);
            this.cadastrarProduto.Name = "cadastrarProduto";
            this.cadastrarProduto.Size = new System.Drawing.Size(800, 48);
            this.cadastrarProduto.TabIndex = 1;
            this.cadastrarProduto.Text = "Cadastrar Produto";
            this.cadastrarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(586, 417);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(686, 417);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.cadastrarProduto);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelCodigoDeBarra);
            this.Controls.Add(this.labelEstoque);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxCodigoDeBarra);
            this.Controls.Add(this.textBoxEstoque);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastrarProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastrar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxPreco;
        private TextBox textBoxEstoque;
        private TextBox textBoxCodigoDeBarra;
        private Label labelNome;
        private Label labelEstoque;
        private Label labelCodigoDeBarra;
        private Label labelPreco;
        private Label cadastrarProduto;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private BindingSource bindingSourceProduto;
    }
}