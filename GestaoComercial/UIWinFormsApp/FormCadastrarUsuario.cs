using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormCadastrarUsuario : Form
    {
        private int id;
        public FormCadastrarUsuario(int _id = 0)
        {
            InitializeComponent();
            id = _id;

           if (id == 0)
                bindingSourceUsuario.AddNew();
            else
                bindingSourceUsuario.DataSource = new UsuarioBLL().BuscarPorId(id);

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceUsuario.EndEdit();
                Usuario usuario = (Usuario)bindingSourceUsuario.Current;

                if (id == 0)
                    new UsuarioBLL().Inserir(usuario, textBoxConfirmacaoSenha.Text);
                else
                    new UsuarioBLL().Alterar(usuario, textBoxConfirmacaoSenha.Text);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
