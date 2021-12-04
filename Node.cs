namespace Otus_Dictionary
{
    internal class Node
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"Key - {Key}, value - {Value}";
        }

    }
}
