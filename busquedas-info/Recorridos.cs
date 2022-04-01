using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedas_info
{
    class Recorridos {
        readonly int _v;
        public Recorridos(int v) {
            _v = v;
        }

        // Funciones auxiliares para recorrer las adyacencias de cada nodo.

        public void Greddy(int inicio, int busqueda, LinkedList<int>[] _adj, Dictionary<string, int> _pesos, Dictionary<string, int> _estados) {
            int pesoFinal = 0;
            LinkedList<int> queue = new LinkedList<int>();  // Queue para el BFSX
            List<int> final = new List<int>();  // Queue para el BFSX

            queue.AddLast(inicio);
            final.Add(inicio);

            int ultimoVisitado = -1;
            while (true) {
                inicio = final[final.Count - 1];

                string tempS = inicio.ToString() + "," + busqueda.ToString();
                try{
                    pesoFinal += _pesos[tempS];
                    final.Add(busqueda);
                    break;
                }catch(Exception e){
                    LinkedList<int> lista = _adj[inicio];

                    int elementoAdd = -1;
                    int pesoMenor = int.MaxValue;
                    foreach (var elemento in lista) {
                        
                        string tempNodo = inicio.ToString() + "," + elemento.ToString();
                        if (_pesos[tempNodo] < pesoMenor && ultimoVisitado != elemento) {
                            pesoMenor = _pesos[tempNodo];
                            elementoAdd = elemento;
                        }
                    }

                    if (elementoAdd > -1) {

                        pesoFinal += pesoMenor;
                        final.Add(elementoAdd);
                    }

                    ultimoVisitado = inicio;
                }
            }

            foreach (var elemento in final)
            {        
                foreach (KeyValuePair<string, int> estado in _estados)
                {
                    if (elemento == estado.Value)
                    {
                        Console.WriteLine("Estado visitado: " + estado.Key);
                    }
                }
            }

            Console.WriteLine("Peso final: " + pesoFinal);

            Console.WriteLine("\n\n");
        }
    }
}
