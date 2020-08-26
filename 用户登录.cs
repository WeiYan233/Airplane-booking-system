/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System;
using System.Windows.Forms;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 用户登录
 
描述:实现用户在本系统的登录与注册，是进入本系统的入口 
 
********************************************************/

namespace 航班订票系统
{
    // LoginForm:登录窗体
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        // “注册”按钮
        private void res_button_Click(object sender, EventArgs e)
        {
            ResForm res_form = new ResForm();
            res_form.Show();
            res_form.Owner = this;
            this.Hide();
        }
        // “登录”按钮
        private void login_button_Click(object sender, EventArgs e)
        {
            if (Regular.IsNull(login_name_box.Text) || Regular.IsNull(login_pwd_box.Text))
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }
            else if (login_type_box.SelectedIndex == -1)
            {
                MessageBox.Show("请选择登录类型!");
                return;
            }
            else if (login_type_box.SelectedItem.ToString() == "普通用户")
            {
                UserList user_list = new UserList();
                FileOpearte file = new FileOpearte();
                // 读取用户文件中已有的用户名和密码至链表
                file.LoadUserList(user_list, file.Common_file_path);
                // 根据链表中的数据判断用户名和密码是否正确
                if (user_list.IsUserTrue(login_name_box.Text, login_pwd_box.Text))
                {
                    user_list.DeleteList();
                    CommonUserForm common_form = new CommonUserForm();
                    // 接收登录系统的用户名
                    common_form.track_user = login_name_box.Text;
                    common_form.Owner = this;
                    this.Hide();
                    common_form.Show();
                }
                else
                {
                    user_list.DeleteList();
                    MessageBox.Show("用户名或密码不正确！");
                    return;
                }
            }
            else if (login_type_box.SelectedItem.ToString() == "管理员")
            {
                UserList admin_list = new UserList();
                FileOpearte file = new FileOpearte();
                // 读取用户文件中已有的用户名和密码至链表
                file.LoadUserList(admin_list, file.Admin_file_path);
                // 根据链表中的数据判断用户名和密码是否正确
                if (admin_list.IsUserTrue(login_name_box.Text, login_pwd_box.Text))
                {
                    admin_list.DeleteList();
                    AdminUserForm new_admin_form = new AdminUserForm();
                    new_admin_form.Owner = this;
                    this.Hide();
                    new_admin_form.Show();
                }
                else
                {
                    admin_list.DeleteList();
                    MessageBox.Show("用户名或密码不正确！");
                    return;
                }
            }
        }
    }
}
