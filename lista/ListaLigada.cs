using System;
using System.Collections.Generic;

namespace aula.lista
{
    public class ListaLigada
    {
        public Vagao Trem { get; set; }

        public void InserirVagao(Vagao novoVagao) {
            if(Trem == null) Trem = novoVagao;
            else {
                var vagaoAnterior = getUltimoVagao();
                vagaoAnterior.VagaoAnterior = novoVagao;
            }
        }

        public Vagao getUltimoVagao() {
            var tempVagao = Trem;
            while(tempVagao.VagaoAnterior != null) {
                tempVagao = tempVagao.VagaoAnterior;
            }
            return tempVagao;
        }

        public List<Vagao> getVagoes() {
            var _trem = new List<Vagao>();
            var tempVagao = Trem;
            while(tempVagao != null) {
                _trem.Add(tempVagao);
                tempVagao = tempVagao.VagaoAnterior;
            };
            return _trem;
        }

        public Vagao getVagaoById(int id)
        {
            foreach (Vagao item in getVagoes())
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Vagao> getVagoesByName(string name)
        {
            var listaVagoes = new List<Vagao>();

            foreach (Vagao item in getVagoes())
            {
                if (item.Carga.ToUpper() == name.ToUpper())
                {
                    listaVagoes.Add(item);
                }
            }
            return listaVagoes;
        }
    }
}