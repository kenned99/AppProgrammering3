using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IUserControl
    {
        bool firstClick(int user_id, int count);
        bool updateClick(int user_id, int count);
        //bool AddUser(User user);
        bool check_Login(string email, string password);
        bool addItem(int item_id, int user_id);
    }
}
