/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System;
using System.Windows.Forms;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 航班信息增加
 
描述:管理员可在此界面为系统增加新的航班信息
 
********************************************************/

namespace 航班订票系统
{
    // AddInfoForm:增加航班信息窗体
    public partial class AddInfoForm : Form
    {
        public AddInfoForm()
        {
            InitializeComponent();
        }
        // “提交”按钮
        private void submit_button_Click(object sender, EventArgs e)
        {
            // 遍历所有文本框确保每一项都填写
            foreach (Control i in this.Controls)
            {
                if (i is TextBox)
                {
                    if (i.Text == "")
                    {
                        MessageBox.Show("以上均为必填项目！");
                        return;
                    }
                }
            }
            PlaneInfoList info_list = new PlaneInfoList();
            FileOpearte file = new FileOpearte();
            // 从航班信息文件中读取航班数据添加到链表
            file.LoadInfoList(info_list, file.Info_file_path);
            // 判断航班是否已经存在
            if (info_list.IsIdExist(id_box.Text, start_time_box.Text, end_time_box.Text))
            {
                MessageBox.Show("此航班已经存在！");
                return;
            }
            PlaneInfo new_info = new PlaneInfo();
            new_info.Id = id_box.Text;
            new_info.Type = type_box.Text;
            new_info.Start_station = start_sta_box.Text;
            new_info.End_station = end_sta_box.Text;
            new_info.Start_time = start_time_box.Text;
            new_info.End_time = end_time_box.Text;
            new_info.Tickets = Convert.ToInt32(tickets_box.Text);
            new_info.Price = Convert.ToInt32(price_box.Text);
            // 将新航班数据加入到链表生成新链表
            info_list.AddInfo(new_info);
            // 将新链表中的数据写入航班信息文件
            file.SaveInfoList(info_list, file.Info_file_path);
            MessageBox.Show("添加成功！");
        }
        // “返回”按钮
        private void return_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
