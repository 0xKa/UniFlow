using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniFlow.Shared;

public class Util
{
    public enum enMode { AddNew, Update }

    //returns the new image path
    static string folderPath = @"..\..\..\PeopleImages";
    public static string? SaveNewImage(string SourceImagePath)
    {
        Directory.CreateDirectory(folderPath); // Ensure the directory exists

        string UniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(SourceImagePath);
        string NewImagePath = Path.Combine(folderPath, UniqueFileName);


        try
        {
            File.Copy(SourceImagePath, NewImagePath, true);
            return Path.GetFullPath(NewImagePath);
        }
        catch
        {
            return null;
        }

    }

}
