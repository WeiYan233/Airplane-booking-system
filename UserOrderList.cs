/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/


/******************************************************** 

项目名称: 航班订票系统

模块名称: 用户订单链表生成类
 
描述:①用链表生成用户订单
     ②取消用户订单
 
********************************************************/

namespace 航班订票系统
{
    // “订单”
    public class UserOrder
    {
        // 航班号
        public string Id { get; set; }
        // 飞机型号
        public string Type { get; set; }
        // 出发城市
        public string Start_station { get; set; }
        // 到达城市
        public string End_station { get; set; }
        // 起飞时间
        public string Start_time { get; set; }
        // 降落时间
        public string End_time { get; set; }
        // 票价
        public int Price { get; set; }
        // 乘客身份证号码
        public string Passenger_id { get; set; }
        // 乘客姓名
        public string Passenger_name { get; set; }
        public UserOrder next;
    }
    // “用户订单链表”
    public class UserOrderList
    {
        public UserOrder head;
        // 构造一个空的用户订单链表
        public UserOrderList()
        {
            this.head = new UserOrder();
            this.head.next = null;
        }
        public UserOrder GetHead()
        {
            return this.head;
        }
        // 向链表中添加订单信息（新节点）
        public void AddUserOrder(UserOrder new_order)
        {
            if (this.head.next == null)
            {
                this.head.next = new_order;
                new_order.next = null;
            }
            else
            {

                UserOrder p = this.head;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = new_order;
            }
        }
        // 从链表中删除订单信息
        public void DeleteOrder(string passenger_id, string passenger_name, string plane_id)
        {
            UserOrder p = this.GetHead();
            while (p != null)
            {
                if (p.next.Id == plane_id && p.next.Passenger_id == passenger_id && p.next.Passenger_name == passenger_name)
                {
                    p.next = p.next.next;
                    break;
                }
                p = p.next;
            }
        }
    }
}
