using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop_.NET_6.AppData
{
    public static class ControllerProduct
    {
        public static int Id { get; set; }

        public static string Name { get; set; } = null!;

        public static decimal Cost { get; set; }

        public static string? Description { get; set; }

        public static string? Image { get; set; }
    }
}
