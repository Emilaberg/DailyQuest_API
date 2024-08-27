using Newtonsoft.Json.Linq;

namespace Shared.Utility;

/// <summary>
/// A class that reads a JSON file from a local path and parses it into a JObject
/// Has a method to get a value from the JObject by key, can only return and handle json key value pairs where the value is a string
/// If anything goes wrong it logs the error and exits the program
/// </summary>
public class LocalFileReader(string path = """/ProgramProperties.json""")
{ //Insert path to secret file HERE  _________^^^^^^^^^^^^^^^^^^^^^^^______

    private string _path = path;
    private JObject? _json;
    public JObject? Json
    {
        get => _json;
        set => throw new AccessViolationException("Not Allowed to set the JSon variable");

    }


    /// <summary>
    /// Reads the JSON file from the _path and parses it into a JObject
    /// If anything fails it logs the error and exits the program
    /// </summary>
    public bool? ReadJsonFile()
    {
        try
        {
            if (!File.Exists(_path)) throw new FileNotFoundException("File Not Found: " + _path);
        }
        catch (Exception e)
        {
            Console.WriteLine("File Not Found: ");
            Console.WriteLine(e.StackTrace);
            return null;
        }

        string? rawJson = null;
        try
        {
            rawJson = File.ReadAllText(_path);
            if (rawJson == null) throw new NullReferenceException("The result of reading the file was null");
        }
        catch (Exception e)
        {
            Console.WriteLine("Could not read from the file: ");
            Console.WriteLine(e.StackTrace);
            return null;
        }

        try
        {
            _json = JObject.Parse(rawJson);
            if (_json == null) throw new NullReferenceException("The result of parsing the JSON file was null");
        }
        catch (Exception e)
        {
            Console.WriteLine("Could not parse the JSON file");
            Console.WriteLine(e.StackTrace);
            return null;
        }
        return true;
    }

    /// <summary>
    /// Searches for a key in the JObject and returns the value as a string
    /// Example: get value of "password" from the JObject
    /// do a  .GetValue("password")  and it will return the value of the key "password"
    /// log error if it fails,and exit the program
    /// </summary>
    /// <param name="key">the Key from Key Value Pairs</param>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public string? GetValue(string key)
    {
        if (_json == null) return null;
        try
        {
            var result = _json[key]?.ToString();
            if (result != null) return result;
            if (result == null) return null;
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went Wrong when trying to read key: " + key + " from the JObject");
            Console.WriteLine(e.StackTrace);
            return null;
        }

        return null;
    }

    public void CreateNewValue(string? Key, string? Value)
    {
        throw new NotImplementedException();
    }

    public void RemoveValue(string? Key)
    {
        throw new NotImplementedException();
    }

    public void UpdateValue(string key, string NewValue)
    {
        throw new NotImplementedException();
    }
}