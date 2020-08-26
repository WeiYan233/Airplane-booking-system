/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System;
using System.Windows.Forms;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 航班信息修改
 
描述:管理员登录后，进入此界面，可在此界面直接修改航班信息
 
********************************************************/

namespace 航班订票系统
{
    // AdminUserForm：管理员修改航班信息窗体
    public partial class AdminUserForm : Form
    {
        private int after_row_index;
        private readonly FileOpearte file;
        public AdminUserForm()
        {
            file = new FileOpearte();
            InitializeComponent();
        }
        private void AdminUserForm_Load(object sender, EventArgs e)
        {
            PlaneInfoList info_list = new PlaneInfoList();
            // 从航班信息文件中读取航班数据添加到链表
            file.LoadInfoList(info_list, file.Info_file_path);
            // 将链表中的航班信息加载到界面
            this.DisplayDataByPointer(info_list.head.next);

        }
        // “退出系统”按钮
        private void exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定要退出系统吗", "提示", MessageBoxButtons.YesNo))
            {
                Environment.Exit(0);
            }
        }
        // “增加航班信息”按钮
        private void add_info_button_Click(object sender, EventArgs e)
        {
            AddInfoForm new_form = new AddInfoForm();
            new_form.Owner = this;
            this.Hide();
            // 在点击后“返回”后返回此界面
            if (new_form.ShowDialog() == DialogResult.OK)
            {
                // 将窗体原航班信息清空
                this.display_box.Rows.Clear();
                this.Show();
                PlaneInfoList info_list = new PlaneInfoList();
                // 从航班信息文件中读取航班数据添加到链表
                file.LoadInfoList(info_list, file.Info_file_path);
                // 重新将链表中的航班信息加载进界面
                this.DisplayDataByPointer(info_list.head.next);
            }
        }
        // 将航班信息显示在DataGridView控件
        public void DisplayDataByPointer(PlaneInfo p)
        {
            while (p != null)
            {
                int index_a = this.display_box.Rows.Add();
                this.display_box.Rows[index_a].Cells[0].Value = p.Id;
                this.display_box.Rows[index_a].Cells[1].Value = p.Type;
                this.display_box.Rows[index_a].Cells[2].Value = p.Start_station;
                this.display_box.Rows[index_a].Cells[3].Value = p.End_station;
                this.display_box.Rows[index_a].Cells[4].Value = p.Start_time;
                this.display_box.Rows[index_a].Cells[5].Value = p.End_time;
                this.display_box.Rows[index_a].Cells[6].Value = p.Tickets;
                this.display_box.Rows[index_a].Cells[7].Value = p.Price;
                this.display_box.Rows[index_a].Cells[8].Value = "编辑";
                this.display_box.Rows[index_a].Cells[9].Value = "删除";
                p = p.next;
            }
        }
        // “删除”与“编辑”按钮
        private void display_box_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 通过单元格编号识别“编辑”
            if (e.ColumnIndex == 8)
            {
                after_row_index = e.RowIndex;
                // 取消只读
                this.display_box.ReadOnly = false;
                int num = after_row_index + 1;
                MessageBox.Show("请直接编辑第" + num.ToString() + "行中的数据");
                // “增加航班信息”按钮不可见
                add_info_button.Visible = false;
                save_button.Visible = true;
                cancel_save_button.Visible = true;
            }
            // 通过单元格编号识别“删除”
            else if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string delete_id = this.display_box.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string delete_type = this.display_box.Rows[e.RowIndex].Cells[1].Value.ToString();
                    PlaneInfoList info_list = new PlaneInfoList();
                    // 从航班信息文件中读取航班数据添加到链表
                    file.LoadInfoList(info_list, file.Info_file_path);
                    // 从链表中删除航班数据生成新链表
                    info_list.DeleteInfo(delete_id, delete_type);
                    MessageBox.Show("删除航班信息成功！");
                    // 将新链表中的航班数据写入航班信息文件
                    file.SaveInfoList(info_list, file.Info_file_path);
                    // 将窗体原航班信息清空
                    this.display_box.Rows.Clear();
                    // 重新将链表中的航班信息加载进界面
                    this.DisplayDataByPointer(info_list.head.next);
                }
            }

        }
        // “保存修改”按钮
        private void save_button_Click(object sender, EventArgs e)
        {
            PlaneInfoList info_list = new PlaneInfoList();
            // 从航班信息文件中读取航班数据添加到链表
            file.LoadInfoList(info_list, file.Info_file_path);
            PlaneInfo p = info_list.GetHead().next;
            int tick = 0;
            while (p != null)
            {
                // 找到被修改的数据的行号
                if (after_row_index == tick)
                {
                    // 将修改后的数据写入链表
                    p.Id = this.display_box.Rows[after_row_index].Cells[0].Value.ToString();
                    p.Type = this.display_box.Rows[after_row_index].Cells[1].Value.ToString();
                    p.Start_station = this.display_box.Rows[after_row_index].Cells[2].Value.ToString();
                    p.End_station = this.display_box.Rows[after_row_index].Cells[3].Value.ToString();
                    p.Start_time = this.display_box.Rows[after_row_index].Cells[4].Value.ToString();
                    p.End_time = this.display_box.Rows[after_row_index].Cells[5].Value.ToString();
                    p.Tickets = Convert.ToInt32(this.display_box.Rows[after_row_index].Cells[6].Value);
                    p.Price = Convert.ToInt32(this.display_box.Rows[after_row_index].Cells[7].Value);
                }
                tick++;
                p = p.next;
            }
            // 将链表中的航班数据写入航班信息文件
            file.SaveInfoList(info_list, file.Info_file_path);
            MessageBox.Show("保存修改成功");
            // 恢复只读
            this.display_box.ReadOnly = true;
            save_button.Visible = false;
            cancel_save_button.Visible = false;
            add_info_button.Visible = true;
        }
        // “放弃修改”按钮
        private void cancel_save_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认放弃修改吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cancel_save_button.Visible = false;
                save_button.Visible = false;
                add_info_button.Visible = true;
            }
            // 恢复只读
            this.display_box.ReadOnly = true;
            PlaneInfoList list = new PlaneInfoList();
            // 从航班信息文件中读取航班数据添加到链表
            file.LoadInfoList(list, file.Info_file_path);
            // 将窗体原航班信息清空
            this.display_box.Rows.Clear();
            // 重新将链表中的航班信息加载进界面
            this.DisplayDataByPointer(list.head.next);
        }
        // “返回”按钮
        private void return_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            this.Close();
        }
    }
}
