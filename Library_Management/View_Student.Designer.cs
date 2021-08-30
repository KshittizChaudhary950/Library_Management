
namespace Library_Management
{
    partial class View_Student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SnametextBox = new System.Windows.Forms.TextBox();
            this.senrolltextBox = new System.Windows.Forms.TextBox();
            this.DepartmenttextBox = new System.Windows.Forms.TextBox();
            this.SemstertextBox = new System.Windows.Forms.TextBox();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox.Location = new System.Drawing.Point(499, 27);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(140, 29);
            this.searchtextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(670, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.Aqua;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(436, 421);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(87, 37);
            this.Updatebutton.TabIndex = 3;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.Aqua;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(567, 421);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(93, 37);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.Aqua;
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(687, 421);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 37);
            this.Backbutton.TabIndex = 5;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enrollment No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // SnametextBox
            // 
            this.SnametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnametextBox.Location = new System.Drawing.Point(125, 298);
            this.SnametextBox.Name = "SnametextBox";
            this.SnametextBox.Size = new System.Drawing.Size(132, 22);
            this.SnametextBox.TabIndex = 12;
            // 
            // senrolltextBox
            // 
            this.senrolltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senrolltextBox.Location = new System.Drawing.Point(402, 301);
            this.senrolltextBox.Name = "senrolltextBox";
            this.senrolltextBox.Size = new System.Drawing.Size(121, 22);
            this.senrolltextBox.TabIndex = 13;
            // 
            // DepartmenttextBox
            // 
            this.DepartmenttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmenttextBox.Location = new System.Drawing.Point(623, 302);
            this.DepartmenttextBox.Name = "DepartmenttextBox";
            this.DepartmenttextBox.Size = new System.Drawing.Size(139, 22);
            this.DepartmenttextBox.TabIndex = 14;
            // 
            // SemstertextBox
            // 
            this.SemstertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemstertextBox.Location = new System.Drawing.Point(118, 358);
            this.SemstertextBox.Name = "SemstertextBox";
            this.SemstertextBox.Size = new System.Drawing.Size(139, 22);
            this.SemstertextBox.TabIndex = 15;
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContacttextBox.Location = new System.Drawing.Point(402, 361);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(112, 22);
            this.ContacttextBox.TabIndex = 16;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailtextBox.Location = new System.Drawing.Point(623, 358);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(139, 22);
            this.EmailtextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDnumericUpDown.Location = new System.Drawing.Point(76, 25);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(49, 29);
            this.IDnumericUpDown.TabIndex = 19;
            // 
            // View_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 470);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.ContacttextBox);
            this.Controls.Add(this.SemstertextBox);
            this.Controls.Add(this.DepartmenttextBox);
            this.Controls.Add(this.senrolltextBox);
            this.Controls.Add(this.SnametextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Student";
            this.Load += new System.EventHandler(this.View_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SnametextBox;
        private System.Windows.Forms.TextBox senrolltextBox;
        private System.Windows.Forms.TextBox DepartmenttextBox;
        private System.Windows.Forms.TextBox SemstertextBox;
        private System.Windows.Forms.TextBox ContacttextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
    }
}