using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IBusinessLogic
    {
        bool Click(int user_id, int click_nr);
       // bool registration(User user);
        bool login(string email, string password);
        bool buyItem(int item_id, int user_id);
    }
}
