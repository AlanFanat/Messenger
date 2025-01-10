using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Messenger
{
    public partial class FormMessanger : Form
    {
        private User currentUser { get; set; } //Пользователь текущего сеанса
        private User companionUser { get; set; } //Пользователь Собеседник
        private List<User> users { get; set; } //Список пользователей
        public FormMessanger(User user, List<User> users)
        {
            InitializeComponent();
            currentUser = user;
            this.users = users;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //загружаю диалоги
            UploadDialogs();

            //Задаю интерфейс так как пользователь выбран
            UpdateCurrentUserView();

            //заполняю меню выбора пользователя из списка
            FillMenuItem();

            //При нажатии на строку DGV выбирается вся строка, чтобы легче подписать на это событие
            dataGridViewDialogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDialogs.SelectionChanged += DataGridViewDialogs_SelectionChanged;            
        }

        private void UploadDialogs()
        {
            currentUser.UploadDialogs(FileManager.GetDialogs(currentUser.Id));
        }

        //Заполнить выпадающее меню выбора пользователя из списка
        private void FillMenuItem()
        {
            foreach (User user in users)
            {
                //создаю строку выпадающего меню с именем пользователя 
                ToolStripMenuItem userMenuItem = new ToolStripMenuItem(user.Name);
                userMenuItem.Tag = user;
                userMenuItem.Click += UsersMenuItem_Click;

                //заношу строку с именем пользователя в выпадающее меню
                toolStripMenuItem1Users.DropDownItems.Add(userMenuItem);
            }
        }

        #region Отправка сообщения
        private void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {
            string messageText = textBoxInputMessage.Text;
            Message message = new Message(currentUser.Id, messageText);
            currentUser.AddMessage(companionUser.Id, message);
            AddMessageOnDialogArea(messageText);
            textBoxInputMessage.Clear();
        }

        private void AddMessageOnDialogArea(string messageText)
        {
            dataGridViewDialogArea.Rows.Add("", messageText);
        }
        #endregion

        //Отобразить список диалогов
        private void FillDataGridViewDialogs()
        {
            dataGridViewDialogs.Rows.Clear();
            foreach (User user in users.Where(user => user != currentUser))
            {               
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewDialogs, user.Name);
                row.Tag = user;
                dataGridViewDialogs.Rows.Add(row);               
            }
            dataGridViewDialogs.ClearSelection();
        }

        //показать элементы ввода текста, кнопку отправить, поле сообщений
        private void ShowElements()
        {
            textBoxInputMessage.Visible = true;
            buttonSendMessage.Visible = true;
            dataGridViewDialogArea.Visible = true;
        }

        //спрятать элементы ввода текста, кнопку отправить, поле сообщений
        private void HideElements()
        {
            textBoxInputMessage.Visible = false;
            buttonSendMessage.Visible = false;
            dataGridViewDialogArea.Visible = false;
        }
    
        //изменить вид элементов при смене пользователя
        private void UpdateCurrentUserView()
        {
            companionUser = null;
            labelCurrentUser.Text = currentUser.Name;
            labelCompanionUser.Text = "Собеседник не выбран";
            FillDataGridViewDialogs();
            HideElements();                 
        }

        //Изменить вид элементов при смене собеседника
        private void UpdateCompanionUserView()
        {

            dataGridViewDialogArea.Rows.Clear();

            labelCompanionUser.Text = companionUser.Name;

            if(!currentUser.Dialogs.ContainsKey(companionUser.Id)) //Изменить когда добавишь базу диалогов
            {
                Dialog dialog = new Dialog(currentUser.Id, companionUser.Id);
                currentUser.Dialogs.Add(companionUser.Id, dialog);
            }

            ShowElements();
            FillDataGridViewDialogArea(); 
        }

        //заполнить поле сообщений
        private void FillDataGridViewDialogArea()
        {
            foreach (Message message in currentUser.Dialogs[companionUser.Id])
            {
                if(message.UserId == currentUser.Id)
                {
                    dataGridViewDialogArea.Rows.Add("", message.Text);
                }
                else
                {
                    dataGridViewDialogArea.Rows.Add(message.Text, "");
                }
            }

        }

        //Метод срабатываемый при выборе другого диалога
        private void DataGridViewDialogs_SelectionChanged(object sender, EventArgs e)
        {
            SaveDialog();
            companionUser = null;
            //Если выбран какой-то диалог, то меняем или ставим (если это первый раз) Пользователя Собеседника
            if (dataGridViewDialogs.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDialogs.SelectedRows[0];
                User selectedUser = selectedRow.Tag as User;
                if (selectedUser != null)
                {
                    companionUser = selectedUser;
                    UpdateCompanionUserView();
                }
            }
        }

        //при нажатии на какого-то пользователя из выпадающего списка пользователя,
        //т.е. при выборе пользователя текущего сеанса
        private void UsersMenuItem_Click(object sender, EventArgs e)
        {
            SaveDialog();
            ToolStripMenuItem userMenuItem = sender as ToolStripMenuItem;
            //Установили/поменяли пользователя текущего сеанса
            currentUser = userMenuItem.Tag as User;
            UploadDialogs();
            UpdateCurrentUserView();
        }
        private void SaveDialog()
        {
            if (companionUser != null && companionUser != currentUser)
            {
                FileManager.SerializeDialog(currentUser.Dialogs[companionUser.Id]);
            }
        }
        private void FormMessanger_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveDialog();
            Application.Exit();
        }
    }
}
