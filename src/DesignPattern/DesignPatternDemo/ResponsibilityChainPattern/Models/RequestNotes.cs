using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ResponsibilityChainPattern.Models
{
    /// <summary>
    /// 请求单
    /// </summary>
    public class RequestNotes
    {
        /// <summary>
        /// 请求人
        /// </summary>
        public string Requester { get; set; } = null!;
        /// <summary>
        /// 请求类型
        /// </summary>
        public string RequestType { get; set; } = null!;
        /// <summary>
        /// 请求内容
        /// </summary>
        public string RequestContent { get; set; } = null!;
        /// <summary>
        /// 请求数量
        /// </summary>
        public int RequestNumber { get; set; }
    }
}
