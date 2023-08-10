// See https://aka.ms/new-console-template for more information
using static Abstract_Factory.Factory;

LessonFactory factory;

factory = new OnlineFactory();

var csharpOnline = factory.MakeCSharpLesson();
Console.WriteLine(csharpOnline.Confirm());

var javaOnline = factory.MakeJavaLesson();
Console.WriteLine(javaOnline.Confirm());

factory = new InPersonFactory();

var csharpInPerson = factory.MakeCSharpLesson();
Console.WriteLine(csharpInPerson.Confirm());

var javaInPerso = factory.MakeJavaLesson();
Console.WriteLine(javaInPerso.Confirm());

Console.ReadLine();