using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace busquedas_info {
    class Program {
        static void Main(string[] args) {
            string file = @"../../../estados.txt";
            List<string> lines = File.ReadLines(file).ToList();
            Dictionary<string, int> estados = new Dictionary<string, int>();

            int i = 0;
            int size;
            foreach(string line in lines){
                estados.Add(line, i);
                i++;
            }

            lines.Clear();
            file = @"../../../grafo.txt";
            lines = File.ReadLines(file).ToList();

            size = Int32.Parse(lines[0]);
            size *= 2;
            lines.RemoveAt(0);

            if (size != 0) {
                Grafo g = new Grafo(size);
                foreach (string line in lines) {
                    string[] temp = line.Split(' ');
                    string e1 = temp[0];
                    string e2 = temp[1];
                    int peso = Int32.Parse(temp[2]);

                    g.agregarVertice(estados[e1], estados[e2], peso);

                    i++;
                }

                foreach (string line in lines) {
                   string[] temp = line.Split(' ');
                   string e1 = temp[1];
                   string e2 = temp[0];
                   int peso = Int32.Parse(temp[2]);

                   g.agregarVertice(estados[e1], estados[e2], peso);

                   i++;
                }

                Console.Write("(DFS)\n");
                Recorridos recorrido = new Recorridos(g.getSize());
                recorrido.Greddy(estados["Hermosillo"], estados["Zacatecas"], g.getAdj(), g.Pesos,estados);
                

                Console.ReadLine();
            }   
        }
    }
}