/*Write a program that enters file name along with its full file path 
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
 * Find in MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print user-friendly error messages.*/

using System;
using System.Collections.Generic;
using System.IO;

class HandleReadFileContent
{
	static void ReadFile()
	{
		string path = @"..\..\win.ini";
		
		if (path.Length > 248) 
		{
			throw new PathTooLongException();	
		}
		string content = File.ReadAllText(path);
		if (path == null) 
		{
			throw new ArgumentException();
		}
		if (!File.Exists(path)) 
		{
			throw new FileNotFoundException();
		}
        if (!Directory.Exists(path))
        {
            throw new DirectoryNotFoundException();
        }
		
		FileInfo fInfo = new FileInfo(path);
		if (fInfo.IsReadOnly) 
		{
			throw new UnauthorizedAccessException();
		}
		
		Console.WriteLine("--- Contents of the file: ---");
		Console.WriteLine(content);
	}
	
	static void Main()
	{
		try 
		{
			ReadFile();
		} 
		catch (ArgumentException) 
		{
			Console.WriteLine ("The path to the file is empty!");
		}
		catch (PathTooLongException)
		{
			Console.WriteLine ("The path to the file is TOO long!");
		}
		catch (DirectoryNotFoundException)
		{
			Console.WriteLine ("Directory was not FOUND!");
		}
		catch (FileNotFoundException)
		{
			Console.WriteLine ("FIle was not found in the directory!");
		}
		catch (UnauthorizedAccessException)
		{
			Console.WriteLine ("The file is read-only and can NOT be accessed!");
		}
		catch (Exception)
		{
			Console.WriteLine ("The operation couldn't be processed");
		}

	}
}