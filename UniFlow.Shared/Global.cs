using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniFlow.Shared
{
    public class Global
    {
        public static readonly string BaseAddress = @"https://localhost:7290/"; // temp
        public static string? CurrentUser { get; set; } = null;

    }
}
