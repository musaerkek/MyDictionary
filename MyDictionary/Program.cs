using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(01, "Adana");
            sehirler.Add(06, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(35, "İzmir");
            sehirler.List();
            sehirler.Count();
        }
    }
    class MyDictionary<Key,Value>
    {
        Key[] _key;
        Key[] _tempKey;
        Value[] _value;
        Value[] _tempValue;
        public MyDictionary()
        {
            _key = new Key[0];
            _value = new Value[0];
        }
        public void Add(Key key, Value value)
        {
            _tempKey = _key;
            _key = new Key[_key.Length + 1];
            for(int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            _key[_key.Length - 1] = key;

            _tempValue = _value;
            _value = new Value[_value.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _value[_value.Length - 1] = value;           
        }
        public void List()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("Plaka : " + _key[i] + " -- Şehir : " + _value[i]);
            }
        }
        public void Count()
        {
            Console.WriteLine("Şehir Sayısı : " + _key.Length);
        }
    }
}
