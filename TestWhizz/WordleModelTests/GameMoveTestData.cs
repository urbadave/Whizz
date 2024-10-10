using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestWhizz.WordleModelTests;
internal static class GameMoveTestData
{
    public static string model1Json = @"{
    ""gameId"": ""c0433f3f-2435-4e99-80d2-71060a7fde69"",
    ""moveNumber"": 0,
    ""ruledOut"": [""N"", ""S""],
    ""correct"": ["" "", ""A"", "" "", "" "", "" ""],
    ""incorrect"": [[], [], [], [""E""], [""R""]]
    }";

    public static string model2Json = @"{
    ""gameId"": ""c0433f3f-2435-4e99-80d2-71060a7fde69"",
    ""moveNumber"": 1,
    ""ruledOut"": [""L"", ""Y""],
    ""correct"": ["" "", ""A"", ""R"", "" "", "" ""],
    ""incorrect"": [[""E""], [], [], [], []]
    }";

    public static string model3Json = @"{
    ""gameId"": ""c0433f3f-2435-4e99-80d2-71060a7fde69"",
    ""moveNumber"": 2,
    ""ruledOut"": [""B"", ""G""],
    ""correct"": ["" "", ""A"", ""R"", "" "", ""E""],
    ""incorrect"": [[], [], [], [], []]
    }";

    public static string model4Json = @"{
    ""gameId"": ""c0433f3f-2435-4e99-80d2-71060a7fde69"",
    ""moveNumber"": 3,
    ""ruledOut"": [""F""],
    ""correct"": ["" "", ""A"", ""R"", "" "", ""E""],
    ""incorrect"": [[], [], [], [""C""], []]
    }";
}
