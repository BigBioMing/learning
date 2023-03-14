using DesignPatternDemo.ResponsibilityChainPattern.Concretes;
using DesignPatternDemo.ResponsibilityChainPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ResponsibilityChainPattern
{
    public class TestResponsibilityChainPattern
    {
        public static void Execute()
        {
            Concrete1Handler concrete1Handler = new Concrete1Handler();
            Concrete2Handler concrete2Handler = new Concrete2Handler();
            Concrete3Handler concrete3Handler = new Concrete3Handler();

            //设置继任者
            concrete1Handler.SetSuccessor(concrete2Handler);
            concrete2Handler.SetSuccessor(concrete3Handler);

            List<RequestNotes> requestNoteses = new List<RequestNotes>();
            for (int i = 0; i < 10; i++)
            {
                RequestNotes requestNotes = new RequestNotes()
                {
                    Requester = $"Requester_{i.ToString().PadLeft(3)}",
                    RequestContent = "请求内容",
                    RequestType = "请假",
                    RequestNumber = Random.Shared.Next(0, 30)
                };
                requestNoteses.Add(requestNotes);
            }


            foreach (RequestNotes requestNotes in requestNoteses)
            {
                concrete1Handler.HandleRequest(requestNotes);
            }
        }
    }
}
