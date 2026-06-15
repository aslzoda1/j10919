using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("💎 Aslzoda Bozorboyeva - .NET C# Advanced Core Blueprint");
        RunLinqQuery();
        ManageDictionary();
        ExecutePatternMatching("Android Architecture");
    }

    static void RunLinqQuery() {
        List<int> secureTokens = new List<int> { 204, 401, 404, 500, 201 };
        var successCodes = secureTokens.Where(code => code < 300).ToList();
        Console.WriteLine($"✅ HTTP Success Code count tracked: {successCodes.Count}");
    }

    static void ManageDictionary() {
        var config = new Dictionary<string, string> {
            {"Environment", "Production"},
            {"Encryption", "AES_256"}
        };
        Console.WriteLine($"🛡️ System Encryption Mode: {config["Encryption"]}");
    }

    static void ExecutePatternMatching(object input) {
        if (input is string text) {
            Console.WriteLine($"🔤 Parsed text length evaluation: {text.Length} symbols.");
        }
    }
}