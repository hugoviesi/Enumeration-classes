using System.Reflection;

namespace EnumerationClasses.Enum
{
    public class Enumeration : IComparable
    {
        private int _value { get; }
        private string _displayName { get; }

        public Enumeration() { }

        public Enumeration(int value, string displayName)
        {
            _value = value;
            _displayName = displayName;
        }

        public int CompareTo(object other)
        {
            return _value.CompareTo(((Enumeration)other)._value);
        }
    }
}
