﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_11._0
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool isChapa { get; set; }
        
        public override string ToString()
        {
            return ($"{Quantidade}x - {Nome} - {Preco:F2}");
        }

    }
}
        