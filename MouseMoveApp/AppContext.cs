using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseMoveApp
{
    internal class AppContext : DbContext
    {
        public DbSet<ListInfo> MouseMoves { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
