/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System;
using System.Windows.Forms;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 航班信息查询
 
描述:①用户登录系统后，进入此界面，显示出全部航班信息，
     用户可输入“出发城市”、“到达城市”来查询航班信息 
     ②用户可查询已经完成的订单
 
********************************************************/

namespace 航班订票系统
{
    // CommonUserForm：航班信息查询窗体
    public partial class CommonUserForm : Form
    {
        // 登录系统的用户名
        public string track_user;
        // 储存航班信息的链表
        private PlaneInfoList info_list;
        private readonly FileOpearte file;
        public CommonUserForm()
        {
            file = new FileOpearte();
            InitializeComponent();
        }
        private void CommonUserForm_Load(object sender, EventArgs e)
        {
            // 日历
            dateTimePicker.Value = DateTime.Now;
            this.info_list = new PlaneInfoList();
            // 读取航班信息文件中已有的航班数据至链表
            file.LoadInfoList(this.info_list, file.Info_file_path);
            PlaneInfo p = info_list.GetHead().next;
            // 将链表中的航班信息加载进界面
            this.DisplayDataByPointer(p);
        }
        // “预订”按钮
        private void display_box_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 通过单元格编号识别“预订”
            if (e.ColumnIndex == 8)
            {
                int index = e.RowIndex;
                // 弹出“机票预订”窗体并显示航班信息
                ReserveForm ser_form = new ReserveForm();
                ser_form.track_user = this.track_user;
                ser_form.plane_id = this.display_box.Rows[index].Cells[0].Value.ToString();
                ser_form.plane_type = this.display_box.Rows[index].Cells[1].Value.ToString();
                ser_form.start_station = this.display_box.Rows[index].Cells[2].Value.ToString();
                ser_form.end_station = this.display_box.Rows[index].Cells[3].Value.ToString();
                ser_form.start_time = this.display_box.Rows[index].Cells[4].Value.ToString();
                ser_form.end_time = this.display_box.Rows[index].Cells[5].Value.ToString();
                ser_form.plane_price = Convert.ToInt32(this.display_box.Rows[index].Cells[7].Value);
                ser_form.Owner = this;
                this.Hide();
                // 在订票完成后自动返回到此界面
                if (ser_form.ShowDialog() == DialogResult.OK)
                {
                    // 将窗体原航班信息清空 
                    this.display_box.Rows.Clear();
                    this.info_list = new PlaneInfoList();
                    // 重新读取航班信息文件中的航班数据至链表
                    file.LoadInfoList(this.info_list, file.Info_file_path);
                    PlaneInfo p = info_list.GetHead().next;
                    // 重新将链表中的航班信息加载进界面
                    this.DisplayDataByPointer(p);
                    this.Show();
                }
            }
        }
        // 将航班信息显示在DataGridView控件
        public void DisplayDataByPointer(PlaneInfo p)
        {
            while (p != null)
            {
                int index = this.display_box.Rows.Add();
                this.display_box.Rows[index].Cells[0].Value = p.Id;
                this.display_box.Rows[index].Cells[1].Value = p.Type;
                this.display_box.Rows[index].Cells[2].Value = p.Start_station;
                this.display_box.Rows[index].Cells[3].Value = p.End_station;
                this.display_box.Rows[index].Cells[4].Value = p.Start_time;
                this.display_box.Rows[index].Cells[5].Value = p.End_time;
                this.display_box.Rows[index].Cells[6].Value = p.Tickets;
                this.display_box.Rows[index].Cells[7].Value = p.Price;
                this.display_box.Rows[index].Cells[8].Value = "预订";
                p = p.next;
            }
        }
        // “搜索”按钮
        private void search_button_Click(object sender, EventArgs e)
        {
            this.info_list.DeleteList();
            this.info_list = new PlaneInfoList();
            // 从航班信息文件中读取航班数据添加到链表
            file.LoadInfoList(this.info_list, file.Info_file_path);
            string search_start = this.search_box_1.Text;
            string search_end = this.search_box_2.Text;
            PlaneInfoList search_list = new PlaneInfoList();
            PlaneInfo p = this.info_list.GetHead().next;
            while (p != null)
            {
                if (Regular.IsNull(search_start) || Regular.IsNull(search_end))
                {
                    MessageBox.Show("搜索条件不能为空！");
                    return;
                }
                else if (!Regular.IsMatchChina(search_start) || !Regular.IsMatchChina(search_end))
                {
                    MessageBox.Show("搜索条件输入格式不正确");
                    return;
                }
                else if (p.Start_station.Contains(search_start) && p.End_station.Contains(search_end))
                {
                    // 将匹配的搜索结果添加到链表
                    search_list.AddInfo(CopyObject(p));
                }
                p = p.next;
            }
            if (search_list.head.next == null)
            {
                MessageBox.Show("搜索结果为空！");
            }
            else
            {
                // 将窗体原航班信息清空
                this.display_box.Rows.Clear();
                // 将搜索结果链表中的航班信息加载进界面
                this.DisplayDataByPointer(search_list.head.next);
            }
        }
        // 获得符合乘客搜索的航班信息链表
        public PlaneInfo CopyObject(PlaneInfo p)
        {
            PlaneInfo new_info = new PlaneInfo();
            new_info.Id = p.Id;
            new_info.Type = p.Type;
            new_info.Start_station = p.Start_station;
            new_info.End_station = p.End_station;
            new_info.Start_time = p.Start_time;
            new_info.End_time = p.End_time;
            new_info.Tickets = p.Tickets;
            new_info.Price = p.Price;
            new_info.next = null;
            return new_info;
        }
        // “我的订单”按钮
        private void my_order_label_Click(object sender, EventArgs e)
        {
            MyOrderForm mor_form = new MyOrderForm();
            mor_form.track_user = this.track_user;
            mor_form.Owner = this;
            this.Hide();
            if (mor_form.ShowDialog() == DialogResult.OK)
            {
                // 将窗体原航班信息清空 
                this.display_box.Rows.Clear();
                info_list = new PlaneInfoList();
                // 重新读取航班信息文件中的航班数据至链表
                file.LoadInfoList(info_list, file.Info_file_path);
                // 重新将链表中的航班信息加载进界面
                this.DisplayDataByPointer(info_list.head.next);
                this.Show();
            }
        }
        // “返回”按钮
        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }
    }
}
