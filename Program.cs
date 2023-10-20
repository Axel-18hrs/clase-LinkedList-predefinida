namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            // Agregar elementos al final de la lista
            linkedList.AddLast("Manzana");
            linkedList.AddLast("Banana");
            linkedList.AddLast("Cereza");

            Console.WriteLine("Lista enlazada inicial:");
            PrintLinkedList(linkedList);

            // Insertar "Uva" después de "Banana"
            LinkedListNode<string> node = linkedList.Find("Banana");
            if (node != null)
            {
                linkedList.AddAfter(node, "Uva");
            }

            Console.WriteLine("\nLista enlazada después de agregar 'Uva':");
            PrintLinkedList(linkedList);

            // Eliminar "Banana" de la lista
            linkedList.Remove("Banana");

            Console.WriteLine("\nLista enlazada después de eliminar 'Banana':");
            PrintLinkedList(linkedList);

            // Agregar "Piña" al principio de la lista
            linkedList.AddFirst("Piña");

            Console.WriteLine("\nLista enlazada después de agregar 'Piña' al principio:");
            PrintLinkedList(linkedList);

            // Eliminar el primer elemento de la lista
            linkedList.RemoveFirst();

            Console.WriteLine("\nLista enlazada después de eliminar el primer elemento:");
            PrintLinkedList(linkedList);

            // Eliminar el último elemento de la lista
            linkedList.RemoveLast();

            Console.WriteLine("\nLista enlazada después de eliminar el último elemento:");
            PrintLinkedList(linkedList);
        }

        static void PrintLinkedList(LinkedList<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}