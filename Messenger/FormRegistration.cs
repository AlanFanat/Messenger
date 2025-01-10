using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class FormRegistration : Form
    {
        private List<User> users; //пользователи
        public FormRegistration()
        {
            InitializeComponent();
        }
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            users = FileManager.GetUsers();

            TuneComboBox();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (CheckNormName())
            {
                User user = new User(textBoxRegUserName.Text);
                users.Add(user);
                FileManager.AddUser(user);
                ShowMessengerForm(user);
            }
            else
            {
                MessageBox.Show("Нельзя использовать \'*\'!!!");
            }
        }
        //проверка имени
        private bool CheckNormName()
        {
            return !textBoxRegUserName.Text.Contains("*");
        }
        //переход на основное окно
        private void ShowMessengerForm(User user)
        {
            FormMessanger formMessanger = new FormMessanger(user, users);
            formMessanger.Show();
            this.Hide();
        }
        //настройка комбобокс
        private void TuneComboBox()
        {
            comboBoxUserChoise.DisplayMember = "Name";
            foreach (User user in users)
            {
                comboBoxUserChoise.Items.Add(user);
            }
        }

        private void comboBoxUserChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = comboBoxUserChoise.SelectedItem as User;
            ShowMessengerForm(selectedUser);
        }
    }
}
