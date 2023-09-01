namespace MyExtensions;

public static class MyExtensions
{
    public static T First<T>(this IEnumerable<T> collection, Predicate<T>? predicate)
    {
        foreach (var elem in collection)
        {
            bool? flag = predicate?.Invoke(elem);
            if (flag == true || flag is null) return elem;
        }
        throw new InvalidOperationException();
    }

    public static T First<T>(this IEnumerable<T> collection)
    {
        return collection.First(null);
    }

    public static T? FirstOrDefault<T>(this IEnumerable<T>? collection, Predicate<T>? predicate)
    {
        if (collection is null)
            return default;
        foreach (var elem in collection)
        {
            bool? flag = predicate?.Invoke(elem);
            if (flag == true || flag is null) return elem;
        }
        return default;
    }

    public static T? FirstOrDefault<T>(this IEnumerable<T> collection)
    {
        return
            collection.FirstOrDefault(null);
    }

    public static IList<T> Where<T>(this IEnumerable<T>? collection, Predicate<T> predicate)
    {
        if (predicate == null)
            throw new InvalidOperationException();
        IList<T> result = new List<T>();
        if (collection == null) return result;
        foreach (var elem in collection)
        {
            if (predicate(elem)) result.Add(elem);
        }

        return result;
    }

    public static bool Any<T>(this IEnumerable<T> collection, Predicate<T>? predicate)
    {
        foreach (var elem in collection)
        {
            bool? flag = predicate?.Invoke(elem);
            if (flag is null || flag == true) return true;
        }

        return false;
    }

    public static bool Any<T>(this IEnumerable<T> collection)
    {
        return collection.Any(null);
    }
}