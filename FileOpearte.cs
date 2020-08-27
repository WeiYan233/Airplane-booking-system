/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System;
using System.IO;
using System.Text;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 文件操作类
 
描述:对整个系统的全部文件进行操作
 
********************************************************/

namespace 航班订票系统
{
    // “文件操作”
    public class FileOpearte
    {
        private string _common_file_path = "../../../航班订票系统数据/用户.txt";
        private string _admin_file_path = "../../../航班订票系统数据/管理员.txt";
        private string _info_file_path = "../../../航班订票系统数据/航班信息.txt";

        // 用户信息文件路径
        public string Common_file_path { get { return _common_file_path; } }
        // 管理员信息文件路径
        public string Admin_file_path { get { return _admin_file_path; } }
        // 航班信息文件路径
        public string Info_file_path { get { return _info_file_path; } }

        // 从文件中读取用户数据添加到链表
        public UserList LoadUserList(UserList list, string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string nextline;
            while ((nextline = sr.ReadLine()) != null)
            {
                string[] arr = nextline.Split(' ');
                User new_user = new User();
                new_user.Name = arr[0];
                new_user.Pwd = arr[1];
                list.AddUser(new_user);
            }
            sr.Close();
            return list;
        }
        // 将链表中的用户数据写入文件
        public void SaveUserList(UserList list, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            User p = list.GetHead();
            p = p.next;
            while (p != null)
            {
                sw.Write(p.Name);
                sw.Write(" ");
                sw.Write(p.Pwd);
                sw.Write(Environment.NewLine);
                sw.Flush();
                p = p.next;
            }
            sw.Close();
            fs.Close();
        }
        // 从文件中读取航班数据添加到链表
        public PlaneInfoList LoadInfoList(PlaneInfoList list, string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string nextline;
            while ((nextline = sr.ReadLine()) != null)
            {
                string[] arr = nextline.Split(' ');
                PlaneInfo new_info = new PlaneInfo();
                new_info.Id = arr[0];
                new_info.Type = arr[1];
                new_info.Start_station = arr[2];
                new_info.End_station = arr[3];
                new_info.Start_time = arr[4];
                new_info.End_time = arr[5];
                new_info.Tickets = Convert.ToInt32(arr[6]);
                new_info.Price = Convert.ToInt32(arr[7]);
                list.AddInfo(new_info);
            }
            sr.Close();
            return list;
        }
        // 将链表中的航班数据写入文件
        public void SaveInfoList(PlaneInfoList list, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            PlaneInfo p = list.GetHead();
            p = p.next;
            while (p != null)
            {
                sw.Write(p.Id); sw.Write(" ");
                sw.Write(p.Type); sw.Write(" ");
                sw.Write(p.Start_station); sw.Write(" ");
                sw.Write(p.End_station); sw.Write(" ");
                sw.Write(p.Start_time); sw.Write(" ");
                sw.Write(p.End_time); sw.Write(" ");
                sw.Write(p.Tickets); sw.Write(" ");
                sw.Write(p.Price); sw.Write(" ");
                sw.Write(Environment.NewLine);
                sw.Flush();
                p = p.next;
            }
            sw.Close();
            fs.Close();
        }
        // 从文件中读取用户订单数据添加到链表，如果文件不存在则只新建文件
        public UserOrderList LoadOrderList(UserOrderList list, string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path, Encoding.Default);
                string nextline;
                while ((nextline = sr.ReadLine()) != null)
                {
                    string[] arr = nextline.Split(' ');
                    UserOrder new_order = new UserOrder();
                    new_order.Id = arr[0];
                    new_order.Type = arr[1];
                    new_order.Start_station = arr[2];
                    new_order.End_station = arr[3];
                    new_order.Start_time = arr[4];
                    new_order.End_time = arr[5];
                    new_order.Price = Convert.ToInt32(arr[6]);
                    new_order.Passenger_id = arr[7];
                    new_order.Passenger_name = arr[8];
                    list.AddUserOrder(new_order);
                }
                sr.Close();
                return list;
            }
            else
            {
                // 创建完新文件后关闭
                File.Create(path).Close();
                return list;
            }
        }
        // 将链表中的用户订单数据写入文件
        public void SaveUserOrderList(UserOrderList list, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            UserOrder p = list.GetHead();
            p = p.next;
            while (p != null)
            {
                sw.Write(p.Id); sw.Write(" ");
                sw.Write(p.Type); sw.Write(" ");
                sw.Write(p.Start_station); sw.Write(" ");
                sw.Write(p.End_station); sw.Write(" ");
                sw.Write(p.Start_time); sw.Write(" ");
                sw.Write(p.End_time); sw.Write(" ");
                sw.Write(p.Price); sw.Write(" ");
                sw.Write(p.Passenger_id); sw.Write(" ");
                sw.Write(p.Passenger_name);
                sw.Write(Environment.NewLine);
                sw.Flush();
                p = p.next;
            }
            sw.Close();
            fs.Close();
        }
    }
}
