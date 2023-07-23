using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        private Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();
        private const string saveFileName = "bank_accounts.json";
        public Form1()
        {
            InitializeComponent();
            LoadAccountsFromFile();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveAccountsToFile()
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                File.WriteAllText(saveFileName, jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }
        }

        private void LoadAccountsFromFile()
        {
            try
            {
                if (File.Exists(saveFileName))
                {
                    string jsonData = File.ReadAllText(saveFileName);
                    accounts = JsonConvert.DeserializeObject<Dictionary<string, BankAccount>>(jsonData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}");
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
            string accountNumber = txtAccountNumber.Text;
            string owner = txtOwner.Text;

            if (!string.IsNullOrEmpty(accountNumber) && !string.IsNullOrEmpty(owner))
            {
                if (accounts.ContainsKey(accountNumber))
                {
                    MessageBox.Show("Ошибка: счет с таким номером уже существует.");
                    txtAccountNumber.Text = "";
                }
                else
                {
                    accounts.Add(accountNumber, new BankAccount(accountNumber, 0, owner));
                    MessageBox.Show("Счет успешно создан.");
                    txtAccountNumber.Text = "";
                    txtOwner.Text = "";
                    SaveAccountsToFile();
                }
            }
            else
            {
                MessageBox.Show("Ошибка: необходимо ввести номер счета и имя владельца.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber2.Text;
            double amount;
            if (double.TryParse(txtAmount.Text, out amount))
            {
                if (accounts.ContainsKey(accountNumber))
                {
                    MessageBox.Show($"Счет {accountNumber} успешно пополнен на {amount}.");
                    accounts[accountNumber].Deposit(amount);
                    SaveAccountsToFile();
                    txtAccountNumber2.Text = "";
                    txtAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("Ошибка: счет с таким номером не существует.");
                    txtAccountNumber2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ошибка: некорректная сумма для пополнения.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber3.Text;
            double amount;
            if (double.TryParse(txtAmount3.Text, out amount))
            {
                if (accounts.ContainsKey(accountNumber))
                {
                    accounts[accountNumber].Withdraw(amount);
                    MessageBox.Show($"Со счета {accountNumber} снято {amount}.");
                    SaveAccountsToFile();
                    txtAccountNumber3.Text = "";
                    txtAmount3.Text = "";
                }
                else
                {
                    MessageBox.Show("Ошибка: счет с таким номером не существует.");
                    txtAccountNumber3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ошибка: некорректная сумма для снятия.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sourceAccountNumber = txtAccountNumber4.Text;
            string targetAccountNumber = txtTargetAccount4.Text;
            double amount;
            if (double.TryParse(txtAmount4.Text, out amount))
            {
                if (accounts.ContainsKey(sourceAccountNumber) && accounts.ContainsKey(targetAccountNumber))
                {
                    accounts[sourceAccountNumber].Withdraw(amount);
                    accounts[targetAccountNumber].Deposit(amount);
                    SaveAccountsToFile();
                    MessageBox.Show("Перевод успешно выполнен.");
                    txtAccountNumber4.Text = "";
                    txtTargetAccount4.Text = "";
                    txtAmount4.Text = "";
                }
                else
                {
                    MessageBox.Show("Ошибка: один из счетов не существует.");
                    txtAccountNumber4.Text = "";
                    txtTargetAccount4.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ошибка: некорректная сумма для перевода.");
                txtAmount4.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber5.Text;
            if (accounts.ContainsKey(accountNumber))
            {
                BankAccount account = accounts[accountNumber];
                MessageBox.Show($"Информация о счете:\nНомер счета: {account.GetAccountNumber()}\nВладелец счета: {account.GetOwner()}\nТекущий баланс: {account.GetBalance()}");
            }
            else
            {
                MessageBox.Show("Ошибка: счет с таким номером не существует.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber6.Text;

            if (accounts.ContainsKey(accountNumber))
            {
                accounts.Remove(accountNumber);
                MessageBox.Show($"Счет {accountNumber} успешно удален.");
                txtAccountNumber6.Text = "";
                SaveAccountsToFile();
            }
            else
            {
                MessageBox.Show("Ошибка: счет с таким номером не существует.");
                txtAccountNumber6.Text = "";
            }

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }
    }
}
