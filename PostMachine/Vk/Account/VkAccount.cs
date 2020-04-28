using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMachine
{
    public class VkAccount
    {
        // TODO:
        // Сохранение аккаунтов
        // Выгрузка аккаунтов
        public static List<VkAccount> Accounts { get; private set; } = new List<VkAccount>();
        // ID который будет присвоен след. аккаунту
        // TODO: Выгружать данные о нем при включении софта
        // TODO: Сохранять данные о нем при создании аккаунта
        private static Int32 CurrentAvailableID = 0;

        // Данный каждого аккаунта
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Int32 id { get; private set; } = -1;
        public Item ConnectedItem { get; private set; } = null;

        public VkAccount() { }

        public static void AddAccount(string login, string password)
        {
            VkAccount account = new VkAccount();
            account.Login = login;
            account.Password = password;
            account.id = CurrentAvailableID++;
            Accounts.Add(account);
        }

        public void ConnectItem(Item item) => this.ConnectedItem = item;
    }
}
