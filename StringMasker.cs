using System;
using System.Reflection;
using System.Text.RegularExpressions;

public class StringMasker
{


    public static object MaskString<T>(T obj, Dictionary<string, string> maskPatterns) where T : class
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        foreach (PropertyInfo property in properties)
        {
            if (property.GetCustomAttribute<MaskAttribute>() != null)
            {
                if (maskPatterns.TryGetValue(property.Name, out string pattern))
                {
                    string value = property.GetValue(obj)?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        Regex regex = new Regex(pattern);

                        string maskedValue = regex.Replace(value, "*");
                        property.SetValue(obj, Convert.ChangeType(maskedValue, property.PropertyType));
                    }
                }
            }
        }

        return obj;
    }
}
