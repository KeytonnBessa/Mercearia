﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Constantes
    {
        private static string stringDeConexao = "User ID=SA;Initial Catalog=Mercearia;Data Source=.\\sqlexpress2019;Password=Senailab02";
        public static string StringDeConexao 
        {
            get
            {
                return stringDeConexao;
            }
        }
        
        //SqlConnection cn = new SqlConnection("User ID=SA;Initial Catalog=Mercearia,Data Source=.\\sqlexpress2019;Password=Senailab02");

    }
}
