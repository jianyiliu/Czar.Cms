using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01.Models
{
    /// <summary>
    /// 2018.1.15
    /// 刘建沂
    /// 内容实体
    /// </summary>
    public class Content
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Contents { get; set; }

        public int Stauts { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime ModifyTime { get; set; }

    }
}
