namespace MyUnit
{
    public static class MyAssert
    {
        public static void True(bool actual)
        {
            if (!actual)
                throw new MyAssertTestFailureException();
        }

        public static void False(bool actual)
        {
            if (actual)
                throw new MyAssertTestFailureException();
        }
        public static void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            if (!expected.SequenceEqual(actual))
                throw new MyAssertTestFailureException();
        }

        public static void Equal(object expected, object actual)
        {
            if (!expected.Equals(actual))
                throw new MyAssertTestFailureException();
        }
        
        public static void Null(object? actual)
        {
            if (actual is not null)
                throw new MyAssertTestFailureException();
                
        }
        public static void NotNull(object actual)
        {
            if (actual is null)
                throw new MyAssertTestFailureException();
            
        }

        public static void Throws<T>(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                if (e.GetType() == typeof(T)) return;
            }
            throw new MyAssertTestFailureException();
        }

        public static void Same(object expected, object actual)
        {
            if (expected != actual)
                throw new MyAssertTestFailureException();
        }
    }
}
