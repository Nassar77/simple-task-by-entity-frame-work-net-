namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Project_GV = new DataGridView();
            Search_bt = new TextBox();
            Search_Btn = new Button();
            Rest_btn = new Button();
            Fname_txt = new TextBox();
            Lname_txt = new TextBox();
            Ssn_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Add_bt = new Button();
            ((System.ComponentModel.ISupportInitialize)Project_GV).BeginInit();
            SuspendLayout();
            // 
            // Project_GV
            // 
            Project_GV.AccessibleName = "";
            Project_GV.BackgroundColor = SystemColors.ButtonHighlight;
            Project_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Project_GV.Location = new Point(12, 132);
            Project_GV.Name = "Project_GV";
            Project_GV.Size = new Size(447, 227);
            Project_GV.TabIndex = 0;
            // 
            // Search_bt
            // 
            Search_bt.Location = new Point(12, 83);
            Search_bt.Name = "Search_bt";
            Search_bt.Size = new Size(138, 23);
            Search_bt.TabIndex = 1;
            // 
            // Search_Btn
            // 
            Search_Btn.Location = new Point(195, 83);
            Search_Btn.Name = "Search_Btn";
            Search_Btn.Size = new Size(75, 23);
            Search_Btn.TabIndex = 2;
            Search_Btn.Text = "Search";
            Search_Btn.UseVisualStyleBackColor = true;
            Search_Btn.Click += button1_Click;
            // 
            // Rest_btn
            // 
            Rest_btn.Location = new Point(276, 83);
            Rest_btn.Name = "Rest_btn";
            Rest_btn.Size = new Size(75, 23);
            Rest_btn.TabIndex = 3;
            Rest_btn.Text = "Reset";
            Rest_btn.UseVisualStyleBackColor = true;
            Rest_btn.Click += Rest_btn_Click;
            // 
            // Fname_txt
            // 
            Fname_txt.Location = new Point(578, 132);
            Fname_txt.Name = "Fname_txt";
            Fname_txt.Size = new Size(100, 23);
            Fname_txt.TabIndex = 4;
            // 
            // Lname_txt
            // 
            Lname_txt.Location = new Point(578, 161);
            Lname_txt.Name = "Lname_txt";
            Lname_txt.Size = new Size(100, 23);
            Lname_txt.TabIndex = 5;
            // 
            // Ssn_txt
            // 
            Ssn_txt.Location = new Point(578, 190);
            Ssn_txt.Name = "Ssn_txt";
            Ssn_txt.Size = new Size(100, 23);
            Ssn_txt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 140);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Fname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(514, 169);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Lname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 198);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 11;
            label3.Text = "Ssn";
            // 
            // Add_bt
            // 
            Add_bt.Location = new Point(588, 232);
            Add_bt.Name = "Add_bt";
            Add_bt.Size = new Size(75, 23);
            Add_bt.TabIndex = 14;
            Add_bt.Text = "Add";
            Add_bt.UseVisualStyleBackColor = true;
            Add_bt.Click += Add_bt_Click;
            // 
            // Form1
            // 
            AccessibleName = "Project_GV";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add_bt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ssn_txt);
            Controls.Add(Lname_txt);
            Controls.Add(Fname_txt);
            Controls.Add(Rest_btn);
            Controls.Add(Search_Btn);
            Controls.Add(Search_bt);
            Controls.Add(Project_GV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Project_GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Project_GV;
        private TextBox Search_bt;
        private Button Search_Btn;
        private Button Rest_btn;
        private TextBox Fname_txt;
        private TextBox Lname_txt;
        private TextBox Ssn_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Add_bt;
    }
}
