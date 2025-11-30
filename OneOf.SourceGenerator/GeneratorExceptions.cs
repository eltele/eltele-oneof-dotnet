namespace OneOf;

public static class GeneratorExceptions
{
        public class DuplicateTypeException : System.Exception
        {
                public string Type { get; }

                public DuplicateTypeException(string type)
                {
                        Type = type;
                }
        }
}