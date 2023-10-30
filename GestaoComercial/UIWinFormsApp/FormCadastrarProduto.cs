﻿using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormCadastrarProduto : Form
    {
        private int id;
        public FormCadastrarProduto(int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if (id == 0)
                bindingSourceProduto.AddNew();
            else
                bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceProduto.EndEdit();
                Produto produto = (Produto)bindingSourceProduto.Current;

                if (id == 0)
                    new ProdutoBLL().Inserir(produto);
                else
                    new ProdutoBLL().Alterar(produto);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
