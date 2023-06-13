using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace StringMaker;

public class MaskerService
{

    public static object MaskObject<I, O>(I input) where I : class
    {
        Type type = typeof(I);
        PropertyInfo[] properties = type.GetProperties();

        O output = Activator.CreateInstance<O>();

        foreach (PropertyInfo property in properties)
        {
            if (property.GetCustomAttribute<MaskAttribute>() != null)
            {
                string regexPattern = property.GetCustomAttribute<MaskAttribute>().RegexParameter;
                string maskString = property.GetCustomAttribute<MaskAttribute>().MaskString;



                Regex regex = new Regex(regexPattern);
                Type typeOutput = typeof(O);
                var propertyOutput = typeOutput.GetProperty(property.Name);
                string maskedValue;

                string value;
                if (property.PropertyType == typeof(DateTime))
                {
                    DateTime dateTime = (DateTime)property.GetValue(input);
                    value = dateTime.ToShortDateString();
                    maskedValue = regex.Replace(value, maskString);

                }
                else
                {
                    value = property.GetValue(input)?.ToString();
                    maskedValue = regex.Replace(value, maskString);
                }

                propertyOutput.SetValue(output, maskedValue);



            }
        }

        return output;
    }
}