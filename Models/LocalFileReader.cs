using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Shared;

/// <summary>
/// A class that reads a JSON file from a local path and parses it into a JObject
/// Has methods to get, create, update, and remove values from the JObject
/// </summary>
public class LocalFileReader
{
    #region PrivateVariables

    private readonly string _path;
    private readonly string _tempFilePath;
    private JObject? _json;

    #endregion



    #region Properties

    public JObject? Json
    {
        get => _json;
        private set => throw new AccessViolationException("Not Allowed to set the Json variable");
    }

    #endregion



    #region Methods

    /// <summary>
    /// Reads the JSON file from the _credentialsPath and parses it into a JObject
    /// If anything fails it logs the error and exits the program
    /// </summary>
    public bool? ReadJsonFile()
    {
        try { if (!File.Exists(_path)) throw new FileNotFoundException(); }
        catch (Exception e)
        {
            Console.WriteLine("There was no file found at the given location: " + _path);
            Console.WriteLine(e.StackTrace);
            return null;
        }

        string? rawJson = null;
        try
        {
            rawJson = File.ReadAllText(_path);
            if (rawJson == null) throw new NullReferenceException();
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong when ");
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
    /// Searches for a key in the JObject and returns the value as an object
    /// </summary>
    /// <param name="key">The key from key-value pairs</param>
    /// <returns>The value as an object</returns>
    public T? GetValue<T>(string key)
    {
        if (_json == null) return default;
        try
        {
            var token = _json[key];
            if (token == null) return default;

            return token.ToObject<T>();
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong when trying to read key: " + key + " from the JObject");
            Console.WriteLine(e.StackTrace);
        }
        return default;
    }

    /// <summary>
    /// Creates a new key-value pair in the JObject
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    public T? CreateNewValue<T>(string key, T value)
    {
        if (_json == null) return default;
        if (value == null) return default;
        try
        {
            _json[key] = JToken.FromObject(value);
            SaveJsonFile();
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong when trying to create key: " + key + " in the JObject");
            Console.WriteLine(e.StackTrace);
            return default;
        }
        return GetValue<T>(key);
    }

    /// <summary>
    /// Removes a key-value pair from the JObject
    /// </summary>
    /// <param name="key">The key</param>
    public void RemoveValue(string key)
    {
        if (_json == null) return;
        try
        {
            _json.Remove(key);
            SaveJsonFile();
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong when trying to remove key: " + key + " from the JObject");
            Console.WriteLine(e.StackTrace);
        }
    }

    /// <summary>
    /// Updates the value of an existing key in the JObject
    /// Returns the value before the update and the value after the update
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="newValue">The new value</param>
    /// <returns>A tuple containing the value before the update and the value after the update</returns>
    public (T? Before, T? After) UpdateValue<T>(string key, T newValue)
    {
        if (_json == null) return (default, default);
        if (newValue == null) return (default, default);

        T? beforeValue = GetValue<T>(key);

        try
        {
            _json[key] = JToken.FromObject(newValue);
            SaveJsonFile();
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong when trying to update key: " + key + " in the JObject");
            Console.WriteLine(e.StackTrace);
            return (beforeValue, default);
        }

        T? afterValue = GetValue<T>(key);
        return (beforeValue, afterValue);
    }


    #endregion

    #region Private Methods

    private string GetFullPath(string relativePath)
    {
        return Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), relativePath));
    }

    /// <summary>
    /// Saves the current state of the JObject back to the JSON file
    /// </summary>
    private void SaveJsonFile()
    {
        try
        {
            File.WriteAllText(_path, _json?.ToString(Formatting.Indented));
        }
        catch (Exception e)
        {
            Console.WriteLine("Could not save the JSON file");
            Console.WriteLine(e.StackTrace);
        }
    }

    #endregion



    //-------------------- ONLY Constructors below this --------------------

    /// <summary>
    /// This constructor takes in a RELATIVE path to a JSON file, and a relative path to a temp file
    /// If there is no temp file, it will create one
    /// </summary>
    /// <param name="credentailsPath"></param>
    /// <param name="tempFilePath"></param>
    public LocalFileReader(string credentailsPath = "./ProgramProperties.json", string tempFilePath = "./TempFile.json")
    {
        _path = GetFullPath(credentailsPath);
        Console.WriteLine("The credentailsPath: " + _path);

        if (!File.Exists(GetFullPath(tempFilePath)))
        {
            File.Create(GetFullPath(tempFilePath)).Close();
        }
        _tempFilePath = GetFullPath(tempFilePath);
    }
}
