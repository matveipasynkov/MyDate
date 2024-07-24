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
