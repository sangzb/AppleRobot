using System;
using System.Reflection;
internal class Class1
{
    internal delegate void Delegate0(object o);
    internal static Module module_0;
    internal static void a0QQOijj2ln1q(int typemdt)
    {
        Type type = Class1.module_0.ResolveType(33554432 + typemdt);
        FieldInfo[] fields = type.GetFields();
        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo fieldInfo = fields[i];
            MethodInfo method = (MethodInfo)Class1.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
            fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
        }
    }
    public Class1()
    {
        Class2.e1eQOijzrvtg6();
    }
    static Class1()
    {
        Class2.e1eQOijzrvtg6();
        Class1.module_0 = typeof(Class1).Assembly.ManifestModule;
    }
}

