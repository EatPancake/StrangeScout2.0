using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace StrangeScout.Views
{
    public class Index : PageModel
    {
        public int add()
        {
            return 1+1;
        }
    }
}