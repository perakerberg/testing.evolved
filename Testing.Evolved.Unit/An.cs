using System;
using System.Collections.Generic;
using System.Linq;
using Ploeh.AutoFixture;

namespace Testing.Evolved.Unit
{
    public class An
    {
        private static readonly Fixture Fixture = new Fixture();

        public static IEnumerable<T> EmptySetOf<T>()
        {
            return new T[0];
        }

        public static T[] EmptyArrayOf<T>()
        {
            return new T[0];
        }

        public static IQueryable<T> EmptyQueryableSetOf<T>()
        {
            return EmptySetOf<T>().AsQueryable();
        }

        public static T Arbitrary<T>(params Action<T>[] initializers)
        {
            var result = Fixture.Create<T>();
            if (initializers != null)
            {
                foreach (var initializer in initializers)
                {
                    initializer(result);
                }
            }
            return result;
        }

        public static string ArbitraryStringContaining(string stringToContain)
        {
            return $"{An.Arbitrary<string>()}{stringToContain}{An.Arbitrary<string>()}";
        }

        public static IEnumerable<T> ArbitrarySetOf<T>(int? count = null)
        {
            if (!count.HasValue)
                count = An.Arbitrary<int>();

            return Fixture.CreateMany<T>(count.Value);
        }

        public static IEnumerable<T> SetOf<T>(params T[] items)
        {
            return items ?? EmptySetOf<T>();
        }

        public static List<T> ListOf<T>(params T[] items)
        {
            return SetOf(items).ToList();
        }

        public static T[] ArrayOf<T>(params T[] items)
        {
            return SetOf(items).ToArray();
        }

        public static IEnumerable<T> QueryableSetOf<T>(params T[] items)
        {
            return items?.AsQueryable() ?? EmptyQueryableSetOf<T>();
        }
    }
}