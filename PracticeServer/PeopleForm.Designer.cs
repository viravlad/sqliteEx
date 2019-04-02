using System;

namespace PracticeServer
{
    partial class PeopleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(104, 73);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(102, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Add Person";
            this.firstNameLabel.UseMnemonic = false;
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(106, 133);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(131, 20);
            this.firstNameBox.TabIndex = 4;
            this.firstNameBox.TextChanged += new System.EventHandler(this.firstNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(108, 216);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(129, 20);
            this.lastNameBox.TabIndex = 6;
            this.lastNameBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.Location = new System.Drawing.Point(110, 267);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(127, 33);
            this.addPersonBtn.TabIndex = 7;
            this.addPersonBtn.Text = "Add Person";
            this.addPersonBtn.UseVisualStyleBackColor = true;
            this.addPersonBtn.Click += new System.EventHandler(this.addPersonBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(110, 320);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(127, 33);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "Refresh List";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(533, 115);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(165, 173);
            this.listBox.TabIndex = 9;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.addPersonBtn);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "PeopleForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Button addPersonBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ListBox listBox;
    }
}

