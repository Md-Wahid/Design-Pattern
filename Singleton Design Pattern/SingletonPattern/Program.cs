using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SingletonClass singletonClass1 = SingletonClass.GetInstance();
                Console.WriteLine(singletonClass1.GetMessage());
            }
            catch (System.NullReferenceException ex)
            {
                Console.WriteLine($"Exeption (NullReferenceException): {ex.ToString()}\n");
                Console.WriteLine($"Exeption (Message): {ex.Message}\n");
                Console.WriteLine($"Exeption (HelpLink): {ex.HelpLink.ToString()}\n");
                Console.WriteLine($"Exeption (HResult): {ex.HResult.ToString()}\n");
                Console.WriteLine($"Exeption (InnerException): {ex.InnerException.ToString()}\n");
                Console.WriteLine($"Exeption (Source): {ex.Source.ToString()}\n");
                Console.WriteLine($"Exeption (StackTrace): {ex.StackTrace.ToString()}\n");
                Console.WriteLine($"Exeption (TargetSite): {ex.TargetSite.ToString()}\n");
                foreach (var data in ex.Data)
                {
                    Console.WriteLine($"Key: {data}");
                }
                Console.WriteLine($"Exeption (NullReferenceException): {ex.ToString()}\n");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Exeption: {ex.ToString()}\n");
            }
            try
            {
                SingletonClass singletonClass2 = SingletonClass.GetInstance();
                Console.WriteLine(singletonClass2.GetMessage());
            }
            catch (System.NullReferenceException ex)
            {
                Console.WriteLine($"Exeption (NullReferenceException): {ex.ToString()}\n");
                Console.WriteLine($"Exeption (Message): {ex.Message}\n");
                Console.WriteLine($"Exeption (HelpLink): {ex.HelpLink}\n");
                Console.WriteLine($"Exeption (HResult): {ex.HResult}\n");
                // Console.WriteLine($"Exeption (InnerException): {ex.InnerException.ToString()}\n");
                Console.WriteLine($"Exeption (Source): {ex.Source}\n");
                Console.WriteLine($"Exeption (StackTrace): {ex.StackTrace}\n");
                Console.WriteLine($"Exeption (TargetSite): {ex.TargetSite.ToString()}\n");
                // for(int i=0; i<ex.Data.Count; i++)
                // {
                //     Console.WriteLine($"Key: {ex.Data[i].ToString()}");
                // }
                Console.WriteLine($"Exeption (NullReferenceException): {ex.Data.ToString()}\n");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Exeption: {ex.ToString()}\n");
            }
        }
    }
}
