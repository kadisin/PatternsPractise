/*
 * 
 * Singleton is pattern use to get only one and same instance in global 
 * Example is processing database...
 * 
 */

using SingletonPattern.Singleton;

var singleton1 = DatabaseSingleton.GetInstance();
var singleton2 = DatabaseSingleton.GetInstance();

//should be equal reference
if(singleton1 == singleton2)
{
    Console.WriteLine("We got only one instance");
}
else
{
    Console.WriteLine("Oooops, something went wrong!");
}

singleton1.QueryDatabase();

//We got only one instance