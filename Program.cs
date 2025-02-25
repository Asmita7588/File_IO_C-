using BasicFileOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        //CreateFile
        BasicOperationsDemo.CreateFile();

        //DeleteFile
        BasicOperationsDemo.DeleteFile();

        //write to files
        BasicOperationsDemo.WriteToFile();

        //ReadLine by Line 
        BasicOperationsDemo.ReadAllLinesFromFile();

        //Read All text from file 
        BasicOperationsDemo.ReadAllTextFromFile();

        //copy to destination file 
        BasicOperationsDemo.CopyFile();

    }
}