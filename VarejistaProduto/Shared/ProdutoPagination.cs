using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejistaProduto.Shared
{
    public class ProdutoPagination
    {
        public int TotalCount { get; set; }
        public List<Produto> Data { get; set; }
    }
}
