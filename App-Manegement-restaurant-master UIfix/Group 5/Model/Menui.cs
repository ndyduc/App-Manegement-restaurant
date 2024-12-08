using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_5.Model
{
    public class Menui
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Kind { get; set; }
        public string Description { get; set; }
        public string ImageCover { get; set; } // Đây là đường dẫn hoặc URL đến ảnh
    }
}
