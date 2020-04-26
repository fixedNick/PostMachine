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
        private static List<VkAccount> Accounts = new List<VkAccount>();
        // ID который будет присвоен след. аккаунту
        // TODO: Выгружать данные о нем при включении софта
        // TODO: Сохранять данные о нем при создании аккаунта
        private static Int32 CurrentAvailableID = 0;

        // Данный каждого аккаунта
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Int32 id { get; private set; } = -1;
        private List<Item> Items = new List<Item>();

        public VkAccount(string login, string password)
        {
            this.Login = login; 
            this.Password = password;
            this.id = CurrentAvailableID++;
        }
    }
}
