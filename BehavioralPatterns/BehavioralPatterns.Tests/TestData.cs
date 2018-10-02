using System;
using System.Collections.Generic;
using BehavioralPatterns.Iterator;

namespace BehavioralPatterns.Tests
{
    public static class TestData
    {
        public static double DemodulationHandlerLimit = 10000;

        public static Func<double, double> NoizyDemodulationHandlerLogic => value => Math.Round(value * 2, 2);

        public static Func<double, double> SimpleDemodulationHandlerLogic => value => value * 2;

        public static List<double> NumericList => GenerateRandomNumericList<double>(10);

        public static User UserA = new User { Name = "UserA"};

        public static User UserB= new User { Name = "UserB"};

        public static User UserC = new User { Name = "UserC"};

        public static List<User> UsersList = new List<User> { UserA , UserB, UserC};

        #region Private methods

        public static List<T> GenerateRandomNumericList<T>(int arrayCapacity) where T : struct
        {
            if (arrayCapacity <= 0)
                throw new ArgumentException("Invalid passed array capacity value.");

            var generator = new Random();

            var numericList = new List<T>();

            while (arrayCapacity-- >= 0)
            {
                var value = (T)Convert.ChangeType(generator.Next(), typeof(T));
                numericList.Add(value);
            }

            return numericList;
        }

        #endregion
    }
}
