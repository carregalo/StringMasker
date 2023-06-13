using System;
using System.Reflection.Metadata;

namespace StringMaker;
internal class MaskAttribute : Attribute
{
    public string RegexParameter { get; set; }
    public string MaskString { get; set; }
    public MaskAttribute(string parameter, string maskString)
    {
        RegexParameter = parameter;
        MaskString = maskString;
    }

}