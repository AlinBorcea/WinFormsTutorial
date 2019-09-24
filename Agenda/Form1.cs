using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Functia care este apelata atunci cand dati click pe buton
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Extragerea textului din TextBox-uri. Textul este de tip String.
            String Name = nameTextBox.Text;
            String Phone = phoneNumberTextBox.Text;

            // Crearea unui nou contact
            Contact contact = new Contact(Name, Phone);

            // Afisarea contactului in textbox-ul Result
            Result.Text = "Nume: " + contact.Name + " " + "Numar: " + contact.Phone; 
        }
    }
}
