/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System;
using System.Windows.Forms;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 显示我的订单
 
描述:①用户可在此界面查询全部已完成的订单
     ②用户可根据自己的需要退订订单
 
********************************************************/

namespace 航班订票系统
{
    // MyOrderForm：订单查询窗体
    public partial class MyOrderForm : Form
    {
        // 储存登录系统的用户名
        public string track_user;
        // 储存订单信息的链表
        private UserOrderList order_list;
        private readonly FileOpearte file;
        public MyOrderForm()
        {
            file = new FileOpearte();
            InitializeComponent();
        }
        private void MyOrderForm_Load(object sender, EventArgs e)
        {
            this.user_label.Text = "登录名：" + this.track_user;
            this.order_list = new UserOrderList();
            // 读取用户订单文件中已有的用户订单信息至链表，如果文件不存在则只新建用户订单文件
            file.LoadOrderList(order_list, "../../../航班订票系统数据/订单/" + this.track_user + ".txt");//加载订单数据
            this.DisplayDataByPointer(order_list.head.next);
        }
        // “退订”按钮
        private void display_box_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 通过单元格编号识别“退订”
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("确认退订吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string delete_plane_id = this.display_box.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string delete_passenger_id = this.display_box.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string delete_passenger_name = this.display_box.Rows[e.RowIndex].Cells[0].Value.ToString();
                    // 从链表中删除用户退订的订单信息生成新链表
                    this.order_list.DeleteOrder(delete_passenger_id, delete_passenger_name, delete_plane_id);
                    MessageBox.Show("退订成功！");
                    // 将新链表中的数据写入订单文件
                    file.SaveUserOrderList(this.order_list, "../../../航班订票系统数据/订单/" + this.track_user + ".txt");
                    PlaneInfoList info_list = new PlaneInfoList();
                    // 读取航班信息文件中已有的航班信息至链表
                    file.LoadInfoList(info_list, file.Info_file_path);
                    // 增加用户选定的航班的票数
                    PlaneInfo p = info_list.GetHead().next;
                    while (p != null)
                    {
                        if (p.Id == delete_plane_id)
                        {
                            p.Tickets++;
                            break;
                        }
                        p = p.next;
                    }
                    // 将新链表中的数据写入航班信息文件
                    file.SaveInfoList(info_list, file.Info_file_path);
                    // 将窗体原订单信息清除 
                    this.display_box.Rows.Clear();
                    // 重新将链表中的订单信息加载进界面
                    this.DisplayDataByPointer(this.order_list.head.next);
                }
            }
        }
        // 将订单信息显示在DataGridView控件
        public void DisplayDataByPointer(UserOrder p)
        {
            while (p != null)
            {
                int index = this.display_box.Rows.Add();
                this.display_box.Rows[index].Cells[0].Value = p.Passenger_name;
                this.display_box.Rows[index].Cells[1].Value = p.Passenger_id;
                this.display_box.Rows[index].Cells[2].Value = p.Id;
                this.display_box.Rows[index].Cells[3].Value = p.Type;
                this.display_box.Rows[index].Cells[4].Value = p.Start_station;
                this.display_box.Rows[index].Cells[5].Value = p.End_station;
                this.display_box.Rows[index].Cells[6].Value = p.Start_time;
                this.display_box.Rows[index].Cells[7].Value = p.End_time;
                this.display_box.Rows[index].Cells[8].Value = "退订";
                p = p.next;
            }
        }
        // “退出系统”按钮
        private void exit_button_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定要退出吗", "提示", MessageBoxButtons.YesNo))
            {
                Environment.Exit(0);
            }
        }
        // “返回订票界面”按钮
        private void return_button_Click(object sender, EventArgs e)
        {
            // 返回值
            this.DialogResult = DialogResult.OK;
            this.Hide();
            this.Close();
            this.Owner.Show();
        }
    }
}
