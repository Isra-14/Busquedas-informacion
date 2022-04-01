using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedas_info {
    class Grafo {
        private int _v; // Representa el numero de nodos.
        private LinkedList<int>[] _adj; // Lista de adyacencia
        private int peso;
        private Dictionary<string, int> _pesos;


        // Constructor
        public Grafo(int v) {
            _adj = new LinkedList<int>[v];
            for (int i = 0; i < _adj.Length; i++)
                _adj[i] = new LinkedList<int>();
            _pesos = new Dictionary<string, int>();

            _v = v;
        }

        public void agregarVertice(int inicio, int destino, int peso) {
            _adj[inicio].AddLast(destino);
            string tempKey = inicio.ToString() + "," + destino.ToString();
            
            // Asignacion de valores al diccionario 
            _pesos.Add(tempKey, peso);
        }

        public int getSize() {
            return _v;
        }


        public LinkedList<int>[] getAdj() {
            return _adj;
        }

        public int Peso { get => peso; set => peso = value; }
        public Dictionary<string, int> Pesos { get => _pesos; set => _pesos = value; }
    }
}
