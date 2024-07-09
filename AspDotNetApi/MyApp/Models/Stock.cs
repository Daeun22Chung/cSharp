using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace MyApp.Models
{
    public class Stock
    {
         public int Id { get; set;}
        public string Symbol {get; set;} = string.Empty;  // 속성이 null이 아닌 상태에서 시작을 명확
        public string CompanyName {get; set;} = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase {get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv {get; set;}  
        public string Industry {get; set;} = string.Empty;
        public long MarketCap {get; set;}
        public List<Comment> Comments {get; set;} = new List<Comment>();   // 하나의 게시물에는 여러 개의 댓글
    }
}