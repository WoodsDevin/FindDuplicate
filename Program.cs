public class Program
{
	public static void Main(string[] args)
	{
		string MyString = "This has multiple repeating characters.";
		Console.WriteLine("First duplicate character in the string:\n\"" + MyString + "\"\nis:");
		
		try // Try to find a duplicate char
		{
			Console.WriteLine("\"" + FindDuplicate(MyString) + "\"");
		}
		catch (DuplicateNotFoundException e) // If no duplicate char....
		{
			// Print the error message.
			Console.WriteLine(e.Message);
		}
	}

	public static char FindDuplicate(string MyString)
	{
		// Default charcter set to Unicode Null
		char duplicateChar = '\0';

			// Outer loop
			for (int i = 0; i <= MyString.Length - 1; i++)
			{
				// Inner loop for comparing
				// The inner loop operates off of "i" from the outer loop, plus 1.
				// This is so the program will never evaluate the same index at one time.
				for (int j = i + 1; j <= MyString.Length - 1; j++)
				{
					if (MyString[j] == MyString[i]) // If found....
					{
						// Set the char
						duplicateChar = MyString[j];
						// Returnt he char
						return duplicateChar;
					}
				}
			}
		
		// If no duplicate was found
		if (duplicateChar == '\0')
		{
			// Throw the exception
			throw new DuplicateNotFoundException();
		}
		// This will never be reached, as the char will be returned when found, or an exception will be thrown instead.
		return duplicateChar;
	}
}
