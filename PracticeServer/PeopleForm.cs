using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PracticeServer.PersonModel;

namespace PracticeServer
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public PeopleForm()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people.Add(new PersonModel {FirstName = "Vira" , LastName = "Vlad" });
            people.Add(new PersonModel { FirstName = "Man", LastName = "Boy" });

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listBox.DataSource = null;
            listBox.DataSource = people;
            listBox.DisplayMember = "FullName";
        }

       

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.FirstName = firstNameBox.Text;
            p.LastName = lastNameBox.Text;

            people.Add(p);
            WireUpPeopleList();

            firstNameBox.Text = "";
            lastNameBox.Text = "";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
