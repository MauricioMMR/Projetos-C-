using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material
{
    internal class Material_Escolar
    {
        private string marca, tipo_material, cor, qualidade, qual_deseja;
       
        private int quantidade, tamanho;
        
        public void SetMarca(string m)
        {
            this.marca = m;
        }

        public string GetMarca()
        {
            return this.marca;
        }


        public void SetTipo(string T)
        {
            this.marca = T;
        }

        public string GetTipo()
        {
            return this.tipo_material;
        }

        public void SetCor(string c)
        {
            this.cor = c;
        }

        public string GetCor()
        {
            return this.cor;
        }

        public void SetQualidade(string q)
        {
            this.qualidade = q;
        }

        public string GetQualidade()
        {
            return this.qualidade;
        }

        public void SetQual(string d)
        {
            this.qual_deseja = d;
        }

        public string GetQual()
        {
            return this.qual_deseja;
        }

        public void SetQuant(int qn)
        {
            this.qualidade = qn;
        }


        public int GetQuant()
        {
            return this.quantidade;
        }

        public void SetTamanho(int Ta)
        {
            this.qualidade = Ta;
        }


        public int GetTamanho()
        {
            return this.tamanho;
        }
    }
}
