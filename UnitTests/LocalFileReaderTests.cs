using Newtonsoft.Json.Linq;
using Shared;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace UnitTests;

/// <summary>
/// Tests for the LocalFileReader class
/// DISCLAIMER: most output.WriteLine() are made by AI
/// </summary>
public class LocalFileReaderTests(ITestOutputHelper output)
{
    private const string TestJsonPath = "./TestProgramProperties.json";
    private const string TestTempPath = "./TestTempFile.json";
    private readonly ITestOutputHelper _output = output;



    private void CreateTestJsonFile(string content)
    {
        File.WriteAllText(TestJsonPath, content);
    }

    private void DeleteTestFiles()
    {
        if (File.Exists(TestJsonPath)) File.Delete(TestJsonPath);
        if (File.Exists(TestTempPath)) File.Delete(TestTempPath);
    }

    [Fact]
    public void ReadJsonFile_FileExists_ReturnsTrue()
    {
        _output.WriteLine("Creating a test JSON file with a valid JSON content.");
        CreateTestJsonFile("{\"key\":\"value\"}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        _output.WriteLine("Reading the JSON file.");
        var result = reader.ReadJsonFile();
        _output.WriteLine("Asserting that the file was read successfully.");
        Assert.True(result);
        DeleteTestFiles();
    }

    [Fact]
    public void ReadJsonFile_FileDoesNotExist_ReturnsNull()
    {
        _output.WriteLine("Attempting to read a JSON file that does not exist.");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        var result = reader.ReadJsonFile();
        _output.WriteLine("Asserting that the result is null since the file does not exist.");
        Assert.Null(result);
    }

    [Fact]
    public void ReadJsonFile_InvalidJson_ReturnsNull()
    {
        _output.WriteLine("Creating a test JSON file with invalid JSON content.");
        CreateTestJsonFile("{invalid json}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        _output.WriteLine("Attempting to read the invalid JSON file.");
        var result = reader.ReadJsonFile();
        _output.WriteLine("Asserting that the result is null due to invalid JSON content.");
        Assert.Null(result);
        DeleteTestFiles();
    }

    [Fact]
    public void GetValue_KeyExists_ReturnsValue()
    {
        _output.WriteLine("Creating a test JSON file with a key-value pair.");
        CreateTestJsonFile("{\"key\":\"value\"}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Retrieving the value for the existing key.");
        var value = reader.GetValue<string>("key");
        _output.WriteLine("Asserting that the retrieved value matches the expected value.");
        Assert.Equal("value", value);
        DeleteTestFiles();
    }

    [Fact]
    public void GetValue_KeyDoesNotExist_ReturnsDefault()
    {
        _output.WriteLine("Creating a test JSON file with a key-value pair.");
        CreateTestJsonFile("{\"key\":\"value\"}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Attempting to retrieve the value for a non-existent key.");
        var value = reader.GetValue<string>("nonexistent");
        _output.WriteLine("Asserting that the retrieved value is null since the key does not exist.");
        Assert.Null(value);
        DeleteTestFiles();
    }

    [Fact]
    public void CreateNewValue_ValidKeyAndValue_CreatesValue()
    {
        _output.WriteLine("Creating an empty test JSON file.");
        CreateTestJsonFile("{}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Creating a new key-value pair in the JSON file.");
        var value = reader.CreateNewValue("newKey", "newValue");
        _output.WriteLine("Asserting that the new value was created successfully.");
        Assert.Equal("newValue", value);
        DeleteTestFiles();
    }

    [Fact]
    public void CreateNewValue_NullValue_ReturnsDefault()
    {
        _output.WriteLine("Creating an empty test JSON file.");
        CreateTestJsonFile("{}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Attempting to create a new key with a null value.");
        var value = reader.CreateNewValue<string>("newKey", null);
        _output.WriteLine("Asserting that the result is null since the value provided was null.");
        Assert.Null(value);
        DeleteTestFiles();
    }

    [Fact]
    public void RemoveValue_ValidKey_RemovesValue()
    {
        _output.WriteLine("Creating a test JSON file with a key-value pair.");
        CreateTestJsonFile("{\"key\":\"value\"}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Removing the existing key from the JSON file.");
        reader.RemoveValue("key");
        _output.WriteLine("Asserting that the key was removed successfully.");
        var value = reader.GetValue<string>("key");
        Assert.Null(value);
        DeleteTestFiles();
    }

    [Fact]
    public void RemoveValue_KeyDoesNotExist_DoesNothing()
    {
        _output.WriteLine("Creating a test JSON file with a key-value pair.");
        CreateTestJsonFile("{\"key\":\"value\"}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Attempting to remove a non-existent key from the JSON file.");
        reader.RemoveValue("nonexistent");
        _output.WriteLine("Asserting that the existing key-value pair remains unchanged.");
        var value = reader.GetValue<string>("key");
        Assert.Equal("value", value);
        DeleteTestFiles();
    }

    [Fact]
    public void UpdateValue_ValidKeyAndValue_UpdatesValue()
    {
        _output.WriteLine("Creating a test JSON file with a key-value pair.");
        CreateTestJsonFile("{\"key\":\"value\"}");
        LocalFileReader reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Updating the value for the existing key.");
        var (before, after) = reader.UpdateValue("key", "newValue");
        _output.WriteLine("Asserting that the value was updated successfully.");
        Assert.Equal("value", before);
        Assert.Equal("newValue", after);
        DeleteTestFiles();
    }

    [Fact]
    public void UpdateValue_KeyDoesNotExist_ReturnsDefault()
    {
        _output.WriteLine("Creating a test JSON file with a key-value pair.");
        CreateTestJsonFile("{\"key\":\"value\"}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Attempting to update a non-existent key in the JSON file.");
        var (before, after) = reader.UpdateValue("nonexistent", "newValue");
        _output.WriteLine("Asserting that the update operation returned default values since the key does not exist.");
        Assert.Null(before);
        Assert.Null(after);
        DeleteTestFiles();
    }

    [Fact]
    public void UpdateValue_NullValue_ReturnsDefault()
    {
        _output.WriteLine("Creating a test JSON file with a key-value pair.");
        CreateTestJsonFile("{\"key\":\"value\"}");
        var reader = new LocalFileReader(TestJsonPath, TestTempPath);
        reader.ReadJsonFile();
        _output.WriteLine("Attempting to update an existing key with a null value.");
        var (before, after) = reader.UpdateValue<string>("key", null);
        _output.WriteLine("Asserting that the update operation returned default values since the new value was null.");
        Assert.Equal(null, before);
        Assert.Null(after);
        DeleteTestFiles();
    }
}
