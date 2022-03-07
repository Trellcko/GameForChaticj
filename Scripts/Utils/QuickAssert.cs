using UnityEngine.Assertions;

namespace House312B.Utils
{
    public static class QuickAssert
    {
        private const string CantBeNullMessage  = "can't be null";
        private const string DidntFindMessage = "didn't find";
        private const string ArentEqual = "Aren't equal";

        public static void AssertIsNotNullAfterAssigment<T>(T obj) where T : class
        {
            AssertIsNotNull(obj, DidntFindMessage);
        }

        public static void AssertIsNotNullAfterFind<T>(T obj) where T: class
        {
            AssertIsNotNull(obj, CantBeNullMessage);
        }

        private static void AssertIsNotNull<T>(T obj, string message) where T :class
        {

            Assert.IsNotNull(obj, $"{nameof(T)} {message}");
        }
    }
}