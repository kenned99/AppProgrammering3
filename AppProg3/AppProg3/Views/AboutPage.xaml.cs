using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Interfaces;
using DASQL;
using CoreAppInterface;
using Business_Logic;


namespace AppProg3.Views
{
    public partial class AboutPage : ContentPage
    {

        SQLController sqlc = new SQLController();
        FrontEndInterface busic = new Business();

        public AboutPage()
        {
            InitializeComponent();
            User user = Test();
            
        }
        
        User Test()
        {
            User user = new User() { UserType = UserType.Chef, Username = "Coom", Password = "Password1", Email = "mail.fag" };
            busic.CreateUserRandom(user);            
            return user;
        }
        
    }
}