using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedas_info {
    class Nodo {
        private int id;
        private int peso;

        public Nodo(int id, int peso) {
            this.id = id;
            this.peso = peso;
        }

        public int Peso { get => peso; set => peso = value; }
        public int Id { get => id; set => id = value; }
    }
}
