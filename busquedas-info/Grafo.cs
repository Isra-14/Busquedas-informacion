using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedas_info {
    class Grafo {
        private int _v; // Representa el numero de nodos.
        private LinkedList<int>[] _adj; // Lista de adyacencia

        // Constructor
        public Grafo(int v) {
            _adj = new LinkedList<int>[v];

            for (int i = 0; i < _adj.Length; i++)
                _adj[i] = new LinkedList<int>();

            _v = v;
        }

        public void agregarVertice(int inicio, int destino) {
            _adj[inicio].AddLast(destino);
        }

        public int getSize() {
            return _v;
        }

        public LinkedList<int>[] getAdj() {
            return _adj;
        }

    }
}
