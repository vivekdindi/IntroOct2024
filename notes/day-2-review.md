# Day 2 Review

## Assemblies and Visual Studio
What is your understanding of what is meant by the term "Assembly" in .NET?
Assembly is an intermediate language that is created when we compile our project.
It creates a .exe or .dll, this is executed by Dotnet CLR.


What is the relationship between an assembly and visual studio Project?
A project has all the information about Assembly (.csproj file ), once the project is compiled then we get Assembly .dll or .exe .Next we can run our application, or we can import new features form .dll into other projects. 

What is a solution in Visual Studio?
Solutions contains one or more projects. 

What are the two types of Assemblies discussed in class?
Dynamic Link Library .dll and executables .exe.

What is the thing that makes an assembly "Runnable" - what is the *entry* point of an Assembly?
To run an application, it should have an entry point static void Main(string[] args ) {}
we can run an application with .exe extension.

## What is the "Common Language Runtime (CLR)" 
it is an important part of .NET framework that helps us to run the .NET applications (like JVM in Java)

## What is "Dotnet Core"? What's that all about?
Dotnet Core is an Open-source branch of .NET framework, it is designed to run on any operating system ex: Windows , MacOS or Linux

## What is the Common Type System (CTS)?
Common Type System in.NET specifies how data types are declared and managed so that we can run multiple .Net programming languages like VB or C#

## What are the "First Class Citizens" of .NET?
 values and Objects (Reference Type)

