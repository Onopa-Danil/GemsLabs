namespace MyExtensions;

public static class MyExtensions
{
    public static T? First<T>(this IEnumerable<T> collection, Predicate<T>? predicate)
    {
        if (collection == null || !collection.Any())
            throw new InvalidOperationException();
        foreach (var elem in collection)
        {
            bool? flag = predicate?.Invoke(elem);
            if (flag == true || flag == null) return elem;
        }
        throw new InvalidOperationException();
    }

    public static T? First<T>(this IEnumerable<T> collection)
    {
        return collection.First(null);
    }

    public static T? FirstOrDefault<T>(this IEnumerable<T>? collection, Predicate<T>? predicate)
    {
        if (collection == null || !collection.Any())
            return default(T);
        foreach (var elem in collection)
        {
            bool? flag = predicate?.Invoke(elem);
            if (flag == true || flag == null) return elem;
        }
        return default(T);
    }

    public static T? FirstOrDefault<T>(this IEnumerable<T>? collection)
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
        if (collection == null)
            throw new InvalidOperationException();
        foreach (var elem in collection)
        {
            bool? flag = predicate?.Invoke(elem);
            if (flag == null || flag == true) return true;
        }

        return false;
    }

    public static bool Any<T>(this IEnumerable<T> collection)
    {
        return collection.Any(null);
    }
}