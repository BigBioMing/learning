using 领域事件01.Domains;
using 领域事件01.Notifications;

namespace 领域事件01.Entities
{
    public class UserInfo : DomainEvents
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        //给EFCore用的无参私有的构造函数
        private UserInfo()
        {

        }
        public UserInfo(string name, string pwd)
        {
            this.Name = name;
            this.Password = pwd;
            AddDomainEvents(new MessageNotification() { Message = "userinfo created" });
        }

        public bool ModifyPassword(string newPassword)
        {
            if ((this.Password?.Equals(newPassword) == true))
            {
                return false;
            }

            this.Password = newPassword;
            AddDomainEvents(new MessageNotification() { Message = "userinfo password modified" });
            return true;
        }
    }
}
