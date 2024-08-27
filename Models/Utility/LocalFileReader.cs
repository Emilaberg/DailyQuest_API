using Newtonsoft.Json.Linq;

namespace Shared.Utility;

/// <summary>
/// A class that reads a JSON file from a local path and parses it into a JObject
/// Has a method to get a value from the JObject by key, can only return and handle json key value pairs where the value is a string
/// If anything goes wrong it logs the error and exits the program
/// </summary>
public class LocalFileReader
{
    //PUT THE PATH TO THE FILE YOU WANT TO READ HERE
    public LocalFileReader() : this("C:\\Programming\\Dependencies\\SecretFiles\\DailyQuest.json") { }

    private readonly string _path;
    private JObject? _json;
    public JObject Json
    {
        get => _json;
        set => throw new AccessViolationException("Not Allowed to set the JSon variable");

    }

    /// <summary>
    /// Reads the JSON file from the _path and parses it into a JObject
    /// If anything fails it logs the error and exits the program
    /// </summary>
    public void ReadJsonFile()
    {
        try
        {
            if (!File.Exists(_path)) Console.WriteLine("File not found");
        }
        catch (Exception e)
        {
            Console.WriteLine("File Not Found: ");
            Console.WriteLine(e.StackTrace);
            Environment.Exit(1);
        }

        string? _rawJson = null;
        try
        {
            _rawJson = File.ReadAllText(_path);
            if (_rawJson == null) throw new NullReferenceException("The result of reading the file was null");
        }
        catch (Exception e)
        {
            Console.WriteLine("Could not read from the file: ");
            Console.WriteLine(e.StackTrace);
            Environment.Exit(1);
        }

        try
        {
            _json = JObject.Parse(_rawJson);
            if (_json == null) throw new NullReferenceException("The result of parsing the JSON file was null");
        }
        catch (Exception e)
        {
            Console.WriteLine("Could not parse the JSON file");
            Console.WriteLine(e.StackTrace);
            Environment.Exit(1);
        }
    }

    /// <summary>
    /// Searches for a key in the JObject and returns the value as a string
    /// Example: get value of "password" from the JObject
    /// do a  .getValue("password")  and it will return the value of the key "password"
    /// log error if it fails,and exit the program
    /// </summary>
    /// <param name="key">the Key from Key Value Pairs</param>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public string? getValue(string key)
    {
        if (_json == null) throw new NullReferenceException("Can not read from a null entity");
        try
        {
            var result = _json[key]?.ToString();
            if (result != null) return result;
            if (result == null) throw new NullReferenceException("The result of reading the key was null");
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went Wrong when trying to read key: " + key + " from the JObject");
            Console.WriteLine(e.StackTrace);
            Environment.Exit(1);
        }
        return null;
    }



    public LocalFileReader(string path)
    {
        _path = path;
    }



}

