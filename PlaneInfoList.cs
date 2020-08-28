/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/


/******************************************************** 

项目名称: 航班订票系统

模块名称: 航班信息链表生产类
 
描述:生成航班信息
 
********************************************************/

namespace 航班订票系统
{
    // “航班”
    public class PlaneInfo
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
        // 剩余票数
        public int Tickets { get; set; }
        // 票价
        public int Price { get; set; }
        public PlaneInfo next;

    }

    // “航班信息链表”
    public class PlaneInfoList
    {
        public PlaneInfo head;
        // 构造一个空的航班信息链表
        public PlaneInfoList()
        {
            this.head = new PlaneInfo();
            this.head.Id = null;
            this.head.Type = null;
            this.head.Start_station = null;
            this.head.End_station = null;
            this.head.next = null;
        }
        // 获取链表的头节点
        public PlaneInfo GetHead()
        {
            return this.head;
        }
        // 通过航班号与起飞降落时间判断航班是否已经存在
        public bool IsIdExist(string search_id, string search_stime, string search_etime)
        {
            PlaneInfo p = this.head;
            while (p != null)
            {
                if (p.Id == search_id && (p.Start_time == search_stime || p.End_time == search_etime))
                {
                    return true;
                }
                p = p.next;
            }
            return false;
        }
        // 向链表中添加航班数据（新节点）
        public void AddInfo(PlaneInfo new_info)
        {
            if (this.head.next == null)
            {
                this.head.next = new_info;
                new_info.next = null;
            }
            else
            {
                PlaneInfo p = this.head;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = new_info;
                new_info.next = null;
            }
        }
        // 从链表中删除航班数据（只需核对航班号、飞机型号）
        public void DeleteInfo(string id, string type)
        {
            PlaneInfo p = this.head;
            while (p != null)
            {
                if (p.next.Id == id && p.next.Type == type)
                {
                    p.next = p.next.next;
                    break;
                }
                p = p.next;
            }
        }
        // 使链表的头节点引用为空
        public void DeleteList()
        {
            this.head = null;
        }
    }
}
