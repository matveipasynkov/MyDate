# MyDate
This is my third project, which was assigned as homework in university. The console application is stored in ConsoleApplication, the class library in LibraryOfMethods.
## Main Assignment
Develop a solution containing a console application project and a class library.
## Console Application 
In the main program, using the class library, retrieve from an input file strings containing dates and events specified in the format assumed by the constructor of the MyDate class. The data in the file can be arranged either line by line or in multiple lines. Create an array of objects of the MyDate type. Output to the output file the original lines, as well as a formatted and sorted by ascending date table of dates and events, taking into account missing values, i.e. lines with N/A characters.
## Class Library
#### In the class library, declare the MyDate class with the following properties:
	• Class field - DateTime[] _dates
 	• Class field - String[] _events
  	• Constructor with string str parameter. The constructor receives as input a string of the following form: YYYYY-MM-DD:event_1; YYYYY-MM-DD:event_2;... Two equal-sized arrays are formed using the data from the string, linked with the references _dates and _events, respectively. The dates array stores strings with the date, the events array stores event names. If an event or date is missing or in an incorrect format, the string N/A” is inserted. A correct date line consists only of digits and separators - hyphens. A correct event is a sequence of Latin lowercase and uppercase characters and spaces not more than 70 characters long.
   	• Open properties for reading data of date and event arrays
## Compatibility and quality requirements for the main task
	1) all program code must be written in the C# programming language, taking into account the use of .net 6.0;
	2) the source code must contain comments explaining non-obvious fragments and solutions, code summary, description of code goals (see materials of lecture 1, module 1);
	3) identifiers used in the program must conform to the rules and conventions of C# identifier naming (https://learn.microsoft.com/ruru/dotnet/csharp/fundamentals/coding-style/identifier-names);
	4) the code submitted for testing must conform to Microsoft's general C# code conventions (https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/codingconventions); 
	5) when the library project folder is moved (copied / transferred to another device), the files must be opened by the program as successfully as on the creator's computer, i.e. on a relative path;
 	6) text data, including data in Russian, are successfully decoded when presented to the user and are human-readable;
	7) the program does not allow the user to solve tasks until correct data are entered from the keyboard;
	8) the console application handles exceptional situations related to (1) input and conversion / conversion of data both from the keyboard and from files; (2) creation, initialization, access to array and string elements; (3) calling library methods.
	9) the class library submitted for testing must solve all the tasks and compile successfully.
	10) only arrays (type derived from Array) should be used as data structures.
	11) it is forbidden to use third-party libraries and nuget packages to work with csv-files, the code must be prepared independently.
	12) the console application must handle emergency situations and contain a loop to repeat the solution.
	13) each library method can be used separately from the console application code, for example, when inserting it into another project and accessing the library methods from it using the reference to the library and the method signature specified in the task.
