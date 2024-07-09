using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Dtos
{
    public class StockDto
    {
        public int Id { get; set;}
        public string Symbol {get; set;} = string.Empty;  // 속성이 null이 아닌 상태에서 시작을 명확
        public string CompanyName {get; set;} = string.Empty;
        public decimal Purchase {get; set;}
        public decimal LastDiv {get; set;}  
        public string Industry {get; set;} = string.Empty;
        public long MarketCap {get; set;}
    }
}