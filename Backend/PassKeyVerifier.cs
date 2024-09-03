using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Backend;

public class PassKeyVerifier(LocalFileReader reader)
{
    private readonly LocalFileReader _reader = reader;

    /// <summary>
    /// Reads from local file and compares the given passKey to the one in the File
    /// </summary>
    /// <param name="passKey"></param>
    /// <returns></returns>
    /// <exception cref="FileLoadException"></exception>
    /// <exception cref="NullReferenceException"></exception>
    public bool VerifyAdminPassKey(string passKey)
    {
        if (_reader.ReadJsonFile() == null)
        {
            throw new FileLoadException();
        }

        string? passKeyFromJson = _reader.GetValue<string>("api-admin-passkey");
        if (passKeyFromJson == null) throw new NullReferenceException();

        return passKey == passKeyFromJson;
    }

    public bool RequestIsAdmin(HttpContext context)
    {
        if (context.Items.TryGetValue("Admin", out var isAdmin))
        {
            return isAdmin is bool && (bool)isAdmin;
        }
        return false;
    }
}

