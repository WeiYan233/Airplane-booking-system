/******************************************************** 
                      
 
                 项目名称：航班订票系统                             
             

*********************************************************/

using System.Text.RegularExpressions;

/******************************************************** 

项目名称: 航班订票系统

模块名称: 输入格式判断类
 
描述: 根据正则表达式判断输入格式是否符合实际
 
********************************************************/

namespace 航班订票系统
{
    // “输入格式判断”
    public class Regular
    {
        // 判断文本框输入是否为空
        public static bool IsNull(string input)
        {
            string pattern = @"^[\s]*$";
            return Regex.IsMatch(input, pattern);
        }
        // 验证用户名和密码是否符合格式
        public static bool IsMatchUsers(string input)
        {
            string pattern = @"^[\u4E00-\u9FA5A-Za-z0-9_]+$";
            return Regex.IsMatch(input, pattern);
        }
        // 验证地名是否符合格式
        public static bool IsMatchChina(string input)
        {
            string pattern = @"^[\u4E00-\u9FA5A-Za-z]+$";
            return Regex.IsMatch(input, pattern);
        }
        // 验证身份证号码是否符合格式
        public static bool IsMatchPersonId(string input)
        {
            string pattern = @"^[0-9X]{18}$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
