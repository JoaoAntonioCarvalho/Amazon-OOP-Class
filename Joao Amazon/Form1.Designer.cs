namespace Joao_Amazon
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
            txtDescription = new TextBox();
            txtPID = new TextBox();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtSize = new TextBox();
            btnRemove = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            lblSize = new Label();
            lblProductID = new Label();
            lblDescription = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            listView = new ListView();
            btnCount = new Button();
            btnExit = new Button();
            lblCount = new Label();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(146, 109);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 0;
            // 
            // txtPID
            // 
            txtPID.Location = new Point(146, 28);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(100, 23);
            txtPID.TabIndex = 1;
            txtPID.TextChanged += txtPID_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(146, 150);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 3;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(146, 193);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(100, 23);
            txtSize.TabIndex = 4;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(117, 318);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(215, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(71, 196);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(27, 15);
            lblSize.TabIndex = 8;
            lblSize.Text = "Size";
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(55, 31);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(63, 15);
            lblProductID.TabIndex = 9;
            lblProductID.Text = "Product ID";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(51, 112);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(51, 70);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "Product Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(59, 153);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Category";
            // 
            // listView
            // 
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(363, 28);
            listView.Name = "listView";
            listView.Size = new Size(765, 195);
            listView.TabIndex = 13;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(23, 361);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(75, 23);
            btnCount.TabIndex = 14;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(117, 361);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(215, 365);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(91, 15);
            lblCount.TabIndex = 16;
            lblCount.Text = "Product Count: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 416);
            Controls.Add(lblCount);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(listView);
            Controls.Add(lblCategory);
            Controls.Add(lblProductName);
            Controls.Add(lblDescription);
            Controls.Add(lblProductID);
            Controls.Add(lblSize);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(txtSize);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(txtPID);
            Controls.Add(txtDescription);
            Name = "Form1";
            Text = "Amazon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtPID;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtSize;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnClear;
        private Label lblSize;
        private Label lblProductID;
        private Label lblDescription;
        private Label lblProductName;
        private Label lblCategory;
        private ListView listView;
        private Button btnCount;
        private Button btnExit;
        private Label lblCount;
    }
}
