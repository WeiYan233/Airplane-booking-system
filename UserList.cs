/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/


/******************************************************** 

项目名称: 航班订票系统

模块名称: 用户链表生成类
 
描述:生成用户信息（添加新用户）
 
********************************************************/

namespace 航班订票系统
{
    // “用户”
    public class User
    {
        // 用户名
        public string Name { get; set; }
        // 密码
        public string Pwd { get; set; }
        public User next;
    }

    // “用户信息链表”
    public class UserList
    {
        private User head;
        // 构造一个空的用户信息链表
        public UserList()
        {
            this.head = new User();
            this.head.Name = null;
            this.head.Pwd = null;
            this.head.next = null;
        }
        // 获取链表的头节点
        public User GetHead()
        {
            return this.head;
        }
        // 向链表中添加用户数据（新节点）
        public void AddUser(User new_user)
        {
            User p = this.head;
            if (p.next == null)
            {
                p.next = new_user;
                new_user.next = null;
            }
            else
            {
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = new_user;
            }
        }
        // 判断用户名是否已经存在
        public bool IsUserExist(string check_name)
        {
            User p = this.head;
            while (p != null)
            {
                if (p.Name == check_name)
                {
                    return true;
                }
                p = p.next;
            }
            return false;
        }
        // 判断用户名和密码是否正确
        public bool IsUserTrue(string check_name, string check_pwd)
        {
            User p = this.head;
            while (p != null)
            {
                if (p.Name == check_name && p.Pwd == check_pwd)
                {
                    return true;
                }
                p = p.next;
            }
            return false;
        }
        // 使链表的头节点引用为空
        public void DeleteList()
        {
            this.head = null;
        }
    }
}
