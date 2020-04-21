namespace Task4
{
    class ArrayList
    {
        object[] _objectArray;

        public ArrayList()
        {
            _objectArray = new object[0];
        }

        public void Add(object valueFromClassProgram)
        {
           object[] _temporaryObjectArray = new object[_objectArray.Length+1];

            for (int i = 0; i < _objectArray.Length; i++)
            {
                _temporaryObjectArray[i] = _objectArray[i];
            }

            _temporaryObjectArray[_objectArray.Length] = valueFromClassProgram;
            _objectArray = _temporaryObjectArray;
        }

        public override string ToString()
        {
            string temporaryString = "";

            for (int i = 0; i < _objectArray.Length; i++)
            {
                temporaryString += _objectArray[i] + "\n";
            }

            return $"Массив:\n{temporaryString}";
        }
    }
}
