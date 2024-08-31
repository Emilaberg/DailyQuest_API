using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shared;

public class PassKeyVerifier(LocalFileReader reader)
{
    private readonly LocalFileReader _reader;


    public bool VerifyPassKey(string passKey)
    {
        if (_reader.ReadJsonFile() == null)
        {
            throw new FileLoadException();
        }

        string? passKeyFromJson = _reader.GetValue<string>("PassKey");
        if (passKeyFromJson == null) throw new NullReferenceException();

        return passKey == passKeyFromJson;
    }
}

