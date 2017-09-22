// Inherits from Exception
public class DuplicateNotFoundException : Exception
{
	// Override the virtual property Message in the Exception class
	public override string Message
	{
		get
		{
			// Error message to be returned.
			return "No duplicate was found in the string.";
		}
	}
}
