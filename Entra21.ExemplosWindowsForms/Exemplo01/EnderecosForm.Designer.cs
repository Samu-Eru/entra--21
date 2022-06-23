namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    partial class EnderecosForm
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
            this.labelCEP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelEnderecoCompleto = new System.Windows.Forms.Label();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelEnderecos = new System.Windows.Forms.Label();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(596, 35);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(28, 15);
            this.labelCEP.TabIndex = 0;
            this.labelCEP.Text = "CEP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnEnderecoCompleto,
            this.ColumnCep,
            this.ColumnPaciente});
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 345);
            this.dataGridView1.TabIndex = 1;
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(596, 53);
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(123, 23);
            this.maskedTextBoxCEP.TabIndex = 2;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(852, 219);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(98, 23);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(596, 93);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(112, 15);
            this.labelEnderecoCompleto.TabIndex = 4;
            this.labelEnderecoCompleto.Text = "Endereco Completo";
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(596, 111);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(354, 23);
            this.textBoxEnderecoCompleto.TabIndex = 5;
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(596, 141);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(52, 15);
            this.labelPaciente.TabIndex = 6;
            this.labelPaciente.Text = "Paciente";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(753, 219);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(98, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Items.AddRange(new object[] {
            "judty",
            "Kellem",
            "Francisco"});
            this.comboBoxPaciente.Location = new System.Drawing.Point(596, 159);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(354, 23);
            this.comboBoxPaciente.TabIndex = 9;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(504, 4);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 10;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(403, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 11;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // labelEnderecos
            // 
            this.labelEnderecos.AutoSize = true;
            this.labelEnderecos.Location = new System.Drawing.Point(3, 12);
            this.labelEnderecos.Name = "labelEnderecos";
            this.labelEnderecos.Size = new System.Drawing.Size(61, 15);
            this.labelEnderecos.TabIndex = 12;
            this.labelEnderecos.Text = "Endereços";
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnEnderecoCompleto
            // 
            this.ColumnEnderecoCompleto.HeaderText = "Endereco Completo";
            this.ColumnEnderecoCompleto.Name = "ColumnEnderecoCompleto";
            this.ColumnEnderecoCompleto.ReadOnly = true;
            // 
            // ColumnCep
            // 
            this.ColumnCep.HeaderText = "Cep";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            // 
            // ColumnPaciente
            // 
            this.ColumnPaciente.HeaderText = "Paciente";
            this.ColumnPaciente.Name = "ColumnPaciente";
            this.ColumnPaciente.ReadOnly = true;
            // 
            // EnderecosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.labelEnderecos);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.textBoxEnderecoCompleto);
            this.Controls.Add(this.labelEnderecoCompleto);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCEP);
            this.Name = "EnderecosForm";
            this.Text = "EnderecosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCEP;
        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBoxCEP;
        private Button buttonSalvar;
        private Label labelEnderecoCompleto;
        private TextBox textBoxEnderecoCompleto;
        private Label labelPaciente;
        private Button buttonCancelar;
        private ComboBox comboBoxPaciente;
        private Button buttonApagar;
        private Button buttonEditar;
        private Label labelEnderecos;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnEnderecoCompleto;
        private DataGridViewTextBoxColumn ColumnCep;
        private DataGridViewTextBoxColumn ColumnPaciente;
    }
}