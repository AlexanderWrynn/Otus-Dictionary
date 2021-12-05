using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Dictionary
{
    internal class OtusDictionary
    {
        private static int capacity = 32;
        public Node[] storage = new Node[capacity];

        public Node this[int i]
        {
            get { return storage[i]; }
            set { storage[i] = value; }
        }

        public void Add(int key, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Введена пустая строка");
                return;
            }

            if (key < 0)
            {
                key *= -1;
            }

            if (storage[key % capacity] != null)
            {
                capacity = capacity * 2 + 1;
                Node[] newStorage = new Node[capacity];

                foreach (var node in storage)
                {

                    if (node == null)
                    {
                        continue;
                    }

                    newStorage[node.Key % capacity] = new Node { Key = node.Key, Value = node.Value };
                }

                storage = newStorage;
            }

            storage[key % capacity] = new Node { Key = key, Value = value };
        }

        public string Get(int key)
        {

            if (key < 0)
            {
                key *= -1;
            }

            if (storage[key % capacity] == null)
            {
                return $"Объекта с ключом {key} не найдено";
            }

            else
            {
                return storage[key % capacity].Value;
            }
        }

    }
}
