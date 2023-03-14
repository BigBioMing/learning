using DesignPatternDemo.ResponsibilityChainPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ResponsibilityChainPattern.Abstractions
{
    /// <summary>
    /// 业务处理类
    /// </summary>
    public abstract class Handler
    {
        /// <summary>
        /// 下个处理者
        /// </summary>
        protected Handler? Successor;

        /// <summary>
        /// 设置下个处理者
        /// </summary>
        /// <param name="successor"></param>
        public void SetSuccessor(Handler successor) { Successor = successor; }

        /// <summary>
        /// 处理请求
        /// </summary>
        /// <param name="requestNotes"></param>
        public abstract void HandleRequest(RequestNotes requestNotes);

    }
}
