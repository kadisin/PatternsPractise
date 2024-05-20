/*
 * 
 * Builder pattern is used to create instances with diffrent configurations
 * In this case we could build home with Garage, Garden and Swimming Pool
 * also with any combination of this parameters
 *
 */

using BuilderPattern.Builder;
using BuilderPattern.Director;

var director = new Director();
var builder = new HomeBuilder();

director.HomeBuilder = builder;

Console.WriteLine("Standard basic home: ");
director.BuildMinimalViableHome();
builder.GetHome().ShowParts();

Console.WriteLine("Standard full featured home: ");
director.BuildFullFeaturedHome();
builder.GetHome().ShowParts();

Console.Write("Custom featured home: ");
builder.BuildSwimmingPool();
builder.BuildGarden();
builder.GetHome().ShowParts();

/*
 * 
 * Standard basic home:
Parts: Garage Part
Standard full featured home:
Parts: Garage Part, Garden Part, Swimming Pool Part
Custom featured home: Parts: Swimming Pool Part, Garden Part
 */