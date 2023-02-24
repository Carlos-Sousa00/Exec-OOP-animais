﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Estimacao.Animal
{
    internal class Animal
    {
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private string tipo;
		public string Tipo
		{
			get { return tipo; }
			set {
                if (value == "Cachorro" || value == "Gato") 
				{
					tipo = value;

				}
				else 
					tipo = "Peixe";
							
				}
		}


	}
}
