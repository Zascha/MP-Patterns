using System;
using System.Collections.Generic;
using CreationalPatterns.Prototype;

namespace CreationalPatterns.Tests
{
    public static class TestData
    {
        public static List<double> NumericList => GenerateRandomNumericList<double>(10);

        public static LargeObject LargeObject => new LargeObject {IntField = 42, StringField = "Test"};

        #region Private methods

        public static List<T> GenerateRandomNumericList<T>(int arrayCapacity) where T: struct
        {
            if (arrayCapacity <= 0)
                throw new ArgumentException("Invalid passed array capacity value.");

            var generator = new Random();

            var numericList = new List<T>();

            while (arrayCapacity-- >=0)
            {
                var value = (T)Convert.ChangeType(generator.Next(), typeof(T));
                numericList.Add(value);
            }

            return numericList;
        }

        #endregion
    }
}
