using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public class BankAccount
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public string Owner { get; private set; }

        public BankAccount(string accountNumber, double balance, string owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
        }
        public void SaveToFile(string filename)
        {
            string jsonData = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filename, jsonData);
        }
        public static BankAccount LoadFromFile(string filename)
        {
            try
            {
                string jsonData = File.ReadAllText(filename);
                return JsonConvert.DeserializeObject<BankAccount>(jsonData);
            }
            catch (FileNotFoundException)
            {
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}");
                return null;
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Пополнение прошло успешно. Новый баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Ошибка: сумма для пополнения должна быть положительной.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Снятие прошло успешно. Новый баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Ошибка: недостаточно средств на счете или указана некорректная сумма.");
            }
        }

        public double GetBalance()
        {
            return Balance;
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        public string GetOwner()
        {
            return Owner;
        }
    }
}
