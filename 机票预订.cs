/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System;
using System.Windows.Forms;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 机票预订
 
描述:①用户选中要预定的航班后，该界面会显示出航班信息
     ②用户填写“姓名”、“身份证号码”完成订单
 
********************************************************/

namespace 航班订票系统
{
    // ReserveForm:机票预订窗体
    public partial class ReserveForm : Form
    {
        // 登录系统的用户名
        public string track_user;
        // 航班号
        public string plane_id;
        // 飞机型号
        public string plane_type;
        // 出发城市
        public string start_station;
        // 到达城市
        public string end_station;
        // 起飞时间
        public string start_time;
        // 降落时间
        public string end_time;
        // 票价
        public int plane_price;

        public UserOrderList order_list;
        // ReserveForm：机票预订（生成订单）窗体
        public ReserveForm()
        {
            InitializeComponent();
        }
        private void ReserveForm_Load(object sender, EventArgs e)
        {
            this.order_list = new UserOrderList();
            // 显示用户预订机票的信息
            this.message_label.Text = "航班信息:\n航班号:" + this.plane_id + "\n飞机型号:" + this.plane_type + "\n出发城市:" + this.start_station + "\n到达城市:" + this.end_station + "\n起飞时间:" + this.start_time + "\n降落时间:" + this.end_time + "\n票价:" + this.plane_price;
        }
        // “确认预订”按钮
        private void sure_button_Click(object sender, EventArgs e)
        {
            if (Regular.IsNull(name_box.Text) || Regular.IsNull(id_box.Text))
            {
                MessageBox.Show("姓名或身份证号码不能为空！");
                return;
            }
            else if (Regular.IsNull(name_box.Text) || Regular.IsNull(id_box.Text))
            {
                MessageBox.Show("乘客信息必填！");
                return;
            }
            else if (!Regular.IsMatchPersonId(id_box.Text))
            {
                MessageBox.Show("乘客身份证ID格式不正确！");
                return;
            }
            else
            {
                FileOpearte file = new FileOpearte();
                // 读取用户订单文件中已有的用户订单信息至链表，如果文件不存在则只新建文件
                file.LoadOrderList(this.order_list, "../../../航班订票系统数据/订单/" + this.track_user + ".txt");
                UserOrder new_order = new UserOrder();
                new_order.Id = this.plane_id;
                new_order.Type = this.plane_type;
                new_order.Start_station = this.start_station;
                new_order.End_station = this.end_station;
                new_order.Start_time = this.start_time;
                new_order.End_time = this.end_time;
                new_order.Price = this.plane_price;
                new_order.Passenger_id = id_box.Text;
                new_order.Passenger_name = name_box.Text;
                // 将新订单信息加入到链表生成新链表
                this.order_list.AddUserOrder(new_order);
                // 将新链表中的数据写入用户订单文件
                file.SaveUserOrderList(this.order_list, "../../../航班订票系统数据/订单/" + this.track_user + ".txt");
                PlaneInfoList change_list = new PlaneInfoList();
                // 读取航班信息文件中已有的航班信息至链表
                file.LoadInfoList(change_list, file.Info_file_path);
                // 减少用户选定的航班的票数
                PlaneInfo p = change_list.GetHead();
                while (p != null)
                {
                    p = p.next;
                    if (p.Id == this.plane_id)
                    {
                        p.Tickets--;
                        break;
                    }
                }
                // 将新链表中的数据写入航班信息文件
                file.SaveInfoList(change_list, file.Info_file_path);
                change_list.DeleteList();
                MessageBox.Show("预订成功！");
                // 返回值
                this.DialogResult = DialogResult.OK;
                this.Hide();
                this.Close();
            }
        }
        // “取消”按钮
        private void quit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }
    }
}
