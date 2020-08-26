/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System;
using System.Windows.Forms;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 用户注册
 
描述:实现新用户在本系统的注册，是进入本系统的入口 
 
********************************************************/

namespace 航班订票系统
{
    // ResForm:注册窗体   
    public partial class ResForm : Form
    {
        private UserList common_user_list;
        private readonly FileOpearte file;
        public ResForm()
        {
            file = new FileOpearte();
            InitializeComponent();
        }
        private void ResForm_Load(object sender, EventArgs e)
        {

            common_user_list = new UserList();
            // 读取用户文件中已有的用户名和密码至链表
            file.LoadUserList(common_user_list, file.Common_file_path);
        }
        // “提交”按钮
        private void submit_button_Click(object sender, EventArgs e)
        {
            if (Regular.IsNull(res_name_box.Text) || Regular.IsNull(res_pwd_box.Text))
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }
            else if (!Regular.IsMatchUsers(res_name_box.Text))
            {
                MessageBox.Show("用户名必须为中文、英文、数字和下划线的组合");
                return;
            }
            else if (!Regular.IsMatchUsers(res_pwd_box.Text))
            {
                MessageBox.Show("密码必须为中文、英文、数字和下划线的组合");
                return;
            }
            // 根据链表中的数据判断用户名是否存在
            else if (common_user_list.IsUserExist(res_name_box.Text))
            {
                MessageBox.Show("该用户名已经被注册！");
                return;
            }
            else
            {
                User new_user = new User();
                new_user.Name = res_name_box.Text;
                new_user.Pwd = res_pwd_box.Text;
                // 将新用户数据加入到链表生成新链表
                common_user_list.AddUser(new_user);
                // 将新链表中的数据写入用户文件
                file.SaveUserList(common_user_list, file.Common_file_path);
                MessageBox.Show("注册成功！");
                common_user_list.DeleteList();
                this.Hide();
                this.Owner.Show();
                this.Close();
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